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
    public sealed class GetSchedulesScheduleInfoSetActivityActivityParaSampleSnapshotTaskOutputStorageS3OutputStorageResult
    {
        /// <summary>
        /// The AWS S3 bucket bound to the scheme.
        /// </summary>
        public readonly string S3Bucket;
        /// <summary>
        /// The region of the AWS S3 bucket.
        /// </summary>
        public readonly string S3Region;
        /// <summary>
        /// The key ID of the AWS S3 bucket.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string S3SecretId;
        /// <summary>
        /// The key of the AWS S3 bucket.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string S3SecretKey;

        [OutputConstructor]
        private GetSchedulesScheduleInfoSetActivityActivityParaSampleSnapshotTaskOutputStorageS3OutputStorageResult(
            string s3Bucket,

            string s3Region,

            string s3SecretId,

            string s3SecretKey)
        {
            S3Bucket = s3Bucket;
            S3Region = s3Region;
            S3SecretId = s3SecretId;
            S3SecretKey = s3SecretKey;
        }
    }
}