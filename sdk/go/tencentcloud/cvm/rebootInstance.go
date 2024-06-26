// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cvm

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a cvm rebootInstance
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cvm"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Cvm.NewRebootInstance(ctx, "rebootInstance", &Cvm.RebootInstanceArgs{
//				InstanceId: pulumi.String("ins-f9jr4bd2"),
//				StopType:   pulumi.String("SOFT_FIRST"),
//			})
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
type RebootInstance struct {
	pulumi.CustomResourceState

	// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
	//
	// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
	ForceReboot pulumi.BoolPtrOutput `pulumi:"forceReboot"`
	// Instance ID.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
	StopType pulumi.StringPtrOutput `pulumi:"stopType"`
}

// NewRebootInstance registers a new resource with the given unique name, arguments, and options.
func NewRebootInstance(ctx *pulumi.Context,
	name string, args *RebootInstanceArgs, opts ...pulumi.ResourceOption) (*RebootInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RebootInstance
	err := ctx.RegisterResource("tencentcloud:Cvm/rebootInstance:RebootInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRebootInstance gets an existing RebootInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRebootInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RebootInstanceState, opts ...pulumi.ResourceOption) (*RebootInstance, error) {
	var resource RebootInstance
	err := ctx.ReadResource("tencentcloud:Cvm/rebootInstance:RebootInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RebootInstance resources.
type rebootInstanceState struct {
	// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
	//
	// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
	ForceReboot *bool `pulumi:"forceReboot"`
	// Instance ID.
	InstanceId *string `pulumi:"instanceId"`
	// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
	StopType *string `pulumi:"stopType"`
}

type RebootInstanceState struct {
	// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
	//
	// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
	ForceReboot pulumi.BoolPtrInput
	// Instance ID.
	InstanceId pulumi.StringPtrInput
	// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
	StopType pulumi.StringPtrInput
}

func (RebootInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*rebootInstanceState)(nil)).Elem()
}

type rebootInstanceArgs struct {
	// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
	//
	// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
	ForceReboot *bool `pulumi:"forceReboot"`
	// Instance ID.
	InstanceId string `pulumi:"instanceId"`
	// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
	StopType *string `pulumi:"stopType"`
}

// The set of arguments for constructing a RebootInstance resource.
type RebootInstanceArgs struct {
	// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
	//
	// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
	ForceReboot pulumi.BoolPtrInput
	// Instance ID.
	InstanceId pulumi.StringInput
	// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
	StopType pulumi.StringPtrInput
}

func (RebootInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*rebootInstanceArgs)(nil)).Elem()
}

type RebootInstanceInput interface {
	pulumi.Input

	ToRebootInstanceOutput() RebootInstanceOutput
	ToRebootInstanceOutputWithContext(ctx context.Context) RebootInstanceOutput
}

func (*RebootInstance) ElementType() reflect.Type {
	return reflect.TypeOf((**RebootInstance)(nil)).Elem()
}

func (i *RebootInstance) ToRebootInstanceOutput() RebootInstanceOutput {
	return i.ToRebootInstanceOutputWithContext(context.Background())
}

func (i *RebootInstance) ToRebootInstanceOutputWithContext(ctx context.Context) RebootInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RebootInstanceOutput)
}

// RebootInstanceArrayInput is an input type that accepts RebootInstanceArray and RebootInstanceArrayOutput values.
// You can construct a concrete instance of `RebootInstanceArrayInput` via:
//
//	RebootInstanceArray{ RebootInstanceArgs{...} }
type RebootInstanceArrayInput interface {
	pulumi.Input

	ToRebootInstanceArrayOutput() RebootInstanceArrayOutput
	ToRebootInstanceArrayOutputWithContext(context.Context) RebootInstanceArrayOutput
}

type RebootInstanceArray []RebootInstanceInput

func (RebootInstanceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RebootInstance)(nil)).Elem()
}

func (i RebootInstanceArray) ToRebootInstanceArrayOutput() RebootInstanceArrayOutput {
	return i.ToRebootInstanceArrayOutputWithContext(context.Background())
}

func (i RebootInstanceArray) ToRebootInstanceArrayOutputWithContext(ctx context.Context) RebootInstanceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RebootInstanceArrayOutput)
}

// RebootInstanceMapInput is an input type that accepts RebootInstanceMap and RebootInstanceMapOutput values.
// You can construct a concrete instance of `RebootInstanceMapInput` via:
//
//	RebootInstanceMap{ "key": RebootInstanceArgs{...} }
type RebootInstanceMapInput interface {
	pulumi.Input

	ToRebootInstanceMapOutput() RebootInstanceMapOutput
	ToRebootInstanceMapOutputWithContext(context.Context) RebootInstanceMapOutput
}

type RebootInstanceMap map[string]RebootInstanceInput

func (RebootInstanceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RebootInstance)(nil)).Elem()
}

func (i RebootInstanceMap) ToRebootInstanceMapOutput() RebootInstanceMapOutput {
	return i.ToRebootInstanceMapOutputWithContext(context.Background())
}

func (i RebootInstanceMap) ToRebootInstanceMapOutputWithContext(ctx context.Context) RebootInstanceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RebootInstanceMapOutput)
}

type RebootInstanceOutput struct{ *pulumi.OutputState }

func (RebootInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RebootInstance)(nil)).Elem()
}

func (o RebootInstanceOutput) ToRebootInstanceOutput() RebootInstanceOutput {
	return o
}

func (o RebootInstanceOutput) ToRebootInstanceOutputWithContext(ctx context.Context) RebootInstanceOutput {
	return o
}

// It has been deprecated from version 1.81.21. Please use `stopType` instead. This parameter has been disused. We recommend using StopType instead. Note that ForceReboot and StopType parameters cannot be specified at the same time. Whether to forcibly restart an instance after a normal restart fails. Valid values are `TRUE` and `FALSE`. Default value: FALSE.
//
// Deprecated: It has been deprecated from version 1.81.21. Please use `stopType` instead.
func (o RebootInstanceOutput) ForceReboot() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *RebootInstance) pulumi.BoolPtrOutput { return v.ForceReboot }).(pulumi.BoolPtrOutput)
}

// Instance ID.
func (o RebootInstanceOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *RebootInstance) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Shutdown type. Valid values: `SOFT`: soft shutdown; `HARD`: hard shutdown; `SOFT_FIRST`: perform a soft shutdown first, and perform a hard shutdown if the soft shutdown fails. Default value: SOFT.
func (o RebootInstanceOutput) StopType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *RebootInstance) pulumi.StringPtrOutput { return v.StopType }).(pulumi.StringPtrOutput)
}

type RebootInstanceArrayOutput struct{ *pulumi.OutputState }

func (RebootInstanceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RebootInstance)(nil)).Elem()
}

func (o RebootInstanceArrayOutput) ToRebootInstanceArrayOutput() RebootInstanceArrayOutput {
	return o
}

func (o RebootInstanceArrayOutput) ToRebootInstanceArrayOutputWithContext(ctx context.Context) RebootInstanceArrayOutput {
	return o
}

func (o RebootInstanceArrayOutput) Index(i pulumi.IntInput) RebootInstanceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RebootInstance {
		return vs[0].([]*RebootInstance)[vs[1].(int)]
	}).(RebootInstanceOutput)
}

type RebootInstanceMapOutput struct{ *pulumi.OutputState }

func (RebootInstanceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RebootInstance)(nil)).Elem()
}

func (o RebootInstanceMapOutput) ToRebootInstanceMapOutput() RebootInstanceMapOutput {
	return o
}

func (o RebootInstanceMapOutput) ToRebootInstanceMapOutputWithContext(ctx context.Context) RebootInstanceMapOutput {
	return o
}

func (o RebootInstanceMapOutput) MapIndex(k pulumi.StringInput) RebootInstanceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RebootInstance {
		return vs[0].(map[string]*RebootInstance)[vs[1].(string)]
	}).(RebootInstanceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RebootInstanceInput)(nil)).Elem(), &RebootInstance{})
	pulumi.RegisterInputType(reflect.TypeOf((*RebootInstanceArrayInput)(nil)).Elem(), RebootInstanceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RebootInstanceMapInput)(nil)).Elem(), RebootInstanceMap{})
	pulumi.RegisterOutputType(RebootInstanceOutput{})
	pulumi.RegisterOutputType(RebootInstanceArrayOutput{})
	pulumi.RegisterOutputType(RebootInstanceMapOutput{})
}
