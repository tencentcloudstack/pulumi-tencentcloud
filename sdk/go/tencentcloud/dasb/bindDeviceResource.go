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

// Provides a resource to create a dasb bindDeviceResource
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
//			_, err := Dasb.NewBindDeviceResource(ctx, "example", &Dasb.BindDeviceResourceArgs{
//				DeviceIdSets: pulumi.IntArray{
//					pulumi.Int(17),
//					pulumi.Int(18),
//				},
//				ResourceId: pulumi.String("bh-saas-weyosfym"),
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
type BindDeviceResource struct {
	pulumi.CustomResourceState

	// Asset ID collection.
	DeviceIdSets pulumi.IntArrayOutput `pulumi:"deviceIdSets"`
	// Bastion host service ID.
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
}

// NewBindDeviceResource registers a new resource with the given unique name, arguments, and options.
func NewBindDeviceResource(ctx *pulumi.Context,
	name string, args *BindDeviceResourceArgs, opts ...pulumi.ResourceOption) (*BindDeviceResource, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DeviceIdSets == nil {
		return nil, errors.New("invalid value for required argument 'DeviceIdSets'")
	}
	if args.ResourceId == nil {
		return nil, errors.New("invalid value for required argument 'ResourceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource BindDeviceResource
	err := ctx.RegisterResource("tencentcloud:Dasb/bindDeviceResource:BindDeviceResource", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBindDeviceResource gets an existing BindDeviceResource resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBindDeviceResource(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BindDeviceResourceState, opts ...pulumi.ResourceOption) (*BindDeviceResource, error) {
	var resource BindDeviceResource
	err := ctx.ReadResource("tencentcloud:Dasb/bindDeviceResource:BindDeviceResource", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering BindDeviceResource resources.
type bindDeviceResourceState struct {
	// Asset ID collection.
	DeviceIdSets []int `pulumi:"deviceIdSets"`
	// Bastion host service ID.
	ResourceId *string `pulumi:"resourceId"`
}

type BindDeviceResourceState struct {
	// Asset ID collection.
	DeviceIdSets pulumi.IntArrayInput
	// Bastion host service ID.
	ResourceId pulumi.StringPtrInput
}

func (BindDeviceResourceState) ElementType() reflect.Type {
	return reflect.TypeOf((*bindDeviceResourceState)(nil)).Elem()
}

type bindDeviceResourceArgs struct {
	// Asset ID collection.
	DeviceIdSets []int `pulumi:"deviceIdSets"`
	// Bastion host service ID.
	ResourceId string `pulumi:"resourceId"`
}

// The set of arguments for constructing a BindDeviceResource resource.
type BindDeviceResourceArgs struct {
	// Asset ID collection.
	DeviceIdSets pulumi.IntArrayInput
	// Bastion host service ID.
	ResourceId pulumi.StringInput
}

func (BindDeviceResourceArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*bindDeviceResourceArgs)(nil)).Elem()
}

type BindDeviceResourceInput interface {
	pulumi.Input

	ToBindDeviceResourceOutput() BindDeviceResourceOutput
	ToBindDeviceResourceOutputWithContext(ctx context.Context) BindDeviceResourceOutput
}

func (*BindDeviceResource) ElementType() reflect.Type {
	return reflect.TypeOf((**BindDeviceResource)(nil)).Elem()
}

func (i *BindDeviceResource) ToBindDeviceResourceOutput() BindDeviceResourceOutput {
	return i.ToBindDeviceResourceOutputWithContext(context.Background())
}

func (i *BindDeviceResource) ToBindDeviceResourceOutputWithContext(ctx context.Context) BindDeviceResourceOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceResourceOutput)
}

// BindDeviceResourceArrayInput is an input type that accepts BindDeviceResourceArray and BindDeviceResourceArrayOutput values.
// You can construct a concrete instance of `BindDeviceResourceArrayInput` via:
//
//	BindDeviceResourceArray{ BindDeviceResourceArgs{...} }
type BindDeviceResourceArrayInput interface {
	pulumi.Input

	ToBindDeviceResourceArrayOutput() BindDeviceResourceArrayOutput
	ToBindDeviceResourceArrayOutputWithContext(context.Context) BindDeviceResourceArrayOutput
}

type BindDeviceResourceArray []BindDeviceResourceInput

func (BindDeviceResourceArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BindDeviceResource)(nil)).Elem()
}

func (i BindDeviceResourceArray) ToBindDeviceResourceArrayOutput() BindDeviceResourceArrayOutput {
	return i.ToBindDeviceResourceArrayOutputWithContext(context.Background())
}

func (i BindDeviceResourceArray) ToBindDeviceResourceArrayOutputWithContext(ctx context.Context) BindDeviceResourceArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceResourceArrayOutput)
}

// BindDeviceResourceMapInput is an input type that accepts BindDeviceResourceMap and BindDeviceResourceMapOutput values.
// You can construct a concrete instance of `BindDeviceResourceMapInput` via:
//
//	BindDeviceResourceMap{ "key": BindDeviceResourceArgs{...} }
type BindDeviceResourceMapInput interface {
	pulumi.Input

	ToBindDeviceResourceMapOutput() BindDeviceResourceMapOutput
	ToBindDeviceResourceMapOutputWithContext(context.Context) BindDeviceResourceMapOutput
}

type BindDeviceResourceMap map[string]BindDeviceResourceInput

func (BindDeviceResourceMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BindDeviceResource)(nil)).Elem()
}

func (i BindDeviceResourceMap) ToBindDeviceResourceMapOutput() BindDeviceResourceMapOutput {
	return i.ToBindDeviceResourceMapOutputWithContext(context.Background())
}

func (i BindDeviceResourceMap) ToBindDeviceResourceMapOutputWithContext(ctx context.Context) BindDeviceResourceMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BindDeviceResourceMapOutput)
}

type BindDeviceResourceOutput struct{ *pulumi.OutputState }

func (BindDeviceResourceOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**BindDeviceResource)(nil)).Elem()
}

func (o BindDeviceResourceOutput) ToBindDeviceResourceOutput() BindDeviceResourceOutput {
	return o
}

func (o BindDeviceResourceOutput) ToBindDeviceResourceOutputWithContext(ctx context.Context) BindDeviceResourceOutput {
	return o
}

// Asset ID collection.
func (o BindDeviceResourceOutput) DeviceIdSets() pulumi.IntArrayOutput {
	return o.ApplyT(func(v *BindDeviceResource) pulumi.IntArrayOutput { return v.DeviceIdSets }).(pulumi.IntArrayOutput)
}

// Bastion host service ID.
func (o BindDeviceResourceOutput) ResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v *BindDeviceResource) pulumi.StringOutput { return v.ResourceId }).(pulumi.StringOutput)
}

type BindDeviceResourceArrayOutput struct{ *pulumi.OutputState }

func (BindDeviceResourceArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*BindDeviceResource)(nil)).Elem()
}

func (o BindDeviceResourceArrayOutput) ToBindDeviceResourceArrayOutput() BindDeviceResourceArrayOutput {
	return o
}

func (o BindDeviceResourceArrayOutput) ToBindDeviceResourceArrayOutputWithContext(ctx context.Context) BindDeviceResourceArrayOutput {
	return o
}

func (o BindDeviceResourceArrayOutput) Index(i pulumi.IntInput) BindDeviceResourceOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *BindDeviceResource {
		return vs[0].([]*BindDeviceResource)[vs[1].(int)]
	}).(BindDeviceResourceOutput)
}

type BindDeviceResourceMapOutput struct{ *pulumi.OutputState }

func (BindDeviceResourceMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*BindDeviceResource)(nil)).Elem()
}

func (o BindDeviceResourceMapOutput) ToBindDeviceResourceMapOutput() BindDeviceResourceMapOutput {
	return o
}

func (o BindDeviceResourceMapOutput) ToBindDeviceResourceMapOutputWithContext(ctx context.Context) BindDeviceResourceMapOutput {
	return o
}

func (o BindDeviceResourceMapOutput) MapIndex(k pulumi.StringInput) BindDeviceResourceOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *BindDeviceResource {
		return vs[0].(map[string]*BindDeviceResource)[vs[1].(string)]
	}).(BindDeviceResourceOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceResourceInput)(nil)).Elem(), &BindDeviceResource{})
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceResourceArrayInput)(nil)).Elem(), BindDeviceResourceArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*BindDeviceResourceMapInput)(nil)).Elem(), BindDeviceResourceMap{})
	pulumi.RegisterOutputType(BindDeviceResourceOutput{})
	pulumi.RegisterOutputType(BindDeviceResourceArrayOutput{})
	pulumi.RegisterOutputType(BindDeviceResourceMapOutput{})
}
