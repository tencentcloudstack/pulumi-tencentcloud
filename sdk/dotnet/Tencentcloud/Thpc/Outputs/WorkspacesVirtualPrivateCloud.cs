// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Thpc.Outputs
{

    [OutputType]
    public sealed class WorkspacesVirtualPrivateCloud
    {
        /// <summary>
        /// Is it used as a public network gateway.
        /// </summary>
        public readonly bool? AsVpcGateway;
        /// <summary>
        /// IPV6 address count.
        /// </summary>
        public readonly int? Ipv6AddressCount;
        /// <summary>
        /// Array of private ip address.
        /// </summary>
        public readonly ImmutableArray<string> PrivateIpAddresses;
        /// <summary>
        /// The ID of a VPC subnet. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// The ID of a VPC network. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private WorkspacesVirtualPrivateCloud(
            bool? asVpcGateway,

            int? ipv6AddressCount,

            ImmutableArray<string> privateIpAddresses,

            string subnetId,

            string vpcId)
        {
            AsVpcGateway = asVpcGateway;
            Ipv6AddressCount = ipv6AddressCount;
            PrivateIpAddresses = privateIpAddresses;
            SubnetId = subnetId;
            VpcId = vpcId;
        }
    }
}
