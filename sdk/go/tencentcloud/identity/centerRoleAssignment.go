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

// Provides a resource to create a organization identityCenterRoleAssignment
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
//			_, err := Identity.NewCenterRoleAssignment(ctx, "identityCenterRoleAssignment", &Identity.CenterRoleAssignmentArgs{
//				PrincipalId:         pulumi.String("u-xxxxxx"),
//				PrincipalType:       pulumi.String("User"),
//				RoleConfigurationId: pulumi.String("rc-xxxxxx"),
//				TargetType:          pulumi.String("MemberUin"),
//				TargetUin:           pulumi.Int("xxxxxx"),
//				ZoneId:              pulumi.String("z-xxxxxx"),
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
// organization identity_center_role_assignment can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Identity/centerRoleAssignment:CenterRoleAssignment identity_center_role_assignment {zoneId}#{roleConfigurationId}#{targetType}#{targetUinString}#{principalType}#{principalId}
// ```
type CenterRoleAssignment struct {
	pulumi.CustomResourceState

	// Create time.
	CreateTime pulumi.StringOutput `pulumi:"createTime"`
	// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
	DeprovisionStrategy pulumi.StringPtrOutput `pulumi:"deprovisionStrategy"`
	// Identity ID for the CAM user synchronization. Valid values:
	// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
	// When the PrincipalType value is User, it is the CIC user ID (u-********).
	PrincipalId pulumi.StringOutput `pulumi:"principalId"`
	// Principal name.
	PrincipalName pulumi.StringOutput `pulumi:"principalName"`
	// Identity type for the CAM user synchronization. Valid values:
	//
	// User: indicates that the identity for the CAM user synchronization is a CIC user.
	// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
	PrincipalType pulumi.StringOutput `pulumi:"principalType"`
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringOutput `pulumi:"roleConfigurationId"`
	// Role configuration name.
	RoleConfigurationName pulumi.StringOutput `pulumi:"roleConfigurationName"`
	// Target name.
	TargetName pulumi.StringOutput `pulumi:"targetName"`
	// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
	TargetType pulumi.StringOutput `pulumi:"targetType"`
	// UIN of the synchronized target account of the Tencent Cloud Organization.
	TargetUin pulumi.IntOutput `pulumi:"targetUin"`
	// Update time.
	UpdateTime pulumi.StringOutput `pulumi:"updateTime"`
	// Space ID.
	ZoneId pulumi.StringOutput `pulumi:"zoneId"`
}

// NewCenterRoleAssignment registers a new resource with the given unique name, arguments, and options.
func NewCenterRoleAssignment(ctx *pulumi.Context,
	name string, args *CenterRoleAssignmentArgs, opts ...pulumi.ResourceOption) (*CenterRoleAssignment, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.PrincipalId == nil {
		return nil, errors.New("invalid value for required argument 'PrincipalId'")
	}
	if args.PrincipalType == nil {
		return nil, errors.New("invalid value for required argument 'PrincipalType'")
	}
	if args.RoleConfigurationId == nil {
		return nil, errors.New("invalid value for required argument 'RoleConfigurationId'")
	}
	if args.TargetType == nil {
		return nil, errors.New("invalid value for required argument 'TargetType'")
	}
	if args.TargetUin == nil {
		return nil, errors.New("invalid value for required argument 'TargetUin'")
	}
	if args.ZoneId == nil {
		return nil, errors.New("invalid value for required argument 'ZoneId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource CenterRoleAssignment
	err := ctx.RegisterResource("tencentcloud:Identity/centerRoleAssignment:CenterRoleAssignment", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCenterRoleAssignment gets an existing CenterRoleAssignment resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCenterRoleAssignment(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CenterRoleAssignmentState, opts ...pulumi.ResourceOption) (*CenterRoleAssignment, error) {
	var resource CenterRoleAssignment
	err := ctx.ReadResource("tencentcloud:Identity/centerRoleAssignment:CenterRoleAssignment", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CenterRoleAssignment resources.
type centerRoleAssignmentState struct {
	// Create time.
	CreateTime *string `pulumi:"createTime"`
	// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
	DeprovisionStrategy *string `pulumi:"deprovisionStrategy"`
	// Identity ID for the CAM user synchronization. Valid values:
	// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
	// When the PrincipalType value is User, it is the CIC user ID (u-********).
	PrincipalId *string `pulumi:"principalId"`
	// Principal name.
	PrincipalName *string `pulumi:"principalName"`
	// Identity type for the CAM user synchronization. Valid values:
	//
	// User: indicates that the identity for the CAM user synchronization is a CIC user.
	// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
	PrincipalType *string `pulumi:"principalType"`
	// Permission configuration ID.
	RoleConfigurationId *string `pulumi:"roleConfigurationId"`
	// Role configuration name.
	RoleConfigurationName *string `pulumi:"roleConfigurationName"`
	// Target name.
	TargetName *string `pulumi:"targetName"`
	// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
	TargetType *string `pulumi:"targetType"`
	// UIN of the synchronized target account of the Tencent Cloud Organization.
	TargetUin *int `pulumi:"targetUin"`
	// Update time.
	UpdateTime *string `pulumi:"updateTime"`
	// Space ID.
	ZoneId *string `pulumi:"zoneId"`
}

type CenterRoleAssignmentState struct {
	// Create time.
	CreateTime pulumi.StringPtrInput
	// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
	DeprovisionStrategy pulumi.StringPtrInput
	// Identity ID for the CAM user synchronization. Valid values:
	// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
	// When the PrincipalType value is User, it is the CIC user ID (u-********).
	PrincipalId pulumi.StringPtrInput
	// Principal name.
	PrincipalName pulumi.StringPtrInput
	// Identity type for the CAM user synchronization. Valid values:
	//
	// User: indicates that the identity for the CAM user synchronization is a CIC user.
	// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
	PrincipalType pulumi.StringPtrInput
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringPtrInput
	// Role configuration name.
	RoleConfigurationName pulumi.StringPtrInput
	// Target name.
	TargetName pulumi.StringPtrInput
	// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
	TargetType pulumi.StringPtrInput
	// UIN of the synchronized target account of the Tencent Cloud Organization.
	TargetUin pulumi.IntPtrInput
	// Update time.
	UpdateTime pulumi.StringPtrInput
	// Space ID.
	ZoneId pulumi.StringPtrInput
}

func (CenterRoleAssignmentState) ElementType() reflect.Type {
	return reflect.TypeOf((*centerRoleAssignmentState)(nil)).Elem()
}

type centerRoleAssignmentArgs struct {
	// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
	DeprovisionStrategy *string `pulumi:"deprovisionStrategy"`
	// Identity ID for the CAM user synchronization. Valid values:
	// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
	// When the PrincipalType value is User, it is the CIC user ID (u-********).
	PrincipalId string `pulumi:"principalId"`
	// Identity type for the CAM user synchronization. Valid values:
	//
	// User: indicates that the identity for the CAM user synchronization is a CIC user.
	// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
	PrincipalType string `pulumi:"principalType"`
	// Permission configuration ID.
	RoleConfigurationId string `pulumi:"roleConfigurationId"`
	// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
	TargetType string `pulumi:"targetType"`
	// UIN of the synchronized target account of the Tencent Cloud Organization.
	TargetUin int `pulumi:"targetUin"`
	// Space ID.
	ZoneId string `pulumi:"zoneId"`
}

// The set of arguments for constructing a CenterRoleAssignment resource.
type CenterRoleAssignmentArgs struct {
	// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
	DeprovisionStrategy pulumi.StringPtrInput
	// Identity ID for the CAM user synchronization. Valid values:
	// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
	// When the PrincipalType value is User, it is the CIC user ID (u-********).
	PrincipalId pulumi.StringInput
	// Identity type for the CAM user synchronization. Valid values:
	//
	// User: indicates that the identity for the CAM user synchronization is a CIC user.
	// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
	PrincipalType pulumi.StringInput
	// Permission configuration ID.
	RoleConfigurationId pulumi.StringInput
	// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
	TargetType pulumi.StringInput
	// UIN of the synchronized target account of the Tencent Cloud Organization.
	TargetUin pulumi.IntInput
	// Space ID.
	ZoneId pulumi.StringInput
}

func (CenterRoleAssignmentArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*centerRoleAssignmentArgs)(nil)).Elem()
}

type CenterRoleAssignmentInput interface {
	pulumi.Input

	ToCenterRoleAssignmentOutput() CenterRoleAssignmentOutput
	ToCenterRoleAssignmentOutputWithContext(ctx context.Context) CenterRoleAssignmentOutput
}

func (*CenterRoleAssignment) ElementType() reflect.Type {
	return reflect.TypeOf((**CenterRoleAssignment)(nil)).Elem()
}

func (i *CenterRoleAssignment) ToCenterRoleAssignmentOutput() CenterRoleAssignmentOutput {
	return i.ToCenterRoleAssignmentOutputWithContext(context.Background())
}

func (i *CenterRoleAssignment) ToCenterRoleAssignmentOutputWithContext(ctx context.Context) CenterRoleAssignmentOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleAssignmentOutput)
}

// CenterRoleAssignmentArrayInput is an input type that accepts CenterRoleAssignmentArray and CenterRoleAssignmentArrayOutput values.
// You can construct a concrete instance of `CenterRoleAssignmentArrayInput` via:
//
//	CenterRoleAssignmentArray{ CenterRoleAssignmentArgs{...} }
type CenterRoleAssignmentArrayInput interface {
	pulumi.Input

	ToCenterRoleAssignmentArrayOutput() CenterRoleAssignmentArrayOutput
	ToCenterRoleAssignmentArrayOutputWithContext(context.Context) CenterRoleAssignmentArrayOutput
}

type CenterRoleAssignmentArray []CenterRoleAssignmentInput

func (CenterRoleAssignmentArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CenterRoleAssignment)(nil)).Elem()
}

func (i CenterRoleAssignmentArray) ToCenterRoleAssignmentArrayOutput() CenterRoleAssignmentArrayOutput {
	return i.ToCenterRoleAssignmentArrayOutputWithContext(context.Background())
}

func (i CenterRoleAssignmentArray) ToCenterRoleAssignmentArrayOutputWithContext(ctx context.Context) CenterRoleAssignmentArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleAssignmentArrayOutput)
}

// CenterRoleAssignmentMapInput is an input type that accepts CenterRoleAssignmentMap and CenterRoleAssignmentMapOutput values.
// You can construct a concrete instance of `CenterRoleAssignmentMapInput` via:
//
//	CenterRoleAssignmentMap{ "key": CenterRoleAssignmentArgs{...} }
type CenterRoleAssignmentMapInput interface {
	pulumi.Input

	ToCenterRoleAssignmentMapOutput() CenterRoleAssignmentMapOutput
	ToCenterRoleAssignmentMapOutputWithContext(context.Context) CenterRoleAssignmentMapOutput
}

type CenterRoleAssignmentMap map[string]CenterRoleAssignmentInput

func (CenterRoleAssignmentMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CenterRoleAssignment)(nil)).Elem()
}

func (i CenterRoleAssignmentMap) ToCenterRoleAssignmentMapOutput() CenterRoleAssignmentMapOutput {
	return i.ToCenterRoleAssignmentMapOutputWithContext(context.Background())
}

func (i CenterRoleAssignmentMap) ToCenterRoleAssignmentMapOutputWithContext(ctx context.Context) CenterRoleAssignmentMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CenterRoleAssignmentMapOutput)
}

type CenterRoleAssignmentOutput struct{ *pulumi.OutputState }

func (CenterRoleAssignmentOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**CenterRoleAssignment)(nil)).Elem()
}

func (o CenterRoleAssignmentOutput) ToCenterRoleAssignmentOutput() CenterRoleAssignmentOutput {
	return o
}

func (o CenterRoleAssignmentOutput) ToCenterRoleAssignmentOutputWithContext(ctx context.Context) CenterRoleAssignmentOutput {
	return o
}

// Create time.
func (o CenterRoleAssignmentOutput) CreateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.CreateTime }).(pulumi.StringOutput)
}

// When you remove the last authorization configured with a certain privilege on a group account target account, whether to cancel the privilege configuration deployment at the same time. Value: DeprovisionForLastRoleAssignmentOnAccount: Remove privileges to configure deployment. None (default): Configure deployment without delegating privileges.
func (o CenterRoleAssignmentOutput) DeprovisionStrategy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringPtrOutput { return v.DeprovisionStrategy }).(pulumi.StringPtrOutput)
}

// Identity ID for the CAM user synchronization. Valid values:
// When the PrincipalType value is Group, it is the CIC user group ID (g-********).
// When the PrincipalType value is User, it is the CIC user ID (u-********).
func (o CenterRoleAssignmentOutput) PrincipalId() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.PrincipalId }).(pulumi.StringOutput)
}

// Principal name.
func (o CenterRoleAssignmentOutput) PrincipalName() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.PrincipalName }).(pulumi.StringOutput)
}

// Identity type for the CAM user synchronization. Valid values:
//
// User: indicates that the identity for the CAM user synchronization is a CIC user.
// Group: indicates that the identity for the CAM user synchronization is a CIC user group.
func (o CenterRoleAssignmentOutput) PrincipalType() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.PrincipalType }).(pulumi.StringOutput)
}

// Permission configuration ID.
func (o CenterRoleAssignmentOutput) RoleConfigurationId() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.RoleConfigurationId }).(pulumi.StringOutput)
}

// Role configuration name.
func (o CenterRoleAssignmentOutput) RoleConfigurationName() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.RoleConfigurationName }).(pulumi.StringOutput)
}

// Target name.
func (o CenterRoleAssignmentOutput) TargetName() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.TargetName }).(pulumi.StringOutput)
}

// Type of the synchronized target account of the Tencent Cloud Organization. ManagerUin: admin account; MemberUin: member account.
func (o CenterRoleAssignmentOutput) TargetType() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.TargetType }).(pulumi.StringOutput)
}

// UIN of the synchronized target account of the Tencent Cloud Organization.
func (o CenterRoleAssignmentOutput) TargetUin() pulumi.IntOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.IntOutput { return v.TargetUin }).(pulumi.IntOutput)
}

// Update time.
func (o CenterRoleAssignmentOutput) UpdateTime() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.UpdateTime }).(pulumi.StringOutput)
}

// Space ID.
func (o CenterRoleAssignmentOutput) ZoneId() pulumi.StringOutput {
	return o.ApplyT(func(v *CenterRoleAssignment) pulumi.StringOutput { return v.ZoneId }).(pulumi.StringOutput)
}

type CenterRoleAssignmentArrayOutput struct{ *pulumi.OutputState }

func (CenterRoleAssignmentArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*CenterRoleAssignment)(nil)).Elem()
}

func (o CenterRoleAssignmentArrayOutput) ToCenterRoleAssignmentArrayOutput() CenterRoleAssignmentArrayOutput {
	return o
}

func (o CenterRoleAssignmentArrayOutput) ToCenterRoleAssignmentArrayOutputWithContext(ctx context.Context) CenterRoleAssignmentArrayOutput {
	return o
}

func (o CenterRoleAssignmentArrayOutput) Index(i pulumi.IntInput) CenterRoleAssignmentOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *CenterRoleAssignment {
		return vs[0].([]*CenterRoleAssignment)[vs[1].(int)]
	}).(CenterRoleAssignmentOutput)
}

type CenterRoleAssignmentMapOutput struct{ *pulumi.OutputState }

func (CenterRoleAssignmentMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*CenterRoleAssignment)(nil)).Elem()
}

func (o CenterRoleAssignmentMapOutput) ToCenterRoleAssignmentMapOutput() CenterRoleAssignmentMapOutput {
	return o
}

func (o CenterRoleAssignmentMapOutput) ToCenterRoleAssignmentMapOutputWithContext(ctx context.Context) CenterRoleAssignmentMapOutput {
	return o
}

func (o CenterRoleAssignmentMapOutput) MapIndex(k pulumi.StringInput) CenterRoleAssignmentOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *CenterRoleAssignment {
		return vs[0].(map[string]*CenterRoleAssignment)[vs[1].(string)]
	}).(CenterRoleAssignmentOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleAssignmentInput)(nil)).Elem(), &CenterRoleAssignment{})
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleAssignmentArrayInput)(nil)).Elem(), CenterRoleAssignmentArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*CenterRoleAssignmentMapInput)(nil)).Elem(), CenterRoleAssignmentMap{})
	pulumi.RegisterOutputType(CenterRoleAssignmentOutput{})
	pulumi.RegisterOutputType(CenterRoleAssignmentArrayOutput{})
	pulumi.RegisterOutputType(CenterRoleAssignmentMapOutput{})
}