// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package postgresql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of postgresql parameterTemplates
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Postgresql"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Postgresql.GetParameterTemplates(ctx, &postgresql.GetParameterTemplatesArgs{
//				Filters: []postgresql.GetParameterTemplatesFilter{
//					{
//						Name: pulumi.StringRef("TemplateName"),
//						Values: []string{
//							"temp_name",
//						},
//					},
//					{
//						Name: pulumi.StringRef("DBEngine"),
//						Values: []string{
//							"postgresql",
//						},
//					},
//				},
//				OrderBy:     pulumi.StringRef("CreateTime"),
//				OrderByType: pulumi.StringRef("desc"),
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
func GetParameterTemplates(ctx *pulumi.Context, args *GetParameterTemplatesArgs, opts ...pulumi.InvokeOption) (*GetParameterTemplatesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetParameterTemplatesResult
	err := ctx.Invoke("tencentcloud:Postgresql/getParameterTemplates:getParameterTemplates", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getParameterTemplates.
type GetParameterTemplatesArgs struct {
	// Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
	Filters []GetParameterTemplatesFilter `pulumi:"filters"`
	// Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
	OrderBy *string `pulumi:"orderBy"`
	// Sorting order. Valid values:asc (ascending order),desc (descending order).
	OrderByType *string `pulumi:"orderByType"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getParameterTemplates.
type GetParameterTemplatesResult struct {
	Filters []GetParameterTemplatesFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// list of parameter templates.
	Lists            []GetParameterTemplatesList `pulumi:"lists"`
	OrderBy          *string                     `pulumi:"orderBy"`
	OrderByType      *string                     `pulumi:"orderByType"`
	ResultOutputFile *string                     `pulumi:"resultOutputFile"`
}

func GetParameterTemplatesOutput(ctx *pulumi.Context, args GetParameterTemplatesOutputArgs, opts ...pulumi.InvokeOption) GetParameterTemplatesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetParameterTemplatesResult, error) {
			args := v.(GetParameterTemplatesArgs)
			r, err := GetParameterTemplates(ctx, &args, opts...)
			var s GetParameterTemplatesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetParameterTemplatesResultOutput)
}

// A collection of arguments for invoking getParameterTemplates.
type GetParameterTemplatesOutputArgs struct {
	// Filter conditions. Valid values:TemplateName, TemplateId, DBMajorVersion, DBEngine.
	Filters GetParameterTemplatesFilterArrayInput `pulumi:"filters"`
	// Sorting metric. Valid values:CreateTime, TemplateName, DBMajorVersion.
	OrderBy pulumi.StringPtrInput `pulumi:"orderBy"`
	// Sorting order. Valid values:asc (ascending order),desc (descending order).
	OrderByType pulumi.StringPtrInput `pulumi:"orderByType"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetParameterTemplatesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetParameterTemplatesArgs)(nil)).Elem()
}

// A collection of values returned by getParameterTemplates.
type GetParameterTemplatesResultOutput struct{ *pulumi.OutputState }

func (GetParameterTemplatesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetParameterTemplatesResult)(nil)).Elem()
}

func (o GetParameterTemplatesResultOutput) ToGetParameterTemplatesResultOutput() GetParameterTemplatesResultOutput {
	return o
}

func (o GetParameterTemplatesResultOutput) ToGetParameterTemplatesResultOutputWithContext(ctx context.Context) GetParameterTemplatesResultOutput {
	return o
}

func (o GetParameterTemplatesResultOutput) Filters() GetParameterTemplatesFilterArrayOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) []GetParameterTemplatesFilter { return v.Filters }).(GetParameterTemplatesFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetParameterTemplatesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) string { return v.Id }).(pulumi.StringOutput)
}

// list of parameter templates.
func (o GetParameterTemplatesResultOutput) Lists() GetParameterTemplatesListArrayOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) []GetParameterTemplatesList { return v.Lists }).(GetParameterTemplatesListArrayOutput)
}

func (o GetParameterTemplatesResultOutput) OrderBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) *string { return v.OrderBy }).(pulumi.StringPtrOutput)
}

func (o GetParameterTemplatesResultOutput) OrderByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) *string { return v.OrderByType }).(pulumi.StringPtrOutput)
}

func (o GetParameterTemplatesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetParameterTemplatesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetParameterTemplatesResultOutput{})
}
