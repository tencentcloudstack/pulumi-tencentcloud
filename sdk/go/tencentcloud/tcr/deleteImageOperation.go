// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tcr

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a tcr deleteImageOperation
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tcr"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Tcr.NewDeleteImageOperation(ctx, "deleteImageOperation", &Tcr.DeleteImageOperationArgs{
// 			ImageVersion:   pulumi.String("v1"),
// 			NamespaceName:  pulumi.String("ns"),
// 			RegistryId:     pulumi.String("tcr-xxx"),
// 			RepositoryName: pulumi.String("repo"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type DeleteImageOperation struct {
	pulumi.CustomResourceState

	// image version name.
	ImageVersion pulumi.StringOutput `pulumi:"imageVersion"`
	// namespace name.
	NamespaceName pulumi.StringOutput `pulumi:"namespaceName"`
	// instance id.
	RegistryId pulumi.StringOutput `pulumi:"registryId"`
	// repository name.
	RepositoryName pulumi.StringOutput `pulumi:"repositoryName"`
}

// NewDeleteImageOperation registers a new resource with the given unique name, arguments, and options.
func NewDeleteImageOperation(ctx *pulumi.Context,
	name string, args *DeleteImageOperationArgs, opts ...pulumi.ResourceOption) (*DeleteImageOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ImageVersion == nil {
		return nil, errors.New("invalid value for required argument 'ImageVersion'")
	}
	if args.NamespaceName == nil {
		return nil, errors.New("invalid value for required argument 'NamespaceName'")
	}
	if args.RegistryId == nil {
		return nil, errors.New("invalid value for required argument 'RegistryId'")
	}
	if args.RepositoryName == nil {
		return nil, errors.New("invalid value for required argument 'RepositoryName'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource DeleteImageOperation
	err := ctx.RegisterResource("tencentcloud:Tcr/deleteImageOperation:DeleteImageOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDeleteImageOperation gets an existing DeleteImageOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDeleteImageOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DeleteImageOperationState, opts ...pulumi.ResourceOption) (*DeleteImageOperation, error) {
	var resource DeleteImageOperation
	err := ctx.ReadResource("tencentcloud:Tcr/deleteImageOperation:DeleteImageOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DeleteImageOperation resources.
type deleteImageOperationState struct {
	// image version name.
	ImageVersion *string `pulumi:"imageVersion"`
	// namespace name.
	NamespaceName *string `pulumi:"namespaceName"`
	// instance id.
	RegistryId *string `pulumi:"registryId"`
	// repository name.
	RepositoryName *string `pulumi:"repositoryName"`
}

type DeleteImageOperationState struct {
	// image version name.
	ImageVersion pulumi.StringPtrInput
	// namespace name.
	NamespaceName pulumi.StringPtrInput
	// instance id.
	RegistryId pulumi.StringPtrInput
	// repository name.
	RepositoryName pulumi.StringPtrInput
}

func (DeleteImageOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*deleteImageOperationState)(nil)).Elem()
}

type deleteImageOperationArgs struct {
	// image version name.
	ImageVersion string `pulumi:"imageVersion"`
	// namespace name.
	NamespaceName string `pulumi:"namespaceName"`
	// instance id.
	RegistryId string `pulumi:"registryId"`
	// repository name.
	RepositoryName string `pulumi:"repositoryName"`
}

// The set of arguments for constructing a DeleteImageOperation resource.
type DeleteImageOperationArgs struct {
	// image version name.
	ImageVersion pulumi.StringInput
	// namespace name.
	NamespaceName pulumi.StringInput
	// instance id.
	RegistryId pulumi.StringInput
	// repository name.
	RepositoryName pulumi.StringInput
}

func (DeleteImageOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*deleteImageOperationArgs)(nil)).Elem()
}

type DeleteImageOperationInput interface {
	pulumi.Input

	ToDeleteImageOperationOutput() DeleteImageOperationOutput
	ToDeleteImageOperationOutputWithContext(ctx context.Context) DeleteImageOperationOutput
}

func (*DeleteImageOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**DeleteImageOperation)(nil)).Elem()
}

func (i *DeleteImageOperation) ToDeleteImageOperationOutput() DeleteImageOperationOutput {
	return i.ToDeleteImageOperationOutputWithContext(context.Background())
}

func (i *DeleteImageOperation) ToDeleteImageOperationOutputWithContext(ctx context.Context) DeleteImageOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeleteImageOperationOutput)
}

// DeleteImageOperationArrayInput is an input type that accepts DeleteImageOperationArray and DeleteImageOperationArrayOutput values.
// You can construct a concrete instance of `DeleteImageOperationArrayInput` via:
//
//          DeleteImageOperationArray{ DeleteImageOperationArgs{...} }
type DeleteImageOperationArrayInput interface {
	pulumi.Input

	ToDeleteImageOperationArrayOutput() DeleteImageOperationArrayOutput
	ToDeleteImageOperationArrayOutputWithContext(context.Context) DeleteImageOperationArrayOutput
}

type DeleteImageOperationArray []DeleteImageOperationInput

func (DeleteImageOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DeleteImageOperation)(nil)).Elem()
}

func (i DeleteImageOperationArray) ToDeleteImageOperationArrayOutput() DeleteImageOperationArrayOutput {
	return i.ToDeleteImageOperationArrayOutputWithContext(context.Background())
}

func (i DeleteImageOperationArray) ToDeleteImageOperationArrayOutputWithContext(ctx context.Context) DeleteImageOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeleteImageOperationArrayOutput)
}

// DeleteImageOperationMapInput is an input type that accepts DeleteImageOperationMap and DeleteImageOperationMapOutput values.
// You can construct a concrete instance of `DeleteImageOperationMapInput` via:
//
//          DeleteImageOperationMap{ "key": DeleteImageOperationArgs{...} }
type DeleteImageOperationMapInput interface {
	pulumi.Input

	ToDeleteImageOperationMapOutput() DeleteImageOperationMapOutput
	ToDeleteImageOperationMapOutputWithContext(context.Context) DeleteImageOperationMapOutput
}

type DeleteImageOperationMap map[string]DeleteImageOperationInput

func (DeleteImageOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DeleteImageOperation)(nil)).Elem()
}

func (i DeleteImageOperationMap) ToDeleteImageOperationMapOutput() DeleteImageOperationMapOutput {
	return i.ToDeleteImageOperationMapOutputWithContext(context.Background())
}

func (i DeleteImageOperationMap) ToDeleteImageOperationMapOutputWithContext(ctx context.Context) DeleteImageOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DeleteImageOperationMapOutput)
}

type DeleteImageOperationOutput struct{ *pulumi.OutputState }

func (DeleteImageOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DeleteImageOperation)(nil)).Elem()
}

func (o DeleteImageOperationOutput) ToDeleteImageOperationOutput() DeleteImageOperationOutput {
	return o
}

func (o DeleteImageOperationOutput) ToDeleteImageOperationOutputWithContext(ctx context.Context) DeleteImageOperationOutput {
	return o
}

// image version name.
func (o DeleteImageOperationOutput) ImageVersion() pulumi.StringOutput {
	return o.ApplyT(func(v *DeleteImageOperation) pulumi.StringOutput { return v.ImageVersion }).(pulumi.StringOutput)
}

// namespace name.
func (o DeleteImageOperationOutput) NamespaceName() pulumi.StringOutput {
	return o.ApplyT(func(v *DeleteImageOperation) pulumi.StringOutput { return v.NamespaceName }).(pulumi.StringOutput)
}

// instance id.
func (o DeleteImageOperationOutput) RegistryId() pulumi.StringOutput {
	return o.ApplyT(func(v *DeleteImageOperation) pulumi.StringOutput { return v.RegistryId }).(pulumi.StringOutput)
}

// repository name.
func (o DeleteImageOperationOutput) RepositoryName() pulumi.StringOutput {
	return o.ApplyT(func(v *DeleteImageOperation) pulumi.StringOutput { return v.RepositoryName }).(pulumi.StringOutput)
}

type DeleteImageOperationArrayOutput struct{ *pulumi.OutputState }

func (DeleteImageOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DeleteImageOperation)(nil)).Elem()
}

func (o DeleteImageOperationArrayOutput) ToDeleteImageOperationArrayOutput() DeleteImageOperationArrayOutput {
	return o
}

func (o DeleteImageOperationArrayOutput) ToDeleteImageOperationArrayOutputWithContext(ctx context.Context) DeleteImageOperationArrayOutput {
	return o
}

func (o DeleteImageOperationArrayOutput) Index(i pulumi.IntInput) DeleteImageOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DeleteImageOperation {
		return vs[0].([]*DeleteImageOperation)[vs[1].(int)]
	}).(DeleteImageOperationOutput)
}

type DeleteImageOperationMapOutput struct{ *pulumi.OutputState }

func (DeleteImageOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DeleteImageOperation)(nil)).Elem()
}

func (o DeleteImageOperationMapOutput) ToDeleteImageOperationMapOutput() DeleteImageOperationMapOutput {
	return o
}

func (o DeleteImageOperationMapOutput) ToDeleteImageOperationMapOutputWithContext(ctx context.Context) DeleteImageOperationMapOutput {
	return o
}

func (o DeleteImageOperationMapOutput) MapIndex(k pulumi.StringInput) DeleteImageOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DeleteImageOperation {
		return vs[0].(map[string]*DeleteImageOperation)[vs[1].(string)]
	}).(DeleteImageOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DeleteImageOperationInput)(nil)).Elem(), &DeleteImageOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeleteImageOperationArrayInput)(nil)).Elem(), DeleteImageOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DeleteImageOperationMapInput)(nil)).Elem(), DeleteImageOperationMap{})
	pulumi.RegisterOutputType(DeleteImageOperationOutput{})
	pulumi.RegisterOutputType(DeleteImageOperationArrayOutput{})
	pulumi.RegisterOutputType(DeleteImageOperationMapOutput{})
}