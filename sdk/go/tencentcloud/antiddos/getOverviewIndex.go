// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package antiddos

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of antiddos overview index
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
//			_, err := Antiddos.GetOverviewIndex(ctx, &antiddos.GetOverviewIndexArgs{
//				EndTime:   "2023-11-21 12:32:12",
//				StartTime: "2023-11-20 12:32:12",
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
func GetOverviewIndex(ctx *pulumi.Context, args *GetOverviewIndexArgs, opts ...pulumi.InvokeOption) (*GetOverviewIndexResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetOverviewIndexResult
	err := ctx.Invoke("tencentcloud:Antiddos/getOverviewIndex:getOverviewIndex", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getOverviewIndex.
type GetOverviewIndexArgs struct {
	// EndTime.
	EndTime string `pulumi:"endTime"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// StartTime.
	StartTime string `pulumi:"startTime"`
}

// A collection of values returned by getOverviewIndex.
type GetOverviewIndexResult struct {
	// ip count.
	AllIpCount int `pulumi:"allIpCount"`
	// AntiddosDomainCount.
	AntiddosDomainCount int `pulumi:"antiddosDomainCount"`
	// Total number of advanced defense IPs (including advanced defense packets and advanced defense IPs).
	AntiddosIpCount int `pulumi:"antiddosIpCount"`
	// AttackDomainCount.
	AttackDomainCount int `pulumi:"attackDomainCount"`
	// AttackIpCount.
	AttackIpCount int `pulumi:"attackIpCount"`
	// BlockIpCount.
	BlockIpCount int    `pulumi:"blockIpCount"`
	EndTime      string `pulumi:"endTime"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// MaxAttackFlow.
	MaxAttackFlow int `pulumi:"maxAttackFlow"`
	// The IP address in the most recent attack.
	NewAttackIp string `pulumi:"newAttackIp"`
	// The time in the most recent attack.
	NewAttackTime string `pulumi:"newAttackTime"`
	// The type in the most recent attack.
	NewAttackType    string  `pulumi:"newAttackType"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	StartTime        string  `pulumi:"startTime"`
}

func GetOverviewIndexOutput(ctx *pulumi.Context, args GetOverviewIndexOutputArgs, opts ...pulumi.InvokeOption) GetOverviewIndexResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetOverviewIndexResult, error) {
			args := v.(GetOverviewIndexArgs)
			r, err := GetOverviewIndex(ctx, &args, opts...)
			var s GetOverviewIndexResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetOverviewIndexResultOutput)
}

// A collection of arguments for invoking getOverviewIndex.
type GetOverviewIndexOutputArgs struct {
	// EndTime.
	EndTime pulumi.StringInput `pulumi:"endTime"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// StartTime.
	StartTime pulumi.StringInput `pulumi:"startTime"`
}

func (GetOverviewIndexOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOverviewIndexArgs)(nil)).Elem()
}

// A collection of values returned by getOverviewIndex.
type GetOverviewIndexResultOutput struct{ *pulumi.OutputState }

func (GetOverviewIndexResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetOverviewIndexResult)(nil)).Elem()
}

func (o GetOverviewIndexResultOutput) ToGetOverviewIndexResultOutput() GetOverviewIndexResultOutput {
	return o
}

func (o GetOverviewIndexResultOutput) ToGetOverviewIndexResultOutputWithContext(ctx context.Context) GetOverviewIndexResultOutput {
	return o
}

// ip count.
func (o GetOverviewIndexResultOutput) AllIpCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.AllIpCount }).(pulumi.IntOutput)
}

// AntiddosDomainCount.
func (o GetOverviewIndexResultOutput) AntiddosDomainCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.AntiddosDomainCount }).(pulumi.IntOutput)
}

// Total number of advanced defense IPs (including advanced defense packets and advanced defense IPs).
func (o GetOverviewIndexResultOutput) AntiddosIpCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.AntiddosIpCount }).(pulumi.IntOutput)
}

// AttackDomainCount.
func (o GetOverviewIndexResultOutput) AttackDomainCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.AttackDomainCount }).(pulumi.IntOutput)
}

// AttackIpCount.
func (o GetOverviewIndexResultOutput) AttackIpCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.AttackIpCount }).(pulumi.IntOutput)
}

// BlockIpCount.
func (o GetOverviewIndexResultOutput) BlockIpCount() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.BlockIpCount }).(pulumi.IntOutput)
}

func (o GetOverviewIndexResultOutput) EndTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.EndTime }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetOverviewIndexResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.Id }).(pulumi.StringOutput)
}

// MaxAttackFlow.
func (o GetOverviewIndexResultOutput) MaxAttackFlow() pulumi.IntOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) int { return v.MaxAttackFlow }).(pulumi.IntOutput)
}

// The IP address in the most recent attack.
func (o GetOverviewIndexResultOutput) NewAttackIp() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.NewAttackIp }).(pulumi.StringOutput)
}

// The time in the most recent attack.
func (o GetOverviewIndexResultOutput) NewAttackTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.NewAttackTime }).(pulumi.StringOutput)
}

// The type in the most recent attack.
func (o GetOverviewIndexResultOutput) NewAttackType() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.NewAttackType }).(pulumi.StringOutput)
}

func (o GetOverviewIndexResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetOverviewIndexResultOutput) StartTime() pulumi.StringOutput {
	return o.ApplyT(func(v GetOverviewIndexResult) string { return v.StartTime }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetOverviewIndexResultOutput{})
}
