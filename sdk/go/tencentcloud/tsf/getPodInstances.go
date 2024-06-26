// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tsf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tsf podInstances
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tsf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Tsf.GetPodInstances(ctx, &tsf.GetPodInstancesArgs{
//				GroupId: "group-ynd95rea",
//				PodNameLists: []string{
//					"keep-terraform-6f8f977688-zvphm",
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
func LookupPodInstances(ctx *pulumi.Context, args *LookupPodInstancesArgs, opts ...pulumi.InvokeOption) (*LookupPodInstancesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupPodInstancesResult
	err := ctx.Invoke("tencentcloud:Tsf/getPodInstances:getPodInstances", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPodInstances.
type LookupPodInstancesArgs struct {
	// Instance&amp;#39;s group ID.
	GroupId string `pulumi:"groupId"`
	// Filter, pod name list.
	PodNameLists []string `pulumi:"podNameLists"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getPodInstances.
type LookupPodInstancesResult struct {
	GroupId string `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string   `pulumi:"id"`
	PodNameLists     []string `pulumi:"podNameLists"`
	ResultOutputFile *string  `pulumi:"resultOutputFile"`
	// pod instance list.
	Results []GetPodInstancesResult `pulumi:"results"`
}

func LookupPodInstancesOutput(ctx *pulumi.Context, args LookupPodInstancesOutputArgs, opts ...pulumi.InvokeOption) LookupPodInstancesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupPodInstancesResult, error) {
			args := v.(LookupPodInstancesArgs)
			r, err := LookupPodInstances(ctx, &args, opts...)
			var s LookupPodInstancesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupPodInstancesResultOutput)
}

// A collection of arguments for invoking getPodInstances.
type LookupPodInstancesOutputArgs struct {
	// Instance&amp;#39;s group ID.
	GroupId pulumi.StringInput `pulumi:"groupId"`
	// Filter, pod name list.
	PodNameLists pulumi.StringArrayInput `pulumi:"podNameLists"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (LookupPodInstancesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPodInstancesArgs)(nil)).Elem()
}

// A collection of values returned by getPodInstances.
type LookupPodInstancesResultOutput struct{ *pulumi.OutputState }

func (LookupPodInstancesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupPodInstancesResult)(nil)).Elem()
}

func (o LookupPodInstancesResultOutput) ToLookupPodInstancesResultOutput() LookupPodInstancesResultOutput {
	return o
}

func (o LookupPodInstancesResultOutput) ToLookupPodInstancesResultOutputWithContext(ctx context.Context) LookupPodInstancesResultOutput {
	return o
}

func (o LookupPodInstancesResultOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPodInstancesResult) string { return v.GroupId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupPodInstancesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupPodInstancesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupPodInstancesResultOutput) PodNameLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupPodInstancesResult) []string { return v.PodNameLists }).(pulumi.StringArrayOutput)
}

func (o LookupPodInstancesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupPodInstancesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// pod instance list.
func (o LookupPodInstancesResultOutput) Results() GetPodInstancesResultArrayOutput {
	return o.ApplyT(func(v LookupPodInstancesResult) []GetPodInstancesResult { return v.Results }).(GetPodInstancesResultArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupPodInstancesResultOutput{})
}
