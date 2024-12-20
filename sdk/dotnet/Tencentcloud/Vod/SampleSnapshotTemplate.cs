// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vod
{
    /// <summary>
    /// Provides a resource to create a vod snapshot template
    /// 
    /// ## Import
    /// 
    /// vod snapshot template can be imported using the id($subAppId#$templateId), e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Vod/sampleSnapshotTemplate:SampleSnapshotTemplate sample_snapshot_template $subAppId#$templateId
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Vod/sampleSnapshotTemplate:SampleSnapshotTemplate")]
    public partial class SampleSnapshotTemplate : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [Output("comment")]
        public Output<string?> Comment { get; private set; } = null!;

        /// <summary>
        /// Fill type. Fill refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:  stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot shorter or longer; black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks. white: fill with white. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with white color blocks. gauss: fill with Gaussian blur. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with Gaussian blur.Default value: black.
        /// </summary>
        [Output("fillType")]
        public Output<string?> FillType { get; private set; } = null!;

        /// <summary>
        /// Image format. Valid values: jpg, png. Default value: jpg.
        /// </summary>
        [Output("format")]
        public Output<string?> Format { get; private set; } = null!;

        /// <summary>
        /// Maximum value of the height (or short side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Output("height")]
        public Output<int?> Height { get; private set; } = null!;

        /// <summary>
        /// Name of a sampled screencapturing template. Length limit: 64 characters.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Resolution adaption. Valid values: open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side; close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.Default value: open.
        /// </summary>
        [Output("resolutionAdaptive")]
        public Output<string?> ResolutionAdaptive { get; private set; } = null!;

        /// <summary>
        /// Sampling interval. If `SampleType` is `Percent`, sampling will be performed at an interval of the specified percentage. If `SampleType` is `Time`, sampling will be performed at the specified time interval in seconds.
        /// </summary>
        [Output("sampleInterval")]
        public Output<int> SampleInterval { get; private set; } = null!;

        /// <summary>
        /// Sampled screencapturing type. Valid values: Percent: by percent. Time: by time interval.
        /// </summary>
        [Output("sampleType")]
        public Output<string> SampleType { get; private set; } = null!;

        /// <summary>
        /// The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.
        /// </summary>
        [Output("subAppId")]
        public Output<int> SubAppId { get; private set; } = null!;

        /// <summary>
        /// Maximum value of the width (or long side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Output("width")]
        public Output<int?> Width { get; private set; } = null!;


        /// <summary>
        /// Create a SampleSnapshotTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SampleSnapshotTemplate(string name, SampleSnapshotTemplateArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vod/sampleSnapshotTemplate:SampleSnapshotTemplate", name, args ?? new SampleSnapshotTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SampleSnapshotTemplate(string name, Input<string> id, SampleSnapshotTemplateState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vod/sampleSnapshotTemplate:SampleSnapshotTemplate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SampleSnapshotTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SampleSnapshotTemplate Get(string name, Input<string> id, SampleSnapshotTemplateState? state = null, CustomResourceOptions? options = null)
        {
            return new SampleSnapshotTemplate(name, id, state, options);
        }
    }

    public sealed class SampleSnapshotTemplateArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// Fill type. Fill refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:  stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot shorter or longer; black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks. white: fill with white. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with white color blocks. gauss: fill with Gaussian blur. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with Gaussian blur.Default value: black.
        /// </summary>
        [Input("fillType")]
        public Input<string>? FillType { get; set; }

        /// <summary>
        /// Image format. Valid values: jpg, png. Default value: jpg.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Input("height")]
        public Input<int>? Height { get; set; }

        /// <summary>
        /// Name of a sampled screencapturing template. Length limit: 64 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Resolution adaption. Valid values: open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side; close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.Default value: open.
        /// </summary>
        [Input("resolutionAdaptive")]
        public Input<string>? ResolutionAdaptive { get; set; }

        /// <summary>
        /// Sampling interval. If `SampleType` is `Percent`, sampling will be performed at an interval of the specified percentage. If `SampleType` is `Time`, sampling will be performed at the specified time interval in seconds.
        /// </summary>
        [Input("sampleInterval", required: true)]
        public Input<int> SampleInterval { get; set; } = null!;

        /// <summary>
        /// Sampled screencapturing type. Valid values: Percent: by percent. Time: by time interval.
        /// </summary>
        [Input("sampleType", required: true)]
        public Input<string> SampleType { get; set; } = null!;

        /// <summary>
        /// The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.
        /// </summary>
        [Input("subAppId", required: true)]
        public Input<int> SubAppId { get; set; } = null!;

        /// <summary>
        /// Maximum value of the width (or long side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Input("width")]
        public Input<int>? Width { get; set; }

        public SampleSnapshotTemplateArgs()
        {
        }
        public static new SampleSnapshotTemplateArgs Empty => new SampleSnapshotTemplateArgs();
    }

    public sealed class SampleSnapshotTemplateState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// Fill type. Fill refers to the way of processing a screenshot when its aspect ratio is different from that of the source video. The following fill types are supported:  stretch: stretch. The screenshot will be stretched frame by frame to match the aspect ratio of the source video, which may make the screenshot shorter or longer; black: fill with black. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with black color blocks. white: fill with white. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with white color blocks. gauss: fill with Gaussian blur. This option retains the aspect ratio of the source video for the screenshot and fills the unmatched area with Gaussian blur.Default value: black.
        /// </summary>
        [Input("fillType")]
        public Input<string>? FillType { get; set; }

        /// <summary>
        /// Image format. Valid values: jpg, png. Default value: jpg.
        /// </summary>
        [Input("format")]
        public Input<string>? Format { get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Input("height")]
        public Input<int>? Height { get; set; }

        /// <summary>
        /// Name of a sampled screencapturing template. Length limit: 64 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Resolution adaption. Valid values: open: enabled. In this case, `Width` represents the long side of a video, while `Height` the short side; close: disabled. In this case, `Width` represents the width of a video, while `Height` the height.Default value: open.
        /// </summary>
        [Input("resolutionAdaptive")]
        public Input<string>? ResolutionAdaptive { get; set; }

        /// <summary>
        /// Sampling interval. If `SampleType` is `Percent`, sampling will be performed at an interval of the specified percentage. If `SampleType` is `Time`, sampling will be performed at the specified time interval in seconds.
        /// </summary>
        [Input("sampleInterval")]
        public Input<int>? SampleInterval { get; set; }

        /// <summary>
        /// Sampled screencapturing type. Valid values: Percent: by percent. Time: by time interval.
        /// </summary>
        [Input("sampleType")]
        public Input<string>? SampleType { get; set; }

        /// <summary>
        /// The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.
        /// </summary>
        [Input("subAppId")]
        public Input<int>? SubAppId { get; set; }

        /// <summary>
        /// Maximum value of the width (or long side) of a screenshot in px. Value range: 0 and [128, 4,096]. If both `Width` and `Height` are 0, the resolution will be the same as that of the source video; If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled; If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled; If both `Width` and `Height` are not 0, the custom resolution will be used.Default value: 0.
        /// </summary>
        [Input("width")]
        public Input<int>? Width { get; set; }

        public SampleSnapshotTemplateState()
        {
        }
        public static new SampleSnapshotTemplateState Empty => new SampleSnapshotTemplateState();
    }
}
