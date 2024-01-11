// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package cls

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Provides a resource to create a cls dataTransform
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Cls"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cls"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		logsetSrc, err := Cls.NewLogset(ctx, "logsetSrc", &Cls.LogsetArgs{
// 			LogsetName: pulumi.String("tf-example-src"),
// 			Tags: pulumi.AnyMap{
// 				"createdBy": pulumi.Any("terraform"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		topicSrc, err := Cls.NewTopic(ctx, "topicSrc", &Cls.TopicArgs{
// 			TopicName:          pulumi.String("tf-example_src"),
// 			LogsetId:           logsetSrc.ID(),
// 			AutoSplit:          pulumi.Bool(false),
// 			MaxSplitPartitions: pulumi.Int(20),
// 			PartitionCount:     pulumi.Int(1),
// 			Period:             pulumi.Int(10),
// 			StorageType:        pulumi.String("hot"),
// 			Tags: pulumi.AnyMap{
// 				"test": pulumi.Any("test"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		logsetDst, err := Cls.NewLogset(ctx, "logsetDst", &Cls.LogsetArgs{
// 			LogsetName: pulumi.String("tf-example-dst"),
// 			Tags: pulumi.AnyMap{
// 				"createdBy": pulumi.Any("terraform"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		topicDst, err := Cls.NewTopic(ctx, "topicDst", &Cls.TopicArgs{
// 			TopicName:          pulumi.String("tf-example-dst"),
// 			LogsetId:           logsetDst.ID(),
// 			AutoSplit:          pulumi.Bool(false),
// 			MaxSplitPartitions: pulumi.Int(20),
// 			PartitionCount:     pulumi.Int(1),
// 			Period:             pulumi.Int(10),
// 			StorageType:        pulumi.String("hot"),
// 			Tags: pulumi.AnyMap{
// 				"test": pulumi.Any("test"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = Cls.NewDataTransform(ctx, "dataTransform", &Cls.DataTransformArgs{
// 			FuncType:   pulumi.Int(1),
// 			SrcTopicId: topicSrc.ID(),
// 			EtlContent: pulumi.String("ext_sep(\"content\", \"f1, f2, f3\", sep=\",\", quote=\"\", restrict=False, mode=\"overwrite\")fields_drop(\"content\")"),
// 			TaskType:   pulumi.Int(3),
// 			EnableFlag: pulumi.Int(1),
// 			DstResources: cls.DataTransformDstResourceArray{
// 				&cls.DataTransformDstResourceArgs{
// 					TopicId: topicDst.ID(),
// 					Alias:   pulumi.String("iac-test-dst"),
// 				},
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
//
// ## Import
//
// cls data_transform can be imported using the id, e.g.
//
// ```sh
//  $ pulumi import tencentcloud:Cls/dataTransform:DataTransform data_transform data_transform_id
// ```
type DataTransform struct {
	pulumi.CustomResourceState

	// data transform des resources.
	DstResources DataTransformDstResourceArrayOutput `pulumi:"dstResources"`
	// task enable flag.
	EnableFlag pulumi.IntPtrOutput `pulumi:"enableFlag"`
	// data transform content.
	EtlContent pulumi.StringOutput `pulumi:"etlContent"`
	// task type.
	FuncType pulumi.IntOutput `pulumi:"funcType"`
	// task name.
	Name pulumi.StringOutput `pulumi:"name"`
	// src topic id.
	SrcTopicId pulumi.StringOutput `pulumi:"srcTopicId"`
	// task type.
	TaskType pulumi.IntOutput `pulumi:"taskType"`
}

// NewDataTransform registers a new resource with the given unique name, arguments, and options.
func NewDataTransform(ctx *pulumi.Context,
	name string, args *DataTransformArgs, opts ...pulumi.ResourceOption) (*DataTransform, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.EtlContent == nil {
		return nil, errors.New("invalid value for required argument 'EtlContent'")
	}
	if args.FuncType == nil {
		return nil, errors.New("invalid value for required argument 'FuncType'")
	}
	if args.SrcTopicId == nil {
		return nil, errors.New("invalid value for required argument 'SrcTopicId'")
	}
	if args.TaskType == nil {
		return nil, errors.New("invalid value for required argument 'TaskType'")
	}
	opts = pkgResourceDefaultOpts(opts)
	var resource DataTransform
	err := ctx.RegisterResource("tencentcloud:Cls/dataTransform:DataTransform", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDataTransform gets an existing DataTransform resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDataTransform(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DataTransformState, opts ...pulumi.ResourceOption) (*DataTransform, error) {
	var resource DataTransform
	err := ctx.ReadResource("tencentcloud:Cls/dataTransform:DataTransform", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DataTransform resources.
type dataTransformState struct {
	// data transform des resources.
	DstResources []DataTransformDstResource `pulumi:"dstResources"`
	// task enable flag.
	EnableFlag *int `pulumi:"enableFlag"`
	// data transform content.
	EtlContent *string `pulumi:"etlContent"`
	// task type.
	FuncType *int `pulumi:"funcType"`
	// task name.
	Name *string `pulumi:"name"`
	// src topic id.
	SrcTopicId *string `pulumi:"srcTopicId"`
	// task type.
	TaskType *int `pulumi:"taskType"`
}

type DataTransformState struct {
	// data transform des resources.
	DstResources DataTransformDstResourceArrayInput
	// task enable flag.
	EnableFlag pulumi.IntPtrInput
	// data transform content.
	EtlContent pulumi.StringPtrInput
	// task type.
	FuncType pulumi.IntPtrInput
	// task name.
	Name pulumi.StringPtrInput
	// src topic id.
	SrcTopicId pulumi.StringPtrInput
	// task type.
	TaskType pulumi.IntPtrInput
}

func (DataTransformState) ElementType() reflect.Type {
	return reflect.TypeOf((*dataTransformState)(nil)).Elem()
}

type dataTransformArgs struct {
	// data transform des resources.
	DstResources []DataTransformDstResource `pulumi:"dstResources"`
	// task enable flag.
	EnableFlag *int `pulumi:"enableFlag"`
	// data transform content.
	EtlContent string `pulumi:"etlContent"`
	// task type.
	FuncType int `pulumi:"funcType"`
	// task name.
	Name *string `pulumi:"name"`
	// src topic id.
	SrcTopicId string `pulumi:"srcTopicId"`
	// task type.
	TaskType int `pulumi:"taskType"`
}

// The set of arguments for constructing a DataTransform resource.
type DataTransformArgs struct {
	// data transform des resources.
	DstResources DataTransformDstResourceArrayInput
	// task enable flag.
	EnableFlag pulumi.IntPtrInput
	// data transform content.
	EtlContent pulumi.StringInput
	// task type.
	FuncType pulumi.IntInput
	// task name.
	Name pulumi.StringPtrInput
	// src topic id.
	SrcTopicId pulumi.StringInput
	// task type.
	TaskType pulumi.IntInput
}

func (DataTransformArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*dataTransformArgs)(nil)).Elem()
}

type DataTransformInput interface {
	pulumi.Input

	ToDataTransformOutput() DataTransformOutput
	ToDataTransformOutputWithContext(ctx context.Context) DataTransformOutput
}

func (*DataTransform) ElementType() reflect.Type {
	return reflect.TypeOf((**DataTransform)(nil)).Elem()
}

func (i *DataTransform) ToDataTransformOutput() DataTransformOutput {
	return i.ToDataTransformOutputWithContext(context.Background())
}

func (i *DataTransform) ToDataTransformOutputWithContext(ctx context.Context) DataTransformOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataTransformOutput)
}

// DataTransformArrayInput is an input type that accepts DataTransformArray and DataTransformArrayOutput values.
// You can construct a concrete instance of `DataTransformArrayInput` via:
//
//          DataTransformArray{ DataTransformArgs{...} }
type DataTransformArrayInput interface {
	pulumi.Input

	ToDataTransformArrayOutput() DataTransformArrayOutput
	ToDataTransformArrayOutputWithContext(context.Context) DataTransformArrayOutput
}

type DataTransformArray []DataTransformInput

func (DataTransformArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DataTransform)(nil)).Elem()
}

func (i DataTransformArray) ToDataTransformArrayOutput() DataTransformArrayOutput {
	return i.ToDataTransformArrayOutputWithContext(context.Background())
}

func (i DataTransformArray) ToDataTransformArrayOutputWithContext(ctx context.Context) DataTransformArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataTransformArrayOutput)
}

// DataTransformMapInput is an input type that accepts DataTransformMap and DataTransformMapOutput values.
// You can construct a concrete instance of `DataTransformMapInput` via:
//
//          DataTransformMap{ "key": DataTransformArgs{...} }
type DataTransformMapInput interface {
	pulumi.Input

	ToDataTransformMapOutput() DataTransformMapOutput
	ToDataTransformMapOutputWithContext(context.Context) DataTransformMapOutput
}

type DataTransformMap map[string]DataTransformInput

func (DataTransformMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DataTransform)(nil)).Elem()
}

func (i DataTransformMap) ToDataTransformMapOutput() DataTransformMapOutput {
	return i.ToDataTransformMapOutputWithContext(context.Background())
}

func (i DataTransformMap) ToDataTransformMapOutputWithContext(ctx context.Context) DataTransformMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(DataTransformMapOutput)
}

type DataTransformOutput struct{ *pulumi.OutputState }

func (DataTransformOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**DataTransform)(nil)).Elem()
}

func (o DataTransformOutput) ToDataTransformOutput() DataTransformOutput {
	return o
}

func (o DataTransformOutput) ToDataTransformOutputWithContext(ctx context.Context) DataTransformOutput {
	return o
}

// data transform des resources.
func (o DataTransformOutput) DstResources() DataTransformDstResourceArrayOutput {
	return o.ApplyT(func(v *DataTransform) DataTransformDstResourceArrayOutput { return v.DstResources }).(DataTransformDstResourceArrayOutput)
}

// task enable flag.
func (o DataTransformOutput) EnableFlag() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.IntPtrOutput { return v.EnableFlag }).(pulumi.IntPtrOutput)
}

// data transform content.
func (o DataTransformOutput) EtlContent() pulumi.StringOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.StringOutput { return v.EtlContent }).(pulumi.StringOutput)
}

// task type.
func (o DataTransformOutput) FuncType() pulumi.IntOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.IntOutput { return v.FuncType }).(pulumi.IntOutput)
}

// task name.
func (o DataTransformOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// src topic id.
func (o DataTransformOutput) SrcTopicId() pulumi.StringOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.StringOutput { return v.SrcTopicId }).(pulumi.StringOutput)
}

// task type.
func (o DataTransformOutput) TaskType() pulumi.IntOutput {
	return o.ApplyT(func(v *DataTransform) pulumi.IntOutput { return v.TaskType }).(pulumi.IntOutput)
}

type DataTransformArrayOutput struct{ *pulumi.OutputState }

func (DataTransformArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*DataTransform)(nil)).Elem()
}

func (o DataTransformArrayOutput) ToDataTransformArrayOutput() DataTransformArrayOutput {
	return o
}

func (o DataTransformArrayOutput) ToDataTransformArrayOutputWithContext(ctx context.Context) DataTransformArrayOutput {
	return o
}

func (o DataTransformArrayOutput) Index(i pulumi.IntInput) DataTransformOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *DataTransform {
		return vs[0].([]*DataTransform)[vs[1].(int)]
	}).(DataTransformOutput)
}

type DataTransformMapOutput struct{ *pulumi.OutputState }

func (DataTransformMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*DataTransform)(nil)).Elem()
}

func (o DataTransformMapOutput) ToDataTransformMapOutput() DataTransformMapOutput {
	return o
}

func (o DataTransformMapOutput) ToDataTransformMapOutputWithContext(ctx context.Context) DataTransformMapOutput {
	return o
}

func (o DataTransformMapOutput) MapIndex(k pulumi.StringInput) DataTransformOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *DataTransform {
		return vs[0].(map[string]*DataTransform)[vs[1].(string)]
	}).(DataTransformOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*DataTransformInput)(nil)).Elem(), &DataTransform{})
	pulumi.RegisterInputType(reflect.TypeOf((*DataTransformArrayInput)(nil)).Elem(), DataTransformArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*DataTransformMapInput)(nil)).Elem(), DataTransformMap{})
	pulumi.RegisterOutputType(DataTransformOutput{})
	pulumi.RegisterOutputType(DataTransformArrayOutput{})
	pulumi.RegisterOutputType(DataTransformMapOutput{})
}