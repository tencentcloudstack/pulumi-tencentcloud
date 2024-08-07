// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cam

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of cam accountSummary
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cam"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Cam.GetAccountSummary(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetAccountSummary(ctx *pulumi.Context, args *GetAccountSummaryArgs, opts ...pulumi.InvokeOption) (*GetAccountSummaryResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetAccountSummaryResult
	err := ctx.Invoke("tencentcloud:Cam/getAccountSummary:getAccountSummary", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getAccountSummary.
type GetAccountSummaryArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getAccountSummary.
type GetAccountSummaryResult struct {
	// The number of Group.
	Group int `pulumi:"group"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The number of identity provider.
	IdentityProviders int `pulumi:"identityProviders"`
	// The number of grouped users.
	Member int `pulumi:"member"`
	// The number of policy.
	Policies         int     `pulumi:"policies"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The number of role.
	Roles int `pulumi:"roles"`
	// The number of Sub-user.
	User int `pulumi:"user"`
}

func GetAccountSummaryOutput(ctx *pulumi.Context, args GetAccountSummaryOutputArgs, opts ...pulumi.InvokeOption) GetAccountSummaryResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetAccountSummaryResult, error) {
			args := v.(GetAccountSummaryArgs)
			r, err := GetAccountSummary(ctx, &args, opts...)
			var s GetAccountSummaryResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetAccountSummaryResultOutput)
}

// A collection of arguments for invoking getAccountSummary.
type GetAccountSummaryOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetAccountSummaryOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAccountSummaryArgs)(nil)).Elem()
}

// A collection of values returned by getAccountSummary.
type GetAccountSummaryResultOutput struct{ *pulumi.OutputState }

func (GetAccountSummaryResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetAccountSummaryResult)(nil)).Elem()
}

func (o GetAccountSummaryResultOutput) ToGetAccountSummaryResultOutput() GetAccountSummaryResultOutput {
	return o
}

func (o GetAccountSummaryResultOutput) ToGetAccountSummaryResultOutputWithContext(ctx context.Context) GetAccountSummaryResultOutput {
	return o
}

// The number of Group.
func (o GetAccountSummaryResultOutput) Group() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.Group }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetAccountSummaryResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) string { return v.Id }).(pulumi.StringOutput)
}

// The number of identity provider.
func (o GetAccountSummaryResultOutput) IdentityProviders() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.IdentityProviders }).(pulumi.IntOutput)
}

// The number of grouped users.
func (o GetAccountSummaryResultOutput) Member() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.Member }).(pulumi.IntOutput)
}

// The number of policy.
func (o GetAccountSummaryResultOutput) Policies() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.Policies }).(pulumi.IntOutput)
}

func (o GetAccountSummaryResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// The number of role.
func (o GetAccountSummaryResultOutput) Roles() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.Roles }).(pulumi.IntOutput)
}

// The number of Sub-user.
func (o GetAccountSummaryResultOutput) User() pulumi.IntOutput {
	return o.ApplyT(func(v GetAccountSummaryResult) int { return v.User }).(pulumi.IntOutput)
}

func init() {
	pulumi.RegisterOutputType(GetAccountSummaryResultOutput{})
}
