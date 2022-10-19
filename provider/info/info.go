package info

import (
	"github.com/pulumi/pulumi-terraform-bridge/v3/pkg/tfbridge"
	"github.com/tencentcloudstack/pulumi-tencentcloud/provider/info/transform"
	"github.com/tencentcloudstack/terraform-provider-tencentcloud/tencentcloud"
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

func GetResourceOutput() []*ResourceOutput {
	p := tencentcloud.Provider()
	resourceOutputs := make([]*ResourceOutput, 0, len(p.ResourcesMap))

	for k, v := range p.ResourcesMap {
		if v.DeprecationMessage != "" {
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
	return resourceOutputs
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
	return dataSourceOutputs
}

func GetResourceInfo(mainPkg string) map[string]*tfbridge.ResourceInfo {
	info := make(map[string]*tfbridge.ResourceInfo)
	outputs := GetResourceOutput()
	for i := range outputs {
		item := outputs[i]
		info[item.Key] = &tfbridge.ResourceInfo{
			Tok: tfbridge.MakeResource(mainPkg, item.Module, item.Resource),
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
		info[item.Key] = &tfbridge.DataSourceInfo{
			Tok: tfbridge.MakeDataSource(mainPkg, item.Module, item.DataSource),
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
