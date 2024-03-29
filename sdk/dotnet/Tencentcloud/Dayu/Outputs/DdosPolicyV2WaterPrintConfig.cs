// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dayu.Outputs
{

    [OutputType]
    public sealed class DdosPolicyV2WaterPrintConfig
    {
        /// <summary>
        /// List of forwarding listeners to which the watermark belongs.
        /// </summary>
        public readonly ImmutableArray<Outputs.DdosPolicyV2WaterPrintConfigListener> Listeners;
        /// <summary>
        /// Watermark offset, value range: [0-100].
        /// </summary>
        public readonly int Offset;
        /// <summary>
        /// Whether it is enabled, value [0 (manual open), 1 (immediate operation)].
        /// </summary>
        public readonly int OpenStatus;
        /// <summary>
        /// Watermark check mode, value [`checkall`(normal mode), `shortfpcheckall`(simplified mode)].
        /// </summary>
        public readonly string Verify;

        [OutputConstructor]
        private DdosPolicyV2WaterPrintConfig(
            ImmutableArray<Outputs.DdosPolicyV2WaterPrintConfigListener> listeners,

            int offset,

            int openStatus,

            string verify)
        {
            Listeners = listeners;
            Offset = offset;
            OpenStatus = openStatus;
            Verify = verify;
        }
    }
}
