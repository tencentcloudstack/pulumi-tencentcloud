// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dasb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a dasb bindDeviceAccountPrivateKey
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dasb"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			exampleDevice, err := Dasb.NewDevice(ctx, "exampleDevice", &Dasb.DeviceArgs{
//				OsName: pulumi.String("Linux"),
//				Ip:     pulumi.String("192.168.0.1"),
//				Port:   pulumi.Int(80),
//			})
//			if err != nil {
//				return err
//			}
//			exampleDeviceAccount, err := Dasb.NewDeviceAccount(ctx, "exampleDeviceAccount", &Dasb.DeviceAccountArgs{
//				DeviceId: exampleDevice.ID(),
//				Account:  pulumi.String("root"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Dasb.NewBindDeviceAccountPrivateKey(ctx, "exampleBindDeviceAccountPrivateKey", &Dasb.BindDeviceAccountPrivateKeyArgs{
//				DeviceAccountId:    exampleDeviceAccount.ID(),
//				PrivateKey:         pulumi.String("MIICXAIBAAKBgQCqGKukO1De7zhZj6+H0qtjTkVxwTCpvKe4eCZ0FPqri0cb2JZfXJ/DgYSF6vUpwmJG8wVQZKjeGcjDOL5UlsuusFncCzWBQ7RKNUSesmQRMSGkVb1/3j+skZ6UtW+5u09lHNsj6tQ51s1SPrCBkedbNf0Tp0GbMJDyR4e9T04ZZwIDAQABAoGAFijko56+qGyN8M0RVyaRAXz++xTqHBLh"),
//				PrivateKeyPassword: pulumi.String("TerraformPassword"),
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
type BindDeviceAccountPrivateKey struct {
	pulumi.CustomResourceState

	// Host account ID.
	DeviceAccountId pulumi.IntOutput `pulumi:"deviceAccountId"`
	// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
	PrivateKey pulumi.StringOutput `pulumi:"privateKey"`
	// Host account private key password, maximum length 256 bytes.
	PrivateKeyPassword pulumi.StringPtrOutput `pulumi:"privateKeyPassword"`
}

// NewBindDeviceAccountPrivateKey registers a new resource with the given unique name, arguments, and options.
func NewBindDeviceAccountPrivateKey(ctx *pulumi.Context,
	name string, args *BindDeviceAccountPrivateKeyArgs, opts ...pulumi.ResourceOption) (*BindDeviceAccountPrivateKey, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DeviceAccountId == nil {
		return nil, errors.New("invalid value for required argument 'DeviceAccountId'")
	}
	if args.PrivateKey == nil {
		return nil, errors.New("invalid value for required argument 'PrivateKey'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource BindDeviceAccountPrivateKey
	err := ctx.RegisterResource("tencentcloud:Dasb/bindDeviceAccountPrivateKey:BindDeviceAccountPrivateKey", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBindDeviceAccountPrivateKey gets an existing BindDeviceAccountPrivateKey resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBindDeviceAccountPrivateKey(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BindDeviceAccountPrivateKeyState, opts ...pulumi.ResourceOption) (*BindDeviceAccountPrivateKey, error) {
	var resource BindDeviceAccountPrivateKey
	err := ctx.ReadResource("tencentcloud:Dasb/bindDeviceAccountPrivateKey:BindDeviceAccountPrivateKey", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BindDeviceAccountPrivateKey resources.
type bindDeviceAccountPrivateKeyState struct {
	// Host account ID.
	DeviceAccountId *int `pulumi:"deviceAccountId"`
	// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
	PrivateKey *string `pulumi:"privateKey"`
	// Host account private key password, maximum length 256 bytes.
	PrivateKeyPassword *string `pulumi:"privateKeyPassword"`
}

type BindDeviceAccountPrivateKeyState struct {
	// Host account ID.
	DeviceAccountId pulumi.IntPtrInput
	// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
	PrivateKey pulumi.StringPtrInput
	// Host account private key password, maximum length 256 bytes.
	PrivateKeyPassword pulumi.StringPtrInput
}

func (BindDeviceAccountPrivateKeyState) ElementType() reflect.Type {
	return reflect.TypeOf((*bindDeviceAccountPrivateKeyState)(nil)).Elem()
}

type bindDeviceAccountPrivateKeyArgs struct {
	// Host account ID.
	DeviceAccountId int `pulumi:"deviceAccountId"`
	// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
	PrivateKey string `pulumi:"privateKey"`
	// Host account private key password, maximum length 256 bytes.
	PrivateKeyPassword *string `pulumi:"privateKeyPassword"`
}

// The set of arguments for constructing a BindDeviceAccountPrivateKey resource.
type BindDeviceAccountPrivateKeyArgs struct {
	// Host account ID.
	DeviceAccountId pulumi.IntInput
	// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
	PrivateKey pulumi.StringInput
	// Host account private key password, maximum length 256 bytes.
	PrivateKeyPassword pulumi.StringPtrInput
}

func (BindDeviceAccountPrivateKeyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bindDeviceAccountPrivateKeyArgs)(nil)).Elem()
}

type BindDeviceAccountPrivateKeyInput interface {
	pulumi.Input

	ToBindDeviceAccountPrivateKeyOutput() BindDeviceAccountPrivateKeyOutput
	ToBindDeviceAccountPrivateKeyOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyOutput
}

func (*BindDeviceAccountPrivateKey) ElementType() reflect.Type {
	return reflect.TypeOf((**BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (i *BindDeviceAccountPrivateKey) ToBindDeviceAccountPrivateKeyOutput() BindDeviceAccountPrivateKeyOutput {
	return i.ToBindDeviceAccountPrivateKeyOutputWithContext(context.Background())
}

func (i *BindDeviceAccountPrivateKey) ToBindDeviceAccountPrivateKeyOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceAccountPrivateKeyOutput)
}

// BindDeviceAccountPrivateKeyArrayInput is an input type that accepts BindDeviceAccountPrivateKeyArray and BindDeviceAccountPrivateKeyArrayOutput values.
// You can construct a concrete instance of `BindDeviceAccountPrivateKeyArrayInput` via:
//
//	BindDeviceAccountPrivateKeyArray{ BindDeviceAccountPrivateKeyArgs{...} }
type BindDeviceAccountPrivateKeyArrayInput interface {
	pulumi.Input

	ToBindDeviceAccountPrivateKeyArrayOutput() BindDeviceAccountPrivateKeyArrayOutput
	ToBindDeviceAccountPrivateKeyArrayOutputWithContext(context.Context) BindDeviceAccountPrivateKeyArrayOutput
}

type BindDeviceAccountPrivateKeyArray []BindDeviceAccountPrivateKeyInput

func (BindDeviceAccountPrivateKeyArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (i BindDeviceAccountPrivateKeyArray) ToBindDeviceAccountPrivateKeyArrayOutput() BindDeviceAccountPrivateKeyArrayOutput {
	return i.ToBindDeviceAccountPrivateKeyArrayOutputWithContext(context.Background())
}

func (i BindDeviceAccountPrivateKeyArray) ToBindDeviceAccountPrivateKeyArrayOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceAccountPrivateKeyArrayOutput)
}

// BindDeviceAccountPrivateKeyMapInput is an input type that accepts BindDeviceAccountPrivateKeyMap and BindDeviceAccountPrivateKeyMapOutput values.
// You can construct a concrete instance of `BindDeviceAccountPrivateKeyMapInput` via:
//
//	BindDeviceAccountPrivateKeyMap{ "key": BindDeviceAccountPrivateKeyArgs{...} }
type BindDeviceAccountPrivateKeyMapInput interface {
	pulumi.Input

	ToBindDeviceAccountPrivateKeyMapOutput() BindDeviceAccountPrivateKeyMapOutput
	ToBindDeviceAccountPrivateKeyMapOutputWithContext(context.Context) BindDeviceAccountPrivateKeyMapOutput
}

type BindDeviceAccountPrivateKeyMap map[string]BindDeviceAccountPrivateKeyInput

func (BindDeviceAccountPrivateKeyMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (i BindDeviceAccountPrivateKeyMap) ToBindDeviceAccountPrivateKeyMapOutput() BindDeviceAccountPrivateKeyMapOutput {
	return i.ToBindDeviceAccountPrivateKeyMapOutputWithContext(context.Background())
}

func (i BindDeviceAccountPrivateKeyMap) ToBindDeviceAccountPrivateKeyMapOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceAccountPrivateKeyMapOutput)
}

type BindDeviceAccountPrivateKeyOutput struct{ *pulumi.OutputState }

func (BindDeviceAccountPrivateKeyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (o BindDeviceAccountPrivateKeyOutput) ToBindDeviceAccountPrivateKeyOutput() BindDeviceAccountPrivateKeyOutput {
	return o
}

func (o BindDeviceAccountPrivateKeyOutput) ToBindDeviceAccountPrivateKeyOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyOutput {
	return o
}

// Host account ID.
func (o BindDeviceAccountPrivateKeyOutput) DeviceAccountId() pulumi.IntOutput {
	return o.ApplyT(func(v *BindDeviceAccountPrivateKey) pulumi.IntOutput { return v.DeviceAccountId }).(pulumi.IntOutput)
}

// Host account private key, the latest length is 128 bytes, the maximum length is 8192 bytes.
func (o BindDeviceAccountPrivateKeyOutput) PrivateKey() pulumi.StringOutput {
	return o.ApplyT(func(v *BindDeviceAccountPrivateKey) pulumi.StringOutput { return v.PrivateKey }).(pulumi.StringOutput)
}

// Host account private key password, maximum length 256 bytes.
func (o BindDeviceAccountPrivateKeyOutput) PrivateKeyPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *BindDeviceAccountPrivateKey) pulumi.StringPtrOutput { return v.PrivateKeyPassword }).(pulumi.StringPtrOutput)
}

type BindDeviceAccountPrivateKeyArrayOutput struct{ *pulumi.OutputState }

func (BindDeviceAccountPrivateKeyArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (o BindDeviceAccountPrivateKeyArrayOutput) ToBindDeviceAccountPrivateKeyArrayOutput() BindDeviceAccountPrivateKeyArrayOutput {
	return o
}

func (o BindDeviceAccountPrivateKeyArrayOutput) ToBindDeviceAccountPrivateKeyArrayOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyArrayOutput {
	return o
}

func (o BindDeviceAccountPrivateKeyArrayOutput) Index(i pulumi.IntInput) BindDeviceAccountPrivateKeyOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BindDeviceAccountPrivateKey {
		return vs[0].([]*BindDeviceAccountPrivateKey)[vs[1].(int)]
	}).(BindDeviceAccountPrivateKeyOutput)
}

type BindDeviceAccountPrivateKeyMapOutput struct{ *pulumi.OutputState }

func (BindDeviceAccountPrivateKeyMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BindDeviceAccountPrivateKey)(nil)).Elem()
}

func (o BindDeviceAccountPrivateKeyMapOutput) ToBindDeviceAccountPrivateKeyMapOutput() BindDeviceAccountPrivateKeyMapOutput {
	return o
}

func (o BindDeviceAccountPrivateKeyMapOutput) ToBindDeviceAccountPrivateKeyMapOutputWithContext(ctx context.Context) BindDeviceAccountPrivateKeyMapOutput {
	return o
}

func (o BindDeviceAccountPrivateKeyMapOutput) MapIndex(k pulumi.StringInput) BindDeviceAccountPrivateKeyOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BindDeviceAccountPrivateKey {
		return vs[0].(map[string]*BindDeviceAccountPrivateKey)[vs[1].(string)]
	}).(BindDeviceAccountPrivateKeyOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceAccountPrivateKeyInput)(nil)).Elem(), &BindDeviceAccountPrivateKey{})
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceAccountPrivateKeyArrayInput)(nil)).Elem(), BindDeviceAccountPrivateKeyArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceAccountPrivateKeyMapInput)(nil)).Elem(), BindDeviceAccountPrivateKeyMap{})
	pulumi.RegisterOutputType(BindDeviceAccountPrivateKeyOutput{})
	pulumi.RegisterOutputType(BindDeviceAccountPrivateKeyArrayOutput{})
	pulumi.RegisterOutputType(BindDeviceAccountPrivateKeyMapOutput{})
}
