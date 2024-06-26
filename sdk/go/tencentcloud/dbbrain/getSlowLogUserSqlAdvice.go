// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dbbrain

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of dbbrain slowLogUserSqlAdvice
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dbbrain"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dbbrain.GetSlowLogUserSqlAdvice(ctx, &dbbrain.GetSlowLogUserSqlAdviceArgs{
//				InstanceId: "%s",
//				Product:    pulumi.StringRef("mysql"),
//				SqlText:    "%s",
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
func GetSlowLogUserSqlAdvice(ctx *pulumi.Context, args *GetSlowLogUserSqlAdviceArgs, opts ...pulumi.InvokeOption) (*GetSlowLogUserSqlAdviceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSlowLogUserSqlAdviceResult
	err := ctx.Invoke("tencentcloud:Dbbrain/getSlowLogUserSqlAdvice:getSlowLogUserSqlAdvice", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSlowLogUserSqlAdvice.
type GetSlowLogUserSqlAdviceArgs struct {
	// instance id.
	InstanceId string `pulumi:"instanceId"`
	// Service product type, supported values: `mysql` - cloud database MySQL; `cynosdb` - cloud database TDSQL-C for MySQL; `dbbrain-mysql` - self-built MySQL, the default is `mysql`.
	Product *string `pulumi:"product"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// library name.
	Schema *string `pulumi:"schema"`
	// SQL statements.
	SqlText string `pulumi:"sqlText"`
}

// A collection of values returned by getSlowLogUserSqlAdvice.
type GetSlowLogUserSqlAdviceResult struct {
	// SQL optimization suggestion, which can be parsed into a JSON array, and the output is empty when no optimization is required.
	Advices string `pulumi:"advices"`
	// SQL optimization suggestion remarks, which can be parsed into a String array, and the output is empty when optimization is not required.
	Comments string `pulumi:"comments"`
	// The cost saving details after SQL optimization can be parsed as JSON, and the output is empty when no optimization is required.
	Cost string `pulumi:"cost"`
	// The provider-assigned unique ID for this managed resource.
	Id         string  `pulumi:"id"`
	InstanceId string  `pulumi:"instanceId"`
	Product    *string `pulumi:"product"`
	// Unique request ID, returned for every request. The RequestId of the request needs to be provided when locating the problem.
	RequestId        string  `pulumi:"requestId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Schema           string  `pulumi:"schema"`
	// The SQL execution plan can be parsed into JSON, and the output is empty when no optimization is required.
	SqlPlan string `pulumi:"sqlPlan"`
	SqlText string `pulumi:"sqlText"`
	// The DDL information of related tables can be parsed into a JSON array.
	Tables string `pulumi:"tables"`
}

func GetSlowLogUserSqlAdviceOutput(ctx *pulumi.Context, args GetSlowLogUserSqlAdviceOutputArgs, opts ...pulumi.InvokeOption) GetSlowLogUserSqlAdviceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSlowLogUserSqlAdviceResult, error) {
			args := v.(GetSlowLogUserSqlAdviceArgs)
			r, err := GetSlowLogUserSqlAdvice(ctx, &args, opts...)
			var s GetSlowLogUserSqlAdviceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSlowLogUserSqlAdviceResultOutput)
}

// A collection of arguments for invoking getSlowLogUserSqlAdvice.
type GetSlowLogUserSqlAdviceOutputArgs struct {
	// instance id.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Service product type, supported values: `mysql` - cloud database MySQL; `cynosdb` - cloud database TDSQL-C for MySQL; `dbbrain-mysql` - self-built MySQL, the default is `mysql`.
	Product pulumi.StringPtrInput `pulumi:"product"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// library name.
	Schema pulumi.StringPtrInput `pulumi:"schema"`
	// SQL statements.
	SqlText pulumi.StringInput `pulumi:"sqlText"`
}

func (GetSlowLogUserSqlAdviceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSlowLogUserSqlAdviceArgs)(nil)).Elem()
}

// A collection of values returned by getSlowLogUserSqlAdvice.
type GetSlowLogUserSqlAdviceResultOutput struct{ *pulumi.OutputState }

func (GetSlowLogUserSqlAdviceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSlowLogUserSqlAdviceResult)(nil)).Elem()
}

func (o GetSlowLogUserSqlAdviceResultOutput) ToGetSlowLogUserSqlAdviceResultOutput() GetSlowLogUserSqlAdviceResultOutput {
	return o
}

func (o GetSlowLogUserSqlAdviceResultOutput) ToGetSlowLogUserSqlAdviceResultOutputWithContext(ctx context.Context) GetSlowLogUserSqlAdviceResultOutput {
	return o
}

// SQL optimization suggestion, which can be parsed into a JSON array, and the output is empty when no optimization is required.
func (o GetSlowLogUserSqlAdviceResultOutput) Advices() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Advices }).(pulumi.StringOutput)
}

// SQL optimization suggestion remarks, which can be parsed into a String array, and the output is empty when optimization is not required.
func (o GetSlowLogUserSqlAdviceResultOutput) Comments() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Comments }).(pulumi.StringOutput)
}

// The cost saving details after SQL optimization can be parsed as JSON, and the output is empty when no optimization is required.
func (o GetSlowLogUserSqlAdviceResultOutput) Cost() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Cost }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetSlowLogUserSqlAdviceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSlowLogUserSqlAdviceResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetSlowLogUserSqlAdviceResultOutput) Product() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) *string { return v.Product }).(pulumi.StringPtrOutput)
}

// Unique request ID, returned for every request. The RequestId of the request needs to be provided when locating the problem.
func (o GetSlowLogUserSqlAdviceResultOutput) RequestId() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.RequestId }).(pulumi.StringOutput)
}

func (o GetSlowLogUserSqlAdviceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetSlowLogUserSqlAdviceResultOutput) Schema() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Schema }).(pulumi.StringOutput)
}

// The SQL execution plan can be parsed into JSON, and the output is empty when no optimization is required.
func (o GetSlowLogUserSqlAdviceResultOutput) SqlPlan() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.SqlPlan }).(pulumi.StringOutput)
}

func (o GetSlowLogUserSqlAdviceResultOutput) SqlText() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.SqlText }).(pulumi.StringOutput)
}

// The DDL information of related tables can be parsed into a JSON array.
func (o GetSlowLogUserSqlAdviceResultOutput) Tables() pulumi.StringOutput {
	return o.ApplyT(func(v GetSlowLogUserSqlAdviceResult) string { return v.Tables }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSlowLogUserSqlAdviceResultOutput{})
}
