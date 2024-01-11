// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class ContentReviewTemplateProhibitedConfigure
    {
        /// <summary>
        /// Voice Prohibition Control Parameters.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ContentReviewTemplateProhibitedConfigureAsrReviewInfo? AsrReviewInfo;
        /// <summary>
        /// Ocr Prohibition Control Parameters.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ContentReviewTemplateProhibitedConfigureOcrReviewInfo? OcrReviewInfo;

        [OutputConstructor]
        private ContentReviewTemplateProhibitedConfigure(
            Outputs.ContentReviewTemplateProhibitedConfigureAsrReviewInfo? asrReviewInfo,

            Outputs.ContentReviewTemplateProhibitedConfigureOcrReviewInfo? ocrReviewInfo)
        {
            AsrReviewInfo = asrReviewInfo;
            OcrReviewInfo = ocrReviewInfo;
        }
    }
}