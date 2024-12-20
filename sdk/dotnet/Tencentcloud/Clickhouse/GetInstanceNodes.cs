// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse
{
    public static class GetInstanceNodes
    {
        /// <summary>
        /// Use this data source to query detailed information of clickhouse instance_nodes
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
        ///     var instanceNodes = Tencentcloud.Clickhouse.GetInstanceNodes.Invoke(new()
        ///     {
        ///         DisplayPolicy = "all",
        ///         ForceAll = true,
        ///         InstanceId = "cdwch-mvfjh373",
        ///         NodeRole = "data",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInstanceNodesResult> InvokeAsync(GetInstanceNodesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceNodesResult>("tencentcloud:Clickhouse/getInstanceNodes:getInstanceNodes", args ?? new GetInstanceNodesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of clickhouse instance_nodes
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
        ///     var instanceNodes = Tencentcloud.Clickhouse.GetInstanceNodes.Invoke(new()
        ///     {
        ///         DisplayPolicy = "all",
        ///         ForceAll = true,
        ///         InstanceId = "cdwch-mvfjh373",
        ///         NodeRole = "data",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInstanceNodesResult> Invoke(GetInstanceNodesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceNodesResult>("tencentcloud:Clickhouse/getInstanceNodes:getInstanceNodes", args ?? new GetInstanceNodesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceNodesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Display strategy, display all when All.
        /// </summary>
        [Input("displayPolicy")]
        public string? DisplayPolicy { get; set; }

        /// <summary>
        /// When true, returns all nodes, that is, the Limit is infinitely large.
        /// </summary>
        [Input("forceAll")]
        public bool? ForceAll { get; set; }

        /// <summary>
        /// InstanceId.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Cluster role type, default is `data` data node.
        /// </summary>
        [Input("nodeRole")]
        public string? NodeRole { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceNodesArgs()
        {
        }
        public static new GetInstanceNodesArgs Empty => new GetInstanceNodesArgs();
    }

    public sealed class GetInstanceNodesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Display strategy, display all when All.
        /// </summary>
        [Input("displayPolicy")]
        public Input<string>? DisplayPolicy { get; set; }

        /// <summary>
        /// When true, returns all nodes, that is, the Limit is infinitely large.
        /// </summary>
        [Input("forceAll")]
        public Input<bool>? ForceAll { get; set; }

        /// <summary>
        /// InstanceId.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Cluster role type, default is `data` data node.
        /// </summary>
        [Input("nodeRole")]
        public Input<string>? NodeRole { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceNodesInvokeArgs()
        {
        }
        public static new GetInstanceNodesInvokeArgs Empty => new GetInstanceNodesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceNodesResult
    {
        public readonly string? DisplayPolicy;
        public readonly bool? ForceAll;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Total number of instance nodes.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceNodesInstanceNodesListResult> InstanceNodesLists;
        public readonly string? NodeRole;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceNodesResult(
            string? displayPolicy,

            bool? forceAll,

            string id,

            string instanceId,

            ImmutableArray<Outputs.GetInstanceNodesInstanceNodesListResult> instanceNodesLists,

            string? nodeRole,

            string? resultOutputFile)
        {
            DisplayPolicy = displayPolicy;
            ForceAll = forceAll;
            Id = id;
            InstanceId = instanceId;
            InstanceNodesLists = instanceNodesLists;
            NodeRole = nodeRole;
            ResultOutputFile = resultOutputFile;
        }
    }
}
