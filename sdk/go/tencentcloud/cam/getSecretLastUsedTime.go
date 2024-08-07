// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cam

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of cam secretLastUsedTime
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
//			_, err := Cam.GetSecretLastUsedTime(ctx, &cam.GetSecretLastUsedTimeArgs{
//				SecretIdLists: []string{
//					"xxxx",
//				},
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
func GetSecretLastUsedTime(ctx *pulumi.Context, args *GetSecretLastUsedTimeArgs, opts ...pulumi.InvokeOption) (*GetSecretLastUsedTimeResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetSecretLastUsedTimeResult
	err := ctx.Invoke("tencentcloud:Cam/getSecretLastUsedTime:getSecretLastUsedTime", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecretLastUsedTime.
type GetSecretLastUsedTimeArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Query the key ID list. Supports up to 10.
	SecretIdLists []string `pulumi:"secretIdLists"`
}

// A collection of values returned by getSecretLastUsedTime.
type GetSecretLastUsedTimeResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Last used time list.
	SecretIdLastUsedRows []GetSecretLastUsedTimeSecretIdLastUsedRow `pulumi:"secretIdLastUsedRows"`
	SecretIdLists        []string                                   `pulumi:"secretIdLists"`
}

func GetSecretLastUsedTimeOutput(ctx *pulumi.Context, args GetSecretLastUsedTimeOutputArgs, opts ...pulumi.InvokeOption) GetSecretLastUsedTimeResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetSecretLastUsedTimeResult, error) {
			args := v.(GetSecretLastUsedTimeArgs)
			r, err := GetSecretLastUsedTime(ctx, &args, opts...)
			var s GetSecretLastUsedTimeResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetSecretLastUsedTimeResultOutput)
}

// A collection of arguments for invoking getSecretLastUsedTime.
type GetSecretLastUsedTimeOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Query the key ID list. Supports up to 10.
	SecretIdLists pulumi.StringArrayInput `pulumi:"secretIdLists"`
}

func (GetSecretLastUsedTimeOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSecretLastUsedTimeArgs)(nil)).Elem()
}

// A collection of values returned by getSecretLastUsedTime.
type GetSecretLastUsedTimeResultOutput struct{ *pulumi.OutputState }

func (GetSecretLastUsedTimeResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetSecretLastUsedTimeResult)(nil)).Elem()
}

func (o GetSecretLastUsedTimeResultOutput) ToGetSecretLastUsedTimeResultOutput() GetSecretLastUsedTimeResultOutput {
	return o
}

func (o GetSecretLastUsedTimeResultOutput) ToGetSecretLastUsedTimeResultOutputWithContext(ctx context.Context) GetSecretLastUsedTimeResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetSecretLastUsedTimeResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetSecretLastUsedTimeResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetSecretLastUsedTimeResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetSecretLastUsedTimeResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Last used time list.
func (o GetSecretLastUsedTimeResultOutput) SecretIdLastUsedRows() GetSecretLastUsedTimeSecretIdLastUsedRowArrayOutput {
	return o.ApplyT(func(v GetSecretLastUsedTimeResult) []GetSecretLastUsedTimeSecretIdLastUsedRow {
		return v.SecretIdLastUsedRows
	}).(GetSecretLastUsedTimeSecretIdLastUsedRowArrayOutput)
}

func (o GetSecretLastUsedTimeResultOutput) SecretIdLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetSecretLastUsedTimeResult) []string { return v.SecretIdLists }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetSecretLastUsedTimeResultOutput{})
}
