// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps
{
    /// <summary>
    /// Provides a resource to create a mps schedule
    /// 
    /// ## Example Usage
    /// 
    /// ### Create a schedule through COS bucket
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = Pulumi.Tencentcloud;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var @object = Tencentcloud.Cos.GetBucketObject.Invoke(new()
    ///     {
    ///         Bucket = $"keep-bucket-{local.App_id}",
    ///         Key = "/mps-test/test.mov",
    ///     });
    /// 
    ///     var output = new Tencentcloud.Cos.Bucket("output", new()
    ///     {
    ///         CosBucket = $"tf-bucket-mps-schedule-output-{local.App_id}",
    ///         ForceClean = true,
    ///         Acl = "public-read",
    ///     });
    /// 
    ///     var schedule = new Tencentcloud.Mps.Schedule("schedule", new()
    ///     {
    ///         ScheduleName = "tf_test_mps_schedule_%d",
    ///         Trigger = new Tencentcloud.Mps.Inputs.ScheduleTriggerArgs
    ///         {
    ///             Type = "CosFileUpload",
    ///             CosFileUploadTrigger = new Tencentcloud.Mps.Inputs.ScheduleTriggerCosFileUploadTriggerArgs
    ///             {
    ///                 Bucket = @object.Apply(@object =&gt; @object.Apply(getBucketObjectResult =&gt; getBucketObjectResult.Bucket)),
    ///                 Region = "%s",
    ///                 Dir = "/upload/",
    ///                 Formats = new[]
    ///                 {
    ///                     "flv",
    ///                     "mov",
    ///                 },
    ///             },
    ///         },
    ///         Activities = new[]
    ///         {
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "input",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     1,
    ///                     2,
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     3,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     6,
    ///                     7,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     4,
    ///                     5,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     10,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     10,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     10,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     8,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     9,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "action-trans",
    ///                 ReardriveIndices = new[]
    ///                 {
    ///                     10,
    ///                 },
    ///                 ActivityPara = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaArgs
    ///                 {
    ///                     TranscodeTask = new Tencentcloud.Mps.Inputs.ScheduleActivityActivityParaTranscodeTaskArgs
    ///                     {
    ///                         Definition = 10,
    ///                     },
    ///                 },
    ///             },
    ///             new Tencentcloud.Mps.Inputs.ScheduleActivityArgs
    ///             {
    ///                 ActivityType = "output",
    ///             },
    ///         },
    ///         OutputStorage = new Tencentcloud.Mps.Inputs.ScheduleOutputStorageArgs
    ///         {
    ///             Type = "COS",
    ///             CosOutputStorage = new Tencentcloud.Mps.Inputs.ScheduleOutputStorageCosOutputStorageArgs
    ///             {
    ///                 Bucket = output.CosBucket,
    ///                 Region = "%s",
    ///             },
    ///         },
    ///         OutputDir = "output/",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// mps schedule can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Mps/schedule:Schedule schedule schedule_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Mps/schedule:Schedule")]
    public partial class Schedule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The subtasks of the scheme.
        /// </summary>
        [Output("activities")]
        public Output<ImmutableArray<Outputs.ScheduleActivity>> Activities { get; private set; } = null!;

        /// <summary>
        /// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
        /// </summary>
        [Output("outputDir")]
        public Output<string?> OutputDir { get; private set; } = null!;

        /// <summary>
        /// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
        /// </summary>
        [Output("outputStorage")]
        public Output<Outputs.ScheduleOutputStorage?> OutputStorage { get; private set; } = null!;

        /// <summary>
        /// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
        /// </summary>
        [Output("resourceId")]
        public Output<string?> ResourceId { get; private set; } = null!;

        /// <summary>
        /// The scheme name (max 128 characters). This name should be unique across your account.
        /// </summary>
        [Output("scheduleName")]
        public Output<string> ScheduleName { get; private set; } = null!;

        /// <summary>
        /// The notification configuration. If you do not specify this parameter, notifications will not be sent.
        /// </summary>
        [Output("taskNotifyConfig")]
        public Output<Outputs.ScheduleTaskNotifyConfig> TaskNotifyConfig { get; private set; } = null!;

        /// <summary>
        /// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
        /// </summary>
        [Output("trigger")]
        public Output<Outputs.ScheduleTrigger> Trigger { get; private set; } = null!;


        /// <summary>
        /// Create a Schedule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Schedule(string name, ScheduleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/schedule:Schedule", name, args ?? new ScheduleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Schedule(string name, Input<string> id, ScheduleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/schedule:Schedule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Schedule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Schedule Get(string name, Input<string> id, ScheduleState? state = null, CustomResourceOptions? options = null)
        {
            return new Schedule(name, id, state, options);
        }
    }

    public sealed class ScheduleArgs : global::Pulumi.ResourceArgs
    {
        [Input("activities", required: true)]
        private InputList<Inputs.ScheduleActivityArgs>? _activities;

        /// <summary>
        /// The subtasks of the scheme.
        /// </summary>
        public InputList<Inputs.ScheduleActivityArgs> Activities
        {
            get => _activities ?? (_activities = new InputList<Inputs.ScheduleActivityArgs>());
            set => _activities = value;
        }

        /// <summary>
        /// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
        /// </summary>
        [Input("outputDir")]
        public Input<string>? OutputDir { get; set; }

        /// <summary>
        /// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
        /// </summary>
        [Input("outputStorage")]
        public Input<Inputs.ScheduleOutputStorageArgs>? OutputStorage { get; set; }

        /// <summary>
        /// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        /// <summary>
        /// The scheme name (max 128 characters). This name should be unique across your account.
        /// </summary>
        [Input("scheduleName", required: true)]
        public Input<string> ScheduleName { get; set; } = null!;

        /// <summary>
        /// The notification configuration. If you do not specify this parameter, notifications will not be sent.
        /// </summary>
        [Input("taskNotifyConfig")]
        public Input<Inputs.ScheduleTaskNotifyConfigArgs>? TaskNotifyConfig { get; set; }

        /// <summary>
        /// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
        /// </summary>
        [Input("trigger", required: true)]
        public Input<Inputs.ScheduleTriggerArgs> Trigger { get; set; } = null!;

        public ScheduleArgs()
        {
        }
        public static new ScheduleArgs Empty => new ScheduleArgs();
    }

    public sealed class ScheduleState : global::Pulumi.ResourceArgs
    {
        [Input("activities")]
        private InputList<Inputs.ScheduleActivityGetArgs>? _activities;

        /// <summary>
        /// The subtasks of the scheme.
        /// </summary>
        public InputList<Inputs.ScheduleActivityGetArgs> Activities
        {
            get => _activities ?? (_activities = new InputList<Inputs.ScheduleActivityGetArgs>());
            set => _activities = value;
        }

        /// <summary>
        /// The directory to save the media processing output file, which must start and end with `/`, such as `/movie/201907/`.If you do not specify this, the file will be saved to the trigger directory.
        /// </summary>
        [Input("outputDir")]
        public Input<string>? OutputDir { get; set; }

        /// <summary>
        /// The bucket to save the output file. If you do not specify this parameter, the bucket in `Trigger` will be used.
        /// </summary>
        [Input("outputStorage")]
        public Input<Inputs.ScheduleOutputStorageGetArgs>? OutputStorage { get; set; }

        /// <summary>
        /// Resource ID, you need to ensure that the corresponding resource is open. The default is the account main resource ID.
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        /// <summary>
        /// The scheme name (max 128 characters). This name should be unique across your account.
        /// </summary>
        [Input("scheduleName")]
        public Input<string>? ScheduleName { get; set; }

        /// <summary>
        /// The notification configuration. If you do not specify this parameter, notifications will not be sent.
        /// </summary>
        [Input("taskNotifyConfig")]
        public Input<Inputs.ScheduleTaskNotifyConfigGetArgs>? TaskNotifyConfig { get; set; }

        /// <summary>
        /// The trigger of the scheme. If a file is uploaded to the specified bucket, the scheme will be triggered.
        /// </summary>
        [Input("trigger")]
        public Input<Inputs.ScheduleTriggerGetArgs>? Trigger { get; set; }

        public ScheduleState()
        {
        }
        public static new ScheduleState Empty => new ScheduleState();
    }
}
