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
    public sealed class ScheduleActivityActivityParaAdaptiveDynamicStreamingTaskAddOnSubtitle
    {
        /// <summary>
        /// Subtitle file.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ScheduleActivityActivityParaAdaptiveDynamicStreamingTaskAddOnSubtitleSubtitle? Subtitle;
        /// <summary>
        /// The inserting type. Valid values: `subtitle-stream`:Insert title track. `close-caption-708`:CEA-708 subtitle encode to SEI frame. `close-caption-608`:CEA-608 subtitle encode to SEI frame. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ScheduleActivityActivityParaAdaptiveDynamicStreamingTaskAddOnSubtitle(
            Outputs.ScheduleActivityActivityParaAdaptiveDynamicStreamingTaskAddOnSubtitleSubtitle? subtitle,

            string? type)
        {
            Subtitle = subtitle;
            Type = type;
        }
    }
}