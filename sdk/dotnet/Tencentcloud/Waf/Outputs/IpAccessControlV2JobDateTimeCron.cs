// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf.Outputs
{

    [OutputType]
    public sealed class IpAccessControlV2JobDateTimeCron
    {
        /// <summary>
        /// Days in each month for execution
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> Days;
        /// <summary>
        /// End time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? EndTime;
        /// <summary>
        /// Start time
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? StartTime;
        /// <summary>
        /// Days of each week for execution
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<int> WDays;

        [OutputConstructor]
        private IpAccessControlV2JobDateTimeCron(
            ImmutableArray<int> days,

            string? endTime,

            string? startTime,

            ImmutableArray<int> wDays)
        {
            Days = days;
            EndTime = endTime;
            StartTime = startTime;
            WDays = wDays;
        }
    }
}