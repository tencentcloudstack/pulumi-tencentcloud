// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package chdfs

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of chdfs fileSystems
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Chdfs"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Chdfs"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Chdfs.GetFileSystems(ctx, nil, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetFileSystems(ctx *pulumi.Context, args *GetFileSystemsArgs, opts ...pulumi.InvokeOption) (*GetFileSystemsResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetFileSystemsResult
	err := ctx.Invoke("tencentcloud:Chdfs/getFileSystems:getFileSystems", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFileSystems.
type GetFileSystemsArgs struct {
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getFileSystems.
type GetFileSystemsResult struct {
	// file system list.
	FileSystems []GetFileSystemsFileSystem `pulumi:"fileSystems"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetFileSystemsOutput(ctx *pulumi.Context, args GetFileSystemsOutputArgs, opts ...pulumi.InvokeOption) GetFileSystemsResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetFileSystemsResult, error) {
			args := v.(GetFileSystemsArgs)
			r, err := GetFileSystems(ctx, &args, opts...)
			var s GetFileSystemsResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetFileSystemsResultOutput)
}

// A collection of arguments for invoking getFileSystems.
type GetFileSystemsOutputArgs struct {
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetFileSystemsOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFileSystemsArgs)(nil)).Elem()
}

// A collection of values returned by getFileSystems.
type GetFileSystemsResultOutput struct{ *pulumi.OutputState }

func (GetFileSystemsResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetFileSystemsResult)(nil)).Elem()
}

func (o GetFileSystemsResultOutput) ToGetFileSystemsResultOutput() GetFileSystemsResultOutput {
	return o
}

func (o GetFileSystemsResultOutput) ToGetFileSystemsResultOutputWithContext(ctx context.Context) GetFileSystemsResultOutput {
	return o
}

// file system list.
func (o GetFileSystemsResultOutput) FileSystems() GetFileSystemsFileSystemArrayOutput {
	return o.ApplyT(func(v GetFileSystemsResult) []GetFileSystemsFileSystem { return v.FileSystems }).(GetFileSystemsFileSystemArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetFileSystemsResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetFileSystemsResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetFileSystemsResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetFileSystemsResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetFileSystemsResultOutput{})
}