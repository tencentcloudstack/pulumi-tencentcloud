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
    public sealed class InputInputGroupRtpSettings
    {
        /// <summary>
        /// Defaults to &amp;#39;none&amp;#39;, optional values[&amp;#39;none&amp;#39;].
        /// </summary>
        public readonly string? Fec;
        /// <summary>
        /// Idle timeout, the default is 5000, the unit is ms, and the range is [1000, 10000].
        /// </summary>
        public readonly int? IdleTimeout;

        [OutputConstructor]
        private InputInputGroupRtpSettings(
            string? fec,

            int? idleTimeout)
        {
            Fec = fec;
            IdleTimeout = idleTimeout;
        }
    }
}