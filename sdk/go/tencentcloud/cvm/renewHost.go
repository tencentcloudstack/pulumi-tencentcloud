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

type RenewHost struct {
	pulumi.CustomResourceState

	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
	// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
	// the payment mode of the specified instance is prepaid, this parameter must be passed.
	HostChargePrepaid RenewHostHostChargePrepaidOutput `pulumi:"hostChargePrepaid"`
	// CDH instance ID.
	HostId pulumi.StringOutput `pulumi:"hostId"`
}

// NewRenewHost registers a new resource with the given unique name, arguments, and options.
func NewRenewHost(ctx *pulumi.Context,
	name string, args *RenewHostArgs, opts ...pulumi.ResourceOption) (*RenewHost, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.HostChargePrepaid == nil {
		return nil, errors.New("invalid value for required argument 'HostChargePrepaid'")
	}
	if args.HostId == nil {
		return nil, errors.New("invalid value for required argument 'HostId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RenewHost
	err := ctx.RegisterResource("tencentcloud:Cvm/renewHost:RenewHost", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRenewHost gets an existing RenewHost resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRenewHost(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RenewHostState, opts ...pulumi.ResourceOption) (*RenewHost, error) {
	var resource RenewHost
	err := ctx.ReadResource("tencentcloud:Cvm/renewHost:RenewHost", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RenewHost resources.
type renewHostState struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
	// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
	// the payment mode of the specified instance is prepaid, this parameter must be passed.
	HostChargePrepaid *RenewHostHostChargePrepaid `pulumi:"hostChargePrepaid"`
	// CDH instance ID.
	HostId *string `pulumi:"hostId"`
}

type RenewHostState struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
	// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
	// the payment mode of the specified instance is prepaid, this parameter must be passed.
	HostChargePrepaid RenewHostHostChargePrepaidPtrInput
	// CDH instance ID.
	HostId pulumi.StringPtrInput
}

func (RenewHostState) ElementType() reflect.Type {
	return reflect.TypeOf((*renewHostState)(nil)).Elem()
}

type renewHostArgs struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
	// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
	// the payment mode of the specified instance is prepaid, this parameter must be passed.
	HostChargePrepaid RenewHostHostChargePrepaid `pulumi:"hostChargePrepaid"`
	// CDH instance ID.
	HostId string `pulumi:"hostId"`
}

// The set of arguments for constructing a RenewHost resource.
type RenewHostArgs struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
	// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
	// the payment mode of the specified instance is prepaid, this parameter must be passed.
	HostChargePrepaid RenewHostHostChargePrepaidInput
	// CDH instance ID.
	HostId pulumi.StringInput
}

func (RenewHostArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*renewHostArgs)(nil)).Elem()
}

type RenewHostInput interface {
	pulumi.Input

	ToRenewHostOutput() RenewHostOutput
	ToRenewHostOutputWithContext(ctx context.Context) RenewHostOutput
}

func (*RenewHost) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewHost)(nil)).Elem()
}

func (i *RenewHost) ToRenewHostOutput() RenewHostOutput {
	return i.ToRenewHostOutputWithContext(context.Background())
}

func (i *RenewHost) ToRenewHostOutputWithContext(ctx context.Context) RenewHostOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewHostOutput)
}

// RenewHostArrayInput is an input type that accepts RenewHostArray and RenewHostArrayOutput values.
// You can construct a concrete instance of `RenewHostArrayInput` via:
//
//	RenewHostArray{ RenewHostArgs{...} }
type RenewHostArrayInput interface {
	pulumi.Input

	ToRenewHostArrayOutput() RenewHostArrayOutput
	ToRenewHostArrayOutputWithContext(context.Context) RenewHostArrayOutput
}

type RenewHostArray []RenewHostInput

func (RenewHostArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewHost)(nil)).Elem()
}

func (i RenewHostArray) ToRenewHostArrayOutput() RenewHostArrayOutput {
	return i.ToRenewHostArrayOutputWithContext(context.Background())
}

func (i RenewHostArray) ToRenewHostArrayOutputWithContext(ctx context.Context) RenewHostArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewHostArrayOutput)
}

// RenewHostMapInput is an input type that accepts RenewHostMap and RenewHostMapOutput values.
// You can construct a concrete instance of `RenewHostMapInput` via:
//
//	RenewHostMap{ "key": RenewHostArgs{...} }
type RenewHostMapInput interface {
	pulumi.Input

	ToRenewHostMapOutput() RenewHostMapOutput
	ToRenewHostMapOutputWithContext(context.Context) RenewHostMapOutput
}

type RenewHostMap map[string]RenewHostInput

func (RenewHostMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewHost)(nil)).Elem()
}

func (i RenewHostMap) ToRenewHostMapOutput() RenewHostMapOutput {
	return i.ToRenewHostMapOutputWithContext(context.Background())
}

func (i RenewHostMap) ToRenewHostMapOutputWithContext(ctx context.Context) RenewHostMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewHostMapOutput)
}

type RenewHostOutput struct{ *pulumi.OutputState }

func (RenewHostOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewHost)(nil)).Elem()
}

func (o RenewHostOutput) ToRenewHostOutput() RenewHostOutput {
	return o
}

func (o RenewHostOutput) ToRenewHostOutputWithContext(ctx context.Context) RenewHostOutput {
	return o
}

// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
// specify attributes such as the purchase duration of the Subscription instance and whether to set automatic renewal. If
// the payment mode of the specified instance is prepaid, this parameter must be passed.
func (o RenewHostOutput) HostChargePrepaid() RenewHostHostChargePrepaidOutput {
	return o.ApplyT(func(v *RenewHost) RenewHostHostChargePrepaidOutput { return v.HostChargePrepaid }).(RenewHostHostChargePrepaidOutput)
}

// CDH instance ID.
func (o RenewHostOutput) HostId() pulumi.StringOutput {
	return o.ApplyT(func(v *RenewHost) pulumi.StringOutput { return v.HostId }).(pulumi.StringOutput)
}

type RenewHostArrayOutput struct{ *pulumi.OutputState }

func (RenewHostArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewHost)(nil)).Elem()
}

func (o RenewHostArrayOutput) ToRenewHostArrayOutput() RenewHostArrayOutput {
	return o
}

func (o RenewHostArrayOutput) ToRenewHostArrayOutputWithContext(ctx context.Context) RenewHostArrayOutput {
	return o
}

func (o RenewHostArrayOutput) Index(i pulumi.IntInput) RenewHostOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RenewHost {
		return vs[0].([]*RenewHost)[vs[1].(int)]
	}).(RenewHostOutput)
}

type RenewHostMapOutput struct{ *pulumi.OutputState }

func (RenewHostMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewHost)(nil)).Elem()
}

func (o RenewHostMapOutput) ToRenewHostMapOutput() RenewHostMapOutput {
	return o
}

func (o RenewHostMapOutput) ToRenewHostMapOutputWithContext(ctx context.Context) RenewHostMapOutput {
	return o
}

func (o RenewHostMapOutput) MapIndex(k pulumi.StringInput) RenewHostOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RenewHost {
		return vs[0].(map[string]*RenewHost)[vs[1].(string)]
	}).(RenewHostOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RenewHostInput)(nil)).Elem(), &RenewHost{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewHostArrayInput)(nil)).Elem(), RenewHostArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewHostMapInput)(nil)).Elem(), RenewHostMap{})
	pulumi.RegisterOutputType(RenewHostOutput{})
	pulumi.RegisterOutputType(RenewHostArrayOutput{})
	pulumi.RegisterOutputType(RenewHostMapOutput{})
}
