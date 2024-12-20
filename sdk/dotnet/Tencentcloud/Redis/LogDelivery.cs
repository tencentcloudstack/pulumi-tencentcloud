// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis
{
    /// <summary>
    /// Provides a resource to create Redis instance log delivery land set its attributes.
    /// 
    /// &gt; **NOTE:** When you use an existing cls logset and topic to enable logging, there is no need to set parameters such
    /// as `period`, `create_index`, `log_region`, etc.
    /// 
    /// ## Example Usage
    /// 
    /// ### Use cls logset and topic which existed
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
    ///     var delivery = new Tencentcloud.Redis.LogDelivery("delivery", new()
    ///     {
    ///         InstanceId = "crs-dmjj8en7",
    ///         LogsetId = "cc31d9d6-74c0-4888-8b2f-b8148c3bcc5c",
    ///         TopicId = "5c2333e9-0bab-41fd-9f75-c602b3f9545f",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Use exist cls logset and create new topic
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
    ///     var delivery = new Tencentcloud.Redis.LogDelivery("delivery", new()
    ///     {
    ///         CreateIndex = true,
    ///         InstanceId = "crs-dmjj8en7",
    ///         LogsetId = "cc31d9d6-74c0-4888-8b2f-b8148c3bcc5c",
    ///         Period = 20,
    ///         TopicName = "test13",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ### Create new cls logset and topic
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
    ///     var delivery = new Tencentcloud.Redis.LogDelivery("delivery", new()
    ///     {
    ///         CreateIndex = true,
    ///         InstanceId = "crs-dmjj8en7",
    ///         LogRegion = "ap-guangzhou",
    ///         LogsetName = "test",
    ///         Period = 20,
    ///         TopicName = "test",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// Redis log delivery can be imported, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Redis/logDelivery:LogDelivery delivery crs-dmjj8en7
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Redis/logDelivery:LogDelivery")]
    public partial class LogDelivery : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Whether to create an index when creating a log topic.
        /// </summary>
        [Output("createIndex")]
        public Output<bool> CreateIndex { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// The region where the log set is located; if not specified, the region where the instance is located will be used by default.
        /// </summary>
        [Output("logRegion")]
        public Output<string> LogRegion { get; private set; } = null!;

        /// <summary>
        /// The ID of the log set being delivered.
        /// </summary>
        [Output("logsetId")]
        public Output<string> LogsetId { get; private set; } = null!;

        /// <summary>
        /// Log set name. If LogsetId does not specify a specific log set ID, please configure this parameter to set the log set name, and the system will automatically create a new log set with the specified name.
        /// </summary>
        [Output("logsetName")]
        public Output<string> LogsetName { get; private set; } = null!;

        /// <summary>
        /// Log storage time, defaults to 30 days, with an optional range of 1-3600 days.
        /// </summary>
        [Output("period")]
        public Output<int> Period { get; private set; } = null!;

        /// <summary>
        /// The ID of the topic being delivered.
        /// </summary>
        [Output("topicId")]
        public Output<string> TopicId { get; private set; } = null!;

        /// <summary>
        /// Log topic name, required when TopicId is empty, a new log topic will be automatically created.
        /// </summary>
        [Output("topicName")]
        public Output<string> TopicName { get; private set; } = null!;


        /// <summary>
        /// Create a LogDelivery resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LogDelivery(string name, LogDeliveryArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/logDelivery:LogDelivery", name, args ?? new LogDeliveryArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LogDelivery(string name, Input<string> id, LogDeliveryState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/logDelivery:LogDelivery", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LogDelivery resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LogDelivery Get(string name, Input<string> id, LogDeliveryState? state = null, CustomResourceOptions? options = null)
        {
            return new LogDelivery(name, id, state, options);
        }
    }

    public sealed class LogDeliveryArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to create an index when creating a log topic.
        /// </summary>
        [Input("createIndex")]
        public Input<bool>? CreateIndex { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// The region where the log set is located; if not specified, the region where the instance is located will be used by default.
        /// </summary>
        [Input("logRegion")]
        public Input<string>? LogRegion { get; set; }

        /// <summary>
        /// The ID of the log set being delivered.
        /// </summary>
        [Input("logsetId")]
        public Input<string>? LogsetId { get; set; }

        /// <summary>
        /// Log set name. If LogsetId does not specify a specific log set ID, please configure this parameter to set the log set name, and the system will automatically create a new log set with the specified name.
        /// </summary>
        [Input("logsetName")]
        public Input<string>? LogsetName { get; set; }

        /// <summary>
        /// Log storage time, defaults to 30 days, with an optional range of 1-3600 days.
        /// </summary>
        [Input("period")]
        public Input<int>? Period { get; set; }

        /// <summary>
        /// The ID of the topic being delivered.
        /// </summary>
        [Input("topicId")]
        public Input<string>? TopicId { get; set; }

        /// <summary>
        /// Log topic name, required when TopicId is empty, a new log topic will be automatically created.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        public LogDeliveryArgs()
        {
        }
        public static new LogDeliveryArgs Empty => new LogDeliveryArgs();
    }

    public sealed class LogDeliveryState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to create an index when creating a log topic.
        /// </summary>
        [Input("createIndex")]
        public Input<bool>? CreateIndex { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// The region where the log set is located; if not specified, the region where the instance is located will be used by default.
        /// </summary>
        [Input("logRegion")]
        public Input<string>? LogRegion { get; set; }

        /// <summary>
        /// The ID of the log set being delivered.
        /// </summary>
        [Input("logsetId")]
        public Input<string>? LogsetId { get; set; }

        /// <summary>
        /// Log set name. If LogsetId does not specify a specific log set ID, please configure this parameter to set the log set name, and the system will automatically create a new log set with the specified name.
        /// </summary>
        [Input("logsetName")]
        public Input<string>? LogsetName { get; set; }

        /// <summary>
        /// Log storage time, defaults to 30 days, with an optional range of 1-3600 days.
        /// </summary>
        [Input("period")]
        public Input<int>? Period { get; set; }

        /// <summary>
        /// The ID of the topic being delivered.
        /// </summary>
        [Input("topicId")]
        public Input<string>? TopicId { get; set; }

        /// <summary>
        /// Log topic name, required when TopicId is empty, a new log topic will be automatically created.
        /// </summary>
        [Input("topicName")]
        public Input<string>? TopicName { get; set; }

        public LogDeliveryState()
        {
        }
        public static new LogDeliveryState Empty => new LogDeliveryState();
    }
}
