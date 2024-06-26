// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of mysql backupSummaries
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Mysql.GetBackupSummaries(ctx, &mysql.GetBackupSummariesArgs{
//				OrderBy:        pulumi.StringRef("BackupVolume"),
//				OrderDirection: pulumi.StringRef("ASC"),
//				Product:        "mysql",
//			}, nil)
//			if err != nil {
//				return err
//			}
//			return nil
//		})
//	}
//
// ```
// <!--End PulumiCodeChooser -->
func GetBackupSummaries(ctx *pulumi.Context, args *GetBackupSummariesArgs, opts ...pulumi.InvokeOption) (*GetBackupSummariesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBackupSummariesResult
	err := ctx.Invoke("tencentcloud:Mysql/getBackupSummaries:getBackupSummaries", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackupSummaries.
type GetBackupSummariesArgs struct {
	// Specify to sort by a certain item, the optional values include: BackupVolume: backup volume, DataBackupVolume: data backup volume, BinlogBackupVolume: log backup volume, AutoBackupVolume: automatic backup volume, ManualBackupVolume: manual backup volume. By default, they are sorted by BackupVolume.
	OrderBy *string `pulumi:"orderBy"`
	// Specify the sorting direction, optional values include: ASC: forward order, DESC: reverse order. The default is ASC.
	OrderDirection *string `pulumi:"orderDirection"`
	// The type of cloud database product to be queried, currently only supports `mysql`.
	Product string `pulumi:"product"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getBackupSummaries.
type GetBackupSummariesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Instance backup statistics entries.
	Items            []GetBackupSummariesItem `pulumi:"items"`
	OrderBy          *string                  `pulumi:"orderBy"`
	OrderDirection   *string                  `pulumi:"orderDirection"`
	Product          string                   `pulumi:"product"`
	ResultOutputFile *string                  `pulumi:"resultOutputFile"`
}

func GetBackupSummariesOutput(ctx *pulumi.Context, args GetBackupSummariesOutputArgs, opts ...pulumi.InvokeOption) GetBackupSummariesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupSummariesResult, error) {
			args := v.(GetBackupSummariesArgs)
			r, err := GetBackupSummaries(ctx, &args, opts...)
			var s GetBackupSummariesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBackupSummariesResultOutput)
}

// A collection of arguments for invoking getBackupSummaries.
type GetBackupSummariesOutputArgs struct {
	// Specify to sort by a certain item, the optional values include: BackupVolume: backup volume, DataBackupVolume: data backup volume, BinlogBackupVolume: log backup volume, AutoBackupVolume: automatic backup volume, ManualBackupVolume: manual backup volume. By default, they are sorted by BackupVolume.
	OrderBy pulumi.StringPtrInput `pulumi:"orderBy"`
	// Specify the sorting direction, optional values include: ASC: forward order, DESC: reverse order. The default is ASC.
	OrderDirection pulumi.StringPtrInput `pulumi:"orderDirection"`
	// The type of cloud database product to be queried, currently only supports `mysql`.
	Product pulumi.StringInput `pulumi:"product"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetBackupSummariesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupSummariesArgs)(nil)).Elem()
}

// A collection of values returned by getBackupSummaries.
type GetBackupSummariesResultOutput struct{ *pulumi.OutputState }

func (GetBackupSummariesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupSummariesResult)(nil)).Elem()
}

func (o GetBackupSummariesResultOutput) ToGetBackupSummariesResultOutput() GetBackupSummariesResultOutput {
	return o
}

func (o GetBackupSummariesResultOutput) ToGetBackupSummariesResultOutputWithContext(ctx context.Context) GetBackupSummariesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupSummariesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) string { return v.Id }).(pulumi.StringOutput)
}

// Instance backup statistics entries.
func (o GetBackupSummariesResultOutput) Items() GetBackupSummariesItemArrayOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) []GetBackupSummariesItem { return v.Items }).(GetBackupSummariesItemArrayOutput)
}

func (o GetBackupSummariesResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o GetBackupSummariesResultOutput) OrderDirection() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) *string { return v.OrderDirection }).(pulumi.StringPtrOutput)
}

func (o GetBackupSummariesResultOutput) Product() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) string { return v.Product }).(pulumi.StringOutput)
}

func (o GetBackupSummariesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupSummariesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupSummariesResultOutput{})
}
