// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package identity

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a organization Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachment
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Identity"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Identity.NewCenterRoleConfigurationPermissionCustomPoliciesAttachment(ctx, "identityCenterRoleConfigurationPermissionCustomPoliciesAttachment", &Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs{
//				ZoneId:              pulumi.String("z-xxxxxx"),
//				RoleConfigurationId: pulumi.String("rc-xxxxxx"),
//				Policies: identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArray{
//					&identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArgs{
//						RolePolicyName: pulumi.String("CustomPolicy2"),
//						RolePolicyDocument: pulumi.String(`{
//	    "version": "2.0",
//	    "statement": [
//	        {
//	            "effect": "allow",
//	            "action": [
//	                "vpc:AcceptAttachCcnInstances"
//	            ],
//	            "resource": [
//	                "*"
//	            ]
//	        }
//	    ]
//	}
//
// `),
//
//					},
//					&identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArgs{
//						RolePolicyName: pulumi.String("CustomPolicy1"),
//						RolePolicyDocument: pulumi.String(`{
//	    "version": "2.0",
//	    "statement": [
//	        {
//	            "effect": "allow",
//	            "action": [
//	                "vpc:AcceptAttachCcnInstances"
//	            ],
//	            "resource": [
//	                "*"
//	            ]
//	        }
//	    ]
//	}
//
// `),
//
//					},
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
//
// ## Import
//
// organization tencentcloud_identity_center_role_configuration_permission_custom_policies_attachment can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Identity/centerRoleConfigurationPermissionCustomPoliciesAttachment:CenterRoleConfigurationPermissionCustomPoliciesAttachment identity_center_role_configuration_permission_custom_policies_attachment ${zoneId}#${roleConfigurationId}#${rolePolicyName1},...${rolePolicyNameN}
// ```
type CenterRoleConfigurationPermissionCustomPoliciesAttachment struct {
	pulumi.CustomResourceState

	// Policies.
	Policies CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayOutput `pulumi:"policies"`
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringOutput `pulumi:"roleConfigurationId"`
	// Space ID.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewCenterRoleConfigurationPermissionCustomPoliciesAttachment registers a new resource with the given unique name, arguments, and options.
func NewCenterRoleConfigurationPermissionCustomPoliciesAttachment(ctx *pulumi.Context,
	name string, args *CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs, opts ...pulumi.ResourceOption) (*CenterRoleConfigurationPermissionCustomPoliciesAttachment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Policies == nil {
		return nil, errors.New("invalid value for required argument 'Policies'")
	}
	if args.RoleConfigurationId == nil {
		return nil, errors.New("invalid value for required argument 'RoleConfigurationId'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CenterRoleConfigurationPermissionCustomPoliciesAttachment
	err := ctx.RegisterResource("tencentcloud:Identity/centerRoleConfigurationPermissionCustomPoliciesAttachment:CenterRoleConfigurationPermissionCustomPoliciesAttachment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCenterRoleConfigurationPermissionCustomPoliciesAttachment gets an existing CenterRoleConfigurationPermissionCustomPoliciesAttachment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCenterRoleConfigurationPermissionCustomPoliciesAttachment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CenterRoleConfigurationPermissionCustomPoliciesAttachmentState, opts ...pulumi.ResourceOption) (*CenterRoleConfigurationPermissionCustomPoliciesAttachment, error) {
	var resource CenterRoleConfigurationPermissionCustomPoliciesAttachment
	err := ctx.ReadResource("tencentcloud:Identity/centerRoleConfigurationPermissionCustomPoliciesAttachment:CenterRoleConfigurationPermissionCustomPoliciesAttachment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CenterRoleConfigurationPermissionCustomPoliciesAttachment resources.
type centerRoleConfigurationPermissionCustomPoliciesAttachmentState struct {
	// Policies.
	Policies []CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicy `pulumi:"policies"`
	// Permission configuration ID.
	RoleConfigurationId *string `pulumi:"roleConfigurationId"`
	// Space ID.
	ZoneId *string `pulumi:"zoneId"`
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentState struct {
	// Policies.
	Policies CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayInput
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringPtrInput
	// Space ID.
	ZoneId pulumi.StringPtrInput
}

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*centerRoleConfigurationPermissionCustomPoliciesAttachmentState)(nil)).Elem()
}

type centerRoleConfigurationPermissionCustomPoliciesAttachmentArgs struct {
	// Policies.
	Policies []CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicy `pulumi:"policies"`
	// Permission configuration ID.
	RoleConfigurationId string `pulumi:"roleConfigurationId"`
	// Space ID.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a CenterRoleConfigurationPermissionCustomPoliciesAttachment resource.
type CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs struct {
	// Policies.
	Policies CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayInput
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringInput
	// Space ID.
	ZoneId pulumi.StringInput
}

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*centerRoleConfigurationPermissionCustomPoliciesAttachmentArgs)(nil)).Elem()
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentInput interface {
	pulumi.Input

	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput
	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput
}

func (*CenterRoleConfigurationPermissionCustomPoliciesAttachment) ElementType() reflect.Type {
	return reflect.TypeOf((**CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (i *CenterRoleConfigurationPermissionCustomPoliciesAttachment) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return i.ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutputWithContext(context.Background())
}

func (i *CenterRoleConfigurationPermissionCustomPoliciesAttachment) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput)
}

// CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayInput is an input type that accepts CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray and CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput values.
// You can construct a concrete instance of `CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayInput` via:
//
//	CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray{ CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs{...} }
type CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayInput interface {
	pulumi.Input

	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput
	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutputWithContext(context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray []CenterRoleConfigurationPermissionCustomPoliciesAttachmentInput

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (i CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput {
	return i.ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutputWithContext(context.Background())
}

func (i CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput)
}

// CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapInput is an input type that accepts CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap and CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput values.
// You can construct a concrete instance of `CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapInput` via:
//
//	CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap{ "key": CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs{...} }
type CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapInput interface {
	pulumi.Input

	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput
	ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutputWithContext(context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap map[string]CenterRoleConfigurationPermissionCustomPoliciesAttachmentInput

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (i CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput {
	return i.ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutputWithContext(context.Background())
}

func (i CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput)
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput struct{ *pulumi.OutputState }

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return o
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return o
}

// Policies.
func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) Policies() CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayOutput {
	return o.ApplyT(func(v *CenterRoleConfigurationPermissionCustomPoliciesAttachment) CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayOutput {
		return v.Policies
	}).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicyArrayOutput)
}

// Permission configuration ID.
func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) RoleConfigurationId() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleConfigurationPermissionCustomPoliciesAttachment) pulumi.StringOutput {
		return v.RoleConfigurationId
	}).(pulumi.StringOutput)
}

// Space ID.
func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleConfigurationPermissionCustomPoliciesAttachment) pulumi.StringOutput {
		return v.ZoneId
	}).(pulumi.StringOutput)
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput struct{ *pulumi.OutputState }

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput {
	return o
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput {
	return o
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput) Index(i pulumi.IntInput) CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CenterRoleConfigurationPermissionCustomPoliciesAttachment {
		return vs[0].([]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)[vs[1].(int)]
	}).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput)
}

type CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput struct{ *pulumi.OutputState }

func (CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)(nil)).Elem()
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput() CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput {
	return o
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput) ToCenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutputWithContext(ctx context.Context) CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput {
	return o
}

func (o CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput) MapIndex(k pulumi.StringInput) CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CenterRoleConfigurationPermissionCustomPoliciesAttachment {
		return vs[0].(map[string]*CenterRoleConfigurationPermissionCustomPoliciesAttachment)[vs[1].(string)]
	}).(CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleConfigurationPermissionCustomPoliciesAttachmentInput)(nil)).Elem(), &CenterRoleConfigurationPermissionCustomPoliciesAttachment{})
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayInput)(nil)).Elem(), CenterRoleConfigurationPermissionCustomPoliciesAttachmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapInput)(nil)).Elem(), CenterRoleConfigurationPermissionCustomPoliciesAttachmentMap{})
	pulumi.RegisterOutputType(CenterRoleConfigurationPermissionCustomPoliciesAttachmentOutput{})
	pulumi.RegisterOutputType(CenterRoleConfigurationPermissionCustomPoliciesAttachmentArrayOutput{})
	pulumi.RegisterOutputType(CenterRoleConfigurationPermissionCustomPoliciesAttachmentMapOutput{})
}
