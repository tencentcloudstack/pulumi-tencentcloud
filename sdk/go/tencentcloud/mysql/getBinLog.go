// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of mysql binLog
//
// ## Example Usage
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Mysql.GetBinLog(ctx, &mysql.GetBinLogArgs{
//				InstanceId: "cdb-fitq5t9h",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetBinLog(ctx *pulumi.Context, args *GetBinLogArgs, opts ...pulumi.InvokeOption) (*GetBinLogResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBinLogResult
	err := ctx.Invoke("tencentcloud:Mysql/getBinLog:getBinLog", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBinLog.
type GetBinLogArgs struct {
	// Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBinLog.
type GetBinLogResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
	InstanceId string `pulumi:"instanceId"`
	// Details of binary log files that meet the query conditions.
	Items            []GetBinLogItem `pulumi:"items"`
	ResultOutputFile *string         `pulumi:"resultOutputFile"`
}

func GetBinLogOutput(ctx *pulumi.Context, args GetBinLogOutputArgs, opts ...pulumi.InvokeOption) GetBinLogResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBinLogResult, error) {
			args := v.(GetBinLogArgs)
			r, err := GetBinLog(ctx, &args, opts...)
			var s GetBinLogResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBinLogResultOutput)
}

// A collection of arguments for invoking getBinLog.
type GetBinLogOutputArgs struct {
	// Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBinLogOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBinLogArgs)(nil)).Elem()
}

// A collection of values returned by getBinLog.
type GetBinLogResultOutput struct{ *pulumi.OutputState }

func (GetBinLogResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBinLogResult)(nil)).Elem()
}

func (o GetBinLogResultOutput) ToGetBinLogResultOutput() GetBinLogResultOutput {
	return o
}

func (o GetBinLogResultOutput) ToGetBinLogResultOutputWithContext(ctx context.Context) GetBinLogResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetBinLogResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBinLogResult) string { return v.Id }).(pulumi.StringOutput)
}

// Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
func (o GetBinLogResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBinLogResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

// Details of binary log files that meet the query conditions.
func (o GetBinLogResultOutput) Items() GetBinLogItemArrayOutput {
	return o.ApplyT(func(v GetBinLogResult) []GetBinLogItem { return v.Items }).(GetBinLogItemArrayOutput)
}

func (o GetBinLogResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBinLogResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBinLogResultOutput{})
}
