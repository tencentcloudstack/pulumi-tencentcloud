// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package batch

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

var _ = internal.GetEnvOrDefault

type ApplyAccountBaselinesBaselineConfigItem struct {
	// Account Factory baseline item configuration. Different items have different parameters.Note: This field may return null, indicating that no valid values can be obtained.
	Configuration *string `pulumi:"configuration"`
	// A unique identifier for an Account Factory baseline item, which can only contain English letters, digits, and @,._[]-:()+=. It must be 2-128 characters long.Note: This field may return null, indicating that no valid values can be obtained.
	Identifier *string `pulumi:"identifier"`
}

// ApplyAccountBaselinesBaselineConfigItemInput is an input type that accepts ApplyAccountBaselinesBaselineConfigItemArgs and ApplyAccountBaselinesBaselineConfigItemOutput values.
// You can construct a concrete instance of `ApplyAccountBaselinesBaselineConfigItemInput` via:
//
//	ApplyAccountBaselinesBaselineConfigItemArgs{...}
type ApplyAccountBaselinesBaselineConfigItemInput interface {
	pulumi.Input

	ToApplyAccountBaselinesBaselineConfigItemOutput() ApplyAccountBaselinesBaselineConfigItemOutput
	ToApplyAccountBaselinesBaselineConfigItemOutputWithContext(context.Context) ApplyAccountBaselinesBaselineConfigItemOutput
}

type ApplyAccountBaselinesBaselineConfigItemArgs struct {
	// Account Factory baseline item configuration. Different items have different parameters.Note: This field may return null, indicating that no valid values can be obtained.
	Configuration pulumi.StringPtrInput `pulumi:"configuration"`
	// A unique identifier for an Account Factory baseline item, which can only contain English letters, digits, and @,._[]-:()+=. It must be 2-128 characters long.Note: This field may return null, indicating that no valid values can be obtained.
	Identifier pulumi.StringPtrInput `pulumi:"identifier"`
}

func (ApplyAccountBaselinesBaselineConfigItemArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplyAccountBaselinesBaselineConfigItem)(nil)).Elem()
}

func (i ApplyAccountBaselinesBaselineConfigItemArgs) ToApplyAccountBaselinesBaselineConfigItemOutput() ApplyAccountBaselinesBaselineConfigItemOutput {
	return i.ToApplyAccountBaselinesBaselineConfigItemOutputWithContext(context.Background())
}

func (i ApplyAccountBaselinesBaselineConfigItemArgs) ToApplyAccountBaselinesBaselineConfigItemOutputWithContext(ctx context.Context) ApplyAccountBaselinesBaselineConfigItemOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplyAccountBaselinesBaselineConfigItemOutput)
}

// ApplyAccountBaselinesBaselineConfigItemArrayInput is an input type that accepts ApplyAccountBaselinesBaselineConfigItemArray and ApplyAccountBaselinesBaselineConfigItemArrayOutput values.
// You can construct a concrete instance of `ApplyAccountBaselinesBaselineConfigItemArrayInput` via:
//
//	ApplyAccountBaselinesBaselineConfigItemArray{ ApplyAccountBaselinesBaselineConfigItemArgs{...} }
type ApplyAccountBaselinesBaselineConfigItemArrayInput interface {
	pulumi.Input

	ToApplyAccountBaselinesBaselineConfigItemArrayOutput() ApplyAccountBaselinesBaselineConfigItemArrayOutput
	ToApplyAccountBaselinesBaselineConfigItemArrayOutputWithContext(context.Context) ApplyAccountBaselinesBaselineConfigItemArrayOutput
}

type ApplyAccountBaselinesBaselineConfigItemArray []ApplyAccountBaselinesBaselineConfigItemInput

func (ApplyAccountBaselinesBaselineConfigItemArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ApplyAccountBaselinesBaselineConfigItem)(nil)).Elem()
}

func (i ApplyAccountBaselinesBaselineConfigItemArray) ToApplyAccountBaselinesBaselineConfigItemArrayOutput() ApplyAccountBaselinesBaselineConfigItemArrayOutput {
	return i.ToApplyAccountBaselinesBaselineConfigItemArrayOutputWithContext(context.Background())
}

func (i ApplyAccountBaselinesBaselineConfigItemArray) ToApplyAccountBaselinesBaselineConfigItemArrayOutputWithContext(ctx context.Context) ApplyAccountBaselinesBaselineConfigItemArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ApplyAccountBaselinesBaselineConfigItemArrayOutput)
}

type ApplyAccountBaselinesBaselineConfigItemOutput struct{ *pulumi.OutputState }

func (ApplyAccountBaselinesBaselineConfigItemOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ApplyAccountBaselinesBaselineConfigItem)(nil)).Elem()
}

func (o ApplyAccountBaselinesBaselineConfigItemOutput) ToApplyAccountBaselinesBaselineConfigItemOutput() ApplyAccountBaselinesBaselineConfigItemOutput {
	return o
}

func (o ApplyAccountBaselinesBaselineConfigItemOutput) ToApplyAccountBaselinesBaselineConfigItemOutputWithContext(ctx context.Context) ApplyAccountBaselinesBaselineConfigItemOutput {
	return o
}

// Account Factory baseline item configuration. Different items have different parameters.Note: This field may return null, indicating that no valid values can be obtained.
func (o ApplyAccountBaselinesBaselineConfigItemOutput) Configuration() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ApplyAccountBaselinesBaselineConfigItem) *string { return v.Configuration }).(pulumi.StringPtrOutput)
}

// A unique identifier for an Account Factory baseline item, which can only contain English letters, digits, and @,._[]-:()+=. It must be 2-128 characters long.Note: This field may return null, indicating that no valid values can be obtained.
func (o ApplyAccountBaselinesBaselineConfigItemOutput) Identifier() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ApplyAccountBaselinesBaselineConfigItem) *string { return v.Identifier }).(pulumi.StringPtrOutput)
}

type ApplyAccountBaselinesBaselineConfigItemArrayOutput struct{ *pulumi.OutputState }

func (ApplyAccountBaselinesBaselineConfigItemArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ApplyAccountBaselinesBaselineConfigItem)(nil)).Elem()
}

func (o ApplyAccountBaselinesBaselineConfigItemArrayOutput) ToApplyAccountBaselinesBaselineConfigItemArrayOutput() ApplyAccountBaselinesBaselineConfigItemArrayOutput {
	return o
}

func (o ApplyAccountBaselinesBaselineConfigItemArrayOutput) ToApplyAccountBaselinesBaselineConfigItemArrayOutputWithContext(ctx context.Context) ApplyAccountBaselinesBaselineConfigItemArrayOutput {
	return o
}

func (o ApplyAccountBaselinesBaselineConfigItemArrayOutput) Index(i pulumi.IntInput) ApplyAccountBaselinesBaselineConfigItemOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ApplyAccountBaselinesBaselineConfigItem {
		return vs[0].([]ApplyAccountBaselinesBaselineConfigItem)[vs[1].(int)]
	}).(ApplyAccountBaselinesBaselineConfigItemOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ApplyAccountBaselinesBaselineConfigItemInput)(nil)).Elem(), ApplyAccountBaselinesBaselineConfigItemArgs{})
	pulumi.RegisterInputType(reflect.TypeOf((*ApplyAccountBaselinesBaselineConfigItemArrayInput)(nil)).Elem(), ApplyAccountBaselinesBaselineConfigItemArray{})
	pulumi.RegisterOutputType(ApplyAccountBaselinesBaselineConfigItemOutput{})
	pulumi.RegisterOutputType(ApplyAccountBaselinesBaselineConfigItemArrayOutput{})
}