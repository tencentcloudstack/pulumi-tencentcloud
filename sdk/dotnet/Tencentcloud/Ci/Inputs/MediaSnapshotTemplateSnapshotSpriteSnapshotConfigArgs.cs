// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ci.Inputs
{

    public sealed class MediaSnapshotTemplateSnapshotSpriteSnapshotConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Single image height Value range: [8, 4096], Unit: px.
        /// </summary>
        [Input("cellHeight")]
        public Input<string>? CellHeight { get; set; }

        /// <summary>
        /// Single image width Value range: [8, 4096], Unit: px.
        /// </summary>
        [Input("cellWidth")]
        public Input<string>? CellWidth { get; set; }

        /// <summary>
        /// See `https://www.ffmpeg.org/ffmpeg-utils.html#color-syntax` for details on supported colors.
        /// </summary>
        [Input("color", required: true)]
        public Input<string> Color { get; set; } = null!;

        /// <summary>
        /// Number of screenshot columns, value range: [1, 10000].
        /// </summary>
        [Input("columns", required: true)]
        public Input<string> Columns { get; set; } = null!;

        /// <summary>
        /// Number of screenshot lines, value range: [1, 10000].
        /// </summary>
        [Input("lines", required: true)]
        public Input<string> Lines { get; set; } = null!;

        /// <summary>
        /// screenshot margin size, Value range: [8, 4096], Unit: px.
        /// </summary>
        [Input("margin")]
        public Input<string>? Margin { get; set; }

        /// <summary>
        /// screenshot padding size, Value range: [8, 4096], Unit: px.
        /// </summary>
        [Input("padding")]
        public Input<string>? Padding { get; set; }

        public MediaSnapshotTemplateSnapshotSpriteSnapshotConfigArgs()
        {
        }
        public static new MediaSnapshotTemplateSnapshotSpriteSnapshotConfigArgs Empty => new MediaSnapshotTemplateSnapshotSpriteSnapshotConfigArgs();
    }
}
