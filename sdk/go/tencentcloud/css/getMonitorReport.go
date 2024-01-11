// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package css

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of css monitorReport
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Css"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Css"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Css.GetMonitorReport(ctx, &css.GetMonitorReportArgs{
// 			MonitorId: "0e8a12b5-df2a-4a1b-aa98-97d5610aa142",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetMonitorReport(ctx *pulumi.Context, args *GetMonitorReportArgs, opts ...pulumi.InvokeOption) (*GetMonitorReportResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetMonitorReportResult
	err := ctx.Invoke("tencentcloud:Css/getMonitorReport:getMonitorReport", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getMonitorReport.
type GetMonitorReportArgs struct {
	// Monitor ID.
	MonitorId string `pulumi:"monitorId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getMonitorReport.
type GetMonitorReportResult struct {
	// The information about the media diagnostic result.Note: This field may return null, indicating that no valid value was found.
	DiagnoseResults []GetMonitorReportDiagnoseResult `pulumi:"diagnoseResults"`
	// The provider-assigned unique ID for this managed resource.
	Id        string `pulumi:"id"`
	MonitorId string `pulumi:"monitorId"`
	// The information about the media processing result.Note: This field may return null, indicating that no valid value was found.
	MpsResults       []GetMonitorReportMpsResult `pulumi:"mpsResults"`
	ResultOutputFile *string                     `pulumi:"resultOutputFile"`
}

func GetMonitorReportOutput(ctx *pulumi.Context, args GetMonitorReportOutputArgs, opts ...pulumi.InvokeOption) GetMonitorReportResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetMonitorReportResult, error) {
			args := v.(GetMonitorReportArgs)
			r, err := GetMonitorReport(ctx, &args, opts...)
			var s GetMonitorReportResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetMonitorReportResultOutput)
}

// A collection of arguments for invoking getMonitorReport.
type GetMonitorReportOutputArgs struct {
	// Monitor ID.
	MonitorId pulumi.StringInput `pulumi:"monitorId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetMonitorReportOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMonitorReportArgs)(nil)).Elem()
}

// A collection of values returned by getMonitorReport.
type GetMonitorReportResultOutput struct{ *pulumi.OutputState }

func (GetMonitorReportResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetMonitorReportResult)(nil)).Elem()
}

func (o GetMonitorReportResultOutput) ToGetMonitorReportResultOutput() GetMonitorReportResultOutput {
	return o
}

func (o GetMonitorReportResultOutput) ToGetMonitorReportResultOutputWithContext(ctx context.Context) GetMonitorReportResultOutput {
	return o
}

// The information about the media diagnostic result.Note: This field may return null, indicating that no valid value was found.
func (o GetMonitorReportResultOutput) DiagnoseResults() GetMonitorReportDiagnoseResultArrayOutput {
	return o.ApplyT(func(v GetMonitorReportResult) []GetMonitorReportDiagnoseResult { return v.DiagnoseResults }).(GetMonitorReportDiagnoseResultArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetMonitorReportResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetMonitorReportResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetMonitorReportResultOutput) MonitorId() pulumi.StringOutput {
	return o.ApplyT(func(v GetMonitorReportResult) string { return v.MonitorId }).(pulumi.StringOutput)
}

// The information about the media processing result.Note: This field may return null, indicating that no valid value was found.
func (o GetMonitorReportResultOutput) MpsResults() GetMonitorReportMpsResultArrayOutput {
	return o.ApplyT(func(v GetMonitorReportResult) []GetMonitorReportMpsResult { return v.MpsResults }).(GetMonitorReportMpsResultArrayOutput)
}

func (o GetMonitorReportResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetMonitorReportResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetMonitorReportResultOutput{})
}