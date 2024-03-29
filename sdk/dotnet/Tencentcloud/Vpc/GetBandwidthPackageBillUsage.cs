// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetBandwidthPackageBillUsage
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc bandwidth_package_bill_usage
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var bandwidthPackageBillUsage = Output.Create(Tencentcloud.Vpc.GetBandwidthPackageBillUsage.InvokeAsync(new Tencentcloud.Vpc.GetBandwidthPackageBillUsageArgs
        ///         {
        ///             BandwidthPackageId = "bwp-234rfgt5",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBandwidthPackageBillUsageResult> InvokeAsync(GetBandwidthPackageBillUsageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBandwidthPackageBillUsageResult>("tencentcloud:Vpc/getBandwidthPackageBillUsage:getBandwidthPackageBillUsage", args ?? new GetBandwidthPackageBillUsageArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc bandwidth_package_bill_usage
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var bandwidthPackageBillUsage = Output.Create(Tencentcloud.Vpc.GetBandwidthPackageBillUsage.InvokeAsync(new Tencentcloud.Vpc.GetBandwidthPackageBillUsageArgs
        ///         {
        ///             BandwidthPackageId = "bwp-234rfgt5",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetBandwidthPackageBillUsageResult> Invoke(GetBandwidthPackageBillUsageInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBandwidthPackageBillUsageResult>("tencentcloud:Vpc/getBandwidthPackageBillUsage:getBandwidthPackageBillUsage", args ?? new GetBandwidthPackageBillUsageInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBandwidthPackageBillUsageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique ID of the postpaid bandwidth package.
        /// </summary>
        [Input("bandwidthPackageId", required: true)]
        public string BandwidthPackageId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBandwidthPackageBillUsageArgs()
        {
        }
    }

    public sealed class GetBandwidthPackageBillUsageInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique ID of the postpaid bandwidth package.
        /// </summary>
        [Input("bandwidthPackageId", required: true)]
        public Input<string> BandwidthPackageId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBandwidthPackageBillUsageInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBandwidthPackageBillUsageResult
    {
        /// <summary>
        /// current billing amount.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSetResult> BandwidthPackageBillBandwidthSets;
        public readonly string BandwidthPackageId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetBandwidthPackageBillUsageResult(
            ImmutableArray<Outputs.GetBandwidthPackageBillUsageBandwidthPackageBillBandwidthSetResult> bandwidthPackageBillBandwidthSets,

            string bandwidthPackageId,

            string id,

            string? resultOutputFile)
        {
            BandwidthPackageBillBandwidthSets = bandwidthPackageBillBandwidthSets;
            BandwidthPackageId = bandwidthPackageId;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
