// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eni.Outputs
{

    [OutputType]
    public sealed class Ipv4AddressPrivateIpAddress
    {
        /// <summary>
        /// EIP instance ID, such as `eip-11112222`.
        /// </summary>
        public readonly string? AddressId;
        /// <summary>
        /// Private IP description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Whether the public IP is blocked.
        /// </summary>
        public readonly bool? IsWanIpBlocked;
        /// <summary>
        /// Whether it is a primary IP.
        /// </summary>
        public readonly bool? Primary;
        /// <summary>
        /// Private IP address.
        /// </summary>
        public readonly string PrivateIpAddress;
        /// <summary>
        /// Public IP address.
        /// </summary>
        public readonly string? PublicIpAddress;
        /// <summary>
        /// IP service level. Values: PT` (Gold), `AU` (Silver), `AG `(Bronze) and DEFAULT` (Default).
        /// </summary>
        public readonly string? QosLevel;
        /// <summary>
        /// IP status: `PENDING`: Creating, `MIGRATING`: Migrating, `DELETING`: Deleting, `AVAILABLE`: Available.
        /// </summary>
        public readonly string? State;

        [OutputConstructor]
        private Ipv4AddressPrivateIpAddress(
            string? addressId,

            string? description,

            bool? isWanIpBlocked,

            bool? primary,

            string privateIpAddress,

            string? publicIpAddress,

            string? qosLevel,

            string? state)
        {
            AddressId = addressId;
            Description = description;
            IsWanIpBlocked = isWanIpBlocked;
            Primary = primary;
            PrivateIpAddress = privateIpAddress;
            PublicIpAddress = publicIpAddress;
            QosLevel = qosLevel;
            State = state;
        }
    }
}