// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package reserve

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a vpc reserve ip addresses
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Reserve"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Reserve.NewIpAddress(ctx, "reserveIp", &Reserve.IpAddressArgs{
//				Description: pulumi.String("description"),
//				IpAddress:   pulumi.String("10.0.0.13"),
//				SubnetId:    pulumi.String("xxxxxx"),
//				Tags: pulumi.Map{
//					"test1": pulumi.Any("test1"),
//				},
//				VpcId: pulumi.String("xxxxxx"),
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
// vpc reserve_ip_addresses can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Reserve/ipAddress:IpAddress reserve_ip_addresses ${vpcId}#${reserveIpId}
// ```
type IpAddress struct {
	pulumi.CustomResourceState

	// Created time.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// The IP description is retained on the intranet.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Specify the reserved IP address of the intranet for which the IP application is requested.
	IpAddress pulumi.StringOutput `pulumi:"ipAddress"`
	// Ip type for product application.
	IpType pulumi.IntOutput `pulumi:"ipType"`
	// The IP name is reserved for the intranet.
	Name pulumi.StringOutput `pulumi:"name"`
	// Reserve ip ID.
	ReserveIpId pulumi.StringOutput `pulumi:"reserveIpId"`
	// The intranet retains the resource instance ID bound to the IPs.
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
	// Binding status.
	State pulumi.StringOutput `pulumi:"state"`
	// Subnet ID.
	SubnetId pulumi.StringPtrOutput `pulumi:"subnetId"`
	// Tags.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// VPC unique ID.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewIpAddress registers a new resource with the given unique name, arguments, and options.
func NewIpAddress(ctx *pulumi.Context,
	name string, args *IpAddressArgs, opts ...pulumi.ResourceOption) (*IpAddress, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IpAddress
	err := ctx.RegisterResource("tencentcloud:Reserve/ipAddress:IpAddress", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIpAddress gets an existing IpAddress resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIpAddress(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IpAddressState, opts ...pulumi.ResourceOption) (*IpAddress, error) {
	var resource IpAddress
	err := ctx.ReadResource("tencentcloud:Reserve/ipAddress:IpAddress", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IpAddress resources.
type ipAddressState struct {
	// Created time.
	CreatedTime *string `pulumi:"createdTime"`
	// The IP description is retained on the intranet.
	Description *string `pulumi:"description"`
	// Specify the reserved IP address of the intranet for which the IP application is requested.
	IpAddress *string `pulumi:"ipAddress"`
	// Ip type for product application.
	IpType *int `pulumi:"ipType"`
	// The IP name is reserved for the intranet.
	Name *string `pulumi:"name"`
	// Reserve ip ID.
	ReserveIpId *string `pulumi:"reserveIpId"`
	// The intranet retains the resource instance ID bound to the IPs.
	ResourceId *string `pulumi:"resourceId"`
	// Binding status.
	State *string `pulumi:"state"`
	// Subnet ID.
	SubnetId *string `pulumi:"subnetId"`
	// Tags.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC unique ID.
	VpcId *string `pulumi:"vpcId"`
}

type IpAddressState struct {
	// Created time.
	CreatedTime pulumi.StringPtrInput
	// The IP description is retained on the intranet.
	Description pulumi.StringPtrInput
	// Specify the reserved IP address of the intranet for which the IP application is requested.
	IpAddress pulumi.StringPtrInput
	// Ip type for product application.
	IpType pulumi.IntPtrInput
	// The IP name is reserved for the intranet.
	Name pulumi.StringPtrInput
	// Reserve ip ID.
	ReserveIpId pulumi.StringPtrInput
	// The intranet retains the resource instance ID bound to the IPs.
	ResourceId pulumi.StringPtrInput
	// Binding status.
	State pulumi.StringPtrInput
	// Subnet ID.
	SubnetId pulumi.StringPtrInput
	// Tags.
	Tags pulumi.MapInput
	// VPC unique ID.
	VpcId pulumi.StringPtrInput
}

func (IpAddressState) ElementType() reflect.Type {
	return reflect.TypeOf((*ipAddressState)(nil)).Elem()
}

type ipAddressArgs struct {
	// The IP description is retained on the intranet.
	Description *string `pulumi:"description"`
	// Specify the reserved IP address of the intranet for which the IP application is requested.
	IpAddress *string `pulumi:"ipAddress"`
	// The IP name is reserved for the intranet.
	Name *string `pulumi:"name"`
	// Subnet ID.
	SubnetId *string `pulumi:"subnetId"`
	// Tags.
	Tags map[string]interface{} `pulumi:"tags"`
	// VPC unique ID.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a IpAddress resource.
type IpAddressArgs struct {
	// The IP description is retained on the intranet.
	Description pulumi.StringPtrInput
	// Specify the reserved IP address of the intranet for which the IP application is requested.
	IpAddress pulumi.StringPtrInput
	// The IP name is reserved for the intranet.
	Name pulumi.StringPtrInput
	// Subnet ID.
	SubnetId pulumi.StringPtrInput
	// Tags.
	Tags pulumi.MapInput
	// VPC unique ID.
	VpcId pulumi.StringInput
}

func (IpAddressArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ipAddressArgs)(nil)).Elem()
}

type IpAddressInput interface {
	pulumi.Input

	ToIpAddressOutput() IpAddressOutput
	ToIpAddressOutputWithContext(ctx context.Context) IpAddressOutput
}

func (*IpAddress) ElementType() reflect.Type {
	return reflect.TypeOf((**IpAddress)(nil)).Elem()
}

func (i *IpAddress) ToIpAddressOutput() IpAddressOutput {
	return i.ToIpAddressOutputWithContext(context.Background())
}

func (i *IpAddress) ToIpAddressOutputWithContext(ctx context.Context) IpAddressOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpAddressOutput)
}

// IpAddressArrayInput is an input type that accepts IpAddressArray and IpAddressArrayOutput values.
// You can construct a concrete instance of `IpAddressArrayInput` via:
//
//	IpAddressArray{ IpAddressArgs{...} }
type IpAddressArrayInput interface {
	pulumi.Input

	ToIpAddressArrayOutput() IpAddressArrayOutput
	ToIpAddressArrayOutputWithContext(context.Context) IpAddressArrayOutput
}

type IpAddressArray []IpAddressInput

func (IpAddressArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpAddress)(nil)).Elem()
}

func (i IpAddressArray) ToIpAddressArrayOutput() IpAddressArrayOutput {
	return i.ToIpAddressArrayOutputWithContext(context.Background())
}

func (i IpAddressArray) ToIpAddressArrayOutputWithContext(ctx context.Context) IpAddressArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpAddressArrayOutput)
}

// IpAddressMapInput is an input type that accepts IpAddressMap and IpAddressMapOutput values.
// You can construct a concrete instance of `IpAddressMapInput` via:
//
//	IpAddressMap{ "key": IpAddressArgs{...} }
type IpAddressMapInput interface {
	pulumi.Input

	ToIpAddressMapOutput() IpAddressMapOutput
	ToIpAddressMapOutputWithContext(context.Context) IpAddressMapOutput
}

type IpAddressMap map[string]IpAddressInput

func (IpAddressMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpAddress)(nil)).Elem()
}

func (i IpAddressMap) ToIpAddressMapOutput() IpAddressMapOutput {
	return i.ToIpAddressMapOutputWithContext(context.Background())
}

func (i IpAddressMap) ToIpAddressMapOutputWithContext(ctx context.Context) IpAddressMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IpAddressMapOutput)
}

type IpAddressOutput struct{ *pulumi.OutputState }

func (IpAddressOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IpAddress)(nil)).Elem()
}

func (o IpAddressOutput) ToIpAddressOutput() IpAddressOutput {
	return o
}

func (o IpAddressOutput) ToIpAddressOutputWithContext(ctx context.Context) IpAddressOutput {
	return o
}

// Created time.
func (o IpAddressOutput) CreatedTime() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.CreatedTime }).(pulumi.StringOutput)
}

// The IP description is retained on the intranet.
func (o IpAddressOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// Specify the reserved IP address of the intranet for which the IP application is requested.
func (o IpAddressOutput) IpAddress() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.IpAddress }).(pulumi.StringOutput)
}

// Ip type for product application.
func (o IpAddressOutput) IpType() pulumi.IntOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.IntOutput { return v.IpType }).(pulumi.IntOutput)
}

// The IP name is reserved for the intranet.
func (o IpAddressOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Reserve ip ID.
func (o IpAddressOutput) ReserveIpId() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.ReserveIpId }).(pulumi.StringOutput)
}

// The intranet retains the resource instance ID bound to the IPs.
func (o IpAddressOutput) ResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.ResourceId }).(pulumi.StringOutput)
}

// Binding status.
func (o IpAddressOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Subnet ID.
func (o IpAddressOutput) SubnetId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringPtrOutput { return v.SubnetId }).(pulumi.StringPtrOutput)
}

// Tags.
func (o IpAddressOutput) Tags() pulumi.MapOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.MapOutput { return v.Tags }).(pulumi.MapOutput)
}

// VPC unique ID.
func (o IpAddressOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *IpAddress) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type IpAddressArrayOutput struct{ *pulumi.OutputState }

func (IpAddressArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IpAddress)(nil)).Elem()
}

func (o IpAddressArrayOutput) ToIpAddressArrayOutput() IpAddressArrayOutput {
	return o
}

func (o IpAddressArrayOutput) ToIpAddressArrayOutputWithContext(ctx context.Context) IpAddressArrayOutput {
	return o
}

func (o IpAddressArrayOutput) Index(i pulumi.IntInput) IpAddressOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IpAddress {
		return vs[0].([]*IpAddress)[vs[1].(int)]
	}).(IpAddressOutput)
}

type IpAddressMapOutput struct{ *pulumi.OutputState }

func (IpAddressMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IpAddress)(nil)).Elem()
}

func (o IpAddressMapOutput) ToIpAddressMapOutput() IpAddressMapOutput {
	return o
}

func (o IpAddressMapOutput) ToIpAddressMapOutputWithContext(ctx context.Context) IpAddressMapOutput {
	return o
}

func (o IpAddressMapOutput) MapIndex(k pulumi.StringInput) IpAddressOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IpAddress {
		return vs[0].(map[string]*IpAddress)[vs[1].(string)]
	}).(IpAddressOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IpAddressInput)(nil)).Elem(), &IpAddress{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpAddressArrayInput)(nil)).Elem(), IpAddressArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IpAddressMapInput)(nil)).Elem(), IpAddressMap{})
	pulumi.RegisterOutputType(IpAddressOutput{})
	pulumi.RegisterOutputType(IpAddressArrayOutput{})
	pulumi.RegisterOutputType(IpAddressMapOutput{})
}