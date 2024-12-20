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
    public sealed class GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageResult
    {
        /// <summary>
        /// The location to save the output object in COS. This parameter is valid and required when `Type` is COS.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageCosOutputStorageResult> CosOutputStorages;
        /// <summary>
        /// The AWS S3 bucket to save the output file. This parameter is required if `Type` is `AWS-S3`.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageS3OutputStorageResult> S3OutputStorages;
        /// <summary>
        /// The trigger type. Valid values:`CosFileUpload`: Tencent Cloud COS trigger.`AwsS3FileUpload`: AWS S3 trigger. Currently, this type is only supported for transcoding tasks and schemes (not supported for workflows).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageResult(
            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageCosOutputStorageResult> cosOutputStorages,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetActivityActivityParaAnimatedGraphicTaskOutputStorageS3OutputStorageResult> s3OutputStorages,

            string type)
        {
            CosOutputStorages = cosOutputStorages;
            S3OutputStorages = s3OutputStorages;
            Type = type;
        }
    }
}
