// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ccn

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a CCN Route table input policies.
//
// > **NOTE:** Use this resource to manage all input policies under the routing table of CCN instances.
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
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ccn"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			cfg := config.New(ctx, "")
//			region := "ap-guangzhou"
//			if param := cfg.Get("region"); param != "" {
//				region = param
//			}
//			availabilityZone := "ap-guangzhou-4"
//			if param := cfg.Get("availabilityZone"); param != "" {
//				availabilityZone = param
//			}
//			// create vpc
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("172.16.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			// create subnet
//			_, err = Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				AvailabilityZone: pulumi.String(availabilityZone),
//				VpcId:            vpc.ID(),
//				CidrBlock:        pulumi.String("172.16.0.0/24"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			// create ccn
//			exampleInstance, err := Ccn.NewInstance(ctx, "exampleInstance", &Ccn.InstanceArgs{
//				Description:        pulumi.String("desc."),
//				Qos:                pulumi.String("AG"),
//				ChargeType:         pulumi.String("PREPAID"),
//				BandwidthLimitType: pulumi.String("INTER_REGION_LIMIT"),
//				Tags: pulumi.Map{
//					"createBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			// create ccn route table
//			exampleRouteTable, err := Ccn.NewRouteTable(ctx, "exampleRouteTable", &Ccn.RouteTableArgs{
//				CcnId:       exampleInstance.ID(),
//				Description: pulumi.String("desc."),
//			})
//			if err != nil {
//				return err
//			}
//			// attachment instance
//			_, err = Ccn.NewAttachment(ctx, "attachment", &Ccn.AttachmentArgs{
//				CcnId:          exampleInstance.ID(),
//				InstanceId:     vpc.ID(),
//				InstanceType:   pulumi.String("VPC"),
//				InstanceRegion: pulumi.String(region),
//				RouteTableId:   exampleRouteTable.ID(),
//			})
//			if err != nil {
//				return err
//			}
//			// create route table input policy
//			_, err = Ccn.NewRouteTableInputPolicies(ctx, "exampleRouteTableInputPolicies", &Ccn.RouteTableInputPoliciesArgs{
//				CcnId:        exampleInstance.ID(),
//				RouteTableId: exampleRouteTable.ID(),
//				Policies: ccn.RouteTableInputPoliciesPolicyArray{
//					&ccn.RouteTableInputPoliciesPolicyArgs{
//						Action:      pulumi.String("accept"),
//						Description: pulumi.String("desc."),
//						RouteConditions: ccn.RouteTableInputPoliciesPolicyRouteConditionArray{
//							&ccn.RouteTableInputPoliciesPolicyRouteConditionArgs{
//								Name: pulumi.String("instance-region"),
//								Values: pulumi.StringArray{
//									pulumi.String(region),
//								},
//								MatchPattern: pulumi.Int(1),
//							},
//						},
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
// Ccn instance can be imported, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies example ccn-gr7nynbd#ccnrtb-jpf7bzn3
// ```
type RouteTableInputPolicies struct {
	pulumi.CustomResourceState

	// CCN Instance ID.
	CcnId pulumi.StringOutput `pulumi:"ccnId"`
	// Routing reception strategy.
	Policies RouteTableInputPoliciesPolicyArrayOutput `pulumi:"policies"`
	// CCN Route table ID.
	RouteTableId pulumi.StringOutput `pulumi:"routeTableId"`
}

// NewRouteTableInputPolicies registers a new resource with the given unique name, arguments, and options.
func NewRouteTableInputPolicies(ctx *pulumi.Context,
	name string, args *RouteTableInputPoliciesArgs, opts ...pulumi.ResourceOption) (*RouteTableInputPolicies, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CcnId == nil {
		return nil, errors.New("invalid value for required argument 'CcnId'")
	}
	if args.RouteTableId == nil {
		return nil, errors.New("invalid value for required argument 'RouteTableId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RouteTableInputPolicies
	err := ctx.RegisterResource("tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRouteTableInputPolicies gets an existing RouteTableInputPolicies resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRouteTableInputPolicies(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RouteTableInputPoliciesState, opts ...pulumi.ResourceOption) (*RouteTableInputPolicies, error) {
	var resource RouteTableInputPolicies
	err := ctx.ReadResource("tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RouteTableInputPolicies resources.
type routeTableInputPoliciesState struct {
	// CCN Instance ID.
	CcnId *string `pulumi:"ccnId"`
	// Routing reception strategy.
	Policies []RouteTableInputPoliciesPolicy `pulumi:"policies"`
	// CCN Route table ID.
	RouteTableId *string `pulumi:"routeTableId"`
}

type RouteTableInputPoliciesState struct {
	// CCN Instance ID.
	CcnId pulumi.StringPtrInput
	// Routing reception strategy.
	Policies RouteTableInputPoliciesPolicyArrayInput
	// CCN Route table ID.
	RouteTableId pulumi.StringPtrInput
}

func (RouteTableInputPoliciesState) ElementType() reflect.Type {
	return reflect.TypeOf((*routeTableInputPoliciesState)(nil)).Elem()
}

type routeTableInputPoliciesArgs struct {
	// CCN Instance ID.
	CcnId string `pulumi:"ccnId"`
	// Routing reception strategy.
	Policies []RouteTableInputPoliciesPolicy `pulumi:"policies"`
	// CCN Route table ID.
	RouteTableId string `pulumi:"routeTableId"`
}

// The set of arguments for constructing a RouteTableInputPolicies resource.
type RouteTableInputPoliciesArgs struct {
	// CCN Instance ID.
	CcnId pulumi.StringInput
	// Routing reception strategy.
	Policies RouteTableInputPoliciesPolicyArrayInput
	// CCN Route table ID.
	RouteTableId pulumi.StringInput
}

func (RouteTableInputPoliciesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*routeTableInputPoliciesArgs)(nil)).Elem()
}

type RouteTableInputPoliciesInput interface {
	pulumi.Input

	ToRouteTableInputPoliciesOutput() RouteTableInputPoliciesOutput
	ToRouteTableInputPoliciesOutputWithContext(ctx context.Context) RouteTableInputPoliciesOutput
}

func (*RouteTableInputPolicies) ElementType() reflect.Type {
	return reflect.TypeOf((**RouteTableInputPolicies)(nil)).Elem()
}

func (i *RouteTableInputPolicies) ToRouteTableInputPoliciesOutput() RouteTableInputPoliciesOutput {
	return i.ToRouteTableInputPoliciesOutputWithContext(context.Background())
}

func (i *RouteTableInputPolicies) ToRouteTableInputPoliciesOutputWithContext(ctx context.Context) RouteTableInputPoliciesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteTableInputPoliciesOutput)
}

// RouteTableInputPoliciesArrayInput is an input type that accepts RouteTableInputPoliciesArray and RouteTableInputPoliciesArrayOutput values.
// You can construct a concrete instance of `RouteTableInputPoliciesArrayInput` via:
//
//	RouteTableInputPoliciesArray{ RouteTableInputPoliciesArgs{...} }
type RouteTableInputPoliciesArrayInput interface {
	pulumi.Input

	ToRouteTableInputPoliciesArrayOutput() RouteTableInputPoliciesArrayOutput
	ToRouteTableInputPoliciesArrayOutputWithContext(context.Context) RouteTableInputPoliciesArrayOutput
}

type RouteTableInputPoliciesArray []RouteTableInputPoliciesInput

func (RouteTableInputPoliciesArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RouteTableInputPolicies)(nil)).Elem()
}

func (i RouteTableInputPoliciesArray) ToRouteTableInputPoliciesArrayOutput() RouteTableInputPoliciesArrayOutput {
	return i.ToRouteTableInputPoliciesArrayOutputWithContext(context.Background())
}

func (i RouteTableInputPoliciesArray) ToRouteTableInputPoliciesArrayOutputWithContext(ctx context.Context) RouteTableInputPoliciesArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteTableInputPoliciesArrayOutput)
}

// RouteTableInputPoliciesMapInput is an input type that accepts RouteTableInputPoliciesMap and RouteTableInputPoliciesMapOutput values.
// You can construct a concrete instance of `RouteTableInputPoliciesMapInput` via:
//
//	RouteTableInputPoliciesMap{ "key": RouteTableInputPoliciesArgs{...} }
type RouteTableInputPoliciesMapInput interface {
	pulumi.Input

	ToRouteTableInputPoliciesMapOutput() RouteTableInputPoliciesMapOutput
	ToRouteTableInputPoliciesMapOutputWithContext(context.Context) RouteTableInputPoliciesMapOutput
}

type RouteTableInputPoliciesMap map[string]RouteTableInputPoliciesInput

func (RouteTableInputPoliciesMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RouteTableInputPolicies)(nil)).Elem()
}

func (i RouteTableInputPoliciesMap) ToRouteTableInputPoliciesMapOutput() RouteTableInputPoliciesMapOutput {
	return i.ToRouteTableInputPoliciesMapOutputWithContext(context.Background())
}

func (i RouteTableInputPoliciesMap) ToRouteTableInputPoliciesMapOutputWithContext(ctx context.Context) RouteTableInputPoliciesMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RouteTableInputPoliciesMapOutput)
}

type RouteTableInputPoliciesOutput struct{ *pulumi.OutputState }

func (RouteTableInputPoliciesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RouteTableInputPolicies)(nil)).Elem()
}

func (o RouteTableInputPoliciesOutput) ToRouteTableInputPoliciesOutput() RouteTableInputPoliciesOutput {
	return o
}

func (o RouteTableInputPoliciesOutput) ToRouteTableInputPoliciesOutputWithContext(ctx context.Context) RouteTableInputPoliciesOutput {
	return o
}

// CCN Instance ID.
func (o RouteTableInputPoliciesOutput) CcnId() pulumi.StringOutput {
	return o.ApplyT(func(v *RouteTableInputPolicies) pulumi.StringOutput { return v.CcnId }).(pulumi.StringOutput)
}

// Routing reception strategy.
func (o RouteTableInputPoliciesOutput) Policies() RouteTableInputPoliciesPolicyArrayOutput {
	return o.ApplyT(func(v *RouteTableInputPolicies) RouteTableInputPoliciesPolicyArrayOutput { return v.Policies }).(RouteTableInputPoliciesPolicyArrayOutput)
}

// CCN Route table ID.
func (o RouteTableInputPoliciesOutput) RouteTableId() pulumi.StringOutput {
	return o.ApplyT(func(v *RouteTableInputPolicies) pulumi.StringOutput { return v.RouteTableId }).(pulumi.StringOutput)
}

type RouteTableInputPoliciesArrayOutput struct{ *pulumi.OutputState }

func (RouteTableInputPoliciesArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RouteTableInputPolicies)(nil)).Elem()
}

func (o RouteTableInputPoliciesArrayOutput) ToRouteTableInputPoliciesArrayOutput() RouteTableInputPoliciesArrayOutput {
	return o
}

func (o RouteTableInputPoliciesArrayOutput) ToRouteTableInputPoliciesArrayOutputWithContext(ctx context.Context) RouteTableInputPoliciesArrayOutput {
	return o
}

func (o RouteTableInputPoliciesArrayOutput) Index(i pulumi.IntInput) RouteTableInputPoliciesOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RouteTableInputPolicies {
		return vs[0].([]*RouteTableInputPolicies)[vs[1].(int)]
	}).(RouteTableInputPoliciesOutput)
}

type RouteTableInputPoliciesMapOutput struct{ *pulumi.OutputState }

func (RouteTableInputPoliciesMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RouteTableInputPolicies)(nil)).Elem()
}

func (o RouteTableInputPoliciesMapOutput) ToRouteTableInputPoliciesMapOutput() RouteTableInputPoliciesMapOutput {
	return o
}

func (o RouteTableInputPoliciesMapOutput) ToRouteTableInputPoliciesMapOutputWithContext(ctx context.Context) RouteTableInputPoliciesMapOutput {
	return o
}

func (o RouteTableInputPoliciesMapOutput) MapIndex(k pulumi.StringInput) RouteTableInputPoliciesOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RouteTableInputPolicies {
		return vs[0].(map[string]*RouteTableInputPolicies)[vs[1].(string)]
	}).(RouteTableInputPoliciesOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RouteTableInputPoliciesInput)(nil)).Elem(), &RouteTableInputPolicies{})
	pulumi.RegisterInputType(reflect.TypeOf((*RouteTableInputPoliciesArrayInput)(nil)).Elem(), RouteTableInputPoliciesArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RouteTableInputPoliciesMapInput)(nil)).Elem(), RouteTableInputPoliciesMap{})
	pulumi.RegisterOutputType(RouteTableInputPoliciesOutput{})
	pulumi.RegisterOutputType(RouteTableInputPoliciesArrayOutput{})
	pulumi.RegisterOutputType(RouteTableInputPoliciesMapOutput{})
}
