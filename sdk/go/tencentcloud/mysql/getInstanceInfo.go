// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mysql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of mysql instanceInfo
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mysql"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Mysql.GetInstanceInfo(ctx, &mysql.GetInstanceInfoArgs{
// 			InstanceId: "cdb-fitq5t9h",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetInstanceInfo(ctx *pulumi.Context, args *GetInstanceInfoArgs, opts ...pulumi.InvokeOption) (*GetInstanceInfoResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetInstanceInfoResult
	err := ctx.Invoke("tencentcloud:Mysql/getInstanceInfo:getInstanceInfo", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getInstanceInfo.
type GetInstanceInfoArgs struct {
	// instance id.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

// A collection of values returned by getInstanceInfo.
type GetInstanceInfoResult struct {
	// The default region of the KMS service used by the current CDB backend service.
	DefaultKmsRegion string `pulumi:"defaultKmsRegion"`
	// Whether to enable encryption, YES is enabled, NO is not enabled.
	Encryption string `pulumi:"encryption"`
	// The provider-assigned unique ID for this managed resource.
	Id         string `pulumi:"id"`
	InstanceId string `pulumi:"instanceId"`
	// instance name.
	InstanceName string `pulumi:"instanceName"`
	// The key ID used for encryption.
	KeyId string `pulumi:"keyId"`
	// The region where the key is located.
	KeyRegion        string  `pulumi:"keyRegion"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
}

func GetInstanceInfoOutput(ctx *pulumi.Context, args GetInstanceInfoOutputArgs, opts ...pulumi.InvokeOption) GetInstanceInfoResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetInstanceInfoResult, error) {
			args := v.(GetInstanceInfoArgs)
			r, err := GetInstanceInfo(ctx, &args, opts...)
			var s GetInstanceInfoResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetInstanceInfoResultOutput)
}

// A collection of arguments for invoking getInstanceInfo.
type GetInstanceInfoOutputArgs struct {
	// instance id.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
}

func (GetInstanceInfoOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceInfoArgs)(nil)).Elem()
}

// A collection of values returned by getInstanceInfo.
type GetInstanceInfoResultOutput struct{ *pulumi.OutputState }

func (GetInstanceInfoResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetInstanceInfoResult)(nil)).Elem()
}

func (o GetInstanceInfoResultOutput) ToGetInstanceInfoResultOutput() GetInstanceInfoResultOutput {
	return o
}

func (o GetInstanceInfoResultOutput) ToGetInstanceInfoResultOutputWithContext(ctx context.Context) GetInstanceInfoResultOutput {
	return o
}

// The default region of the KMS service used by the current CDB backend service.
func (o GetInstanceInfoResultOutput) DefaultKmsRegion() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.DefaultKmsRegion }).(pulumi.StringOutput)
}

// Whether to enable encryption, YES is enabled, NO is not enabled.
func (o GetInstanceInfoResultOutput) Encryption() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.Encryption }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetInstanceInfoResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetInstanceInfoResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

// instance name.
func (o GetInstanceInfoResultOutput) InstanceName() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.InstanceName }).(pulumi.StringOutput)
}

// The key ID used for encryption.
func (o GetInstanceInfoResultOutput) KeyId() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.KeyId }).(pulumi.StringOutput)
}

// The region where the key is located.
func (o GetInstanceInfoResultOutput) KeyRegion() pulumi.StringOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) string { return v.KeyRegion }).(pulumi.StringOutput)
}

func (o GetInstanceInfoResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetInstanceInfoResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetInstanceInfoResultOutput{})
}