// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package organization

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a organization orgManagePolicyConfig
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Organization"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Organization.NewOrgManagePolicyConfig(ctx, "orgManagePolicyConfig", &Organization.OrgManagePolicyConfigArgs{
//				OrganizationId: pulumi.Int(80001),
//				PolicyType:     pulumi.String("SERVICE_CONTROL_POLICY"),
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
// organization org_manage_policy_config can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig org_manage_policy_config organization_id#policy_type
// ```
type OrgManagePolicyConfig struct {
	pulumi.CustomResourceState

	// Organization ID.
	OrganizationId pulumi.IntOutput `pulumi:"organizationId"`
	// Policy type. Default value is SERVICE_CONTROL_POLICY.
	// Valid values:
	PolicyType pulumi.StringPtrOutput `pulumi:"policyType"`
}

// NewOrgManagePolicyConfig registers a new resource with the given unique name, arguments, and options.
func NewOrgManagePolicyConfig(ctx *pulumi.Context,
	name string, args *OrgManagePolicyConfigArgs, opts ...pulumi.ResourceOption) (*OrgManagePolicyConfig, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.OrganizationId == nil {
		return nil, errors.New("invalid value for required argument 'OrganizationId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource OrgManagePolicyConfig
	err := ctx.RegisterResource("tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetOrgManagePolicyConfig gets an existing OrgManagePolicyConfig resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetOrgManagePolicyConfig(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *OrgManagePolicyConfigState, opts ...pulumi.ResourceOption) (*OrgManagePolicyConfig, error) {
	var resource OrgManagePolicyConfig
	err := ctx.ReadResource("tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering OrgManagePolicyConfig resources.
type orgManagePolicyConfigState struct {
	// Organization ID.
	OrganizationId *int `pulumi:"organizationId"`
	// Policy type. Default value is SERVICE_CONTROL_POLICY.
	// Valid values:
	PolicyType *string `pulumi:"policyType"`
}

type OrgManagePolicyConfigState struct {
	// Organization ID.
	OrganizationId pulumi.IntPtrInput
	// Policy type. Default value is SERVICE_CONTROL_POLICY.
	// Valid values:
	PolicyType pulumi.StringPtrInput
}

func (OrgManagePolicyConfigState) ElementType() reflect.Type {
	return reflect.TypeOf((*orgManagePolicyConfigState)(nil)).Elem()
}

type orgManagePolicyConfigArgs struct {
	// Organization ID.
	OrganizationId int `pulumi:"organizationId"`
	// Policy type. Default value is SERVICE_CONTROL_POLICY.
	// Valid values:
	PolicyType *string `pulumi:"policyType"`
}

// The set of arguments for constructing a OrgManagePolicyConfig resource.
type OrgManagePolicyConfigArgs struct {
	// Organization ID.
	OrganizationId pulumi.IntInput
	// Policy type. Default value is SERVICE_CONTROL_POLICY.
	// Valid values:
	PolicyType pulumi.StringPtrInput
}

func (OrgManagePolicyConfigArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*orgManagePolicyConfigArgs)(nil)).Elem()
}

type OrgManagePolicyConfigInput interface {
	pulumi.Input

	ToOrgManagePolicyConfigOutput() OrgManagePolicyConfigOutput
	ToOrgManagePolicyConfigOutputWithContext(ctx context.Context) OrgManagePolicyConfigOutput
}

func (*OrgManagePolicyConfig) ElementType() reflect.Type {
	return reflect.TypeOf((**OrgManagePolicyConfig)(nil)).Elem()
}

func (i *OrgManagePolicyConfig) ToOrgManagePolicyConfigOutput() OrgManagePolicyConfigOutput {
	return i.ToOrgManagePolicyConfigOutputWithContext(context.Background())
}

func (i *OrgManagePolicyConfig) ToOrgManagePolicyConfigOutputWithContext(ctx context.Context) OrgManagePolicyConfigOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgManagePolicyConfigOutput)
}

// OrgManagePolicyConfigArrayInput is an input type that accepts OrgManagePolicyConfigArray and OrgManagePolicyConfigArrayOutput values.
// You can construct a concrete instance of `OrgManagePolicyConfigArrayInput` via:
//
//	OrgManagePolicyConfigArray{ OrgManagePolicyConfigArgs{...} }
type OrgManagePolicyConfigArrayInput interface {
	pulumi.Input

	ToOrgManagePolicyConfigArrayOutput() OrgManagePolicyConfigArrayOutput
	ToOrgManagePolicyConfigArrayOutputWithContext(context.Context) OrgManagePolicyConfigArrayOutput
}

type OrgManagePolicyConfigArray []OrgManagePolicyConfigInput

func (OrgManagePolicyConfigArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrgManagePolicyConfig)(nil)).Elem()
}

func (i OrgManagePolicyConfigArray) ToOrgManagePolicyConfigArrayOutput() OrgManagePolicyConfigArrayOutput {
	return i.ToOrgManagePolicyConfigArrayOutputWithContext(context.Background())
}

func (i OrgManagePolicyConfigArray) ToOrgManagePolicyConfigArrayOutputWithContext(ctx context.Context) OrgManagePolicyConfigArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgManagePolicyConfigArrayOutput)
}

// OrgManagePolicyConfigMapInput is an input type that accepts OrgManagePolicyConfigMap and OrgManagePolicyConfigMapOutput values.
// You can construct a concrete instance of `OrgManagePolicyConfigMapInput` via:
//
//	OrgManagePolicyConfigMap{ "key": OrgManagePolicyConfigArgs{...} }
type OrgManagePolicyConfigMapInput interface {
	pulumi.Input

	ToOrgManagePolicyConfigMapOutput() OrgManagePolicyConfigMapOutput
	ToOrgManagePolicyConfigMapOutputWithContext(context.Context) OrgManagePolicyConfigMapOutput
}

type OrgManagePolicyConfigMap map[string]OrgManagePolicyConfigInput

func (OrgManagePolicyConfigMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrgManagePolicyConfig)(nil)).Elem()
}

func (i OrgManagePolicyConfigMap) ToOrgManagePolicyConfigMapOutput() OrgManagePolicyConfigMapOutput {
	return i.ToOrgManagePolicyConfigMapOutputWithContext(context.Background())
}

func (i OrgManagePolicyConfigMap) ToOrgManagePolicyConfigMapOutputWithContext(ctx context.Context) OrgManagePolicyConfigMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(OrgManagePolicyConfigMapOutput)
}

type OrgManagePolicyConfigOutput struct{ *pulumi.OutputState }

func (OrgManagePolicyConfigOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**OrgManagePolicyConfig)(nil)).Elem()
}

func (o OrgManagePolicyConfigOutput) ToOrgManagePolicyConfigOutput() OrgManagePolicyConfigOutput {
	return o
}

func (o OrgManagePolicyConfigOutput) ToOrgManagePolicyConfigOutputWithContext(ctx context.Context) OrgManagePolicyConfigOutput {
	return o
}

// Organization ID.
func (o OrgManagePolicyConfigOutput) OrganizationId() pulumi.IntOutput {
	return o.ApplyT(func(v *OrgManagePolicyConfig) pulumi.IntOutput { return v.OrganizationId }).(pulumi.IntOutput)
}

// Policy type. Default value is SERVICE_CONTROL_POLICY.
// Valid values:
func (o OrgManagePolicyConfigOutput) PolicyType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *OrgManagePolicyConfig) pulumi.StringPtrOutput { return v.PolicyType }).(pulumi.StringPtrOutput)
}

type OrgManagePolicyConfigArrayOutput struct{ *pulumi.OutputState }

func (OrgManagePolicyConfigArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*OrgManagePolicyConfig)(nil)).Elem()
}

func (o OrgManagePolicyConfigArrayOutput) ToOrgManagePolicyConfigArrayOutput() OrgManagePolicyConfigArrayOutput {
	return o
}

func (o OrgManagePolicyConfigArrayOutput) ToOrgManagePolicyConfigArrayOutputWithContext(ctx context.Context) OrgManagePolicyConfigArrayOutput {
	return o
}

func (o OrgManagePolicyConfigArrayOutput) Index(i pulumi.IntInput) OrgManagePolicyConfigOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *OrgManagePolicyConfig {
		return vs[0].([]*OrgManagePolicyConfig)[vs[1].(int)]
	}).(OrgManagePolicyConfigOutput)
}

type OrgManagePolicyConfigMapOutput struct{ *pulumi.OutputState }

func (OrgManagePolicyConfigMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*OrgManagePolicyConfig)(nil)).Elem()
}

func (o OrgManagePolicyConfigMapOutput) ToOrgManagePolicyConfigMapOutput() OrgManagePolicyConfigMapOutput {
	return o
}

func (o OrgManagePolicyConfigMapOutput) ToOrgManagePolicyConfigMapOutputWithContext(ctx context.Context) OrgManagePolicyConfigMapOutput {
	return o
}

func (o OrgManagePolicyConfigMapOutput) MapIndex(k pulumi.StringInput) OrgManagePolicyConfigOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *OrgManagePolicyConfig {
		return vs[0].(map[string]*OrgManagePolicyConfig)[vs[1].(string)]
	}).(OrgManagePolicyConfigOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*OrgManagePolicyConfigInput)(nil)).Elem(), &OrgManagePolicyConfig{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrgManagePolicyConfigArrayInput)(nil)).Elem(), OrgManagePolicyConfigArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*OrgManagePolicyConfigMapInput)(nil)).Elem(), OrgManagePolicyConfigMap{})
	pulumi.RegisterOutputType(OrgManagePolicyConfigOutput{})
	pulumi.RegisterOutputType(OrgManagePolicyConfigArrayOutput{})
	pulumi.RegisterOutputType(OrgManagePolicyConfigMapOutput{})
}