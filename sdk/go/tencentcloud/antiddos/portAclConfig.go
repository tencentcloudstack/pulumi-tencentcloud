// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package antiddos

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a antiddos port acl config
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Antiddos"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Antiddos.NewPortAclConfig(ctx, "portAclConfig", &Antiddos.PortAclConfigArgs{
//				AclConfig: &antiddos.PortAclConfigAclConfigArgs{
//					Action:          pulumi.String("drop"),
//					DPortEnd:        pulumi.Int(23),
//					DPortStart:      pulumi.Int(22),
//					ForwardProtocol: pulumi.String("all"),
//					Priority:        pulumi.Int(2),
//					SPortEnd:        pulumi.Int(23),
//					SPortStart:      pulumi.Int(22),
//				},
//				InstanceId: pulumi.String("bgp-xxxxxx"),
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
//
// ## Import
//
// antiddos port_acl_config can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Antiddos/portAclConfig:PortAclConfig port_acl_config ${instanceId}#${configJson}
// ```
type PortAclConfig struct {
	pulumi.CustomResourceState

	// Port ACL Policy.
	AclConfig PortAclConfigAclConfigOutput `pulumi:"aclConfig"`
	// InstanceIdList.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
}

// NewPortAclConfig registers a new resource with the given unique name, arguments, and options.
func NewPortAclConfig(ctx *pulumi.Context,
	name string, args *PortAclConfigArgs, opts ...pulumi.ResourceOption) (*PortAclConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AclConfig == nil {
		return nil, errors.New("invalid value for required argument 'AclConfig'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource PortAclConfig
	err := ctx.RegisterResource("tencentcloud:Antiddos/portAclConfig:PortAclConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPortAclConfig gets an existing PortAclConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPortAclConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PortAclConfigState, opts ...pulumi.ResourceOption) (*PortAclConfig, error) {
	var resource PortAclConfig
	err := ctx.ReadResource("tencentcloud:Antiddos/portAclConfig:PortAclConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PortAclConfig resources.
type portAclConfigState struct {
	// Port ACL Policy.
	AclConfig *PortAclConfigAclConfig `pulumi:"aclConfig"`
	// InstanceIdList.
	InstanceId *string `pulumi:"instanceId"`
}

type PortAclConfigState struct {
	// Port ACL Policy.
	AclConfig PortAclConfigAclConfigPtrInput
	// InstanceIdList.
	InstanceId pulumi.StringPtrInput
}

func (PortAclConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*portAclConfigState)(nil)).Elem()
}

type portAclConfigArgs struct {
	// Port ACL Policy.
	AclConfig PortAclConfigAclConfig `pulumi:"aclConfig"`
	// InstanceIdList.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a PortAclConfig resource.
type PortAclConfigArgs struct {
	// Port ACL Policy.
	AclConfig PortAclConfigAclConfigInput
	// InstanceIdList.
	InstanceId pulumi.StringInput
}

func (PortAclConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*portAclConfigArgs)(nil)).Elem()
}

type PortAclConfigInput interface {
	pulumi.Input

	ToPortAclConfigOutput() PortAclConfigOutput
	ToPortAclConfigOutputWithContext(ctx context.Context) PortAclConfigOutput
}

func (*PortAclConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**PortAclConfig)(nil)).Elem()
}

func (i *PortAclConfig) ToPortAclConfigOutput() PortAclConfigOutput {
	return i.ToPortAclConfigOutputWithContext(context.Background())
}

func (i *PortAclConfig) ToPortAclConfigOutputWithContext(ctx context.Context) PortAclConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PortAclConfigOutput)
}

// PortAclConfigArrayInput is an input type that accepts PortAclConfigArray and PortAclConfigArrayOutput values.
// You can construct a concrete instance of `PortAclConfigArrayInput` via:
//
//	PortAclConfigArray{ PortAclConfigArgs{...} }
type PortAclConfigArrayInput interface {
	pulumi.Input

	ToPortAclConfigArrayOutput() PortAclConfigArrayOutput
	ToPortAclConfigArrayOutputWithContext(context.Context) PortAclConfigArrayOutput
}

type PortAclConfigArray []PortAclConfigInput

func (PortAclConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PortAclConfig)(nil)).Elem()
}

func (i PortAclConfigArray) ToPortAclConfigArrayOutput() PortAclConfigArrayOutput {
	return i.ToPortAclConfigArrayOutputWithContext(context.Background())
}

func (i PortAclConfigArray) ToPortAclConfigArrayOutputWithContext(ctx context.Context) PortAclConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PortAclConfigArrayOutput)
}

// PortAclConfigMapInput is an input type that accepts PortAclConfigMap and PortAclConfigMapOutput values.
// You can construct a concrete instance of `PortAclConfigMapInput` via:
//
//	PortAclConfigMap{ "key": PortAclConfigArgs{...} }
type PortAclConfigMapInput interface {
	pulumi.Input

	ToPortAclConfigMapOutput() PortAclConfigMapOutput
	ToPortAclConfigMapOutputWithContext(context.Context) PortAclConfigMapOutput
}

type PortAclConfigMap map[string]PortAclConfigInput

func (PortAclConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PortAclConfig)(nil)).Elem()
}

func (i PortAclConfigMap) ToPortAclConfigMapOutput() PortAclConfigMapOutput {
	return i.ToPortAclConfigMapOutputWithContext(context.Background())
}

func (i PortAclConfigMap) ToPortAclConfigMapOutputWithContext(ctx context.Context) PortAclConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PortAclConfigMapOutput)
}

type PortAclConfigOutput struct{ *pulumi.OutputState }

func (PortAclConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**PortAclConfig)(nil)).Elem()
}

func (o PortAclConfigOutput) ToPortAclConfigOutput() PortAclConfigOutput {
	return o
}

func (o PortAclConfigOutput) ToPortAclConfigOutputWithContext(ctx context.Context) PortAclConfigOutput {
	return o
}

// Port ACL Policy.
func (o PortAclConfigOutput) AclConfig() PortAclConfigAclConfigOutput {
	return o.ApplyT(func(v *PortAclConfig) PortAclConfigAclConfigOutput { return v.AclConfig }).(PortAclConfigAclConfigOutput)
}

// InstanceIdList.
func (o PortAclConfigOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *PortAclConfig) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

type PortAclConfigArrayOutput struct{ *pulumi.OutputState }

func (PortAclConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*PortAclConfig)(nil)).Elem()
}

func (o PortAclConfigArrayOutput) ToPortAclConfigArrayOutput() PortAclConfigArrayOutput {
	return o
}

func (o PortAclConfigArrayOutput) ToPortAclConfigArrayOutputWithContext(ctx context.Context) PortAclConfigArrayOutput {
	return o
}

func (o PortAclConfigArrayOutput) Index(i pulumi.IntInput) PortAclConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *PortAclConfig {
		return vs[0].([]*PortAclConfig)[vs[1].(int)]
	}).(PortAclConfigOutput)
}

type PortAclConfigMapOutput struct{ *pulumi.OutputState }

func (PortAclConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*PortAclConfig)(nil)).Elem()
}

func (o PortAclConfigMapOutput) ToPortAclConfigMapOutput() PortAclConfigMapOutput {
	return o
}

func (o PortAclConfigMapOutput) ToPortAclConfigMapOutputWithContext(ctx context.Context) PortAclConfigMapOutput {
	return o
}

func (o PortAclConfigMapOutput) MapIndex(k pulumi.StringInput) PortAclConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *PortAclConfig {
		return vs[0].(map[string]*PortAclConfig)[vs[1].(string)]
	}).(PortAclConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PortAclConfigInput)(nil)).Elem(), &PortAclConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*PortAclConfigArrayInput)(nil)).Elem(), PortAclConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*PortAclConfigMapInput)(nil)).Elem(), PortAclConfigMap{})
	pulumi.RegisterOutputType(PortAclConfigOutput{})
	pulumi.RegisterOutputType(PortAclConfigArrayOutput{})
	pulumi.RegisterOutputType(PortAclConfigMapOutput{})
}
