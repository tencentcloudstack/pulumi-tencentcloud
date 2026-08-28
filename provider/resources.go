// Copyright 2016-2024, Pulumi Corporation.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

package tencentcloud

import (
	"context"
	"fmt"
	"path/filepath"

	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/info"

	// Allow embedding bridge-metadata.json in the provider.
	_ "embed"

	sdkSchema "github.com/hashicorp/terraform-plugin-sdk/v2/helper/schema"
	pftfbridge "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/pf/tfbridge"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"

	// Replace this provider with the provider you are bridging.
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud"
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud/framework"

	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/pkg/version"
)

const (
	mainPkg = "tencentcloud"
	mainMod = "index" // the tencentcloud module
)

//go:embed cmd/pulumi-resource-tencentcloud/bridge-metadata.json
var metadata []byte

// removeDeprecatedDlcDescribeDataEngineUiURL strips the deprecated "ui_u_r_l"
// attribute from the tencentcloud_dlc_describe_data_engine data source.
//
// The upstream provider declares both the deprecated "ui_u_r_l" and its
// replacement "ui_url" on the same nested object. Both survive schema
// generation as distinct properties, and the Python codegen snake-cases the
// two names onto the same __init__ parameter, producing
// "SyntaxError: duplicate argument 'ui_url'" and breaking compilation of the
// entire Python SDK. The deprecated attribute is redundant (upstream marks it
// "Use ui_url instead") and is removed at the source until the upstream field
// is dropped.
func removeDeprecatedDlcDescribeDataEngineUIURL(p *sdkSchema.Provider) {
	ds, ok := p.DataSourcesMap["tencentcloud_dlc_describe_data_engine"]
	if !ok {
		return
	}
	dataEngine, ok := ds.Schema["data_engine"]
	if !ok {
		return
	}
	elem, ok := dataEngine.Elem.(*sdkSchema.Resource)
	if !ok {
		return
	}
	delete(elem.Schema, "ui_u_r_l")
}

// Provider returns additional overlaid schema and metadata associated with the provider.
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform providers:
	// - sdkProvider is the SDKv2 implementation hosting the majority of resources.
	// - pfProvider is the Plugin Framework implementation for migrated resources;
	//   it takes the SDKv2 provider as input to share configuration and meta,
	//   mirroring the upstream muxed main.go.
	ctx := context.Background()
	sdkProvider := tencentcloud.Provider()
	removeDeprecatedDlcDescribeDataEngineUIURL(sdkProvider)
	// pfProvider is the Plugin Framework implementation for migrated resources;
	// it takes the SDKv2 provider as input to share configuration and meta,
	// mirroring the upstream muxed main.go.
	pfProvider := framework.NewProvider(sdkProvider)
	p := pftfbridge.MuxShimWithPF(ctx, shimv2.NewProvider(sdkProvider), pfProvider)

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:                 p,
		Name:              "tencentcloud",
		Version:           version.Version,
		DisplayName:       "TencentCloud",
		Publisher:         "TencentCloudStack",
		LogoURL:           "https://avatars.githubusercontent.com/u/68363092",
		PluginDownloadURL: "github://api.github.com/tencentcloudstack",
		Description:       "A Pulumi package for creating and managing Tencent Cloud resources.",
		Keywords:          []string{"pulumi", "tencentcloud", "category/cloud"},
		License:           "Apache-2.0",
		Homepage:          "https://www.pulumi.com",
		Repository:        "https://github.com/tencentcloudstack/pulumi-tencentcloud",
		GitHubOrg:         "tencentcloudstack",
		MetadataInfo:      tfbridge.NewProviderMetadata(metadata),
		Config: map[string]*tfbridge.SchemaInfo{
			"region": {
				Default: &tfbridge.DefaultInfo{
					EnvVars: []string{"TENCENTCLOUD_REGION"},
				},
			},
		},
		Resources:   info.GetResourceInfo(mainPkg),
		DataSources: info.GetDataSourceInfo(mainPkg),
		JavaScript: &tfbridge.JavaScriptInfo{
			Dependencies: map[string]string{
				"@pulumi/pulumi": "^3.0.0",
			},
			DevDependencies: map[string]string{
				"@types/node": "^10.0.0", // so we can access strongly typed node definitions.
				"@types/mime": "^2.0.0",
			},
			PackageName: "@tencentcloud_iac/pulumi",
			// The nodejs codegen lowercases module directory names
			// (getChildMod -> strings.ToLower). The "Config" module (cloud
			// audit / config service resources) would collide with the
			// reserved provider "config" module directory, tripping a
			// "duplicate file: config/index.ts" assertion. Map it to a
			// distinct directory name to avoid the case-folding collision.
			ModuleToPackage: map[string]string{
				"Config": "configservice",
			},
		},
		Python: &tfbridge.PythonInfo{
			Requires: map[string]string{
				"pulumi": ">=3.0.0,<4.0.0",
			},
			PackageName: "tencentcloud_iac_pulumi",
		},
		Golang: &tfbridge.GolangInfo{
			ImportBasePath: filepath.Join(
				fmt.Sprintf("github.com/tencentcloudstack/pulumi-%[1]s/sdk/", mainPkg),
				tfbridge.GetModuleMajorVersion(version.Version),
				"go",
				mainPkg,
			),
			GenerateResourceContainerTypes: true,
		},
		CSharp: &tfbridge.CSharpInfo{
			PackageReferences: map[string]string{
				"Pulumi": "3.*",
			},
			RootNamespace: "TencentCloudIAC.PulumiPackage",
			// The "Config" module (cloud audit resources) generates the
			// child namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Config,
			// which collides with the provider's static Config class in the
			// parent namespace (C# forbids a type and a child namespace sharing
			// a name in the same scope; error CS0101). Map the module to a
			// distinct namespace.
			Namespaces: map[string]string{
				"Config": "ConfigService",
			},
		},
	}

	// MustComputeTokens maps all resources and datasources from the upstream provider into Pulumi.
	//
	// tokens.SingleModule puts every upstream item into your provider's main module.
	//
	// You shouldn't need to override anything, but if you do, use the [tfbridge.ProviderInfo.Resources]
	// and [tfbridge.ProviderInfo.DataSources].
	// prov.MustComputeTokens(tokens.SingleModule("tencentcloud_", mainMod,
	// 	tokens.MakeStandard(mainPkg)))

	// prov.MustApplyAutoAliases()
	prov.SetAutonaming(255, "-")

	return prov
}
