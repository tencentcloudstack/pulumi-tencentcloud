// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf
{
    public static class GetAttackTotalCount
    {
        /// <summary>
        /// Use this data source to query detailed information of waf attack_total_count
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// ### Obtain the specified domain name attack log
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Tencentcloud.Waf.GetAttackTotalCount.InvokeAsync(new Tencentcloud.Waf.GetAttackTotalCountArgs
        ///         {
        ///             Domain = "domain.com",
        ///             EndTime = "2023-09-07 00:00:00",
        ///             QueryString = "method:GET",
        ///             StartTime = "2023-09-01 00:00:00",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% example %}}
        /// ### Obtain all domain name attack log
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Tencentcloud.Waf.GetAttackTotalCount.InvokeAsync(new Tencentcloud.Waf.GetAttackTotalCountArgs
        ///         {
        ///             Domain = "all",
        ///             EndTime = "2023-09-07 00:00:00",
        ///             QueryString = "method:GET",
        ///             StartTime = "2023-09-01 00:00:00",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAttackTotalCountResult> InvokeAsync(GetAttackTotalCountArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAttackTotalCountResult>("tencentcloud:Waf/getAttackTotalCount:getAttackTotalCount", args ?? new GetAttackTotalCountArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of waf attack_total_count
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// ### Obtain the specified domain name attack log
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Tencentcloud.Waf.GetAttackTotalCount.InvokeAsync(new Tencentcloud.Waf.GetAttackTotalCountArgs
        ///         {
        ///             Domain = "domain.com",
        ///             EndTime = "2023-09-07 00:00:00",
        ///             QueryString = "method:GET",
        ///             StartTime = "2023-09-01 00:00:00",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% example %}}
        /// ### Obtain all domain name attack log
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Tencentcloud.Waf.GetAttackTotalCount.InvokeAsync(new Tencentcloud.Waf.GetAttackTotalCountArgs
        ///         {
        ///             Domain = "all",
        ///             EndTime = "2023-09-07 00:00:00",
        ///             QueryString = "method:GET",
        ///             StartTime = "2023-09-01 00:00:00",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAttackTotalCountResult> Invoke(GetAttackTotalCountInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAttackTotalCountResult>("tencentcloud:Waf/getAttackTotalCount:getAttackTotalCount", args ?? new GetAttackTotalCountInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAttackTotalCountArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query domain name, all domain use all.
        /// </summary>
        [Input("domain", required: true)]
        public string Domain { get; set; } = null!;

        /// <summary>
        /// End time.
        /// </summary>
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

        /// <summary>
        /// Query conditions.
        /// </summary>
        [Input("queryString")]
        public string? QueryString { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Begin time.
        /// </summary>
        [Input("startTime", required: true)]
        public string StartTime { get; set; } = null!;

        public GetAttackTotalCountArgs()
        {
        }
    }

    public sealed class GetAttackTotalCountInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query domain name, all domain use all.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// End time.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        /// <summary>
        /// Query conditions.
        /// </summary>
        [Input("queryString")]
        public Input<string>? QueryString { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Begin time.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public GetAttackTotalCountInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAttackTotalCountResult
    {
        public readonly string Domain;
        public readonly string EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? QueryString;
        public readonly string? ResultOutputFile;
        public readonly string StartTime;
        /// <summary>
        /// Total number of attacks.
        /// </summary>
        public readonly int TotalCount;

        [OutputConstructor]
        private GetAttackTotalCountResult(
            string domain,

            string endTime,

            string id,

            string? queryString,

            string? resultOutputFile,

            string startTime,

            int totalCount)
        {
            Domain = domain;
            EndTime = endTime;
            Id = id;
            QueryString = queryString;
            ResultOutputFile = resultOutputFile;
            StartTime = startTime;
            TotalCount = totalCount;
        }
    }
}