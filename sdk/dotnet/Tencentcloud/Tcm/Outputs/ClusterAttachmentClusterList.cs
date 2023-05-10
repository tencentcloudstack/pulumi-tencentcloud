// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class ClusterAttachmentClusterList
    {
        /// <summary>
        /// TKE Cluster id.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// TKE cluster region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Cluster role in mesh, REMOTE or MASTER.
        /// </summary>
        public readonly string Role;
        /// <summary>
        /// Subnet id, only needed if it&amp;#39;s standalone mesh.
        /// </summary>
        public readonly string? SubnetId;
        /// <summary>
        /// Cluster type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Cluster&amp;#39;s VpcId.
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private ClusterAttachmentClusterList(
            string clusterId,

            string region,

            string role,

            string? subnetId,

            string type,

            string vpcId)
        {
            ClusterId = clusterId;
            Region = region;
            Role = role;
            SubnetId = subnetId;
            Type = type;
            VpcId = vpcId;
        }
    }
}