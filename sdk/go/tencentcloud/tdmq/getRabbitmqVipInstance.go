// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tdmq

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

func LookupRabbitmqVipInstance(ctx *pulumi.Context, args *LookupRabbitmqVipInstanceArgs, opts ...pulumi.InvokeOption) (*LookupRabbitmqVipInstanceResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRabbitmqVipInstanceResult
	err := ctx.Invoke("tencentcloud:Tdmq/getRabbitmqVipInstance:getRabbitmqVipInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRabbitmqVipInstance.
type LookupRabbitmqVipInstanceArgs struct {
	Filters          []GetRabbitmqVipInstanceFilter `pulumi:"filters"`
	ResultOutputFile *string                        `pulumi:"resultOutputFile"`
}

// A collection of values returned by getRabbitmqVipInstance.
type LookupRabbitmqVipInstanceResult struct {
	Filters []GetRabbitmqVipInstanceFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string                           `pulumi:"id"`
	Instances        []GetRabbitmqVipInstanceInstance `pulumi:"instances"`
	ResultOutputFile *string                          `pulumi:"resultOutputFile"`
}

func LookupRabbitmqVipInstanceOutput(ctx *pulumi.Context, args LookupRabbitmqVipInstanceOutputArgs, opts ...pulumi.InvokeOption) LookupRabbitmqVipInstanceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRabbitmqVipInstanceResult, error) {
			args := v.(LookupRabbitmqVipInstanceArgs)
			r, err := LookupRabbitmqVipInstance(ctx, &args, opts...)
			var s LookupRabbitmqVipInstanceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRabbitmqVipInstanceResultOutput)
}

// A collection of arguments for invoking getRabbitmqVipInstance.
type LookupRabbitmqVipInstanceOutputArgs struct {
	Filters          GetRabbitmqVipInstanceFilterArrayInput `pulumi:"filters"`
	ResultOutputFile pulumi.StringPtrInput                  `pulumi:"resultOutputFile"`
}

func (LookupRabbitmqVipInstanceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRabbitmqVipInstanceArgs)(nil)).Elem()
}

// A collection of values returned by getRabbitmqVipInstance.
type LookupRabbitmqVipInstanceResultOutput struct{ *pulumi.OutputState }

func (LookupRabbitmqVipInstanceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRabbitmqVipInstanceResult)(nil)).Elem()
}

func (o LookupRabbitmqVipInstanceResultOutput) ToLookupRabbitmqVipInstanceResultOutput() LookupRabbitmqVipInstanceResultOutput {
	return o
}

func (o LookupRabbitmqVipInstanceResultOutput) ToLookupRabbitmqVipInstanceResultOutputWithContext(ctx context.Context) LookupRabbitmqVipInstanceResultOutput {
	return o
}

func (o LookupRabbitmqVipInstanceResultOutput) Filters() GetRabbitmqVipInstanceFilterArrayOutput {
	return o.ApplyT(func(v LookupRabbitmqVipInstanceResult) []GetRabbitmqVipInstanceFilter { return v.Filters }).(GetRabbitmqVipInstanceFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupRabbitmqVipInstanceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRabbitmqVipInstanceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupRabbitmqVipInstanceResultOutput) Instances() GetRabbitmqVipInstanceInstanceArrayOutput {
	return o.ApplyT(func(v LookupRabbitmqVipInstanceResult) []GetRabbitmqVipInstanceInstance { return v.Instances }).(GetRabbitmqVipInstanceInstanceArrayOutput)
}

func (o LookupRabbitmqVipInstanceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRabbitmqVipInstanceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRabbitmqVipInstanceResultOutput{})
}
