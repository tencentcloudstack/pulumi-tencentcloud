// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dnspod

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a dnspod Dnspod.ModifyRecordGroupOperation
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dnspod"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dnspod.NewModifyRecordGroupOperation(ctx, "modifyRecordGroup", &Dnspod.ModifyRecordGroupOperationArgs{
//				Domain:   pulumi.String("dnspod.cn"),
//				DomainId: pulumi.Int(123),
//				GroupId:  pulumi.Int(1),
//				RecordId: pulumi.String("234|345"),
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
type ModifyRecordGroupOperation struct {
	pulumi.CustomResourceState

	// Domain.
	Domain pulumi.StringOutput `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrOutput `pulumi:"domainId"`
	// Record Group ID.
	GroupId pulumi.IntOutput `pulumi:"groupId"`
	// Record ID, multiple IDs are separated by a vertical line |.
	RecordId pulumi.StringOutput `pulumi:"recordId"`
}

// NewModifyRecordGroupOperation registers a new resource with the given unique name, arguments, and options.
func NewModifyRecordGroupOperation(ctx *pulumi.Context,
	name string, args *ModifyRecordGroupOperationArgs, opts ...pulumi.ResourceOption) (*ModifyRecordGroupOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Domain == nil {
		return nil, errors.New("invalid value for required argument 'Domain'")
	}
	if args.GroupId == nil {
		return nil, errors.New("invalid value for required argument 'GroupId'")
	}
	if args.RecordId == nil {
		return nil, errors.New("invalid value for required argument 'RecordId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ModifyRecordGroupOperation
	err := ctx.RegisterResource("tencentcloud:Dnspod/modifyRecordGroupOperation:ModifyRecordGroupOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModifyRecordGroupOperation gets an existing ModifyRecordGroupOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModifyRecordGroupOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModifyRecordGroupOperationState, opts ...pulumi.ResourceOption) (*ModifyRecordGroupOperation, error) {
	var resource ModifyRecordGroupOperation
	err := ctx.ReadResource("tencentcloud:Dnspod/modifyRecordGroupOperation:ModifyRecordGroupOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ModifyRecordGroupOperation resources.
type modifyRecordGroupOperationState struct {
	// Domain.
	Domain *string `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId *int `pulumi:"domainId"`
	// Record Group ID.
	GroupId *int `pulumi:"groupId"`
	// Record ID, multiple IDs are separated by a vertical line |.
	RecordId *string `pulumi:"recordId"`
}

type ModifyRecordGroupOperationState struct {
	// Domain.
	Domain pulumi.StringPtrInput
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrInput
	// Record Group ID.
	GroupId pulumi.IntPtrInput
	// Record ID, multiple IDs are separated by a vertical line |.
	RecordId pulumi.StringPtrInput
}

func (ModifyRecordGroupOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*modifyRecordGroupOperationState)(nil)).Elem()
}

type modifyRecordGroupOperationArgs struct {
	// Domain.
	Domain string `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId *int `pulumi:"domainId"`
	// Record Group ID.
	GroupId int `pulumi:"groupId"`
	// Record ID, multiple IDs are separated by a vertical line |.
	RecordId string `pulumi:"recordId"`
}

// The set of arguments for constructing a ModifyRecordGroupOperation resource.
type ModifyRecordGroupOperationArgs struct {
	// Domain.
	Domain pulumi.StringInput
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrInput
	// Record Group ID.
	GroupId pulumi.IntInput
	// Record ID, multiple IDs are separated by a vertical line |.
	RecordId pulumi.StringInput
}

func (ModifyRecordGroupOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modifyRecordGroupOperationArgs)(nil)).Elem()
}

type ModifyRecordGroupOperationInput interface {
	pulumi.Input

	ToModifyRecordGroupOperationOutput() ModifyRecordGroupOperationOutput
	ToModifyRecordGroupOperationOutputWithContext(ctx context.Context) ModifyRecordGroupOperationOutput
}

func (*ModifyRecordGroupOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifyRecordGroupOperation)(nil)).Elem()
}

func (i *ModifyRecordGroupOperation) ToModifyRecordGroupOperationOutput() ModifyRecordGroupOperationOutput {
	return i.ToModifyRecordGroupOperationOutputWithContext(context.Background())
}

func (i *ModifyRecordGroupOperation) ToModifyRecordGroupOperationOutputWithContext(ctx context.Context) ModifyRecordGroupOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyRecordGroupOperationOutput)
}

// ModifyRecordGroupOperationArrayInput is an input type that accepts ModifyRecordGroupOperationArray and ModifyRecordGroupOperationArrayOutput values.
// You can construct a concrete instance of `ModifyRecordGroupOperationArrayInput` via:
//
//	ModifyRecordGroupOperationArray{ ModifyRecordGroupOperationArgs{...} }
type ModifyRecordGroupOperationArrayInput interface {
	pulumi.Input

	ToModifyRecordGroupOperationArrayOutput() ModifyRecordGroupOperationArrayOutput
	ToModifyRecordGroupOperationArrayOutputWithContext(context.Context) ModifyRecordGroupOperationArrayOutput
}

type ModifyRecordGroupOperationArray []ModifyRecordGroupOperationInput

func (ModifyRecordGroupOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifyRecordGroupOperation)(nil)).Elem()
}

func (i ModifyRecordGroupOperationArray) ToModifyRecordGroupOperationArrayOutput() ModifyRecordGroupOperationArrayOutput {
	return i.ToModifyRecordGroupOperationArrayOutputWithContext(context.Background())
}

func (i ModifyRecordGroupOperationArray) ToModifyRecordGroupOperationArrayOutputWithContext(ctx context.Context) ModifyRecordGroupOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyRecordGroupOperationArrayOutput)
}

// ModifyRecordGroupOperationMapInput is an input type that accepts ModifyRecordGroupOperationMap and ModifyRecordGroupOperationMapOutput values.
// You can construct a concrete instance of `ModifyRecordGroupOperationMapInput` via:
//
//	ModifyRecordGroupOperationMap{ "key": ModifyRecordGroupOperationArgs{...} }
type ModifyRecordGroupOperationMapInput interface {
	pulumi.Input

	ToModifyRecordGroupOperationMapOutput() ModifyRecordGroupOperationMapOutput
	ToModifyRecordGroupOperationMapOutputWithContext(context.Context) ModifyRecordGroupOperationMapOutput
}

type ModifyRecordGroupOperationMap map[string]ModifyRecordGroupOperationInput

func (ModifyRecordGroupOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifyRecordGroupOperation)(nil)).Elem()
}

func (i ModifyRecordGroupOperationMap) ToModifyRecordGroupOperationMapOutput() ModifyRecordGroupOperationMapOutput {
	return i.ToModifyRecordGroupOperationMapOutputWithContext(context.Background())
}

func (i ModifyRecordGroupOperationMap) ToModifyRecordGroupOperationMapOutputWithContext(ctx context.Context) ModifyRecordGroupOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyRecordGroupOperationMapOutput)
}

type ModifyRecordGroupOperationOutput struct{ *pulumi.OutputState }

func (ModifyRecordGroupOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifyRecordGroupOperation)(nil)).Elem()
}

func (o ModifyRecordGroupOperationOutput) ToModifyRecordGroupOperationOutput() ModifyRecordGroupOperationOutput {
	return o
}

func (o ModifyRecordGroupOperationOutput) ToModifyRecordGroupOperationOutputWithContext(ctx context.Context) ModifyRecordGroupOperationOutput {
	return o
}

// Domain.
func (o ModifyRecordGroupOperationOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *ModifyRecordGroupOperation) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
func (o ModifyRecordGroupOperationOutput) DomainId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ModifyRecordGroupOperation) pulumi.IntPtrOutput { return v.DomainId }).(pulumi.IntPtrOutput)
}

// Record Group ID.
func (o ModifyRecordGroupOperationOutput) GroupId() pulumi.IntOutput {
	return o.ApplyT(func(v *ModifyRecordGroupOperation) pulumi.IntOutput { return v.GroupId }).(pulumi.IntOutput)
}

// Record ID, multiple IDs are separated by a vertical line |.
func (o ModifyRecordGroupOperationOutput) RecordId() pulumi.StringOutput {
	return o.ApplyT(func(v *ModifyRecordGroupOperation) pulumi.StringOutput { return v.RecordId }).(pulumi.StringOutput)
}

type ModifyRecordGroupOperationArrayOutput struct{ *pulumi.OutputState }

func (ModifyRecordGroupOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifyRecordGroupOperation)(nil)).Elem()
}

func (o ModifyRecordGroupOperationArrayOutput) ToModifyRecordGroupOperationArrayOutput() ModifyRecordGroupOperationArrayOutput {
	return o
}

func (o ModifyRecordGroupOperationArrayOutput) ToModifyRecordGroupOperationArrayOutputWithContext(ctx context.Context) ModifyRecordGroupOperationArrayOutput {
	return o
}

func (o ModifyRecordGroupOperationArrayOutput) Index(i pulumi.IntInput) ModifyRecordGroupOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ModifyRecordGroupOperation {
		return vs[0].([]*ModifyRecordGroupOperation)[vs[1].(int)]
	}).(ModifyRecordGroupOperationOutput)
}

type ModifyRecordGroupOperationMapOutput struct{ *pulumi.OutputState }

func (ModifyRecordGroupOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifyRecordGroupOperation)(nil)).Elem()
}

func (o ModifyRecordGroupOperationMapOutput) ToModifyRecordGroupOperationMapOutput() ModifyRecordGroupOperationMapOutput {
	return o
}

func (o ModifyRecordGroupOperationMapOutput) ToModifyRecordGroupOperationMapOutputWithContext(ctx context.Context) ModifyRecordGroupOperationMapOutput {
	return o
}

func (o ModifyRecordGroupOperationMapOutput) MapIndex(k pulumi.StringInput) ModifyRecordGroupOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ModifyRecordGroupOperation {
		return vs[0].(map[string]*ModifyRecordGroupOperation)[vs[1].(string)]
	}).(ModifyRecordGroupOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyRecordGroupOperationInput)(nil)).Elem(), &ModifyRecordGroupOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyRecordGroupOperationArrayInput)(nil)).Elem(), ModifyRecordGroupOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyRecordGroupOperationMapInput)(nil)).Elem(), ModifyRecordGroupOperationMap{})
	pulumi.RegisterOutputType(ModifyRecordGroupOperationOutput{})
	pulumi.RegisterOutputType(ModifyRecordGroupOperationArrayOutput{})
	pulumi.RegisterOutputType(ModifyRecordGroupOperationMapOutput{})
}
