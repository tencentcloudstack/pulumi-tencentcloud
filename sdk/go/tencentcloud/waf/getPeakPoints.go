// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package waf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of waf peakPoints
//
// ## Example Usage
//
// ### Basic Query
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Waf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Waf.GetPeakPoints(ctx, &waf.GetPeakPointsArgs{
//				FromTime: "2023-09-01 00:00:00",
//				ToTime:   "2023-09-07 00:00:00",
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
//
// ### Query by filter
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Waf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Waf.GetPeakPoints(ctx, &waf.GetPeakPointsArgs{
//				Domain:     pulumi.StringRef("domain.com"),
//				Edition:    pulumi.StringRef("clb-waf"),
//				FromTime:   "2023-09-01 00:00:00",
//				InstanceId: pulumi.StringRef("waf_2kxtlbky00b2v1fn"),
//				MetricName: pulumi.StringRef("access"),
//				ToTime:     "2023-09-07 00:00:00",
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
func GetPeakPoints(ctx *pulumi.Context, args *GetPeakPointsArgs, opts ...pulumi.InvokeOption) (*GetPeakPointsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetPeakPointsResult
	err := ctx.Invoke("tencentcloud:Waf/getPeakPoints:getPeakPoints", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPeakPoints.
type GetPeakPointsArgs struct {
	// The domain name to be queried. If all domain name data is queried, this parameter is not filled in.
	Domain *string `pulumi:"domain"`
	// Only support sparta-waf and clb-waf. If not passed, there will be no filtering.
	Edition *string `pulumi:"edition"`
	// Begin time.
	FromTime string `pulumi:"fromTime"`
	// WAF instance ID, if not passed, there will be no filtering.
	InstanceId *string `pulumi:"instanceId"`
	// Thirteen values are available: access-Peak qps trend chart; botAccess- bot peak qps trend chart; down-Downstream peak bandwidth trend chart; up-Upstream peak bandwidth trend chart; attack-Trend chart of total number of web attacks; cc-Trend chart of total number of CC attacks; StatusServerError-Trend chart of the number of status codes returned by WAF to the server; StatusClientError-Trend chart of the number of status codes returned by WAF to the client; StatusRedirect-Trend chart of the number of status codes returned by WAF to the client; StatusOk-Trend chart of the number of status codes returned by WAF to the client; UpstreamServerError-Trend chart of the number of status codes returned to WAF by the origin site; UpstreamClientError-Trend chart of the number of status codes returned to WAF by the origin site; UpstreamRedirect-Trend chart of the number of status codes returned to WAF by the origin site.
	MetricName *string `pulumi:"metricName"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// End time.
	ToTime string `pulumi:"toTime"`
}

// A collection of values returned by getPeakPoints.
type GetPeakPointsResult struct {
	Domain   *string `pulumi:"domain"`
	Edition  *string `pulumi:"edition"`
	FromTime string  `pulumi:"fromTime"`
	// The provider-assigned unique ID for this managed resource.
	Id         string  `pulumi:"id"`
	InstanceId *string `pulumi:"instanceId"`
	MetricName *string `pulumi:"metricName"`
	// point list.
	Points           []GetPeakPointsPoint `pulumi:"points"`
	ResultOutputFile *string              `pulumi:"resultOutputFile"`
	ToTime           string               `pulumi:"toTime"`
}

func GetPeakPointsOutput(ctx *pulumi.Context, args GetPeakPointsOutputArgs, opts ...pulumi.InvokeOption) GetPeakPointsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetPeakPointsResult, error) {
			args := v.(GetPeakPointsArgs)
			r, err := GetPeakPoints(ctx, &args, opts...)
			var s GetPeakPointsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetPeakPointsResultOutput)
}

// A collection of arguments for invoking getPeakPoints.
type GetPeakPointsOutputArgs struct {
	// The domain name to be queried. If all domain name data is queried, this parameter is not filled in.
	Domain pulumi.StringPtrInput `pulumi:"domain"`
	// Only support sparta-waf and clb-waf. If not passed, there will be no filtering.
	Edition pulumi.StringPtrInput `pulumi:"edition"`
	// Begin time.
	FromTime pulumi.StringInput `pulumi:"fromTime"`
	// WAF instance ID, if not passed, there will be no filtering.
	InstanceId pulumi.StringPtrInput `pulumi:"instanceId"`
	// Thirteen values are available: access-Peak qps trend chart; botAccess- bot peak qps trend chart; down-Downstream peak bandwidth trend chart; up-Upstream peak bandwidth trend chart; attack-Trend chart of total number of web attacks; cc-Trend chart of total number of CC attacks; StatusServerError-Trend chart of the number of status codes returned by WAF to the server; StatusClientError-Trend chart of the number of status codes returned by WAF to the client; StatusRedirect-Trend chart of the number of status codes returned by WAF to the client; StatusOk-Trend chart of the number of status codes returned by WAF to the client; UpstreamServerError-Trend chart of the number of status codes returned to WAF by the origin site; UpstreamClientError-Trend chart of the number of status codes returned to WAF by the origin site; UpstreamRedirect-Trend chart of the number of status codes returned to WAF by the origin site.
	MetricName pulumi.StringPtrInput `pulumi:"metricName"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// End time.
	ToTime pulumi.StringInput `pulumi:"toTime"`
}

func (GetPeakPointsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPeakPointsArgs)(nil)).Elem()
}

// A collection of values returned by getPeakPoints.
type GetPeakPointsResultOutput struct{ *pulumi.OutputState }

func (GetPeakPointsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetPeakPointsResult)(nil)).Elem()
}

func (o GetPeakPointsResultOutput) ToGetPeakPointsResultOutput() GetPeakPointsResultOutput {
	return o
}

func (o GetPeakPointsResultOutput) ToGetPeakPointsResultOutputWithContext(ctx context.Context) GetPeakPointsResultOutput {
	return o
}

func (o GetPeakPointsResultOutput) Domain() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPeakPointsResult) *string { return v.Domain }).(pulumi.StringPtrOutput)
}

func (o GetPeakPointsResultOutput) Edition() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPeakPointsResult) *string { return v.Edition }).(pulumi.StringPtrOutput)
}

func (o GetPeakPointsResultOutput) FromTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetPeakPointsResult) string { return v.FromTime }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetPeakPointsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetPeakPointsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetPeakPointsResultOutput) InstanceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPeakPointsResult) *string { return v.InstanceId }).(pulumi.StringPtrOutput)
}

func (o GetPeakPointsResultOutput) MetricName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPeakPointsResult) *string { return v.MetricName }).(pulumi.StringPtrOutput)
}

// point list.
func (o GetPeakPointsResultOutput) Points() GetPeakPointsPointArrayOutput {
	return o.ApplyT(func(v GetPeakPointsResult) []GetPeakPointsPoint { return v.Points }).(GetPeakPointsPointArrayOutput)
}

func (o GetPeakPointsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetPeakPointsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetPeakPointsResultOutput) ToTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetPeakPointsResult) string { return v.ToTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetPeakPointsResultOutput{})
}
