// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tse

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a tse wafProtection
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tse"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Tse.NewWafProtection(ctx, "wafProtection", &Tse.WafProtectionArgs{
// 			GatewayId: pulumi.String("gateway-ed63e957"),
// 			Lists: pulumi.StringArray{
// 				pulumi.String("7324a769-9d87-48ce-a904-48c3defc4abd"),
// 			},
// 			Operate: pulumi.String("open"),
// 			Type:    pulumi.String("Route"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type WafProtection struct {
	pulumi.CustomResourceState

	// Gateway ID.
	GatewayId pulumi.StringOutput `pulumi:"gatewayId"`
	// Global protection status.
	GlobalStatus pulumi.StringOutput `pulumi:"globalStatus"`
	// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
	Lists pulumi.StringArrayOutput `pulumi:"lists"`
	// `open`: open the protection, `close`: close the protection.
	Operate pulumi.StringOutput `pulumi:"operate"`
	// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewWafProtection registers a new resource with the given unique name, arguments, and options.
func NewWafProtection(ctx *pulumi.Context,
	name string, args *WafProtectionArgs, opts ...pulumi.ResourceOption) (*WafProtection, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GatewayId == nil {
		return nil, errors.New("invalid value for required argument 'GatewayId'")
	}
	if args.Operate == nil {
		return nil, errors.New("invalid value for required argument 'Operate'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource WafProtection
	err := ctx.RegisterResource("tencentcloud:Tse/wafProtection:WafProtection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetWafProtection gets an existing WafProtection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetWafProtection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *WafProtectionState, opts ...pulumi.ResourceOption) (*WafProtection, error) {
	var resource WafProtection
	err := ctx.ReadResource("tencentcloud:Tse/wafProtection:WafProtection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering WafProtection resources.
type wafProtectionState struct {
	// Gateway ID.
	GatewayId *string `pulumi:"gatewayId"`
	// Global protection status.
	GlobalStatus *string `pulumi:"globalStatus"`
	// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
	Lists []string `pulumi:"lists"`
	// `open`: open the protection, `close`: close the protection.
	Operate *string `pulumi:"operate"`
	// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
	Type *string `pulumi:"type"`
}

type WafProtectionState struct {
	// Gateway ID.
	GatewayId pulumi.StringPtrInput
	// Global protection status.
	GlobalStatus pulumi.StringPtrInput
	// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
	Lists pulumi.StringArrayInput
	// `open`: open the protection, `close`: close the protection.
	Operate pulumi.StringPtrInput
	// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
	Type pulumi.StringPtrInput
}

func (WafProtectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*wafProtectionState)(nil)).Elem()
}

type wafProtectionArgs struct {
	// Gateway ID.
	GatewayId string `pulumi:"gatewayId"`
	// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
	Lists []string `pulumi:"lists"`
	// `open`: open the protection, `close`: close the protection.
	Operate string `pulumi:"operate"`
	// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a WafProtection resource.
type WafProtectionArgs struct {
	// Gateway ID.
	GatewayId pulumi.StringInput
	// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
	Lists pulumi.StringArrayInput
	// `open`: open the protection, `close`: close the protection.
	Operate pulumi.StringInput
	// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
	Type pulumi.StringInput
}

func (WafProtectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*wafProtectionArgs)(nil)).Elem()
}

type WafProtectionInput interface {
	pulumi.Input

	ToWafProtectionOutput() WafProtectionOutput
	ToWafProtectionOutputWithContext(ctx context.Context) WafProtectionOutput
}

func (*WafProtection) ElementType() reflect.Type {
	return reflect.TypeOf((**WafProtection)(nil)).Elem()
}

func (i *WafProtection) ToWafProtectionOutput() WafProtectionOutput {
	return i.ToWafProtectionOutputWithContext(context.Background())
}

func (i *WafProtection) ToWafProtectionOutputWithContext(ctx context.Context) WafProtectionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WafProtectionOutput)
}

// WafProtectionArrayInput is an input type that accepts WafProtectionArray and WafProtectionArrayOutput values.
// You can construct a concrete instance of `WafProtectionArrayInput` via:
//
//          WafProtectionArray{ WafProtectionArgs{...} }
type WafProtectionArrayInput interface {
	pulumi.Input

	ToWafProtectionArrayOutput() WafProtectionArrayOutput
	ToWafProtectionArrayOutputWithContext(context.Context) WafProtectionArrayOutput
}

type WafProtectionArray []WafProtectionInput

func (WafProtectionArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WafProtection)(nil)).Elem()
}

func (i WafProtectionArray) ToWafProtectionArrayOutput() WafProtectionArrayOutput {
	return i.ToWafProtectionArrayOutputWithContext(context.Background())
}

func (i WafProtectionArray) ToWafProtectionArrayOutputWithContext(ctx context.Context) WafProtectionArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WafProtectionArrayOutput)
}

// WafProtectionMapInput is an input type that accepts WafProtectionMap and WafProtectionMapOutput values.
// You can construct a concrete instance of `WafProtectionMapInput` via:
//
//          WafProtectionMap{ "key": WafProtectionArgs{...} }
type WafProtectionMapInput interface {
	pulumi.Input

	ToWafProtectionMapOutput() WafProtectionMapOutput
	ToWafProtectionMapOutputWithContext(context.Context) WafProtectionMapOutput
}

type WafProtectionMap map[string]WafProtectionInput

func (WafProtectionMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WafProtection)(nil)).Elem()
}

func (i WafProtectionMap) ToWafProtectionMapOutput() WafProtectionMapOutput {
	return i.ToWafProtectionMapOutputWithContext(context.Background())
}

func (i WafProtectionMap) ToWafProtectionMapOutputWithContext(ctx context.Context) WafProtectionMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WafProtectionMapOutput)
}

type WafProtectionOutput struct{ *pulumi.OutputState }

func (WafProtectionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WafProtection)(nil)).Elem()
}

func (o WafProtectionOutput) ToWafProtectionOutput() WafProtectionOutput {
	return o
}

func (o WafProtectionOutput) ToWafProtectionOutputWithContext(ctx context.Context) WafProtectionOutput {
	return o
}

// Gateway ID.
func (o WafProtectionOutput) GatewayId() pulumi.StringOutput {
	return o.ApplyT(func(v *WafProtection) pulumi.StringOutput { return v.GatewayId }).(pulumi.StringOutput)
}

// Global protection status.
func (o WafProtectionOutput) GlobalStatus() pulumi.StringOutput {
	return o.ApplyT(func(v *WafProtection) pulumi.StringOutput { return v.GlobalStatus }).(pulumi.StringOutput)
}

// Means the list of services or routes when the resource type `Type` is `Service` or `Route`.
func (o WafProtectionOutput) Lists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *WafProtection) pulumi.StringArrayOutput { return v.Lists }).(pulumi.StringArrayOutput)
}

// `open`: open the protection, `close`: close the protection.
func (o WafProtectionOutput) Operate() pulumi.StringOutput {
	return o.ApplyT(func(v *WafProtection) pulumi.StringOutput { return v.Operate }).(pulumi.StringOutput)
}

// The type of protection resource. Reference value: `Global`: instance, `Service`: service, `Route`: route, `Object`: obejct (This interface does not currently support this type).
func (o WafProtectionOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *WafProtection) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

type WafProtectionArrayOutput struct{ *pulumi.OutputState }

func (WafProtectionArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*WafProtection)(nil)).Elem()
}

func (o WafProtectionArrayOutput) ToWafProtectionArrayOutput() WafProtectionArrayOutput {
	return o
}

func (o WafProtectionArrayOutput) ToWafProtectionArrayOutputWithContext(ctx context.Context) WafProtectionArrayOutput {
	return o
}

func (o WafProtectionArrayOutput) Index(i pulumi.IntInput) WafProtectionOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *WafProtection {
		return vs[0].([]*WafProtection)[vs[1].(int)]
	}).(WafProtectionOutput)
}

type WafProtectionMapOutput struct{ *pulumi.OutputState }

func (WafProtectionMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*WafProtection)(nil)).Elem()
}

func (o WafProtectionMapOutput) ToWafProtectionMapOutput() WafProtectionMapOutput {
	return o
}

func (o WafProtectionMapOutput) ToWafProtectionMapOutputWithContext(ctx context.Context) WafProtectionMapOutput {
	return o
}

func (o WafProtectionMapOutput) MapIndex(k pulumi.StringInput) WafProtectionOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *WafProtection {
		return vs[0].(map[string]*WafProtection)[vs[1].(string)]
	}).(WafProtectionOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*WafProtectionInput)(nil)).Elem(), &WafProtection{})
	pulumi.RegisterInputType(reflect.TypeOf((*WafProtectionArrayInput)(nil)).Elem(), WafProtectionArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*WafProtectionMapInput)(nil)).Elem(), WafProtectionMap{})
	pulumi.RegisterOutputType(WafProtectionOutput{})
	pulumi.RegisterOutputType(WafProtectionArrayOutput{})
	pulumi.RegisterOutputType(WafProtectionMapOutput{})
}