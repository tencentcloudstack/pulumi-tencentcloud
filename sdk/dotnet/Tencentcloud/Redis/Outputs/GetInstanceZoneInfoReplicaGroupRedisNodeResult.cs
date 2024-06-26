// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis.Outputs
{

    [OutputType]
    public sealed class GetInstanceZoneInfoReplicaGroupRedisNodeResult
    {
        /// <summary>
        /// The number of node keys.
        /// </summary>
        public readonly int Keys;
        /// <summary>
        /// Node ID.
        /// </summary>
        public readonly string NodeId;
        /// <summary>
        /// The node group type, master is the primary node, and replica is the replica node.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// Node slot distribution.
        /// </summary>
        public readonly string Slot;
        /// <summary>
        /// Node status.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetInstanceZoneInfoReplicaGroupRedisNodeResult(
            int keys,

            string nodeId,

            string role,

            string slot,

            string status)
        {
            Keys = keys;
            NodeId = nodeId;
            Role = role;
            Slot = slot;
            Status = status;
        }
    }
}
