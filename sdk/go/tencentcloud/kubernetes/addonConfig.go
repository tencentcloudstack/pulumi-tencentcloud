// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kubernetes

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provide a resource to configure addon that kubernetes comes with.
//
// ## Example Usage
type AddonConfig struct {
	pulumi.CustomResourceState

	// Name of addon.
	AddonName pulumi.StringOutput `pulumi:"addonName"`
	// Version of addon.
	AddonVersion pulumi.StringOutput `pulumi:"addonVersion"`
	// ID of cluster.
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// Status of addon.
	Phase pulumi.StringOutput `pulumi:"phase"`
	// Params of addon, base64 encoded json format.
	RawValues pulumi.StringOutput `pulumi:"rawValues"`
	// Reason of addon failed.
	Reason pulumi.StringOutput `pulumi:"reason"`
}

// NewAddonConfig registers a new resource with the given unique name, arguments, and options.
func NewAddonConfig(ctx *pulumi.Context,
	name string, args *AddonConfigArgs, opts ...pulumi.ResourceOption) (*AddonConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AddonName == nil {
		return nil, errors.New("invalid value for required argument 'AddonName'")
	}
	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource AddonConfig
	err := ctx.RegisterResource("tencentcloud:Kubernetes/addonConfig:AddonConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAddonConfig gets an existing AddonConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAddonConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AddonConfigState, opts ...pulumi.ResourceOption) (*AddonConfig, error) {
	var resource AddonConfig
	err := ctx.ReadResource("tencentcloud:Kubernetes/addonConfig:AddonConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AddonConfig resources.
type addonConfigState struct {
	// Name of addon.
	AddonName *string `pulumi:"addonName"`
	// Version of addon.
	AddonVersion *string `pulumi:"addonVersion"`
	// ID of cluster.
	ClusterId *string `pulumi:"clusterId"`
	// Status of addon.
	Phase *string `pulumi:"phase"`
	// Params of addon, base64 encoded json format.
	RawValues *string `pulumi:"rawValues"`
	// Reason of addon failed.
	Reason *string `pulumi:"reason"`
}

type AddonConfigState struct {
	// Name of addon.
	AddonName pulumi.StringPtrInput
	// Version of addon.
	AddonVersion pulumi.StringPtrInput
	// ID of cluster.
	ClusterId pulumi.StringPtrInput
	// Status of addon.
	Phase pulumi.StringPtrInput
	// Params of addon, base64 encoded json format.
	RawValues pulumi.StringPtrInput
	// Reason of addon failed.
	Reason pulumi.StringPtrInput
}

func (AddonConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*addonConfigState)(nil)).Elem()
}

type addonConfigArgs struct {
	// Name of addon.
	AddonName string `pulumi:"addonName"`
	// Version of addon.
	AddonVersion *string `pulumi:"addonVersion"`
	// ID of cluster.
	ClusterId string `pulumi:"clusterId"`
	// Params of addon, base64 encoded json format.
	RawValues *string `pulumi:"rawValues"`
}

// The set of arguments for constructing a AddonConfig resource.
type AddonConfigArgs struct {
	// Name of addon.
	AddonName pulumi.StringInput
	// Version of addon.
	AddonVersion pulumi.StringPtrInput
	// ID of cluster.
	ClusterId pulumi.StringInput
	// Params of addon, base64 encoded json format.
	RawValues pulumi.StringPtrInput
}

func (AddonConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*addonConfigArgs)(nil)).Elem()
}

type AddonConfigInput interface {
	pulumi.Input

	ToAddonConfigOutput() AddonConfigOutput
	ToAddonConfigOutputWithContext(ctx context.Context) AddonConfigOutput
}

func (*AddonConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**AddonConfig)(nil)).Elem()
}

func (i *AddonConfig) ToAddonConfigOutput() AddonConfigOutput {
	return i.ToAddonConfigOutputWithContext(context.Background())
}

func (i *AddonConfig) ToAddonConfigOutputWithContext(ctx context.Context) AddonConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddonConfigOutput)
}

// AddonConfigArrayInput is an input type that accepts AddonConfigArray and AddonConfigArrayOutput values.
// You can construct a concrete instance of `AddonConfigArrayInput` via:
//
//	AddonConfigArray{ AddonConfigArgs{...} }
type AddonConfigArrayInput interface {
	pulumi.Input

	ToAddonConfigArrayOutput() AddonConfigArrayOutput
	ToAddonConfigArrayOutputWithContext(context.Context) AddonConfigArrayOutput
}

type AddonConfigArray []AddonConfigInput

func (AddonConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddonConfig)(nil)).Elem()
}

func (i AddonConfigArray) ToAddonConfigArrayOutput() AddonConfigArrayOutput {
	return i.ToAddonConfigArrayOutputWithContext(context.Background())
}

func (i AddonConfigArray) ToAddonConfigArrayOutputWithContext(ctx context.Context) AddonConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddonConfigArrayOutput)
}

// AddonConfigMapInput is an input type that accepts AddonConfigMap and AddonConfigMapOutput values.
// You can construct a concrete instance of `AddonConfigMapInput` via:
//
//	AddonConfigMap{ "key": AddonConfigArgs{...} }
type AddonConfigMapInput interface {
	pulumi.Input

	ToAddonConfigMapOutput() AddonConfigMapOutput
	ToAddonConfigMapOutputWithContext(context.Context) AddonConfigMapOutput
}

type AddonConfigMap map[string]AddonConfigInput

func (AddonConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddonConfig)(nil)).Elem()
}

func (i AddonConfigMap) ToAddonConfigMapOutput() AddonConfigMapOutput {
	return i.ToAddonConfigMapOutputWithContext(context.Background())
}

func (i AddonConfigMap) ToAddonConfigMapOutputWithContext(ctx context.Context) AddonConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AddonConfigMapOutput)
}

type AddonConfigOutput struct{ *pulumi.OutputState }

func (AddonConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AddonConfig)(nil)).Elem()
}

func (o AddonConfigOutput) ToAddonConfigOutput() AddonConfigOutput {
	return o
}

func (o AddonConfigOutput) ToAddonConfigOutputWithContext(ctx context.Context) AddonConfigOutput {
	return o
}

// Name of addon.
func (o AddonConfigOutput) AddonName() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.AddonName }).(pulumi.StringOutput)
}

// Version of addon.
func (o AddonConfigOutput) AddonVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.AddonVersion }).(pulumi.StringOutput)
}

// ID of cluster.
func (o AddonConfigOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// Status of addon.
func (o AddonConfigOutput) Phase() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.Phase }).(pulumi.StringOutput)
}

// Params of addon, base64 encoded json format.
func (o AddonConfigOutput) RawValues() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.RawValues }).(pulumi.StringOutput)
}

// Reason of addon failed.
func (o AddonConfigOutput) Reason() pulumi.StringOutput {
	return o.ApplyT(func(v *AddonConfig) pulumi.StringOutput { return v.Reason }).(pulumi.StringOutput)
}

type AddonConfigArrayOutput struct{ *pulumi.OutputState }

func (AddonConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AddonConfig)(nil)).Elem()
}

func (o AddonConfigArrayOutput) ToAddonConfigArrayOutput() AddonConfigArrayOutput {
	return o
}

func (o AddonConfigArrayOutput) ToAddonConfigArrayOutputWithContext(ctx context.Context) AddonConfigArrayOutput {
	return o
}

func (o AddonConfigArrayOutput) Index(i pulumi.IntInput) AddonConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AddonConfig {
		return vs[0].([]*AddonConfig)[vs[1].(int)]
	}).(AddonConfigOutput)
}

type AddonConfigMapOutput struct{ *pulumi.OutputState }

func (AddonConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AddonConfig)(nil)).Elem()
}

func (o AddonConfigMapOutput) ToAddonConfigMapOutput() AddonConfigMapOutput {
	return o
}

func (o AddonConfigMapOutput) ToAddonConfigMapOutputWithContext(ctx context.Context) AddonConfigMapOutput {
	return o
}

func (o AddonConfigMapOutput) MapIndex(k pulumi.StringInput) AddonConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AddonConfig {
		return vs[0].(map[string]*AddonConfig)[vs[1].(string)]
	}).(AddonConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AddonConfigInput)(nil)).Elem(), &AddonConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddonConfigArrayInput)(nil)).Elem(), AddonConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AddonConfigMapInput)(nil)).Elem(), AddonConfigMap{})
	pulumi.RegisterOutputType(AddonConfigOutput{})
	pulumi.RegisterOutputType(AddonConfigArrayOutput{})
	pulumi.RegisterOutputType(AddonConfigMapOutput{})
}