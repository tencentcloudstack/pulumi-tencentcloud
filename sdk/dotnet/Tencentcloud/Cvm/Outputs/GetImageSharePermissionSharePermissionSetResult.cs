// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm.Outputs
{

    [OutputType]
    public sealed class GetImageSharePermissionSharePermissionSetResult
    {
        /// <summary>
        /// ID of the account with which the image is shared.
        /// </summary>
        public readonly string AccountId;
        /// <summary>
        /// Time when an image was shared.
        /// </summary>
        public readonly string CreatedTime;

        [OutputConstructor]
        private GetImageSharePermissionSharePermissionSetResult(
            string accountId,

            string createdTime)
        {
            AccountId = accountId;
            CreatedTime = createdTime;
        }
    }
}