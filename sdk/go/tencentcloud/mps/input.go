// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mps input
//
// ## Example Usage
//
// ### Create mps input group with SRT
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Mps.NewInput(ctx, "input", &Mps.InputArgs{
//				FlowId: pulumi.Any(tencentcloud_mps_flow.Flow.Id),
//				InputGroup: &mps.InputInputGroupArgs{
//					InputName:   pulumi.String("your_input_name"),
//					Protocol:    pulumi.String("SRT"),
//					Description: pulumi.String("input name Description"),
//					AllowIpLists: pulumi.StringArray{
//						pulumi.String("0.0.0.0/0"),
//					},
//					SrtSettings: &mps.InputInputGroupSrtSettingsArgs{
//						Mode:            pulumi.String("LISTENER"),
//						StreamId:        pulumi.String("#!::u=johnny,r=resource,h=xxx.com,t=stream,m=play"),
//						Latency:         pulumi.Int(1000),
//						RecvLatency:     pulumi.Int(1000),
//						PeerLatency:     pulumi.Int(1000),
//						PeerIdleTimeout: pulumi.Int(1000),
//					},
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
//
// ## Import
//
// mps input can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Mps/input:Input input input_id
// ```
type Input struct {
	pulumi.CustomResourceState

	// Flow ID.
	FlowId pulumi.StringOutput `pulumi:"flowId"`
	// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
	InputGroup InputInputGroupPtrOutput `pulumi:"inputGroup"`
}

// NewInput registers a new resource with the given unique name, arguments, and options.
func NewInput(ctx *pulumi.Context,
	name string, args *InputArgs, opts ...pulumi.ResourceOption) (*Input, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FlowId == nil {
		return nil, errors.New("invalid value for required argument 'FlowId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Input
	err := ctx.RegisterResource("tencentcloud:Mps/input:Input", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetInput gets an existing Input resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInput(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *InputState, opts ...pulumi.ResourceOption) (*Input, error) {
	var resource Input
	err := ctx.ReadResource("tencentcloud:Mps/input:Input", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Input resources.
type inputState struct {
	// Flow ID.
	FlowId *string `pulumi:"flowId"`
	// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
	InputGroup *InputInputGroup `pulumi:"inputGroup"`
}

type InputState struct {
	// Flow ID.
	FlowId pulumi.StringPtrInput
	// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
	InputGroup InputInputGroupPtrInput
}

func (InputState) ElementType() reflect.Type {
	return reflect.TypeOf((*inputState)(nil)).Elem()
}

type inputArgs struct {
	// Flow ID.
	FlowId string `pulumi:"flowId"`
	// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
	InputGroup *InputInputGroup `pulumi:"inputGroup"`
}

// The set of arguments for constructing a Input resource.
type InputArgs struct {
	// Flow ID.
	FlowId pulumi.StringInput
	// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
	InputGroup InputInputGroupPtrInput
}

func (InputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*inputArgs)(nil)).Elem()
}

type InputInput interface {
	pulumi.Input

	ToInputOutput() InputOutput
	ToInputOutputWithContext(ctx context.Context) InputOutput
}

func (*Input) ElementType() reflect.Type {
	return reflect.TypeOf((**Input)(nil)).Elem()
}

func (i *Input) ToInputOutput() InputOutput {
	return i.ToInputOutputWithContext(context.Background())
}

func (i *Input) ToInputOutputWithContext(ctx context.Context) InputOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InputOutput)
}

// InputArrayInput is an input type that accepts InputArray and InputArrayOutput values.
// You can construct a concrete instance of `InputArrayInput` via:
//
//	InputArray{ InputArgs{...} }
type InputArrayInput interface {
	pulumi.Input

	ToInputArrayOutput() InputArrayOutput
	ToInputArrayOutputWithContext(context.Context) InputArrayOutput
}

type InputArray []InputInput

func (InputArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Input)(nil)).Elem()
}

func (i InputArray) ToInputArrayOutput() InputArrayOutput {
	return i.ToInputArrayOutputWithContext(context.Background())
}

func (i InputArray) ToInputArrayOutputWithContext(ctx context.Context) InputArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InputArrayOutput)
}

// InputMapInput is an input type that accepts InputMap and InputMapOutput values.
// You can construct a concrete instance of `InputMapInput` via:
//
//	InputMap{ "key": InputArgs{...} }
type InputMapInput interface {
	pulumi.Input

	ToInputMapOutput() InputMapOutput
	ToInputMapOutputWithContext(context.Context) InputMapOutput
}

type InputMap map[string]InputInput

func (InputMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Input)(nil)).Elem()
}

func (i InputMap) ToInputMapOutput() InputMapOutput {
	return i.ToInputMapOutputWithContext(context.Background())
}

func (i InputMap) ToInputMapOutputWithContext(ctx context.Context) InputMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(InputMapOutput)
}

type InputOutput struct{ *pulumi.OutputState }

func (InputOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Input)(nil)).Elem()
}

func (o InputOutput) ToInputOutput() InputOutput {
	return o
}

func (o InputOutput) ToInputOutputWithContext(ctx context.Context) InputOutput {
	return o
}

// Flow ID.
func (o InputOutput) FlowId() pulumi.StringOutput {
	return o.ApplyT(func(v *Input) pulumi.StringOutput { return v.FlowId }).(pulumi.StringOutput)
}

// The input group for the input. Only support one group for one `Mps.Input`. Use `forEach` to create multiple inputs Scenario.
func (o InputOutput) InputGroup() InputInputGroupPtrOutput {
	return o.ApplyT(func(v *Input) InputInputGroupPtrOutput { return v.InputGroup }).(InputInputGroupPtrOutput)
}

type InputArrayOutput struct{ *pulumi.OutputState }

func (InputArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Input)(nil)).Elem()
}

func (o InputArrayOutput) ToInputArrayOutput() InputArrayOutput {
	return o
}

func (o InputArrayOutput) ToInputArrayOutputWithContext(ctx context.Context) InputArrayOutput {
	return o
}

func (o InputArrayOutput) Index(i pulumi.IntInput) InputOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Input {
		return vs[0].([]*Input)[vs[1].(int)]
	}).(InputOutput)
}

type InputMapOutput struct{ *pulumi.OutputState }

func (InputMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Input)(nil)).Elem()
}

func (o InputMapOutput) ToInputMapOutput() InputMapOutput {
	return o
}

func (o InputMapOutput) ToInputMapOutputWithContext(ctx context.Context) InputMapOutput {
	return o
}

func (o InputMapOutput) MapIndex(k pulumi.StringInput) InputOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Input {
		return vs[0].(map[string]*Input)[vs[1].(string)]
	}).(InputOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*InputInput)(nil)).Elem(), &Input{})
	pulumi.RegisterInputType(reflect.TypeOf((*InputArrayInput)(nil)).Elem(), InputArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*InputMapInput)(nil)).Elem(), InputMap{})
	pulumi.RegisterOutputType(InputOutput{})
	pulumi.RegisterOutputType(InputArrayOutput{})
	pulumi.RegisterOutputType(InputMapOutput{})
}
