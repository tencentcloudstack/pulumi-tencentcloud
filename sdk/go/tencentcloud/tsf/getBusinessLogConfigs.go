// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tsf

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of tsf businessLogConfigs
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tsf"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Tsf.GetBusinessLogConfigs(ctx, &tsf.GetBusinessLogConfigsArgs{
//				ConfigIdLists: []string{
//					"apm-busi-log-cfg-qv3x3rdv",
//				},
//				DisableProgramAuthCheck: pulumi.BoolRef(true),
//				SearchWord:              pulumi.StringRef("terraform"),
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
func LookupBusinessLogConfigs(ctx *pulumi.Context, args *LookupBusinessLogConfigsArgs, opts ...pulumi.InvokeOption) (*LookupBusinessLogConfigsResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv LookupBusinessLogConfigsResult
	err := ctx.Invoke("tencentcloud:Tsf/getBusinessLogConfigs:getBusinessLogConfigs", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getBusinessLogConfigs.
type LookupBusinessLogConfigsArgs struct {
	// Config Id list.
	ConfigIdLists []string `pulumi:"configIdLists"`
	// Disable Program auth check or not.
	DisableProgramAuthCheck *bool `pulumi:"disableProgramAuthCheck"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// wild search word.
	SearchWord *string `pulumi:"searchWord"`
}

// A collection of values returned by getBusinessLogConfigs.
type LookupBusinessLogConfigsResult struct {
	ConfigIdLists           []string `pulumi:"configIdLists"`
	DisableProgramAuthCheck *bool    `pulumi:"disableProgramAuthCheck"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// List of business log configurations.Note: This field may return null, indicating that no valid values can be obtained.
	Results    []GetBusinessLogConfigsResult `pulumi:"results"`
	SearchWord *string                       `pulumi:"searchWord"`
}

func LookupBusinessLogConfigsOutput(ctx *pulumi.Context, args LookupBusinessLogConfigsOutputArgs, opts ...pulumi.InvokeOption) LookupBusinessLogConfigsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupBusinessLogConfigsResult, error) {
			args := v.(LookupBusinessLogConfigsArgs)
			r, err := LookupBusinessLogConfigs(ctx, &args, opts...)
			var s LookupBusinessLogConfigsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupBusinessLogConfigsResultOutput)
}

// A collection of arguments for invoking getBusinessLogConfigs.
type LookupBusinessLogConfigsOutputArgs struct {
	// Config Id list.
	ConfigIdLists pulumi.StringArrayInput `pulumi:"configIdLists"`
	// Disable Program auth check or not.
	DisableProgramAuthCheck pulumi.BoolPtrInput `pulumi:"disableProgramAuthCheck"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// wild search word.
	SearchWord pulumi.StringPtrInput `pulumi:"searchWord"`
}

func (LookupBusinessLogConfigsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBusinessLogConfigsArgs)(nil)).Elem()
}

// A collection of values returned by getBusinessLogConfigs.
type LookupBusinessLogConfigsResultOutput struct{ *pulumi.OutputState }

func (LookupBusinessLogConfigsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupBusinessLogConfigsResult)(nil)).Elem()
}

func (o LookupBusinessLogConfigsResultOutput) ToLookupBusinessLogConfigsResultOutput() LookupBusinessLogConfigsResultOutput {
	return o
}

func (o LookupBusinessLogConfigsResultOutput) ToLookupBusinessLogConfigsResultOutputWithContext(ctx context.Context) LookupBusinessLogConfigsResultOutput {
	return o
}

func (o LookupBusinessLogConfigsResultOutput) ConfigIdLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) []string { return v.ConfigIdLists }).(pulumi.StringArrayOutput)
}

func (o LookupBusinessLogConfigsResultOutput) DisableProgramAuthCheck() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) *bool { return v.DisableProgramAuthCheck }).(pulumi.BoolPtrOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupBusinessLogConfigsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupBusinessLogConfigsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// List of business log configurations.Note: This field may return null, indicating that no valid values can be obtained.
func (o LookupBusinessLogConfigsResultOutput) Results() GetBusinessLogConfigsResultArrayOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) []GetBusinessLogConfigsResult { return v.Results }).(GetBusinessLogConfigsResultArrayOutput)
}

func (o LookupBusinessLogConfigsResultOutput) SearchWord() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupBusinessLogConfigsResult) *string { return v.SearchWord }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupBusinessLogConfigsResultOutput{})
}
