// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ckafka

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a ckafka route
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ckafka"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Ckafka.NewRoute(ctx, "route", &Ckafka.RouteArgs{
// 			AccessType:    pulumi.Int(0),
// 			InstanceId:    pulumi.String("ckafka-xxxxxx"),
// 			PublicNetwork: pulumi.Int(3),
// 			SubnetId:      pulumi.String("subnet-xxxxxx"),
// 			VipType:       pulumi.Int(3),
// 			VpcId:         pulumi.String("vpc-xxxxxx"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type Route struct {
	pulumi.CustomResourceState

	// Access type. Valid values:
	// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
	// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
	// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
	// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
	AccessType pulumi.IntOutput `pulumi:"accessType"`
	// Auth flag.
	AuthFlag pulumi.IntPtrOutput `pulumi:"authFlag"`
	// Virtual IP list (1 to 1 broker nodes).
	BrokerVipLists RouteBrokerVipListArrayOutput `pulumi:"brokerVipLists"`
	// Caller appid.
	CallerAppid pulumi.IntPtrOutput `pulumi:"callerAppid"`
	// Instance id.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// Ip.
	Ip pulumi.StringOutput `pulumi:"ip"`
	// Public network.
	PublicNetwork pulumi.IntPtrOutput `pulumi:"publicNetwork"`
	// Subnet id.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Virtual IP list.
	VipLists RouteVipListArrayOutput `pulumi:"vipLists"`
	// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
	VipType pulumi.IntOutput `pulumi:"vipType"`
	// Vpc id.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewRoute registers a new resource with the given unique name, arguments, and options.
func NewRoute(ctx *pulumi.Context,
	name string, args *RouteArgs, opts ...pulumi.ResourceOption) (*Route, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.VipType == nil {
		return nil, errors.New("invalid value for required argument 'VipType'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource Route
	err := ctx.RegisterResource("tencentcloud:Ckafka/route:Route", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRoute gets an existing Route resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRoute(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteState, opts ...pulumi.ResourceOption) (*Route, error) {
	var resource Route
	err := ctx.ReadResource("tencentcloud:Ckafka/route:Route", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Route resources.
type routeState struct {
	// Access type. Valid values:
	// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
	// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
	// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
	// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
	AccessType *int `pulumi:"accessType"`
	// Auth flag.
	AuthFlag *int `pulumi:"authFlag"`
	// Virtual IP list (1 to 1 broker nodes).
	BrokerVipLists []RouteBrokerVipList `pulumi:"brokerVipLists"`
	// Caller appid.
	CallerAppid *int `pulumi:"callerAppid"`
	// Instance id.
	InstanceId *string `pulumi:"instanceId"`
	// Ip.
	Ip *string `pulumi:"ip"`
	// Public network.
	PublicNetwork *int `pulumi:"publicNetwork"`
	// Subnet id.
	SubnetId *string `pulumi:"subnetId"`
	// Virtual IP list.
	VipLists []RouteVipList `pulumi:"vipLists"`
	// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
	VipType *int `pulumi:"vipType"`
	// Vpc id.
	VpcId *string `pulumi:"vpcId"`
}

type RouteState struct {
	// Access type. Valid values:
	// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
	// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
	// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
	// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
	AccessType pulumi.IntPtrInput
	// Auth flag.
	AuthFlag pulumi.IntPtrInput
	// Virtual IP list (1 to 1 broker nodes).
	BrokerVipLists RouteBrokerVipListArrayInput
	// Caller appid.
	CallerAppid pulumi.IntPtrInput
	// Instance id.
	InstanceId pulumi.StringPtrInput
	// Ip.
	Ip pulumi.StringPtrInput
	// Public network.
	PublicNetwork pulumi.IntPtrInput
	// Subnet id.
	SubnetId pulumi.StringPtrInput
	// Virtual IP list.
	VipLists RouteVipListArrayInput
	// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
	VipType pulumi.IntPtrInput
	// Vpc id.
	VpcId pulumi.StringPtrInput
}

func (RouteState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeState)(nil)).Elem()
}

type routeArgs struct {
	// Access type. Valid values:
	// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
	// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
	// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
	// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
	AccessType *int `pulumi:"accessType"`
	// Auth flag.
	AuthFlag *int `pulumi:"authFlag"`
	// Caller appid.
	CallerAppid *int `pulumi:"callerAppid"`
	// Instance id.
	InstanceId string `pulumi:"instanceId"`
	// Ip.
	Ip *string `pulumi:"ip"`
	// Public network.
	PublicNetwork *int `pulumi:"publicNetwork"`
	// Subnet id.
	SubnetId *string `pulumi:"subnetId"`
	// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
	VipType int `pulumi:"vipType"`
	// Vpc id.
	VpcId *string `pulumi:"vpcId"`
}

// The set of arguments for constructing a Route resource.
type RouteArgs struct {
	// Access type. Valid values:
	// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
	// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
	// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
	// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
	AccessType pulumi.IntPtrInput
	// Auth flag.
	AuthFlag pulumi.IntPtrInput
	// Caller appid.
	CallerAppid pulumi.IntPtrInput
	// Instance id.
	InstanceId pulumi.StringInput
	// Ip.
	Ip pulumi.StringPtrInput
	// Public network.
	PublicNetwork pulumi.IntPtrInput
	// Subnet id.
	SubnetId pulumi.StringPtrInput
	// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
	VipType pulumi.IntInput
	// Vpc id.
	VpcId pulumi.StringPtrInput
}

func (RouteArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeArgs)(nil)).Elem()
}

type RouteInput interface {
	pulumi.Input

	ToRouteOutput() RouteOutput
	ToRouteOutputWithContext(ctx context.Context) RouteOutput
}

func (*Route) ElementType() reflect.Type {
	return reflect.TypeOf((**Route)(nil)).Elem()
}

func (i *Route) ToRouteOutput() RouteOutput {
	return i.ToRouteOutputWithContext(context.Background())
}

func (i *Route) ToRouteOutputWithContext(ctx context.Context) RouteOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteOutput)
}

// RouteArrayInput is an input type that accepts RouteArray and RouteArrayOutput values.
// You can construct a concrete instance of `RouteArrayInput` via:
//
//          RouteArray{ RouteArgs{...} }
type RouteArrayInput interface {
	pulumi.Input

	ToRouteArrayOutput() RouteArrayOutput
	ToRouteArrayOutputWithContext(context.Context) RouteArrayOutput
}

type RouteArray []RouteInput

func (RouteArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Route)(nil)).Elem()
}

func (i RouteArray) ToRouteArrayOutput() RouteArrayOutput {
	return i.ToRouteArrayOutputWithContext(context.Background())
}

func (i RouteArray) ToRouteArrayOutputWithContext(ctx context.Context) RouteArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteArrayOutput)
}

// RouteMapInput is an input type that accepts RouteMap and RouteMapOutput values.
// You can construct a concrete instance of `RouteMapInput` via:
//
//          RouteMap{ "key": RouteArgs{...} }
type RouteMapInput interface {
	pulumi.Input

	ToRouteMapOutput() RouteMapOutput
	ToRouteMapOutputWithContext(context.Context) RouteMapOutput
}

type RouteMap map[string]RouteInput

func (RouteMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Route)(nil)).Elem()
}

func (i RouteMap) ToRouteMapOutput() RouteMapOutput {
	return i.ToRouteMapOutputWithContext(context.Background())
}

func (i RouteMap) ToRouteMapOutputWithContext(ctx context.Context) RouteMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteMapOutput)
}

type RouteOutput struct{ *pulumi.OutputState }

func (RouteOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Route)(nil)).Elem()
}

func (o RouteOutput) ToRouteOutput() RouteOutput {
	return o
}

func (o RouteOutput) ToRouteOutputWithContext(ctx context.Context) RouteOutput {
	return o
}

// Access type. Valid values:
// - 0: PLAINTEXT (in clear text, supported by both the old version and the community version without user information)
// - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be logged in through SASL, which is only supported by the community version)
// - 2: SSL (SSL encrypted communication without user information, supported by both older and community versions)
// - 3: SASL_SSL (SSL encrypted communication. When the data starts, authentication will be logged in through SASL. Only the community version supports it).
func (o RouteOutput) AccessType() pulumi.IntOutput {
	return o.ApplyT(func(v *Route) pulumi.IntOutput { return v.AccessType }).(pulumi.IntOutput)
}

// Auth flag.
func (o RouteOutput) AuthFlag() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Route) pulumi.IntPtrOutput { return v.AuthFlag }).(pulumi.IntPtrOutput)
}

// Virtual IP list (1 to 1 broker nodes).
func (o RouteOutput) BrokerVipLists() RouteBrokerVipListArrayOutput {
	return o.ApplyT(func(v *Route) RouteBrokerVipListArrayOutput { return v.BrokerVipLists }).(RouteBrokerVipListArrayOutput)
}

// Caller appid.
func (o RouteOutput) CallerAppid() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Route) pulumi.IntPtrOutput { return v.CallerAppid }).(pulumi.IntPtrOutput)
}

// Instance id.
func (o RouteOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *Route) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// Ip.
func (o RouteOutput) Ip() pulumi.StringOutput {
	return o.ApplyT(func(v *Route) pulumi.StringOutput { return v.Ip }).(pulumi.StringOutput)
}

// Public network.
func (o RouteOutput) PublicNetwork() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *Route) pulumi.IntPtrOutput { return v.PublicNetwork }).(pulumi.IntPtrOutput)
}

// Subnet id.
func (o RouteOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *Route) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Virtual IP list.
func (o RouteOutput) VipLists() RouteVipListArrayOutput {
	return o.ApplyT(func(v *Route) RouteVipListArrayOutput { return v.VipLists }).(RouteVipListArrayOutput)
}

// Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
func (o RouteOutput) VipType() pulumi.IntOutput {
	return o.ApplyT(func(v *Route) pulumi.IntOutput { return v.VipType }).(pulumi.IntOutput)
}

// Vpc id.
func (o RouteOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *Route) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type RouteArrayOutput struct{ *pulumi.OutputState }

func (RouteArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Route)(nil)).Elem()
}

func (o RouteArrayOutput) ToRouteArrayOutput() RouteArrayOutput {
	return o
}

func (o RouteArrayOutput) ToRouteArrayOutputWithContext(ctx context.Context) RouteArrayOutput {
	return o
}

func (o RouteArrayOutput) Index(i pulumi.IntInput) RouteOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Route {
		return vs[0].([]*Route)[vs[1].(int)]
	}).(RouteOutput)
}

type RouteMapOutput struct{ *pulumi.OutputState }

func (RouteMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Route)(nil)).Elem()
}

func (o RouteMapOutput) ToRouteMapOutput() RouteMapOutput {
	return o
}

func (o RouteMapOutput) ToRouteMapOutputWithContext(ctx context.Context) RouteMapOutput {
	return o
}

func (o RouteMapOutput) MapIndex(k pulumi.StringInput) RouteOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Route {
		return vs[0].(map[string]*Route)[vs[1].(string)]
	}).(RouteOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RouteInput)(nil)).Elem(), &Route{})
	pulumi.RegisterInputType(reflect.TypeOf((*RouteArrayInput)(nil)).Elem(), RouteArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RouteMapInput)(nil)).Elem(), RouteMap{})
	pulumi.RegisterOutputType(RouteOutput{})
	pulumi.RegisterOutputType(RouteArrayOutput{})
	pulumi.RegisterOutputType(RouteMapOutput{})
}