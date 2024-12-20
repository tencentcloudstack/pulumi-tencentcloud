// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Trocket.Inputs
{

    public sealed class RocketmqInstanceIpRuleGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to allow release or not.
        /// </summary>
        [Input("allow", required: true)]
        public Input<bool> Allow { get; set; } = null!;

        /// <summary>
        /// IP.
        /// </summary>
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        /// <summary>
        /// Remark.
        /// </summary>
        [Input("remark", required: true)]
        public Input<string> Remark { get; set; } = null!;

        public RocketmqInstanceIpRuleGetArgs()
        {
        }
        public static new RocketmqInstanceIpRuleGetArgs Empty => new RocketmqInstanceIpRuleGetArgs();
    }
}
