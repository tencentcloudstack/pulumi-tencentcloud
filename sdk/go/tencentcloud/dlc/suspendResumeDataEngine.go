// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dlc

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a dlc suspendResumeDataEngine
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dlc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dlc.NewSuspendResumeDataEngine(ctx, "suspendResumeDataEngine", &Dlc.SuspendResumeDataEngineArgs{
//				DataEngineName: pulumi.String("example-iac"),
//				Operate:        pulumi.String("suspend"),
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
// dlc suspend_resume_data_engine can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Dlc/suspendResumeDataEngine:SuspendResumeDataEngine suspend_resume_data_engine suspend_resume_data_engine_id
// ```
type SuspendResumeDataEngine struct {
	pulumi.CustomResourceState

	// Engine name.
	DataEngineName pulumi.StringOutput `pulumi:"dataEngineName"`
	// Engine operate tye: suspend/resume.
	Operate pulumi.StringOutput `pulumi:"operate"`
}

// NewSuspendResumeDataEngine registers a new resource with the given unique name, arguments, and options.
func NewSuspendResumeDataEngine(ctx *pulumi.Context,
	name string, args *SuspendResumeDataEngineArgs, opts ...pulumi.ResourceOption) (*SuspendResumeDataEngine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DataEngineName == nil {
		return nil, errors.New("invalid value for required argument 'DataEngineName'")
	}
	if args.Operate == nil {
		return nil, errors.New("invalid value for required argument 'Operate'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource SuspendResumeDataEngine
	err := ctx.RegisterResource("tencentcloud:Dlc/suspendResumeDataEngine:SuspendResumeDataEngine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSuspendResumeDataEngine gets an existing SuspendResumeDataEngine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSuspendResumeDataEngine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SuspendResumeDataEngineState, opts ...pulumi.ResourceOption) (*SuspendResumeDataEngine, error) {
	var resource SuspendResumeDataEngine
	err := ctx.ReadResource("tencentcloud:Dlc/suspendResumeDataEngine:SuspendResumeDataEngine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SuspendResumeDataEngine resources.
type suspendResumeDataEngineState struct {
	// Engine name.
	DataEngineName *string `pulumi:"dataEngineName"`
	// Engine operate tye: suspend/resume.
	Operate *string `pulumi:"operate"`
}

type SuspendResumeDataEngineState struct {
	// Engine name.
	DataEngineName pulumi.StringPtrInput
	// Engine operate tye: suspend/resume.
	Operate pulumi.StringPtrInput
}

func (SuspendResumeDataEngineState) ElementType() reflect.Type {
	return reflect.TypeOf((*suspendResumeDataEngineState)(nil)).Elem()
}

type suspendResumeDataEngineArgs struct {
	// Engine name.
	DataEngineName string `pulumi:"dataEngineName"`
	// Engine operate tye: suspend/resume.
	Operate string `pulumi:"operate"`
}

// The set of arguments for constructing a SuspendResumeDataEngine resource.
type SuspendResumeDataEngineArgs struct {
	// Engine name.
	DataEngineName pulumi.StringInput
	// Engine operate tye: suspend/resume.
	Operate pulumi.StringInput
}

func (SuspendResumeDataEngineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*suspendResumeDataEngineArgs)(nil)).Elem()
}

type SuspendResumeDataEngineInput interface {
	pulumi.Input

	ToSuspendResumeDataEngineOutput() SuspendResumeDataEngineOutput
	ToSuspendResumeDataEngineOutputWithContext(ctx context.Context) SuspendResumeDataEngineOutput
}

func (*SuspendResumeDataEngine) ElementType() reflect.Type {
	return reflect.TypeOf((**SuspendResumeDataEngine)(nil)).Elem()
}

func (i *SuspendResumeDataEngine) ToSuspendResumeDataEngineOutput() SuspendResumeDataEngineOutput {
	return i.ToSuspendResumeDataEngineOutputWithContext(context.Background())
}

func (i *SuspendResumeDataEngine) ToSuspendResumeDataEngineOutputWithContext(ctx context.Context) SuspendResumeDataEngineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SuspendResumeDataEngineOutput)
}

// SuspendResumeDataEngineArrayInput is an input type that accepts SuspendResumeDataEngineArray and SuspendResumeDataEngineArrayOutput values.
// You can construct a concrete instance of `SuspendResumeDataEngineArrayInput` via:
//
//	SuspendResumeDataEngineArray{ SuspendResumeDataEngineArgs{...} }
type SuspendResumeDataEngineArrayInput interface {
	pulumi.Input

	ToSuspendResumeDataEngineArrayOutput() SuspendResumeDataEngineArrayOutput
	ToSuspendResumeDataEngineArrayOutputWithContext(context.Context) SuspendResumeDataEngineArrayOutput
}

type SuspendResumeDataEngineArray []SuspendResumeDataEngineInput

func (SuspendResumeDataEngineArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SuspendResumeDataEngine)(nil)).Elem()
}

func (i SuspendResumeDataEngineArray) ToSuspendResumeDataEngineArrayOutput() SuspendResumeDataEngineArrayOutput {
	return i.ToSuspendResumeDataEngineArrayOutputWithContext(context.Background())
}

func (i SuspendResumeDataEngineArray) ToSuspendResumeDataEngineArrayOutputWithContext(ctx context.Context) SuspendResumeDataEngineArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SuspendResumeDataEngineArrayOutput)
}

// SuspendResumeDataEngineMapInput is an input type that accepts SuspendResumeDataEngineMap and SuspendResumeDataEngineMapOutput values.
// You can construct a concrete instance of `SuspendResumeDataEngineMapInput` via:
//
//	SuspendResumeDataEngineMap{ "key": SuspendResumeDataEngineArgs{...} }
type SuspendResumeDataEngineMapInput interface {
	pulumi.Input

	ToSuspendResumeDataEngineMapOutput() SuspendResumeDataEngineMapOutput
	ToSuspendResumeDataEngineMapOutputWithContext(context.Context) SuspendResumeDataEngineMapOutput
}

type SuspendResumeDataEngineMap map[string]SuspendResumeDataEngineInput

func (SuspendResumeDataEngineMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SuspendResumeDataEngine)(nil)).Elem()
}

func (i SuspendResumeDataEngineMap) ToSuspendResumeDataEngineMapOutput() SuspendResumeDataEngineMapOutput {
	return i.ToSuspendResumeDataEngineMapOutputWithContext(context.Background())
}

func (i SuspendResumeDataEngineMap) ToSuspendResumeDataEngineMapOutputWithContext(ctx context.Context) SuspendResumeDataEngineMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SuspendResumeDataEngineMapOutput)
}

type SuspendResumeDataEngineOutput struct{ *pulumi.OutputState }

func (SuspendResumeDataEngineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SuspendResumeDataEngine)(nil)).Elem()
}

func (o SuspendResumeDataEngineOutput) ToSuspendResumeDataEngineOutput() SuspendResumeDataEngineOutput {
	return o
}

func (o SuspendResumeDataEngineOutput) ToSuspendResumeDataEngineOutputWithContext(ctx context.Context) SuspendResumeDataEngineOutput {
	return o
}

// Engine name.
func (o SuspendResumeDataEngineOutput) DataEngineName() pulumi.StringOutput {
	return o.ApplyT(func(v *SuspendResumeDataEngine) pulumi.StringOutput { return v.DataEngineName }).(pulumi.StringOutput)
}

// Engine operate tye: suspend/resume.
func (o SuspendResumeDataEngineOutput) Operate() pulumi.StringOutput {
	return o.ApplyT(func(v *SuspendResumeDataEngine) pulumi.StringOutput { return v.Operate }).(pulumi.StringOutput)
}

type SuspendResumeDataEngineArrayOutput struct{ *pulumi.OutputState }

func (SuspendResumeDataEngineArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*SuspendResumeDataEngine)(nil)).Elem()
}

func (o SuspendResumeDataEngineArrayOutput) ToSuspendResumeDataEngineArrayOutput() SuspendResumeDataEngineArrayOutput {
	return o
}

func (o SuspendResumeDataEngineArrayOutput) ToSuspendResumeDataEngineArrayOutputWithContext(ctx context.Context) SuspendResumeDataEngineArrayOutput {
	return o
}

func (o SuspendResumeDataEngineArrayOutput) Index(i pulumi.IntInput) SuspendResumeDataEngineOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *SuspendResumeDataEngine {
		return vs[0].([]*SuspendResumeDataEngine)[vs[1].(int)]
	}).(SuspendResumeDataEngineOutput)
}

type SuspendResumeDataEngineMapOutput struct{ *pulumi.OutputState }

func (SuspendResumeDataEngineMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*SuspendResumeDataEngine)(nil)).Elem()
}

func (o SuspendResumeDataEngineMapOutput) ToSuspendResumeDataEngineMapOutput() SuspendResumeDataEngineMapOutput {
	return o
}

func (o SuspendResumeDataEngineMapOutput) ToSuspendResumeDataEngineMapOutputWithContext(ctx context.Context) SuspendResumeDataEngineMapOutput {
	return o
}

func (o SuspendResumeDataEngineMapOutput) MapIndex(k pulumi.StringInput) SuspendResumeDataEngineOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *SuspendResumeDataEngine {
		return vs[0].(map[string]*SuspendResumeDataEngine)[vs[1].(string)]
	}).(SuspendResumeDataEngineOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*SuspendResumeDataEngineInput)(nil)).Elem(), &SuspendResumeDataEngine{})
	pulumi.RegisterInputType(reflect.TypeOf((*SuspendResumeDataEngineArrayInput)(nil)).Elem(), SuspendResumeDataEngineArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*SuspendResumeDataEngineMapInput)(nil)).Elem(), SuspendResumeDataEngineMap{})
	pulumi.RegisterOutputType(SuspendResumeDataEngineOutput{})
	pulumi.RegisterOutputType(SuspendResumeDataEngineArrayOutput{})
	pulumi.RegisterOutputType(SuspendResumeDataEngineMapOutput{})
}
