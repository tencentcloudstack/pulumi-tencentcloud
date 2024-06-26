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
    public static class GetOverviewDdosTrend
    {
        /// <summary>
        /// Use this data source to query detailed information of antiddos overview ddos trend
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
        ///     var overviewDdosTrend = Tencentcloud.Antiddos.GetOverviewDdosTrend.Invoke(new()
        ///     {
        ///         Business = "bgpip",
        ///         EndTime = "2023-11-21 14:16:23",
        ///         MetricName = "bps",
        ///         Period = 300,
        ///         StartTime = "2023-11-20 14:16:23",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetOverviewDdosTrendResult> InvokeAsync(GetOverviewDdosTrendArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOverviewDdosTrendResult>("tencentcloud:Antiddos/getOverviewDdosTrend:getOverviewDdosTrend", args ?? new GetOverviewDdosTrendArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of antiddos overview ddos trend
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
        ///     var overviewDdosTrend = Tencentcloud.Antiddos.GetOverviewDdosTrend.Invoke(new()
        ///     {
        ///         Business = "bgpip",
        ///         EndTime = "2023-11-21 14:16:23",
        ///         MetricName = "bps",
        ///         Period = 300,
        ///         StartTime = "2023-11-20 14:16:23",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetOverviewDdosTrendResult> Invoke(GetOverviewDdosTrendInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOverviewDdosTrendResult>("tencentcloud:Antiddos/getOverviewDdosTrend:getOverviewDdosTrend", args ?? new GetOverviewDdosTrendInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOverviewDdosTrendArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
        /// </summary>
        [Input("business")]
        public string? Business { get; set; }

        /// <summary>
        /// EndTime.
        /// </summary>
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

        [Input("ipLists")]
        private List<string>? _ipLists;

        /// <summary>
        /// instance IpList.
        /// </summary>
        public List<string> IpLists
        {
            get => _ipLists ?? (_ipLists = new List<string>());
            set => _ipLists = value;
        }

        /// <summary>
        /// Indicator, value [bps (attack traffic bandwidth, pps (attack packet rate)].
        /// </summary>
        [Input("metricName", required: true)]
        public string MetricName { get; set; } = null!;

        /// <summary>
        /// Statistical granularity, values [300 (5 minutes), 3600 (hours), 86400 (days)].
        /// </summary>
        [Input("period", required: true)]
        public int Period { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// StartTime.
        /// </summary>
        [Input("startTime", required: true)]
        public string StartTime { get; set; } = null!;

        public GetOverviewDdosTrendArgs()
        {
        }
        public static new GetOverviewDdosTrendArgs Empty => new GetOverviewDdosTrendArgs();
    }

    public sealed class GetOverviewDdosTrendInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
        /// </summary>
        [Input("business")]
        public Input<string>? Business { get; set; }

        /// <summary>
        /// EndTime.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        [Input("ipLists")]
        private InputList<string>? _ipLists;

        /// <summary>
        /// instance IpList.
        /// </summary>
        public InputList<string> IpLists
        {
            get => _ipLists ?? (_ipLists = new InputList<string>());
            set => _ipLists = value;
        }

        /// <summary>
        /// Indicator, value [bps (attack traffic bandwidth, pps (attack packet rate)].
        /// </summary>
        [Input("metricName", required: true)]
        public Input<string> MetricName { get; set; } = null!;

        /// <summary>
        /// Statistical granularity, values [300 (5 minutes), 3600 (hours), 86400 (days)].
        /// </summary>
        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// StartTime.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public GetOverviewDdosTrendInvokeArgs()
        {
        }
        public static new GetOverviewDdosTrendInvokeArgs Empty => new GetOverviewDdosTrendInvokeArgs();
    }


    [OutputType]
    public sealed class GetOverviewDdosTrendResult
    {
        public readonly string? Business;
        /// <summary>
        /// Array, attack traffic bandwidth in Mbps, packet rate in pps.
        /// </summary>
        public readonly ImmutableArray<int> Datas;
        public readonly string EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> IpLists;
        public readonly string MetricName;
        public readonly int Period;
        public readonly string? ResultOutputFile;
        public readonly string StartTime;

        [OutputConstructor]
        private GetOverviewDdosTrendResult(
            string? business,

            ImmutableArray<int> datas,

            string endTime,

            string id,

            ImmutableArray<string> ipLists,

            string metricName,

            int period,

            string? resultOutputFile,

            string startTime)
        {
            Business = business;
            Datas = datas;
            EndTime = endTime;
            Id = id;
            IpLists = ipLists;
            MetricName = metricName;
            Period = period;
            ResultOutputFile = resultOutputFile;
            StartTime = startTime;
        }
    }
}
