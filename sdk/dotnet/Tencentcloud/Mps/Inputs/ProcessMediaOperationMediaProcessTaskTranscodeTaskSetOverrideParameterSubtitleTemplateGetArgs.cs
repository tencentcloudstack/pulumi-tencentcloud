// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Inputs
{

    public sealed class ProcessMediaOperationMediaProcessTaskTranscodeTaskSetOverrideParameterSubtitleTemplateGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The text transparency. Value range: 0-1.`0`: Fully transparent.`1`: Fully opaque.Default value: 1.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("fontAlpha")]
        public Input<double>? FontAlpha { get; set; }

        /// <summary>
        /// The font color in 0xRRGGBB format. Default value: 0xFFFFFF (white).Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("fontColor")]
        public Input<string>? FontColor { get; set; }

        /// <summary>
        /// The font size (pixels). If this is not specified, the font size in the subtitle file will be used.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("fontSize")]
        public Input<string>? FontSize { get; set; }

        /// <summary>
        /// The font. Valid values:`hei.ttf`: Heiti.`song.ttf`: Songti.`simkai.ttf`: Kaiti.`arial.ttf`: Arial.The default is `hei.ttf`.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("fontType")]
        public Input<string>? FontType { get; set; }

        /// <summary>
        /// The URL of the subtitles to add to the video.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The subtitle track to add to the video. If both `Path` and `StreamIndex` are specified, `Path` will be used. You need to specify at least one of the two parameters.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("streamIndex")]
        public Input<int>? StreamIndex { get; set; }

        public ProcessMediaOperationMediaProcessTaskTranscodeTaskSetOverrideParameterSubtitleTemplateGetArgs()
        {
        }
        public static new ProcessMediaOperationMediaProcessTaskTranscodeTaskSetOverrideParameterSubtitleTemplateGetArgs Empty => new ProcessMediaOperationMediaProcessTaskTranscodeTaskSetOverrideParameterSubtitleTemplateGetArgs();
    }
}
