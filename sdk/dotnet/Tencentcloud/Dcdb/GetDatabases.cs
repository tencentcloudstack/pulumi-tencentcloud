// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dcdb
{
    public static class GetDatabases
    {
        /// <summary>
        /// Use this data source to query detailed information of dcdb databases
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
        ///     var databases = Tencentcloud.Dcdb.GetDatabases.Invoke(new()
        ///     {
        ///         InstanceId = "your_dcdb_instance_id",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDatabasesResult> InvokeAsync(GetDatabasesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDatabasesResult>("tencentcloud:Dcdb/getDatabases:getDatabases", args ?? new GetDatabasesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dcdb databases
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
        ///     var databases = Tencentcloud.Dcdb.GetDatabases.Invoke(new()
        ///     {
        ///         InstanceId = "your_dcdb_instance_id",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDatabasesResult> Invoke(GetDatabasesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDatabasesResult>("tencentcloud:Dcdb/getDatabases:getDatabases", args ?? new GetDatabasesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatabasesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDatabasesArgs()
        {
        }
        public static new GetDatabasesArgs Empty => new GetDatabasesArgs();
    }

    public sealed class GetDatabasesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDatabasesInvokeArgs()
        {
        }
        public static new GetDatabasesInvokeArgs Empty => new GetDatabasesInvokeArgs();
    }


    [OutputType]
    public sealed class GetDatabasesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Database information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDatabasesListResult> Lists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDatabasesResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetDatabasesListResult> lists,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
