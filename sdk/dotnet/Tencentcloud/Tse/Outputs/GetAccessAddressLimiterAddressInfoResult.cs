// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetAccessAddressLimiterAddressInfoResult
    {
        /// <summary>
        /// VPC access IP address listNote: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public readonly string IntranetAddress;

        [OutputConstructor]
        private GetAccessAddressLimiterAddressInfoResult(string intranetAddress)
        {
            IntranetAddress = intranetAddress;
        }
    }
}
