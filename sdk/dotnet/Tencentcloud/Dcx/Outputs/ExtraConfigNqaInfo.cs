// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dcx.Outputs
{

    [OutputType]
    public sealed class ExtraConfigNqaInfo
    {
        /// <summary>
        /// detect ip.
        /// </summary>
        public readonly string? DestinationIp;
        /// <summary>
        /// detect interval.
        /// </summary>
        public readonly int? Interval;
        /// <summary>
        /// detect times.
        /// </summary>
        public readonly int? ProbeFailedTimes;

        [OutputConstructor]
        private ExtraConfigNqaInfo(
            string? destinationIp,

            int? interval,

            int? probeFailedTimes)
        {
            DestinationIp = destinationIp;
            Interval = interval;
            ProbeFailedTimes = probeFailedTimes;
        }
    }
}