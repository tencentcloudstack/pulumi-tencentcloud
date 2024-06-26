// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package oceanus

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a oceanus resourceConfig
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Oceanus"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			exampleResource, err := Oceanus.NewResource(ctx, "exampleResource", &Oceanus.ResourceArgs{
//				ResourceLoc: &oceanus.ResourceResourceLocArgs{
//					StorageType: pulumi.Int(1),
//					Param: &oceanus.ResourceResourceLocParamArgs{
//						Bucket: pulumi.String("keep-terraform-1257058945"),
//						Path:   pulumi.String("OceanusResource/junit-4.13.1.jar"),
//						Region: pulumi.String("ap-guangzhou"),
//					},
//				},
//				ResourceType:         pulumi.Int(1),
//				Remark:               pulumi.String("remark."),
//				ResourceConfigRemark: pulumi.String("config remark."),
//				FolderId:             pulumi.String("folder-7ctl246z"),
//				WorkSpaceId:          pulumi.String("space-2idq8wbr"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Oceanus.NewResourceConfig(ctx, "exampleResourceConfig", &Oceanus.ResourceConfigArgs{
//				ResourceId: exampleResource.ResourceId,
//				ResourceLoc: &oceanus.ResourceConfigResourceLocArgs{
//					StorageType: pulumi.Int(1),
//					Param: &oceanus.ResourceConfigResourceLocParamArgs{
//						Bucket: pulumi.String("keep-terraform-1257058945"),
//						Path:   pulumi.String("OceanusResource/junit-4.13.2.jar"),
//						Region: pulumi.String("ap-guangzhou"),
//					},
//				},
//				Remark:      pulumi.String("config remark."),
//				WorkSpaceId: pulumi.String("space-2idq8wbr"),
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
type ResourceConfig struct {
	pulumi.CustomResourceState

	// Resource description.
	Remark pulumi.StringPtrOutput `pulumi:"remark"`
	// Resource ID.
	ResourceId pulumi.StringOutput `pulumi:"resourceId"`
	// Resource location.
	ResourceLoc ResourceConfigResourceLocOutput `pulumi:"resourceLoc"`
	// Resource Config Version.
	Version pulumi.IntOutput `pulumi:"version"`
	// Workspace SerialId.
	WorkSpaceId pulumi.StringPtrOutput `pulumi:"workSpaceId"`
}

// NewResourceConfig registers a new resource with the given unique name, arguments, and options.
func NewResourceConfig(ctx *pulumi.Context,
	name string, args *ResourceConfigArgs, opts ...pulumi.ResourceOption) (*ResourceConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceId == nil {
		return nil, errors.New("invalid value for required argument 'ResourceId'")
	}
	if args.ResourceLoc == nil {
		return nil, errors.New("invalid value for required argument 'ResourceLoc'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ResourceConfig
	err := ctx.RegisterResource("tencentcloud:Oceanus/resourceConfig:ResourceConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetResourceConfig gets an existing ResourceConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetResourceConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ResourceConfigState, opts ...pulumi.ResourceOption) (*ResourceConfig, error) {
	var resource ResourceConfig
	err := ctx.ReadResource("tencentcloud:Oceanus/resourceConfig:ResourceConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ResourceConfig resources.
type resourceConfigState struct {
	// Resource description.
	Remark *string `pulumi:"remark"`
	// Resource ID.
	ResourceId *string `pulumi:"resourceId"`
	// Resource location.
	ResourceLoc *ResourceConfigResourceLoc `pulumi:"resourceLoc"`
	// Resource Config Version.
	Version *int `pulumi:"version"`
	// Workspace SerialId.
	WorkSpaceId *string `pulumi:"workSpaceId"`
}

type ResourceConfigState struct {
	// Resource description.
	Remark pulumi.StringPtrInput
	// Resource ID.
	ResourceId pulumi.StringPtrInput
	// Resource location.
	ResourceLoc ResourceConfigResourceLocPtrInput
	// Resource Config Version.
	Version pulumi.IntPtrInput
	// Workspace SerialId.
	WorkSpaceId pulumi.StringPtrInput
}

func (ResourceConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceConfigState)(nil)).Elem()
}

type resourceConfigArgs struct {
	// Resource description.
	Remark *string `pulumi:"remark"`
	// Resource ID.
	ResourceId string `pulumi:"resourceId"`
	// Resource location.
	ResourceLoc ResourceConfigResourceLoc `pulumi:"resourceLoc"`
	// Workspace SerialId.
	WorkSpaceId *string `pulumi:"workSpaceId"`
}

// The set of arguments for constructing a ResourceConfig resource.
type ResourceConfigArgs struct {
	// Resource description.
	Remark pulumi.StringPtrInput
	// Resource ID.
	ResourceId pulumi.StringInput
	// Resource location.
	ResourceLoc ResourceConfigResourceLocInput
	// Workspace SerialId.
	WorkSpaceId pulumi.StringPtrInput
}

func (ResourceConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*resourceConfigArgs)(nil)).Elem()
}

type ResourceConfigInput interface {
	pulumi.Input

	ToResourceConfigOutput() ResourceConfigOutput
	ToResourceConfigOutputWithContext(ctx context.Context) ResourceConfigOutput
}

func (*ResourceConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceConfig)(nil)).Elem()
}

func (i *ResourceConfig) ToResourceConfigOutput() ResourceConfigOutput {
	return i.ToResourceConfigOutputWithContext(context.Background())
}

func (i *ResourceConfig) ToResourceConfigOutputWithContext(ctx context.Context) ResourceConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceConfigOutput)
}

// ResourceConfigArrayInput is an input type that accepts ResourceConfigArray and ResourceConfigArrayOutput values.
// You can construct a concrete instance of `ResourceConfigArrayInput` via:
//
//	ResourceConfigArray{ ResourceConfigArgs{...} }
type ResourceConfigArrayInput interface {
	pulumi.Input

	ToResourceConfigArrayOutput() ResourceConfigArrayOutput
	ToResourceConfigArrayOutputWithContext(context.Context) ResourceConfigArrayOutput
}

type ResourceConfigArray []ResourceConfigInput

func (ResourceConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourceConfig)(nil)).Elem()
}

func (i ResourceConfigArray) ToResourceConfigArrayOutput() ResourceConfigArrayOutput {
	return i.ToResourceConfigArrayOutputWithContext(context.Background())
}

func (i ResourceConfigArray) ToResourceConfigArrayOutputWithContext(ctx context.Context) ResourceConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceConfigArrayOutput)
}

// ResourceConfigMapInput is an input type that accepts ResourceConfigMap and ResourceConfigMapOutput values.
// You can construct a concrete instance of `ResourceConfigMapInput` via:
//
//	ResourceConfigMap{ "key": ResourceConfigArgs{...} }
type ResourceConfigMapInput interface {
	pulumi.Input

	ToResourceConfigMapOutput() ResourceConfigMapOutput
	ToResourceConfigMapOutputWithContext(context.Context) ResourceConfigMapOutput
}

type ResourceConfigMap map[string]ResourceConfigInput

func (ResourceConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourceConfig)(nil)).Elem()
}

func (i ResourceConfigMap) ToResourceConfigMapOutput() ResourceConfigMapOutput {
	return i.ToResourceConfigMapOutputWithContext(context.Background())
}

func (i ResourceConfigMap) ToResourceConfigMapOutputWithContext(ctx context.Context) ResourceConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ResourceConfigMapOutput)
}

type ResourceConfigOutput struct{ *pulumi.OutputState }

func (ResourceConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ResourceConfig)(nil)).Elem()
}

func (o ResourceConfigOutput) ToResourceConfigOutput() ResourceConfigOutput {
	return o
}

func (o ResourceConfigOutput) ToResourceConfigOutputWithContext(ctx context.Context) ResourceConfigOutput {
	return o
}

// Resource description.
func (o ResourceConfigOutput) Remark() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ResourceConfig) pulumi.StringPtrOutput { return v.Remark }).(pulumi.StringPtrOutput)
}

// Resource ID.
func (o ResourceConfigOutput) ResourceId() pulumi.StringOutput {
	return o.ApplyT(func(v *ResourceConfig) pulumi.StringOutput { return v.ResourceId }).(pulumi.StringOutput)
}

// Resource location.
func (o ResourceConfigOutput) ResourceLoc() ResourceConfigResourceLocOutput {
	return o.ApplyT(func(v *ResourceConfig) ResourceConfigResourceLocOutput { return v.ResourceLoc }).(ResourceConfigResourceLocOutput)
}

// Resource Config Version.
func (o ResourceConfigOutput) Version() pulumi.IntOutput {
	return o.ApplyT(func(v *ResourceConfig) pulumi.IntOutput { return v.Version }).(pulumi.IntOutput)
}

// Workspace SerialId.
func (o ResourceConfigOutput) WorkSpaceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *ResourceConfig) pulumi.StringPtrOutput { return v.WorkSpaceId }).(pulumi.StringPtrOutput)
}

type ResourceConfigArrayOutput struct{ *pulumi.OutputState }

func (ResourceConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ResourceConfig)(nil)).Elem()
}

func (o ResourceConfigArrayOutput) ToResourceConfigArrayOutput() ResourceConfigArrayOutput {
	return o
}

func (o ResourceConfigArrayOutput) ToResourceConfigArrayOutputWithContext(ctx context.Context) ResourceConfigArrayOutput {
	return o
}

func (o ResourceConfigArrayOutput) Index(i pulumi.IntInput) ResourceConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ResourceConfig {
		return vs[0].([]*ResourceConfig)[vs[1].(int)]
	}).(ResourceConfigOutput)
}

type ResourceConfigMapOutput struct{ *pulumi.OutputState }

func (ResourceConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ResourceConfig)(nil)).Elem()
}

func (o ResourceConfigMapOutput) ToResourceConfigMapOutput() ResourceConfigMapOutput {
	return o
}

func (o ResourceConfigMapOutput) ToResourceConfigMapOutputWithContext(ctx context.Context) ResourceConfigMapOutput {
	return o
}

func (o ResourceConfigMapOutput) MapIndex(k pulumi.StringInput) ResourceConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ResourceConfig {
		return vs[0].(map[string]*ResourceConfig)[vs[1].(string)]
	}).(ResourceConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceConfigInput)(nil)).Elem(), &ResourceConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceConfigArrayInput)(nil)).Elem(), ResourceConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ResourceConfigMapInput)(nil)).Elem(), ResourceConfigMap{})
	pulumi.RegisterOutputType(ResourceConfigOutput{})
	pulumi.RegisterOutputType(ResourceConfigArrayOutput{})
	pulumi.RegisterOutputType(ResourceConfigMapOutput{})
}
