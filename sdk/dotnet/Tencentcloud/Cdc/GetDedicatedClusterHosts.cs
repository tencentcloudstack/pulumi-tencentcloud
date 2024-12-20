// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdc
{
    public static class GetDedicatedClusterHosts
    {
        /// <summary>
        /// Use this data source to query detailed information of CDC dedicated cluster hosts
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
        ///     var hosts = Tencentcloud.Cdc.GetDedicatedClusterHosts.Invoke(new()
        ///     {
        ///         DedicatedClusterId = "cluster-262n63e8",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDedicatedClusterHostsResult> InvokeAsync(GetDedicatedClusterHostsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDedicatedClusterHostsResult>("tencentcloud:Cdc/getDedicatedClusterHosts:getDedicatedClusterHosts", args ?? new GetDedicatedClusterHostsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of CDC dedicated cluster hosts
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
        ///     var hosts = Tencentcloud.Cdc.GetDedicatedClusterHosts.Invoke(new()
        ///     {
        ///         DedicatedClusterId = "cluster-262n63e8",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDedicatedClusterHostsResult> Invoke(GetDedicatedClusterHostsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDedicatedClusterHostsResult>("tencentcloud:Cdc/getDedicatedClusterHosts:getDedicatedClusterHosts", args ?? new GetDedicatedClusterHostsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDedicatedClusterHostsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dedicated Cluster ID.
        /// </summary>
        [Input("dedicatedClusterId", required: true)]
        public string DedicatedClusterId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDedicatedClusterHostsArgs()
        {
        }
        public static new GetDedicatedClusterHostsArgs Empty => new GetDedicatedClusterHostsArgs();
    }

    public sealed class GetDedicatedClusterHostsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Dedicated Cluster ID.
        /// </summary>
        [Input("dedicatedClusterId", required: true)]
        public Input<string> DedicatedClusterId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDedicatedClusterHostsInvokeArgs()
        {
        }
        public static new GetDedicatedClusterHostsInvokeArgs Empty => new GetDedicatedClusterHostsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDedicatedClusterHostsResult
    {
        public readonly string DedicatedClusterId;
        /// <summary>
        /// Dedicated Cluster Host Info.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDedicatedClusterHostsHostInfoSetResult> HostInfoSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDedicatedClusterHostsResult(
            string dedicatedClusterId,

            ImmutableArray<Outputs.GetDedicatedClusterHostsHostInfoSetResult> hostInfoSets,

            string id,

            string? resultOutputFile)
        {
            DedicatedClusterId = dedicatedClusterId;
            HostInfoSets = hostInfoSets;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
