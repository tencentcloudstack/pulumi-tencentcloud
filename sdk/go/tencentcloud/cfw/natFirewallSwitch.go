// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cfw

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a cfw natFirewallSwitch
//
// ## Example Usage
//
// ### Turn off switch
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cfw"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			exampleNatFwSwitches, err := Cfw.GetNatFwSwitches(ctx, &cfw.GetNatFwSwitchesArgs{
//				NatInsId: pulumi.StringRef("cfwnat-18d2ba18"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = Cfw.NewNatFirewallSwitch(ctx, "exampleNatFirewallSwitch", &Cfw.NatFirewallSwitchArgs{
//				NatInsId: pulumi.String(exampleNatFwSwitches.Id),
//				SubnetId: pulumi.String(exampleNatFwSwitches.Datas[0].SubnetId),
//				Enable:   pulumi.Int(0),
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
// ### Or turn on switch
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cfw"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			exampleNatFwSwitches, err := Cfw.GetNatFwSwitches(ctx, &cfw.GetNatFwSwitchesArgs{
//				NatInsId: pulumi.StringRef("cfwnat-18d2ba18"),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			_, err = Cfw.NewNatFirewallSwitch(ctx, "exampleNatFirewallSwitch", &Cfw.NatFirewallSwitchArgs{
//				NatInsId: pulumi.String(exampleNatFwSwitches.Id),
//				SubnetId: pulumi.String(exampleNatFwSwitches.Datas[0].SubnetId),
//				Enable:   pulumi.Int(1),
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
// cfw nat_firewall_switch can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch example cfwnat-18d2ba18#subnet-ef7wyymr
// ```
type NatFirewallSwitch struct {
	pulumi.CustomResourceState

	// Switch, 0: off, 1: on.
	Enable pulumi.IntOutput `pulumi:"enable"`
	// Firewall instance id.
	NatInsId pulumi.StringOutput `pulumi:"natInsId"`
	// subnet id.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
}

// NewNatFirewallSwitch registers a new resource with the given unique name, arguments, and options.
func NewNatFirewallSwitch(ctx *pulumi.Context,
	name string, args *NatFirewallSwitchArgs, opts ...pulumi.ResourceOption) (*NatFirewallSwitch, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Enable == nil {
		return nil, errors.New("invalid value for required argument 'Enable'")
	}
	if args.NatInsId == nil {
		return nil, errors.New("invalid value for required argument 'NatInsId'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource NatFirewallSwitch
	err := ctx.RegisterResource("tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetNatFirewallSwitch gets an existing NatFirewallSwitch resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetNatFirewallSwitch(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *NatFirewallSwitchState, opts ...pulumi.ResourceOption) (*NatFirewallSwitch, error) {
	var resource NatFirewallSwitch
	err := ctx.ReadResource("tencentcloud:Cfw/natFirewallSwitch:NatFirewallSwitch", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering NatFirewallSwitch resources.
type natFirewallSwitchState struct {
	// Switch, 0: off, 1: on.
	Enable *int `pulumi:"enable"`
	// Firewall instance id.
	NatInsId *string `pulumi:"natInsId"`
	// subnet id.
	SubnetId *string `pulumi:"subnetId"`
}

type NatFirewallSwitchState struct {
	// Switch, 0: off, 1: on.
	Enable pulumi.IntPtrInput
	// Firewall instance id.
	NatInsId pulumi.StringPtrInput
	// subnet id.
	SubnetId pulumi.StringPtrInput
}

func (NatFirewallSwitchState) ElementType() reflect.Type {
	return reflect.TypeOf((*natFirewallSwitchState)(nil)).Elem()
}

type natFirewallSwitchArgs struct {
	// Switch, 0: off, 1: on.
	Enable int `pulumi:"enable"`
	// Firewall instance id.
	NatInsId string `pulumi:"natInsId"`
	// subnet id.
	SubnetId string `pulumi:"subnetId"`
}

// The set of arguments for constructing a NatFirewallSwitch resource.
type NatFirewallSwitchArgs struct {
	// Switch, 0: off, 1: on.
	Enable pulumi.IntInput
	// Firewall instance id.
	NatInsId pulumi.StringInput
	// subnet id.
	SubnetId pulumi.StringInput
}

func (NatFirewallSwitchArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*natFirewallSwitchArgs)(nil)).Elem()
}

type NatFirewallSwitchInput interface {
	pulumi.Input

	ToNatFirewallSwitchOutput() NatFirewallSwitchOutput
	ToNatFirewallSwitchOutputWithContext(ctx context.Context) NatFirewallSwitchOutput
}

func (*NatFirewallSwitch) ElementType() reflect.Type {
	return reflect.TypeOf((**NatFirewallSwitch)(nil)).Elem()
}

func (i *NatFirewallSwitch) ToNatFirewallSwitchOutput() NatFirewallSwitchOutput {
	return i.ToNatFirewallSwitchOutputWithContext(context.Background())
}

func (i *NatFirewallSwitch) ToNatFirewallSwitchOutputWithContext(ctx context.Context) NatFirewallSwitchOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NatFirewallSwitchOutput)
}

// NatFirewallSwitchArrayInput is an input type that accepts NatFirewallSwitchArray and NatFirewallSwitchArrayOutput values.
// You can construct a concrete instance of `NatFirewallSwitchArrayInput` via:
//
//	NatFirewallSwitchArray{ NatFirewallSwitchArgs{...} }
type NatFirewallSwitchArrayInput interface {
	pulumi.Input

	ToNatFirewallSwitchArrayOutput() NatFirewallSwitchArrayOutput
	ToNatFirewallSwitchArrayOutputWithContext(context.Context) NatFirewallSwitchArrayOutput
}

type NatFirewallSwitchArray []NatFirewallSwitchInput

func (NatFirewallSwitchArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NatFirewallSwitch)(nil)).Elem()
}

func (i NatFirewallSwitchArray) ToNatFirewallSwitchArrayOutput() NatFirewallSwitchArrayOutput {
	return i.ToNatFirewallSwitchArrayOutputWithContext(context.Background())
}

func (i NatFirewallSwitchArray) ToNatFirewallSwitchArrayOutputWithContext(ctx context.Context) NatFirewallSwitchArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NatFirewallSwitchArrayOutput)
}

// NatFirewallSwitchMapInput is an input type that accepts NatFirewallSwitchMap and NatFirewallSwitchMapOutput values.
// You can construct a concrete instance of `NatFirewallSwitchMapInput` via:
//
//	NatFirewallSwitchMap{ "key": NatFirewallSwitchArgs{...} }
type NatFirewallSwitchMapInput interface {
	pulumi.Input

	ToNatFirewallSwitchMapOutput() NatFirewallSwitchMapOutput
	ToNatFirewallSwitchMapOutputWithContext(context.Context) NatFirewallSwitchMapOutput
}

type NatFirewallSwitchMap map[string]NatFirewallSwitchInput

func (NatFirewallSwitchMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NatFirewallSwitch)(nil)).Elem()
}

func (i NatFirewallSwitchMap) ToNatFirewallSwitchMapOutput() NatFirewallSwitchMapOutput {
	return i.ToNatFirewallSwitchMapOutputWithContext(context.Background())
}

func (i NatFirewallSwitchMap) ToNatFirewallSwitchMapOutputWithContext(ctx context.Context) NatFirewallSwitchMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(NatFirewallSwitchMapOutput)
}

type NatFirewallSwitchOutput struct{ *pulumi.OutputState }

func (NatFirewallSwitchOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**NatFirewallSwitch)(nil)).Elem()
}

func (o NatFirewallSwitchOutput) ToNatFirewallSwitchOutput() NatFirewallSwitchOutput {
	return o
}

func (o NatFirewallSwitchOutput) ToNatFirewallSwitchOutputWithContext(ctx context.Context) NatFirewallSwitchOutput {
	return o
}

// Switch, 0: off, 1: on.
func (o NatFirewallSwitchOutput) Enable() pulumi.IntOutput {
	return o.ApplyT(func(v *NatFirewallSwitch) pulumi.IntOutput { return v.Enable }).(pulumi.IntOutput)
}

// Firewall instance id.
func (o NatFirewallSwitchOutput) NatInsId() pulumi.StringOutput {
	return o.ApplyT(func(v *NatFirewallSwitch) pulumi.StringOutput { return v.NatInsId }).(pulumi.StringOutput)
}

// subnet id.
func (o NatFirewallSwitchOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *NatFirewallSwitch) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

type NatFirewallSwitchArrayOutput struct{ *pulumi.OutputState }

func (NatFirewallSwitchArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*NatFirewallSwitch)(nil)).Elem()
}

func (o NatFirewallSwitchArrayOutput) ToNatFirewallSwitchArrayOutput() NatFirewallSwitchArrayOutput {
	return o
}

func (o NatFirewallSwitchArrayOutput) ToNatFirewallSwitchArrayOutputWithContext(ctx context.Context) NatFirewallSwitchArrayOutput {
	return o
}

func (o NatFirewallSwitchArrayOutput) Index(i pulumi.IntInput) NatFirewallSwitchOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *NatFirewallSwitch {
		return vs[0].([]*NatFirewallSwitch)[vs[1].(int)]
	}).(NatFirewallSwitchOutput)
}

type NatFirewallSwitchMapOutput struct{ *pulumi.OutputState }

func (NatFirewallSwitchMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*NatFirewallSwitch)(nil)).Elem()
}

func (o NatFirewallSwitchMapOutput) ToNatFirewallSwitchMapOutput() NatFirewallSwitchMapOutput {
	return o
}

func (o NatFirewallSwitchMapOutput) ToNatFirewallSwitchMapOutputWithContext(ctx context.Context) NatFirewallSwitchMapOutput {
	return o
}

func (o NatFirewallSwitchMapOutput) MapIndex(k pulumi.StringInput) NatFirewallSwitchOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *NatFirewallSwitch {
		return vs[0].(map[string]*NatFirewallSwitch)[vs[1].(string)]
	}).(NatFirewallSwitchOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*NatFirewallSwitchInput)(nil)).Elem(), &NatFirewallSwitch{})
	pulumi.RegisterInputType(reflect.TypeOf((*NatFirewallSwitchArrayInput)(nil)).Elem(), NatFirewallSwitchArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*NatFirewallSwitchMapInput)(nil)).Elem(), NatFirewallSwitchMap{})
	pulumi.RegisterOutputType(NatFirewallSwitchOutput{})
	pulumi.RegisterOutputType(NatFirewallSwitchArrayOutput{})
	pulumi.RegisterOutputType(NatFirewallSwitchMapOutput{})
}
