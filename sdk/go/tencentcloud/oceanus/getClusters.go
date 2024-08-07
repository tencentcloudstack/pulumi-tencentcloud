// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package oceanus

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/internal"
)

// Use this data source to query detailed information of oceanus clusters
//
// ## Example Usage
//
// ### Query all clusters
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Oceanus"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Oceanus.GetClusters(ctx, nil, nil)
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
// ### Query the specified cluster
//
// <!--Start PulumiCodeChooser -->
// ```go
// package main
//
// import (
//
//	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
//	"github.com/tencentcloudstack/pulumi-tencentcloud/sdk/go/tencentcloud/Oceanus"
//
// )
//
//	func main() {
//		pulumi.Run(func(ctx *pulumi.Context) error {
//			_, err := Oceanus.GetClusters(ctx, &oceanus.GetClustersArgs{
//				ClusterIds: []string{
//					"cluster-5c42n3a5",
//				},
//				Filters: []oceanus.GetClustersFilter{
//					{
//						Name: "name",
//						Values: []string{
//							"tf_example",
//						},
//					},
//				},
//				OrderType:   pulumi.IntRef(1),
//				WorkSpaceId: pulumi.StringRef("space-2idq8wbr"),
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
func GetClusters(ctx *pulumi.Context, args *GetClustersArgs, opts ...pulumi.InvokeOption) (*GetClustersResult, error) {
	opts = internal.PkgInvokeDefaultOpts(opts)
	var rv GetClustersResult
	err := ctx.Invoke("tencentcloud:Oceanus/getClusters:getClusters", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getClusters.
type GetClustersArgs struct {
	// Query one or more clusters by their ID. The maximum number of clusters that can be queried at once is 100.
	ClusterIds []string `pulumi:"clusterIds"`
	// The filtering rules.
	Filters []GetClustersFilter `pulumi:"filters"`
	// The sorting rule of the cluster information results. Possible values are 1 (sort by time in descending order), 2 (sort by time in ascending order), and 3 (sort by status).
	OrderType *int `pulumi:"orderType"`
	// Used to save results.
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Workspace SerialId.
	WorkSpaceId *string `pulumi:"workSpaceId"`
}

// A collection of values returned by getClusters.
type GetClustersResult struct {
	ClusterIds []string `pulumi:"clusterIds"`
	// Cluster list.
	ClusterSets []GetClustersClusterSet `pulumi:"clusterSets"`
	Filters     []GetClustersFilter     `pulumi:"filters"`
	// The provider-assigned unique ID for this managed resource.
	Id               string  `pulumi:"id"`
	OrderType        *int    `pulumi:"orderType"`
	ResultOutputFile *string `pulumi:"resultOutputFile"`
	// Workspace SerialId.
	WorkSpaceId *string `pulumi:"workSpaceId"`
}

func GetClustersOutput(ctx *pulumi.Context, args GetClustersOutputArgs, opts ...pulumi.InvokeOption) GetClustersResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetClustersResult, error) {
			args := v.(GetClustersArgs)
			r, err := GetClusters(ctx, &args, opts...)
			var s GetClustersResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetClustersResultOutput)
}

// A collection of arguments for invoking getClusters.
type GetClustersOutputArgs struct {
	// Query one or more clusters by their ID. The maximum number of clusters that can be queried at once is 100.
	ClusterIds pulumi.StringArrayInput `pulumi:"clusterIds"`
	// The filtering rules.
	Filters GetClustersFilterArrayInput `pulumi:"filters"`
	// The sorting rule of the cluster information results. Possible values are 1 (sort by time in descending order), 2 (sort by time in ascending order), and 3 (sort by status).
	OrderType pulumi.IntPtrInput `pulumi:"orderType"`
	// Used to save results.
	ResultOutputFile pulumi.StringPtrInput `pulumi:"resultOutputFile"`
	// Workspace SerialId.
	WorkSpaceId pulumi.StringPtrInput `pulumi:"workSpaceId"`
}

func (GetClustersOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClustersArgs)(nil)).Elem()
}

// A collection of values returned by getClusters.
type GetClustersResultOutput struct{ *pulumi.OutputState }

func (GetClustersResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetClustersResult)(nil)).Elem()
}

func (o GetClustersResultOutput) ToGetClustersResultOutput() GetClustersResultOutput {
	return o
}

func (o GetClustersResultOutput) ToGetClustersResultOutputWithContext(ctx context.Context) GetClustersResultOutput {
	return o
}

func (o GetClustersResultOutput) ClusterIds() pulumi.StringArrayOutput {
	return o.ApplyT(func(v GetClustersResult) []string { return v.ClusterIds }).(pulumi.StringArrayOutput)
}

// Cluster list.
func (o GetClustersResultOutput) ClusterSets() GetClustersClusterSetArrayOutput {
	return o.ApplyT(func(v GetClustersResult) []GetClustersClusterSet { return v.ClusterSets }).(GetClustersClusterSetArrayOutput)
}

func (o GetClustersResultOutput) Filters() GetClustersFilterArrayOutput {
	return o.ApplyT(func(v GetClustersResult) []GetClustersFilter { return v.Filters }).(GetClustersFilterArrayOutput)
}

// The provider-assigned unique ID for this managed resource.
func (o GetClustersResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetClustersResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetClustersResultOutput) OrderType() pulumi.IntPtrOutput {
	return o.ApplyT(func(v GetClustersResult) *int { return v.OrderType }).(pulumi.IntPtrOutput)
}

func (o GetClustersResultOutput) ResultOutputFile() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetClustersResult) *string { return v.ResultOutputFile }).(pulumi.StringPtrOutput)
}

// Workspace SerialId.
func (o GetClustersResultOutput) WorkSpaceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v GetClustersResult) *string { return v.WorkSpaceId }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(GetClustersResultOutput{})
}
