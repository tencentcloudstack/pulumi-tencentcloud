// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package gaap

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of gaap dest regions
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Gaap"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Gaap.GetDestRegions(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetDestRegions(ctx *pulumi.Context, args *GetDestRegionsArgs, opts ...pulumi.InvokeOption) (*GetDestRegionsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetDestRegionsResult
	err := ctx.Invoke("tencentcloud:Gaap/getDestRegions:getDestRegions", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getDestRegions.
type GetDestRegionsArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getDestRegions.
type GetDestRegionsResult struct {
	// Source Site Area Details List.
	DestRegionSets []GetDestRegionsDestRegionSet `pulumi:"destRegionSets"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetDestRegionsOutput(ctx *pulumi.Context, args GetDestRegionsOutputArgs, opts ...pulumi.InvokeOption) GetDestRegionsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetDestRegionsResult, error) {
			args := v.(GetDestRegionsArgs)
			r, err := GetDestRegions(ctx, &args, opts...)
			var s GetDestRegionsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetDestRegionsResultOutput)
}

// A collection of arguments for invoking getDestRegions.
type GetDestRegionsOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetDestRegionsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDestRegionsArgs)(nil)).Elem()
}

// A collection of values returned by getDestRegions.
type GetDestRegionsResultOutput struct{ *pulumi.OutputState }

func (GetDestRegionsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetDestRegionsResult)(nil)).Elem()
}

func (o GetDestRegionsResultOutput) ToGetDestRegionsResultOutput() GetDestRegionsResultOutput {
	return o
}

func (o GetDestRegionsResultOutput) ToGetDestRegionsResultOutputWithContext(ctx context.Context) GetDestRegionsResultOutput {
	return o
}

// Source Site Area Details List.
func (o GetDestRegionsResultOutput) DestRegionSets() GetDestRegionsDestRegionSetArrayOutput {
	return o.ApplyT(func(v GetDestRegionsResult) []GetDestRegionsDestRegionSet { return v.DestRegionSets }).(GetDestRegionsDestRegionSetArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetDestRegionsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetDestRegionsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetDestRegionsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetDestRegionsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetDestRegionsResultOutput{})
}
