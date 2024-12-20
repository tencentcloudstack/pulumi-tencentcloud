// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a mps schedule
//
// ## Example Usage
//
// ### Create a schedule through COS bucket
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cos"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			object, err := Cos.GetBucketObject(ctx, &cos.GetBucketObjectArgs{
//				Bucket: fmt.Sprintf("keep-bucket-%v", local.App_id),
//				Key:    "/mps-test/test.mov",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			output, err := Cos.NewBucket(ctx, "output", &Cos.BucketArgs{
//				Bucket:     pulumi.String(fmt.Sprintf("tf-bucket-mps-schedule-output-%v", local.App_id)),
//				ForceClean: pulumi.Bool(true),
//				Acl:        pulumi.String("public-read"),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Mps.NewSchedule(ctx, "schedule", &Mps.ScheduleArgs{
//				ScheduleName: pulumi.String("tf_test_mps_schedule_%d"),
//				Trigger: &mps.ScheduleTriggerArgs{
//					Type: pulumi.String("CosFileUpload"),
//					CosFileUploadTrigger: &mps.ScheduleTriggerCosFileUploadTriggerArgs{
//						Bucket: pulumi.String(object.Bucket),
//						Region: pulumi.String("%s"),
//						Dir:    pulumi.String("/upload/"),
//						Formats: pulumi.StringArray{
//							pulumi.String("flv"),
//							pulumi.String("mov"),
//						},
//					},
//				},
//				Activities: mps.ScheduleActivityArray{
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("input"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(1),
//							pulumi.Int(2),
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(3),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(6),
//							pulumi.Int(7),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(4),
//							pulumi.Int(5),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(10),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(10),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(10),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(8),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(9),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("action-trans"),
//						ReardriveIndices: pulumi.IntArray{
//							pulumi.Int(10),
//						},
//						ActivityPara: &mps.ScheduleActivityActivityParaArgs{
//							TranscodeTask: &mps.ScheduleActivityActivityParaTranscodeTaskArgs{
//								Definition: pulumi.Int(10),
//							},
//						},
//					},
//					&mps.ScheduleActivityArgs{
//						ActivityType: pulumi.String("output"),
//					},
//				},
//				OutputStorage: &mps.ScheduleOutputStorageArgs{
//					Type: pulumi.String("COS"),
//					CosOutputStorage: &mps.ScheduleOutputStorageCosOutputStorageArgs{
//						Bucket: output.Bucket,
//						Region: pulumi.String("%s"),
//					},
//				},
//				OutputDir: pulumi.String("output/"),
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
// mps schedule can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Mps/schedule:Schedule schedule schedule_id
// ```
type Schedule struct {
	pulumi.CustomResourceState

	// The subtasks of the scheme.
	Activities ScheduleActivityArrayOutput `pulumi:"activities"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
	OutputDir pulumi.StringPtrOutput `pulumi:"outputDir"`
	// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
	OutputStorage ScheduleOutputStoragePtrOutput `pulumi:"outputStorage"`
	// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
	ResourceId pulumi.StringPtrOutput `pulumi:"resourceId"`
	// The scheme name (max 128 characters). This name should be unique across your account.
	ScheduleName pulumi.StringOutput `pulumi:"scheduleName"`
	// The notification configuration. If you do not specify this parameter, notifications will not be sent.
	TaskNotifyConfig ScheduleTaskNotifyConfigOutput `pulumi:"taskNotifyConfig"`
	// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
	Trigger ScheduleTriggerOutput `pulumi:"trigger"`
}

// NewSchedule registers a new resource with the given unique name, arguments, and options.
func NewSchedule(ctx *pulumi.Context,
	name string, args *ScheduleArgs, opts ...pulumi.ResourceOption) (*Schedule, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Activities == nil {
		return nil, errors.New("invalid value for required argument 'Activities'")
	}
	if args.ScheduleName == nil {
		return nil, errors.New("invalid value for required argument 'ScheduleName'")
	}
	if args.Trigger == nil {
		return nil, errors.New("invalid value for required argument 'Trigger'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource Schedule
	err := ctx.RegisterResource("tencentcloud:Mps/schedule:Schedule", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSchedule gets an existing Schedule resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSchedule(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ScheduleState, opts ...pulumi.ResourceOption) (*Schedule, error) {
	var resource Schedule
	err := ctx.ReadResource("tencentcloud:Mps/schedule:Schedule", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Schedule resources.
type scheduleState struct {
	// The subtasks of the scheme.
	Activities []ScheduleActivity `pulumi:"activities"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
	OutputDir *string `pulumi:"outputDir"`
	// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
	OutputStorage *ScheduleOutputStorage `pulumi:"outputStorage"`
	// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
	ResourceId *string `pulumi:"resourceId"`
	// The scheme name (max 128 characters). This name should be unique across your account.
	ScheduleName *string `pulumi:"scheduleName"`
	// The notification configuration. If you do not specify this parameter, notifications will not be sent.
	TaskNotifyConfig *ScheduleTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
	Trigger *ScheduleTrigger `pulumi:"trigger"`
}

type ScheduleState struct {
	// The subtasks of the scheme.
	Activities ScheduleActivityArrayInput
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
	OutputDir pulumi.StringPtrInput
	// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
	OutputStorage ScheduleOutputStoragePtrInput
	// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
	ResourceId pulumi.StringPtrInput
	// The scheme name (max 128 characters). This name should be unique across your account.
	ScheduleName pulumi.StringPtrInput
	// The notification configuration. If you do not specify this parameter, notifications will not be sent.
	TaskNotifyConfig ScheduleTaskNotifyConfigPtrInput
	// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
	Trigger ScheduleTriggerPtrInput
}

func (ScheduleState) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleState)(nil)).Elem()
}

type scheduleArgs struct {
	// The subtasks of the scheme.
	Activities []ScheduleActivity `pulumi:"activities"`
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
	OutputDir *string `pulumi:"outputDir"`
	// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
	OutputStorage *ScheduleOutputStorage `pulumi:"outputStorage"`
	// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
	ResourceId *string `pulumi:"resourceId"`
	// The scheme name (max 128 characters). This name should be unique across your account.
	ScheduleName string `pulumi:"scheduleName"`
	// The notification configuration. If you do not specify this parameter, notifications will not be sent.
	TaskNotifyConfig *ScheduleTaskNotifyConfig `pulumi:"taskNotifyConfig"`
	// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
	Trigger ScheduleTrigger `pulumi:"trigger"`
}

// The set of arguments for constructing a Schedule resource.
type ScheduleArgs struct {
	// The subtasks of the scheme.
	Activities ScheduleActivityArrayInput
	// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
	OutputDir pulumi.StringPtrInput
	// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
	OutputStorage ScheduleOutputStoragePtrInput
	// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
	ResourceId pulumi.StringPtrInput
	// The scheme name (max 128 characters). This name should be unique across your account.
	ScheduleName pulumi.StringInput
	// The notification configuration. If you do not specify this parameter, notifications will not be sent.
	TaskNotifyConfig ScheduleTaskNotifyConfigPtrInput
	// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
	Trigger ScheduleTriggerInput
}

func (ScheduleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*scheduleArgs)(nil)).Elem()
}

type ScheduleInput interface {
	pulumi.Input

	ToScheduleOutput() ScheduleOutput
	ToScheduleOutputWithContext(ctx context.Context) ScheduleOutput
}

func (*Schedule) ElementType() reflect.Type {
	return reflect.TypeOf((**Schedule)(nil)).Elem()
}

func (i *Schedule) ToScheduleOutput() ScheduleOutput {
	return i.ToScheduleOutputWithContext(context.Background())
}

func (i *Schedule) ToScheduleOutputWithContext(ctx context.Context) ScheduleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScheduleOutput)
}

// ScheduleArrayInput is an input type that accepts ScheduleArray and ScheduleArrayOutput values.
// You can construct a concrete instance of `ScheduleArrayInput` via:
//
//	ScheduleArray{ ScheduleArgs{...} }
type ScheduleArrayInput interface {
	pulumi.Input

	ToScheduleArrayOutput() ScheduleArrayOutput
	ToScheduleArrayOutputWithContext(context.Context) ScheduleArrayOutput
}

type ScheduleArray []ScheduleInput

func (ScheduleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Schedule)(nil)).Elem()
}

func (i ScheduleArray) ToScheduleArrayOutput() ScheduleArrayOutput {
	return i.ToScheduleArrayOutputWithContext(context.Background())
}

func (i ScheduleArray) ToScheduleArrayOutputWithContext(ctx context.Context) ScheduleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScheduleArrayOutput)
}

// ScheduleMapInput is an input type that accepts ScheduleMap and ScheduleMapOutput values.
// You can construct a concrete instance of `ScheduleMapInput` via:
//
//	ScheduleMap{ "key": ScheduleArgs{...} }
type ScheduleMapInput interface {
	pulumi.Input

	ToScheduleMapOutput() ScheduleMapOutput
	ToScheduleMapOutputWithContext(context.Context) ScheduleMapOutput
}

type ScheduleMap map[string]ScheduleInput

func (ScheduleMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Schedule)(nil)).Elem()
}

func (i ScheduleMap) ToScheduleMapOutput() ScheduleMapOutput {
	return i.ToScheduleMapOutputWithContext(context.Background())
}

func (i ScheduleMap) ToScheduleMapOutputWithContext(ctx context.Context) ScheduleMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ScheduleMapOutput)
}

type ScheduleOutput struct{ *pulumi.OutputState }

func (ScheduleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Schedule)(nil)).Elem()
}

func (o ScheduleOutput) ToScheduleOutput() ScheduleOutput {
	return o
}

func (o ScheduleOutput) ToScheduleOutputWithContext(ctx context.Context) ScheduleOutput {
	return o
}

// The subtasks of the scheme.
func (o ScheduleOutput) Activities() ScheduleActivityArrayOutput {
	return o.ApplyT(func(v *Schedule) ScheduleActivityArrayOutput { return v.Activities }).(ScheduleActivityArrayOutput)
}

// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
func (o ScheduleOutput) OutputDir() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Schedule) pulumi.StringPtrOutput { return v.OutputDir }).(pulumi.StringPtrOutput)
}

// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
func (o ScheduleOutput) OutputStorage() ScheduleOutputStoragePtrOutput {
	return o.ApplyT(func(v *Schedule) ScheduleOutputStoragePtrOutput { return v.OutputStorage }).(ScheduleOutputStoragePtrOutput)
}

// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
func (o ScheduleOutput) ResourceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Schedule) pulumi.StringPtrOutput { return v.ResourceId }).(pulumi.StringPtrOutput)
}

// The scheme name (max 128 characters). This name should be unique across your account.
func (o ScheduleOutput) ScheduleName() pulumi.StringOutput {
	return o.ApplyT(func(v *Schedule) pulumi.StringOutput { return v.ScheduleName }).(pulumi.StringOutput)
}

// The notification configuration. If you do not specify this parameter, notifications will not be sent.
func (o ScheduleOutput) TaskNotifyConfig() ScheduleTaskNotifyConfigOutput {
	return o.ApplyT(func(v *Schedule) ScheduleTaskNotifyConfigOutput { return v.TaskNotifyConfig }).(ScheduleTaskNotifyConfigOutput)
}

// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
func (o ScheduleOutput) Trigger() ScheduleTriggerOutput {
	return o.ApplyT(func(v *Schedule) ScheduleTriggerOutput { return v.Trigger }).(ScheduleTriggerOutput)
}

type ScheduleArrayOutput struct{ *pulumi.OutputState }

func (ScheduleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*Schedule)(nil)).Elem()
}

func (o ScheduleArrayOutput) ToScheduleArrayOutput() ScheduleArrayOutput {
	return o
}

func (o ScheduleArrayOutput) ToScheduleArrayOutputWithContext(ctx context.Context) ScheduleArrayOutput {
	return o
}

func (o ScheduleArrayOutput) Index(i pulumi.IntInput) ScheduleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *Schedule {
		return vs[0].([]*Schedule)[vs[1].(int)]
	}).(ScheduleOutput)
}

type ScheduleMapOutput struct{ *pulumi.OutputState }

func (ScheduleMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*Schedule)(nil)).Elem()
}

func (o ScheduleMapOutput) ToScheduleMapOutput() ScheduleMapOutput {
	return o
}

func (o ScheduleMapOutput) ToScheduleMapOutputWithContext(ctx context.Context) ScheduleMapOutput {
	return o
}

func (o ScheduleMapOutput) MapIndex(k pulumi.StringInput) ScheduleOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *Schedule {
		return vs[0].(map[string]*Schedule)[vs[1].(string)]
	}).(ScheduleOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*ScheduleInput)(nil)).Elem(), &Schedule{})
	pulumi.RegisterInputType(reflect.TypeOf((*ScheduleArrayInput)(nil)).Elem(), ScheduleArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*ScheduleMapInput)(nil)).Elem(), ScheduleMap{})
	pulumi.RegisterOutputType(ScheduleOutput{})
	pulumi.RegisterOutputType(ScheduleArrayOutput{})
	pulumi.RegisterOutputType(ScheduleMapOutput{})
}
