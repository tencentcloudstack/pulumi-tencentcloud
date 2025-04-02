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
	"fmt"
	"path/filepath"

	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/info"

	// Allow embedding bridge-metadata.json in the provider.
	_ "embed"

	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"

	// Replace this provider with the provider you are bridging.
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud"

	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/pkg/version"
)

const (
	mainPkg = "tencentcloud"
	mainMod = "index" // the tencentcloud module
)

//go:embed cmd/pulumi-resource-tencentcloud/bridge-metadata.json
var metadata []byte

// Provider returns additional overlaid schema and metadata associated with the provider.
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(tencentcloud.Provider())

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
