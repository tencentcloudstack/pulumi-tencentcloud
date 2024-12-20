// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tse

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tse gatewayServices
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tse"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Tse.GetGatewayServices(ctx, &tse.GetGatewayServicesArgs{
//				Filters: []tse.GetGatewayServicesFilter{
//					{
//						Key:   pulumi.StringRef("name"),
//						Value: pulumi.StringRef("test"),
//					},
//				},
//				GatewayId: "gateway-ddbb709b",
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
func LookupGatewayServices(ctx *pulumi.Context, args *LookupGatewayServicesArgs, opts ...pulumi.InvokeOption) (*LookupGatewayServicesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupGatewayServicesResult
	err := ctx.Invoke("tencentcloud:Tse/getGatewayServices:getGatewayServices", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGatewayServices.
type LookupGatewayServicesArgs struct {
	// filter conditions, valid value:name,upstreamType.
	Filters []GetGatewayServicesFilter `pulumi:"filters"`
	// gateway ID.
	GatewayId string `pulumi:"gatewayId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getGatewayServices.
type LookupGatewayServicesResult struct {
	Filters   []GetGatewayServicesFilter `pulumi:"filters"`
	GatewayId string                     `pulumi:"gatewayId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// result.
	Results []GetGatewayServicesResult `pulumi:"results"`
}

func LookupGatewayServicesOutput(ctx *pulumi.Context, args LookupGatewayServicesOutputArgs, opts ...pulumi.InvokeOption) LookupGatewayServicesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupGatewayServicesResult, error) {
			args := v.(LookupGatewayServicesArgs)
			r, err := LookupGatewayServices(ctx, &args, opts...)
			var s LookupGatewayServicesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupGatewayServicesResultOutput)
}

// A collection of arguments for invoking getGatewayServices.
type LookupGatewayServicesOutputArgs struct {
	// filter conditions, valid value:name,upstreamType.
	Filters GetGatewayServicesFilterArrayInput `pulumi:"filters"`
	// gateway ID.
	GatewayId pulumi.StringInput `pulumi:"gatewayId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (LookupGatewayServicesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGatewayServicesArgs)(nil)).Elem()
}

// A collection of values returned by getGatewayServices.
type LookupGatewayServicesResultOutput struct{ *pulumi.OutputState }

func (LookupGatewayServicesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGatewayServicesResult)(nil)).Elem()
}

func (o LookupGatewayServicesResultOutput) ToLookupGatewayServicesResultOutput() LookupGatewayServicesResultOutput {
	return o
}

func (o LookupGatewayServicesResultOutput) ToLookupGatewayServicesResultOutputWithContext(ctx context.Context) LookupGatewayServicesResultOutput {
	return o
}

func (o LookupGatewayServicesResultOutput) Filters() GetGatewayServicesFilterArrayOutput {
	return o.ApplyT(func(v LookupGatewayServicesResult) []GetGatewayServicesFilter { return v.Filters }).(GetGatewayServicesFilterArrayOutput)
}

func (o LookupGatewayServicesResultOutput) GatewayId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGatewayServicesResult) string { return v.GatewayId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupGatewayServicesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGatewayServicesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupGatewayServicesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupGatewayServicesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// result.
func (o LookupGatewayServicesResultOutput) Results() GetGatewayServicesResultArrayOutput {
	return o.ApplyT(func(v LookupGatewayServicesResult) []GetGatewayServicesResult { return v.Results }).(GetGatewayServicesResultArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupGatewayServicesResultOutput{})
}
