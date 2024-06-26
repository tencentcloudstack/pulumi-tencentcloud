// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package wedata

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a wedata integrationOfflineTask
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Wedata"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Wedata.NewIntegrationOfflineTask(ctx, "example", &Wedata.IntegrationOfflineTaskArgs{
//				CycleStep:  pulumi.Int(1),
//				DelayTime:  pulumi.Int(0),
//				EndTime:    pulumi.String("2099-12-31 00:00:00"),
//				Notes:      pulumi.String("terraform example demo."),
//				ProjectId:  pulumi.String("1612982498218618880"),
//				StartTime:  pulumi.String("2023-12-31 00:00:00"),
//				TaskAction: pulumi.String("2"),
//				TaskInfo: &wedata.IntegrationOfflineTaskTaskInfoArgs{
//					Configs: wedata.IntegrationOfflineTaskTaskInfoConfigArray{
//						&wedata.IntegrationOfflineTaskTaskInfoConfigArgs{
//							Name:  pulumi.String("Args"),
//							Value: pulumi.String("args"),
//						},
//						&wedata.IntegrationOfflineTaskTaskInfoConfigArgs{
//							Name:  pulumi.String("dirtyDataThreshold"),
//							Value: pulumi.String("0"),
//						},
//						&wedata.IntegrationOfflineTaskTaskInfoConfigArgs{
//							Name:  pulumi.String("concurrency"),
//							Value: pulumi.String("1"),
//						},
//						&wedata.IntegrationOfflineTaskTaskInfoConfigArgs{
//							Name:  pulumi.String("syncRateLimitUnit"),
//							Value: pulumi.String("0"),
//						},
//					},
//					ExecutorId: pulumi.String("20230313175748567418"),
//					ExtConfigs: wedata.IntegrationOfflineTaskTaskInfoExtConfigArray{
//						&wedata.IntegrationOfflineTaskTaskInfoExtConfigArgs{
//							Name:  pulumi.String("TaskAlarmRegularList"),
//							Value: pulumi.String("73"),
//						},
//					},
//					Incharge: pulumi.String("demo"),
//					OfflineTaskAddEntity: &wedata.IntegrationOfflineTaskTaskInfoOfflineTaskAddEntityArgs{
//						CrontabExpression: pulumi.String("0 0 1 * * ?"),
//						CycleType:         pulumi.Int(3),
//						Retriable:         pulumi.Int(1),
//						RetryWait:         pulumi.Int(5),
//						SelfDepend:        pulumi.Int(1),
//						TryLimit:          pulumi.Int(5),
//					},
//				},
//				TaskMode: pulumi.String("1"),
//				TaskName: pulumi.String("tf_example"),
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
// wedata integration_offline_task can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask example 1612982498218618880#20231102200955095
// ```
type IntegrationOfflineTask struct {
	pulumi.CustomResourceState

	// Interval time of scheduling, the minimum value: 1.
	CycleStep pulumi.IntOutput `pulumi:"cycleStep"`
	// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
	DelayTime pulumi.IntOutput `pulumi:"delayTime"`
	// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
	EndTime pulumi.StringOutput `pulumi:"endTime"`
	// Description information.
	Notes pulumi.StringOutput `pulumi:"notes"`
	// Project ID.
	ProjectId pulumi.StringOutput `pulumi:"projectId"`
	// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
	StartTime pulumi.StringOutput `pulumi:"startTime"`
	// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
	TaskAction pulumi.StringOutput `pulumi:"taskAction"`
	// Task ID.
	TaskId pulumi.StringOutput `pulumi:"taskId"`
	// Task Information.
	TaskInfo IntegrationOfflineTaskTaskInfoOutput `pulumi:"taskInfo"`
	// Task display mode, 0: canvas mode, 1: form mode.
	TaskMode pulumi.StringOutput `pulumi:"taskMode"`
	// Task name.
	TaskName pulumi.StringOutput `pulumi:"taskName"`
}

// NewIntegrationOfflineTask registers a new resource with the given unique name, arguments, and options.
func NewIntegrationOfflineTask(ctx *pulumi.Context,
	name string, args *IntegrationOfflineTaskArgs, opts ...pulumi.ResourceOption) (*IntegrationOfflineTask, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.CycleStep == nil {
		return nil, errors.New("invalid value for required argument 'CycleStep'")
	}
	if args.DelayTime == nil {
		return nil, errors.New("invalid value for required argument 'DelayTime'")
	}
	if args.EndTime == nil {
		return nil, errors.New("invalid value for required argument 'EndTime'")
	}
	if args.Notes == nil {
		return nil, errors.New("invalid value for required argument 'Notes'")
	}
	if args.ProjectId == nil {
		return nil, errors.New("invalid value for required argument 'ProjectId'")
	}
	if args.StartTime == nil {
		return nil, errors.New("invalid value for required argument 'StartTime'")
	}
	if args.TaskAction == nil {
		return nil, errors.New("invalid value for required argument 'TaskAction'")
	}
	if args.TaskInfo == nil {
		return nil, errors.New("invalid value for required argument 'TaskInfo'")
	}
	if args.TaskMode == nil {
		return nil, errors.New("invalid value for required argument 'TaskMode'")
	}
	if args.TaskName == nil {
		return nil, errors.New("invalid value for required argument 'TaskName'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource IntegrationOfflineTask
	err := ctx.RegisterResource("tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetIntegrationOfflineTask gets an existing IntegrationOfflineTask resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetIntegrationOfflineTask(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *IntegrationOfflineTaskState, opts ...pulumi.ResourceOption) (*IntegrationOfflineTask, error) {
	var resource IntegrationOfflineTask
	err := ctx.ReadResource("tencentcloud:Wedata/integrationOfflineTask:IntegrationOfflineTask", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering IntegrationOfflineTask resources.
type integrationOfflineTaskState struct {
	// Interval time of scheduling, the minimum value: 1.
	CycleStep *int `pulumi:"cycleStep"`
	// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
	DelayTime *int `pulumi:"delayTime"`
	// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
	EndTime *string `pulumi:"endTime"`
	// Description information.
	Notes *string `pulumi:"notes"`
	// Project ID.
	ProjectId *string `pulumi:"projectId"`
	// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
	StartTime *string `pulumi:"startTime"`
	// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
	TaskAction *string `pulumi:"taskAction"`
	// Task ID.
	TaskId *string `pulumi:"taskId"`
	// Task Information.
	TaskInfo *IntegrationOfflineTaskTaskInfo `pulumi:"taskInfo"`
	// Task display mode, 0: canvas mode, 1: form mode.
	TaskMode *string `pulumi:"taskMode"`
	// Task name.
	TaskName *string `pulumi:"taskName"`
}

type IntegrationOfflineTaskState struct {
	// Interval time of scheduling, the minimum value: 1.
	CycleStep pulumi.IntPtrInput
	// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
	DelayTime pulumi.IntPtrInput
	// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
	EndTime pulumi.StringPtrInput
	// Description information.
	Notes pulumi.StringPtrInput
	// Project ID.
	ProjectId pulumi.StringPtrInput
	// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
	StartTime pulumi.StringPtrInput
	// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
	TaskAction pulumi.StringPtrInput
	// Task ID.
	TaskId pulumi.StringPtrInput
	// Task Information.
	TaskInfo IntegrationOfflineTaskTaskInfoPtrInput
	// Task display mode, 0: canvas mode, 1: form mode.
	TaskMode pulumi.StringPtrInput
	// Task name.
	TaskName pulumi.StringPtrInput
}

func (IntegrationOfflineTaskState) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationOfflineTaskState)(nil)).Elem()
}

type integrationOfflineTaskArgs struct {
	// Interval time of scheduling, the minimum value: 1.
	CycleStep int `pulumi:"cycleStep"`
	// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
	DelayTime int `pulumi:"delayTime"`
	// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
	EndTime string `pulumi:"endTime"`
	// Description information.
	Notes string `pulumi:"notes"`
	// Project ID.
	ProjectId string `pulumi:"projectId"`
	// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
	StartTime string `pulumi:"startTime"`
	// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
	TaskAction string `pulumi:"taskAction"`
	// Task Information.
	TaskInfo IntegrationOfflineTaskTaskInfo `pulumi:"taskInfo"`
	// Task display mode, 0: canvas mode, 1: form mode.
	TaskMode string `pulumi:"taskMode"`
	// Task name.
	TaskName string `pulumi:"taskName"`
}

// The set of arguments for constructing a IntegrationOfflineTask resource.
type IntegrationOfflineTaskArgs struct {
	// Interval time of scheduling, the minimum value: 1.
	CycleStep pulumi.IntInput
	// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
	DelayTime pulumi.IntInput
	// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
	EndTime pulumi.StringInput
	// Description information.
	Notes pulumi.StringInput
	// Project ID.
	ProjectId pulumi.StringInput
	// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
	StartTime pulumi.StringInput
	// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
	TaskAction pulumi.StringInput
	// Task Information.
	TaskInfo IntegrationOfflineTaskTaskInfoInput
	// Task display mode, 0: canvas mode, 1: form mode.
	TaskMode pulumi.StringInput
	// Task name.
	TaskName pulumi.StringInput
}

func (IntegrationOfflineTaskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*integrationOfflineTaskArgs)(nil)).Elem()
}

type IntegrationOfflineTaskInput interface {
	pulumi.Input

	ToIntegrationOfflineTaskOutput() IntegrationOfflineTaskOutput
	ToIntegrationOfflineTaskOutputWithContext(ctx context.Context) IntegrationOfflineTaskOutput
}

func (*IntegrationOfflineTask) ElementType() reflect.Type {
	return reflect.TypeOf((**IntegrationOfflineTask)(nil)).Elem()
}

func (i *IntegrationOfflineTask) ToIntegrationOfflineTaskOutput() IntegrationOfflineTaskOutput {
	return i.ToIntegrationOfflineTaskOutputWithContext(context.Background())
}

func (i *IntegrationOfflineTask) ToIntegrationOfflineTaskOutputWithContext(ctx context.Context) IntegrationOfflineTaskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationOfflineTaskOutput)
}

// IntegrationOfflineTaskArrayInput is an input type that accepts IntegrationOfflineTaskArray and IntegrationOfflineTaskArrayOutput values.
// You can construct a concrete instance of `IntegrationOfflineTaskArrayInput` via:
//
//	IntegrationOfflineTaskArray{ IntegrationOfflineTaskArgs{...} }
type IntegrationOfflineTaskArrayInput interface {
	pulumi.Input

	ToIntegrationOfflineTaskArrayOutput() IntegrationOfflineTaskArrayOutput
	ToIntegrationOfflineTaskArrayOutputWithContext(context.Context) IntegrationOfflineTaskArrayOutput
}

type IntegrationOfflineTaskArray []IntegrationOfflineTaskInput

func (IntegrationOfflineTaskArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IntegrationOfflineTask)(nil)).Elem()
}

func (i IntegrationOfflineTaskArray) ToIntegrationOfflineTaskArrayOutput() IntegrationOfflineTaskArrayOutput {
	return i.ToIntegrationOfflineTaskArrayOutputWithContext(context.Background())
}

func (i IntegrationOfflineTaskArray) ToIntegrationOfflineTaskArrayOutputWithContext(ctx context.Context) IntegrationOfflineTaskArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationOfflineTaskArrayOutput)
}

// IntegrationOfflineTaskMapInput is an input type that accepts IntegrationOfflineTaskMap and IntegrationOfflineTaskMapOutput values.
// You can construct a concrete instance of `IntegrationOfflineTaskMapInput` via:
//
//	IntegrationOfflineTaskMap{ "key": IntegrationOfflineTaskArgs{...} }
type IntegrationOfflineTaskMapInput interface {
	pulumi.Input

	ToIntegrationOfflineTaskMapOutput() IntegrationOfflineTaskMapOutput
	ToIntegrationOfflineTaskMapOutputWithContext(context.Context) IntegrationOfflineTaskMapOutput
}

type IntegrationOfflineTaskMap map[string]IntegrationOfflineTaskInput

func (IntegrationOfflineTaskMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IntegrationOfflineTask)(nil)).Elem()
}

func (i IntegrationOfflineTaskMap) ToIntegrationOfflineTaskMapOutput() IntegrationOfflineTaskMapOutput {
	return i.ToIntegrationOfflineTaskMapOutputWithContext(context.Background())
}

func (i IntegrationOfflineTaskMap) ToIntegrationOfflineTaskMapOutputWithContext(ctx context.Context) IntegrationOfflineTaskMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(IntegrationOfflineTaskMapOutput)
}

type IntegrationOfflineTaskOutput struct{ *pulumi.OutputState }

func (IntegrationOfflineTaskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**IntegrationOfflineTask)(nil)).Elem()
}

func (o IntegrationOfflineTaskOutput) ToIntegrationOfflineTaskOutput() IntegrationOfflineTaskOutput {
	return o
}

func (o IntegrationOfflineTaskOutput) ToIntegrationOfflineTaskOutputWithContext(ctx context.Context) IntegrationOfflineTaskOutput {
	return o
}

// Interval time of scheduling, the minimum value: 1.
func (o IntegrationOfflineTaskOutput) CycleStep() pulumi.IntOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.IntOutput { return v.CycleStep }).(pulumi.IntOutput)
}

// Execution time, unit is minutes, only available for day/week/month/year scheduling. For example, daily scheduling is executed once every day at 02:00, and the delayTime is 120 minutes.
func (o IntegrationOfflineTaskOutput) DelayTime() pulumi.IntOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.IntOutput { return v.DelayTime }).(pulumi.IntOutput)
}

// Effective end time, the format is yyyy-MM-dd HH:mm:ss.
func (o IntegrationOfflineTaskOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.EndTime }).(pulumi.StringOutput)
}

// Description information.
func (o IntegrationOfflineTaskOutput) Notes() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.Notes }).(pulumi.StringOutput)
}

// Project ID.
func (o IntegrationOfflineTaskOutput) ProjectId() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.ProjectId }).(pulumi.StringOutput)
}

// Effective start time, the format is yyyy-MM-dd HH:mm:ss.
func (o IntegrationOfflineTaskOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.StartTime }).(pulumi.StringOutput)
}

// Scheduling configuration: flexible period configuration, only available for hourly/weekly/monthly/yearly scheduling. If the hourly task is specified to run at 0:00, 3:00 and 4:00 every day, it is 0,3,4.
func (o IntegrationOfflineTaskOutput) TaskAction() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.TaskAction }).(pulumi.StringOutput)
}

// Task ID.
func (o IntegrationOfflineTaskOutput) TaskId() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.TaskId }).(pulumi.StringOutput)
}

// Task Information.
func (o IntegrationOfflineTaskOutput) TaskInfo() IntegrationOfflineTaskTaskInfoOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) IntegrationOfflineTaskTaskInfoOutput { return v.TaskInfo }).(IntegrationOfflineTaskTaskInfoOutput)
}

// Task display mode, 0: canvas mode, 1: form mode.
func (o IntegrationOfflineTaskOutput) TaskMode() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.TaskMode }).(pulumi.StringOutput)
}

// Task name.
func (o IntegrationOfflineTaskOutput) TaskName() pulumi.StringOutput {
	return o.ApplyT(func(v *IntegrationOfflineTask) pulumi.StringOutput { return v.TaskName }).(pulumi.StringOutput)
}

type IntegrationOfflineTaskArrayOutput struct{ *pulumi.OutputState }

func (IntegrationOfflineTaskArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*IntegrationOfflineTask)(nil)).Elem()
}

func (o IntegrationOfflineTaskArrayOutput) ToIntegrationOfflineTaskArrayOutput() IntegrationOfflineTaskArrayOutput {
	return o
}

func (o IntegrationOfflineTaskArrayOutput) ToIntegrationOfflineTaskArrayOutputWithContext(ctx context.Context) IntegrationOfflineTaskArrayOutput {
	return o
}

func (o IntegrationOfflineTaskArrayOutput) Index(i pulumi.IntInput) IntegrationOfflineTaskOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *IntegrationOfflineTask {
		return vs[0].([]*IntegrationOfflineTask)[vs[1].(int)]
	}).(IntegrationOfflineTaskOutput)
}

type IntegrationOfflineTaskMapOutput struct{ *pulumi.OutputState }

func (IntegrationOfflineTaskMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*IntegrationOfflineTask)(nil)).Elem()
}

func (o IntegrationOfflineTaskMapOutput) ToIntegrationOfflineTaskMapOutput() IntegrationOfflineTaskMapOutput {
	return o
}

func (o IntegrationOfflineTaskMapOutput) ToIntegrationOfflineTaskMapOutputWithContext(ctx context.Context) IntegrationOfflineTaskMapOutput {
	return o
}

func (o IntegrationOfflineTaskMapOutput) MapIndex(k pulumi.StringInput) IntegrationOfflineTaskOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *IntegrationOfflineTask {
		return vs[0].(map[string]*IntegrationOfflineTask)[vs[1].(string)]
	}).(IntegrationOfflineTaskOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*IntegrationOfflineTaskInput)(nil)).Elem(), &IntegrationOfflineTask{})
	pulumi.RegisterInputType(reflect.TypeOf((*IntegrationOfflineTaskArrayInput)(nil)).Elem(), IntegrationOfflineTaskArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*IntegrationOfflineTaskMapInput)(nil)).Elem(), IntegrationOfflineTaskMap{})
	pulumi.RegisterOutputType(IntegrationOfflineTaskOutput{})
	pulumi.RegisterOutputType(IntegrationOfflineTaskArrayOutput{})
	pulumi.RegisterOutputType(IntegrationOfflineTaskMapOutput{})
}
