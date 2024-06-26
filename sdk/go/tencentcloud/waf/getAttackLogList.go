// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package waf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of waf attackLogList
//
// ## Example Usage
//
// ### Obtain the specified domain name attack log list
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Waf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Waf.GetAttackLogList(ctx, &waf.GetAttackLogListArgs{
//				Domain:      "domain.com",
//				EndTime:     "2023-09-07 00:00:00",
//				Page:        pulumi.IntRef(0),
//				QueryCount:  pulumi.IntRef(10),
//				QueryString: "method:GET",
//				Sort:        pulumi.StringRef("desc"),
//				StartTime:   "2023-09-01 00:00:00",
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
//
// ### Obtain all domain name attack log list
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Waf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Waf.GetAttackLogList(ctx, &waf.GetAttackLogListArgs{
//				Domain:      "all",
//				EndTime:     "2023-09-07 00:00:00",
//				Page:        pulumi.IntRef(1),
//				QueryCount:  pulumi.IntRef(20),
//				QueryString: "method:GET",
//				Sort:        pulumi.StringRef("asc"),
//				StartTime:   "2023-09-01 00:00:00",
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
func GetAttackLogList(ctx *pulumi.Context, args *GetAttackLogListArgs, opts ...pulumi.InvokeOption) (*GetAttackLogListResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetAttackLogListResult
	err := ctx.Invoke("tencentcloud:Waf/getAttackLogList:getAttackLogList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAttackLogList.
type GetAttackLogListArgs struct {
	// Domain for query, all domain use all.
	Domain string `pulumi:"domain"`
	// End time.
	EndTime string `pulumi:"endTime"`
	// Number of pages, starting from 0 by default.
	Page *int `pulumi:"page"`
	// Number of queries, default to 10, maximum of 100.
	QueryCount *int `pulumi:"queryCount"`
	// Lucene grammar.
	QueryString string `pulumi:"queryString"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Default desc, support desc, asc.
	Sort *string `pulumi:"sort"`
	// Begin time.
	StartTime string `pulumi:"startTime"`
}

// A collection of values returned by getAttackLogList.
type GetAttackLogListResult struct {
	// Attack log array.
	Datas   []GetAttackLogListData `pulumi:"datas"`
	Domain  string                 `pulumi:"domain"`
	EndTime string                 `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Page             *int    `pulumi:"page"`
	QueryCount       *int    `pulumi:"queryCount"`
	QueryString      string  `pulumi:"queryString"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	Sort             *string `pulumi:"sort"`
	StartTime        string  `pulumi:"startTime"`
}

func GetAttackLogListOutput(ctx *pulumi.Context, args GetAttackLogListOutputArgs, opts ...pulumi.InvokeOption) GetAttackLogListResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetAttackLogListResult, error) {
			args := v.(GetAttackLogListArgs)
			r, err := GetAttackLogList(ctx, &args, opts...)
			var s GetAttackLogListResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetAttackLogListResultOutput)
}

// A collection of arguments for invoking getAttackLogList.
type GetAttackLogListOutputArgs struct {
	// Domain for query, all domain use all.
	Domain pulumi.StringInput `pulumi:"domain"`
	// End time.
	EndTime pulumi.StringInput `pulumi:"endTime"`
	// Number of pages, starting from 0 by default.
	Page pulumi.IntPtrInput `pulumi:"page"`
	// Number of queries, default to 10, maximum of 100.
	QueryCount pulumi.IntPtrInput `pulumi:"queryCount"`
	// Lucene grammar.
	QueryString pulumi.StringInput `pulumi:"queryString"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Default desc, support desc, asc.
	Sort pulumi.StringPtrInput `pulumi:"sort"`
	// Begin time.
	StartTime pulumi.StringInput `pulumi:"startTime"`
}

func (GetAttackLogListOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAttackLogListArgs)(nil)).Elem()
}

// A collection of values returned by getAttackLogList.
type GetAttackLogListResultOutput struct{ *pulumi.OutputState }

func (GetAttackLogListResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAttackLogListResult)(nil)).Elem()
}

func (o GetAttackLogListResultOutput) ToGetAttackLogListResultOutput() GetAttackLogListResultOutput {
	return o
}

func (o GetAttackLogListResultOutput) ToGetAttackLogListResultOutputWithContext(ctx context.Context) GetAttackLogListResultOutput {
	return o
}

// Attack log array.
func (o GetAttackLogListResultOutput) Datas() GetAttackLogListDataArrayOutput {
	return o.ApplyT(func(v GetAttackLogListResult) []GetAttackLogListData { return v.Datas }).(GetAttackLogListDataArrayOutput)
}

func (o GetAttackLogListResultOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v GetAttackLogListResult) string { return v.Domain }).(pulumi.StringOutput)
}

func (o GetAttackLogListResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetAttackLogListResult) string { return v.EndTime }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetAttackLogListResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetAttackLogListResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetAttackLogListResultOutput) Page() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetAttackLogListResult) *int { return v.Page }).(pulumi.IntPtrOutput)
}

func (o GetAttackLogListResultOutput) QueryCount() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetAttackLogListResult) *int { return v.QueryCount }).(pulumi.IntPtrOutput)
}

func (o GetAttackLogListResultOutput) QueryString() pulumi.StringOutput {
	return o.ApplyT(func(v GetAttackLogListResult) string { return v.QueryString }).(pulumi.StringOutput)
}

func (o GetAttackLogListResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetAttackLogListResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetAttackLogListResultOutput) Sort() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetAttackLogListResult) *string { return v.Sort }).(pulumi.StringPtrOutput)
}

func (o GetAttackLogListResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetAttackLogListResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetAttackLogListResultOutput{})
}
