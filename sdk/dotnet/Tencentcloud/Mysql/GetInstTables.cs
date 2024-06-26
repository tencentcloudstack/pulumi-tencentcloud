// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql
{
    public static class GetInstTables
    {
        /// <summary>
        /// Use this data source to query detailed information of mysql inst_tables
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
        ///     var instTables = Tencentcloud.Mysql.GetInstTables.Invoke(new()
        ///     {
        ///         Database = "tf_ci_test",
        ///         InstanceId = "cdb-fitq5t9h",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInstTablesResult> InvokeAsync(GetInstTablesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstTablesResult>("tencentcloud:Mysql/getInstTables:getInstTables", args ?? new GetInstTablesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mysql inst_tables
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
        ///     var instTables = Tencentcloud.Mysql.GetInstTables.Invoke(new()
        ///     {
        ///         Database = "tf_ci_test",
        ///         InstanceId = "cdb-fitq5t9h",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInstTablesResult> Invoke(GetInstTablesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstTablesResult>("tencentcloud:Mysql/getInstTables:getInstTables", args ?? new GetInstTablesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstTablesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("database", required: true)]
        public string Database { get; set; } = null!;

        /// <summary>
        /// The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Match the regular expression of the database table name, the rules are the same as MySQL official website.
        /// </summary>
        [Input("tableRegexp")]
        public string? TableRegexp { get; set; }

        public GetInstTablesArgs()
        {
        }
        public static new GetInstTablesArgs Empty => new GetInstTablesArgs();
    }

    public sealed class GetInstTablesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// The instance ID, in the format: cdb-c1nl9rpv, is the same as the instance ID displayed on the cloud database console page.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Match the regular expression of the database table name, the rules are the same as MySQL official website.
        /// </summary>
        [Input("tableRegexp")]
        public Input<string>? TableRegexp { get; set; }

        public GetInstTablesInvokeArgs()
        {
        }
        public static new GetInstTablesInvokeArgs Empty => new GetInstTablesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstTablesResult
    {
        public readonly string Database;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// The returned database table information.
        /// </summary>
        public readonly ImmutableArray<string> Items;
        public readonly string? ResultOutputFile;
        public readonly string? TableRegexp;

        [OutputConstructor]
        private GetInstTablesResult(
            string database,

            string id,

            string instanceId,

            ImmutableArray<string> items,

            string? resultOutputFile,

            string? tableRegexp)
        {
            Database = database;
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
            TableRegexp = tableRegexp;
        }
    }
}
