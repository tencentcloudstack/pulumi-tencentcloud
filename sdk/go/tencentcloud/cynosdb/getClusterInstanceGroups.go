// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cynosdb

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of cynosdb clusterInstanceGroups
func GetClusterInstanceGroups(ctx *pulumi.Context, args *GetClusterInstanceGroupsArgs, opts ...pulumi.InvokeOption) (*GetClusterInstanceGroupsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetClusterInstanceGroupsResult
	err := ctx.Invoke("tencentcloud:Cynosdb/getClusterInstanceGroups:getClusterInstanceGroups", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getClusterInstanceGroups.
type GetClusterInstanceGroupsArgs struct {
	// The ID of cluster.
	ClusterId string `pulumi:"clusterId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getClusterInstanceGroups.
type GetClusterInstanceGroupsResult struct {
	// The id of cluster.
	ClusterId string `pulumi:"clusterId"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// List of instance groups.
	InstanceGrpInfoLists []GetClusterInstanceGroupsInstanceGrpInfoList `pulumi:"instanceGrpInfoLists"`
	ResultOutputFile     *string                                       `pulumi:"resultOutputFile"`
}

func GetClusterInstanceGroupsOutput(ctx *pulumi.Context, args GetClusterInstanceGroupsOutputArgs, opts ...pulumi.InvokeOption) GetClusterInstanceGroupsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetClusterInstanceGroupsResult, error) {
			args := v.(GetClusterInstanceGroupsArgs)
			r, err := GetClusterInstanceGroups(ctx, &args, opts...)
			var s GetClusterInstanceGroupsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetClusterInstanceGroupsResultOutput)
}

// A collection of arguments for invoking getClusterInstanceGroups.
type GetClusterInstanceGroupsOutputArgs struct {
	// The ID of cluster.
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetClusterInstanceGroupsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterInstanceGroupsArgs)(nil)).Elem()
}

// A collection of values returned by getClusterInstanceGroups.
type GetClusterInstanceGroupsResultOutput struct{ *pulumi.OutputState }

func (GetClusterInstanceGroupsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClusterInstanceGroupsResult)(nil)).Elem()
}

func (o GetClusterInstanceGroupsResultOutput) ToGetClusterInstanceGroupsResultOutput() GetClusterInstanceGroupsResultOutput {
	return o
}

func (o GetClusterInstanceGroupsResultOutput) ToGetClusterInstanceGroupsResultOutputWithContext(ctx context.Context) GetClusterInstanceGroupsResultOutput {
	return o
}

// The id of cluster.
func (o GetClusterInstanceGroupsResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterInstanceGroupsResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetClusterInstanceGroupsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetClusterInstanceGroupsResult) string { return v.Id }).(pulumi.StringOutput)
}

// List of instance groups.
func (o GetClusterInstanceGroupsResultOutput) InstanceGrpInfoLists() GetClusterInstanceGroupsInstanceGrpInfoListArrayOutput {
	return o.ApplyT(func(v GetClusterInstanceGroupsResult) []GetClusterInstanceGroupsInstanceGrpInfoList {
		return v.InstanceGrpInfoLists
	}).(GetClusterInstanceGroupsInstanceGrpInfoListArrayOutput)
}

func (o GetClusterInstanceGroupsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetClusterInstanceGroupsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetClusterInstanceGroupsResultOutput{})
}
