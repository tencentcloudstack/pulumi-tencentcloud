// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package rum

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a rum projectStatusConfig
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Rum"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Rum.NewProjectStatusConfig(ctx, "projectStatusConfig", &Rum.ProjectStatusConfigArgs{
//				Operate:   pulumi.String("stop"),
//				ProjectId: pulumi.Int(131407),
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
// rum project_status_config can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Rum/projectStatusConfig:ProjectStatusConfig project_status_config project_id
// ```
type ProjectStatusConfig struct {
	pulumi.CustomResourceState

	// `resume`, `stop`.
	Operate pulumi.StringOutput `pulumi:"operate"`
	// Project ID.
	ProjectId pulumi.IntOutput `pulumi:"projectId"`
}

// NewProjectStatusConfig registers a new resource with the given unique name, arguments, and options.
func NewProjectStatusConfig(ctx *pulumi.Context,
	name string, args *ProjectStatusConfigArgs, opts ...pulumi.ResourceOption) (*ProjectStatusConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Operate == nil {
		return nil, errors.New("invalid value for required argument 'Operate'")
	}
	if args.ProjectId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ProjectStatusConfig
	err := ctx.RegisterResource("tencentcloud:Rum/projectStatusConfig:ProjectStatusConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProjectStatusConfig gets an existing ProjectStatusConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProjectStatusConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProjectStatusConfigState, opts ...pulumi.ResourceOption) (*ProjectStatusConfig, error) {
	var resource ProjectStatusConfig
	err := ctx.ReadResource("tencentcloud:Rum/projectStatusConfig:ProjectStatusConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ProjectStatusConfig resources.
type projectStatusConfigState struct {
	// `resume`, `stop`.
	Operate *string `pulumi:"operate"`
	// Project ID.
	ProjectId *int `pulumi:"projectId"`
}

type ProjectStatusConfigState struct {
	// `resume`, `stop`.
	Operate pulumi.StringPtrInput
	// Project ID.
	ProjectId pulumi.IntPtrInput
}

func (ProjectStatusConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*projectStatusConfigState)(nil)).Elem()
}

type projectStatusConfigArgs struct {
	// `resume`, `stop`.
	Operate string `pulumi:"operate"`
	// Project ID.
	ProjectId int `pulumi:"projectId"`
}

// The set of arguments for constructing a ProjectStatusConfig resource.
type ProjectStatusConfigArgs struct {
	// `resume`, `stop`.
	Operate pulumi.StringInput
	// Project ID.
	ProjectId pulumi.IntInput
}

func (ProjectStatusConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*projectStatusConfigArgs)(nil)).Elem()
}

type ProjectStatusConfigInput interface {
	pulumi.Input

	ToProjectStatusConfigOutput() ProjectStatusConfigOutput
	ToProjectStatusConfigOutputWithContext(ctx context.Context) ProjectStatusConfigOutput
}

func (*ProjectStatusConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**ProjectStatusConfig)(nil)).Elem()
}

func (i *ProjectStatusConfig) ToProjectStatusConfigOutput() ProjectStatusConfigOutput {
	return i.ToProjectStatusConfigOutputWithContext(context.Background())
}

func (i *ProjectStatusConfig) ToProjectStatusConfigOutputWithContext(ctx context.Context) ProjectStatusConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectStatusConfigOutput)
}

// ProjectStatusConfigArrayInput is an input type that accepts ProjectStatusConfigArray and ProjectStatusConfigArrayOutput values.
// You can construct a concrete instance of `ProjectStatusConfigArrayInput` via:
//
//	ProjectStatusConfigArray{ ProjectStatusConfigArgs{...} }
type ProjectStatusConfigArrayInput interface {
	pulumi.Input

	ToProjectStatusConfigArrayOutput() ProjectStatusConfigArrayOutput
	ToProjectStatusConfigArrayOutputWithContext(context.Context) ProjectStatusConfigArrayOutput
}

type ProjectStatusConfigArray []ProjectStatusConfigInput

func (ProjectStatusConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProjectStatusConfig)(nil)).Elem()
}

func (i ProjectStatusConfigArray) ToProjectStatusConfigArrayOutput() ProjectStatusConfigArrayOutput {
	return i.ToProjectStatusConfigArrayOutputWithContext(context.Background())
}

func (i ProjectStatusConfigArray) ToProjectStatusConfigArrayOutputWithContext(ctx context.Context) ProjectStatusConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectStatusConfigArrayOutput)
}

// ProjectStatusConfigMapInput is an input type that accepts ProjectStatusConfigMap and ProjectStatusConfigMapOutput values.
// You can construct a concrete instance of `ProjectStatusConfigMapInput` via:
//
//	ProjectStatusConfigMap{ "key": ProjectStatusConfigArgs{...} }
type ProjectStatusConfigMapInput interface {
	pulumi.Input

	ToProjectStatusConfigMapOutput() ProjectStatusConfigMapOutput
	ToProjectStatusConfigMapOutputWithContext(context.Context) ProjectStatusConfigMapOutput
}

type ProjectStatusConfigMap map[string]ProjectStatusConfigInput

func (ProjectStatusConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProjectStatusConfig)(nil)).Elem()
}

func (i ProjectStatusConfigMap) ToProjectStatusConfigMapOutput() ProjectStatusConfigMapOutput {
	return i.ToProjectStatusConfigMapOutputWithContext(context.Background())
}

func (i ProjectStatusConfigMap) ToProjectStatusConfigMapOutputWithContext(ctx context.Context) ProjectStatusConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ProjectStatusConfigMapOutput)
}

type ProjectStatusConfigOutput struct{ *pulumi.OutputState }

func (ProjectStatusConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ProjectStatusConfig)(nil)).Elem()
}

func (o ProjectStatusConfigOutput) ToProjectStatusConfigOutput() ProjectStatusConfigOutput {
	return o
}

func (o ProjectStatusConfigOutput) ToProjectStatusConfigOutputWithContext(ctx context.Context) ProjectStatusConfigOutput {
	return o
}

// `resume`, `stop`.
func (o ProjectStatusConfigOutput) Operate() pulumi.StringOutput {
	return o.ApplyT(func(v *ProjectStatusConfig) pulumi.StringOutput { return v.Operate }).(pulumi.StringOutput)
}

// Project ID.
func (o ProjectStatusConfigOutput) ProjectId() pulumi.IntOutput {
	return o.ApplyT(func(v *ProjectStatusConfig) pulumi.IntOutput { return v.ProjectId }).(pulumi.IntOutput)
}

type ProjectStatusConfigArrayOutput struct{ *pulumi.OutputState }

func (ProjectStatusConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ProjectStatusConfig)(nil)).Elem()
}

func (o ProjectStatusConfigArrayOutput) ToProjectStatusConfigArrayOutput() ProjectStatusConfigArrayOutput {
	return o
}

func (o ProjectStatusConfigArrayOutput) ToProjectStatusConfigArrayOutputWithContext(ctx context.Context) ProjectStatusConfigArrayOutput {
	return o
}

func (o ProjectStatusConfigArrayOutput) Index(i pulumi.IntInput) ProjectStatusConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ProjectStatusConfig {
		return vs[0].([]*ProjectStatusConfig)[vs[1].(int)]
	}).(ProjectStatusConfigOutput)
}

type ProjectStatusConfigMapOutput struct{ *pulumi.OutputState }

func (ProjectStatusConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ProjectStatusConfig)(nil)).Elem()
}

func (o ProjectStatusConfigMapOutput) ToProjectStatusConfigMapOutput() ProjectStatusConfigMapOutput {
	return o
}

func (o ProjectStatusConfigMapOutput) ToProjectStatusConfigMapOutputWithContext(ctx context.Context) ProjectStatusConfigMapOutput {
	return o
}

func (o ProjectStatusConfigMapOutput) MapIndex(k pulumi.StringInput) ProjectStatusConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ProjectStatusConfig {
		return vs[0].(map[string]*ProjectStatusConfig)[vs[1].(string)]
	}).(ProjectStatusConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectStatusConfigInput)(nil)).Elem(), &ProjectStatusConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectStatusConfigArrayInput)(nil)).Elem(), ProjectStatusConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ProjectStatusConfigMapInput)(nil)).Elem(), ProjectStatusConfigMap{})
	pulumi.RegisterOutputType(ProjectStatusConfigOutput{})
	pulumi.RegisterOutputType(ProjectStatusConfigArrayOutput{})
	pulumi.RegisterOutputType(ProjectStatusConfigMapOutput{})
}
