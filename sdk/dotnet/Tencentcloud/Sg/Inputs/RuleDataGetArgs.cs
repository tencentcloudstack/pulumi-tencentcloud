// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sg.Inputs
{

    public sealed class RuleDataGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Destination example: `net`: IP/CIDR (192.168.0.2); `template`: parameter template (ipm-dyodhpby); `instance`: asset instance (ins-123456); `resourcegroup`: asset group (/all groups/group 1/subgroup 1); `tag`: resource tag ({"Key":"tag key","Value":"tag value"}); `region`: region (ap-gaungzhou).
        /// </summary>
        [Input("destContent", required: true)]
        public Input<string> DestContent { get; set; } = null!;

        /// <summary>
        /// Access destination type. Valid values: net|template|instance|resourcegroup|tag|region.
        /// </summary>
        [Input("destType", required: true)]
        public Input<string> DestType { get; set; } = null!;

        /// <summary>
        /// Rule priority.
        /// </summary>
        [Input("orderIndex")]
        public Input<string>? OrderIndex { get; set; }

        /// <summary>
        /// The port to apply access control rules. Valid values: `-1/-1`: all ports, `80`: port 80.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        /// <summary>
        /// Protocol. TCP/UDP/ICMP/ANY.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The action that Cloud Firewall performs on the traffic. Valid values: `accept`: allow, `drop`: deny.
        /// </summary>
        [Input("ruleAction", required: true)]
        public Input<string> RuleAction { get; set; } = null!;

        /// <summary>
        /// Parameter template ID of port and protocol type; mutually exclusive with Protocol and Port.
        /// </summary>
        [Input("serviceTemplateId")]
        public Input<string>? ServiceTemplateId { get; set; }

        /// <summary>
        /// Source example: `net`: IP/CIDR (192.168.0.2); `template`: parameter template (ipm-dyodhpby); `instance`: asset instance (ins-123456); `resourcegroup`: asset group (/all groups/group 1/subgroup 1); `tag`: resource tag ({"Key":"tag key","Value":"tag value"}); `region`: region (ap-gaungzhou).
        /// </summary>
        [Input("sourceContent", required: true)]
        public Input<string> SourceContent { get; set; } = null!;

        /// <summary>
        /// Access source type. Valid values: net|template|instance|resourcegroup|tag|region.
        /// </summary>
        [Input("sourceType", required: true)]
        public Input<string> SourceType { get; set; } = null!;

        public RuleDataGetArgs()
        {
        }
        public static new RuleDataGetArgs Empty => new RuleDataGetArgs();
    }
}
