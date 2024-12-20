// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cynosdb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a cynosdb readOnlyInstanceExclusiveAccess
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cynosdb"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			cfg := config.New(ctx, "")
//			cynosdbClusterId := "default_cynosdb_cluster"
//			if param := cfg.Get("cynosdbClusterId"); param != "" {
//				cynosdbClusterId = param
//			}
//			cynosdbClusterInstanceId := "default_cluster_instance"
//			if param := cfg.Get("cynosdbClusterInstanceId"); param != "" {
//				cynosdbClusterInstanceId = param
//			}
//			cynosdbClusterSecurityGroupId := "default_security_group_id"
//			if param := cfg.Get("cynosdbClusterSecurityGroupId"); param != "" {
//				cynosdbClusterSecurityGroupId = param
//			}
//			gz3, err := Vpc.GetSubnets(ctx, &vpc.GetSubnetsArgs{
//				AvailabilityZone: pulumi.StringRef(_var.Default_az),
//				IsDefault:        pulumi.BoolRef(true),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			vpcId := gz3.InstanceLists[0].VpcId
//			subnetId := gz3.InstanceLists[0].SubnetId
//			_, err = Cynosdb.NewReadOnlyInstanceExclusiveAccess(ctx, "readOnlyInstanceExclusiveAccess", &Cynosdb.ReadOnlyInstanceExclusiveAccessArgs{
//				ClusterId:  pulumi.String(cynosdbClusterId),
//				InstanceId: pulumi.String(cynosdbClusterInstanceId),
//				VpcId:      pulumi.String(vpcId),
//				SubnetId:   pulumi.String(subnetId),
//				Port:       pulumi.Int(1234),
//				SecurityGroupIds: pulumi.StringArray{
//					pulumi.String(cynosdbClusterSecurityGroupId),
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
type ReadOnlyInstanceExclusiveAccess struct {
	pulumi.CustomResourceState

	// Cluster ID.
	ClusterId pulumi.StringOutput `pulumi:"clusterId"`
	// Need to activate a read-only instance ID with unique access.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
	// port.
	Port pulumi.IntOutput `pulumi:"port"`
	// Security Group.
	SecurityGroupIds pulumi.StringArrayOutput `pulumi:"securityGroupIds"`
	// The specified subnet ID.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
	// Specified VPC ID.
	VpcId pulumi.StringOutput `pulumi:"vpcId"`
}

// NewReadOnlyInstanceExclusiveAccess registers a new resource with the given unique name, arguments, and options.
func NewReadOnlyInstanceExclusiveAccess(ctx *pulumi.Context,
	name string, args *ReadOnlyInstanceExclusiveAccessArgs, opts ...pulumi.ResourceOption) (*ReadOnlyInstanceExclusiveAccess, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ClusterId == nil {
		return nil, errors.New("invalid value for required argument 'ClusterId'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	if args.Port == nil {
		return nil, errors.New("invalid value for required argument 'Port'")
	}
	if args.SubnetId == nil {
		return nil, errors.New("invalid value for required argument 'SubnetId'")
	}
	if args.VpcId == nil {
		return nil, errors.New("invalid value for required argument 'VpcId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource ReadOnlyInstanceExclusiveAccess
	err := ctx.RegisterResource("tencentcloud:Cynosdb/readOnlyInstanceExclusiveAccess:ReadOnlyInstanceExclusiveAccess", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetReadOnlyInstanceExclusiveAccess gets an existing ReadOnlyInstanceExclusiveAccess resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetReadOnlyInstanceExclusiveAccess(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ReadOnlyInstanceExclusiveAccessState, opts ...pulumi.ResourceOption) (*ReadOnlyInstanceExclusiveAccess, error) {
	var resource ReadOnlyInstanceExclusiveAccess
	err := ctx.ReadResource("tencentcloud:Cynosdb/readOnlyInstanceExclusiveAccess:ReadOnlyInstanceExclusiveAccess", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ReadOnlyInstanceExclusiveAccess resources.
type readOnlyInstanceExclusiveAccessState struct {
	// Cluster ID.
	ClusterId *string `pulumi:"clusterId"`
	// Need to activate a read-only instance ID with unique access.
	InstanceId *string `pulumi:"instanceId"`
	// port.
	Port *int `pulumi:"port"`
	// Security Group.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// The specified subnet ID.
	SubnetId *string `pulumi:"subnetId"`
	// Specified VPC ID.
	VpcId *string `pulumi:"vpcId"`
}

type ReadOnlyInstanceExclusiveAccessState struct {
	// Cluster ID.
	ClusterId pulumi.StringPtrInput
	// Need to activate a read-only instance ID with unique access.
	InstanceId pulumi.StringPtrInput
	// port.
	Port pulumi.IntPtrInput
	// Security Group.
	SecurityGroupIds pulumi.StringArrayInput
	// The specified subnet ID.
	SubnetId pulumi.StringPtrInput
	// Specified VPC ID.
	VpcId pulumi.StringPtrInput
}

func (ReadOnlyInstanceExclusiveAccessState) ElementType() reflect.Type {
	return reflect.TypeOf((*readOnlyInstanceExclusiveAccessState)(nil)).Elem()
}

type readOnlyInstanceExclusiveAccessArgs struct {
	// Cluster ID.
	ClusterId string `pulumi:"clusterId"`
	// Need to activate a read-only instance ID with unique access.
	InstanceId string `pulumi:"instanceId"`
	// port.
	Port int `pulumi:"port"`
	// Security Group.
	SecurityGroupIds []string `pulumi:"securityGroupIds"`
	// The specified subnet ID.
	SubnetId string `pulumi:"subnetId"`
	// Specified VPC ID.
	VpcId string `pulumi:"vpcId"`
}

// The set of arguments for constructing a ReadOnlyInstanceExclusiveAccess resource.
type ReadOnlyInstanceExclusiveAccessArgs struct {
	// Cluster ID.
	ClusterId pulumi.StringInput
	// Need to activate a read-only instance ID with unique access.
	InstanceId pulumi.StringInput
	// port.
	Port pulumi.IntInput
	// Security Group.
	SecurityGroupIds pulumi.StringArrayInput
	// The specified subnet ID.
	SubnetId pulumi.StringInput
	// Specified VPC ID.
	VpcId pulumi.StringInput
}

func (ReadOnlyInstanceExclusiveAccessArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*readOnlyInstanceExclusiveAccessArgs)(nil)).Elem()
}

type ReadOnlyInstanceExclusiveAccessInput interface {
	pulumi.Input

	ToReadOnlyInstanceExclusiveAccessOutput() ReadOnlyInstanceExclusiveAccessOutput
	ToReadOnlyInstanceExclusiveAccessOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessOutput
}

func (*ReadOnlyInstanceExclusiveAccess) ElementType() reflect.Type {
	return reflect.TypeOf((**ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (i *ReadOnlyInstanceExclusiveAccess) ToReadOnlyInstanceExclusiveAccessOutput() ReadOnlyInstanceExclusiveAccessOutput {
	return i.ToReadOnlyInstanceExclusiveAccessOutputWithContext(context.Background())
}

func (i *ReadOnlyInstanceExclusiveAccess) ToReadOnlyInstanceExclusiveAccessOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReadOnlyInstanceExclusiveAccessOutput)
}

// ReadOnlyInstanceExclusiveAccessArrayInput is an input type that accepts ReadOnlyInstanceExclusiveAccessArray and ReadOnlyInstanceExclusiveAccessArrayOutput values.
// You can construct a concrete instance of `ReadOnlyInstanceExclusiveAccessArrayInput` via:
//
//	ReadOnlyInstanceExclusiveAccessArray{ ReadOnlyInstanceExclusiveAccessArgs{...} }
type ReadOnlyInstanceExclusiveAccessArrayInput interface {
	pulumi.Input

	ToReadOnlyInstanceExclusiveAccessArrayOutput() ReadOnlyInstanceExclusiveAccessArrayOutput
	ToReadOnlyInstanceExclusiveAccessArrayOutputWithContext(context.Context) ReadOnlyInstanceExclusiveAccessArrayOutput
}

type ReadOnlyInstanceExclusiveAccessArray []ReadOnlyInstanceExclusiveAccessInput

func (ReadOnlyInstanceExclusiveAccessArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (i ReadOnlyInstanceExclusiveAccessArray) ToReadOnlyInstanceExclusiveAccessArrayOutput() ReadOnlyInstanceExclusiveAccessArrayOutput {
	return i.ToReadOnlyInstanceExclusiveAccessArrayOutputWithContext(context.Background())
}

func (i ReadOnlyInstanceExclusiveAccessArray) ToReadOnlyInstanceExclusiveAccessArrayOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReadOnlyInstanceExclusiveAccessArrayOutput)
}

// ReadOnlyInstanceExclusiveAccessMapInput is an input type that accepts ReadOnlyInstanceExclusiveAccessMap and ReadOnlyInstanceExclusiveAccessMapOutput values.
// You can construct a concrete instance of `ReadOnlyInstanceExclusiveAccessMapInput` via:
//
//	ReadOnlyInstanceExclusiveAccessMap{ "key": ReadOnlyInstanceExclusiveAccessArgs{...} }
type ReadOnlyInstanceExclusiveAccessMapInput interface {
	pulumi.Input

	ToReadOnlyInstanceExclusiveAccessMapOutput() ReadOnlyInstanceExclusiveAccessMapOutput
	ToReadOnlyInstanceExclusiveAccessMapOutputWithContext(context.Context) ReadOnlyInstanceExclusiveAccessMapOutput
}

type ReadOnlyInstanceExclusiveAccessMap map[string]ReadOnlyInstanceExclusiveAccessInput

func (ReadOnlyInstanceExclusiveAccessMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (i ReadOnlyInstanceExclusiveAccessMap) ToReadOnlyInstanceExclusiveAccessMapOutput() ReadOnlyInstanceExclusiveAccessMapOutput {
	return i.ToReadOnlyInstanceExclusiveAccessMapOutputWithContext(context.Background())
}

func (i ReadOnlyInstanceExclusiveAccessMap) ToReadOnlyInstanceExclusiveAccessMapOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ReadOnlyInstanceExclusiveAccessMapOutput)
}

type ReadOnlyInstanceExclusiveAccessOutput struct{ *pulumi.OutputState }

func (ReadOnlyInstanceExclusiveAccessOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (o ReadOnlyInstanceExclusiveAccessOutput) ToReadOnlyInstanceExclusiveAccessOutput() ReadOnlyInstanceExclusiveAccessOutput {
	return o
}

func (o ReadOnlyInstanceExclusiveAccessOutput) ToReadOnlyInstanceExclusiveAccessOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessOutput {
	return o
}

// Cluster ID.
func (o ReadOnlyInstanceExclusiveAccessOutput) ClusterId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.StringOutput { return v.ClusterId }).(pulumi.StringOutput)
}

// Need to activate a read-only instance ID with unique access.
func (o ReadOnlyInstanceExclusiveAccessOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

// port.
func (o ReadOnlyInstanceExclusiveAccessOutput) Port() pulumi.IntOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.IntOutput { return v.Port }).(pulumi.IntOutput)
}

// Security Group.
func (o ReadOnlyInstanceExclusiveAccessOutput) SecurityGroupIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.StringArrayOutput { return v.SecurityGroupIds }).(pulumi.StringArrayOutput)
}

// The specified subnet ID.
func (o ReadOnlyInstanceExclusiveAccessOutput) SubnetId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.StringOutput { return v.SubnetId }).(pulumi.StringOutput)
}

// Specified VPC ID.
func (o ReadOnlyInstanceExclusiveAccessOutput) VpcId() pulumi.StringOutput {
	return o.ApplyT(func(v *ReadOnlyInstanceExclusiveAccess) pulumi.StringOutput { return v.VpcId }).(pulumi.StringOutput)
}

type ReadOnlyInstanceExclusiveAccessArrayOutput struct{ *pulumi.OutputState }

func (ReadOnlyInstanceExclusiveAccessArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (o ReadOnlyInstanceExclusiveAccessArrayOutput) ToReadOnlyInstanceExclusiveAccessArrayOutput() ReadOnlyInstanceExclusiveAccessArrayOutput {
	return o
}

func (o ReadOnlyInstanceExclusiveAccessArrayOutput) ToReadOnlyInstanceExclusiveAccessArrayOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessArrayOutput {
	return o
}

func (o ReadOnlyInstanceExclusiveAccessArrayOutput) Index(i pulumi.IntInput) ReadOnlyInstanceExclusiveAccessOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *ReadOnlyInstanceExclusiveAccess {
		return vs[0].([]*ReadOnlyInstanceExclusiveAccess)[vs[1].(int)]
	}).(ReadOnlyInstanceExclusiveAccessOutput)
}

type ReadOnlyInstanceExclusiveAccessMapOutput struct{ *pulumi.OutputState }

func (ReadOnlyInstanceExclusiveAccessMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*ReadOnlyInstanceExclusiveAccess)(nil)).Elem()
}

func (o ReadOnlyInstanceExclusiveAccessMapOutput) ToReadOnlyInstanceExclusiveAccessMapOutput() ReadOnlyInstanceExclusiveAccessMapOutput {
	return o
}

func (o ReadOnlyInstanceExclusiveAccessMapOutput) ToReadOnlyInstanceExclusiveAccessMapOutputWithContext(ctx context.Context) ReadOnlyInstanceExclusiveAccessMapOutput {
	return o
}

func (o ReadOnlyInstanceExclusiveAccessMapOutput) MapIndex(k pulumi.StringInput) ReadOnlyInstanceExclusiveAccessOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *ReadOnlyInstanceExclusiveAccess {
		return vs[0].(map[string]*ReadOnlyInstanceExclusiveAccess)[vs[1].(string)]
	}).(ReadOnlyInstanceExclusiveAccessOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ReadOnlyInstanceExclusiveAccessInput)(nil)).Elem(), &ReadOnlyInstanceExclusiveAccess{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReadOnlyInstanceExclusiveAccessArrayInput)(nil)).Elem(), ReadOnlyInstanceExclusiveAccessArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ReadOnlyInstanceExclusiveAccessMapInput)(nil)).Elem(), ReadOnlyInstanceExclusiveAccessMap{})
	pulumi.RegisterOutputType(ReadOnlyInstanceExclusiveAccessOutput{})
	pulumi.RegisterOutputType(ReadOnlyInstanceExclusiveAccessArrayOutput{})
	pulumi.RegisterOutputType(ReadOnlyInstanceExclusiveAccessMapOutput{})
}
