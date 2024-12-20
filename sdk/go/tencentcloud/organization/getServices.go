// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package organization

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of organization services
//
// ## Example Usage
//
// ### Query all organization services
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Organization"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Organization.GetServices(ctx, nil, nil)
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
// ### Query organization services by filter
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Organization"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Organization.GetServices(ctx, &organization.GetServicesArgs{
//				SearchKey: pulumi.StringRef("KeyWord"),
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
func GetServices(ctx *pulumi.Context, args *GetServicesArgs, opts ...pulumi.InvokeOption) (*GetServicesResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetServicesResult
	err := ctx.Invoke("tencentcloud:Organization/getServices:getServices", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getServices.
type GetServicesArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Keyword for search by name.
	SearchKey *string `pulumi:"searchKey"`
}

// A collection of values returned by getServices.
type GetServicesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// Organization service list.
	Items            []GetServicesItem `pulumi:"items"`
	ResultOutputFile *string           `pulumi:"resultOutputFile"`
	SearchKey        *string           `pulumi:"searchKey"`
}

func GetServicesOutput(ctx *pulumi.Context, args GetServicesOutputArgs, opts ...pulumi.InvokeOption) GetServicesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetServicesResult, error) {
			args := v.(GetServicesArgs)
			r, err := GetServices(ctx, &args, opts...)
			var s GetServicesResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetServicesResultOutput)
}

// A collection of arguments for invoking getServices.
type GetServicesOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Keyword for search by name.
	SearchKey pulumi.StringPtrInput `pulumi:"searchKey"`
}

func (GetServicesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetServicesArgs)(nil)).Elem()
}

// A collection of values returned by getServices.
type GetServicesResultOutput struct{ *pulumi.OutputState }

func (GetServicesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetServicesResult)(nil)).Elem()
}

func (o GetServicesResultOutput) ToGetServicesResultOutput() GetServicesResultOutput {
	return o
}

func (o GetServicesResultOutput) ToGetServicesResultOutputWithContext(ctx context.Context) GetServicesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetServicesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetServicesResult) string { return v.Id }).(pulumi.StringOutput)
}

// Organization service list.
func (o GetServicesResultOutput) Items() GetServicesItemArrayOutput {
	return o.ApplyT(func(v GetServicesResult) []GetServicesItem { return v.Items }).(GetServicesItemArrayOutput)
}

func (o GetServicesResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetServicesResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetServicesResultOutput) SearchKey() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetServicesResult) *string { return v.SearchKey }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetServicesResultOutput{})
}
