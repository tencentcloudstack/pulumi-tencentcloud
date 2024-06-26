// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package redis

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of redis backupDownloadInfo
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Redis"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Redis.GetBackupDownloadInfo(ctx, &redis.GetBackupDownloadInfoArgs{
//				BackupId:   "641186639-8362913-1516672770",
//				InstanceId: "crs-iw7d9wdd",
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
func GetBackupDownloadInfo(ctx *pulumi.Context, args *GetBackupDownloadInfoArgs, opts ...pulumi.InvokeOption) (*GetBackupDownloadInfoResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetBackupDownloadInfoResult
	err := ctx.Invoke("tencentcloud:Redis/getBackupDownloadInfo:getBackupDownloadInfo", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBackupDownloadInfo.
type GetBackupDownloadInfoArgs struct {
	// The backup ID, which can be accessed via [DescribeInstanceBackups](https://cloud.tencent.com/document/product/239/20011) interface returns the parameter RedisBackupSet to get.
	BackupId string `pulumi:"backupId"`
	// The ID of instance.
	InstanceId string `pulumi:"instanceId"`
	// Identifies whether the customized LimitIP address can download the backup file.- In: Custom IP addresses are available for download.- NotIn: Custom IPs are not available for download.
	IpComparisonSymbol *string `pulumi:"ipComparisonSymbol"`
	// A custom VPC IP address for downloadable backup files.If the parameter LimitType is **Customize**, you need to configure this parameter.
	LimitIps []string `pulumi:"limitIps"`
	// Types of network restrictions for downloading backup files:- NoLimit: There is no limit, and backup files can be downloaded from both Tencent Cloud and internal and external networks.- LimitOnlyIntranet: Only intranet addresses automatically assigned by Tencent Cloud can download backup files.- Customize: refers to a user-defined private network downloadable backup file.
	LimitType *string `pulumi:"limitType"`
	// A custom VPC ID for a downloadable backup file.If the parameter LimitType is **Customize**, you need to configure this parameter.
	LimitVpcs []GetBackupDownloadInfoLimitVpc `pulumi:"limitVpcs"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// This parameter only supports entering In, which means that the custom LimitVpc can download the backup file.
	VpcComparisonSymbol *string `pulumi:"vpcComparisonSymbol"`
}

// A collection of values returned by getBackupDownloadInfo.
type GetBackupDownloadInfoResult struct {
	BackupId string `pulumi:"backupId"`
	// A list of backup file information.
	BackupInfos []GetBackupDownloadInfoBackupInfo `pulumi:"backupInfos"`
	// The provider-assigned unique ID for this managed resource.
	Id                  string                          `pulumi:"id"`
	InstanceId          string                          `pulumi:"instanceId"`
	IpComparisonSymbol  *string                         `pulumi:"ipComparisonSymbol"`
	LimitIps            []string                        `pulumi:"limitIps"`
	LimitType           *string                         `pulumi:"limitType"`
	LimitVpcs           []GetBackupDownloadInfoLimitVpc `pulumi:"limitVpcs"`
	ResultOutputFile    *string                         `pulumi:"resultOutputFile"`
	VpcComparisonSymbol *string                         `pulumi:"vpcComparisonSymbol"`
}

func GetBackupDownloadInfoOutput(ctx *pulumi.Context, args GetBackupDownloadInfoOutputArgs, opts ...pulumi.InvokeOption) GetBackupDownloadInfoResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetBackupDownloadInfoResult, error) {
			args := v.(GetBackupDownloadInfoArgs)
			r, err := GetBackupDownloadInfo(ctx, &args, opts...)
			var s GetBackupDownloadInfoResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetBackupDownloadInfoResultOutput)
}

// A collection of arguments for invoking getBackupDownloadInfo.
type GetBackupDownloadInfoOutputArgs struct {
	// The backup ID, which can be accessed via [DescribeInstanceBackups](https://cloud.tencent.com/document/product/239/20011) interface returns the parameter RedisBackupSet to get.
	BackupId pulumi.StringInput `pulumi:"backupId"`
	// The ID of instance.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Identifies whether the customized LimitIP address can download the backup file.- In: Custom IP addresses are available for download.- NotIn: Custom IPs are not available for download.
	IpComparisonSymbol pulumi.StringPtrInput `pulumi:"ipComparisonSymbol"`
	// A custom VPC IP address for downloadable backup files.If the parameter LimitType is **Customize**, you need to configure this parameter.
	LimitIps pulumi.StringArrayInput `pulumi:"limitIps"`
	// Types of network restrictions for downloading backup files:- NoLimit: There is no limit, and backup files can be downloaded from both Tencent Cloud and internal and external networks.- LimitOnlyIntranet: Only intranet addresses automatically assigned by Tencent Cloud can download backup files.- Customize: refers to a user-defined private network downloadable backup file.
	LimitType pulumi.StringPtrInput `pulumi:"limitType"`
	// A custom VPC ID for a downloadable backup file.If the parameter LimitType is **Customize**, you need to configure this parameter.
	LimitVpcs GetBackupDownloadInfoLimitVpcArrayInput `pulumi:"limitVpcs"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// This parameter only supports entering In, which means that the custom LimitVpc can download the backup file.
	VpcComparisonSymbol pulumi.StringPtrInput `pulumi:"vpcComparisonSymbol"`
}

func (GetBackupDownloadInfoOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupDownloadInfoArgs)(nil)).Elem()
}

// A collection of values returned by getBackupDownloadInfo.
type GetBackupDownloadInfoResultOutput struct{ *pulumi.OutputState }

func (GetBackupDownloadInfoResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetBackupDownloadInfoResult)(nil)).Elem()
}

func (o GetBackupDownloadInfoResultOutput) ToGetBackupDownloadInfoResultOutput() GetBackupDownloadInfoResultOutput {
	return o
}

func (o GetBackupDownloadInfoResultOutput) ToGetBackupDownloadInfoResultOutputWithContext(ctx context.Context) GetBackupDownloadInfoResultOutput {
	return o
}

func (o GetBackupDownloadInfoResultOutput) BackupId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) string { return v.BackupId }).(pulumi.StringOutput)
}

// A list of backup file information.
func (o GetBackupDownloadInfoResultOutput) BackupInfos() GetBackupDownloadInfoBackupInfoArrayOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) []GetBackupDownloadInfoBackupInfo { return v.BackupInfos }).(GetBackupDownloadInfoBackupInfoArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetBackupDownloadInfoResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetBackupDownloadInfoResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetBackupDownloadInfoResultOutput) IpComparisonSymbol() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) *string { return v.IpComparisonSymbol }).(pulumi.StringPtrOutput)
}

func (o GetBackupDownloadInfoResultOutput) LimitIps() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) []string { return v.LimitIps }).(pulumi.StringArrayOutput)
}

func (o GetBackupDownloadInfoResultOutput) LimitType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) *string { return v.LimitType }).(pulumi.StringPtrOutput)
}

func (o GetBackupDownloadInfoResultOutput) LimitVpcs() GetBackupDownloadInfoLimitVpcArrayOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) []GetBackupDownloadInfoLimitVpc { return v.LimitVpcs }).(GetBackupDownloadInfoLimitVpcArrayOutput)
}

func (o GetBackupDownloadInfoResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetBackupDownloadInfoResultOutput) VpcComparisonSymbol() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetBackupDownloadInfoResult) *string { return v.VpcComparisonSymbol }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetBackupDownloadInfoResultOutput{})
}
