// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb.Inputs
{

    public sealed class InstanceSnatIpArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Snat IP address, If set to empty will auto allocated.
        /// </summary>
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        /// <summary>
        /// Snat subnet ID.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public InstanceSnatIpArgs()
        {
        }
        public static new InstanceSnatIpArgs Empty => new InstanceSnatIpArgs();
    }
}
