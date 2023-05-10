// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetFirewallRulesTemplateFirewallRuleSetResult
    {
        /// <summary>
        /// Valid values are (ACCEPT, DROP). Default value is ACCEPT.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// Application type. Valid values are custom, HTTP (80), HTTPS (443), Linux login (22), Windows login (3389), MySQL (3306), SQL Server (1433), all TCP ports, all UDP ports, Ping-ICMP, ALL.
        /// </summary>
        public readonly string AppType;
        /// <summary>
        /// IP range or IP (mutually exclusive). Default value is 0.0.0.0/0, which indicates all sources.
        /// </summary>
        public readonly string CidrBlock;
        /// <summary>
        /// Firewall rule description.
        /// </summary>
        public readonly string FirewallRuleDescription;
        /// <summary>
        /// Port. Valid values are ALL, one single port, multiple ports separated by commas, or port range indicated by a minus sign.
        /// </summary>
        public readonly string Port;
        /// <summary>
        /// Protocol. Valid values are TCP, UDP, ICMP, ALL.
        /// </summary>
        public readonly string Protocol;

        [OutputConstructor]
        private GetFirewallRulesTemplateFirewallRuleSetResult(
            string action,

            string appType,

            string cidrBlock,

            string firewallRuleDescription,

            string port,

            string protocol)
        {
            Action = action;
            AppType = appType;
            CidrBlock = cidrBlock;
            FirewallRuleDescription = firewallRuleDescription;
            Port = port;
            Protocol = protocol;
        }
    }
}