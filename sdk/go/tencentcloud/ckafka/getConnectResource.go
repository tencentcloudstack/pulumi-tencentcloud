// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ckafka

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of ckafka connectResource
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Ckafka"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ckafka"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Ckafka.GetConnectResource(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupConnectResource(ctx *pulumi.Context, args *LookupConnectResourceArgs, opts ...pulumi.InvokeOption) (*LookupConnectResourceResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupConnectResourceResult
	err := ctx.Invoke("tencentcloud:Ckafka/getConnectResource:getConnectResource", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getConnectResource.
type LookupConnectResourceArgs struct {
	// Return the number, the default is 20, the maximum is 100.
	Limit *int `pulumi:"limit"`
	// Page offset, default is 0.
	Offset *int `pulumi:"offset"`
	// Keyword query of the connection source, query the connection in the connection management list in the local region according to the region (only support the connection source containing the region input).
	ResourceRegion *string `pulumi:"resourceRegion"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Keyword for search.
	SearchWord *string `pulumi:"searchWord"`
	// connection source type.
	Type *string `pulumi:"type"`
}

// A collection of values returned by getConnectResource.
type LookupConnectResourceResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Limit            *int    `pulumi:"limit"`
	Offset           *int    `pulumi:"offset"`
	ResourceRegion   *string `pulumi:"resourceRegion"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Connection source list.
	Results    []GetConnectResourceResult `pulumi:"results"`
	SearchWord *string                    `pulumi:"searchWord"`
	// Resource type.
	Type *string `pulumi:"type"`
}

func LookupConnectResourceOutput(ctx *pulumi.Context, args LookupConnectResourceOutputArgs, opts ...pulumi.InvokeOption) LookupConnectResourceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupConnectResourceResult, error) {
			args := v.(LookupConnectResourceArgs)
			r, err := LookupConnectResource(ctx, &args, opts...)
			var s LookupConnectResourceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupConnectResourceResultOutput)
}

// A collection of arguments for invoking getConnectResource.
type LookupConnectResourceOutputArgs struct {
	// Return the number, the default is 20, the maximum is 100.
	Limit pulumi.IntPtrInput `pulumi:"limit"`
	// Page offset, default is 0.
	Offset pulumi.IntPtrInput `pulumi:"offset"`
	// Keyword query of the connection source, query the connection in the connection management list in the local region according to the region (only support the connection source containing the region input).
	ResourceRegion pulumi.StringPtrInput `pulumi:"resourceRegion"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Keyword for search.
	SearchWord pulumi.StringPtrInput `pulumi:"searchWord"`
	// connection source type.
	Type pulumi.StringPtrInput `pulumi:"type"`
}

func (LookupConnectResourceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConnectResourceArgs)(nil)).Elem()
}

// A collection of values returned by getConnectResource.
type LookupConnectResourceResultOutput struct{ *pulumi.OutputState }

func (LookupConnectResourceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupConnectResourceResult)(nil)).Elem()
}

func (o LookupConnectResourceResultOutput) ToLookupConnectResourceResultOutput() LookupConnectResourceResultOutput {
	return o
}

func (o LookupConnectResourceResultOutput) ToLookupConnectResourceResultOutputWithContext(ctx context.Context) LookupConnectResourceResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o LookupConnectResourceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupConnectResourceResultOutput) Limit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *int { return v.Limit }).(pulumi.IntPtrOutput)
}

func (o LookupConnectResourceResultOutput) Offset() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *int { return v.Offset }).(pulumi.IntPtrOutput)
}

func (o LookupConnectResourceResultOutput) ResourceRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *string { return v.ResourceRegion }).(pulumi.StringPtrOutput)
}

func (o LookupConnectResourceResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Connection source list.
func (o LookupConnectResourceResultOutput) Results() GetConnectResourceResultArrayOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) []GetConnectResourceResult { return v.Results }).(GetConnectResourceResultArrayOutput)
}

func (o LookupConnectResourceResultOutput) SearchWord() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *string { return v.SearchWord }).(pulumi.StringPtrOutput)
}

// Resource type.
func (o LookupConnectResourceResultOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupConnectResourceResult) *string { return v.Type }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupConnectResourceResultOutput{})
}