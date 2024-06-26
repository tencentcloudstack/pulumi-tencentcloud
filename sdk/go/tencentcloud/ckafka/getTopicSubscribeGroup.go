// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package ckafka

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of ckafka topicSubscribeGroup
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
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Ckafka"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Ckafka.GetTopicSubscribeGroup(ctx, &ckafka.GetTopicSubscribeGroupArgs{
//				InstanceId: "ckafka-xxxxxx",
//				TopicName:  "xxxxxx",
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
func GetTopicSubscribeGroup(ctx *pulumi.Context, args *GetTopicSubscribeGroupArgs, opts ...pulumi.InvokeOption) (*GetTopicSubscribeGroupResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetTopicSubscribeGroupResult
	err := ctx.Invoke("tencentcloud:Ckafka/getTopicSubscribeGroup:getTopicSubscribeGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTopicSubscribeGroup.
type GetTopicSubscribeGroupArgs struct {
	// InstanceId.
	InstanceId string `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// TopicName.
	TopicName string `pulumi:"topicName"`
}

// A collection of values returned by getTopicSubscribeGroup.
type GetTopicSubscribeGroupResult struct {
	// Consumer group information.
	GroupsInfos []GetTopicSubscribeGroupGroupsInfo `pulumi:"groupsInfos"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	InstanceId       string  `pulumi:"instanceId"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	TopicName        string  `pulumi:"topicName"`
}

func GetTopicSubscribeGroupOutput(ctx *pulumi.Context, args GetTopicSubscribeGroupOutputArgs, opts ...pulumi.InvokeOption) GetTopicSubscribeGroupResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTopicSubscribeGroupResult, error) {
			args := v.(GetTopicSubscribeGroupArgs)
			r, err := GetTopicSubscribeGroup(ctx, &args, opts...)
			var s GetTopicSubscribeGroupResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTopicSubscribeGroupResultOutput)
}

// A collection of arguments for invoking getTopicSubscribeGroup.
type GetTopicSubscribeGroupOutputArgs struct {
	// InstanceId.
	InstanceId pulumi.StringInput `pulumi:"instanceId"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// TopicName.
	TopicName pulumi.StringInput `pulumi:"topicName"`
}

func (GetTopicSubscribeGroupOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTopicSubscribeGroupArgs)(nil)).Elem()
}

// A collection of values returned by getTopicSubscribeGroup.
type GetTopicSubscribeGroupResultOutput struct{ *pulumi.OutputState }

func (GetTopicSubscribeGroupResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTopicSubscribeGroupResult)(nil)).Elem()
}

func (o GetTopicSubscribeGroupResultOutput) ToGetTopicSubscribeGroupResultOutput() GetTopicSubscribeGroupResultOutput {
	return o
}

func (o GetTopicSubscribeGroupResultOutput) ToGetTopicSubscribeGroupResultOutputWithContext(ctx context.Context) GetTopicSubscribeGroupResultOutput {
	return o
}

// Consumer group information.
func (o GetTopicSubscribeGroupResultOutput) GroupsInfos() GetTopicSubscribeGroupGroupsInfoArrayOutput {
	return o.ApplyT(func(v GetTopicSubscribeGroupResult) []GetTopicSubscribeGroupGroupsInfo { return v.GroupsInfos }).(GetTopicSubscribeGroupGroupsInfoArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetTopicSubscribeGroupResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTopicSubscribeGroupResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetTopicSubscribeGroupResultOutput) InstanceId() pulumi.StringOutput {
	return o.ApplyT(func(v GetTopicSubscribeGroupResult) string { return v.InstanceId }).(pulumi.StringOutput)
}

func (o GetTopicSubscribeGroupResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTopicSubscribeGroupResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetTopicSubscribeGroupResultOutput) TopicName() pulumi.StringOutput {
	return o.ApplyT(func(v GetTopicSubscribeGroupResult) string { return v.TopicName }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTopicSubscribeGroupResultOutput{})
}
