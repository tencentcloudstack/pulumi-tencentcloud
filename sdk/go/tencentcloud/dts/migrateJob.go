// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dts

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a dts migrateJob
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Cynosdb"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dts"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			foo, err := Cynosdb.NewCluster(ctx, "foo", &Cynosdb.ClusterArgs{
//				AvailableZone:             pulumi.Any(_var.Availability_zone),
//				VpcId:                     pulumi.Any(local.Vpc_id),
//				SubnetId:                  pulumi.Any(local.Subnet_id),
//				DbType:                    pulumi.String("MYSQL"),
//				DbVersion:                 pulumi.String("5.7"),
//				StorageLimit:              pulumi.Int(1000),
//				ClusterName:               pulumi.String("tf-cynosdb-mysql"),
//				Password:                  pulumi.String("cynos@123"),
//				InstanceMaintainDuration:  pulumi.Int(3600),
//				InstanceMaintainStartTime: pulumi.Int(10800),
//				InstanceMaintainWeekdays: pulumi.StringArray{
//					pulumi.String("Fri"),
//					pulumi.String("Mon"),
//					pulumi.String("Sat"),
//					pulumi.String("Sun"),
//					pulumi.String("Thu"),
//					pulumi.String("Wed"),
//					pulumi.String("Tue"),
//				},
//				InstanceCpuCore:    pulumi.Int(1),
//				InstanceMemorySize: pulumi.Int(2),
//				ParamItems: cynosdb.ClusterParamItemArray{
//					&cynosdb.ClusterParamItemArgs{
//						Name:         pulumi.String("character_set_server"),
//						CurrentValue: pulumi.String("utf8"),
//					},
//					&cynosdb.ClusterParamItemArgs{
//						Name:         pulumi.String("time_zone"),
//						CurrentValue: pulumi.String("+09:00"),
//					},
//					&cynosdb.ClusterParamItemArgs{
//						Name:         pulumi.String("lower_case_table_names"),
//						CurrentValue: pulumi.String("1"),
//					},
//				},
//				ForceDelete: pulumi.Bool(true),
//				RwGroupSgs: pulumi.StringArray{
//					local.Sg_id,
//				},
//				RoGroupSgs: pulumi.StringArray{
//					local.Sg_id,
//				},
//				PrarmTemplateId: pulumi.Any(_var.My_param_template),
//			})
//			if err != nil {
//				return err
//			}
//			service, err := Dts.NewMigrateService(ctx, "service", &Dts.MigrateServiceArgs{
//				SrcDatabaseType: pulumi.String("mysql"),
//				DstDatabaseType: pulumi.String("cynosdbmysql"),
//				SrcRegion:       pulumi.String("ap-guangzhou"),
//				DstRegion:       pulumi.String("ap-guangzhou"),
//				InstanceClass:   pulumi.String("small"),
//				JobName:         pulumi.String("tf_test_migration_service_1"),
//				Tags: dts.MigrateServiceTagArray{
//					&dts.MigrateServiceTagArgs{
//						TagKey:   pulumi.String("aaa"),
//						TagValue: pulumi.String("bbb"),
//					},
//				},
//			})
//			if err != nil {
//				return err
//			}
//			job, err := Dts.NewMigrateJob(ctx, "job", &Dts.MigrateJobArgs{
//				ServiceId: service.ID(),
//				RunMode:   pulumi.String("immediate"),
//				MigrateOption: &dts.MigrateJobMigrateOptionArgs{
//					DatabaseTable: &dts.MigrateJobMigrateOptionDatabaseTableArgs{
//						ObjectMode: pulumi.String("partial"),
//						Databases: dts.MigrateJobMigrateOptionDatabaseTableDatabaseArray{
//							&dts.MigrateJobMigrateOptionDatabaseTableDatabaseArgs{
//								DbName:    pulumi.String("tf_ci_test"),
//								DbMode:    pulumi.String("partial"),
//								TableMode: pulumi.String("partial"),
//								Tables: dts.MigrateJobMigrateOptionDatabaseTableDatabaseTableArray{
//									&dts.MigrateJobMigrateOptionDatabaseTableDatabaseTableArgs{
//										TableName:     pulumi.String("test"),
//										NewTableName:  pulumi.String("test_%s"),
//										TableEditMode: pulumi.String("rename"),
//									},
//								},
//							},
//						},
//					},
//				},
//				SrcInfo: &dts.MigrateJobSrcInfoArgs{
//					Region:       pulumi.String("ap-guangzhou"),
//					AccessType:   pulumi.String("cdb"),
//					DatabaseType: pulumi.String("mysql"),
//					NodeType:     pulumi.String("simple"),
//					Infos: dts.MigrateJobSrcInfoInfoArray{
//						&dts.MigrateJobSrcInfoInfoArgs{
//							User:       pulumi.String("user_name"),
//							Password:   pulumi.String("your_pw"),
//							InstanceId: pulumi.String("cdb-fitq5t9h"),
//						},
//					},
//				},
//				DstInfo: &dts.MigrateJobDstInfoArgs{
//					Region:       pulumi.String("ap-guangzhou"),
//					AccessType:   pulumi.String("cdb"),
//					DatabaseType: pulumi.String("cynosdbmysql"),
//					NodeType:     pulumi.String("simple"),
//					Infos: dts.MigrateJobDstInfoInfoArray{
//						&dts.MigrateJobDstInfoInfoArgs{
//							User:       pulumi.String("user_name"),
//							Password:   pulumi.String("your_pw"),
//							InstanceId: foo.ID(),
//						},
//					},
//				},
//				AutoRetryTimeRangeMinutes: pulumi.Int(0),
//			})
//			if err != nil {
//				return err
//			}
//			_, err = Dts.NewMigrateJobStartOperation(ctx, "start", &Dts.MigrateJobStartOperationArgs{
//				JobId: job.ID(),
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
// dts migrate_job can be imported using the id, e.g.
//
// ```sh
// $ pulumi import tencentcloud:Dts/migrateJob:MigrateJob migrate_job migrate_config_id
// ```
type MigrateJob struct {
	pulumi.CustomResourceState

	// AutoRetryTimeRangeMinutes.
	AutoRetryTimeRangeMinutes pulumi.IntPtrOutput `pulumi:"autoRetryTimeRangeMinutes"`
	// DstInfo.
	DstInfo MigrateJobDstInfoOutput `pulumi:"dstInfo"`
	// ExpectRunTime.
	ExpectRunTime pulumi.StringOutput `pulumi:"expectRunTime"`
	// Migration job configuration options, used to describe how the task performs migration.
	MigrateOption MigrateJobMigrateOptionOutput `pulumi:"migrateOption"`
	// Run Mode. eg:immediate,timed.
	RunMode pulumi.StringOutput `pulumi:"runMode"`
	// Migrate service Id from `Dts.MigrateService`.
	ServiceId pulumi.StringOutput `pulumi:"serviceId"`
	// SrcInfo.
	SrcInfo MigrateJobSrcInfoOutput `pulumi:"srcInfo"`
	// Migrate job status.
	Status pulumi.StringOutput `pulumi:"status"`
}

// NewMigrateJob registers a new resource with the given unique name, arguments, and options.
func NewMigrateJob(ctx *pulumi.Context,
	name string, args *MigrateJobArgs, opts ...pulumi.ResourceOption) (*MigrateJob, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DstInfo == nil {
		return nil, errors.New("invalid value for required argument 'DstInfo'")
	}
	if args.MigrateOption == nil {
		return nil, errors.New("invalid value for required argument 'MigrateOption'")
	}
	if args.RunMode == nil {
		return nil, errors.New("invalid value for required argument 'RunMode'")
	}
	if args.ServiceId == nil {
		return nil, errors.New("invalid value for required argument 'ServiceId'")
	}
	if args.SrcInfo == nil {
		return nil, errors.New("invalid value for required argument 'SrcInfo'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource MigrateJob
	err := ctx.RegisterResource("tencentcloud:Dts/migrateJob:MigrateJob", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetMigrateJob gets an existing MigrateJob resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMigrateJob(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *MigrateJobState, opts ...pulumi.ResourceOption) (*MigrateJob, error) {
	var resource MigrateJob
	err := ctx.ReadResource("tencentcloud:Dts/migrateJob:MigrateJob", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering MigrateJob resources.
type migrateJobState struct {
	// AutoRetryTimeRangeMinutes.
	AutoRetryTimeRangeMinutes *int `pulumi:"autoRetryTimeRangeMinutes"`
	// DstInfo.
	DstInfo *MigrateJobDstInfo `pulumi:"dstInfo"`
	// ExpectRunTime.
	ExpectRunTime *string `pulumi:"expectRunTime"`
	// Migration job configuration options, used to describe how the task performs migration.
	MigrateOption *MigrateJobMigrateOption `pulumi:"migrateOption"`
	// Run Mode. eg:immediate,timed.
	RunMode *string `pulumi:"runMode"`
	// Migrate service Id from `Dts.MigrateService`.
	ServiceId *string `pulumi:"serviceId"`
	// SrcInfo.
	SrcInfo *MigrateJobSrcInfo `pulumi:"srcInfo"`
	// Migrate job status.
	Status *string `pulumi:"status"`
}

type MigrateJobState struct {
	// AutoRetryTimeRangeMinutes.
	AutoRetryTimeRangeMinutes pulumi.IntPtrInput
	// DstInfo.
	DstInfo MigrateJobDstInfoPtrInput
	// ExpectRunTime.
	ExpectRunTime pulumi.StringPtrInput
	// Migration job configuration options, used to describe how the task performs migration.
	MigrateOption MigrateJobMigrateOptionPtrInput
	// Run Mode. eg:immediate,timed.
	RunMode pulumi.StringPtrInput
	// Migrate service Id from `Dts.MigrateService`.
	ServiceId pulumi.StringPtrInput
	// SrcInfo.
	SrcInfo MigrateJobSrcInfoPtrInput
	// Migrate job status.
	Status pulumi.StringPtrInput
}

func (MigrateJobState) ElementType() reflect.Type {
	return reflect.TypeOf((*migrateJobState)(nil)).Elem()
}

type migrateJobArgs struct {
	// AutoRetryTimeRangeMinutes.
	AutoRetryTimeRangeMinutes *int `pulumi:"autoRetryTimeRangeMinutes"`
	// DstInfo.
	DstInfo MigrateJobDstInfo `pulumi:"dstInfo"`
	// ExpectRunTime.
	ExpectRunTime *string `pulumi:"expectRunTime"`
	// Migration job configuration options, used to describe how the task performs migration.
	MigrateOption MigrateJobMigrateOption `pulumi:"migrateOption"`
	// Run Mode. eg:immediate,timed.
	RunMode string `pulumi:"runMode"`
	// Migrate service Id from `Dts.MigrateService`.
	ServiceId string `pulumi:"serviceId"`
	// SrcInfo.
	SrcInfo MigrateJobSrcInfo `pulumi:"srcInfo"`
}

// The set of arguments for constructing a MigrateJob resource.
type MigrateJobArgs struct {
	// AutoRetryTimeRangeMinutes.
	AutoRetryTimeRangeMinutes pulumi.IntPtrInput
	// DstInfo.
	DstInfo MigrateJobDstInfoInput
	// ExpectRunTime.
	ExpectRunTime pulumi.StringPtrInput
	// Migration job configuration options, used to describe how the task performs migration.
	MigrateOption MigrateJobMigrateOptionInput
	// Run Mode. eg:immediate,timed.
	RunMode pulumi.StringInput
	// Migrate service Id from `Dts.MigrateService`.
	ServiceId pulumi.StringInput
	// SrcInfo.
	SrcInfo MigrateJobSrcInfoInput
}

func (MigrateJobArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*migrateJobArgs)(nil)).Elem()
}

type MigrateJobInput interface {
	pulumi.Input

	ToMigrateJobOutput() MigrateJobOutput
	ToMigrateJobOutputWithContext(ctx context.Context) MigrateJobOutput
}

func (*MigrateJob) ElementType() reflect.Type {
	return reflect.TypeOf((**MigrateJob)(nil)).Elem()
}

func (i *MigrateJob) ToMigrateJobOutput() MigrateJobOutput {
	return i.ToMigrateJobOutputWithContext(context.Background())
}

func (i *MigrateJob) ToMigrateJobOutputWithContext(ctx context.Context) MigrateJobOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MigrateJobOutput)
}

// MigrateJobArrayInput is an input type that accepts MigrateJobArray and MigrateJobArrayOutput values.
// You can construct a concrete instance of `MigrateJobArrayInput` via:
//
//	MigrateJobArray{ MigrateJobArgs{...} }
type MigrateJobArrayInput interface {
	pulumi.Input

	ToMigrateJobArrayOutput() MigrateJobArrayOutput
	ToMigrateJobArrayOutputWithContext(context.Context) MigrateJobArrayOutput
}

type MigrateJobArray []MigrateJobInput

func (MigrateJobArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MigrateJob)(nil)).Elem()
}

func (i MigrateJobArray) ToMigrateJobArrayOutput() MigrateJobArrayOutput {
	return i.ToMigrateJobArrayOutputWithContext(context.Background())
}

func (i MigrateJobArray) ToMigrateJobArrayOutputWithContext(ctx context.Context) MigrateJobArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MigrateJobArrayOutput)
}

// MigrateJobMapInput is an input type that accepts MigrateJobMap and MigrateJobMapOutput values.
// You can construct a concrete instance of `MigrateJobMapInput` via:
//
//	MigrateJobMap{ "key": MigrateJobArgs{...} }
type MigrateJobMapInput interface {
	pulumi.Input

	ToMigrateJobMapOutput() MigrateJobMapOutput
	ToMigrateJobMapOutputWithContext(context.Context) MigrateJobMapOutput
}

type MigrateJobMap map[string]MigrateJobInput

func (MigrateJobMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MigrateJob)(nil)).Elem()
}

func (i MigrateJobMap) ToMigrateJobMapOutput() MigrateJobMapOutput {
	return i.ToMigrateJobMapOutputWithContext(context.Background())
}

func (i MigrateJobMap) ToMigrateJobMapOutputWithContext(ctx context.Context) MigrateJobMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(MigrateJobMapOutput)
}

type MigrateJobOutput struct{ *pulumi.OutputState }

func (MigrateJobOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**MigrateJob)(nil)).Elem()
}

func (o MigrateJobOutput) ToMigrateJobOutput() MigrateJobOutput {
	return o
}

func (o MigrateJobOutput) ToMigrateJobOutputWithContext(ctx context.Context) MigrateJobOutput {
	return o
}

// AutoRetryTimeRangeMinutes.
func (o MigrateJobOutput) AutoRetryTimeRangeMinutes() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *MigrateJob) pulumi.IntPtrOutput { return v.AutoRetryTimeRangeMinutes }).(pulumi.IntPtrOutput)
}

// DstInfo.
func (o MigrateJobOutput) DstInfo() MigrateJobDstInfoOutput {
	return o.ApplyT(func(v *MigrateJob) MigrateJobDstInfoOutput { return v.DstInfo }).(MigrateJobDstInfoOutput)
}

// ExpectRunTime.
func (o MigrateJobOutput) ExpectRunTime() pulumi.StringOutput {
	return o.ApplyT(func(v *MigrateJob) pulumi.StringOutput { return v.ExpectRunTime }).(pulumi.StringOutput)
}

// Migration job configuration options, used to describe how the task performs migration.
func (o MigrateJobOutput) MigrateOption() MigrateJobMigrateOptionOutput {
	return o.ApplyT(func(v *MigrateJob) MigrateJobMigrateOptionOutput { return v.MigrateOption }).(MigrateJobMigrateOptionOutput)
}

// Run Mode. eg:immediate,timed.
func (o MigrateJobOutput) RunMode() pulumi.StringOutput {
	return o.ApplyT(func(v *MigrateJob) pulumi.StringOutput { return v.RunMode }).(pulumi.StringOutput)
}

// Migrate service Id from `Dts.MigrateService`.
func (o MigrateJobOutput) ServiceId() pulumi.StringOutput {
	return o.ApplyT(func(v *MigrateJob) pulumi.StringOutput { return v.ServiceId }).(pulumi.StringOutput)
}

// SrcInfo.
func (o MigrateJobOutput) SrcInfo() MigrateJobSrcInfoOutput {
	return o.ApplyT(func(v *MigrateJob) MigrateJobSrcInfoOutput { return v.SrcInfo }).(MigrateJobSrcInfoOutput)
}

// Migrate job status.
func (o MigrateJobOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v *MigrateJob) pulumi.StringOutput { return v.Status }).(pulumi.StringOutput)
}

type MigrateJobArrayOutput struct{ *pulumi.OutputState }

func (MigrateJobArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*MigrateJob)(nil)).Elem()
}

func (o MigrateJobArrayOutput) ToMigrateJobArrayOutput() MigrateJobArrayOutput {
	return o
}

func (o MigrateJobArrayOutput) ToMigrateJobArrayOutputWithContext(ctx context.Context) MigrateJobArrayOutput {
	return o
}

func (o MigrateJobArrayOutput) Index(i pulumi.IntInput) MigrateJobOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *MigrateJob {
		return vs[0].([]*MigrateJob)[vs[1].(int)]
	}).(MigrateJobOutput)
}

type MigrateJobMapOutput struct{ *pulumi.OutputState }

func (MigrateJobMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*MigrateJob)(nil)).Elem()
}

func (o MigrateJobMapOutput) ToMigrateJobMapOutput() MigrateJobMapOutput {
	return o
}

func (o MigrateJobMapOutput) ToMigrateJobMapOutputWithContext(ctx context.Context) MigrateJobMapOutput {
	return o
}

func (o MigrateJobMapOutput) MapIndex(k pulumi.StringInput) MigrateJobOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *MigrateJob {
		return vs[0].(map[string]*MigrateJob)[vs[1].(string)]
	}).(MigrateJobOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*MigrateJobInput)(nil)).Elem(), &MigrateJob{})
	pulumi.RegisterInputType(reflect.TypeOf((*MigrateJobArrayInput)(nil)).Elem(), MigrateJobArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*MigrateJobMapInput)(nil)).Elem(), MigrateJobMap{})
	pulumi.RegisterOutputType(MigrateJobOutput{})
	pulumi.RegisterOutputType(MigrateJobArrayOutput{})
	pulumi.RegisterOutputType(MigrateJobMapOutput{})
}
