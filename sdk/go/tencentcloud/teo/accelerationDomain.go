// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package teo

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a teo accelerationDomain
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Teo"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Teo"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Teo.NewAccelerationDomain(ctx, "accelerationDomain", &Teo.AccelerationDomainArgs{
// 			DomainName: pulumi.String("aaa.makn.cn"),
// 			OriginInfo: &teo.AccelerationDomainOriginInfoArgs{
// 				Origin:     pulumi.String("150.109.8.1"),
// 				OriginType: pulumi.String("IP_DOMAIN"),
// 			},
// 			ZoneId: pulumi.String("zone-2o0i41pv2h8c"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// teo acceleration_domain can be imported using the id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Teo/accelerationDomain:AccelerationDomain acceleration_domain acceleration_domain_id
// ```
type AccelerationDomain struct {
	pulumi.CustomResourceState

	// CNAME address.
	Cname pulumi.StringOutput `pulumi:"cname"`
	// Accelerated domain name.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// Details of the origin.
	OriginInfo AccelerationDomainOriginInfoOutput `pulumi:"originInfo"`
	// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
	Status pulumi.StringPtrOutput `pulumi:"status"`
	// ID of the site related with the accelerated domain name.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewAccelerationDomain registers a new resource with the given unique name, arguments, and options.
func NewAccelerationDomain(ctx *pulumi.Context,
	name string, args *AccelerationDomainArgs, opts ...pulumi.ResourceOption) (*AccelerationDomain, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DomainName == nil {
		return nil, errors.New("invalid value for required argument 'DomainName'")
	}
	if args.OriginInfo == nil {
		return nil, errors.New("invalid value for required argument 'OriginInfo'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource AccelerationDomain
	err := ctx.RegisterResource("tencentcloud:Teo/accelerationDomain:AccelerationDomain", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAccelerationDomain gets an existing AccelerationDomain resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAccelerationDomain(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AccelerationDomainState, opts ...pulumi.ResourceOption) (*AccelerationDomain, error) {
	var resource AccelerationDomain
	err := ctx.ReadResource("tencentcloud:Teo/accelerationDomain:AccelerationDomain", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering AccelerationDomain resources.
type accelerationDomainState struct {
	// CNAME address.
	Cname *string `pulumi:"cname"`
	// Accelerated domain name.
	DomainName *string `pulumi:"domainName"`
	// Details of the origin.
	OriginInfo *AccelerationDomainOriginInfo `pulumi:"originInfo"`
	// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
	Status *string `pulumi:"status"`
	// ID of the site related with the accelerated domain name.
	ZoneId *string `pulumi:"zoneId"`
}

type AccelerationDomainState struct {
	// CNAME address.
	Cname pulumi.StringPtrInput
	// Accelerated domain name.
	DomainName pulumi.StringPtrInput
	// Details of the origin.
	OriginInfo AccelerationDomainOriginInfoPtrInput
	// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
	Status pulumi.StringPtrInput
	// ID of the site related with the accelerated domain name.
	ZoneId pulumi.StringPtrInput
}

func (AccelerationDomainState) ElementType() reflect.Type {
	return reflect.TypeOf((*accelerationDomainState)(nil)).Elem()
}

type accelerationDomainArgs struct {
	// Accelerated domain name.
	DomainName string `pulumi:"domainName"`
	// Details of the origin.
	OriginInfo AccelerationDomainOriginInfo `pulumi:"originInfo"`
	// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
	Status *string `pulumi:"status"`
	// ID of the site related with the accelerated domain name.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a AccelerationDomain resource.
type AccelerationDomainArgs struct {
	// Accelerated domain name.
	DomainName pulumi.StringInput
	// Details of the origin.
	OriginInfo AccelerationDomainOriginInfoInput
	// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
	Status pulumi.StringPtrInput
	// ID of the site related with the accelerated domain name.
	ZoneId pulumi.StringInput
}

func (AccelerationDomainArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*accelerationDomainArgs)(nil)).Elem()
}

type AccelerationDomainInput interface {
	pulumi.Input

	ToAccelerationDomainOutput() AccelerationDomainOutput
	ToAccelerationDomainOutputWithContext(ctx context.Context) AccelerationDomainOutput
}

func (*AccelerationDomain) ElementType() reflect.Type {
	return reflect.TypeOf((**AccelerationDomain)(nil)).Elem()
}

func (i *AccelerationDomain) ToAccelerationDomainOutput() AccelerationDomainOutput {
	return i.ToAccelerationDomainOutputWithContext(context.Background())
}

func (i *AccelerationDomain) ToAccelerationDomainOutputWithContext(ctx context.Context) AccelerationDomainOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccelerationDomainOutput)
}

// AccelerationDomainArrayInput is an input type that accepts AccelerationDomainArray and AccelerationDomainArrayOutput values.
// You can construct a concrete instance of `AccelerationDomainArrayInput` via:
//
//          AccelerationDomainArray{ AccelerationDomainArgs{...} }
type AccelerationDomainArrayInput interface {
	pulumi.Input

	ToAccelerationDomainArrayOutput() AccelerationDomainArrayOutput
	ToAccelerationDomainArrayOutputWithContext(context.Context) AccelerationDomainArrayOutput
}

type AccelerationDomainArray []AccelerationDomainInput

func (AccelerationDomainArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccelerationDomain)(nil)).Elem()
}

func (i AccelerationDomainArray) ToAccelerationDomainArrayOutput() AccelerationDomainArrayOutput {
	return i.ToAccelerationDomainArrayOutputWithContext(context.Background())
}

func (i AccelerationDomainArray) ToAccelerationDomainArrayOutputWithContext(ctx context.Context) AccelerationDomainArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccelerationDomainArrayOutput)
}

// AccelerationDomainMapInput is an input type that accepts AccelerationDomainMap and AccelerationDomainMapOutput values.
// You can construct a concrete instance of `AccelerationDomainMapInput` via:
//
//          AccelerationDomainMap{ "key": AccelerationDomainArgs{...} }
type AccelerationDomainMapInput interface {
	pulumi.Input

	ToAccelerationDomainMapOutput() AccelerationDomainMapOutput
	ToAccelerationDomainMapOutputWithContext(context.Context) AccelerationDomainMapOutput
}

type AccelerationDomainMap map[string]AccelerationDomainInput

func (AccelerationDomainMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccelerationDomain)(nil)).Elem()
}

func (i AccelerationDomainMap) ToAccelerationDomainMapOutput() AccelerationDomainMapOutput {
	return i.ToAccelerationDomainMapOutputWithContext(context.Background())
}

func (i AccelerationDomainMap) ToAccelerationDomainMapOutputWithContext(ctx context.Context) AccelerationDomainMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AccelerationDomainMapOutput)
}

type AccelerationDomainOutput struct{ *pulumi.OutputState }

func (AccelerationDomainOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AccelerationDomain)(nil)).Elem()
}

func (o AccelerationDomainOutput) ToAccelerationDomainOutput() AccelerationDomainOutput {
	return o
}

func (o AccelerationDomainOutput) ToAccelerationDomainOutputWithContext(ctx context.Context) AccelerationDomainOutput {
	return o
}

// CNAME address.
func (o AccelerationDomainOutput) Cname() pulumi.StringOutput {
	return o.ApplyT(func(v *AccelerationDomain) pulumi.StringOutput { return v.Cname }).(pulumi.StringOutput)
}

// Accelerated domain name.
func (o AccelerationDomainOutput) DomainName() pulumi.StringOutput {
	return o.ApplyT(func(v *AccelerationDomain) pulumi.StringOutput { return v.DomainName }).(pulumi.StringOutput)
}

// Details of the origin.
func (o AccelerationDomainOutput) OriginInfo() AccelerationDomainOriginInfoOutput {
	return o.ApplyT(func(v *AccelerationDomain) AccelerationDomainOriginInfoOutput { return v.OriginInfo }).(AccelerationDomainOriginInfoOutput)
}

// Accelerated domain name status, the values are: `online`: enabled; `offline`: disabled.
func (o AccelerationDomainOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AccelerationDomain) pulumi.StringPtrOutput { return v.Status }).(pulumi.StringPtrOutput)
}

// ID of the site related with the accelerated domain name.
func (o AccelerationDomainOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *AccelerationDomain) pulumi.StringOutput { return v.ZoneId }).(pulumi.StringOutput)
}

type AccelerationDomainArrayOutput struct{ *pulumi.OutputState }

func (AccelerationDomainArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*AccelerationDomain)(nil)).Elem()
}

func (o AccelerationDomainArrayOutput) ToAccelerationDomainArrayOutput() AccelerationDomainArrayOutput {
	return o
}

func (o AccelerationDomainArrayOutput) ToAccelerationDomainArrayOutputWithContext(ctx context.Context) AccelerationDomainArrayOutput {
	return o
}

func (o AccelerationDomainArrayOutput) Index(i pulumi.IntInput) AccelerationDomainOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *AccelerationDomain {
		return vs[0].([]*AccelerationDomain)[vs[1].(int)]
	}).(AccelerationDomainOutput)
}

type AccelerationDomainMapOutput struct{ *pulumi.OutputState }

func (AccelerationDomainMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*AccelerationDomain)(nil)).Elem()
}

func (o AccelerationDomainMapOutput) ToAccelerationDomainMapOutput() AccelerationDomainMapOutput {
	return o
}

func (o AccelerationDomainMapOutput) ToAccelerationDomainMapOutputWithContext(ctx context.Context) AccelerationDomainMapOutput {
	return o
}

func (o AccelerationDomainMapOutput) MapIndex(k pulumi.StringInput) AccelerationDomainOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *AccelerationDomain {
		return vs[0].(map[string]*AccelerationDomain)[vs[1].(string)]
	}).(AccelerationDomainOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*AccelerationDomainInput)(nil)).Elem(), &AccelerationDomain{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccelerationDomainArrayInput)(nil)).Elem(), AccelerationDomainArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*AccelerationDomainMapInput)(nil)).Elem(), AccelerationDomainMap{})
	pulumi.RegisterOutputType(AccelerationDomainOutput{})
	pulumi.RegisterOutputType(AccelerationDomainArrayOutput{})
	pulumi.RegisterOutputType(AccelerationDomainMapOutput{})
}