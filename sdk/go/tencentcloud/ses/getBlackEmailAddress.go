// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ses

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of ses blackEmailAddress
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ses"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Ses.GetBlackEmailAddress(ctx, &ses.GetBlackEmailAddressArgs{
//				EmailAddress: pulumi.StringRef("xxx@mail.qcloud.com"),
//				EndDate:      "2020-09-23",
//				StartDate:    "2020-09-22",
//				TaskId:       pulumi.StringRef("7000"),
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
func GetBlackEmailAddress(ctx *pulumi.Context, args *GetBlackEmailAddressArgs, opts ...pulumi.InvokeOption) (*GetBlackEmailAddressResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBlackEmailAddressResult
	err := ctx.Invoke("tencentcloud:Ses/getBlackEmailAddress:getBlackEmailAddress", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBlackEmailAddress.
type GetBlackEmailAddressArgs struct {
	// You can specify an email address to query.
	EmailAddress *string `pulumi:"emailAddress"`
	// End date in the format of `YYYY-MM-DD`.
	EndDate string `pulumi:"endDate"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Start date in the format of `YYYY-MM-DD`.
	StartDate string `pulumi:"startDate"`
	// You can specify a task ID to query.
	TaskId *string `pulumi:"taskId"`
}

// A collection of values returned by getBlackEmailAddress.
type GetBlackEmailAddressResult struct {
	// List of blocklisted addresses.
	BlackLists []GetBlackEmailAddressBlackList `pulumi:"blackLists"`
	// Blocklisted email address.
	EmailAddress *string `pulumi:"emailAddress"`
	EndDate      string  `pulumi:"endDate"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartDate        string  `pulumi:"startDate"`
	TaskId           *string `pulumi:"taskId"`
}

func GetBlackEmailAddressOutput(ctx *pulumi.Context, args GetBlackEmailAddressOutputArgs, opts ...pulumi.InvokeOption) GetBlackEmailAddressResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBlackEmailAddressResult, error) {
			args := v.(GetBlackEmailAddressArgs)
			r, err := GetBlackEmailAddress(ctx, &args, opts...)
			var s GetBlackEmailAddressResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBlackEmailAddressResultOutput)
}

// A collection of arguments for invoking getBlackEmailAddress.
type GetBlackEmailAddressOutputArgs struct {
	// You can specify an email address to query.
	EmailAddress pulumi.StringPtrInput `pulumi:"emailAddress"`
	// End date in the format of `YYYY-MM-DD`.
	EndDate pulumi.StringInput `pulumi:"endDate"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Start date in the format of `YYYY-MM-DD`.
	StartDate pulumi.StringInput `pulumi:"startDate"`
	// You can specify a task ID to query.
	TaskId pulumi.StringPtrInput `pulumi:"taskId"`
}

func (GetBlackEmailAddressOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBlackEmailAddressArgs)(nil)).Elem()
}

// A collection of values returned by getBlackEmailAddress.
type GetBlackEmailAddressResultOutput struct{ *pulumi.OutputState }

func (GetBlackEmailAddressResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBlackEmailAddressResult)(nil)).Elem()
}

func (o GetBlackEmailAddressResultOutput) ToGetBlackEmailAddressResultOutput() GetBlackEmailAddressResultOutput {
	return o
}

func (o GetBlackEmailAddressResultOutput) ToGetBlackEmailAddressResultOutputWithContext(ctx context.Context) GetBlackEmailAddressResultOutput {
	return o
}

// List of blocklisted addresses.
func (o GetBlackEmailAddressResultOutput) BlackLists() GetBlackEmailAddressBlackListArrayOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) []GetBlackEmailAddressBlackList { return v.BlackLists }).(GetBlackEmailAddressBlackListArrayOutput)
}

// Blocklisted email address.
func (o GetBlackEmailAddressResultOutput) EmailAddress() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) *string { return v.EmailAddress }).(pulumi.StringPtrOutput)
}

func (o GetBlackEmailAddressResultOutput) EndDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) string { return v.EndDate }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBlackEmailAddressResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBlackEmailAddressResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetBlackEmailAddressResultOutput) StartDate() pulumi.StringOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) string { return v.StartDate }).(pulumi.StringOutput)
}

func (o GetBlackEmailAddressResultOutput) TaskId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBlackEmailAddressResult) *string { return v.TaskId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBlackEmailAddressResultOutput{})
}
