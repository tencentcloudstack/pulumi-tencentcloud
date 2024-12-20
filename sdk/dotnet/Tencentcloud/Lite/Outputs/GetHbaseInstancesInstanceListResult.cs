// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lite.Outputs
{

    [OutputType]
    public sealed class GetHbaseInstancesInstanceListResult
    {
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly string AddTime;
        /// <summary>
        /// User APP ID.
        /// </summary>
        public readonly int AppId;
        /// <summary>
        /// Cluster Instance String ID.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// Cluster Instance name.
        /// </summary>
        public readonly string ClusterName;
        /// <summary>
        /// Cluster Instance Digital ID.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Cluster charging type. 0 means charging by volume, 1 means annual and monthly.
        /// </summary>
        public readonly int PayMode;
        /// <summary>
        /// Region ID.
        /// </summary>
        public readonly int RegionId;
        /// <summary>
        /// Status code, please refer to the StatusDesc.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// State description.
        /// </summary>
        public readonly string StatusDesc;
        /// <summary>
        /// Subnet ID.
        /// </summary>
        public readonly int SubnetId;
        /// <summary>
        /// List of tags.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHbaseInstancesInstanceListTagResult> Tags;
        /// <summary>
        /// VPC ID.
        /// </summary>
        public readonly int VpcId;
        /// <summary>
        /// Primary Availability Zone Name.
        /// </summary>
        public readonly string Zone;
        /// <summary>
        /// Primary Availability Zone ID.
        /// </summary>
        public readonly int ZoneId;
        /// <summary>
        /// Detailed configuration of the instance availability zone, including the availability zone name, VPC information, and the total number of nodes, where the total number of nodes must be greater than or equal to 3 and less than or equal to 50.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetHbaseInstancesInstanceListZoneSettingResult> ZoneSettings;

        [OutputConstructor]
        private GetHbaseInstancesInstanceListResult(
            string addTime,

            int appId,

            string clusterId,

            string clusterName,

            int id,

            int payMode,

            int regionId,

            int status,

            string statusDesc,

            int subnetId,

            ImmutableArray<Outputs.GetHbaseInstancesInstanceListTagResult> tags,

            int vpcId,

            string zone,

            int zoneId,

            ImmutableArray<Outputs.GetHbaseInstancesInstanceListZoneSettingResult> zoneSettings)
        {
            AddTime = addTime;
            AppId = appId;
            ClusterId = clusterId;
            ClusterName = clusterName;
            Id = id;
            PayMode = payMode;
            RegionId = regionId;
            Status = status;
            StatusDesc = statusDesc;
            SubnetId = subnetId;
            Tags = tags;
            VpcId = vpcId;
            Zone = zone;
            ZoneId = zoneId;
            ZoneSettings = zoneSettings;
        }
    }
}
