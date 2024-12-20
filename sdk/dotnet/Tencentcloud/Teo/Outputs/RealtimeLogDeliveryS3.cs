// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class RealtimeLogDeliveryS3
    {
        /// <summary>
        /// Fill in a custom SecretId to generate an encrypted signature. This parameter is required if the source site requires authentication.
        /// </summary>
        public readonly string AccessId;
        /// <summary>
        /// Fill in the custom SecretKey to generate the encrypted signature. This parameter is required if the source site requires authentication.
        /// </summary>
        public readonly string AccessKey;
        /// <summary>
        /// Bucket name and log storage directory, for example: `your_bucket_name/EO-logs/`. If this directory does not exist in the bucket, it will be created automatically.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Data compression type, the possible values are: `gzip`: use gzip compression. If it is not filled in, compression is not enabled.
        /// </summary>
        public readonly string? CompressType;
        /// <summary>
        /// URLs that do not include bucket names or paths, for example: `https://storage.googleapis.com`, `https://s3.ap-northeast-2.amazonaws.com`, `https://cos.ap-nanjing.myqcloud.com`.
        /// </summary>
        public readonly string Endpoint;
        /// <summary>
        /// The region where the bucket is located, for example: ap-northeast-2.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private RealtimeLogDeliveryS3(
            string accessId,

            string accessKey,

            string bucket,

            string? compressType,

            string endpoint,

            string region)
        {
            AccessId = accessId;
            AccessKey = accessKey;
            Bucket = bucket;
            CompressType = compressType;
            Endpoint = endpoint;
            Region = region;
        }
    }
}
