// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package kms

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a kms overwriteWhiteBoxDeviceFingerprints
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Kms"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Kms.NewOverwriteWhiteBoxDeviceFingerprints(ctx, "example", &Kms.OverwriteWhiteBoxDeviceFingerprintsArgs{
//				KeyId: pulumi.String("23e80852-1e38-11e9-b129-5cb9019b4b01"),
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
type OverwriteWhiteBoxDeviceFingerprints struct {
	pulumi.CustomResourceState

	// Device fingerprint list.
	DeviceFingerprints OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayOutput `pulumi:"deviceFingerprints"`
	// CMK unique identifier.
	KeyId pulumi.StringOutput `pulumi:"keyId"`
}

// NewOverwriteWhiteBoxDeviceFingerprints registers a new resource with the given unique name, arguments, and options.
func NewOverwriteWhiteBoxDeviceFingerprints(ctx *pulumi.Context,
	name string, args *OverwriteWhiteBoxDeviceFingerprintsArgs, opts ...pulumi.ResourceOption) (*OverwriteWhiteBoxDeviceFingerprints, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.KeyId == nil {
		return nil, errors.New("invalid value for required argument 'KeyId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OverwriteWhiteBoxDeviceFingerprints
	err := ctx.RegisterResource("tencentcloud:Kms/overwriteWhiteBoxDeviceFingerprints:OverwriteWhiteBoxDeviceFingerprints", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOverwriteWhiteBoxDeviceFingerprints gets an existing OverwriteWhiteBoxDeviceFingerprints resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOverwriteWhiteBoxDeviceFingerprints(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OverwriteWhiteBoxDeviceFingerprintsState, opts ...pulumi.ResourceOption) (*OverwriteWhiteBoxDeviceFingerprints, error) {
	var resource OverwriteWhiteBoxDeviceFingerprints
	err := ctx.ReadResource("tencentcloud:Kms/overwriteWhiteBoxDeviceFingerprints:OverwriteWhiteBoxDeviceFingerprints", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OverwriteWhiteBoxDeviceFingerprints resources.
type overwriteWhiteBoxDeviceFingerprintsState struct {
	// Device fingerprint list.
	DeviceFingerprints []OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprint `pulumi:"deviceFingerprints"`
	// CMK unique identifier.
	KeyId *string `pulumi:"keyId"`
}

type OverwriteWhiteBoxDeviceFingerprintsState struct {
	// Device fingerprint list.
	DeviceFingerprints OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayInput
	// CMK unique identifier.
	KeyId pulumi.StringPtrInput
}

func (OverwriteWhiteBoxDeviceFingerprintsState) ElementType() reflect.Type {
	return reflect.TypeOf((*overwriteWhiteBoxDeviceFingerprintsState)(nil)).Elem()
}

type overwriteWhiteBoxDeviceFingerprintsArgs struct {
	// Device fingerprint list.
	DeviceFingerprints []OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprint `pulumi:"deviceFingerprints"`
	// CMK unique identifier.
	KeyId string `pulumi:"keyId"`
}

// The set of arguments for constructing a OverwriteWhiteBoxDeviceFingerprints resource.
type OverwriteWhiteBoxDeviceFingerprintsArgs struct {
	// Device fingerprint list.
	DeviceFingerprints OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayInput
	// CMK unique identifier.
	KeyId pulumi.StringInput
}

func (OverwriteWhiteBoxDeviceFingerprintsArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*overwriteWhiteBoxDeviceFingerprintsArgs)(nil)).Elem()
}

type OverwriteWhiteBoxDeviceFingerprintsInput interface {
	pulumi.Input

	ToOverwriteWhiteBoxDeviceFingerprintsOutput() OverwriteWhiteBoxDeviceFingerprintsOutput
	ToOverwriteWhiteBoxDeviceFingerprintsOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsOutput
}

func (*OverwriteWhiteBoxDeviceFingerprints) ElementType() reflect.Type {
	return reflect.TypeOf((**OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (i *OverwriteWhiteBoxDeviceFingerprints) ToOverwriteWhiteBoxDeviceFingerprintsOutput() OverwriteWhiteBoxDeviceFingerprintsOutput {
	return i.ToOverwriteWhiteBoxDeviceFingerprintsOutputWithContext(context.Background())
}

func (i *OverwriteWhiteBoxDeviceFingerprints) ToOverwriteWhiteBoxDeviceFingerprintsOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OverwriteWhiteBoxDeviceFingerprintsOutput)
}

// OverwriteWhiteBoxDeviceFingerprintsArrayInput is an input type that accepts OverwriteWhiteBoxDeviceFingerprintsArray and OverwriteWhiteBoxDeviceFingerprintsArrayOutput values.
// You can construct a concrete instance of `OverwriteWhiteBoxDeviceFingerprintsArrayInput` via:
//
//	OverwriteWhiteBoxDeviceFingerprintsArray{ OverwriteWhiteBoxDeviceFingerprintsArgs{...} }
type OverwriteWhiteBoxDeviceFingerprintsArrayInput interface {
	pulumi.Input

	ToOverwriteWhiteBoxDeviceFingerprintsArrayOutput() OverwriteWhiteBoxDeviceFingerprintsArrayOutput
	ToOverwriteWhiteBoxDeviceFingerprintsArrayOutputWithContext(context.Context) OverwriteWhiteBoxDeviceFingerprintsArrayOutput
}

type OverwriteWhiteBoxDeviceFingerprintsArray []OverwriteWhiteBoxDeviceFingerprintsInput

func (OverwriteWhiteBoxDeviceFingerprintsArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (i OverwriteWhiteBoxDeviceFingerprintsArray) ToOverwriteWhiteBoxDeviceFingerprintsArrayOutput() OverwriteWhiteBoxDeviceFingerprintsArrayOutput {
	return i.ToOverwriteWhiteBoxDeviceFingerprintsArrayOutputWithContext(context.Background())
}

func (i OverwriteWhiteBoxDeviceFingerprintsArray) ToOverwriteWhiteBoxDeviceFingerprintsArrayOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OverwriteWhiteBoxDeviceFingerprintsArrayOutput)
}

// OverwriteWhiteBoxDeviceFingerprintsMapInput is an input type that accepts OverwriteWhiteBoxDeviceFingerprintsMap and OverwriteWhiteBoxDeviceFingerprintsMapOutput values.
// You can construct a concrete instance of `OverwriteWhiteBoxDeviceFingerprintsMapInput` via:
//
//	OverwriteWhiteBoxDeviceFingerprintsMap{ "key": OverwriteWhiteBoxDeviceFingerprintsArgs{...} }
type OverwriteWhiteBoxDeviceFingerprintsMapInput interface {
	pulumi.Input

	ToOverwriteWhiteBoxDeviceFingerprintsMapOutput() OverwriteWhiteBoxDeviceFingerprintsMapOutput
	ToOverwriteWhiteBoxDeviceFingerprintsMapOutputWithContext(context.Context) OverwriteWhiteBoxDeviceFingerprintsMapOutput
}

type OverwriteWhiteBoxDeviceFingerprintsMap map[string]OverwriteWhiteBoxDeviceFingerprintsInput

func (OverwriteWhiteBoxDeviceFingerprintsMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (i OverwriteWhiteBoxDeviceFingerprintsMap) ToOverwriteWhiteBoxDeviceFingerprintsMapOutput() OverwriteWhiteBoxDeviceFingerprintsMapOutput {
	return i.ToOverwriteWhiteBoxDeviceFingerprintsMapOutputWithContext(context.Background())
}

func (i OverwriteWhiteBoxDeviceFingerprintsMap) ToOverwriteWhiteBoxDeviceFingerprintsMapOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OverwriteWhiteBoxDeviceFingerprintsMapOutput)
}

type OverwriteWhiteBoxDeviceFingerprintsOutput struct{ *pulumi.OutputState }

func (OverwriteWhiteBoxDeviceFingerprintsOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (o OverwriteWhiteBoxDeviceFingerprintsOutput) ToOverwriteWhiteBoxDeviceFingerprintsOutput() OverwriteWhiteBoxDeviceFingerprintsOutput {
	return o
}

func (o OverwriteWhiteBoxDeviceFingerprintsOutput) ToOverwriteWhiteBoxDeviceFingerprintsOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsOutput {
	return o
}

// Device fingerprint list.
func (o OverwriteWhiteBoxDeviceFingerprintsOutput) DeviceFingerprints() OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayOutput {
	return o.ApplyT(func(v *OverwriteWhiteBoxDeviceFingerprints) OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayOutput {
		return v.DeviceFingerprints
	}).(OverwriteWhiteBoxDeviceFingerprintsDeviceFingerprintArrayOutput)
}

// CMK unique identifier.
func (o OverwriteWhiteBoxDeviceFingerprintsOutput) KeyId() pulumi.StringOutput {
	return o.ApplyT(func(v *OverwriteWhiteBoxDeviceFingerprints) pulumi.StringOutput { return v.KeyId }).(pulumi.StringOutput)
}

type OverwriteWhiteBoxDeviceFingerprintsArrayOutput struct{ *pulumi.OutputState }

func (OverwriteWhiteBoxDeviceFingerprintsArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (o OverwriteWhiteBoxDeviceFingerprintsArrayOutput) ToOverwriteWhiteBoxDeviceFingerprintsArrayOutput() OverwriteWhiteBoxDeviceFingerprintsArrayOutput {
	return o
}

func (o OverwriteWhiteBoxDeviceFingerprintsArrayOutput) ToOverwriteWhiteBoxDeviceFingerprintsArrayOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsArrayOutput {
	return o
}

func (o OverwriteWhiteBoxDeviceFingerprintsArrayOutput) Index(i pulumi.IntInput) OverwriteWhiteBoxDeviceFingerprintsOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OverwriteWhiteBoxDeviceFingerprints {
		return vs[0].([]*OverwriteWhiteBoxDeviceFingerprints)[vs[1].(int)]
	}).(OverwriteWhiteBoxDeviceFingerprintsOutput)
}

type OverwriteWhiteBoxDeviceFingerprintsMapOutput struct{ *pulumi.OutputState }

func (OverwriteWhiteBoxDeviceFingerprintsMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OverwriteWhiteBoxDeviceFingerprints)(nil)).Elem()
}

func (o OverwriteWhiteBoxDeviceFingerprintsMapOutput) ToOverwriteWhiteBoxDeviceFingerprintsMapOutput() OverwriteWhiteBoxDeviceFingerprintsMapOutput {
	return o
}

func (o OverwriteWhiteBoxDeviceFingerprintsMapOutput) ToOverwriteWhiteBoxDeviceFingerprintsMapOutputWithContext(ctx context.Context) OverwriteWhiteBoxDeviceFingerprintsMapOutput {
	return o
}

func (o OverwriteWhiteBoxDeviceFingerprintsMapOutput) MapIndex(k pulumi.StringInput) OverwriteWhiteBoxDeviceFingerprintsOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OverwriteWhiteBoxDeviceFingerprints {
		return vs[0].(map[string]*OverwriteWhiteBoxDeviceFingerprints)[vs[1].(string)]
	}).(OverwriteWhiteBoxDeviceFingerprintsOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OverwriteWhiteBoxDeviceFingerprintsInput)(nil)).Elem(), &OverwriteWhiteBoxDeviceFingerprints{})
	pulumi.RegisterInputType(reflect.TypeOf((*OverwriteWhiteBoxDeviceFingerprintsArrayInput)(nil)).Elem(), OverwriteWhiteBoxDeviceFingerprintsArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OverwriteWhiteBoxDeviceFingerprintsMapInput)(nil)).Elem(), OverwriteWhiteBoxDeviceFingerprintsMap{})
	pulumi.RegisterOutputType(OverwriteWhiteBoxDeviceFingerprintsOutput{})
	pulumi.RegisterOutputType(OverwriteWhiteBoxDeviceFingerprintsArrayOutput{})
	pulumi.RegisterOutputType(OverwriteWhiteBoxDeviceFingerprintsMapOutput{})
}
