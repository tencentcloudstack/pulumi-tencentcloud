// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of scf functionAddress
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Scf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Scf.GetFunctionAddress(ctx, &scf.GetFunctionAddressArgs{
//				FunctionName: "keep-1676351130",
//				Namespace:    pulumi.StringRef("default"),
//				Qualifier:    pulumi.StringRef("$LATEST"),
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
func GetFunctionAddress(ctx *pulumi.Context, args *GetFunctionAddressArgs, opts ...pulumi.InvokeOption) (*GetFunctionAddressResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetFunctionAddressResult
	err := ctx.Invoke("tencentcloud:Scf/getFunctionAddress:getFunctionAddress", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFunctionAddress.
type GetFunctionAddressArgs struct {
	// Function name.
	FunctionName string `pulumi:"functionName"`
	// Function namespace.
	Namespace *string `pulumi:"namespace"`
	// Function version.
	Qualifier *string `pulumi:"qualifier"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getFunctionAddress.
type GetFunctionAddressResult struct {
	// SHA256 code of the function.
	CodeSha256   string `pulumi:"codeSha256"`
	FunctionName string `pulumi:"functionName"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Namespace        *string `pulumi:"namespace"`
	Qualifier        *string `pulumi:"qualifier"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Cos address of the function.
	Url string `pulumi:"url"`
}

func GetFunctionAddressOutput(ctx *pulumi.Context, args GetFunctionAddressOutputArgs, opts ...pulumi.InvokeOption) GetFunctionAddressResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetFunctionAddressResult, error) {
			args := v.(GetFunctionAddressArgs)
			r, err := GetFunctionAddress(ctx, &args, opts...)
			var s GetFunctionAddressResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetFunctionAddressResultOutput)
}

// A collection of arguments for invoking getFunctionAddress.
type GetFunctionAddressOutputArgs struct {
	// Function name.
	FunctionName pulumi.StringInput `pulumi:"functionName"`
	// Function namespace.
	Namespace pulumi.StringPtrInput `pulumi:"namespace"`
	// Function version.
	Qualifier pulumi.StringPtrInput `pulumi:"qualifier"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetFunctionAddressOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFunctionAddressArgs)(nil)).Elem()
}

// A collection of values returned by getFunctionAddress.
type GetFunctionAddressResultOutput struct{ *pulumi.OutputState }

func (GetFunctionAddressResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFunctionAddressResult)(nil)).Elem()
}

func (o GetFunctionAddressResultOutput) ToGetFunctionAddressResultOutput() GetFunctionAddressResultOutput {
	return o
}

func (o GetFunctionAddressResultOutput) ToGetFunctionAddressResultOutputWithContext(ctx context.Context) GetFunctionAddressResultOutput {
	return o
}

// SHA256 code of the function.
func (o GetFunctionAddressResultOutput) CodeSha256() pulumi.StringOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) string { return v.CodeSha256 }).(pulumi.StringOutput)
}

func (o GetFunctionAddressResultOutput) FunctionName() pulumi.StringOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) string { return v.FunctionName }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFunctionAddressResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetFunctionAddressResultOutput) Namespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) *string { return v.Namespace }).(pulumi.StringPtrOutput)
}

func (o GetFunctionAddressResultOutput) Qualifier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) *string { return v.Qualifier }).(pulumi.StringPtrOutput)
}

func (o GetFunctionAddressResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Cos address of the function.
func (o GetFunctionAddressResultOutput) Url() pulumi.StringOutput {
	return o.ApplyT(func(v GetFunctionAddressResult) string { return v.Url }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFunctionAddressResultOutput{})
}
