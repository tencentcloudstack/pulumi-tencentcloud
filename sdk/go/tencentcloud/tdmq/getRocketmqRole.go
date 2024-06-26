// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tdmq

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tdmqRocketmq role
func LookupRocketmqRole(ctx *pulumi.Context, args *LookupRocketmqRoleArgs, opts ...pulumi.InvokeOption) (*LookupRocketmqRoleResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupRocketmqRoleResult
	err := ctx.Invoke("tencentcloud:Tdmq/getRocketmqRole:getRocketmqRole", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRocketmqRole.
type LookupRocketmqRoleArgs struct {
	// Cluster ID (required).
	ClusterId string `pulumi:"clusterId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Fuzzy query by role name.
	RoleName *string `pulumi:"roleName"`
}

// A collection of values returned by getRocketmqRole.
type LookupRocketmqRoleResult struct {
	ClusterId string `pulumi:"clusterId"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Role name.
	RoleName *string `pulumi:"roleName"`
	// Array of roles.
	RoleSets []GetRocketmqRoleRoleSet `pulumi:"roleSets"`
}

func LookupRocketmqRoleOutput(ctx *pulumi.Context, args LookupRocketmqRoleOutputArgs, opts ...pulumi.InvokeOption) LookupRocketmqRoleResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupRocketmqRoleResult, error) {
			args := v.(LookupRocketmqRoleArgs)
			r, err := LookupRocketmqRole(ctx, &args, opts...)
			var s LookupRocketmqRoleResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupRocketmqRoleResultOutput)
}

// A collection of arguments for invoking getRocketmqRole.
type LookupRocketmqRoleOutputArgs struct {
	// Cluster ID (required).
	ClusterId pulumi.StringInput `pulumi:"clusterId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Fuzzy query by role name.
	RoleName pulumi.StringPtrInput `pulumi:"roleName"`
}

func (LookupRocketmqRoleOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRocketmqRoleArgs)(nil)).Elem()
}

// A collection of values returned by getRocketmqRole.
type LookupRocketmqRoleResultOutput struct{ *pulumi.OutputState }

func (LookupRocketmqRoleResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupRocketmqRoleResult)(nil)).Elem()
}

func (o LookupRocketmqRoleResultOutput) ToLookupRocketmqRoleResultOutput() LookupRocketmqRoleResultOutput {
	return o
}

func (o LookupRocketmqRoleResultOutput) ToLookupRocketmqRoleResultOutputWithContext(ctx context.Context) LookupRocketmqRoleResultOutput {
	return o
}

func (o LookupRocketmqRoleResultOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRocketmqRoleResult) string { return v.ClusterId }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupRocketmqRoleResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupRocketmqRoleResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupRocketmqRoleResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRocketmqRoleResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Role name.
func (o LookupRocketmqRoleResultOutput) RoleName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupRocketmqRoleResult) *string { return v.RoleName }).(pulumi.StringPtrOutput)
}

// Array of roles.
func (o LookupRocketmqRoleResultOutput) RoleSets() GetRocketmqRoleRoleSetArrayOutput {
	return o.ApplyT(func(v LookupRocketmqRoleResult) []GetRocketmqRoleRoleSet { return v.RoleSets }).(GetRocketmqRoleRoleSetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupRocketmqRoleResultOutput{})
}
