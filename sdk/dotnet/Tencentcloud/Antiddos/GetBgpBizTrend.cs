// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos
{
    public static class GetBgpBizTrend
    {
        /// <summary>
        /// Use this data source to query detailed information of antiddos bgp_biz_trend
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var bgpBizTrend = Tencentcloud.Antiddos.GetBgpBizTrend.Invoke(new()
        ///     {
        ///         Business = "bgp-multip",
        ///         EndTime = "2023-11-22 10:25:00",
        ///         Flag = 0,
        ///         InstanceId = "bgp-00000ry7",
        ///         MetricName = "intraffic",
        ///         StartTime = "2023-11-22 09:25:00",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetBgpBizTrendResult> InvokeAsync(GetBgpBizTrendArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBgpBizTrendResult>("tencentcloud:Antiddos/getBgpBizTrend:getBgpBizTrend", args ?? new GetBgpBizTrendArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of antiddos bgp_biz_trend
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var bgpBizTrend = Tencentcloud.Antiddos.GetBgpBizTrend.Invoke(new()
        ///     {
        ///         Business = "bgp-multip",
        ///         EndTime = "2023-11-22 10:25:00",
        ///         Flag = 0,
        ///         InstanceId = "bgp-00000ry7",
        ///         MetricName = "intraffic",
        ///         StartTime = "2023-11-22 09:25:00",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetBgpBizTrendResult> Invoke(GetBgpBizTrendInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBgpBizTrendResult>("tencentcloud:Antiddos/getBgpBizTrend:getBgpBizTrend", args ?? new GetBgpBizTrendInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBgpBizTrendArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
        /// </summary>
        [Input("business", required: true)]
        public string Business { get; set; } = null!;

        /// <summary>
        /// Statistic end time.
        /// </summary>
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

        /// <summary>
        /// 0 represents fixed time, 1 represents custom time.
        /// </summary>
        [Input("flag", required: true)]
        public int Flag { get; set; }

        /// <summary>
        /// Antiddos InstanceId.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Statistic metric name, for example: intraffic, outtraffic, inpkg, outpkg.
        /// </summary>
        [Input("metricName", required: true)]
        public string MetricName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Statistic start time.
        /// </summary>
        [Input("startTime", required: true)]
        public string StartTime { get; set; } = null!;

        public GetBgpBizTrendArgs()
        {
        }
        public static new GetBgpBizTrendArgs Empty => new GetBgpBizTrendArgs();
    }

    public sealed class GetBgpBizTrendInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
        /// </summary>
        [Input("business", required: true)]
        public Input<string> Business { get; set; } = null!;

        /// <summary>
        /// Statistic end time.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        /// <summary>
        /// 0 represents fixed time, 1 represents custom time.
        /// </summary>
        [Input("flag", required: true)]
        public Input<int> Flag { get; set; } = null!;

        /// <summary>
        /// Antiddos InstanceId.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Statistic metric name, for example: intraffic, outtraffic, inpkg, outpkg.
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Statistic start time.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public GetBgpBizTrendInvokeArgs()
        {
        }
        public static new GetBgpBizTrendInvokeArgs Empty => new GetBgpBizTrendInvokeArgs();
    }


    [OutputType]
    public sealed class GetBgpBizTrendResult
    {
        public readonly string Business;
        /// <summary>
        /// Values at various time points on the graph.
        /// </summary>
        public readonly ImmutableArray<int> DataLists;
        public readonly string EndTime;
        public readonly int Flag;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Returns the maximum value of an array.
        /// </summary>
        public readonly int MaxData;
        public readonly string MetricName;
        public readonly string? ResultOutputFile;
        public readonly string StartTime;
        /// <summary>
        /// Number of values in the curve graph.
        /// </summary>
        public readonly int Total;

        [OutputConstructor]
        private GetBgpBizTrendResult(
            string business,

            ImmutableArray<int> dataLists,

            string endTime,

            int flag,

            string id,

            string instanceId,

            int maxData,

            string metricName,

            string? resultOutputFile,

            string startTime,

            int total)
        {
            Business = business;
            DataLists = dataLists;
            EndTime = endTime;
            Flag = flag;
            Id = id;
            InstanceId = instanceId;
            MaxData = maxData;
            MetricName = metricName;
            ResultOutputFile = resultOutputFile;
            StartTime = startTime;
            Total = total;
        }
    }
}
