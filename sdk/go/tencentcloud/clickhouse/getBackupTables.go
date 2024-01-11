// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package clickhouse

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of clickhouse backup tables
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Clickhouse"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Clickhouse"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Clickhouse.GetBackupTables(ctx, &clickhouse.GetBackupTablesArgs{
// 			InstanceId: "cdwch-xxxxxx",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetBackupTables(ctx *pulumi.Context, args *GetBackupTablesArgs, opts ...pulumi.InvokeOption) (*GetBackupTablesResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetBackupTablesResult
	err := ctx.Invoke("tencentcloud:Clickhouse/getBackupTables:getBackupTables", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackupTables.
type GetBackupTablesArgs struct {
	// Instance id.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBackupTables.
type GetBackupTablesResult struct {
	// Available tables.
	AvailableTables []GetBackupTablesAvailableTable `pulumi:"availableTables"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetBackupTablesOutput(ctx *pulumi.Context, args GetBackupTablesOutputArgs, opts ...pulumi.InvokeOption) GetBackupTablesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupTablesResult, error) {
			args := v.(GetBackupTablesArgs)
			r, err := GetBackupTables(ctx, &args, opts...)
			var s GetBackupTablesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBackupTablesResultOutput)
}

// A collection of arguments for invoking getBackupTables.
type GetBackupTablesOutputArgs struct {
	// Instance id.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBackupTablesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupTablesArgs)(nil)).Elem()
}

// A collection of values returned by getBackupTables.
type GetBackupTablesResultOutput struct{ *pulumi.OutputState }

func (GetBackupTablesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupTablesResult)(nil)).Elem()
}

func (o GetBackupTablesResultOutput) ToGetBackupTablesResultOutput() GetBackupTablesResultOutput {
	return o
}

func (o GetBackupTablesResultOutput) ToGetBackupTablesResultOutputWithContext(ctx context.Context) GetBackupTablesResultOutput {
	return o
}

// Available tables.
func (o GetBackupTablesResultOutput) AvailableTables() GetBackupTablesAvailableTableArrayOutput {
	return o.ApplyT(func(v GetBackupTablesResult) []GetBackupTablesAvailableTable { return v.AvailableTables }).(GetBackupTablesAvailableTableArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupTablesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupTablesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBackupTablesResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupTablesResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetBackupTablesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupTablesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupTablesResultOutput{})
}