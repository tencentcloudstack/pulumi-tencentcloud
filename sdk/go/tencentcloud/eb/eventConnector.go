// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package eb

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a eb eventConnector
//
// > **NOTE:** When the type is `apigw`, the import function is not supported.
//
// ## Example Usage
//
// ### Create ckafka event connector
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"fmt"
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ckafka"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eb"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/User"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			fooInfo, err := User.GetInfo(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			fooEventBus, err := Eb.NewEventBus(ctx, "fooEventBus", &Eb.EventBusArgs{
//				EventBusName: pulumi.String("tf-event_bus"),
//				Description:  pulumi.String("event bus desc"),
//				EnableStore:  pulumi.Bool(false),
//				SaveDays:     pulumi.Int(1),
//				Tags: pulumi.Map{
//					"createdBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			kafkaInstance, err := Ckafka.NewInstance(ctx, "kafkaInstance", &Ckafka.InstanceArgs{
//				InstanceName:  pulumi.String("ckafka-instance-maz-tf-test"),
//				ZoneId:        pulumi.Int(100003),
//				MultiZoneFlag: pulumi.Bool(true),
//				ZoneIds: pulumi.IntArray{
//					pulumi.Int(100003),
//					pulumi.Int(100006),
//				},
//				Period:           pulumi.Int(1),
//				VpcId:            pulumi.Any(_var.Vpc_id),
//				SubnetId:         pulumi.Any(_var.Subnet_id),
//				MsgRetentionTime: pulumi.Int(1300),
//				RenewFlag:        pulumi.Int(0),
//				KafkaVersion:     pulumi.String("1.1.1"),
//				DiskSize:         pulumi.Int(500),
//				DiskType:         pulumi.String("CLOUD_BASIC"),
//				Config: &ckafka.InstanceConfigArgs{
//					AutoCreateTopicEnable:    pulumi.Bool(true),
//					DefaultNumPartitions:     pulumi.Int(3),
//					DefaultReplicationFactor: pulumi.Int(3),
//				},
//				DynamicRetentionConfig: &ckafka.InstanceDynamicRetentionConfigArgs{
//					Enable: pulumi.Int(1),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			ckafkaId := kafkaInstance.ID()
//			uin := fooInfo.OwnerUin
//			_, err = Eb.NewEventConnector(ctx, "eventConnector", &Eb.EventConnectorArgs{
//				EventBusId:     fooEventBus.ID(),
//				ConnectionName: pulumi.String("tf-event-connector"),
//				Description:    pulumi.String("event connector desc1"),
//				Enable:         pulumi.Bool(true),
//				Type:           pulumi.String("ckafka"),
//				ConnectionDescription: &eb.EventConnectorConnectionDescriptionArgs{
//					ResourceDescription: ckafkaId.ApplyT(func(ckafkaId string) (string, error) {
//						return fmt.Sprintf("qcs::ckafka:ap-guangzhou:uin/%v:ckafkaId/uin/%v/%v", uin, uin, ckafkaId), nil
//					}).(pulumi.StringOutput),
//					CkafkaParams: &eb.EventConnectorConnectionDescriptionCkafkaParamsArgs{
//						Offset:    pulumi.String("latest"),
//						TopicName: pulumi.String("dasdasd"),
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
// ### Create apiGateway event connector
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"fmt"
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/ApiGateway"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Eb"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/User"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			fooInfo, err := User.GetInfo(ctx, nil, nil)
//			if err != nil {
//				return err
//			}
//			fooEventBus, err := Eb.NewEventBus(ctx, "fooEventBus", &Eb.EventBusArgs{
//				EventBusName: pulumi.String("tf-event_bus"),
//				Description:  pulumi.String("event bus desc"),
//				EnableStore:  pulumi.Bool(false),
//				SaveDays:     pulumi.Int(1),
//				Tags: pulumi.Map{
//					"createdBy": pulumi.Any("terraform"),
//				},
//			})
//			if err != nil {
//				return err
//			}
//			service, err := ApiGateway.NewService(ctx, "service", &ApiGateway.ServiceArgs{
//				ServiceName: pulumi.String("tf-eb-service"),
//				Protocol:    pulumi.String("http&https"),
//				ServiceDesc: pulumi.String("your nice service"),
//				NetTypes: pulumi.StringArray{
//					pulumi.String("INNER"),
//					pulumi.String("OUTER"),
//				},
//				IpVersion: pulumi.String("IPv4"),
//			})
//			if err != nil {
//				return err
//			}
//			uin := fooInfo.OwnerUin
//			serviceId := service.ID()
//			_, err = Eb.NewEventConnector(ctx, "eventConnector", &Eb.EventConnectorArgs{
//				EventBusId:     fooEventBus.ID(),
//				ConnectionName: pulumi.String("tf-event-connector"),
//				Description:    pulumi.String("event connector desc1"),
//				Enable:         pulumi.Bool(false),
//				Type:           pulumi.String("apigw"),
//				ConnectionDescription: &eb.EventConnectorConnectionDescriptionArgs{
//					ResourceDescription: serviceId.ApplyT(func(serviceId string) (string, error) {
//						return fmt.Sprintf("qcs::apigw:ap-guangzhou:uin/%v:serviceid/%v", uin, serviceId), nil
//					}).(pulumi.StringOutput),
//					ApiGwParams: &eb.EventConnectorConnectionDescriptionApiGwParamsArgs{
//						Protocol: pulumi.String("HTTP"),
//						Method:   pulumi.String("GET"),
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
// eb event_connector can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Eb/eventConnector:EventConnector event_connector eventBusId#connectionId
// ```
type EventConnector struct {
	pulumi.CustomResourceState

	// Connector description.
	ConnectionDescription EventConnectorConnectionDescriptionOutput `pulumi:"connectionDescription"`
	// connector name.
	ConnectionName pulumi.StringOutput `pulumi:"connectionName"`
	// description.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// switch.
	Enable pulumi.BoolPtrOutput `pulumi:"enable"`
	// event bus Id.
	EventBusId pulumi.StringOutput `pulumi:"eventBusId"`
	// type.
	Type pulumi.StringPtrOutput `pulumi:"type"`
}

// NewEventConnector registers a new resource with the given unique name, arguments, and options.
func NewEventConnector(ctx *pulumi.Context,
	name string, args *EventConnectorArgs, opts ...pulumi.ResourceOption) (*EventConnector, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ConnectionDescription == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionDescription'")
	}
	if args.ConnectionName == nil {
		return nil, errors.New("invalid value for required argument 'ConnectionName'")
	}
	if args.EventBusId == nil {
		return nil, errors.New("invalid value for required argument 'EventBusId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource EventConnector
	err := ctx.RegisterResource("tencentcloud:Eb/eventConnector:EventConnector", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEventConnector gets an existing EventConnector resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEventConnector(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EventConnectorState, opts ...pulumi.ResourceOption) (*EventConnector, error) {
	var resource EventConnector
	err := ctx.ReadResource("tencentcloud:Eb/eventConnector:EventConnector", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EventConnector resources.
type eventConnectorState struct {
	// Connector description.
	ConnectionDescription *EventConnectorConnectionDescription `pulumi:"connectionDescription"`
	// connector name.
	ConnectionName *string `pulumi:"connectionName"`
	// description.
	Description *string `pulumi:"description"`
	// switch.
	Enable *bool `pulumi:"enable"`
	// event bus Id.
	EventBusId *string `pulumi:"eventBusId"`
	// type.
	Type *string `pulumi:"type"`
}

type EventConnectorState struct {
	// Connector description.
	ConnectionDescription EventConnectorConnectionDescriptionPtrInput
	// connector name.
	ConnectionName pulumi.StringPtrInput
	// description.
	Description pulumi.StringPtrInput
	// switch.
	Enable pulumi.BoolPtrInput
	// event bus Id.
	EventBusId pulumi.StringPtrInput
	// type.
	Type pulumi.StringPtrInput
}

func (EventConnectorState) ElementType() reflect.Type {
	return reflect.TypeOf((*eventConnectorState)(nil)).Elem()
}

type eventConnectorArgs struct {
	// Connector description.
	ConnectionDescription EventConnectorConnectionDescription `pulumi:"connectionDescription"`
	// connector name.
	ConnectionName string `pulumi:"connectionName"`
	// description.
	Description *string `pulumi:"description"`
	// switch.
	Enable *bool `pulumi:"enable"`
	// event bus Id.
	EventBusId string `pulumi:"eventBusId"`
	// type.
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a EventConnector resource.
type EventConnectorArgs struct {
	// Connector description.
	ConnectionDescription EventConnectorConnectionDescriptionInput
	// connector name.
	ConnectionName pulumi.StringInput
	// description.
	Description pulumi.StringPtrInput
	// switch.
	Enable pulumi.BoolPtrInput
	// event bus Id.
	EventBusId pulumi.StringInput
	// type.
	Type pulumi.StringPtrInput
}

func (EventConnectorArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*eventConnectorArgs)(nil)).Elem()
}

type EventConnectorInput interface {
	pulumi.Input

	ToEventConnectorOutput() EventConnectorOutput
	ToEventConnectorOutputWithContext(ctx context.Context) EventConnectorOutput
}

func (*EventConnector) ElementType() reflect.Type {
	return reflect.TypeOf((**EventConnector)(nil)).Elem()
}

func (i *EventConnector) ToEventConnectorOutput() EventConnectorOutput {
	return i.ToEventConnectorOutputWithContext(context.Background())
}

func (i *EventConnector) ToEventConnectorOutputWithContext(ctx context.Context) EventConnectorOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventConnectorOutput)
}

// EventConnectorArrayInput is an input type that accepts EventConnectorArray and EventConnectorArrayOutput values.
// You can construct a concrete instance of `EventConnectorArrayInput` via:
//
//	EventConnectorArray{ EventConnectorArgs{...} }
type EventConnectorArrayInput interface {
	pulumi.Input

	ToEventConnectorArrayOutput() EventConnectorArrayOutput
	ToEventConnectorArrayOutputWithContext(context.Context) EventConnectorArrayOutput
}

type EventConnectorArray []EventConnectorInput

func (EventConnectorArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventConnector)(nil)).Elem()
}

func (i EventConnectorArray) ToEventConnectorArrayOutput() EventConnectorArrayOutput {
	return i.ToEventConnectorArrayOutputWithContext(context.Background())
}

func (i EventConnectorArray) ToEventConnectorArrayOutputWithContext(ctx context.Context) EventConnectorArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventConnectorArrayOutput)
}

// EventConnectorMapInput is an input type that accepts EventConnectorMap and EventConnectorMapOutput values.
// You can construct a concrete instance of `EventConnectorMapInput` via:
//
//	EventConnectorMap{ "key": EventConnectorArgs{...} }
type EventConnectorMapInput interface {
	pulumi.Input

	ToEventConnectorMapOutput() EventConnectorMapOutput
	ToEventConnectorMapOutputWithContext(context.Context) EventConnectorMapOutput
}

type EventConnectorMap map[string]EventConnectorInput

func (EventConnectorMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventConnector)(nil)).Elem()
}

func (i EventConnectorMap) ToEventConnectorMapOutput() EventConnectorMapOutput {
	return i.ToEventConnectorMapOutputWithContext(context.Background())
}

func (i EventConnectorMap) ToEventConnectorMapOutputWithContext(ctx context.Context) EventConnectorMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EventConnectorMapOutput)
}

type EventConnectorOutput struct{ *pulumi.OutputState }

func (EventConnectorOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**EventConnector)(nil)).Elem()
}

func (o EventConnectorOutput) ToEventConnectorOutput() EventConnectorOutput {
	return o
}

func (o EventConnectorOutput) ToEventConnectorOutputWithContext(ctx context.Context) EventConnectorOutput {
	return o
}

// Connector description.
func (o EventConnectorOutput) ConnectionDescription() EventConnectorConnectionDescriptionOutput {
	return o.ApplyT(func(v *EventConnector) EventConnectorConnectionDescriptionOutput { return v.ConnectionDescription }).(EventConnectorConnectionDescriptionOutput)
}

// connector name.
func (o EventConnectorOutput) ConnectionName() pulumi.StringOutput {
	return o.ApplyT(func(v *EventConnector) pulumi.StringOutput { return v.ConnectionName }).(pulumi.StringOutput)
}

// description.
func (o EventConnectorOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventConnector) pulumi.StringPtrOutput { return v.Description }).(pulumi.StringPtrOutput)
}

// switch.
func (o EventConnectorOutput) Enable() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *EventConnector) pulumi.BoolPtrOutput { return v.Enable }).(pulumi.BoolPtrOutput)
}

// event bus Id.
func (o EventConnectorOutput) EventBusId() pulumi.StringOutput {
	return o.ApplyT(func(v *EventConnector) pulumi.StringOutput { return v.EventBusId }).(pulumi.StringOutput)
}

// type.
func (o EventConnectorOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *EventConnector) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

type EventConnectorArrayOutput struct{ *pulumi.OutputState }

func (EventConnectorArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*EventConnector)(nil)).Elem()
}

func (o EventConnectorArrayOutput) ToEventConnectorArrayOutput() EventConnectorArrayOutput {
	return o
}

func (o EventConnectorArrayOutput) ToEventConnectorArrayOutputWithContext(ctx context.Context) EventConnectorArrayOutput {
	return o
}

func (o EventConnectorArrayOutput) Index(i pulumi.IntInput) EventConnectorOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *EventConnector {
		return vs[0].([]*EventConnector)[vs[1].(int)]
	}).(EventConnectorOutput)
}

type EventConnectorMapOutput struct{ *pulumi.OutputState }

func (EventConnectorMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*EventConnector)(nil)).Elem()
}

func (o EventConnectorMapOutput) ToEventConnectorMapOutput() EventConnectorMapOutput {
	return o
}

func (o EventConnectorMapOutput) ToEventConnectorMapOutputWithContext(ctx context.Context) EventConnectorMapOutput {
	return o
}

func (o EventConnectorMapOutput) MapIndex(k pulumi.StringInput) EventConnectorOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *EventConnector {
		return vs[0].(map[string]*EventConnector)[vs[1].(string)]
	}).(EventConnectorOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*EventConnectorInput)(nil)).Elem(), &EventConnector{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventConnectorArrayInput)(nil)).Elem(), EventConnectorArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*EventConnectorMapInput)(nil)).Elem(), EventConnectorMap{})
	pulumi.RegisterOutputType(EventConnectorOutput{})
	pulumi.RegisterOutputType(EventConnectorArrayOutput{})
	pulumi.RegisterOutputType(EventConnectorMapOutput{})
}
