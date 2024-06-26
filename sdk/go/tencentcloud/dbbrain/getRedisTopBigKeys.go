// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dbbrain

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of dbbrain redisTopBigKeys
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Dbbrain"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Dbbrain.GetRedisTopBigKeys(ctx, &dbbrain.GetRedisTopBigKeysArgs{
//				InstanceId: local.Redis_id,
//				Date:       "%s",
//				Product:    "redis",
//				SortBy:     pulumi.StringRef("Capacity"),
//				KeyType:    pulumi.StringRef("string"),
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
func GetRedisTopBigKeys(ctx *pulumi.Context, args *GetRedisTopBigKeysArgs, opts ...pulumi.InvokeOption) (*GetRedisTopBigKeysResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetRedisTopBigKeysResult
	err := ctx.Invoke("tencentcloud:Dbbrain/getRedisTopBigKeys:getRedisTopBigKeys", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getRedisTopBigKeys.
type GetRedisTopBigKeysArgs struct {
	// Query date, such as 2021-05-27, the earliest date can be the previous 30 days.
	Date string `pulumi:"date"`
	// instance id.
	InstanceId string `pulumi:"instanceId"`
	// Key type filter condition, the default is no filter, the value includes `string`, `list`, `set`, `hash`, `sortedset`, `stream`.
	KeyType *string `pulumi:"keyType"`
	// Service product type, supported values include `redis` - cloud database Redis.
	Product string `pulumi:"product"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Sorting field, the value includes `Capacity` - memory, `ItemCount` - number of elements, the default is `Capacity`.
	SortBy *string `pulumi:"sortBy"`
}

// A collection of values returned by getRedisTopBigKeys.
type GetRedisTopBigKeysResult struct {
	Date string `pulumi:"date"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	KeyType          *string `pulumi:"keyType"`
	Product          string  `pulumi:"product"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	SortBy           *string `pulumi:"sortBy"`
	// list of top keys.
	TopKeys []GetRedisTopBigKeysTopKey `pulumi:"topKeys"`
}

func GetRedisTopBigKeysOutput(ctx *pulumi.Context, args GetRedisTopBigKeysOutputArgs, opts ...pulumi.InvokeOption) GetRedisTopBigKeysResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetRedisTopBigKeysResult, error) {
			args := v.(GetRedisTopBigKeysArgs)
			r, err := GetRedisTopBigKeys(ctx, &args, opts...)
			var s GetRedisTopBigKeysResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetRedisTopBigKeysResultOutput)
}

// A collection of arguments for invoking getRedisTopBigKeys.
type GetRedisTopBigKeysOutputArgs struct {
	// Query date, such as 2021-05-27, the earliest date can be the previous 30 days.
	Date pulumi.StringInput `pulumi:"date"`
	// instance id.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Key type filter condition, the default is no filter, the value includes `string`, `list`, `set`, `hash`, `sortedset`, `stream`.
	KeyType pulumi.StringPtrInput `pulumi:"keyType"`
	// Service product type, supported values include `redis` - cloud database Redis.
	Product pulumi.StringInput `pulumi:"product"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Sorting field, the value includes `Capacity` - memory, `ItemCount` - number of elements, the default is `Capacity`.
	SortBy pulumi.StringPtrInput `pulumi:"sortBy"`
}

func (GetRedisTopBigKeysOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRedisTopBigKeysArgs)(nil)).Elem()
}

// A collection of values returned by getRedisTopBigKeys.
type GetRedisTopBigKeysResultOutput struct{ *pulumi.OutputState }

func (GetRedisTopBigKeysResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetRedisTopBigKeysResult)(nil)).Elem()
}

func (o GetRedisTopBigKeysResultOutput) ToGetRedisTopBigKeysResultOutput() GetRedisTopBigKeysResultOutput {
	return o
}

func (o GetRedisTopBigKeysResultOutput) ToGetRedisTopBigKeysResultOutputWithContext(ctx context.Context) GetRedisTopBigKeysResultOutput {
	return o
}

func (o GetRedisTopBigKeysResultOutput) Date() pulumi.StringOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) string { return v.Date }).(pulumi.StringOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetRedisTopBigKeysResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetRedisTopBigKeysResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetRedisTopBigKeysResultOutput) KeyType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) *string { return v.KeyType }).(pulumi.StringPtrOutput)
}

func (o GetRedisTopBigKeysResultOutput) Product() pulumi.StringOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) string { return v.Product }).(pulumi.StringOutput)
}

func (o GetRedisTopBigKeysResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetRedisTopBigKeysResultOutput) SortBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) *string { return v.SortBy }).(pulumi.StringPtrOutput)
}

// list of top keys.
func (o GetRedisTopBigKeysResultOutput) TopKeys() GetRedisTopBigKeysTopKeyArrayOutput {
	return o.ApplyT(func(v GetRedisTopBigKeysResult) []GetRedisTopBigKeysTopKey { return v.TopKeys }).(GetRedisTopBigKeysTopKeyArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetRedisTopBigKeysResultOutput{})
}
