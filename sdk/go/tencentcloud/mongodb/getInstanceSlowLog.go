// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mongodb

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of mongodb instanceSlowLog
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Mongodb"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mongodb"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Mongodb.GetInstanceSlowLog(ctx, &mongodb.GetInstanceSlowLogArgs{
// 			EndTime:    "2019-06-02 12:00:00",
// 			Format:     pulumi.StringRef("json"),
// 			InstanceId: "cmgo-9d0p6umb",
// 			SlowMS:     100,
// 			StartTime:  "2019-06-01 10:00:00",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetInstanceSlowLog(ctx *pulumi.Context, args *GetInstanceSlowLogArgs, opts ...pulumi.InvokeOption) (*GetInstanceSlowLogResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetInstanceSlowLogResult
	err := ctx.Invoke("tencentcloud:Mongodb/getInstanceSlowLog:getInstanceSlowLog", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstanceSlowLog.
type GetInstanceSlowLogArgs struct {
	// Slow log termination time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-02 12:00:00.The time interval between the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
	EndTime string `pulumi:"endTime"`
	// Slow log return format. By default, the original slow log format is returned,and versions 4.4 and above can be set to json.
	Format *string `pulumi:"format"`
	// Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Slow log execution time threshold, return slow logs whose execution time exceeds this threshold,the unit is milliseconds (ms), and the minimum is 100 milliseconds.
	SlowMs int `pulumi:"slowMs"`
	// Slow log start time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-01 10:00:00. The time intervalbetween the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
	StartTime string `pulumi:"startTime"`
}

// A collection of values returned by getInstanceSlowLog.
type GetInstanceSlowLogResult struct {
	EndTime string  `pulumi:"endTime"`
	Format  *string `pulumi:"format"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// details of slow logs.
	SlowLogs  []string `pulumi:"slowLogs"`
	SlowMs    int      `pulumi:"slowMs"`
	StartTime string   `pulumi:"startTime"`
}

func GetInstanceSlowLogOutput(ctx *pulumi.Context, args GetInstanceSlowLogOutputArgs, opts ...pulumi.InvokeOption) GetInstanceSlowLogResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetInstanceSlowLogResult, error) {
			args := v.(GetInstanceSlowLogArgs)
			r, err := GetInstanceSlowLog(ctx, &args, opts...)
			var s GetInstanceSlowLogResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetInstanceSlowLogResultOutput)
}

// A collection of arguments for invoking getInstanceSlowLog.
type GetInstanceSlowLogOutputArgs struct {
	// Slow log termination time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-02 12:00:00.The time interval between the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
	EndTime pulumi.StringInput `pulumi:"endTime"`
	// Slow log return format. By default, the original slow log format is returned,and versions 4.4 and above can be set to json.
	Format pulumi.StringPtrInput `pulumi:"format"`
	// Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Slow log execution time threshold, return slow logs whose execution time exceeds this threshold,the unit is milliseconds (ms), and the minimum is 100 milliseconds.
	SlowMs pulumi.IntInput `pulumi:"slowMs"`
	// Slow log start time, format: yyyy-mm-dd hh:mm:ss, such as: 2019-06-01 10:00:00. The time intervalbetween the start and end of the query cannot exceed 24 hours,and only slow logs within the last 7 days are allowed to be queried.
	StartTime pulumi.StringInput `pulumi:"startTime"`
}

func (GetInstanceSlowLogOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceSlowLogArgs)(nil)).Elem()
}

// A collection of values returned by getInstanceSlowLog.
type GetInstanceSlowLogResultOutput struct{ *pulumi.OutputState }

func (GetInstanceSlowLogResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceSlowLogResult)(nil)).Elem()
}

func (o GetInstanceSlowLogResultOutput) ToGetInstanceSlowLogResultOutput() GetInstanceSlowLogResultOutput {
	return o
}

func (o GetInstanceSlowLogResultOutput) ToGetInstanceSlowLogResultOutputWithContext(ctx context.Context) GetInstanceSlowLogResultOutput {
	return o
}

func (o GetInstanceSlowLogResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) string { return v.EndTime }).(pulumi.StringOutput)
}

func (o GetInstanceSlowLogResultOutput) Format() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) *string { return v.Format }).(pulumi.StringPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInstanceSlowLogResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInstanceSlowLogResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetInstanceSlowLogResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// details of slow logs.
func (o GetInstanceSlowLogResultOutput) SlowLogs() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) []string { return v.SlowLogs }).(pulumi.StringArrayOutput)
}

func (o GetInstanceSlowLogResultOutput) SlowMs() pulumi.IntOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) int { return v.SlowMs }).(pulumi.IntOutput)
}

func (o GetInstanceSlowLogResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceSlowLogResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInstanceSlowLogResultOutput{})
}