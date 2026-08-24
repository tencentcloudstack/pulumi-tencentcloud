package info

import (
	"context"

	"github.com/hashicorp/terraform-plugin-framework/datasource"
	"github.com/hashicorp/terraform-plugin-framework/resource"
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/info/transform"
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud"
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud/framework"
)

type ResourceOutput struct {
	Key          string            `json:"key"`
	Module       string            `json:"module"`
	Resource     string            `json:"resource"`
	CsharpAlters map[string]string `json:"csharp_alters,omitempty"`
}

type DataSourceOutput struct {
	Key          string            `json:"key"`
	Module       string            `json:"module"`
	DataSource   string            `json:"data_source"`
	CsharpAlters map[string]string `json:"csharp_alters,omitempty"`
}

type FilterFunc func(resource string) bool

func skipResource(resource string, filter FilterFunc) bool {
	return filter(resource)
}

func GetResourceOutput() []*ResourceOutput {
	p := tencentcloud.Provider()
	resourceOutputs := make([]*ResourceOutput, 0, len(p.ResourcesMap))

	// skip the resources whose document cannot be generated correctly
	skippedResources := map[string]struct{}{
		"tencentcloud_audit": {},
	}
	skipFilter := func(resource string) bool {
		_, exists := skippedResources[resource]
		return exists
	}

	for k, v := range p.ResourcesMap {
		if v.DeprecationMessage != "" || skipResource(k, skipFilter) {
			continue
		}
		module, entity := transform.ResolveModuleEntity(k)
		resourceOutputs = append(resourceOutputs, &ResourceOutput{
			Key:          k,
			Module:       transform.ToPascal(module),
			Resource:     transform.ToPascal(entity),
			CsharpAlters: transform.GetConflictFieldOfCsharpModule(k, v.Schema),
		})
	}

	// Framework-side resources are enumerated from the Plugin Framework provider.
	// Tokens already present on the SDKv2 side win (mirrors MuxShimWithPF semantics).
	sdkTokens := make(map[string]struct{}, len(resourceOutputs))
	for i := range resourceOutputs {
		sdkTokens[resourceOutputs[i].Key] = struct{}{}
	}
	for _, out := range frameworkResourceOutputs() {
		if _, dup := sdkTokens[out.Key]; dup {
			continue
		}
		resourceOutputs = append(resourceOutputs, out)
	}
	return resourceOutputs
}

// frameworkResourceOutputs enumerates resources served by the Plugin Framework
// side of the upstream muxed provider.
func frameworkResourceOutputs() []*ResourceOutput {
	pf := framework.NewProvider(tencentcloud.Provider())
	var outputs []*ResourceOutput
	for _, factory := range pf.Resources(context.Background()) {
		res := factory()
		var req resource.MetadataRequest
		var resp resource.MetadataResponse
		res.Metadata(context.Background(), req, &resp)
		if resp.TypeName == "" {
			continue
		}
		module, entity := transform.ResolveModuleEntity(resp.TypeName)
		outputs = append(outputs, &ResourceOutput{
			Key:      resp.TypeName,
			Module:   transform.ToPascal(module),
			Resource: transform.ToPascal(entity),
		})
	}
	return outputs
}

func GetDataSourceOutput() []*DataSourceOutput {
	p := tencentcloud.Provider()
	dataSourceOutputs := make([]*DataSourceOutput, 0, len(p.DataSourcesMap))
	for k, v := range p.DataSourcesMap {
		if v.DeprecationMessage != "" {
			continue
		}
		module, entity := transform.ResolveModuleEntity(k)
		dataSourceOutputs = append(dataSourceOutputs, &DataSourceOutput{
			Key:    k,
			Module: transform.ToPascal(module),
			// DataSource entity should start with prefix `get`
			DataSource:   "get" + transform.ToPascal(entity),
			CsharpAlters: transform.GetConflictFieldOfCsharpModule(k, v.Schema),
		})
	}

	// Framework-side data sources are enumerated from the Plugin Framework provider.
	// Tokens already present on the SDKv2 side win (mirrors MuxShimWithPF semantics).
	sdkTokens := make(map[string]struct{}, len(dataSourceOutputs))
	for i := range dataSourceOutputs {
		sdkTokens[dataSourceOutputs[i].Key] = struct{}{}
	}
	for _, out := range frameworkDataSourceOutputs() {
		if _, dup := sdkTokens[out.Key]; dup {
			continue
		}
		dataSourceOutputs = append(dataSourceOutputs, out)
	}
	return dataSourceOutputs
}

// frameworkDataSourceOutputs enumerates data sources served by the Plugin
// Framework side of the upstream muxed provider.
func frameworkDataSourceOutputs() []*DataSourceOutput {
	pf := framework.NewProvider(tencentcloud.Provider())
	var outputs []*DataSourceOutput
	for _, factory := range pf.DataSources(context.Background()) {
		ds := factory()
		var req datasource.MetadataRequest
		var resp datasource.MetadataResponse
		ds.Metadata(context.Background(), req, &resp)
		if resp.TypeName == "" {
			continue
		}
		module, entity := transform.ResolveModuleEntity(resp.TypeName)
		outputs = append(outputs, &DataSourceOutput{
			Key:        resp.TypeName,
			Module:     transform.ToPascal(module),
			DataSource: "get" + transform.ToPascal(entity),
		})
	}
	return outputs
}

func GetResourceInfo(mainPkg string) map[string]*tfbridge.ResourceInfo {
	info := make(map[string]*tfbridge.ResourceInfo)
	outputs := GetResourceOutput()
	for i := range outputs {
		item := outputs[i]
		if item.Key == "tencentcloud_wedata_resource_group" {
			continue
		}

		if item.Key == "tencentcloud_wedata_data_source" {
			info[item.Key] = &tfbridge.ResourceInfo{
				Tok: tfbridge.MakeResource(mainPkg, item.Module, "WeDataDataSource"),
			}
		} else if item.Key == "tencentcloud_waf_object" {
			// The generated class name "Object" is a reserved built-in in
			// TypeScript and cannot be declared when module is NodeNext
			// (error TS2725), breaking the entire nodejs SDK build. Rename
			// the entity to WafObject and alias the original token so
			// existing state stays valid.
			oldTok := mainPkg + ":Waf/object:Object"
			info[item.Key] = &tfbridge.ResourceInfo{
				Tok: tfbridge.MakeResource(mainPkg, item.Module, "WafObject"),
				Aliases: []tfbridge.AliasInfo{
					{Type: &oldTok},
				},
			}
		} else {
			info[item.Key] = &tfbridge.ResourceInfo{
				Tok: tfbridge.MakeResource(mainPkg, item.Module, item.Resource),
			}
		}

		if item.CsharpAlters != nil {
			fields := map[string]*tfbridge.SchemaInfo{}
			for k, v := range item.CsharpAlters {
				fields[k] = &tfbridge.SchemaInfo{
					CSharpName: v,
				}
			}
			info[item.Key].Fields = fields
		}
	}
	return info
}

func GetDataSourceInfo(mainPkg string) map[string]*tfbridge.DataSourceInfo {
	info := make(map[string]*tfbridge.DataSourceInfo)
	outputs := GetDataSourceOutput()
	for i := range outputs {
		item := outputs[i]
		if item.Key == "tencentcloud_wedata_data_sources" {
			info[item.Key] = &tfbridge.DataSourceInfo{
				Tok: tfbridge.MakeDataSource(mainPkg, item.Module, "WeDataDataSources"),
			}
		} else if item.Key == "tencentcloud_wedata_data_source_list" {
			info[item.Key] = &tfbridge.DataSourceInfo{
				Tok: tfbridge.MakeDataSource(mainPkg, item.Module, "WeDataDataSourceList"),
			}
		} else {
			info[item.Key] = &tfbridge.DataSourceInfo{
				Tok: tfbridge.MakeDataSource(mainPkg, item.Module, item.DataSource),
			}
		}

		if item.CsharpAlters != nil {
			fields := map[string]*tfbridge.SchemaInfo{}
			for k, v := range item.CsharpAlters {
				fields[k] = &tfbridge.SchemaInfo{
					CSharpName: v,
				}
			}
			info[item.Key].Fields = fields
		}
	}
	return info
}
