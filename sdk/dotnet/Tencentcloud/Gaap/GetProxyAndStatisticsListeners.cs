// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap
{
    public static class GetProxyAndStatisticsListeners
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap proxy and statistics listeners
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
        ///         var proxyAndStatisticsListeners = Output.Create(Tencentcloud.Gaap.GetProxyAndStatisticsListeners.InvokeAsync(new Tencentcloud.Gaap.GetProxyAndStatisticsListenersArgs
        ///         {
        ///             ProjectId = 0,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProxyAndStatisticsListenersResult> InvokeAsync(GetProxyAndStatisticsListenersArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProxyAndStatisticsListenersResult>("tencentcloud:Gaap/getProxyAndStatisticsListeners:getProxyAndStatisticsListeners", args ?? new GetProxyAndStatisticsListenersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap proxy and statistics listeners
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
        ///         var proxyAndStatisticsListeners = Output.Create(Tencentcloud.Gaap.GetProxyAndStatisticsListeners.InvokeAsync(new Tencentcloud.Gaap.GetProxyAndStatisticsListenersArgs
        ///         {
        ///             ProjectId = 0,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetProxyAndStatisticsListenersResult> Invoke(GetProxyAndStatisticsListenersInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetProxyAndStatisticsListenersResult>("tencentcloud:Gaap/getProxyAndStatisticsListeners:getProxyAndStatisticsListeners", args ?? new GetProxyAndStatisticsListenersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProxyAndStatisticsListenersArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Project Id.
        /// </summary>
        [Input("projectId", required: true)]
        public int ProjectId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetProxyAndStatisticsListenersArgs()
        {
        }
    }

    public sealed class GetProxyAndStatisticsListenersInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Project Id.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<int> ProjectId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetProxyAndStatisticsListenersInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProxyAndStatisticsListenersResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int ProjectId;
        /// <summary>
        /// proxy information that can be counted.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProxyAndStatisticsListenersProxySetResult> ProxySets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetProxyAndStatisticsListenersResult(
            string id,

            int projectId,

            ImmutableArray<Outputs.GetProxyAndStatisticsListenersProxySetResult> proxySets,

            string? resultOutputFile)
        {
            Id = id;
            ProjectId = projectId;
            ProxySets = proxySets;
            ResultOutputFile = resultOutputFile;
        }
    }
}
