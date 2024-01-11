// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos.Outputs
{

    [OutputType]
    public sealed class PortAclConfigAclConfig
    {
        /// <summary>
        /// Action, can take values: drop, transmit, forward.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// end from port, with a range of 0~65535 values.
        /// </summary>
        public readonly int DPortEnd;
        /// <summary>
        /// Starting from port, with a range of 0~65535 values.
        /// </summary>
        public readonly int DPortStart;
        /// <summary>
        /// Protocol type, can take TCP, udp, all values.
        /// </summary>
        public readonly string ForwardProtocol;
        /// <summary>
        /// The policy priority, the smaller the number, the higher the level, and the higher the matching of the rule, with values ranging from 1 to 1000. Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly int? Priority;
        /// <summary>
        /// end from the source port, with a value range of 0~65535.
        /// </summary>
        public readonly int SPortEnd;
        /// <summary>
        /// Starting from the source port, with a value range of 0~65535.
        /// </summary>
        public readonly int SPortStart;

        [OutputConstructor]
        private PortAclConfigAclConfig(
            string action,

            int dPortEnd,

            int dPortStart,

            string forwardProtocol,

            int? priority,

            int sPortEnd,

            int sPortStart)
        {
            Action = action;
            DPortEnd = dPortEnd;
            DPortStart = dPortStart;
            ForwardProtocol = forwardProtocol;
            Priority = priority;
            SPortEnd = sPortEnd;
            SPortStart = sPortStart;
        }
    }
}