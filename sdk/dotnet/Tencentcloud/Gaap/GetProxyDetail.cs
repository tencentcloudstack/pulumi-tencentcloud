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
    public static class GetProxyDetail
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap proxy detail
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
        ///         var proxyDetail = Output.Create(Tencentcloud.Gaap.GetProxyDetail.InvokeAsync(new Tencentcloud.Gaap.GetProxyDetailArgs
        ///         {
        ///             ProxyId = "link-8lpyo88p",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetProxyDetailResult> InvokeAsync(GetProxyDetailArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProxyDetailResult>("tencentcloud:Gaap/getProxyDetail:getProxyDetail", args ?? new GetProxyDetailArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap proxy detail
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
        ///         var proxyDetail = Output.Create(Tencentcloud.Gaap.GetProxyDetail.InvokeAsync(new Tencentcloud.Gaap.GetProxyDetailArgs
        ///         {
        ///             ProxyId = "link-8lpyo88p",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetProxyDetailResult> Invoke(GetProxyDetailInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetProxyDetailResult>("tencentcloud:Gaap/getProxyDetail:getProxyDetail", args ?? new GetProxyDetailInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProxyDetailArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Proxy Id.
        /// </summary>
        [Input("proxyId", required: true)]
        public string ProxyId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetProxyDetailArgs()
        {
        }
    }

    public sealed class GetProxyDetailInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Proxy Id.
        /// </summary>
        [Input("proxyId", required: true)]
        public Input<string> ProxyId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetProxyDetailInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProxyDetailResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Proxy Detail.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProxyDetailProxyDetailResult> GaapProxyDetail;
        /// <summary>
        /// (New parameter) proxy instance ID.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string ProxyId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetProxyDetailResult(
            string id,

            ImmutableArray<Outputs.GetProxyDetailProxyDetailResult> proxyDetails,

            string proxyId,

            string? resultOutputFile)
        {
            Id = id;
            GaapProxyDetail = proxyDetails;
            ProxyId = proxyId;
            ResultOutputFile = resultOutputFile;
        }
    }
}