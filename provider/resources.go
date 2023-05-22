// Copyright 2016-2018, Pulumi Corporation.
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
	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/info"
	"path/filepath"

	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	shimv2 "github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfshim/sdk-v2"
	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/pkg/version"
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud"
)

const (
	mainPkg = "tencentcloud"
	mainMod = "index" // the tencentcloud module
)

// Provider returns additional overlaid schema and metadata associated with the provider.
//go generate:
func Provider() tfbridge.ProviderInfo {
	// Instantiate the Terraform provider
	p := shimv2.NewProvider(tencentcloud.Provider())

	// Create a Pulumi provider mapping
	prov := tfbridge.ProviderInfo{
		P:                 p,
		Name:              "tencentcloud",
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

	prov.SetAutonaming(255, "-")

	return prov
}
