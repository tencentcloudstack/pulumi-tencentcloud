// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package teo

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a teo teoFunctionRuntimeEnvironment
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Teo"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Teo.NewFunctionRuntimeEnvironment(ctx, "teoFunctionRuntimeEnvironment", &Teo.FunctionRuntimeEnvironmentArgs{
//				EnvironmentVariables: teo.FunctionRuntimeEnvironmentEnvironmentVariableArray{
//					&teo.FunctionRuntimeEnvironmentEnvironmentVariableArgs{
//						Key:   pulumi.String("test-a"),
//						Type:  pulumi.String("string"),
//						Value: pulumi.String("AAA"),
//					},
//					&teo.FunctionRuntimeEnvironmentEnvironmentVariableArgs{
//						Key:   pulumi.String("test-b"),
//						Type:  pulumi.String("string"),
//						Value: pulumi.String("BBB"),
//					},
//				},
//				FunctionId: pulumi.String("ef-txx7fnua"),
//				ZoneId:     pulumi.String("zone-2qtuhspy7cr6"),
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
// teo teo_function_runtime_environment can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Teo/functionRuntimeEnvironment:FunctionRuntimeEnvironment teo_function_runtime_environment zone_id#function_id
// ```
type FunctionRuntimeEnvironment struct {
	pulumi.CustomResourceState

	// The environment variable list.
	EnvironmentVariables FunctionRuntimeEnvironmentEnvironmentVariableArrayOutput `pulumi:"environmentVariables"`
	// ID of the Function.
	FunctionId pulumi.StringOutput `pulumi:"functionId"`
	// ID of the site.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewFunctionRuntimeEnvironment registers a new resource with the given unique name, arguments, and options.
func NewFunctionRuntimeEnvironment(ctx *pulumi.Context,
	name string, args *FunctionRuntimeEnvironmentArgs, opts ...pulumi.ResourceOption) (*FunctionRuntimeEnvironment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EnvironmentVariables == nil {
		return nil, errors.New("invalid value for required argument 'EnvironmentVariables'")
	}
	if args.FunctionId == nil {
		return nil, errors.New("invalid value for required argument 'FunctionId'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource FunctionRuntimeEnvironment
	err := ctx.RegisterResource("tencentcloud:Teo/functionRuntimeEnvironment:FunctionRuntimeEnvironment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFunctionRuntimeEnvironment gets an existing FunctionRuntimeEnvironment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFunctionRuntimeEnvironment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FunctionRuntimeEnvironmentState, opts ...pulumi.ResourceOption) (*FunctionRuntimeEnvironment, error) {
	var resource FunctionRuntimeEnvironment
	err := ctx.ReadResource("tencentcloud:Teo/functionRuntimeEnvironment:FunctionRuntimeEnvironment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FunctionRuntimeEnvironment resources.
type functionRuntimeEnvironmentState struct {
	// The environment variable list.
	EnvironmentVariables []FunctionRuntimeEnvironmentEnvironmentVariable `pulumi:"environmentVariables"`
	// ID of the Function.
	FunctionId *string `pulumi:"functionId"`
	// ID of the site.
	ZoneId *string `pulumi:"zoneId"`
}

type FunctionRuntimeEnvironmentState struct {
	// The environment variable list.
	EnvironmentVariables FunctionRuntimeEnvironmentEnvironmentVariableArrayInput
	// ID of the Function.
	FunctionId pulumi.StringPtrInput
	// ID of the site.
	ZoneId pulumi.StringPtrInput
}

func (FunctionRuntimeEnvironmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*functionRuntimeEnvironmentState)(nil)).Elem()
}

type functionRuntimeEnvironmentArgs struct {
	// The environment variable list.
	EnvironmentVariables []FunctionRuntimeEnvironmentEnvironmentVariable `pulumi:"environmentVariables"`
	// ID of the Function.
	FunctionId string `pulumi:"functionId"`
	// ID of the site.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a FunctionRuntimeEnvironment resource.
type FunctionRuntimeEnvironmentArgs struct {
	// The environment variable list.
	EnvironmentVariables FunctionRuntimeEnvironmentEnvironmentVariableArrayInput
	// ID of the Function.
	FunctionId pulumi.StringInput
	// ID of the site.
	ZoneId pulumi.StringInput
}

func (FunctionRuntimeEnvironmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*functionRuntimeEnvironmentArgs)(nil)).Elem()
}

type FunctionRuntimeEnvironmentInput interface {
	pulumi.Input

	ToFunctionRuntimeEnvironmentOutput() FunctionRuntimeEnvironmentOutput
	ToFunctionRuntimeEnvironmentOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentOutput
}

func (*FunctionRuntimeEnvironment) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionRuntimeEnvironment)(nil)).Elem()
}

func (i *FunctionRuntimeEnvironment) ToFunctionRuntimeEnvironmentOutput() FunctionRuntimeEnvironmentOutput {
	return i.ToFunctionRuntimeEnvironmentOutputWithContext(context.Background())
}

func (i *FunctionRuntimeEnvironment) ToFunctionRuntimeEnvironmentOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionRuntimeEnvironmentOutput)
}

// FunctionRuntimeEnvironmentArrayInput is an input type that accepts FunctionRuntimeEnvironmentArray and FunctionRuntimeEnvironmentArrayOutput values.
// You can construct a concrete instance of `FunctionRuntimeEnvironmentArrayInput` via:
//
//	FunctionRuntimeEnvironmentArray{ FunctionRuntimeEnvironmentArgs{...} }
type FunctionRuntimeEnvironmentArrayInput interface {
	pulumi.Input

	ToFunctionRuntimeEnvironmentArrayOutput() FunctionRuntimeEnvironmentArrayOutput
	ToFunctionRuntimeEnvironmentArrayOutputWithContext(context.Context) FunctionRuntimeEnvironmentArrayOutput
}

type FunctionRuntimeEnvironmentArray []FunctionRuntimeEnvironmentInput

func (FunctionRuntimeEnvironmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionRuntimeEnvironment)(nil)).Elem()
}

func (i FunctionRuntimeEnvironmentArray) ToFunctionRuntimeEnvironmentArrayOutput() FunctionRuntimeEnvironmentArrayOutput {
	return i.ToFunctionRuntimeEnvironmentArrayOutputWithContext(context.Background())
}

func (i FunctionRuntimeEnvironmentArray) ToFunctionRuntimeEnvironmentArrayOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionRuntimeEnvironmentArrayOutput)
}

// FunctionRuntimeEnvironmentMapInput is an input type that accepts FunctionRuntimeEnvironmentMap and FunctionRuntimeEnvironmentMapOutput values.
// You can construct a concrete instance of `FunctionRuntimeEnvironmentMapInput` via:
//
//	FunctionRuntimeEnvironmentMap{ "key": FunctionRuntimeEnvironmentArgs{...} }
type FunctionRuntimeEnvironmentMapInput interface {
	pulumi.Input

	ToFunctionRuntimeEnvironmentMapOutput() FunctionRuntimeEnvironmentMapOutput
	ToFunctionRuntimeEnvironmentMapOutputWithContext(context.Context) FunctionRuntimeEnvironmentMapOutput
}

type FunctionRuntimeEnvironmentMap map[string]FunctionRuntimeEnvironmentInput

func (FunctionRuntimeEnvironmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionRuntimeEnvironment)(nil)).Elem()
}

func (i FunctionRuntimeEnvironmentMap) ToFunctionRuntimeEnvironmentMapOutput() FunctionRuntimeEnvironmentMapOutput {
	return i.ToFunctionRuntimeEnvironmentMapOutputWithContext(context.Background())
}

func (i FunctionRuntimeEnvironmentMap) ToFunctionRuntimeEnvironmentMapOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(FunctionRuntimeEnvironmentMapOutput)
}

type FunctionRuntimeEnvironmentOutput struct{ *pulumi.OutputState }

func (FunctionRuntimeEnvironmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**FunctionRuntimeEnvironment)(nil)).Elem()
}

func (o FunctionRuntimeEnvironmentOutput) ToFunctionRuntimeEnvironmentOutput() FunctionRuntimeEnvironmentOutput {
	return o
}

func (o FunctionRuntimeEnvironmentOutput) ToFunctionRuntimeEnvironmentOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentOutput {
	return o
}

// The environment variable list.
func (o FunctionRuntimeEnvironmentOutput) EnvironmentVariables() FunctionRuntimeEnvironmentEnvironmentVariableArrayOutput {
	return o.ApplyT(func(v *FunctionRuntimeEnvironment) FunctionRuntimeEnvironmentEnvironmentVariableArrayOutput {
		return v.EnvironmentVariables
	}).(FunctionRuntimeEnvironmentEnvironmentVariableArrayOutput)
}

// ID of the Function.
func (o FunctionRuntimeEnvironmentOutput) FunctionId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionRuntimeEnvironment) pulumi.StringOutput { return v.FunctionId }).(pulumi.StringOutput)
}

// ID of the site.
func (o FunctionRuntimeEnvironmentOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *FunctionRuntimeEnvironment) pulumi.StringOutput { return v.ZoneId }).(pulumi.StringOutput)
}

type FunctionRuntimeEnvironmentArrayOutput struct{ *pulumi.OutputState }

func (FunctionRuntimeEnvironmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*FunctionRuntimeEnvironment)(nil)).Elem()
}

func (o FunctionRuntimeEnvironmentArrayOutput) ToFunctionRuntimeEnvironmentArrayOutput() FunctionRuntimeEnvironmentArrayOutput {
	return o
}

func (o FunctionRuntimeEnvironmentArrayOutput) ToFunctionRuntimeEnvironmentArrayOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentArrayOutput {
	return o
}

func (o FunctionRuntimeEnvironmentArrayOutput) Index(i pulumi.IntInput) FunctionRuntimeEnvironmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *FunctionRuntimeEnvironment {
		return vs[0].([]*FunctionRuntimeEnvironment)[vs[1].(int)]
	}).(FunctionRuntimeEnvironmentOutput)
}

type FunctionRuntimeEnvironmentMapOutput struct{ *pulumi.OutputState }

func (FunctionRuntimeEnvironmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*FunctionRuntimeEnvironment)(nil)).Elem()
}

func (o FunctionRuntimeEnvironmentMapOutput) ToFunctionRuntimeEnvironmentMapOutput() FunctionRuntimeEnvironmentMapOutput {
	return o
}

func (o FunctionRuntimeEnvironmentMapOutput) ToFunctionRuntimeEnvironmentMapOutputWithContext(ctx context.Context) FunctionRuntimeEnvironmentMapOutput {
	return o
}

func (o FunctionRuntimeEnvironmentMapOutput) MapIndex(k pulumi.StringInput) FunctionRuntimeEnvironmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *FunctionRuntimeEnvironment {
		return vs[0].(map[string]*FunctionRuntimeEnvironment)[vs[1].(string)]
	}).(FunctionRuntimeEnvironmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionRuntimeEnvironmentInput)(nil)).Elem(), &FunctionRuntimeEnvironment{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionRuntimeEnvironmentArrayInput)(nil)).Elem(), FunctionRuntimeEnvironmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*FunctionRuntimeEnvironmentMapInput)(nil)).Elem(), FunctionRuntimeEnvironmentMap{})
	pulumi.RegisterOutputType(FunctionRuntimeEnvironmentOutput{})
	pulumi.RegisterOutputType(FunctionRuntimeEnvironmentArrayOutput{})
	pulumi.RegisterOutputType(FunctionRuntimeEnvironmentMapOutput{})
}
