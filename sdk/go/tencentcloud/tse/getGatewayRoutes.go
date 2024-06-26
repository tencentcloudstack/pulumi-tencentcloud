// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tse

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tse gatewayRoutes
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
//			_, err := Tse.GetGatewayRoutes(ctx, &tse.GetGatewayRoutesArgs{
//				GatewayId:   "gateway-ddbb709b",
//				RouteName:   pulumi.StringRef("keep-routes"),
//				ServiceName: pulumi.StringRef("test"),
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
func LookupGatewayRoutes(ctx *pulumi.Context, args *LookupGatewayRoutesArgs, opts ...pulumi.InvokeOption) (*LookupGatewayRoutesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupGatewayRoutesResult
	err := ctx.Invoke("tencentcloud:Tse/getGatewayRoutes:getGatewayRoutes", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGatewayRoutes.
type LookupGatewayRoutesArgs struct {
	// gateway ID.
	GatewayId string `pulumi:"gatewayId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// route name.
	RouteName *string `pulumi:"routeName"`
	// service name.
	ServiceName *string `pulumi:"serviceName"`
}

// A collection of values returned by getGatewayRoutes.
type LookupGatewayRoutesResult struct {
	GatewayId string `pulumi:"gatewayId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// result.
	Results   []GetGatewayRoutesResult `pulumi:"results"`
	RouteName *string                  `pulumi:"routeName"`
	// service name.
	ServiceName *string `pulumi:"serviceName"`
}

func LookupGatewayRoutesOutput(ctx *pulumi.Context, args LookupGatewayRoutesOutputArgs, opts ...pulumi.InvokeOption) LookupGatewayRoutesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupGatewayRoutesResult, error) {
			args := v.(LookupGatewayRoutesArgs)
			r, err := LookupGatewayRoutes(ctx, &args, opts...)
			var s LookupGatewayRoutesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupGatewayRoutesResultOutput)
}

// A collection of arguments for invoking getGatewayRoutes.
type LookupGatewayRoutesOutputArgs struct {
	// gateway ID.
	GatewayId pulumi.StringInput `pulumi:"gatewayId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// route name.
	RouteName pulumi.StringPtrInput `pulumi:"routeName"`
	// service name.
	ServiceName pulumi.StringPtrInput `pulumi:"serviceName"`
}

func (LookupGatewayRoutesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGatewayRoutesArgs)(nil)).Elem()
}

// A collection of values returned by getGatewayRoutes.
type LookupGatewayRoutesResultOutput struct{ *pulumi.OutputState }

func (LookupGatewayRoutesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupGatewayRoutesResult)(nil)).Elem()
}

func (o LookupGatewayRoutesResultOutput) ToLookupGatewayRoutesResultOutput() LookupGatewayRoutesResultOutput {
	return o
}

func (o LookupGatewayRoutesResultOutput) ToLookupGatewayRoutesResultOutputWithContext(ctx context.Context) LookupGatewayRoutesResultOutput {
	return o
}

func (o LookupGatewayRoutesResultOutput) GatewayId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) string { return v.GatewayId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupGatewayRoutesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupGatewayRoutesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// result.
func (o LookupGatewayRoutesResultOutput) Results() GetGatewayRoutesResultArrayOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) []GetGatewayRoutesResult { return v.Results }).(GetGatewayRoutesResultArrayOutput)
}

func (o LookupGatewayRoutesResultOutput) RouteName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) *string { return v.RouteName }).(pulumi.StringPtrOutput)
}

// service name.
func (o LookupGatewayRoutesResultOutput) ServiceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupGatewayRoutesResult) *string { return v.ServiceName }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupGatewayRoutesResultOutput{})
}
