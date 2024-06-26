// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package antiddos

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of antiddos overviewAttackTrend
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Antiddos"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Antiddos.GetOverviewAttackTrend(ctx, &antiddos.GetOverviewAttackTrendArgs{
//				Dimension: "attackcount",
//				EndTime:   "2023-11-22 10:28:31",
//				Period:    86400,
//				StartTime: "2023-11-21 10:28:31",
//				Type:      "ddos",
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
func GetOverviewAttackTrend(ctx *pulumi.Context, args *GetOverviewAttackTrendArgs, opts ...pulumi.InvokeOption) (*GetOverviewAttackTrendResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetOverviewAttackTrendResult
	err := ctx.Invoke("tencentcloud:Antiddos/getOverviewAttackTrend:getOverviewAttackTrend", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOverviewAttackTrend.
type GetOverviewAttackTrendArgs struct {
	// Latitude, currently only attackcount is supported.
	Dimension string `pulumi:"dimension"`
	// Protection Overview Attack Trend End Time.
	EndTime string `pulumi:"endTime"`
	// Period, currently only 86400 is supported.
	Period int `pulumi:"period"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Protection Overview Attack Trend Start Time.
	StartTime string `pulumi:"startTime"`
	// Attack type: cc, ddos.
	Type string `pulumi:"type"`
}

// A collection of values returned by getOverviewAttackTrend.
type GetOverviewAttackTrendResult struct {
	// Number of attacks per cycle point.
	Datas     []int  `pulumi:"datas"`
	Dimension string `pulumi:"dimension"`
	EndTime   string `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id     string `pulumi:"id"`
	Period int    `pulumi:"period"`
	// Number of period points included.
	PeriodPointCount int     `pulumi:"periodPointCount"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartTime        string  `pulumi:"startTime"`
	Type             string  `pulumi:"type"`
}

func GetOverviewAttackTrendOutput(ctx *pulumi.Context, args GetOverviewAttackTrendOutputArgs, opts ...pulumi.InvokeOption) GetOverviewAttackTrendResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetOverviewAttackTrendResult, error) {
			args := v.(GetOverviewAttackTrendArgs)
			r, err := GetOverviewAttackTrend(ctx, &args, opts...)
			var s GetOverviewAttackTrendResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetOverviewAttackTrendResultOutput)
}

// A collection of arguments for invoking getOverviewAttackTrend.
type GetOverviewAttackTrendOutputArgs struct {
	// Latitude, currently only attackcount is supported.
	Dimension pulumi.StringInput `pulumi:"dimension"`
	// Protection Overview Attack Trend End Time.
	EndTime pulumi.StringInput `pulumi:"endTime"`
	// Period, currently only 86400 is supported.
	Period pulumi.IntInput `pulumi:"period"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Protection Overview Attack Trend Start Time.
	StartTime pulumi.StringInput `pulumi:"startTime"`
	// Attack type: cc, ddos.
	Type pulumi.StringInput `pulumi:"type"`
}

func (GetOverviewAttackTrendOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOverviewAttackTrendArgs)(nil)).Elem()
}

// A collection of values returned by getOverviewAttackTrend.
type GetOverviewAttackTrendResultOutput struct{ *pulumi.OutputState }

func (GetOverviewAttackTrendResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOverviewAttackTrendResult)(nil)).Elem()
}

func (o GetOverviewAttackTrendResultOutput) ToGetOverviewAttackTrendResultOutput() GetOverviewAttackTrendResultOutput {
	return o
}

func (o GetOverviewAttackTrendResultOutput) ToGetOverviewAttackTrendResultOutputWithContext(ctx context.Context) GetOverviewAttackTrendResultOutput {
	return o
}

// Number of attacks per cycle point.
func (o GetOverviewAttackTrendResultOutput) Datas() pulumi.IntArrayOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) []int { return v.Datas }).(pulumi.IntArrayOutput)
}

func (o GetOverviewAttackTrendResultOutput) Dimension() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) string { return v.Dimension }).(pulumi.StringOutput)
}

func (o GetOverviewAttackTrendResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) string { return v.EndTime }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetOverviewAttackTrendResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetOverviewAttackTrendResultOutput) Period() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) int { return v.Period }).(pulumi.IntOutput)
}

// Number of period points included.
func (o GetOverviewAttackTrendResultOutput) PeriodPointCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) int { return v.PeriodPointCount }).(pulumi.IntOutput)
}

func (o GetOverviewAttackTrendResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetOverviewAttackTrendResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func (o GetOverviewAttackTrendResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewAttackTrendResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetOverviewAttackTrendResultOutput{})
}
