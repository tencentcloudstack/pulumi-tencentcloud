// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb
{
    public static class GetClusterDetailDatabases
    {
        /// <summary>
        /// Use this data source to query detailed information of cynosdb cluster_detail_databases
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
        ///     var clusterDetailDatabases = Tencentcloud.Cynosdb.GetClusterDetailDatabases.Invoke(new()
        ///     {
        ///         ClusterId = "cynosdbmysql-bws8h88b",
        ///         DbName = "users",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetClusterDetailDatabasesResult> InvokeAsync(GetClusterDetailDatabasesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClusterDetailDatabasesResult>("tencentcloud:Cynosdb/getClusterDetailDatabases:getClusterDetailDatabases", args ?? new GetClusterDetailDatabasesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cynosdb cluster_detail_databases
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
        ///     var clusterDetailDatabases = Tencentcloud.Cynosdb.GetClusterDetailDatabases.Invoke(new()
        ///     {
        ///         ClusterId = "cynosdbmysql-bws8h88b",
        ///         DbName = "users",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetClusterDetailDatabasesResult> Invoke(GetClusterDetailDatabasesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClusterDetailDatabasesResult>("tencentcloud:Cynosdb/getClusterDetailDatabases:getClusterDetailDatabases", args ?? new GetClusterDetailDatabasesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterDetailDatabasesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        /// <summary>
        /// Database Name.
        /// </summary>
        [Input("dbName")]
        public string? DbName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetClusterDetailDatabasesArgs()
        {
        }
        public static new GetClusterDetailDatabasesArgs Empty => new GetClusterDetailDatabasesArgs();
    }

    public sealed class GetClusterDetailDatabasesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Database Name.
        /// </summary>
        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetClusterDetailDatabasesInvokeArgs()
        {
        }
        public static new GetClusterDetailDatabasesInvokeArgs Empty => new GetClusterDetailDatabasesInvokeArgs();
    }


    [OutputType]
    public sealed class GetClusterDetailDatabasesResult
    {
        /// <summary>
        /// Cluster Id note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// Database information note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterDetailDatabasesDbInfoResult> DbInfos;
        /// <summary>
        /// Database Name.
        /// </summary>
        public readonly string? DbName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetClusterDetailDatabasesResult(
            string clusterId,

            ImmutableArray<Outputs.GetClusterDetailDatabasesDbInfoResult> dbInfos,

            string? dbName,

            string id,

            string? resultOutputFile)
        {
            ClusterId = clusterId;
            DbInfos = dbInfos;
            DbName = dbName;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
