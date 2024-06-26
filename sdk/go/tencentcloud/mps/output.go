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

// Provides a resource to create a mps output
//
// ## Example Usage
//
// ### Create a output group with RTP
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
//			_, err := Mps.NewOutput(ctx, "output", &Mps.OutputArgs{
//				FlowId: pulumi.String("your_flow_id"),
//				Output: &mps.OutputOutputTypeArgs{
//					Description:  pulumi.String("tf mps output group"),
//					OutputName:   pulumi.String("your_output_name"),
//					OutputRegion: pulumi.String("ap-guangzhou"),
//					Protocol:     pulumi.String("RTP"),
//					RtpSettings: &mps.OutputOutputRtpSettingsArgs{
//						Destinations: mps.OutputOutputRtpSettingsDestinationArray{
//							&mps.OutputOutputRtpSettingsDestinationArgs{
//								Ip:   pulumi.String("203.205.141.84"),
//								Port: pulumi.Int(65535),
//							},
//						},
//						Fec:         pulumi.String("none"),
//						IdleTimeout: pulumi.Int(1000),
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
// mps output can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Mps/output:Output output flow_id#output_id
// ```
type Output struct {
	pulumi.CustomResourceState

	// Flow ID.
	FlowId pulumi.StringOutput `pulumi:"flowId"`
	// Output configuration of the transport stream.
	Output OutputOutputTypeOutput `pulumi:"output"`
}

// NewOutput registers a new resource with the given unique name, arguments, and options.
func NewOutput(ctx *pulumi.Context,
	name string, args *OutputArgs, opts ...pulumi.ResourceOption) (*Output, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FlowId == nil {
		return nil, errors.New("invalid value for required argument 'FlowId'")
	}
	if args.Output == nil {
		return nil, errors.New("invalid value for required argument 'Output'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Output
	err := ctx.RegisterResource("tencentcloud:Mps/output:Output", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOutput gets an existing Output resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOutput(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OutputState, opts ...pulumi.ResourceOption) (*Output, error) {
	var resource Output
	err := ctx.ReadResource("tencentcloud:Mps/output:Output", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Output resources.
type outputState struct {
	// Flow ID.
	FlowId *string `pulumi:"flowId"`
	// Output configuration of the transport stream.
	Output *OutputOutputType `pulumi:"output"`
}

type OutputState struct {
	// Flow ID.
	FlowId pulumi.StringPtrInput
	// Output configuration of the transport stream.
	Output OutputOutputTypePtrInput
}

func (OutputState) ElementType() reflect.Type {
	return reflect.TypeOf((*outputState)(nil)).Elem()
}

type outputArgs struct {
	// Flow ID.
	FlowId string `pulumi:"flowId"`
	// Output configuration of the transport stream.
	Output OutputOutputType `pulumi:"output"`
}

// The set of arguments for constructing a Output resource.
type OutputArgs struct {
	// Flow ID.
	FlowId pulumi.StringInput
	// Output configuration of the transport stream.
	Output OutputOutputTypeInput
}

func (OutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*outputArgs)(nil)).Elem()
}

type OutputInput interface {
	pulumi.Input

	ToOutputOutput() OutputOutput
	ToOutputOutputWithContext(ctx context.Context) OutputOutput
}

func (*Output) ElementType() reflect.Type {
	return reflect.TypeOf((**Output)(nil)).Elem()
}

func (i *Output) ToOutputOutput() OutputOutput {
	return i.ToOutputOutputWithContext(context.Background())
}

func (i *Output) ToOutputOutputWithContext(ctx context.Context) OutputOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OutputOutput)
}

// OutputArrayInput is an input type that accepts OutputArray and OutputArrayOutput values.
// You can construct a concrete instance of `OutputArrayInput` via:
//
//	OutputArray{ OutputArgs{...} }
type OutputArrayInput interface {
	pulumi.Input

	ToOutputArrayOutput() OutputArrayOutput
	ToOutputArrayOutputWithContext(context.Context) OutputArrayOutput
}

type OutputArray []OutputInput

func (OutputArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Output)(nil)).Elem()
}

func (i OutputArray) ToOutputArrayOutput() OutputArrayOutput {
	return i.ToOutputArrayOutputWithContext(context.Background())
}

func (i OutputArray) ToOutputArrayOutputWithContext(ctx context.Context) OutputArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OutputArrayOutput)
}

// OutputMapInput is an input type that accepts OutputMap and OutputMapOutput values.
// You can construct a concrete instance of `OutputMapInput` via:
//
//	OutputMap{ "key": OutputArgs{...} }
type OutputMapInput interface {
	pulumi.Input

	ToOutputMapOutput() OutputMapOutput
	ToOutputMapOutputWithContext(context.Context) OutputMapOutput
}

type OutputMap map[string]OutputInput

func (OutputMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Output)(nil)).Elem()
}

func (i OutputMap) ToOutputMapOutput() OutputMapOutput {
	return i.ToOutputMapOutputWithContext(context.Background())
}

func (i OutputMap) ToOutputMapOutputWithContext(ctx context.Context) OutputMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OutputMapOutput)
}

type OutputOutput struct{ *pulumi.OutputState }

func (OutputOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Output)(nil)).Elem()
}

func (o OutputOutput) ToOutputOutput() OutputOutput {
	return o
}

func (o OutputOutput) ToOutputOutputWithContext(ctx context.Context) OutputOutput {
	return o
}

// Flow ID.
func (o OutputOutput) FlowId() pulumi.StringOutput {
	return o.ApplyT(func(v *Output) pulumi.StringOutput { return v.FlowId }).(pulumi.StringOutput)
}

// Output configuration of the transport stream.
func (o OutputOutput) Output() OutputOutputTypeOutput {
	return o.ApplyT(func(v *Output) OutputOutputTypeOutput { return v.Output }).(OutputOutputTypeOutput)
}

type OutputArrayOutput struct{ *pulumi.OutputState }

func (OutputArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Output)(nil)).Elem()
}

func (o OutputArrayOutput) ToOutputArrayOutput() OutputArrayOutput {
	return o
}

func (o OutputArrayOutput) ToOutputArrayOutputWithContext(ctx context.Context) OutputArrayOutput {
	return o
}

func (o OutputArrayOutput) Index(i pulumi.IntInput) OutputOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Output {
		return vs[0].([]*Output)[vs[1].(int)]
	}).(OutputOutput)
}

type OutputMapOutput struct{ *pulumi.OutputState }

func (OutputMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Output)(nil)).Elem()
}

func (o OutputMapOutput) ToOutputMapOutput() OutputMapOutput {
	return o
}

func (o OutputMapOutput) ToOutputMapOutputWithContext(ctx context.Context) OutputMapOutput {
	return o
}

func (o OutputMapOutput) MapIndex(k pulumi.StringInput) OutputOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Output {
		return vs[0].(map[string]*Output)[vs[1].(string)]
	}).(OutputOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OutputInput)(nil)).Elem(), &Output{})
	pulumi.RegisterInputType(reflect.TypeOf((*OutputArrayInput)(nil)).Elem(), OutputArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OutputMapInput)(nil)).Elem(), OutputMap{})
	pulumi.RegisterOutputType(OutputOutput{})
	pulumi.RegisterOutputType(OutputArrayOutput{})
	pulumi.RegisterOutputType(OutputMapOutput{})
}
