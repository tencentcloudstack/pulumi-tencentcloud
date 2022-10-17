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
    public sealed class GetDdosPoliciesListPortFilterResult
    {
        /// <summary>
        /// Action of port to take.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// End port.
        /// </summary>
        public readonly int EndPort;
        /// <summary>
        /// The type of forbidden port, and valid values are 0, 1, 2. 0 for destination port, 1 for source port and 2 for both destination and source posts.
        /// </summary>
        public readonly int Kind;
        /// <summary>
        /// Protocol.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Start port.
        /// </summary>
        public readonly int StartPort;

        [OutputConstructor]
        private GetDdosPoliciesListPortFilterResult(
            string action,

            int endPort,

            int kind,

            string protocol,

            int startPort)
        {
            Action = action;
            EndPort = endPort;
            Kind = kind;
            Protocol = protocol;
            StartPort = startPort;
        }
    }
}