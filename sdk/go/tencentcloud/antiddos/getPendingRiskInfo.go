// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package antiddos

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of antiddos pending risk info
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Antiddos"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Antiddos.GetPendingRiskInfo(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetPendingRiskInfo(ctx *pulumi.Context, args *GetPendingRiskInfoArgs, opts ...pulumi.InvokeOption) (*GetPendingRiskInfoResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetPendingRiskInfoResult
	err := ctx.Invoke("tencentcloud:Antiddos/getPendingRiskInfo:getPendingRiskInfo", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPendingRiskInfo.
type GetPendingRiskInfoArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getPendingRiskInfo.
type GetPendingRiskInfoResult struct {
	// Number of resources in the attack.
	AttackingCount int `pulumi:"attackingCount"`
	// Number of resources in blockage.
	BlockingCount int `pulumi:"blockingCount"`
	// Number of expired resources.
	ExpiredCount int `pulumi:"expiredCount"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Is it a paid user? True: paid user, false: regular user.
	IsPaidUsr        bool    `pulumi:"isPaidUsr"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Total number of all pending risk events.
	Total int `pulumi:"total"`
}

func GetPendingRiskInfoOutput(ctx *pulumi.Context, args GetPendingRiskInfoOutputArgs, opts ...pulumi.InvokeOption) GetPendingRiskInfoResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetPendingRiskInfoResult, error) {
			args := v.(GetPendingRiskInfoArgs)
			r, err := GetPendingRiskInfo(ctx, &args, opts...)
			var s GetPendingRiskInfoResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetPendingRiskInfoResultOutput)
}

// A collection of arguments for invoking getPendingRiskInfo.
type GetPendingRiskInfoOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetPendingRiskInfoOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPendingRiskInfoArgs)(nil)).Elem()
}

// A collection of values returned by getPendingRiskInfo.
type GetPendingRiskInfoResultOutput struct{ *pulumi.OutputState }

func (GetPendingRiskInfoResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPendingRiskInfoResult)(nil)).Elem()
}

func (o GetPendingRiskInfoResultOutput) ToGetPendingRiskInfoResultOutput() GetPendingRiskInfoResultOutput {
	return o
}

func (o GetPendingRiskInfoResultOutput) ToGetPendingRiskInfoResultOutputWithContext(ctx context.Context) GetPendingRiskInfoResultOutput {
	return o
}

// Number of resources in the attack.
func (o GetPendingRiskInfoResultOutput) AttackingCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) int { return v.AttackingCount }).(pulumi.IntOutput)
}

// Number of resources in blockage.
func (o GetPendingRiskInfoResultOutput) BlockingCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) int { return v.BlockingCount }).(pulumi.IntOutput)
}

// Number of expired resources.
func (o GetPendingRiskInfoResultOutput) ExpiredCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) int { return v.ExpiredCount }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetPendingRiskInfoResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) string { return v.Id }).(pulumi.StringOutput)
}

// Is it a paid user? True: paid user, false: regular user.
func (o GetPendingRiskInfoResultOutput) IsPaidUsr() pulumi.BoolOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) bool { return v.IsPaidUsr }).(pulumi.BoolOutput)
}

func (o GetPendingRiskInfoResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Total number of all pending risk events.
func (o GetPendingRiskInfoResultOutput) Total() pulumi.IntOutput {
	return o.ApplyT(func(v GetPendingRiskInfoResult) int { return v.Total }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(GetPendingRiskInfoResultOutput{})
}
