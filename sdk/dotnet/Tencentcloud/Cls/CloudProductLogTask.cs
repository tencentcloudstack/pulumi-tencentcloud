// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls
{
    /// <summary>
    /// Provides a resource to create a cls cloud product log task
    /// 
    /// &gt; **NOTE:** Using this resource will create new `logset` and `topic`
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Tencentcloud.Cls.CloudProductLogTask("example", new()
    ///     {
    ///         AssumerName = "PostgreSQL",
    ///         CloudProductRegion = "gz",
    ///         ClsRegion = "ap-guangzhou",
    ///         InstanceId = "postgres-1p7xvpc1",
    ///         LogType = "PostgreSQL-SLOW",
    ///         LogsetName = "tf-example",
    ///         TopicName = "tf-example",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// cls cloud product log task can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Cls/cloudProductLogTask:CloudProductLogTask example postgres-1p7xvpc1#PostgreSQL#PostgreSQL-SLOW#gz
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Cls/cloudProductLogTask:CloudProductLogTask")]
    public partial class CloudProductLogTask : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Cloud product identification, Values: CDS, CWP, CDB, TDSQL-C, MongoDB, TDStore, DCDB, MariaDB, PostgreSQL, BH, APIS.
        /// </summary>
        [Output("assumerName")]
        public Output<string> AssumerName { get; private set; } = null!;

        /// <summary>
        /// Cloud product region. There are differences in the input format of different log types in different regions. Please refer to the following example:
        /// - CDS(all log type): ap-guangzhou
        /// - CDB-AUDIT: gz
        /// - TDSQL-C-AUDIT: gz
        /// - MongoDB-AUDIT: gz
        /// - MongoDB-SlowLog: ap-guangzhou
        /// - MongoDB-ErrorLog: ap-guangzhou
        /// - TDMYSQL-SLOW: gz
        /// - DCDB(all log type): gz
        /// - MariaDB(all log type): gz
        /// - PostgreSQL(all log type): gz
        /// - BH(all log type): overseas-polaris(Domestic sites overseas)/fsi-polaris(Domestic sites finance)/general-polaris(Domestic sites)/intl-sg-prod(International sites)
        /// - APIS(all log type): gz.
        /// </summary>
        [Output("cloudProductRegion")]
        public Output<string> CloudProductRegion { get; private set; } = null!;

        /// <summary>
        /// CLS target region.
        /// </summary>
        [Output("clsRegion")]
        public Output<string> ClsRegion { get; private set; } = null!;

        /// <summary>
        /// Log configuration extension information, generally used to store additional log delivery configurations.
        /// </summary>
        [Output("extend")]
        public Output<string?> Extend { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Log type, Values: CDS-AUDIT, CDS-RISK, CDB-AUDIT, TDSQL-C-AUDIT, MongoDB-AUDIT, MongoDB-SlowLog, MongoDB-ErrorLog, TDMYSQL-SLOW, DCDB-AUDIT, DCDB-SLOW, DCDB-ERROR, MariaDB-AUDIT, MariaDB-SLOW, MariaDB-ERROR, PostgreSQL-SLOW, PostgreSQL-ERROR, PostgreSQL-AUDIT, BH-FILELOG, BH-COMMANDLOG, APIS-ACCESS.
        /// </summary>
        [Output("logType")]
        public Output<string> LogType { get; private set; } = null!;

        /// <summary>
        /// Log set ID.
        /// </summary>
        [Output("logsetId")]
        public Output<string> LogsetId { get; private set; } = null!;

        /// <summary>
        /// Log set name, it will be automatically created.
        /// </summary>
        [Output("logsetName")]
        public Output<string?> LogsetName { get; private set; } = null!;

        /// <summary>
        /// Log theme ID.
        /// </summary>
        [Output("topicId")]
        public Output<string> TopicId { get; private set; } = null!;

        /// <summary>
        /// The name of the log topic, it will be automatically created.
        /// </summary>
        [Output("topicName")]
        public Output<string?> TopicName { get; private set; } = null!;


        /// <summary>
        /// Create a CloudProductLogTask resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CloudProductLogTask(string name, CloudProductLogTaskArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/cloudProductLogTask:CloudProductLogTask", name, args ?? new CloudProductLogTaskArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CloudProductLogTask(string name, Input<string> id, CloudProductLogTaskState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/cloudProductLogTask:CloudProductLogTask", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing CloudProductLogTask resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CloudProductLogTask Get(string name, Input<string> id, CloudProductLogTaskState? state = null, CustomResourceOptions? options = null)
        {
            return new CloudProductLogTask(name, id, state, options);
        }
    }

    public sealed class CloudProductLogTaskArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud product identification, Values: CDS, CWP, CDB, TDSQL-C, MongoDB, TDStore, DCDB, MariaDB, PostgreSQL, BH, APIS.
        /// </summary>
        [Input("assumerName", required: true)]
        public Input<string> AssumerName { get; set; } = null!;

        /// <summary>
        /// Cloud product region. There are differences in the input format of different log types in different regions. Please refer to the following example:
        /// - CDS(all log type): ap-guangzhou
        /// - CDB-AUDIT: gz
        /// - TDSQL-C-AUDIT: gz
        /// - MongoDB-AUDIT: gz
        /// - MongoDB-SlowLog: ap-guangzhou
        /// - MongoDB-ErrorLog: ap-guangzhou
        /// - TDMYSQL-SLOW: gz
        /// - DCDB(all log type): gz
        /// - MariaDB(all log type): gz
        /// - PostgreSQL(all log type): gz
        /// - BH(all log type): overseas-polaris(Domestic sites overseas)/fsi-polaris(Domestic sites finance)/general-polaris(Domestic sites)/intl-sg-prod(International sites)
        /// - APIS(all log type): gz.
        /// </summary>
        [Input("cloudProductRegion", required: true)]
        public Input<string> CloudProductRegion { get; set; } = null!;

        /// <summary>
        /// CLS target region.
        /// </summary>
        [Input("clsRegion", required: true)]
        public Input<string> ClsRegion { get; set; } = null!;

        /// <summary>
        /// Log configuration extension information, generally used to store additional log delivery configurations.
        /// </summary>
        [Input("extend")]
        public Input<string>? Extend { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Log type, Values: CDS-AUDIT, CDS-RISK, CDB-AUDIT, TDSQL-C-AUDIT, MongoDB-AUDIT, MongoDB-SlowLog, MongoDB-ErrorLog, TDMYSQL-SLOW, DCDB-AUDIT, DCDB-SLOW, DCDB-ERROR, MariaDB-AUDIT, MariaDB-SLOW, MariaDB-ERROR, PostgreSQL-SLOW, PostgreSQL-ERROR, PostgreSQL-AUDIT, BH-FILELOG, BH-COMMANDLOG, APIS-ACCESS.
        /// </summary>
        [Input("logType", required: true)]
        public Input<string> LogType { get; set; } = null!;

        /// <summary>
        /// Log set name, it will be automatically created.
        /// </summary>
        [Input("logsetName")]
        public Input<string>? LogsetName { get; set; }

        /// <summary>
        /// The name of the log topic, it will be automatically created.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        public CloudProductLogTaskArgs()
        {
        }
        public static new CloudProductLogTaskArgs Empty => new CloudProductLogTaskArgs();
    }

    public sealed class CloudProductLogTaskState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud product identification, Values: CDS, CWP, CDB, TDSQL-C, MongoDB, TDStore, DCDB, MariaDB, PostgreSQL, BH, APIS.
        /// </summary>
        [Input("assumerName")]
        public Input<string>? AssumerName { get; set; }

        /// <summary>
        /// Cloud product region. There are differences in the input format of different log types in different regions. Please refer to the following example:
        /// - CDS(all log type): ap-guangzhou
        /// - CDB-AUDIT: gz
        /// - TDSQL-C-AUDIT: gz
        /// - MongoDB-AUDIT: gz
        /// - MongoDB-SlowLog: ap-guangzhou
        /// - MongoDB-ErrorLog: ap-guangzhou
        /// - TDMYSQL-SLOW: gz
        /// - DCDB(all log type): gz
        /// - MariaDB(all log type): gz
        /// - PostgreSQL(all log type): gz
        /// - BH(all log type): overseas-polaris(Domestic sites overseas)/fsi-polaris(Domestic sites finance)/general-polaris(Domestic sites)/intl-sg-prod(International sites)
        /// - APIS(all log type): gz.
        /// </summary>
        [Input("cloudProductRegion")]
        public Input<string>? CloudProductRegion { get; set; }

        /// <summary>
        /// CLS target region.
        /// </summary>
        [Input("clsRegion")]
        public Input<string>? ClsRegion { get; set; }

        /// <summary>
        /// Log configuration extension information, generally used to store additional log delivery configurations.
        /// </summary>
        [Input("extend")]
        public Input<string>? Extend { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Log type, Values: CDS-AUDIT, CDS-RISK, CDB-AUDIT, TDSQL-C-AUDIT, MongoDB-AUDIT, MongoDB-SlowLog, MongoDB-ErrorLog, TDMYSQL-SLOW, DCDB-AUDIT, DCDB-SLOW, DCDB-ERROR, MariaDB-AUDIT, MariaDB-SLOW, MariaDB-ERROR, PostgreSQL-SLOW, PostgreSQL-ERROR, PostgreSQL-AUDIT, BH-FILELOG, BH-COMMANDLOG, APIS-ACCESS.
        /// </summary>
        [Input("logType")]
        public Input<string>? LogType { get; set; }

        /// <summary>
        /// Log set ID.
        /// </summary>
        [Input("logsetId")]
        public Input<string>? LogsetId { get; set; }

        /// <summary>
        /// Log set name, it will be automatically created.
        /// </summary>
        [Input("logsetName")]
        public Input<string>? LogsetName { get; set; }

        /// <summary>
        /// Log theme ID.
        /// </summary>
        [Input("topicId")]
        public Input<string>? TopicId { get; set; }

        /// <summary>
        /// The name of the log topic, it will be automatically created.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        public CloudProductLogTaskState()
        {
        }
        public static new CloudProductLogTaskState Empty => new CloudProductLogTaskState();
    }
}