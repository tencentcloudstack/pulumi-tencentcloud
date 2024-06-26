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
    public sealed class GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskResult
    {
        /// <summary>
        /// ID of a watermarking template.
        /// </summary>
        public readonly int Definition;
        /// <summary>
        /// List of screenshot time points in the format of `s` or `%`:If the string ends in `s`, it means that the time point is in seconds; for example, `3.5s` means that the time point is the 3.5th second;If the string ends in `%`, it means that the time point is the specified percentage of the video duration; for example, `10%` means that the time point is 10% of the video duration.
        /// </summary>
        public readonly ImmutableArray<string> ExtTimeOffsetSets;
        /// <summary>
        /// Rule of the `{number}` variable in the output path after transcoding.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskObjectNumberFormatResult> ObjectNumberFormats;
        /// <summary>
        /// Path to a primary output file, which can be a relative path or an absolute path. If this parameter is left empty, the following relative path will be used by default: `{inputName}_transcode_{definition}.{format}`.
        /// </summary>
        public readonly string OutputObjectPath;
        /// <summary>
        /// The bucket to save the output file.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskOutputStorageResult> OutputStorages;
        /// <summary>
        /// List of up to 10 image or text watermarks.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskWatermarkSetResult> WatermarkSets;

        [OutputConstructor]
        private GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskResult(
            int definition,

            ImmutableArray<string> extTimeOffsetSets,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskObjectNumberFormatResult> objectNumberFormats,

            string outputObjectPath,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskOutputStorageResult> outputStorages,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaSnapshotByTimeOffsetTaskWatermarkSetResult> watermarkSets)
        {
            Definition = definition;
            ExtTimeOffsetSets = extTimeOffsetSets;
            ObjectNumberFormats = objectNumberFormats;
            OutputObjectPath = outputObjectPath;
            OutputStorages = outputStorages;
            WatermarkSets = watermarkSets;
        }
    }
}
