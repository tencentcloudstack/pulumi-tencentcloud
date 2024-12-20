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
    public static class GetOverviewIndex
    {
        /// <summary>
        /// Use this data source to query detailed information of antiddos overview index
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
        ///     var overviewIndex = Tencentcloud.Antiddos.GetOverviewIndex.Invoke(new()
        ///     {
        ///         EndTime = "2023-11-21 12:32:12",
        ///         StartTime = "2023-11-20 12:32:12",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetOverviewIndexResult> InvokeAsync(GetOverviewIndexArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOverviewIndexResult>("tencentcloud:Antiddos/getOverviewIndex:getOverviewIndex", args ?? new GetOverviewIndexArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of antiddos overview index
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
        ///     var overviewIndex = Tencentcloud.Antiddos.GetOverviewIndex.Invoke(new()
        ///     {
        ///         EndTime = "2023-11-21 12:32:12",
        ///         StartTime = "2023-11-20 12:32:12",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetOverviewIndexResult> Invoke(GetOverviewIndexInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOverviewIndexResult>("tencentcloud:Antiddos/getOverviewIndex:getOverviewIndex", args ?? new GetOverviewIndexInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOverviewIndexArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// EndTime.
        /// </summary>
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

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

        public GetOverviewIndexArgs()
        {
        }
        public static new GetOverviewIndexArgs Empty => new GetOverviewIndexArgs();
    }

    public sealed class GetOverviewIndexInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// EndTime.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

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

        public GetOverviewIndexInvokeArgs()
        {
        }
        public static new GetOverviewIndexInvokeArgs Empty => new GetOverviewIndexInvokeArgs();
    }


    [OutputType]
    public sealed class GetOverviewIndexResult
    {
        /// <summary>
        /// ip count.
        /// </summary>
        public readonly int AllIpCount;
        /// <summary>
        /// AntiddosDomainCount.
        /// </summary>
        public readonly int AntiddosDomainCount;
        /// <summary>
        /// Total number of advanced defense IPs (including advanced defense packets and advanced defense IPs).
        /// </summary>
        public readonly int AntiddosIpCount;
        /// <summary>
        /// AttackDomainCount.
        /// </summary>
        public readonly int AttackDomainCount;
        /// <summary>
        /// AttackIpCount.
        /// </summary>
        public readonly int AttackIpCount;
        /// <summary>
        /// BlockIpCount.
        /// </summary>
        public readonly int BlockIpCount;
        public readonly string EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// MaxAttackFlow.
        /// </summary>
        public readonly int MaxAttackFlow;
        /// <summary>
        /// The IP address in the most recent attack.
        /// </summary>
        public readonly string NewAttackIp;
        /// <summary>
        /// The time in the most recent attack.
        /// </summary>
        public readonly string NewAttackTime;
        /// <summary>
        /// The type in the most recent attack.
        /// </summary>
        public readonly string NewAttackType;
        public readonly string? ResultOutputFile;
        public readonly string StartTime;

        [OutputConstructor]
        private GetOverviewIndexResult(
            int allIpCount,

            int antiddosDomainCount,

            int antiddosIpCount,

            int attackDomainCount,

            int attackIpCount,

            int blockIpCount,

            string endTime,

            string id,

            int maxAttackFlow,

            string newAttackIp,

            string newAttackTime,

            string newAttackType,

            string? resultOutputFile,

            string startTime)
        {
            AllIpCount = allIpCount;
            AntiddosDomainCount = antiddosDomainCount;
            AntiddosIpCount = antiddosIpCount;
            AttackDomainCount = attackDomainCount;
            AttackIpCount = attackIpCount;
            BlockIpCount = blockIpCount;
            EndTime = endTime;
            Id = id;
            MaxAttackFlow = maxAttackFlow;
            NewAttackIp = newAttackIp;
            NewAttackTime = newAttackTime;
            NewAttackType = newAttackType;
            ResultOutputFile = resultOutputFile;
            StartTime = startTime;
        }
    }
}
