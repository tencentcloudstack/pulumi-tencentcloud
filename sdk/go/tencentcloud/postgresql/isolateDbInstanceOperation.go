// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package postgresql

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a postgresql isolateDbInstanceOperation
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Postgresql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Postgresql.NewIsolateDbInstanceOperation(ctx, "isolateDbInstanceOperation", &Postgresql.IsolateDbInstanceOperationArgs{
//				DbInstanceIdSets: pulumi.StringArray{
//					local.Pgsql_id,
//				},
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
type IsolateDbInstanceOperation struct {
	pulumi.CustomResourceState

	// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
	DbInstanceIdSets pulumi.StringArrayOutput `pulumi:"dbInstanceIdSets"`
}

// NewIsolateDbInstanceOperation registers a new resource with the given unique name, arguments, and options.
func NewIsolateDbInstanceOperation(ctx *pulumi.Context,
	name string, args *IsolateDbInstanceOperationArgs, opts ...pulumi.ResourceOption) (*IsolateDbInstanceOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DbInstanceIdSets == nil {
		return nil, errors.New("invalid value for required argument 'DbInstanceIdSets'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IsolateDbInstanceOperation
	err := ctx.RegisterResource("tencentcloud:Postgresql/isolateDbInstanceOperation:IsolateDbInstanceOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIsolateDbInstanceOperation gets an existing IsolateDbInstanceOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIsolateDbInstanceOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IsolateDbInstanceOperationState, opts ...pulumi.ResourceOption) (*IsolateDbInstanceOperation, error) {
	var resource IsolateDbInstanceOperation
	err := ctx.ReadResource("tencentcloud:Postgresql/isolateDbInstanceOperation:IsolateDbInstanceOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IsolateDbInstanceOperation resources.
type isolateDbInstanceOperationState struct {
	// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
	DbInstanceIdSets []string `pulumi:"dbInstanceIdSets"`
}

type IsolateDbInstanceOperationState struct {
	// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
	DbInstanceIdSets pulumi.StringArrayInput
}

func (IsolateDbInstanceOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*isolateDbInstanceOperationState)(nil)).Elem()
}

type isolateDbInstanceOperationArgs struct {
	// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
	DbInstanceIdSets []string `pulumi:"dbInstanceIdSets"`
}

// The set of arguments for constructing a IsolateDbInstanceOperation resource.
type IsolateDbInstanceOperationArgs struct {
	// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
	DbInstanceIdSets pulumi.StringArrayInput
}

func (IsolateDbInstanceOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*isolateDbInstanceOperationArgs)(nil)).Elem()
}

type IsolateDbInstanceOperationInput interface {
	pulumi.Input

	ToIsolateDbInstanceOperationOutput() IsolateDbInstanceOperationOutput
	ToIsolateDbInstanceOperationOutputWithContext(ctx context.Context) IsolateDbInstanceOperationOutput
}

func (*IsolateDbInstanceOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**IsolateDbInstanceOperation)(nil)).Elem()
}

func (i *IsolateDbInstanceOperation) ToIsolateDbInstanceOperationOutput() IsolateDbInstanceOperationOutput {
	return i.ToIsolateDbInstanceOperationOutputWithContext(context.Background())
}

func (i *IsolateDbInstanceOperation) ToIsolateDbInstanceOperationOutputWithContext(ctx context.Context) IsolateDbInstanceOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IsolateDbInstanceOperationOutput)
}

// IsolateDbInstanceOperationArrayInput is an input type that accepts IsolateDbInstanceOperationArray and IsolateDbInstanceOperationArrayOutput values.
// You can construct a concrete instance of `IsolateDbInstanceOperationArrayInput` via:
//
//	IsolateDbInstanceOperationArray{ IsolateDbInstanceOperationArgs{...} }
type IsolateDbInstanceOperationArrayInput interface {
	pulumi.Input

	ToIsolateDbInstanceOperationArrayOutput() IsolateDbInstanceOperationArrayOutput
	ToIsolateDbInstanceOperationArrayOutputWithContext(context.Context) IsolateDbInstanceOperationArrayOutput
}

type IsolateDbInstanceOperationArray []IsolateDbInstanceOperationInput

func (IsolateDbInstanceOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IsolateDbInstanceOperation)(nil)).Elem()
}

func (i IsolateDbInstanceOperationArray) ToIsolateDbInstanceOperationArrayOutput() IsolateDbInstanceOperationArrayOutput {
	return i.ToIsolateDbInstanceOperationArrayOutputWithContext(context.Background())
}

func (i IsolateDbInstanceOperationArray) ToIsolateDbInstanceOperationArrayOutputWithContext(ctx context.Context) IsolateDbInstanceOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IsolateDbInstanceOperationArrayOutput)
}

// IsolateDbInstanceOperationMapInput is an input type that accepts IsolateDbInstanceOperationMap and IsolateDbInstanceOperationMapOutput values.
// You can construct a concrete instance of `IsolateDbInstanceOperationMapInput` via:
//
//	IsolateDbInstanceOperationMap{ "key": IsolateDbInstanceOperationArgs{...} }
type IsolateDbInstanceOperationMapInput interface {
	pulumi.Input

	ToIsolateDbInstanceOperationMapOutput() IsolateDbInstanceOperationMapOutput
	ToIsolateDbInstanceOperationMapOutputWithContext(context.Context) IsolateDbInstanceOperationMapOutput
}

type IsolateDbInstanceOperationMap map[string]IsolateDbInstanceOperationInput

func (IsolateDbInstanceOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IsolateDbInstanceOperation)(nil)).Elem()
}

func (i IsolateDbInstanceOperationMap) ToIsolateDbInstanceOperationMapOutput() IsolateDbInstanceOperationMapOutput {
	return i.ToIsolateDbInstanceOperationMapOutputWithContext(context.Background())
}

func (i IsolateDbInstanceOperationMap) ToIsolateDbInstanceOperationMapOutputWithContext(ctx context.Context) IsolateDbInstanceOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IsolateDbInstanceOperationMapOutput)
}

type IsolateDbInstanceOperationOutput struct{ *pulumi.OutputState }

func (IsolateDbInstanceOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IsolateDbInstanceOperation)(nil)).Elem()
}

func (o IsolateDbInstanceOperationOutput) ToIsolateDbInstanceOperationOutput() IsolateDbInstanceOperationOutput {
	return o
}

func (o IsolateDbInstanceOperationOutput) ToIsolateDbInstanceOperationOutputWithContext(ctx context.Context) IsolateDbInstanceOperationOutput {
	return o
}

// List of resource IDs. Note that currently you cannot isolate multiple instances at the same time. Only one instance ID can be passed in here.
func (o IsolateDbInstanceOperationOutput) DbInstanceIdSets() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *IsolateDbInstanceOperation) pulumi.StringArrayOutput { return v.DbInstanceIdSets }).(pulumi.StringArrayOutput)
}

type IsolateDbInstanceOperationArrayOutput struct{ *pulumi.OutputState }

func (IsolateDbInstanceOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IsolateDbInstanceOperation)(nil)).Elem()
}

func (o IsolateDbInstanceOperationArrayOutput) ToIsolateDbInstanceOperationArrayOutput() IsolateDbInstanceOperationArrayOutput {
	return o
}

func (o IsolateDbInstanceOperationArrayOutput) ToIsolateDbInstanceOperationArrayOutputWithContext(ctx context.Context) IsolateDbInstanceOperationArrayOutput {
	return o
}

func (o IsolateDbInstanceOperationArrayOutput) Index(i pulumi.IntInput) IsolateDbInstanceOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IsolateDbInstanceOperation {
		return vs[0].([]*IsolateDbInstanceOperation)[vs[1].(int)]
	}).(IsolateDbInstanceOperationOutput)
}

type IsolateDbInstanceOperationMapOutput struct{ *pulumi.OutputState }

func (IsolateDbInstanceOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IsolateDbInstanceOperation)(nil)).Elem()
}

func (o IsolateDbInstanceOperationMapOutput) ToIsolateDbInstanceOperationMapOutput() IsolateDbInstanceOperationMapOutput {
	return o
}

func (o IsolateDbInstanceOperationMapOutput) ToIsolateDbInstanceOperationMapOutputWithContext(ctx context.Context) IsolateDbInstanceOperationMapOutput {
	return o
}

func (o IsolateDbInstanceOperationMapOutput) MapIndex(k pulumi.StringInput) IsolateDbInstanceOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IsolateDbInstanceOperation {
		return vs[0].(map[string]*IsolateDbInstanceOperation)[vs[1].(string)]
	}).(IsolateDbInstanceOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IsolateDbInstanceOperationInput)(nil)).Elem(), &IsolateDbInstanceOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*IsolateDbInstanceOperationArrayInput)(nil)).Elem(), IsolateDbInstanceOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IsolateDbInstanceOperationMapInput)(nil)).Elem(), IsolateDbInstanceOperationMap{})
	pulumi.RegisterOutputType(IsolateDbInstanceOperationOutput{})
	pulumi.RegisterOutputType(IsolateDbInstanceOperationArrayOutput{})
	pulumi.RegisterOutputType(IsolateDbInstanceOperationMapOutput{})
}
