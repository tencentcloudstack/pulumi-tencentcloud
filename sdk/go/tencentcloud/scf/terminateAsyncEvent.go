// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package scf

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a scf terminateAsyncEvent
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Scf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Scf.NewTerminateAsyncEvent(ctx, "terminateAsyncEvent", &Scf.TerminateAsyncEventArgs{
//				FunctionName:    pulumi.String("keep-1676351130"),
//				GraceShutdown:   pulumi.Bool(true),
//				InvokeRequestId: pulumi.String("9de9405a-e33a-498d-bb59-e80b7bed1191"),
//				Namespace:       pulumi.String("default"),
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
type TerminateAsyncEvent struct {
	pulumi.CustomResourceState

	// Function name.
	FunctionName pulumi.StringOutput `pulumi:"functionName"`
	// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
	GraceShutdown pulumi.BoolPtrOutput `pulumi:"graceShutdown"`
	// Terminated invocation request ID.
	InvokeRequestId pulumi.StringOutput `pulumi:"invokeRequestId"`
	// Namespace.
	Namespace pulumi.StringPtrOutput `pulumi:"namespace"`
}

// NewTerminateAsyncEvent registers a new resource with the given unique name, arguments, and options.
func NewTerminateAsyncEvent(ctx *pulumi.Context,
	name string, args *TerminateAsyncEventArgs, opts ...pulumi.ResourceOption) (*TerminateAsyncEvent, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.FunctionName == nil {
		return nil, errors.New("invalid value for required argument 'FunctionName'")
	}
	if args.InvokeRequestId == nil {
		return nil, errors.New("invalid value for required argument 'InvokeRequestId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource TerminateAsyncEvent
	err := ctx.RegisterResource("tencentcloud:Scf/terminateAsyncEvent:TerminateAsyncEvent", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTerminateAsyncEvent gets an existing TerminateAsyncEvent resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTerminateAsyncEvent(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TerminateAsyncEventState, opts ...pulumi.ResourceOption) (*TerminateAsyncEvent, error) {
	var resource TerminateAsyncEvent
	err := ctx.ReadResource("tencentcloud:Scf/terminateAsyncEvent:TerminateAsyncEvent", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TerminateAsyncEvent resources.
type terminateAsyncEventState struct {
	// Function name.
	FunctionName *string `pulumi:"functionName"`
	// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
	GraceShutdown *bool `pulumi:"graceShutdown"`
	// Terminated invocation request ID.
	InvokeRequestId *string `pulumi:"invokeRequestId"`
	// Namespace.
	Namespace *string `pulumi:"namespace"`
}

type TerminateAsyncEventState struct {
	// Function name.
	FunctionName pulumi.StringPtrInput
	// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
	GraceShutdown pulumi.BoolPtrInput
	// Terminated invocation request ID.
	InvokeRequestId pulumi.StringPtrInput
	// Namespace.
	Namespace pulumi.StringPtrInput
}

func (TerminateAsyncEventState) ElementType() reflect.Type {
	return reflect.TypeOf((*terminateAsyncEventState)(nil)).Elem()
}

type terminateAsyncEventArgs struct {
	// Function name.
	FunctionName string `pulumi:"functionName"`
	// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
	GraceShutdown *bool `pulumi:"graceShutdown"`
	// Terminated invocation request ID.
	InvokeRequestId string `pulumi:"invokeRequestId"`
	// Namespace.
	Namespace *string `pulumi:"namespace"`
}

// The set of arguments for constructing a TerminateAsyncEvent resource.
type TerminateAsyncEventArgs struct {
	// Function name.
	FunctionName pulumi.StringInput
	// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
	GraceShutdown pulumi.BoolPtrInput
	// Terminated invocation request ID.
	InvokeRequestId pulumi.StringInput
	// Namespace.
	Namespace pulumi.StringPtrInput
}

func (TerminateAsyncEventArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*terminateAsyncEventArgs)(nil)).Elem()
}

type TerminateAsyncEventInput interface {
	pulumi.Input

	ToTerminateAsyncEventOutput() TerminateAsyncEventOutput
	ToTerminateAsyncEventOutputWithContext(ctx context.Context) TerminateAsyncEventOutput
}

func (*TerminateAsyncEvent) ElementType() reflect.Type {
	return reflect.TypeOf((**TerminateAsyncEvent)(nil)).Elem()
}

func (i *TerminateAsyncEvent) ToTerminateAsyncEventOutput() TerminateAsyncEventOutput {
	return i.ToTerminateAsyncEventOutputWithContext(context.Background())
}

func (i *TerminateAsyncEvent) ToTerminateAsyncEventOutputWithContext(ctx context.Context) TerminateAsyncEventOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TerminateAsyncEventOutput)
}

// TerminateAsyncEventArrayInput is an input type that accepts TerminateAsyncEventArray and TerminateAsyncEventArrayOutput values.
// You can construct a concrete instance of `TerminateAsyncEventArrayInput` via:
//
//	TerminateAsyncEventArray{ TerminateAsyncEventArgs{...} }
type TerminateAsyncEventArrayInput interface {
	pulumi.Input

	ToTerminateAsyncEventArrayOutput() TerminateAsyncEventArrayOutput
	ToTerminateAsyncEventArrayOutputWithContext(context.Context) TerminateAsyncEventArrayOutput
}

type TerminateAsyncEventArray []TerminateAsyncEventInput

func (TerminateAsyncEventArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TerminateAsyncEvent)(nil)).Elem()
}

func (i TerminateAsyncEventArray) ToTerminateAsyncEventArrayOutput() TerminateAsyncEventArrayOutput {
	return i.ToTerminateAsyncEventArrayOutputWithContext(context.Background())
}

func (i TerminateAsyncEventArray) ToTerminateAsyncEventArrayOutputWithContext(ctx context.Context) TerminateAsyncEventArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TerminateAsyncEventArrayOutput)
}

// TerminateAsyncEventMapInput is an input type that accepts TerminateAsyncEventMap and TerminateAsyncEventMapOutput values.
// You can construct a concrete instance of `TerminateAsyncEventMapInput` via:
//
//	TerminateAsyncEventMap{ "key": TerminateAsyncEventArgs{...} }
type TerminateAsyncEventMapInput interface {
	pulumi.Input

	ToTerminateAsyncEventMapOutput() TerminateAsyncEventMapOutput
	ToTerminateAsyncEventMapOutputWithContext(context.Context) TerminateAsyncEventMapOutput
}

type TerminateAsyncEventMap map[string]TerminateAsyncEventInput

func (TerminateAsyncEventMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TerminateAsyncEvent)(nil)).Elem()
}

func (i TerminateAsyncEventMap) ToTerminateAsyncEventMapOutput() TerminateAsyncEventMapOutput {
	return i.ToTerminateAsyncEventMapOutputWithContext(context.Background())
}

func (i TerminateAsyncEventMap) ToTerminateAsyncEventMapOutputWithContext(ctx context.Context) TerminateAsyncEventMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TerminateAsyncEventMapOutput)
}

type TerminateAsyncEventOutput struct{ *pulumi.OutputState }

func (TerminateAsyncEventOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TerminateAsyncEvent)(nil)).Elem()
}

func (o TerminateAsyncEventOutput) ToTerminateAsyncEventOutput() TerminateAsyncEventOutput {
	return o
}

func (o TerminateAsyncEventOutput) ToTerminateAsyncEventOutputWithContext(ctx context.Context) TerminateAsyncEventOutput {
	return o
}

// Function name.
func (o TerminateAsyncEventOutput) FunctionName() pulumi.StringOutput {
	return o.ApplyT(func(v *TerminateAsyncEvent) pulumi.StringOutput { return v.FunctionName }).(pulumi.StringOutput)
}

// Whether to enable grace shutdown. If it's true, a SIGTERM signal is sent to the specified request. See [Sending termination signal](https://www.tencentcloud.com/document/product/583/63969?from_cn_redirect=1#.E5.8F.91.E9.80.81.E7.BB.88.E6.AD.A2.E4.BF.A1.E5.8F.B7]. It's set to false by default.
func (o TerminateAsyncEventOutput) GraceShutdown() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *TerminateAsyncEvent) pulumi.BoolPtrOutput { return v.GraceShutdown }).(pulumi.BoolPtrOutput)
}

// Terminated invocation request ID.
func (o TerminateAsyncEventOutput) InvokeRequestId() pulumi.StringOutput {
	return o.ApplyT(func(v *TerminateAsyncEvent) pulumi.StringOutput { return v.InvokeRequestId }).(pulumi.StringOutput)
}

// Namespace.
func (o TerminateAsyncEventOutput) Namespace() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *TerminateAsyncEvent) pulumi.StringPtrOutput { return v.Namespace }).(pulumi.StringPtrOutput)
}

type TerminateAsyncEventArrayOutput struct{ *pulumi.OutputState }

func (TerminateAsyncEventArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TerminateAsyncEvent)(nil)).Elem()
}

func (o TerminateAsyncEventArrayOutput) ToTerminateAsyncEventArrayOutput() TerminateAsyncEventArrayOutput {
	return o
}

func (o TerminateAsyncEventArrayOutput) ToTerminateAsyncEventArrayOutputWithContext(ctx context.Context) TerminateAsyncEventArrayOutput {
	return o
}

func (o TerminateAsyncEventArrayOutput) Index(i pulumi.IntInput) TerminateAsyncEventOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TerminateAsyncEvent {
		return vs[0].([]*TerminateAsyncEvent)[vs[1].(int)]
	}).(TerminateAsyncEventOutput)
}

type TerminateAsyncEventMapOutput struct{ *pulumi.OutputState }

func (TerminateAsyncEventMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TerminateAsyncEvent)(nil)).Elem()
}

func (o TerminateAsyncEventMapOutput) ToTerminateAsyncEventMapOutput() TerminateAsyncEventMapOutput {
	return o
}

func (o TerminateAsyncEventMapOutput) ToTerminateAsyncEventMapOutputWithContext(ctx context.Context) TerminateAsyncEventMapOutput {
	return o
}

func (o TerminateAsyncEventMapOutput) MapIndex(k pulumi.StringInput) TerminateAsyncEventOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TerminateAsyncEvent {
		return vs[0].(map[string]*TerminateAsyncEvent)[vs[1].(string)]
	}).(TerminateAsyncEventOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TerminateAsyncEventInput)(nil)).Elem(), &TerminateAsyncEvent{})
	pulumi.RegisterInputType(reflect.TypeOf((*TerminateAsyncEventArrayInput)(nil)).Elem(), TerminateAsyncEventArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TerminateAsyncEventMapInput)(nil)).Elem(), TerminateAsyncEventMap{})
	pulumi.RegisterOutputType(TerminateAsyncEventOutput{})
	pulumi.RegisterOutputType(TerminateAsyncEventArrayOutput{})
	pulumi.RegisterOutputType(TerminateAsyncEventMapOutput{})
}
