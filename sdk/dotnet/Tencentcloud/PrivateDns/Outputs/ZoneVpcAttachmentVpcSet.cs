// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.PrivateDns.Outputs
{

    [OutputType]
    public sealed class ZoneVpcAttachmentVpcSet
    {
        /// <summary>
        /// Vpc region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Uniq Vpc Id.
        /// </summary>
        public readonly string UniqVpcId;

        [OutputConstructor]
        private ZoneVpcAttachmentVpcSet(
            string region,

            string uniqVpcId)
        {
            Region = region;
            UniqVpcId = uniqVpcId;
        }
    }
}
