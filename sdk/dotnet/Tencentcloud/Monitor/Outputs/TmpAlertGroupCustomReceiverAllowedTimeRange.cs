// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class TmpAlertGroupCustomReceiverAllowedTimeRange
    {
        /// <summary>
        /// Time range end, seconds since 0 o'clock.
        /// </summary>
        public readonly string? End;
        /// <summary>
        /// Time range start, seconds since 0 o'clock.
        /// </summary>
        public readonly string? Start;

        [OutputConstructor]
        private TmpAlertGroupCustomReceiverAllowedTimeRange(
            string? end,

            string? start)
        {
            End = end;
            Start = start;
        }
    }
}