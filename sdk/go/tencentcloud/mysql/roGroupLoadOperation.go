// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mysql roGroupLoadOperation
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Availability"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Security"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Subnet"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Vpc"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			zones, err := Availability.GetZonesByProduct(ctx, &availability.GetZonesByProductArgs{
//				Product: "cdb",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			exampleInstance, err := Mysql.GetInstance(ctx, &mysql.GetInstanceArgs{
//				MysqlId: pulumi.StringRef(exampleMysql / instanceInstance.Id),
//			}, nil)
//			if err != nil {
//				return err
//			}
//			vpc, err := Vpc.NewInstance(ctx, "vpc", &Vpc.InstanceArgs{
//				CidrBlock: pulumi.String("10.0.0.0/16"),
//			})
//			if err != nil {
//				return err
//			}
//			subnet, err := Subnet.NewInstance(ctx, "subnet", &Subnet.InstanceArgs{
//				AvailabilityZone: pulumi.String(zones.Zones[1].Name),
//				VpcId:            vpc.ID(),
//				CidrBlock:        pulumi.String("10.0.0.0/16"),
//				IsMulticast:      pulumi.Bool(false),
//			})
//			if err != nil {
//				return err
//			}
//			securityGroup, err := Security.NewGroup(ctx, "securityGroup", &Security.GroupArgs{
//				Description: pulumi.String("mysql test"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mysql.NewInstance(ctx, "exampleMysql/instanceInstance", &Mysql.InstanceArgs{
//				InternetService:  pulumi.Int(1),
//				EngineVersion:    pulumi.String("5.7"),
//				ChargeType:       pulumi.String("POSTPAID"),
//				RootPassword:     pulumi.String("PassWord123"),
//				SlaveDeployMode:  pulumi.Int(0),
//				AvailabilityZone: pulumi.String(zones.Zones[1].Name),
//				SlaveSyncMode:    pulumi.Int(1),
//				InstanceName:     pulumi.String("tf-example-mysql"),
//				MemSize:          pulumi.Int(4000),
//				VolumeSize:       pulumi.Int(200),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				IntranetPort:     pulumi.Int(3306),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				Tags: pulumi.Map{
//					"name": pulumi.Any("test"),
//				},
//				Parameters: pulumi.Map{
//					"character_set_server": pulumi.Any("utf8"),
//					"max_connections":      pulumi.Any("1000"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mysql.NewReadonlyInstance(ctx, "exampleReadonlyInstance", &Mysql.ReadonlyInstanceArgs{
//				MasterInstanceId: exampleMysql / instanceInstance.Id,
//				InstanceName:     pulumi.String("tf-mysql"),
//				MemSize:          pulumi.Int(2000),
//				VolumeSize:       pulumi.Int(200),
//				VpcId:            vpc.ID(),
//				SubnetId:         subnet.ID(),
//				IntranetPort:     pulumi.Int(3306),
//				SecurityGroups: pulumi.StringArray{
//					securityGroup.ID(),
//				},
//				Tags: pulumi.Map{
//					"createBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mysql.NewRoGroupLoadOperation(ctx, "roGroupLoadOperation", &Mysql.RoGroupLoadOperationArgs{
//				RoGroupId: pulumi.String(exampleInstance.InstanceLists[0].RoGroups[0].GroupId),
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
type RoGroupLoadOperation struct {
	pulumi.CustomResourceState

	// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
	RoGroupId pulumi.StringOutput `pulumi:"roGroupId"`
}

// NewRoGroupLoadOperation registers a new resource with the given unique name, arguments, and options.
func NewRoGroupLoadOperation(ctx *pulumi.Context,
	name string, args *RoGroupLoadOperationArgs, opts ...pulumi.ResourceOption) (*RoGroupLoadOperation, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.RoGroupId == nil {
		return nil, errors.New("invalid value for required argument 'RoGroupId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource RoGroupLoadOperation
	err := ctx.RegisterResource("tencentcloud:Mysql/roGroupLoadOperation:RoGroupLoadOperation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRoGroupLoadOperation gets an existing RoGroupLoadOperation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRoGroupLoadOperation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RoGroupLoadOperationState, opts ...pulumi.ResourceOption) (*RoGroupLoadOperation, error) {
	var resource RoGroupLoadOperation
	err := ctx.ReadResource("tencentcloud:Mysql/roGroupLoadOperation:RoGroupLoadOperation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RoGroupLoadOperation resources.
type roGroupLoadOperationState struct {
	// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
	RoGroupId *string `pulumi:"roGroupId"`
}

type RoGroupLoadOperationState struct {
	// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
	RoGroupId pulumi.StringPtrInput
}

func (RoGroupLoadOperationState) ElementType() reflect.Type {
	return reflect.TypeOf((*roGroupLoadOperationState)(nil)).Elem()
}

type roGroupLoadOperationArgs struct {
	// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
	RoGroupId string `pulumi:"roGroupId"`
}

// The set of arguments for constructing a RoGroupLoadOperation resource.
type RoGroupLoadOperationArgs struct {
	// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
	RoGroupId pulumi.StringInput
}

func (RoGroupLoadOperationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*roGroupLoadOperationArgs)(nil)).Elem()
}

type RoGroupLoadOperationInput interface {
	pulumi.Input

	ToRoGroupLoadOperationOutput() RoGroupLoadOperationOutput
	ToRoGroupLoadOperationOutputWithContext(ctx context.Context) RoGroupLoadOperationOutput
}

func (*RoGroupLoadOperation) ElementType() reflect.Type {
	return reflect.TypeOf((**RoGroupLoadOperation)(nil)).Elem()
}

func (i *RoGroupLoadOperation) ToRoGroupLoadOperationOutput() RoGroupLoadOperationOutput {
	return i.ToRoGroupLoadOperationOutputWithContext(context.Background())
}

func (i *RoGroupLoadOperation) ToRoGroupLoadOperationOutputWithContext(ctx context.Context) RoGroupLoadOperationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoGroupLoadOperationOutput)
}

// RoGroupLoadOperationArrayInput is an input type that accepts RoGroupLoadOperationArray and RoGroupLoadOperationArrayOutput values.
// You can construct a concrete instance of `RoGroupLoadOperationArrayInput` via:
//
//	RoGroupLoadOperationArray{ RoGroupLoadOperationArgs{...} }
type RoGroupLoadOperationArrayInput interface {
	pulumi.Input

	ToRoGroupLoadOperationArrayOutput() RoGroupLoadOperationArrayOutput
	ToRoGroupLoadOperationArrayOutputWithContext(context.Context) RoGroupLoadOperationArrayOutput
}

type RoGroupLoadOperationArray []RoGroupLoadOperationInput

func (RoGroupLoadOperationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RoGroupLoadOperation)(nil)).Elem()
}

func (i RoGroupLoadOperationArray) ToRoGroupLoadOperationArrayOutput() RoGroupLoadOperationArrayOutput {
	return i.ToRoGroupLoadOperationArrayOutputWithContext(context.Background())
}

func (i RoGroupLoadOperationArray) ToRoGroupLoadOperationArrayOutputWithContext(ctx context.Context) RoGroupLoadOperationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoGroupLoadOperationArrayOutput)
}

// RoGroupLoadOperationMapInput is an input type that accepts RoGroupLoadOperationMap and RoGroupLoadOperationMapOutput values.
// You can construct a concrete instance of `RoGroupLoadOperationMapInput` via:
//
//	RoGroupLoadOperationMap{ "key": RoGroupLoadOperationArgs{...} }
type RoGroupLoadOperationMapInput interface {
	pulumi.Input

	ToRoGroupLoadOperationMapOutput() RoGroupLoadOperationMapOutput
	ToRoGroupLoadOperationMapOutputWithContext(context.Context) RoGroupLoadOperationMapOutput
}

type RoGroupLoadOperationMap map[string]RoGroupLoadOperationInput

func (RoGroupLoadOperationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RoGroupLoadOperation)(nil)).Elem()
}

func (i RoGroupLoadOperationMap) ToRoGroupLoadOperationMapOutput() RoGroupLoadOperationMapOutput {
	return i.ToRoGroupLoadOperationMapOutputWithContext(context.Background())
}

func (i RoGroupLoadOperationMap) ToRoGroupLoadOperationMapOutputWithContext(ctx context.Context) RoGroupLoadOperationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(RoGroupLoadOperationMapOutput)
}

type RoGroupLoadOperationOutput struct{ *pulumi.OutputState }

func (RoGroupLoadOperationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**RoGroupLoadOperation)(nil)).Elem()
}

func (o RoGroupLoadOperationOutput) ToRoGroupLoadOperationOutput() RoGroupLoadOperationOutput {
	return o
}

func (o RoGroupLoadOperationOutput) ToRoGroupLoadOperationOutputWithContext(ctx context.Context) RoGroupLoadOperationOutput {
	return o
}

// The ID of the RO group, in the format: cdbrg-c1nl9rpv.
func (o RoGroupLoadOperationOutput) RoGroupId() pulumi.StringOutput {
	return o.ApplyT(func(v *RoGroupLoadOperation) pulumi.StringOutput { return v.RoGroupId }).(pulumi.StringOutput)
}

type RoGroupLoadOperationArrayOutput struct{ *pulumi.OutputState }

func (RoGroupLoadOperationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*RoGroupLoadOperation)(nil)).Elem()
}

func (o RoGroupLoadOperationArrayOutput) ToRoGroupLoadOperationArrayOutput() RoGroupLoadOperationArrayOutput {
	return o
}

func (o RoGroupLoadOperationArrayOutput) ToRoGroupLoadOperationArrayOutputWithContext(ctx context.Context) RoGroupLoadOperationArrayOutput {
	return o
}

func (o RoGroupLoadOperationArrayOutput) Index(i pulumi.IntInput) RoGroupLoadOperationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *RoGroupLoadOperation {
		return vs[0].([]*RoGroupLoadOperation)[vs[1].(int)]
	}).(RoGroupLoadOperationOutput)
}

type RoGroupLoadOperationMapOutput struct{ *pulumi.OutputState }

func (RoGroupLoadOperationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*RoGroupLoadOperation)(nil)).Elem()
}

func (o RoGroupLoadOperationMapOutput) ToRoGroupLoadOperationMapOutput() RoGroupLoadOperationMapOutput {
	return o
}

func (o RoGroupLoadOperationMapOutput) ToRoGroupLoadOperationMapOutputWithContext(ctx context.Context) RoGroupLoadOperationMapOutput {
	return o
}

func (o RoGroupLoadOperationMapOutput) MapIndex(k pulumi.StringInput) RoGroupLoadOperationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *RoGroupLoadOperation {
		return vs[0].(map[string]*RoGroupLoadOperation)[vs[1].(string)]
	}).(RoGroupLoadOperationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*RoGroupLoadOperationInput)(nil)).Elem(), &RoGroupLoadOperation{})
	pulumi.RegisterInputType(reflect.TypeOf((*RoGroupLoadOperationArrayInput)(nil)).Elem(), RoGroupLoadOperationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*RoGroupLoadOperationMapInput)(nil)).Elem(), RoGroupLoadOperationMap{})
	pulumi.RegisterOutputType(RoGroupLoadOperationOutput{})
	pulumi.RegisterOutputType(RoGroupLoadOperationArrayOutput{})
	pulumi.RegisterOutputType(RoGroupLoadOperationMapOutput{})
}
