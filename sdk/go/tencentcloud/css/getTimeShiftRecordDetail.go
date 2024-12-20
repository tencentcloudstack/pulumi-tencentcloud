// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package css

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of css timeShiftRecordDetail
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Css"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Css.GetTimeShiftRecordDetail(ctx, &css.GetTimeShiftRecordDetailArgs{
//				AppName:     "qqq",
//				Domain:      "177154.push.tlivecloud.com",
//				DomainGroup: pulumi.StringRef("tf-test"),
//				EndTime:     1698820641,
//				StartTime:   1698768000,
//				StreamName:  "live",
//				TransCodeId: pulumi.IntRef(0),
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
func GetTimeShiftRecordDetail(ctx *pulumi.Context, args *GetTimeShiftRecordDetailArgs, opts ...pulumi.InvokeOption) (*GetTimeShiftRecordDetailResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetTimeShiftRecordDetailResult
	err := ctx.Invoke("tencentcloud:Css/getTimeShiftRecordDetail:getTimeShiftRecordDetail", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTimeShiftRecordDetail.
type GetTimeShiftRecordDetailArgs struct {
	// Push path.
	AppName string `pulumi:"appName"`
	// Push domain.
	Domain string `pulumi:"domain"`
	// The streaming domain belongs to a group. If there is no domain group or the domain group is an empty string, it can be left blank.
	DomainGroup *string `pulumi:"domainGroup"`
	// The ending time of the query range is specified in Unix timestamp.
	EndTime int `pulumi:"endTime"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// The starting time of the query range is specified in Unix timestamp.
	StartTime int `pulumi:"startTime"`
	// Stream name.
	StreamName string `pulumi:"streamName"`
	// The transcoding template ID can be left blank if it is 0.
	TransCodeId *int `pulumi:"transCodeId"`
}

// A collection of values returned by getTimeShiftRecordDetail.
type GetTimeShiftRecordDetailResult struct {
	AppName     string  `pulumi:"appName"`
	Domain      string  `pulumi:"domain"`
	DomainGroup *string `pulumi:"domainGroup"`
	// The end time of the recording session is specified in Unix timestamp.
	EndTime int `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The array of time-shift recording sessions.Note: This field may return null, indicating that no valid value was found.
	RecordLists      []GetTimeShiftRecordDetailRecordList `pulumi:"recordLists"`
	ResultOutputFile *string                              `pulumi:"resultOutputFile"`
	// The start time of the recording session is specified in Unix timestamp.
	StartTime   int    `pulumi:"startTime"`
	StreamName  string `pulumi:"streamName"`
	TransCodeId *int   `pulumi:"transCodeId"`
}

func GetTimeShiftRecordDetailOutput(ctx *pulumi.Context, args GetTimeShiftRecordDetailOutputArgs, opts ...pulumi.InvokeOption) GetTimeShiftRecordDetailResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTimeShiftRecordDetailResult, error) {
			args := v.(GetTimeShiftRecordDetailArgs)
			r, err := GetTimeShiftRecordDetail(ctx, &args, opts...)
			var s GetTimeShiftRecordDetailResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTimeShiftRecordDetailResultOutput)
}

// A collection of arguments for invoking getTimeShiftRecordDetail.
type GetTimeShiftRecordDetailOutputArgs struct {
	// Push path.
	AppName pulumi.StringInput `pulumi:"appName"`
	// Push domain.
	Domain pulumi.StringInput `pulumi:"domain"`
	// The streaming domain belongs to a group. If there is no domain group or the domain group is an empty string, it can be left blank.
	DomainGroup pulumi.StringPtrInput `pulumi:"domainGroup"`
	// The ending time of the query range is specified in Unix timestamp.
	EndTime pulumi.IntInput `pulumi:"endTime"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// The starting time of the query range is specified in Unix timestamp.
	StartTime pulumi.IntInput `pulumi:"startTime"`
	// Stream name.
	StreamName pulumi.StringInput `pulumi:"streamName"`
	// The transcoding template ID can be left blank if it is 0.
	TransCodeId pulumi.IntPtrInput `pulumi:"transCodeId"`
}

func (GetTimeShiftRecordDetailOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTimeShiftRecordDetailArgs)(nil)).Elem()
}

// A collection of values returned by getTimeShiftRecordDetail.
type GetTimeShiftRecordDetailResultOutput struct{ *pulumi.OutputState }

func (GetTimeShiftRecordDetailResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTimeShiftRecordDetailResult)(nil)).Elem()
}

func (o GetTimeShiftRecordDetailResultOutput) ToGetTimeShiftRecordDetailResultOutput() GetTimeShiftRecordDetailResultOutput {
	return o
}

func (o GetTimeShiftRecordDetailResultOutput) ToGetTimeShiftRecordDetailResultOutputWithContext(ctx context.Context) GetTimeShiftRecordDetailResultOutput {
	return o
}

func (o GetTimeShiftRecordDetailResultOutput) AppName() pulumi.StringOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) string { return v.AppName }).(pulumi.StringOutput)
}

func (o GetTimeShiftRecordDetailResultOutput) Domain() pulumi.StringOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) string { return v.Domain }).(pulumi.StringOutput)
}

func (o GetTimeShiftRecordDetailResultOutput) DomainGroup() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) *string { return v.DomainGroup }).(pulumi.StringPtrOutput)
}

// The end time of the recording session is specified in Unix timestamp.
func (o GetTimeShiftRecordDetailResultOutput) EndTime() pulumi.IntOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) int { return v.EndTime }).(pulumi.IntOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetTimeShiftRecordDetailResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) string { return v.Id }).(pulumi.StringOutput)
}

// The array of time-shift recording sessions.Note: This field may return null, indicating that no valid value was found.
func (o GetTimeShiftRecordDetailResultOutput) RecordLists() GetTimeShiftRecordDetailRecordListArrayOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) []GetTimeShiftRecordDetailRecordList { return v.RecordLists }).(GetTimeShiftRecordDetailRecordListArrayOutput)
}

func (o GetTimeShiftRecordDetailResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// The start time of the recording session is specified in Unix timestamp.
func (o GetTimeShiftRecordDetailResultOutput) StartTime() pulumi.IntOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) int { return v.StartTime }).(pulumi.IntOutput)
}

func (o GetTimeShiftRecordDetailResultOutput) StreamName() pulumi.StringOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) string { return v.StreamName }).(pulumi.StringOutput)
}

func (o GetTimeShiftRecordDetailResultOutput) TransCodeId() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetTimeShiftRecordDetailResult) *int { return v.TransCodeId }).(pulumi.IntPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTimeShiftRecordDetailResultOutput{})
}
