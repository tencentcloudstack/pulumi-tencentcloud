// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vod.Outputs
{

    [OutputType]
    public sealed class WatermarkTemplateTextTemplate
    {
        /// <summary>
        /// Text transparency. Value range: (0, 1] 0: completely transparent  1: completely opaque Default value: 1.
        /// </summary>
        public readonly double FontAlpha;
        /// <summary>
        /// Font color in 0xRRGGBB format. Default value: 0xFFFFFF (white).
        /// </summary>
        public readonly string FontColor;
        /// <summary>
        /// Font size in Npx format where N is a numeric value.
        /// </summary>
        public readonly string FontSize;
        /// <summary>
        /// Font type. Currently, two types are supported: simkai.ttf: both Chinese and English are supported;  arial.ttf: only English is supported.
        /// </summary>
        public readonly string FontType;

        [OutputConstructor]
        private WatermarkTemplateTextTemplate(
            double fontAlpha,

            string fontColor,

            string fontSize,

            string fontType)
        {
            FontAlpha = fontAlpha;
            FontColor = fontColor;
            FontSize = fontSize;
            FontType = fontType;
        }
    }
}
