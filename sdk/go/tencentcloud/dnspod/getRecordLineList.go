// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dnspod

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of dnspod recordLineList
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Dnspod"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dnspod"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Dnspod.GetRecordLineList(ctx, &dnspod.GetRecordLineListArgs{
// 			Domain:      "iac-tf.cloud",
// 			DomainGrade: "DP_FREE",
// 			DomainId:    pulumi.IntRef(123),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetRecordLineList(ctx *pulumi.Context, args *GetRecordLineListArgs, opts ...pulumi.InvokeOption) (*GetRecordLineListResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetRecordLineListResult
	err := ctx.Invoke("tencentcloud:Dnspod/getRecordLineList:getRecordLineList", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRecordLineList.
type GetRecordLineListArgs struct {
	// Domain.
	Domain string `pulumi:"domain"`
	// Domain level. + Old packages: D_FREE, D_PLUS, D_EXTRA, D_EXPERT, D_ULTRA correspond to free package, personal luxury, enterprise 1, enterprise 2, enterprise 3. + New packages: DP_FREE, DP_PLUS, DP_EXTRA, DP_EXPERT, DP_ULTRA correspond to new free, personal professional, enterprise basic, enterprise standard, enterprise flagship.
	DomainGrade string `pulumi:"domainGrade"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId *int `pulumi:"domainId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getRecordLineList.
type GetRecordLineListResult struct {
	Domain      string `pulumi:"domain"`
	DomainGrade string `pulumi:"domainGrade"`
	DomainId    *int   `pulumi:"domainId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Line group list.
	LineGroupLists []GetRecordLineListLineGroupList `pulumi:"lineGroupLists"`
	// Line list.
	LineLists        []GetRecordLineListLineList `pulumi:"lineLists"`
	ResultOutputFile *string                     `pulumi:"resultOutputFile"`
}

func GetRecordLineListOutput(ctx *pulumi.Context, args GetRecordLineListOutputArgs, opts ...pulumi.InvokeOption) GetRecordLineListResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRecordLineListResult, error) {
			args := v.(GetRecordLineListArgs)
			r, err := GetRecordLineList(ctx, &args, opts...)
			var s GetRecordLineListResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRecordLineListResultOutput)
}

// A collection of arguments for invoking getRecordLineList.
type GetRecordLineListOutputArgs struct {
	// Domain.
	Domain pulumi.StringInput `pulumi:"domain"`
	// Domain level. + Old packages: D_FREE, D_PLUS, D_EXTRA, D_EXPERT, D_ULTRA correspond to free package, personal luxury, enterprise 1, enterprise 2, enterprise 3. + New packages: DP_FREE, DP_PLUS, DP_EXTRA, DP_EXPERT, DP_ULTRA correspond to new free, personal professional, enterprise basic, enterprise standard, enterprise flagship.
	DomainGrade pulumi.StringInput `pulumi:"domainGrade"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrInput `pulumi:"domainId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetRecordLineListOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRecordLineListArgs)(nil)).Elem()
}

// A collection of values returned by getRecordLineList.
type GetRecordLineListResultOutput struct{ *pulumi.OutputState }

func (GetRecordLineListResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRecordLineListResult)(nil)).Elem()
}

func (o GetRecordLineListResultOutput) ToGetRecordLineListResultOutput() GetRecordLineListResultOutput {
	return o
}

func (o GetRecordLineListResultOutput) ToGetRecordLineListResultOutputWithContext(ctx context.Context) GetRecordLineListResultOutput {
	return o
}

func (o GetRecordLineListResultOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v GetRecordLineListResult) string { return v.Domain }).(pulumi.StringOutput)
}

func (o GetRecordLineListResultOutput) DomainGrade() pulumi.StringOutput {
	return o.ApplyT(func(v GetRecordLineListResult) string { return v.DomainGrade }).(pulumi.StringOutput)
}

func (o GetRecordLineListResultOutput) DomainId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetRecordLineListResult) *int { return v.DomainId }).(pulumi.IntPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRecordLineListResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRecordLineListResult) string { return v.Id }).(pulumi.StringOutput)
}

// Line group list.
func (o GetRecordLineListResultOutput) LineGroupLists() GetRecordLineListLineGroupListArrayOutput {
	return o.ApplyT(func(v GetRecordLineListResult) []GetRecordLineListLineGroupList { return v.LineGroupLists }).(GetRecordLineListLineGroupListArrayOutput)
}

// Line list.
func (o GetRecordLineListResultOutput) LineLists() GetRecordLineListLineListArrayOutput {
	return o.ApplyT(func(v GetRecordLineListResult) []GetRecordLineListLineList { return v.LineLists }).(GetRecordLineListLineListArrayOutput)
}

func (o GetRecordLineListResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRecordLineListResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRecordLineListResultOutput{})
}