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

    public sealed class MediaPicProcessTemplatePicProcessArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to return the original image information.
        /// </summary>
        [Input("isPicInfo")]
        public Input<string>? IsPicInfo { get; set; }

        /// <summary>
        /// Image processing rules, 1: basic image processing, please refer to the basic image processing document, 2: image compression, please refer to the image compression document, 3: blind watermark, please refer to the blind watermark document.
        /// </summary>
        [Input("processRule", required: true)]
        public Input<string> ProcessRule { get; set; } = null!;

        public MediaPicProcessTemplatePicProcessArgs()
        {
        }
    }
}