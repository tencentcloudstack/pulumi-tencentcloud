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

// Provides a resource to create a dnspod modifyDomainOwner
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
//			_, err := Dnspod.NewModifyDomainOwnerOperation(ctx, "modifyDomainOwner", &Dnspod.ModifyDomainOwnerOperationArgs{
//				Account:  pulumi.String("xxxxxxxxx"),
//				Domain:   pulumi.String("dnspod.cn"),
//				DomainId: pulumi.Int(123),
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
type ModifyDomainOwnerOperation struct {
	pulumi.CustomResourceState

	// The account to which the domain needs to be transferred, supporting Uin or email format.
	Account pulumi.StringOutput `pulumi:"account"`
	// Domain.
	Domain pulumi.StringOutput `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrOutput `pulumi:"domainId"`
}

// NewModifyDomainOwnerOperation registers a new resource with the given unique name, arguments, and options.
func NewModifyDomainOwnerOperation(ctx *pulumi.Context,
	name string, args *ModifyDomainOwnerOperationArgs, opts ...pulumi.ResourceOption) (*ModifyDomainOwnerOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Account == nil {
		return nil, errors.New("invalid value for required argument 'Account'")
	}
	if args.Domain == nil {
		return nil, errors.New("invalid value for required argument 'Domain'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ModifyDomainOwnerOperation
	err := ctx.RegisterResource("tencentcloud:Dnspod/modifyDomainOwnerOperation:ModifyDomainOwnerOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetModifyDomainOwnerOperation gets an existing ModifyDomainOwnerOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetModifyDomainOwnerOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ModifyDomainOwnerOperationState, opts ...pulumi.ResourceOption) (*ModifyDomainOwnerOperation, error) {
	var resource ModifyDomainOwnerOperation
	err := ctx.ReadResource("tencentcloud:Dnspod/modifyDomainOwnerOperation:ModifyDomainOwnerOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ModifyDomainOwnerOperation resources.
type modifyDomainOwnerOperationState struct {
	// The account to which the domain needs to be transferred, supporting Uin or email format.
	Account *string `pulumi:"account"`
	// Domain.
	Domain *string `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId *int `pulumi:"domainId"`
}

type ModifyDomainOwnerOperationState struct {
	// The account to which the domain needs to be transferred, supporting Uin or email format.
	Account pulumi.StringPtrInput
	// Domain.
	Domain pulumi.StringPtrInput
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrInput
}

func (ModifyDomainOwnerOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*modifyDomainOwnerOperationState)(nil)).Elem()
}

type modifyDomainOwnerOperationArgs struct {
	// The account to which the domain needs to be transferred, supporting Uin or email format.
	Account string `pulumi:"account"`
	// Domain.
	Domain string `pulumi:"domain"`
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId *int `pulumi:"domainId"`
}

// The set of arguments for constructing a ModifyDomainOwnerOperation resource.
type ModifyDomainOwnerOperationArgs struct {
	// The account to which the domain needs to be transferred, supporting Uin or email format.
	Account pulumi.StringInput
	// Domain.
	Domain pulumi.StringInput
	// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
	DomainId pulumi.IntPtrInput
}

func (ModifyDomainOwnerOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*modifyDomainOwnerOperationArgs)(nil)).Elem()
}

type ModifyDomainOwnerOperationInput interface {
	pulumi.Input

	ToModifyDomainOwnerOperationOutput() ModifyDomainOwnerOperationOutput
	ToModifyDomainOwnerOperationOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationOutput
}

func (*ModifyDomainOwnerOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifyDomainOwnerOperation)(nil)).Elem()
}

func (i *ModifyDomainOwnerOperation) ToModifyDomainOwnerOperationOutput() ModifyDomainOwnerOperationOutput {
	return i.ToModifyDomainOwnerOperationOutputWithContext(context.Background())
}

func (i *ModifyDomainOwnerOperation) ToModifyDomainOwnerOperationOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyDomainOwnerOperationOutput)
}

// ModifyDomainOwnerOperationArrayInput is an input type that accepts ModifyDomainOwnerOperationArray and ModifyDomainOwnerOperationArrayOutput values.
// You can construct a concrete instance of `ModifyDomainOwnerOperationArrayInput` via:
//
//	ModifyDomainOwnerOperationArray{ ModifyDomainOwnerOperationArgs{...} }
type ModifyDomainOwnerOperationArrayInput interface {
	pulumi.Input

	ToModifyDomainOwnerOperationArrayOutput() ModifyDomainOwnerOperationArrayOutput
	ToModifyDomainOwnerOperationArrayOutputWithContext(context.Context) ModifyDomainOwnerOperationArrayOutput
}

type ModifyDomainOwnerOperationArray []ModifyDomainOwnerOperationInput

func (ModifyDomainOwnerOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifyDomainOwnerOperation)(nil)).Elem()
}

func (i ModifyDomainOwnerOperationArray) ToModifyDomainOwnerOperationArrayOutput() ModifyDomainOwnerOperationArrayOutput {
	return i.ToModifyDomainOwnerOperationArrayOutputWithContext(context.Background())
}

func (i ModifyDomainOwnerOperationArray) ToModifyDomainOwnerOperationArrayOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyDomainOwnerOperationArrayOutput)
}

// ModifyDomainOwnerOperationMapInput is an input type that accepts ModifyDomainOwnerOperationMap and ModifyDomainOwnerOperationMapOutput values.
// You can construct a concrete instance of `ModifyDomainOwnerOperationMapInput` via:
//
//	ModifyDomainOwnerOperationMap{ "key": ModifyDomainOwnerOperationArgs{...} }
type ModifyDomainOwnerOperationMapInput interface {
	pulumi.Input

	ToModifyDomainOwnerOperationMapOutput() ModifyDomainOwnerOperationMapOutput
	ToModifyDomainOwnerOperationMapOutputWithContext(context.Context) ModifyDomainOwnerOperationMapOutput
}

type ModifyDomainOwnerOperationMap map[string]ModifyDomainOwnerOperationInput

func (ModifyDomainOwnerOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifyDomainOwnerOperation)(nil)).Elem()
}

func (i ModifyDomainOwnerOperationMap) ToModifyDomainOwnerOperationMapOutput() ModifyDomainOwnerOperationMapOutput {
	return i.ToModifyDomainOwnerOperationMapOutputWithContext(context.Background())
}

func (i ModifyDomainOwnerOperationMap) ToModifyDomainOwnerOperationMapOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ModifyDomainOwnerOperationMapOutput)
}

type ModifyDomainOwnerOperationOutput struct{ *pulumi.OutputState }

func (ModifyDomainOwnerOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ModifyDomainOwnerOperation)(nil)).Elem()
}

func (o ModifyDomainOwnerOperationOutput) ToModifyDomainOwnerOperationOutput() ModifyDomainOwnerOperationOutput {
	return o
}

func (o ModifyDomainOwnerOperationOutput) ToModifyDomainOwnerOperationOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationOutput {
	return o
}

// The account to which the domain needs to be transferred, supporting Uin or email format.
func (o ModifyDomainOwnerOperationOutput) Account() pulumi.StringOutput {
	return o.ApplyT(func(v *ModifyDomainOwnerOperation) pulumi.StringOutput { return v.Account }).(pulumi.StringOutput)
}

// Domain.
func (o ModifyDomainOwnerOperationOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v *ModifyDomainOwnerOperation) pulumi.StringOutput { return v.Domain }).(pulumi.StringOutput)
}

// Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
func (o ModifyDomainOwnerOperationOutput) DomainId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *ModifyDomainOwnerOperation) pulumi.IntPtrOutput { return v.DomainId }).(pulumi.IntPtrOutput)
}

type ModifyDomainOwnerOperationArrayOutput struct{ *pulumi.OutputState }

func (ModifyDomainOwnerOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ModifyDomainOwnerOperation)(nil)).Elem()
}

func (o ModifyDomainOwnerOperationArrayOutput) ToModifyDomainOwnerOperationArrayOutput() ModifyDomainOwnerOperationArrayOutput {
	return o
}

func (o ModifyDomainOwnerOperationArrayOutput) ToModifyDomainOwnerOperationArrayOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationArrayOutput {
	return o
}

func (o ModifyDomainOwnerOperationArrayOutput) Index(i pulumi.IntInput) ModifyDomainOwnerOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ModifyDomainOwnerOperation {
		return vs[0].([]*ModifyDomainOwnerOperation)[vs[1].(int)]
	}).(ModifyDomainOwnerOperationOutput)
}

type ModifyDomainOwnerOperationMapOutput struct{ *pulumi.OutputState }

func (ModifyDomainOwnerOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ModifyDomainOwnerOperation)(nil)).Elem()
}

func (o ModifyDomainOwnerOperationMapOutput) ToModifyDomainOwnerOperationMapOutput() ModifyDomainOwnerOperationMapOutput {
	return o
}

func (o ModifyDomainOwnerOperationMapOutput) ToModifyDomainOwnerOperationMapOutputWithContext(ctx context.Context) ModifyDomainOwnerOperationMapOutput {
	return o
}

func (o ModifyDomainOwnerOperationMapOutput) MapIndex(k pulumi.StringInput) ModifyDomainOwnerOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ModifyDomainOwnerOperation {
		return vs[0].(map[string]*ModifyDomainOwnerOperation)[vs[1].(string)]
	}).(ModifyDomainOwnerOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyDomainOwnerOperationInput)(nil)).Elem(), &ModifyDomainOwnerOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyDomainOwnerOperationArrayInput)(nil)).Elem(), ModifyDomainOwnerOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ModifyDomainOwnerOperationMapInput)(nil)).Elem(), ModifyDomainOwnerOperationMap{})
	pulumi.RegisterOutputType(ModifyDomainOwnerOperationOutput{})
	pulumi.RegisterOutputType(ModifyDomainOwnerOperationArrayOutput{})
	pulumi.RegisterOutputType(ModifyDomainOwnerOperationMapOutput{})
}
