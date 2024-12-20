// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tsf

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a tsf releaseApiGroup
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tsf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Tsf.NewReleaseApiGroup(ctx, "releaseApiGroup", &Tsf.ReleaseApiGroupArgs{
//				GroupId: pulumi.String("grp-qp0rj3zi"),
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
type ReleaseApiGroup struct {
	pulumi.CustomResourceState

	// api group Id.
	GroupId pulumi.StringOutput `pulumi:"groupId"`
}

// NewReleaseApiGroup registers a new resource with the given unique name, arguments, and options.
func NewReleaseApiGroup(ctx *pulumi.Context,
	name string, args *ReleaseApiGroupArgs, opts ...pulumi.ResourceOption) (*ReleaseApiGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GroupId == nil {
		return nil, errors.New("invalid value for required argument 'GroupId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ReleaseApiGroup
	err := ctx.RegisterResource("tencentcloud:Tsf/releaseApiGroup:ReleaseApiGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReleaseApiGroup gets an existing ReleaseApiGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReleaseApiGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReleaseApiGroupState, opts ...pulumi.ResourceOption) (*ReleaseApiGroup, error) {
	var resource ReleaseApiGroup
	err := ctx.ReadResource("tencentcloud:Tsf/releaseApiGroup:ReleaseApiGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReleaseApiGroup resources.
type releaseApiGroupState struct {
	// api group Id.
	GroupId *string `pulumi:"groupId"`
}

type ReleaseApiGroupState struct {
	// api group Id.
	GroupId pulumi.StringPtrInput
}

func (ReleaseApiGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*releaseApiGroupState)(nil)).Elem()
}

type releaseApiGroupArgs struct {
	// api group Id.
	GroupId string `pulumi:"groupId"`
}

// The set of arguments for constructing a ReleaseApiGroup resource.
type ReleaseApiGroupArgs struct {
	// api group Id.
	GroupId pulumi.StringInput
}

func (ReleaseApiGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*releaseApiGroupArgs)(nil)).Elem()
}

type ReleaseApiGroupInput interface {
	pulumi.Input

	ToReleaseApiGroupOutput() ReleaseApiGroupOutput
	ToReleaseApiGroupOutputWithContext(ctx context.Context) ReleaseApiGroupOutput
}

func (*ReleaseApiGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**ReleaseApiGroup)(nil)).Elem()
}

func (i *ReleaseApiGroup) ToReleaseApiGroupOutput() ReleaseApiGroupOutput {
	return i.ToReleaseApiGroupOutputWithContext(context.Background())
}

func (i *ReleaseApiGroup) ToReleaseApiGroupOutputWithContext(ctx context.Context) ReleaseApiGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReleaseApiGroupOutput)
}

// ReleaseApiGroupArrayInput is an input type that accepts ReleaseApiGroupArray and ReleaseApiGroupArrayOutput values.
// You can construct a concrete instance of `ReleaseApiGroupArrayInput` via:
//
//	ReleaseApiGroupArray{ ReleaseApiGroupArgs{...} }
type ReleaseApiGroupArrayInput interface {
	pulumi.Input

	ToReleaseApiGroupArrayOutput() ReleaseApiGroupArrayOutput
	ToReleaseApiGroupArrayOutputWithContext(context.Context) ReleaseApiGroupArrayOutput
}

type ReleaseApiGroupArray []ReleaseApiGroupInput

func (ReleaseApiGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReleaseApiGroup)(nil)).Elem()
}

func (i ReleaseApiGroupArray) ToReleaseApiGroupArrayOutput() ReleaseApiGroupArrayOutput {
	return i.ToReleaseApiGroupArrayOutputWithContext(context.Background())
}

func (i ReleaseApiGroupArray) ToReleaseApiGroupArrayOutputWithContext(ctx context.Context) ReleaseApiGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReleaseApiGroupArrayOutput)
}

// ReleaseApiGroupMapInput is an input type that accepts ReleaseApiGroupMap and ReleaseApiGroupMapOutput values.
// You can construct a concrete instance of `ReleaseApiGroupMapInput` via:
//
//	ReleaseApiGroupMap{ "key": ReleaseApiGroupArgs{...} }
type ReleaseApiGroupMapInput interface {
	pulumi.Input

	ToReleaseApiGroupMapOutput() ReleaseApiGroupMapOutput
	ToReleaseApiGroupMapOutputWithContext(context.Context) ReleaseApiGroupMapOutput
}

type ReleaseApiGroupMap map[string]ReleaseApiGroupInput

func (ReleaseApiGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReleaseApiGroup)(nil)).Elem()
}

func (i ReleaseApiGroupMap) ToReleaseApiGroupMapOutput() ReleaseApiGroupMapOutput {
	return i.ToReleaseApiGroupMapOutputWithContext(context.Background())
}

func (i ReleaseApiGroupMap) ToReleaseApiGroupMapOutputWithContext(ctx context.Context) ReleaseApiGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReleaseApiGroupMapOutput)
}

type ReleaseApiGroupOutput struct{ *pulumi.OutputState }

func (ReleaseApiGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReleaseApiGroup)(nil)).Elem()
}

func (o ReleaseApiGroupOutput) ToReleaseApiGroupOutput() ReleaseApiGroupOutput {
	return o
}

func (o ReleaseApiGroupOutput) ToReleaseApiGroupOutputWithContext(ctx context.Context) ReleaseApiGroupOutput {
	return o
}

// api group Id.
func (o ReleaseApiGroupOutput) GroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReleaseApiGroup) pulumi.StringOutput { return v.GroupId }).(pulumi.StringOutput)
}

type ReleaseApiGroupArrayOutput struct{ *pulumi.OutputState }

func (ReleaseApiGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReleaseApiGroup)(nil)).Elem()
}

func (o ReleaseApiGroupArrayOutput) ToReleaseApiGroupArrayOutput() ReleaseApiGroupArrayOutput {
	return o
}

func (o ReleaseApiGroupArrayOutput) ToReleaseApiGroupArrayOutputWithContext(ctx context.Context) ReleaseApiGroupArrayOutput {
	return o
}

func (o ReleaseApiGroupArrayOutput) Index(i pulumi.IntInput) ReleaseApiGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ReleaseApiGroup {
		return vs[0].([]*ReleaseApiGroup)[vs[1].(int)]
	}).(ReleaseApiGroupOutput)
}

type ReleaseApiGroupMapOutput struct{ *pulumi.OutputState }

func (ReleaseApiGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReleaseApiGroup)(nil)).Elem()
}

func (o ReleaseApiGroupMapOutput) ToReleaseApiGroupMapOutput() ReleaseApiGroupMapOutput {
	return o
}

func (o ReleaseApiGroupMapOutput) ToReleaseApiGroupMapOutputWithContext(ctx context.Context) ReleaseApiGroupMapOutput {
	return o
}

func (o ReleaseApiGroupMapOutput) MapIndex(k pulumi.StringInput) ReleaseApiGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ReleaseApiGroup {
		return vs[0].(map[string]*ReleaseApiGroup)[vs[1].(string)]
	}).(ReleaseApiGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ReleaseApiGroupInput)(nil)).Elem(), &ReleaseApiGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReleaseApiGroupArrayInput)(nil)).Elem(), ReleaseApiGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReleaseApiGroupMapInput)(nil)).Elem(), ReleaseApiGroupMap{})
	pulumi.RegisterOutputType(ReleaseApiGroupOutput{})
	pulumi.RegisterOutputType(ReleaseApiGroupArrayOutput{})
	pulumi.RegisterOutputType(ReleaseApiGroupMapOutput{})
}
