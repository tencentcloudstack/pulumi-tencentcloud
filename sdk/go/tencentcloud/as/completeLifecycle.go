// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package as

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a as completeLifecycle
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/As"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Availability"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Images"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Instance"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
// func main() {
// pulumi.Run(func(ctx *pulumi.Context) error {
// zones, err := Availability.GetZonesByProduct(ctx, &availability.GetZonesByProductArgs{
// Product: "as",
// }, nil);
// if err != nil {
// return err
// }
// image, err := Images.GetInstance(ctx, &images.GetInstanceArgs{
// ImageTypes: []string{
// "PUBLIC_IMAGE",
// },
// OsName: pulumi.StringRef("TencentOS Server 3.2 (Final)"),
// }, nil);
// if err != nil {
// return err
// }
// instanceTypes, err := Instance.GetTypes(ctx, &instance.GetTypesArgs{
// Filters: []instance.GetTypesFilter{
// {
// Name: "zone",
// Values: interface{}{
// zones.Zones[0].Name,
// },
// },
// {
// Name: "instance-family",
// Values: []string{
// "S5",
// },
// },
// },
// CpuCoreCount: pulumi.IntRef(2),
// ExcludeSoldOut: pulumi.BoolRef(true),
// }, nil);
// if err != nil {
// return err
// }
// vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
// CidrBlock: pulumi.String("10.0.0.0/16"),
// })
// if err != nil {
// return err
// }
// subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
// VpcId: vpc.ID(),
// CidrBlock: pulumi.String("10.0.0.0/16"),
// AvailabilityZone: pulumi.String(zones.Zones[0].Name),
// })
// if err != nil {
// return err
// }
// exampleScalingConfig, err := As.NewScalingConfig(ctx, "exampleScalingConfig", &As.ScalingConfigArgs{
// ConfigurationName: pulumi.String("tf-example"),
// ImageId: pulumi.String(image.Images[0].ImageId),
// InstanceTypes: pulumi.StringArray{
// pulumi.String("SA1.SMALL1"),
// pulumi.String("SA2.SMALL1"),
// pulumi.String("SA2.SMALL2"),
// pulumi.String("SA2.SMALL4"),
// },
// InstanceNameSettings: &as.ScalingConfigInstanceNameSettingsArgs{
// InstanceName: pulumi.String("test-ins-name"),
// },
// })
// if err != nil {
// return err
// }
// exampleScalingGroup, err := As.NewScalingGroup(ctx, "exampleScalingGroup", &As.ScalingGroupArgs{
// ScalingGroupName: pulumi.String("tf-example"),
// ConfigurationId: exampleScalingConfig.ID(),
// MaxSize: pulumi.Int(1),
// MinSize: pulumi.Int(0),
// VpcId: vpc.ID(),
// SubnetIds: pulumi.StringArray{
// subnet.ID(),
// },
// })
// if err != nil {
// return err
// }
// exampleLifecycleHook, err := As.NewLifecycleHook(ctx, "exampleLifecycleHook", &As.LifecycleHookArgs{
// ScalingGroupId: exampleScalingGroup.ID(),
// LifecycleHookName: pulumi.String("tf-as-lifecycle-hook"),
// LifecycleTransition: pulumi.String("INSTANCE_LAUNCHING"),
// DefaultResult: pulumi.String("CONTINUE"),
// HeartbeatTimeout: pulumi.Int(500),
// NotificationMetadata: pulumi.String("tf test"),
// })
// if err != nil {
// return err
// }
// exampleInstance, err := Instance.NewInstance(ctx, "exampleInstance", &Instance.InstanceArgs{
// InstanceName: pulumi.String("tf_example"),
// AvailabilityZone: pulumi.String(zones.Zones[0].Name),
// ImageId: pulumi.String(image.Images[0].ImageId),
// InstanceType: pulumi.String(instanceTypes.InstanceTypes[0].InstanceType),
// SystemDiskType: pulumi.String("CLOUD_PREMIUM"),
// SystemDiskSize: pulumi.Int(50),
// Hostname: pulumi.String("user"),
// ProjectId: pulumi.Int(0),
// VpcId: vpc.ID(),
// SubnetId: subnet.ID(),
// })
// if err != nil {
// return err
// }
// _, err = As.NewCompleteLifecycle(ctx, "completeLifecycle", &As.CompleteLifecycleArgs{
// LifecycleHookId: exampleLifecycleHook.ID(),
// InstanceId: exampleInstance.ID(),
// LifecycleActionResult: pulumi.String("CONTINUE"),
// })
// if err != nil {
// return err
// }
// return nil
// })
// }
// ```
// <!--End PulumiCodeChooser -->
type CompleteLifecycle struct {
	pulumi.CustomResourceState

	// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
	InstanceId pulumi.StringPtrOutput `pulumi:"instanceId"`
	// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
	LifecycleActionResult pulumi.StringOutput `pulumi:"lifecycleActionResult"`
	// Either InstanceId or LifecycleActionToken must be specified.
	LifecycleActionToken pulumi.StringPtrOutput `pulumi:"lifecycleActionToken"`
	// Lifecycle hook ID.
	LifecycleHookId pulumi.StringOutput `pulumi:"lifecycleHookId"`
}

// NewCompleteLifecycle registers a new resource with the given unique name, arguments, and options.
func NewCompleteLifecycle(ctx *pulumi.Context,
	name string, args *CompleteLifecycleArgs, opts ...pulumi.ResourceOption) (*CompleteLifecycle, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LifecycleActionResult == nil {
		return nil, errors.New("invalid value for required argument 'LifecycleActionResult'")
	}
	if args.LifecycleHookId == nil {
		return nil, errors.New("invalid value for required argument 'LifecycleHookId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CompleteLifecycle
	err := ctx.RegisterResource("tencentcloud:As/completeLifecycle:CompleteLifecycle", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCompleteLifecycle gets an existing CompleteLifecycle resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCompleteLifecycle(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CompleteLifecycleState, opts ...pulumi.ResourceOption) (*CompleteLifecycle, error) {
	var resource CompleteLifecycle
	err := ctx.ReadResource("tencentcloud:As/completeLifecycle:CompleteLifecycle", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CompleteLifecycle resources.
type completeLifecycleState struct {
	// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
	InstanceId *string `pulumi:"instanceId"`
	// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
	LifecycleActionResult *string `pulumi:"lifecycleActionResult"`
	// Either InstanceId or LifecycleActionToken must be specified.
	LifecycleActionToken *string `pulumi:"lifecycleActionToken"`
	// Lifecycle hook ID.
	LifecycleHookId *string `pulumi:"lifecycleHookId"`
}

type CompleteLifecycleState struct {
	// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
	InstanceId pulumi.StringPtrInput
	// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
	LifecycleActionResult pulumi.StringPtrInput
	// Either InstanceId or LifecycleActionToken must be specified.
	LifecycleActionToken pulumi.StringPtrInput
	// Lifecycle hook ID.
	LifecycleHookId pulumi.StringPtrInput
}

func (CompleteLifecycleState) ElementType() reflect.Type {
	return reflect.TypeOf((*completeLifecycleState)(nil)).Elem()
}

type completeLifecycleArgs struct {
	// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
	InstanceId *string `pulumi:"instanceId"`
	// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
	LifecycleActionResult string `pulumi:"lifecycleActionResult"`
	// Either InstanceId or LifecycleActionToken must be specified.
	LifecycleActionToken *string `pulumi:"lifecycleActionToken"`
	// Lifecycle hook ID.
	LifecycleHookId string `pulumi:"lifecycleHookId"`
}

// The set of arguments for constructing a CompleteLifecycle resource.
type CompleteLifecycleArgs struct {
	// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
	InstanceId pulumi.StringPtrInput
	// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
	LifecycleActionResult pulumi.StringInput
	// Either InstanceId or LifecycleActionToken must be specified.
	LifecycleActionToken pulumi.StringPtrInput
	// Lifecycle hook ID.
	LifecycleHookId pulumi.StringInput
}

func (CompleteLifecycleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*completeLifecycleArgs)(nil)).Elem()
}

type CompleteLifecycleInput interface {
	pulumi.Input

	ToCompleteLifecycleOutput() CompleteLifecycleOutput
	ToCompleteLifecycleOutputWithContext(ctx context.Context) CompleteLifecycleOutput
}

func (*CompleteLifecycle) ElementType() reflect.Type {
	return reflect.TypeOf((**CompleteLifecycle)(nil)).Elem()
}

func (i *CompleteLifecycle) ToCompleteLifecycleOutput() CompleteLifecycleOutput {
	return i.ToCompleteLifecycleOutputWithContext(context.Background())
}

func (i *CompleteLifecycle) ToCompleteLifecycleOutputWithContext(ctx context.Context) CompleteLifecycleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteLifecycleOutput)
}

// CompleteLifecycleArrayInput is an input type that accepts CompleteLifecycleArray and CompleteLifecycleArrayOutput values.
// You can construct a concrete instance of `CompleteLifecycleArrayInput` via:
//
//	CompleteLifecycleArray{ CompleteLifecycleArgs{...} }
type CompleteLifecycleArrayInput interface {
	pulumi.Input

	ToCompleteLifecycleArrayOutput() CompleteLifecycleArrayOutput
	ToCompleteLifecycleArrayOutputWithContext(context.Context) CompleteLifecycleArrayOutput
}

type CompleteLifecycleArray []CompleteLifecycleInput

func (CompleteLifecycleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CompleteLifecycle)(nil)).Elem()
}

func (i CompleteLifecycleArray) ToCompleteLifecycleArrayOutput() CompleteLifecycleArrayOutput {
	return i.ToCompleteLifecycleArrayOutputWithContext(context.Background())
}

func (i CompleteLifecycleArray) ToCompleteLifecycleArrayOutputWithContext(ctx context.Context) CompleteLifecycleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteLifecycleArrayOutput)
}

// CompleteLifecycleMapInput is an input type that accepts CompleteLifecycleMap and CompleteLifecycleMapOutput values.
// You can construct a concrete instance of `CompleteLifecycleMapInput` via:
//
//	CompleteLifecycleMap{ "key": CompleteLifecycleArgs{...} }
type CompleteLifecycleMapInput interface {
	pulumi.Input

	ToCompleteLifecycleMapOutput() CompleteLifecycleMapOutput
	ToCompleteLifecycleMapOutputWithContext(context.Context) CompleteLifecycleMapOutput
}

type CompleteLifecycleMap map[string]CompleteLifecycleInput

func (CompleteLifecycleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CompleteLifecycle)(nil)).Elem()
}

func (i CompleteLifecycleMap) ToCompleteLifecycleMapOutput() CompleteLifecycleMapOutput {
	return i.ToCompleteLifecycleMapOutputWithContext(context.Background())
}

func (i CompleteLifecycleMap) ToCompleteLifecycleMapOutputWithContext(ctx context.Context) CompleteLifecycleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CompleteLifecycleMapOutput)
}

type CompleteLifecycleOutput struct{ *pulumi.OutputState }

func (CompleteLifecycleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CompleteLifecycle)(nil)).Elem()
}

func (o CompleteLifecycleOutput) ToCompleteLifecycleOutput() CompleteLifecycleOutput {
	return o
}

func (o CompleteLifecycleOutput) ToCompleteLifecycleOutputWithContext(ctx context.Context) CompleteLifecycleOutput {
	return o
}

// Instance ID. Either InstanceId or LifecycleActionToken must be specified.
func (o CompleteLifecycleOutput) InstanceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CompleteLifecycle) pulumi.StringPtrOutput { return v.InstanceId }).(pulumi.StringPtrOutput)
}

// Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
func (o CompleteLifecycleOutput) LifecycleActionResult() pulumi.StringOutput {
	return o.ApplyT(func(v *CompleteLifecycle) pulumi.StringOutput { return v.LifecycleActionResult }).(pulumi.StringOutput)
}

// Either InstanceId or LifecycleActionToken must be specified.
func (o CompleteLifecycleOutput) LifecycleActionToken() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CompleteLifecycle) pulumi.StringPtrOutput { return v.LifecycleActionToken }).(pulumi.StringPtrOutput)
}

// Lifecycle hook ID.
func (o CompleteLifecycleOutput) LifecycleHookId() pulumi.StringOutput {
	return o.ApplyT(func(v *CompleteLifecycle) pulumi.StringOutput { return v.LifecycleHookId }).(pulumi.StringOutput)
}

type CompleteLifecycleArrayOutput struct{ *pulumi.OutputState }

func (CompleteLifecycleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CompleteLifecycle)(nil)).Elem()
}

func (o CompleteLifecycleArrayOutput) ToCompleteLifecycleArrayOutput() CompleteLifecycleArrayOutput {
	return o
}

func (o CompleteLifecycleArrayOutput) ToCompleteLifecycleArrayOutputWithContext(ctx context.Context) CompleteLifecycleArrayOutput {
	return o
}

func (o CompleteLifecycleArrayOutput) Index(i pulumi.IntInput) CompleteLifecycleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CompleteLifecycle {
		return vs[0].([]*CompleteLifecycle)[vs[1].(int)]
	}).(CompleteLifecycleOutput)
}

type CompleteLifecycleMapOutput struct{ *pulumi.OutputState }

func (CompleteLifecycleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CompleteLifecycle)(nil)).Elem()
}

func (o CompleteLifecycleMapOutput) ToCompleteLifecycleMapOutput() CompleteLifecycleMapOutput {
	return o
}

func (o CompleteLifecycleMapOutput) ToCompleteLifecycleMapOutputWithContext(ctx context.Context) CompleteLifecycleMapOutput {
	return o
}

func (o CompleteLifecycleMapOutput) MapIndex(k pulumi.StringInput) CompleteLifecycleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CompleteLifecycle {
		return vs[0].(map[string]*CompleteLifecycle)[vs[1].(string)]
	}).(CompleteLifecycleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteLifecycleInput)(nil)).Elem(), &CompleteLifecycle{})
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteLifecycleArrayInput)(nil)).Elem(), CompleteLifecycleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CompleteLifecycleMapInput)(nil)).Elem(), CompleteLifecycleMap{})
	pulumi.RegisterOutputType(CompleteLifecycleOutput{})
	pulumi.RegisterOutputType(CompleteLifecycleArrayOutput{})
	pulumi.RegisterOutputType(CompleteLifecycleMapOutput{})
}
