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
    public static class GetInstanceSlowQueries
    {
        /// <summary>
        /// Use this data source to query detailed information of cynosdb instance_slow_queries
        /// 
        /// ## Example Usage
        /// 
        /// ### Query slow queries of instance
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         StartTime = "2023-06-20 23:19:03",
        ///         EndTime = "2023-06-30 23:19:03",
        ///         Username = "keep_dts",
        ///         Host = "%%",
        ///         Database = "tf_ci_test",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query slow queries by time range
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         StartTime = "2023-06-20 23:19:03",
        ///         EndTime = "2023-06-30 23:19:03",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query slow queries by user and db name
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         Username = "keep_dts",
        ///         Host = "%%",
        ///         Database = "tf_ci_test",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInstanceSlowQueriesResult> InvokeAsync(GetInstanceSlowQueriesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceSlowQueriesResult>("tencentcloud:Cynosdb/getInstanceSlowQueries:getInstanceSlowQueries", args ?? new GetInstanceSlowQueriesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cynosdb instance_slow_queries
        /// 
        /// ## Example Usage
        /// 
        /// ### Query slow queries of instance
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         StartTime = "2023-06-20 23:19:03",
        ///         EndTime = "2023-06-30 23:19:03",
        ///         Username = "keep_dts",
        ///         Host = "%%",
        ///         Database = "tf_ci_test",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query slow queries by time range
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         StartTime = "2023-06-20 23:19:03",
        ///         EndTime = "2023-06-30 23:19:03",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query slow queries by user and db name
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
        ///     var config = new Config();
        ///     var cynosdbClusterId = config.Get("cynosdbClusterId") ?? "default_cynosdb_cluster";
        ///     var instanceSlowQueries = Tencentcloud.Cynosdb.GetInstanceSlowQueries.Invoke(new()
        ///     {
        ///         InstanceId = cynosdbClusterId,
        ///         Username = "keep_dts",
        ///         Host = "%%",
        ///         Database = "tf_ci_test",
        ///         OrderBy = "QueryTime",
        ///         OrderByType = "desc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInstanceSlowQueriesResult> Invoke(GetInstanceSlowQueriesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceSlowQueriesResult>("tencentcloud:Cynosdb/getInstanceSlowQueries:getInstanceSlowQueries", args ?? new GetInstanceSlowQueriesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceSlowQueriesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Database name.
        /// </summary>
        [Input("database")]
        public string? Database { get; set; }

        /// <summary>
        /// Latest transaction start time.
        /// </summary>
        [Input("endTime")]
        public string? EndTime { get; set; }

        /// <summary>
        /// Client host.
        /// </summary>
        [Input("host")]
        public string? Host { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Sort field, optional values: QueryTime, LockTime, RowsExamined, RowsSent.
        /// </summary>
        [Input("orderBy")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Sort type, optional values: asc, desc.
        /// </summary>
        [Input("orderByType")]
        public string? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Earliest transaction start time.
        /// </summary>
        [Input("startTime")]
        public string? StartTime { get; set; }

        /// <summary>
        /// user name.
        /// </summary>
        [Input("username")]
        public string? Username { get; set; }

        public GetInstanceSlowQueriesArgs()
        {
        }
        public static new GetInstanceSlowQueriesArgs Empty => new GetInstanceSlowQueriesArgs();
    }

    public sealed class GetInstanceSlowQueriesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Database name.
        /// </summary>
        [Input("database")]
        public Input<string>? Database { get; set; }

        /// <summary>
        /// Latest transaction start time.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// Client host.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Sort field, optional values: QueryTime, LockTime, RowsExamined, RowsSent.
        /// </summary>
        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        /// <summary>
        /// Sort type, optional values: asc, desc.
        /// </summary>
        [Input("orderByType")]
        public Input<string>? OrderByType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Earliest transaction start time.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        /// <summary>
        /// user name.
        /// </summary>
        [Input("username")]
        public Input<string>? Username { get; set; }

        public GetInstanceSlowQueriesInvokeArgs()
        {
        }
        public static new GetInstanceSlowQueriesInvokeArgs Empty => new GetInstanceSlowQueriesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceSlowQueriesResult
    {
        /// <summary>
        /// Database name.
        /// </summary>
        public readonly string? Database;
        public readonly string? EndTime;
        public readonly string? Host;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? OrderBy;
        public readonly string? OrderByType;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Slow query records.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceSlowQueriesSlowQueryResult> SlowQueries;
        public readonly string? StartTime;
        public readonly string? Username;

        [OutputConstructor]
        private GetInstanceSlowQueriesResult(
            string? database,

            string? endTime,

            string? host,

            string id,

            string instanceId,

            string? orderBy,

            string? orderByType,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetInstanceSlowQueriesSlowQueryResult> slowQueries,

            string? startTime,

            string? username)
        {
            Database = database;
            EndTime = endTime;
            Host = host;
            Id = id;
            InstanceId = instanceId;
            OrderBy = orderBy;
            OrderByType = orderByType;
            ResultOutputFile = resultOutputFile;
            SlowQueries = slowQueries;
            StartTime = startTime;
            Username = username;
        }
    }
}
