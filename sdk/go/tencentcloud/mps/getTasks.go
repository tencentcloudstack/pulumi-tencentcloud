// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mps

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Use this data source to query detailed information of mps tasks
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Mps"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := Mps.GetTasks(ctx, &mps.GetTasksArgs{
// 			Limit:  pulumi.IntRef(20),
// 			Status: "FINISH",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetTasks(ctx *pulumi.Context, args *GetTasksArgs, opts ...pulumi.InvokeOption) (*GetTasksResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetTasksResult
	err := ctx.Invoke("tencentcloud:Mps/getTasks:getTasks", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getTasks.
type GetTasksArgs struct {
	// Return the number of records, default value: 10, maximum value: 100.
	Limit *int `pulumi:"limit"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Page turning flag, used when pulling in batches: when a single request cannot pull all the data, the interface will return a ScrollToken, and the next request will carry this Token, and it will be obtained from the next record.
	ScrollToken *string `pulumi:"scrollToken"`
	// Filter condition: task status, optional values: WAITING, PROCESSING, FINISH.
	Status string `pulumi:"status"`
}

// A collection of values returned by getTasks.
type GetTasksResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	Limit            *int    `pulumi:"limit"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	ScrollToken      string  `pulumi:"scrollToken"`
	Status           string  `pulumi:"status"`
	// Task list.
	TaskSets []GetTasksTaskSet `pulumi:"taskSets"`
}

func GetTasksOutput(ctx *pulumi.Context, args GetTasksOutputArgs, opts ...pulumi.InvokeOption) GetTasksResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetTasksResult, error) {
			args := v.(GetTasksArgs)
			r, err := GetTasks(ctx, &args, opts...)
			var s GetTasksResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetTasksResultOutput)
}

// A collection of arguments for invoking getTasks.
type GetTasksOutputArgs struct {
	// Return the number of records, default value: 10, maximum value: 100.
	Limit pulumi.IntPtrInput `pulumi:"limit"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Page turning flag, used when pulling in batches: when a single request cannot pull all the data, the interface will return a ScrollToken, and the next request will carry this Token, and it will be obtained from the next record.
	ScrollToken pulumi.StringPtrInput `pulumi:"scrollToken"`
	// Filter condition: task status, optional values: WAITING, PROCESSING, FINISH.
	Status pulumi.StringInput `pulumi:"status"`
}

func (GetTasksOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTasksArgs)(nil)).Elem()
}

// A collection of values returned by getTasks.
type GetTasksResultOutput struct{ *pulumi.OutputState }

func (GetTasksResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetTasksResult)(nil)).Elem()
}

func (o GetTasksResultOutput) ToGetTasksResultOutput() GetTasksResultOutput {
	return o
}

func (o GetTasksResultOutput) ToGetTasksResultOutputWithContext(ctx context.Context) GetTasksResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetTasksResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetTasksResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetTasksResultOutput) Limit() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetTasksResult) *int { return v.Limit }).(pulumi.IntPtrOutput)
}

func (o GetTasksResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetTasksResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

func (o GetTasksResultOutput) ScrollToken() pulumi.StringOutput {
	return o.ApplyT(func(v GetTasksResult) string { return v.ScrollToken }).(pulumi.StringOutput)
}

func (o GetTasksResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v GetTasksResult) string { return v.Status }).(pulumi.StringOutput)
}

// Task list.
func (o GetTasksResultOutput) TaskSets() GetTasksTaskSetArrayOutput {
	return o.ApplyT(func(v GetTasksResult) []GetTasksTaskSet { return v.TaskSets }).(GetTasksTaskSetArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(GetTasksResultOutput{})
}