// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Nat.Outputs
{

    [OutputType]
    public sealed class GetDcRouteNatDirectConnectGatewayRouteSetResult
    {
        /// <summary>
        /// Create time of route.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// IPv4 CIDR of subnet.
        /// </summary>
        public readonly string DestinationCidrBlock;
        /// <summary>
        /// Id of next-hop gateway.
        /// </summary>
        public readonly string GatewayId;
        /// <summary>
        /// Type of next-hop gateway, valid values: DIRECTCONNECT.
        /// </summary>
        public readonly string GatewayType;
        /// <summary>
        /// Update time of route.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetDcRouteNatDirectConnectGatewayRouteSetResult(
            string createTime,

            string destinationCidrBlock,

            string gatewayId,

            string gatewayType,

            string updateTime)
        {
            CreateTime = createTime;
            DestinationCidrBlock = destinationCidrBlock;
            GatewayId = gatewayId;
            GatewayType = gatewayType;
            UpdateTime = updateTime;
        }
    }
}