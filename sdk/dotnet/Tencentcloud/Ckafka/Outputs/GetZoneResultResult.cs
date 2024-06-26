// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class GetZoneResultResult
    {
        /// <summary>
        /// User exclusive cluster information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneResultClusterInfoResult> ClusterInfos;
        /// <summary>
        /// Maximum purchased bandwidth in Mbs.
        /// </summary>
        public readonly int MaxBandwidth;
        /// <summary>
        /// The maximum number of purchased instances.
        /// </summary>
        public readonly int MaxBuyInstanceNum;
        /// <summary>
        /// Postpaid message unit price.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneResultMessagePriceResult> MessagePrices;
        /// <summary>
        /// Physical Exclusive Edition Configuration.
        /// </summary>
        public readonly string Physical;
        /// <summary>
        /// Professional Edition configuration.
        /// </summary>
        public readonly string Profession;
        /// <summary>
        /// Public network bandwidth.
        /// </summary>
        public readonly string PublicNetwork;
        /// <summary>
        /// Public network bandwidth configuration.
        /// </summary>
        public readonly string PublicNetworkLimit;
        /// <summary>
        /// Purchase Standard Edition Configuration.
        /// </summary>
        public readonly string Standard;
        /// <summary>
        /// Standard Edition S2 configuration.
        /// </summary>
        public readonly string StandardS2;
        /// <summary>
        /// Postpaid unit price.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneResultUnitPriceResult> UnitPrices;
        /// <summary>
        /// zone list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZoneResultZoneListResult> ZoneLists;

        [OutputConstructor]
        private GetZoneResultResult(
            ImmutableArray<Outputs.GetZoneResultClusterInfoResult> clusterInfos,

            int maxBandwidth,

            int maxBuyInstanceNum,

            ImmutableArray<Outputs.GetZoneResultMessagePriceResult> messagePrices,

            string physical,

            string profession,

            string publicNetwork,

            string publicNetworkLimit,

            string standard,

            string standardS2,

            ImmutableArray<Outputs.GetZoneResultUnitPriceResult> unitPrices,

            ImmutableArray<Outputs.GetZoneResultZoneListResult> zoneLists)
        {
            ClusterInfos = clusterInfos;
            MaxBandwidth = maxBandwidth;
            MaxBuyInstanceNum = maxBuyInstanceNum;
            MessagePrices = messagePrices;
            Physical = physical;
            Profession = profession;
            PublicNetwork = publicNetwork;
            PublicNetworkLimit = publicNetworkLimit;
            Standard = standard;
            StandardS2 = standardS2;
            UnitPrices = unitPrices;
            ZoneLists = zoneLists;
        }
    }
}
