// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package tcmq

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of tcmq topic
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Tcmq"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Tcmq"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Tcmq.GetTopic(ctx, &tcmq.GetTopicArgs{
// 			TopicName: pulumi.StringRef("topic_name"),
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func LookupTopic(ctx *pulumi.Context, args *LookupTopicArgs, opts ...pulumi.InvokeOption) (*LookupTopicResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv LookupTopicResult
	err := ctx.Invoke("tencentcloud:Tcmq/getTopic:getTopic", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTopic.
type LookupTopicArgs struct {
	// Filter. Currently, you can filter by tag. The tag name must be prefixed with `tag:`, such as `tag: owner`, `tag: environment`, or `tag: business`.
	Filters []GetTopicFilter `pulumi:"filters"`
	// For filtering by tag, this parameter must be set to `true`.
	IsTagFilter *bool `pulumi:"isTagFilter"`
	// Number of topics to be returned per page in case of paginated return. If this parameter is not passed in, 20 will be used by default. Maximum value: 50.
	Limit *int `pulumi:"limit"`
	// Starting position of the list of topics to be returned on the current page in case of paginated return. If a value is entered, limit is required. If this parameter is left empty, 0 will be used by default.
	Offset *int `pulumi:"offset"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Fuzzy search by TopicName.
	TopicName *string `pulumi:"topicName"`
	// Filter by CMQ topic name.
	TopicNameLists []string `pulumi:"topicNameLists"`
}

// A collection of values returned by getTopic.
type LookupTopicResult struct {
	Filters []GetTopicFilter `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	IsTagFilter      *bool   `pulumi:"isTagFilter"`
	Limit            *int    `pulumi:"limit"`
	Offset           *int    `pulumi:"offset"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Topic list.
	TopicLists []GetTopicTopicList `pulumi:"topicLists"`
	// Topic name.
	TopicName      *string  `pulumi:"topicName"`
	TopicNameLists []string `pulumi:"topicNameLists"`
}

func LookupTopicOutput(ctx *pulumi.Context, args LookupTopicOutputArgs, opts ...pulumi.InvokeOption) LookupTopicResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupTopicResult, error) {
			args := v.(LookupTopicArgs)
			r, err := LookupTopic(ctx, &args, opts...)
			var s LookupTopicResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupTopicResultOutput)
}

// A collection of arguments for invoking getTopic.
type LookupTopicOutputArgs struct {
	// Filter. Currently, you can filter by tag. The tag name must be prefixed with `tag:`, such as `tag: owner`, `tag: environment`, or `tag: business`.
	Filters GetTopicFilterArrayInput `pulumi:"filters"`
	// For filtering by tag, this parameter must be set to `true`.
	IsTagFilter pulumi.BoolPtrInput `pulumi:"isTagFilter"`
	// Number of topics to be returned per page in case of paginated return. If this parameter is not passed in, 20 will be used by default. Maximum value: 50.
	Limit pulumi.IntPtrInput `pulumi:"limit"`
	// Starting position of the list of topics to be returned on the current page in case of paginated return. If a value is entered, limit is required. If this parameter is left empty, 0 will be used by default.
	Offset pulumi.IntPtrInput `pulumi:"offset"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Fuzzy search by TopicName.
	TopicName pulumi.StringPtrInput `pulumi:"topicName"`
	// Filter by CMQ topic name.
	TopicNameLists pulumi.StringArrayInput `pulumi:"topicNameLists"`
}

func (LookupTopicOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTopicArgs)(nil)).Elem()
}

// A collection of values returned by getTopic.
type LookupTopicResultOutput struct{ *pulumi.OutputState }

func (LookupTopicResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupTopicResult)(nil)).Elem()
}

func (o LookupTopicResultOutput) ToLookupTopicResultOutput() LookupTopicResultOutput {
	return o
}

func (o LookupTopicResultOutput) ToLookupTopicResultOutputWithContext(ctx context.Context) LookupTopicResultOutput {
	return o
}

func (o LookupTopicResultOutput) Filters() GetTopicFilterArrayOutput {
	return o.ApplyT(func(v LookupTopicResult) []GetTopicFilter { return v.Filters }).(GetTopicFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o LookupTopicResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupTopicResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o LookupTopicResultOutput) IsTagFilter() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupTopicResult) *bool { return v.IsTagFilter }).(pulumi.BoolPtrOutput)
}

func (o LookupTopicResultOutput) Limit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupTopicResult) *int { return v.Limit }).(pulumi.IntPtrOutput)
}

func (o LookupTopicResultOutput) Offset() pulumi.IntPtrOutput {
	return o.ApplyT(func(v LookupTopicResult) *int { return v.Offset }).(pulumi.IntPtrOutput)
}

func (o LookupTopicResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupTopicResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Topic list.
func (o LookupTopicResultOutput) TopicLists() GetTopicTopicListArrayOutput {
	return o.ApplyT(func(v LookupTopicResult) []GetTopicTopicList { return v.TopicLists }).(GetTopicTopicListArrayOutput)
}

// Topic name.
func (o LookupTopicResultOutput) TopicName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupTopicResult) *string { return v.TopicName }).(pulumi.StringPtrOutput)
}

func (o LookupTopicResultOutput) TopicNameLists() pulumi.StringArrayOutput {
	return o.ApplyT(func(v LookupTopicResult) []string { return v.TopicNameLists }).(pulumi.StringArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupTopicResultOutput{})
}