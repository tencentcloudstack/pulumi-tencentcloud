// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eip.Outputs
{

    [OutputType]
    public sealed class GetAddressQuotaQuotaSetResult
    {
        /// <summary>
        /// Current count.
        /// </summary>
        public readonly int QuotaCurrent;
        /// <summary>
        /// Quota name: TOTAL_EIP_QUOTA,DAILY_EIP_APPLY,DAILY_PUBLIC_IP_ASSIGN.
        /// </summary>
        public readonly string QuotaId;
        /// <summary>
        /// quota count.
        /// </summary>
        public readonly int QuotaLimit;

        [OutputConstructor]
        private GetAddressQuotaQuotaSetResult(
            int quotaCurrent,

            string quotaId,

            int quotaLimit)
        {
            QuotaCurrent = quotaCurrent;
            QuotaId = quotaId;
            QuotaLimit = quotaLimit;
        }
    }
}
