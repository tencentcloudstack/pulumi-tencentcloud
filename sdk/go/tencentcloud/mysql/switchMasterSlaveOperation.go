// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mysql switchMasterSlaveOperation
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Availability"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Security"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			zones, err := Availability.GetZonesByProduct(ctx, &availability.GetZonesByProductArgs{
//				Product: "cdb",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("10.0.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				AvailabilityZone: pulumi.String(zones.Zones[0].Name),
//				VpcId:            vpc.ID(),
//				CidrBlock:        pulumi.String("10.0.0.0/16"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			securityGroup, err := Security.NewGroup(ctx, "securityGroup", &Security.GroupArgs{
//				Description: pulumi.String("mysql test"),
//			})
//			if err != nil {
//				return err
//			}
//			exampleInstance, err := Mysql.NewInstance(ctx, "exampleInstance", &Mysql.InstanceArgs{
//				InternetService:  pulumi.Int(1),
//				EngineVersion:    pulumi.String("5.7"),
//				ChargeType:       pulumi.String("POSTPAID"),
//				RootPassword:     pulumi.String("PassWord123"),
//				SlaveDeployMode:  pulumi.Int(1),
//				AvailabilityZone: pulumi.String(zones.Zones[0].Name),
//				FirstSlaveZone:   pulumi.String(zones.Zones[1].Name),
//				SlaveSyncMode:    pulumi.Int(1),
//				InstanceName:     pulumi.String("tf-example-mysql"),
//				MemSize:          pulumi.Int(4000),
//				VolumeSize:       pulumi.Int(200),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				IntranetPort:     pulumi.Int(3306),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				Tags: pulumi.Map{
//					"name": pulumi.Any("test"),
//				},
//				Parameters: pulumi.Map{
//					"character_set_server": pulumi.Any("utf8"),
//					"max_connections":      pulumi.Any("1000"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mysql.NewSwitchMasterSlaveOperation(ctx, "exampleSwitchMasterSlaveOperation", &Mysql.SwitchMasterSlaveOperationArgs{
//				InstanceId:  exampleInstance.ID(),
//				DstSlave:    pulumi.String("second"),
//				ForceSwitch: pulumi.Bool(true),
//				WaitSwitch:  pulumi.Bool(true),
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
type SwitchMasterSlaveOperation struct {
	pulumi.CustomResourceState

	// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
	DstSlave pulumi.StringPtrOutput `pulumi:"dstSlave"`
	// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
	ForceSwitch pulumi.BoolPtrOutput `pulumi:"forceSwitch"`
	// instance id.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
	WaitSwitch pulumi.BoolPtrOutput `pulumi:"waitSwitch"`
}

// NewSwitchMasterSlaveOperation registers a new resource with the given unique name, arguments, and options.
func NewSwitchMasterSlaveOperation(ctx *pulumi.Context,
	name string, args *SwitchMasterSlaveOperationArgs, opts ...pulumi.ResourceOption) (*SwitchMasterSlaveOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SwitchMasterSlaveOperation
	err := ctx.RegisterResource("tencentcloud:Mysql/switchMasterSlaveOperation:SwitchMasterSlaveOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSwitchMasterSlaveOperation gets an existing SwitchMasterSlaveOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSwitchMasterSlaveOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SwitchMasterSlaveOperationState, opts ...pulumi.ResourceOption) (*SwitchMasterSlaveOperation, error) {
	var resource SwitchMasterSlaveOperation
	err := ctx.ReadResource("tencentcloud:Mysql/switchMasterSlaveOperation:SwitchMasterSlaveOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SwitchMasterSlaveOperation resources.
type switchMasterSlaveOperationState struct {
	// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
	DstSlave *string `pulumi:"dstSlave"`
	// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
	ForceSwitch *bool `pulumi:"forceSwitch"`
	// instance id.
	InstanceId *string `pulumi:"instanceId"`
	// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
	WaitSwitch *bool `pulumi:"waitSwitch"`
}

type SwitchMasterSlaveOperationState struct {
	// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
	DstSlave pulumi.StringPtrInput
	// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
	ForceSwitch pulumi.BoolPtrInput
	// instance id.
	InstanceId pulumi.StringPtrInput
	// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
	WaitSwitch pulumi.BoolPtrInput
}

func (SwitchMasterSlaveOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*switchMasterSlaveOperationState)(nil)).Elem()
}

type switchMasterSlaveOperationArgs struct {
	// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
	DstSlave *string `pulumi:"dstSlave"`
	// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
	ForceSwitch *bool `pulumi:"forceSwitch"`
	// instance id.
	InstanceId string `pulumi:"instanceId"`
	// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
	WaitSwitch *bool `pulumi:"waitSwitch"`
}

// The set of arguments for constructing a SwitchMasterSlaveOperation resource.
type SwitchMasterSlaveOperationArgs struct {
	// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
	DstSlave pulumi.StringPtrInput
	// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
	ForceSwitch pulumi.BoolPtrInput
	// instance id.
	InstanceId pulumi.StringInput
	// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
	WaitSwitch pulumi.BoolPtrInput
}

func (SwitchMasterSlaveOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*switchMasterSlaveOperationArgs)(nil)).Elem()
}

type SwitchMasterSlaveOperationInput interface {
	pulumi.Input

	ToSwitchMasterSlaveOperationOutput() SwitchMasterSlaveOperationOutput
	ToSwitchMasterSlaveOperationOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationOutput
}

func (*SwitchMasterSlaveOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**SwitchMasterSlaveOperation)(nil)).Elem()
}

func (i *SwitchMasterSlaveOperation) ToSwitchMasterSlaveOperationOutput() SwitchMasterSlaveOperationOutput {
	return i.ToSwitchMasterSlaveOperationOutputWithContext(context.Background())
}

func (i *SwitchMasterSlaveOperation) ToSwitchMasterSlaveOperationOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SwitchMasterSlaveOperationOutput)
}

// SwitchMasterSlaveOperationArrayInput is an input type that accepts SwitchMasterSlaveOperationArray and SwitchMasterSlaveOperationArrayOutput values.
// You can construct a concrete instance of `SwitchMasterSlaveOperationArrayInput` via:
//
//	SwitchMasterSlaveOperationArray{ SwitchMasterSlaveOperationArgs{...} }
type SwitchMasterSlaveOperationArrayInput interface {
	pulumi.Input

	ToSwitchMasterSlaveOperationArrayOutput() SwitchMasterSlaveOperationArrayOutput
	ToSwitchMasterSlaveOperationArrayOutputWithContext(context.Context) SwitchMasterSlaveOperationArrayOutput
}

type SwitchMasterSlaveOperationArray []SwitchMasterSlaveOperationInput

func (SwitchMasterSlaveOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SwitchMasterSlaveOperation)(nil)).Elem()
}

func (i SwitchMasterSlaveOperationArray) ToSwitchMasterSlaveOperationArrayOutput() SwitchMasterSlaveOperationArrayOutput {
	return i.ToSwitchMasterSlaveOperationArrayOutputWithContext(context.Background())
}

func (i SwitchMasterSlaveOperationArray) ToSwitchMasterSlaveOperationArrayOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SwitchMasterSlaveOperationArrayOutput)
}

// SwitchMasterSlaveOperationMapInput is an input type that accepts SwitchMasterSlaveOperationMap and SwitchMasterSlaveOperationMapOutput values.
// You can construct a concrete instance of `SwitchMasterSlaveOperationMapInput` via:
//
//	SwitchMasterSlaveOperationMap{ "key": SwitchMasterSlaveOperationArgs{...} }
type SwitchMasterSlaveOperationMapInput interface {
	pulumi.Input

	ToSwitchMasterSlaveOperationMapOutput() SwitchMasterSlaveOperationMapOutput
	ToSwitchMasterSlaveOperationMapOutputWithContext(context.Context) SwitchMasterSlaveOperationMapOutput
}

type SwitchMasterSlaveOperationMap map[string]SwitchMasterSlaveOperationInput

func (SwitchMasterSlaveOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SwitchMasterSlaveOperation)(nil)).Elem()
}

func (i SwitchMasterSlaveOperationMap) ToSwitchMasterSlaveOperationMapOutput() SwitchMasterSlaveOperationMapOutput {
	return i.ToSwitchMasterSlaveOperationMapOutputWithContext(context.Background())
}

func (i SwitchMasterSlaveOperationMap) ToSwitchMasterSlaveOperationMapOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SwitchMasterSlaveOperationMapOutput)
}

type SwitchMasterSlaveOperationOutput struct{ *pulumi.OutputState }

func (SwitchMasterSlaveOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SwitchMasterSlaveOperation)(nil)).Elem()
}

func (o SwitchMasterSlaveOperationOutput) ToSwitchMasterSlaveOperationOutput() SwitchMasterSlaveOperationOutput {
	return o
}

func (o SwitchMasterSlaveOperationOutput) ToSwitchMasterSlaveOperationOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationOutput {
	return o
}

// target instance. Possible values: `first` - first standby; `second` - second standby. The default value is `first`, and only multi-AZ instances support setting it to `second`.
func (o SwitchMasterSlaveOperationOutput) DstSlave() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SwitchMasterSlaveOperation) pulumi.StringPtrOutput { return v.DstSlave }).(pulumi.StringPtrOutput)
}

// Whether to force switch. Default is False. Note that if you set the mandatory switch to True, there is a risk of data loss on the instance, so use it with caution.
func (o SwitchMasterSlaveOperationOutput) ForceSwitch() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SwitchMasterSlaveOperation) pulumi.BoolPtrOutput { return v.ForceSwitch }).(pulumi.BoolPtrOutput)
}

// instance id.
func (o SwitchMasterSlaveOperationOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *SwitchMasterSlaveOperation) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Whether to switch within the time window. The default is False, i.e. do not switch within the time window. Note that if the ForceSwitch parameter is set to True, this parameter will not take effect.
func (o SwitchMasterSlaveOperationOutput) WaitSwitch() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SwitchMasterSlaveOperation) pulumi.BoolPtrOutput { return v.WaitSwitch }).(pulumi.BoolPtrOutput)
}

type SwitchMasterSlaveOperationArrayOutput struct{ *pulumi.OutputState }

func (SwitchMasterSlaveOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SwitchMasterSlaveOperation)(nil)).Elem()
}

func (o SwitchMasterSlaveOperationArrayOutput) ToSwitchMasterSlaveOperationArrayOutput() SwitchMasterSlaveOperationArrayOutput {
	return o
}

func (o SwitchMasterSlaveOperationArrayOutput) ToSwitchMasterSlaveOperationArrayOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationArrayOutput {
	return o
}

func (o SwitchMasterSlaveOperationArrayOutput) Index(i pulumi.IntInput) SwitchMasterSlaveOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SwitchMasterSlaveOperation {
		return vs[0].([]*SwitchMasterSlaveOperation)[vs[1].(int)]
	}).(SwitchMasterSlaveOperationOutput)
}

type SwitchMasterSlaveOperationMapOutput struct{ *pulumi.OutputState }

func (SwitchMasterSlaveOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SwitchMasterSlaveOperation)(nil)).Elem()
}

func (o SwitchMasterSlaveOperationMapOutput) ToSwitchMasterSlaveOperationMapOutput() SwitchMasterSlaveOperationMapOutput {
	return o
}

func (o SwitchMasterSlaveOperationMapOutput) ToSwitchMasterSlaveOperationMapOutputWithContext(ctx context.Context) SwitchMasterSlaveOperationMapOutput {
	return o
}

func (o SwitchMasterSlaveOperationMapOutput) MapIndex(k pulumi.StringInput) SwitchMasterSlaveOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SwitchMasterSlaveOperation {
		return vs[0].(map[string]*SwitchMasterSlaveOperation)[vs[1].(string)]
	}).(SwitchMasterSlaveOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SwitchMasterSlaveOperationInput)(nil)).Elem(), &SwitchMasterSlaveOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*SwitchMasterSlaveOperationArrayInput)(nil)).Elem(), SwitchMasterSlaveOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SwitchMasterSlaveOperationMapInput)(nil)).Elem(), SwitchMasterSlaveOperationMap{})
	pulumi.RegisterOutputType(SwitchMasterSlaveOperationOutput{})
	pulumi.RegisterOutputType(SwitchMasterSlaveOperationArrayOutput{})
	pulumi.RegisterOutputType(SwitchMasterSlaveOperationMapOutput{})
}
