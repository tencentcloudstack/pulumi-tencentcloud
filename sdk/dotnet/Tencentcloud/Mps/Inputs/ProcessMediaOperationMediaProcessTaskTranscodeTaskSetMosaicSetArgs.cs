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

    public sealed class ProcessMediaOperationMediaProcessTaskTranscodeTaskSetMosaicSetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Origin position, which currently can only be:TopLeft: the origin of coordinates is in the top-left corner of the video, and the origin of the blur is in the top-left corner of the image or text.Default value: TopLeft.
        /// </summary>
        [Input("coordinateOrigin")]
        public Input<string>? CoordinateOrigin { get; set; }

        /// <summary>
        /// End time offset of blur in seconds.If this parameter is left empty or 0 is entered, the blur will exist till the last video frame;If this value is greater than 0 (e.g., n), the blur will exist till second n;If this value is smaller than 0 (e.g., -n), the blur will exist till second n before the last video frame.
        /// </summary>
        [Input("endTimeOffset")]
        public Input<double>? EndTimeOffset { get; set; }

        /// <summary>
        /// Blur height. % and px formats are supported:If the string ends in %, the `Height` of the blur will be the specified percentage of the video height; for example, `10%` means that `Height` is 10% of the video height;If the string ends in px, the `Height` of the blur will be in px; for example, `100px` means that `Height` is 100 px.Default value: 10%.
        /// </summary>
        [Input("height")]
        public Input<string>? Height { get; set; }

        /// <summary>
        /// Start time offset of blur in seconds. If this parameter is left empty or 0 is entered, the blur will appear upon the first video frame.If this parameter is left empty or 0 is entered, the blur will appear upon the first video frame;If this value is greater than 0 (e.g., n), the blur will appear at second n after the first video frame;If this value is smaller than 0 (e.g., -n), the blur will appear at second n before the last video frame.
        /// </summary>
        [Input("startTimeOffset")]
        public Input<double>? StartTimeOffset { get; set; }

        /// <summary>
        /// Blur width. % and px formats are supported:If the string ends in %, the `Width` of the blur will be the specified percentage of the video width; for example, `10%` means that `Width` is 10% of the video width;If the string ends in px, the `Width` of the blur will be in px; for example, `100px` means that `Width` is 100 px.Default value: 10%.
        /// </summary>
        [Input("width")]
        public Input<string>? Width { get; set; }

        /// <summary>
        /// The horizontal position of the origin of the blur relative to the origin of coordinates of the video. % and px formats are supported:If the string ends in %, the `XPos` of the blur will be the specified percentage of the video width; for example, `10%` means that `XPos` is 10% of the video width;If the string ends in px, the `XPos` of the blur will be the specified px; for example, `100px` means that `XPos` is 100 px.Default value: 0 px.
        /// </summary>
        [Input("xPos")]
        public Input<string>? XPos { get; set; }

        /// <summary>
        /// Vertical position of the origin of blur relative to the origin of coordinates of video. % and px formats are supported:If the string ends in %, the `YPos` of the blur will be the specified percentage of the video height; for example, `10%` means that `YPos` is 10% of the video height;If the string ends in px, the `YPos` of the blur will be the specified px; for example, `100px` means that `YPos` is 100 px.Default value: 0 px.
        /// </summary>
        [Input("yPos")]
        public Input<string>? YPos { get; set; }

        public ProcessMediaOperationMediaProcessTaskTranscodeTaskSetMosaicSetArgs()
        {
        }
    }
}