// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mariadb.Outputs
{

    [OutputType]
    public sealed class GetSecurityGroupsListInboundResult
    {
        /// <summary>
        /// Policy, ACCEPT or DROP.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// Source IP or IP range, such as 192.168.0.0/16.
        /// </summary>
        public readonly string CidrIp;
        /// <summary>
        /// Network protocols, support `UDP`, `TCP`, etc.
        /// </summary>
        public readonly string IpProtocol;
        /// <summary>
        /// port.
        /// </summary>
        public readonly string PortRange;

        [OutputConstructor]
        private GetSecurityGroupsListInboundResult(
            string action,

            string cidrIp,

            string ipProtocol,

            string portRange)
        {
            Action = action;
            CidrIp = cidrIp;
            IpProtocol = ipProtocol;
            PortRange = portRange;
        }
    }
}
