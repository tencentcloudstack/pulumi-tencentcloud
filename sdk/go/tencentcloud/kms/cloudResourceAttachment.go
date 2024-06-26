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

// Provides a resource to create a kms cloudResourceAttachment
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
//			_, err := Kms.NewCloudResourceAttachment(ctx, "example", &Kms.CloudResourceAttachmentArgs{
//				KeyId:      pulumi.String("72688f39-1fe8-11ee-9f1a-525400cf25a4"),
//				ProductId:  pulumi.String("mysql"),
//				ResourceId: pulumi.String("cdb-fitq5t9h"),
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
// kms cloud_resource_attachment can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Kms/cloudResourceAttachment:CloudResourceAttachment example 72688f39-1fe8-11ee-9f1a-525400cf25a4#mysql#cdb-fitq5t9h
// ```
type CloudResourceAttachment struct {
	pulumi.CustomResourceState

	// Alias.
	Alias pulumi.StringOutput `pulumi:"alias"`
	// Description.
	Description pulumi.StringOutput `pulumi:"description"`
	// CMK unique identifier.
	KeyId pulumi.StringOutput `pulumi:"keyId"`
	// Key state.
	KeyState pulumi.StringOutput `pulumi:"keyState"`
	// Key usage.
	KeyUsage pulumi.StringOutput `pulumi:"keyUsage"`
	// owner.
	Owner pulumi.StringOutput `pulumi:"owner"`
	// A unique identifier for the cloud product.
	ProductId pulumi.StringOutput `pulumi:"productId"`
	// The resource/instance ID of the cloud product.
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
}

// NewCloudResourceAttachment registers a new resource with the given unique name, arguments, and options.
func NewCloudResourceAttachment(ctx *pulumi.Context,
	name string, args *CloudResourceAttachmentArgs, opts ...pulumi.ResourceOption) (*CloudResourceAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.KeyId == nil {
		return nil, errors.New("invalid value for required argument 'KeyId'")
	}
	if args.ProductId == nil {
		return nil, errors.New("invalid value for required argument 'ProductId'")
	}
	if args.ResourceId == nil {
		return nil, errors.New("invalid value for required argument 'ResourceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CloudResourceAttachment
	err := ctx.RegisterResource("tencentcloud:Kms/cloudResourceAttachment:CloudResourceAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCloudResourceAttachment gets an existing CloudResourceAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCloudResourceAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CloudResourceAttachmentState, opts ...pulumi.ResourceOption) (*CloudResourceAttachment, error) {
	var resource CloudResourceAttachment
	err := ctx.ReadResource("tencentcloud:Kms/cloudResourceAttachment:CloudResourceAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CloudResourceAttachment resources.
type cloudResourceAttachmentState struct {
	// Alias.
	Alias *string `pulumi:"alias"`
	// Description.
	Description *string `pulumi:"description"`
	// CMK unique identifier.
	KeyId *string `pulumi:"keyId"`
	// Key state.
	KeyState *string `pulumi:"keyState"`
	// Key usage.
	KeyUsage *string `pulumi:"keyUsage"`
	// owner.
	Owner *string `pulumi:"owner"`
	// A unique identifier for the cloud product.
	ProductId *string `pulumi:"productId"`
	// The resource/instance ID of the cloud product.
	ResourceId *string `pulumi:"resourceId"`
}

type CloudResourceAttachmentState struct {
	// Alias.
	Alias pulumi.StringPtrInput
	// Description.
	Description pulumi.StringPtrInput
	// CMK unique identifier.
	KeyId pulumi.StringPtrInput
	// Key state.
	KeyState pulumi.StringPtrInput
	// Key usage.
	KeyUsage pulumi.StringPtrInput
	// owner.
	Owner pulumi.StringPtrInput
	// A unique identifier for the cloud product.
	ProductId pulumi.StringPtrInput
	// The resource/instance ID of the cloud product.
	ResourceId pulumi.StringPtrInput
}

func (CloudResourceAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudResourceAttachmentState)(nil)).Elem()
}

type cloudResourceAttachmentArgs struct {
	// CMK unique identifier.
	KeyId string `pulumi:"keyId"`
	// A unique identifier for the cloud product.
	ProductId string `pulumi:"productId"`
	// The resource/instance ID of the cloud product.
	ResourceId string `pulumi:"resourceId"`
}

// The set of arguments for constructing a CloudResourceAttachment resource.
type CloudResourceAttachmentArgs struct {
	// CMK unique identifier.
	KeyId pulumi.StringInput
	// A unique identifier for the cloud product.
	ProductId pulumi.StringInput
	// The resource/instance ID of the cloud product.
	ResourceId pulumi.StringInput
}

func (CloudResourceAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*cloudResourceAttachmentArgs)(nil)).Elem()
}

type CloudResourceAttachmentInput interface {
	pulumi.Input

	ToCloudResourceAttachmentOutput() CloudResourceAttachmentOutput
	ToCloudResourceAttachmentOutputWithContext(ctx context.Context) CloudResourceAttachmentOutput
}

func (*CloudResourceAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**CloudResourceAttachment)(nil)).Elem()
}

func (i *CloudResourceAttachment) ToCloudResourceAttachmentOutput() CloudResourceAttachmentOutput {
	return i.ToCloudResourceAttachmentOutputWithContext(context.Background())
}

func (i *CloudResourceAttachment) ToCloudResourceAttachmentOutputWithContext(ctx context.Context) CloudResourceAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudResourceAttachmentOutput)
}

// CloudResourceAttachmentArrayInput is an input type that accepts CloudResourceAttachmentArray and CloudResourceAttachmentArrayOutput values.
// You can construct a concrete instance of `CloudResourceAttachmentArrayInput` via:
//
//	CloudResourceAttachmentArray{ CloudResourceAttachmentArgs{...} }
type CloudResourceAttachmentArrayInput interface {
	pulumi.Input

	ToCloudResourceAttachmentArrayOutput() CloudResourceAttachmentArrayOutput
	ToCloudResourceAttachmentArrayOutputWithContext(context.Context) CloudResourceAttachmentArrayOutput
}

type CloudResourceAttachmentArray []CloudResourceAttachmentInput

func (CloudResourceAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CloudResourceAttachment)(nil)).Elem()
}

func (i CloudResourceAttachmentArray) ToCloudResourceAttachmentArrayOutput() CloudResourceAttachmentArrayOutput {
	return i.ToCloudResourceAttachmentArrayOutputWithContext(context.Background())
}

func (i CloudResourceAttachmentArray) ToCloudResourceAttachmentArrayOutputWithContext(ctx context.Context) CloudResourceAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudResourceAttachmentArrayOutput)
}

// CloudResourceAttachmentMapInput is an input type that accepts CloudResourceAttachmentMap and CloudResourceAttachmentMapOutput values.
// You can construct a concrete instance of `CloudResourceAttachmentMapInput` via:
//
//	CloudResourceAttachmentMap{ "key": CloudResourceAttachmentArgs{...} }
type CloudResourceAttachmentMapInput interface {
	pulumi.Input

	ToCloudResourceAttachmentMapOutput() CloudResourceAttachmentMapOutput
	ToCloudResourceAttachmentMapOutputWithContext(context.Context) CloudResourceAttachmentMapOutput
}

type CloudResourceAttachmentMap map[string]CloudResourceAttachmentInput

func (CloudResourceAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CloudResourceAttachment)(nil)).Elem()
}

func (i CloudResourceAttachmentMap) ToCloudResourceAttachmentMapOutput() CloudResourceAttachmentMapOutput {
	return i.ToCloudResourceAttachmentMapOutputWithContext(context.Background())
}

func (i CloudResourceAttachmentMap) ToCloudResourceAttachmentMapOutputWithContext(ctx context.Context) CloudResourceAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CloudResourceAttachmentMapOutput)
}

type CloudResourceAttachmentOutput struct{ *pulumi.OutputState }

func (CloudResourceAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CloudResourceAttachment)(nil)).Elem()
}

func (o CloudResourceAttachmentOutput) ToCloudResourceAttachmentOutput() CloudResourceAttachmentOutput {
	return o
}

func (o CloudResourceAttachmentOutput) ToCloudResourceAttachmentOutputWithContext(ctx context.Context) CloudResourceAttachmentOutput {
	return o
}

// Alias.
func (o CloudResourceAttachmentOutput) Alias() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.Alias }).(pulumi.StringOutput)
}

// Description.
func (o CloudResourceAttachmentOutput) Description() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.Description }).(pulumi.StringOutput)
}

// CMK unique identifier.
func (o CloudResourceAttachmentOutput) KeyId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.KeyId }).(pulumi.StringOutput)
}

// Key state.
func (o CloudResourceAttachmentOutput) KeyState() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.KeyState }).(pulumi.StringOutput)
}

// Key usage.
func (o CloudResourceAttachmentOutput) KeyUsage() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.KeyUsage }).(pulumi.StringOutput)
}

// owner.
func (o CloudResourceAttachmentOutput) Owner() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.Owner }).(pulumi.StringOutput)
}

// A unique identifier for the cloud product.
func (o CloudResourceAttachmentOutput) ProductId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.ProductId }).(pulumi.StringOutput)
}

// The resource/instance ID of the cloud product.
func (o CloudResourceAttachmentOutput) ResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v *CloudResourceAttachment) pulumi.StringOutput { return v.ResourceId }).(pulumi.StringOutput)
}

type CloudResourceAttachmentArrayOutput struct{ *pulumi.OutputState }

func (CloudResourceAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CloudResourceAttachment)(nil)).Elem()
}

func (o CloudResourceAttachmentArrayOutput) ToCloudResourceAttachmentArrayOutput() CloudResourceAttachmentArrayOutput {
	return o
}

func (o CloudResourceAttachmentArrayOutput) ToCloudResourceAttachmentArrayOutputWithContext(ctx context.Context) CloudResourceAttachmentArrayOutput {
	return o
}

func (o CloudResourceAttachmentArrayOutput) Index(i pulumi.IntInput) CloudResourceAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CloudResourceAttachment {
		return vs[0].([]*CloudResourceAttachment)[vs[1].(int)]
	}).(CloudResourceAttachmentOutput)
}

type CloudResourceAttachmentMapOutput struct{ *pulumi.OutputState }

func (CloudResourceAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CloudResourceAttachment)(nil)).Elem()
}

func (o CloudResourceAttachmentMapOutput) ToCloudResourceAttachmentMapOutput() CloudResourceAttachmentMapOutput {
	return o
}

func (o CloudResourceAttachmentMapOutput) ToCloudResourceAttachmentMapOutputWithContext(ctx context.Context) CloudResourceAttachmentMapOutput {
	return o
}

func (o CloudResourceAttachmentMapOutput) MapIndex(k pulumi.StringInput) CloudResourceAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CloudResourceAttachment {
		return vs[0].(map[string]*CloudResourceAttachment)[vs[1].(string)]
	}).(CloudResourceAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CloudResourceAttachmentInput)(nil)).Elem(), &CloudResourceAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*CloudResourceAttachmentArrayInput)(nil)).Elem(), CloudResourceAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CloudResourceAttachmentMapInput)(nil)).Elem(), CloudResourceAttachmentMap{})
	pulumi.RegisterOutputType(CloudResourceAttachmentOutput{})
	pulumi.RegisterOutputType(CloudResourceAttachmentArrayOutput{})
	pulumi.RegisterOutputType(CloudResourceAttachmentMapOutput{})
}
