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

// Provides a resource to create a cvm renewInstance
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Instance"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			// create vpc
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("10.0.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			// create vpc subnet
//			subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				VpcId:            vpc.ID(),
//				AvailabilityZone: pulumi.String("ap-guangzhou-6"),
//				CidrBlock:        pulumi.String("10.0.20.0/28"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			// create cvm
//			exampleInstance, err := Instance.NewInstance(ctx, "exampleInstance", &Instance.InstanceArgs{
//				InstanceName:                       pulumi.String("tf_example"),
//				AvailabilityZone:                   pulumi.String("ap-guangzhou-6"),
//				ImageId:                            pulumi.String("img-9qrfy1xt"),
//				InstanceType:                       pulumi.String("SA3.MEDIUM4"),
//				SystemDiskType:                     pulumi.String("CLOUD_HSSD"),
//				SystemDiskSize:                     pulumi.Int(100),
//				Hostname:                           pulumi.String("example"),
//				ProjectId:                          pulumi.Int(0),
//				VpcId:                              vpc.ID(),
//				SubnetId:                           subnet.ID(),
//				ForceDelete:                        pulumi.Bool(true),
//				InstanceChargeType:                 pulumi.String("PREPAID"),
//				InstanceChargeTypePrepaidPeriod:    pulumi.Int(1),
//				InstanceChargeTypePrepaidRenewFlag: pulumi.String("NOTIFY_AND_MANUAL_RENEW"),
//				DataDisks: instance.InstanceDataDiskArray{
//					&instance.InstanceDataDiskArgs{
//						DataDiskType: pulumi.String("CLOUD_HSSD"),
//						DataDiskSize: pulumi.Int(50),
//						Encrypt:      pulumi.Bool(false),
//					},
//				},
//				Tags: pulumi.Map{
//					"tagKey": pulumi.Any("tagValue"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			// renew instance
//			_, err = Cvm.NewRenewInstance(ctx, "exampleRenewInstance", &Cvm.RenewInstanceArgs{
//				InstanceId:            exampleInstance.ID(),
//				RenewPortableDataDisk: pulumi.Bool(true),
//				InstanceChargePrepaid: &cvm.RenewInstanceInstanceChargePrepaidArgs{
//					Period:    pulumi.Int(1),
//					RenewFlag: pulumi.String("NOTIFY_AND_MANUAL_RENEW"),
//				},
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
type RenewInstance struct {
	pulumi.CustomResourceState

	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
	InstanceChargePrepaid RenewInstanceInstanceChargePrepaidPtrOutput `pulumi:"instanceChargePrepaid"`
	// Instance ID.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Whether to renew the elastic data disk. Valid values:
	RenewPortableDataDisk pulumi.BoolPtrOutput `pulumi:"renewPortableDataDisk"`
}

// NewRenewInstance registers a new resource with the given unique name, arguments, and options.
func NewRenewInstance(ctx *pulumi.Context,
	name string, args *RenewInstanceArgs, opts ...pulumi.ResourceOption) (*RenewInstance, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RenewInstance
	err := ctx.RegisterResource("tencentcloud:Cvm/renewInstance:RenewInstance", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRenewInstance gets an existing RenewInstance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRenewInstance(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RenewInstanceState, opts ...pulumi.ResourceOption) (*RenewInstance, error) {
	var resource RenewInstance
	err := ctx.ReadResource("tencentcloud:Cvm/renewInstance:RenewInstance", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RenewInstance resources.
type renewInstanceState struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
	InstanceChargePrepaid *RenewInstanceInstanceChargePrepaid `pulumi:"instanceChargePrepaid"`
	// Instance ID.
	InstanceId *string `pulumi:"instanceId"`
	// Whether to renew the elastic data disk. Valid values:
	RenewPortableDataDisk *bool `pulumi:"renewPortableDataDisk"`
}

type RenewInstanceState struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
	InstanceChargePrepaid RenewInstanceInstanceChargePrepaidPtrInput
	// Instance ID.
	InstanceId pulumi.StringPtrInput
	// Whether to renew the elastic data disk. Valid values:
	RenewPortableDataDisk pulumi.BoolPtrInput
}

func (RenewInstanceState) ElementType() reflect.Type {
	return reflect.TypeOf((*renewInstanceState)(nil)).Elem()
}

type renewInstanceArgs struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
	InstanceChargePrepaid *RenewInstanceInstanceChargePrepaid `pulumi:"instanceChargePrepaid"`
	// Instance ID.
	InstanceId string `pulumi:"instanceId"`
	// Whether to renew the elastic data disk. Valid values:
	RenewPortableDataDisk *bool `pulumi:"renewPortableDataDisk"`
}

// The set of arguments for constructing a RenewInstance resource.
type RenewInstanceArgs struct {
	// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
	InstanceChargePrepaid RenewInstanceInstanceChargePrepaidPtrInput
	// Instance ID.
	InstanceId pulumi.StringInput
	// Whether to renew the elastic data disk. Valid values:
	RenewPortableDataDisk pulumi.BoolPtrInput
}

func (RenewInstanceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*renewInstanceArgs)(nil)).Elem()
}

type RenewInstanceInput interface {
	pulumi.Input

	ToRenewInstanceOutput() RenewInstanceOutput
	ToRenewInstanceOutputWithContext(ctx context.Context) RenewInstanceOutput
}

func (*RenewInstance) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewInstance)(nil)).Elem()
}

func (i *RenewInstance) ToRenewInstanceOutput() RenewInstanceOutput {
	return i.ToRenewInstanceOutputWithContext(context.Background())
}

func (i *RenewInstance) ToRenewInstanceOutputWithContext(ctx context.Context) RenewInstanceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewInstanceOutput)
}

// RenewInstanceArrayInput is an input type that accepts RenewInstanceArray and RenewInstanceArrayOutput values.
// You can construct a concrete instance of `RenewInstanceArrayInput` via:
//
//	RenewInstanceArray{ RenewInstanceArgs{...} }
type RenewInstanceArrayInput interface {
	pulumi.Input

	ToRenewInstanceArrayOutput() RenewInstanceArrayOutput
	ToRenewInstanceArrayOutputWithContext(context.Context) RenewInstanceArrayOutput
}

type RenewInstanceArray []RenewInstanceInput

func (RenewInstanceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewInstance)(nil)).Elem()
}

func (i RenewInstanceArray) ToRenewInstanceArrayOutput() RenewInstanceArrayOutput {
	return i.ToRenewInstanceArrayOutputWithContext(context.Background())
}

func (i RenewInstanceArray) ToRenewInstanceArrayOutputWithContext(ctx context.Context) RenewInstanceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewInstanceArrayOutput)
}

// RenewInstanceMapInput is an input type that accepts RenewInstanceMap and RenewInstanceMapOutput values.
// You can construct a concrete instance of `RenewInstanceMapInput` via:
//
//	RenewInstanceMap{ "key": RenewInstanceArgs{...} }
type RenewInstanceMapInput interface {
	pulumi.Input

	ToRenewInstanceMapOutput() RenewInstanceMapOutput
	ToRenewInstanceMapOutputWithContext(context.Context) RenewInstanceMapOutput
}

type RenewInstanceMap map[string]RenewInstanceInput

func (RenewInstanceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewInstance)(nil)).Elem()
}

func (i RenewInstanceMap) ToRenewInstanceMapOutput() RenewInstanceMapOutput {
	return i.ToRenewInstanceMapOutputWithContext(context.Background())
}

func (i RenewInstanceMap) ToRenewInstanceMapOutputWithContext(ctx context.Context) RenewInstanceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RenewInstanceMapOutput)
}

type RenewInstanceOutput struct{ *pulumi.OutputState }

func (RenewInstanceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RenewInstance)(nil)).Elem()
}

func (o RenewInstanceOutput) ToRenewInstanceOutput() RenewInstanceOutput {
	return o
}

func (o RenewInstanceOutput) ToRenewInstanceOutputWithContext(ctx context.Context) RenewInstanceOutput {
	return o
}

// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For yearly and monthly subscription instances, this parameter is required.
func (o RenewInstanceOutput) InstanceChargePrepaid() RenewInstanceInstanceChargePrepaidPtrOutput {
	return o.ApplyT(func(v *RenewInstance) RenewInstanceInstanceChargePrepaidPtrOutput { return v.InstanceChargePrepaid }).(RenewInstanceInstanceChargePrepaidPtrOutput)
}

// Instance ID.
func (o RenewInstanceOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *RenewInstance) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Whether to renew the elastic data disk. Valid values:
func (o RenewInstanceOutput) RenewPortableDataDisk() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *RenewInstance) pulumi.BoolPtrOutput { return v.RenewPortableDataDisk }).(pulumi.BoolPtrOutput)
}

type RenewInstanceArrayOutput struct{ *pulumi.OutputState }

func (RenewInstanceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RenewInstance)(nil)).Elem()
}

func (o RenewInstanceArrayOutput) ToRenewInstanceArrayOutput() RenewInstanceArrayOutput {
	return o
}

func (o RenewInstanceArrayOutput) ToRenewInstanceArrayOutputWithContext(ctx context.Context) RenewInstanceArrayOutput {
	return o
}

func (o RenewInstanceArrayOutput) Index(i pulumi.IntInput) RenewInstanceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RenewInstance {
		return vs[0].([]*RenewInstance)[vs[1].(int)]
	}).(RenewInstanceOutput)
}

type RenewInstanceMapOutput struct{ *pulumi.OutputState }

func (RenewInstanceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RenewInstance)(nil)).Elem()
}

func (o RenewInstanceMapOutput) ToRenewInstanceMapOutput() RenewInstanceMapOutput {
	return o
}

func (o RenewInstanceMapOutput) ToRenewInstanceMapOutputWithContext(ctx context.Context) RenewInstanceMapOutput {
	return o
}

func (o RenewInstanceMapOutput) MapIndex(k pulumi.StringInput) RenewInstanceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RenewInstance {
		return vs[0].(map[string]*RenewInstance)[vs[1].(string)]
	}).(RenewInstanceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RenewInstanceInput)(nil)).Elem(), &RenewInstance{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewInstanceArrayInput)(nil)).Elem(), RenewInstanceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RenewInstanceMapInput)(nil)).Elem(), RenewInstanceMap{})
	pulumi.RegisterOutputType(RenewInstanceOutput{})
	pulumi.RegisterOutputType(RenewInstanceArrayOutput{})
	pulumi.RegisterOutputType(RenewInstanceMapOutput{})
}
