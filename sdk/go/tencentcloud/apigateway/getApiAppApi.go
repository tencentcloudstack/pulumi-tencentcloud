// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package apigateway

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of apiGateway apiAppApi
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/ApiGateway"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := ApiGateway.GetApiAppApi(ctx, &apigateway.GetApiAppApiArgs{
//				ApiId:     "api-0cvmf4x4",
//				ApiRegion: "ap-guangzhou",
//				ServiceId: "service-nxz6yync",
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
func LookupApiAppApi(ctx *pulumi.Context, args *LookupApiAppApiArgs, opts ...pulumi.InvokeOption) (*LookupApiAppApiResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupApiAppApiResult
	err := ctx.Invoke("tencentcloud:ApiGateway/getApiAppApi:getApiAppApi", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getApiAppApi.
type LookupApiAppApiArgs struct {
	// API interface unique ID.
	ApiId string `pulumi:"apiId"`
	// Api region.
	ApiRegion string `pulumi:"apiRegion"`
	// Used to save apiAppApis.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The unique ID of the service where the API resides.
	ServiceId string `pulumi:"serviceId"`
}

// A collection of values returned by getApiAppApi.
type LookupApiAppApiResult struct {
	// API interface unique ID.
	ApiId     string `pulumi:"apiId"`
	ApiRegion string `pulumi:"apiRegion"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// API details.
	Results []GetApiAppApiResult `pulumi:"results"`
	// The unique ID of the service where the API resides.
	ServiceId string `pulumi:"serviceId"`
}

func LookupApiAppApiOutput(ctx *pulumi.Context, args LookupApiAppApiOutputArgs, opts ...pulumi.InvokeOption) LookupApiAppApiResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupApiAppApiResult, error) {
			args := v.(LookupApiAppApiArgs)
			r, err := LookupApiAppApi(ctx, &args, opts...)
			var s LookupApiAppApiResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupApiAppApiResultOutput)
}

// A collection of arguments for invoking getApiAppApi.
type LookupApiAppApiOutputArgs struct {
	// API interface unique ID.
	ApiId pulumi.StringInput `pulumi:"apiId"`
	// Api region.
	ApiRegion pulumi.StringInput `pulumi:"apiRegion"`
	// Used to save apiAppApis.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// The unique ID of the service where the API resides.
	ServiceId pulumi.StringInput `pulumi:"serviceId"`
}

func (LookupApiAppApiOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApiAppApiArgs)(nil)).Elem()
}

// A collection of values returned by getApiAppApi.
type LookupApiAppApiResultOutput struct{ *pulumi.OutputState }

func (LookupApiAppApiResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupApiAppApiResult)(nil)).Elem()
}

func (o LookupApiAppApiResultOutput) ToLookupApiAppApiResultOutput() LookupApiAppApiResultOutput {
	return o
}

func (o LookupApiAppApiResultOutput) ToLookupApiAppApiResultOutputWithContext(ctx context.Context) LookupApiAppApiResultOutput {
	return o
}

// API interface unique ID.
func (o LookupApiAppApiResultOutput) ApiId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) string { return v.ApiId }).(pulumi.StringOutput)
}

func (o LookupApiAppApiResultOutput) ApiRegion() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) string { return v.ApiRegion }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupApiAppApiResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupApiAppApiResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// API details.
func (o LookupApiAppApiResultOutput) Results() GetApiAppApiResultArrayOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) []GetApiAppApiResult { return v.Results }).(GetApiAppApiResultArrayOutput)
}

// The unique ID of the service where the API resides.
func (o LookupApiAppApiResultOutput) ServiceId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupApiAppApiResult) string { return v.ServiceId }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupApiAppApiResultOutput{})
}
