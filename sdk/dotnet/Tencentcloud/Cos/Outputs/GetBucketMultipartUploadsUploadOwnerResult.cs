// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class GetBucketMultipartUploadsUploadOwnerResult
    {
        /// <summary>
        /// Abbreviation for user identity ID (UIN).
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The user's unique CAM identity ID.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetBucketMultipartUploadsUploadOwnerResult(
            string displayName,

            string id)
        {
            DisplayName = displayName;
            Id = id;
        }
    }
}
