// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package sqlserver

import (
	"context"
	"reflect"

	"errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Provides a resource to create a sqlserver startBackupFullMigration
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Sqlserver"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Sqlserver.NewStartBackupFullMigration(ctx, "startBackupFullMigration", &Sqlserver.StartBackupFullMigrationArgs{
//				BackupMigrationId: pulumi.String("mssql-backup-migration-kpl74n9l"),
//				InstanceId:        pulumi.String("mssql-i1z41iwd"),
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
type StartBackupFullMigration struct {
	pulumi.CustomResourceState

	// Backup import task ID, returned by the CreateBackupMigration interface.
	BackupMigrationId pulumi.StringOutput `pulumi:"backupMigrationId"`
	// ID of imported target instance.
	InstanceId pulumi.StringOutput `pulumi:"instanceId"`
}

// NewStartBackupFullMigration registers a new resource with the given unique name, arguments, and options.
func NewStartBackupFullMigration(ctx *pulumi.Context,
	name string, args *StartBackupFullMigrationArgs, opts ...pulumi.ResourceOption) (*StartBackupFullMigration, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.BackupMigrationId == nil {
		return nil, errors.New("invalid value for required argument 'BackupMigrationId'")
	}
	if args.InstanceId == nil {
		return nil, errors.New("invalid value for required argument 'InstanceId'")
	}
	opts = internal.PkgResourceDefaultOpts(opts)
	var resource StartBackupFullMigration
	err := ctx.RegisterResource("tencentcloud:Sqlserver/startBackupFullMigration:StartBackupFullMigration", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStartBackupFullMigration gets an existing StartBackupFullMigration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStartBackupFullMigration(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StartBackupFullMigrationState, opts ...pulumi.ResourceOption) (*StartBackupFullMigration, error) {
	var resource StartBackupFullMigration
	err := ctx.ReadResource("tencentcloud:Sqlserver/startBackupFullMigration:StartBackupFullMigration", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StartBackupFullMigration resources.
type startBackupFullMigrationState struct {
	// Backup import task ID, returned by the CreateBackupMigration interface.
	BackupMigrationId *string `pulumi:"backupMigrationId"`
	// ID of imported target instance.
	InstanceId *string `pulumi:"instanceId"`
}

type StartBackupFullMigrationState struct {
	// Backup import task ID, returned by the CreateBackupMigration interface.
	BackupMigrationId pulumi.StringPtrInput
	// ID of imported target instance.
	InstanceId pulumi.StringPtrInput
}

func (StartBackupFullMigrationState) ElementType() reflect.Type {
	return reflect.TypeOf((*startBackupFullMigrationState)(nil)).Elem()
}

type startBackupFullMigrationArgs struct {
	// Backup import task ID, returned by the CreateBackupMigration interface.
	BackupMigrationId string `pulumi:"backupMigrationId"`
	// ID of imported target instance.
	InstanceId string `pulumi:"instanceId"`
}

// The set of arguments for constructing a StartBackupFullMigration resource.
type StartBackupFullMigrationArgs struct {
	// Backup import task ID, returned by the CreateBackupMigration interface.
	BackupMigrationId pulumi.StringInput
	// ID of imported target instance.
	InstanceId pulumi.StringInput
}

func (StartBackupFullMigrationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*startBackupFullMigrationArgs)(nil)).Elem()
}

type StartBackupFullMigrationInput interface {
	pulumi.Input

	ToStartBackupFullMigrationOutput() StartBackupFullMigrationOutput
	ToStartBackupFullMigrationOutputWithContext(ctx context.Context) StartBackupFullMigrationOutput
}

func (*StartBackupFullMigration) ElementType() reflect.Type {
	return reflect.TypeOf((**StartBackupFullMigration)(nil)).Elem()
}

func (i *StartBackupFullMigration) ToStartBackupFullMigrationOutput() StartBackupFullMigrationOutput {
	return i.ToStartBackupFullMigrationOutputWithContext(context.Background())
}

func (i *StartBackupFullMigration) ToStartBackupFullMigrationOutputWithContext(ctx context.Context) StartBackupFullMigrationOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StartBackupFullMigrationOutput)
}

// StartBackupFullMigrationArrayInput is an input type that accepts StartBackupFullMigrationArray and StartBackupFullMigrationArrayOutput values.
// You can construct a concrete instance of `StartBackupFullMigrationArrayInput` via:
//
//	StartBackupFullMigrationArray{ StartBackupFullMigrationArgs{...} }
type StartBackupFullMigrationArrayInput interface {
	pulumi.Input

	ToStartBackupFullMigrationArrayOutput() StartBackupFullMigrationArrayOutput
	ToStartBackupFullMigrationArrayOutputWithContext(context.Context) StartBackupFullMigrationArrayOutput
}

type StartBackupFullMigrationArray []StartBackupFullMigrationInput

func (StartBackupFullMigrationArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StartBackupFullMigration)(nil)).Elem()
}

func (i StartBackupFullMigrationArray) ToStartBackupFullMigrationArrayOutput() StartBackupFullMigrationArrayOutput {
	return i.ToStartBackupFullMigrationArrayOutputWithContext(context.Background())
}

func (i StartBackupFullMigrationArray) ToStartBackupFullMigrationArrayOutputWithContext(ctx context.Context) StartBackupFullMigrationArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StartBackupFullMigrationArrayOutput)
}

// StartBackupFullMigrationMapInput is an input type that accepts StartBackupFullMigrationMap and StartBackupFullMigrationMapOutput values.
// You can construct a concrete instance of `StartBackupFullMigrationMapInput` via:
//
//	StartBackupFullMigrationMap{ "key": StartBackupFullMigrationArgs{...} }
type StartBackupFullMigrationMapInput interface {
	pulumi.Input

	ToStartBackupFullMigrationMapOutput() StartBackupFullMigrationMapOutput
	ToStartBackupFullMigrationMapOutputWithContext(context.Context) StartBackupFullMigrationMapOutput
}

type StartBackupFullMigrationMap map[string]StartBackupFullMigrationInput

func (StartBackupFullMigrationMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StartBackupFullMigration)(nil)).Elem()
}

func (i StartBackupFullMigrationMap) ToStartBackupFullMigrationMapOutput() StartBackupFullMigrationMapOutput {
	return i.ToStartBackupFullMigrationMapOutputWithContext(context.Background())
}

func (i StartBackupFullMigrationMap) ToStartBackupFullMigrationMapOutputWithContext(ctx context.Context) StartBackupFullMigrationMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(StartBackupFullMigrationMapOutput)
}

type StartBackupFullMigrationOutput struct{ *pulumi.OutputState }

func (StartBackupFullMigrationOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**StartBackupFullMigration)(nil)).Elem()
}

func (o StartBackupFullMigrationOutput) ToStartBackupFullMigrationOutput() StartBackupFullMigrationOutput {
	return o
}

func (o StartBackupFullMigrationOutput) ToStartBackupFullMigrationOutputWithContext(ctx context.Context) StartBackupFullMigrationOutput {
	return o
}

// Backup import task ID, returned by the CreateBackupMigration interface.
func (o StartBackupFullMigrationOutput) BackupMigrationId() pulumi.StringOutput {
	return o.ApplyT(func(v *StartBackupFullMigration) pulumi.StringOutput { return v.BackupMigrationId }).(pulumi.StringOutput)
}

// ID of imported target instance.
func (o StartBackupFullMigrationOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v *StartBackupFullMigration) pulumi.StringOutput { return v.InstanceId }).(pulumi.StringOutput)
}

type StartBackupFullMigrationArrayOutput struct{ *pulumi.OutputState }

func (StartBackupFullMigrationArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*StartBackupFullMigration)(nil)).Elem()
}

func (o StartBackupFullMigrationArrayOutput) ToStartBackupFullMigrationArrayOutput() StartBackupFullMigrationArrayOutput {
	return o
}

func (o StartBackupFullMigrationArrayOutput) ToStartBackupFullMigrationArrayOutputWithContext(ctx context.Context) StartBackupFullMigrationArrayOutput {
	return o
}

func (o StartBackupFullMigrationArrayOutput) Index(i pulumi.IntInput) StartBackupFullMigrationOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *StartBackupFullMigration {
		return vs[0].([]*StartBackupFullMigration)[vs[1].(int)]
	}).(StartBackupFullMigrationOutput)
}

type StartBackupFullMigrationMapOutput struct{ *pulumi.OutputState }

func (StartBackupFullMigrationMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*StartBackupFullMigration)(nil)).Elem()
}

func (o StartBackupFullMigrationMapOutput) ToStartBackupFullMigrationMapOutput() StartBackupFullMigrationMapOutput {
	return o
}

func (o StartBackupFullMigrationMapOutput) ToStartBackupFullMigrationMapOutputWithContext(ctx context.Context) StartBackupFullMigrationMapOutput {
	return o
}

func (o StartBackupFullMigrationMapOutput) MapIndex(k pulumi.StringInput) StartBackupFullMigrationOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *StartBackupFullMigration {
		return vs[0].(map[string]*StartBackupFullMigration)[vs[1].(string)]
	}).(StartBackupFullMigrationOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*StartBackupFullMigrationInput)(nil)).Elem(), &StartBackupFullMigration{})
	pulumi.RegisterInputType(reflect.TypeOf((*StartBackupFullMigrationArrayInput)(nil)).Elem(), StartBackupFullMigrationArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*StartBackupFullMigrationMapInput)(nil)).Elem(), StartBackupFullMigrationMap{})
	pulumi.RegisterOutputType(StartBackupFullMigrationOutput{})
	pulumi.RegisterOutputType(StartBackupFullMigrationArrayOutput{})
	pulumi.RegisterOutputType(StartBackupFullMigrationMapOutput{})
}
