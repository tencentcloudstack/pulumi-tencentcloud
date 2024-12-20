// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class GetDedicatedClustersDedicatedClusterSetResult
    {
        /// <summary>
        /// Number of available CPUs.
        /// </summary>
        public readonly int? CpuAvailable;
        /// <summary>
        /// Cpu total.
        /// </summary>
        public readonly int? CpuTotal;
        /// <summary>
        /// Dedicated cluster ID.
        /// </summary>
        public readonly string? DedicatedClusterId;
        /// <summary>
        /// Disk availability.
        /// </summary>
        public readonly int? DiskAvailable;
        /// <summary>
        /// Total number of disks.
        /// </summary>
        public readonly int? DiskTotal;
        /// <summary>
        /// Instance count.
        /// </summary>
        public readonly int? InstanceCount;
        /// <summary>
        /// Available Memory.
        /// </summary>
        public readonly int? MemAvailable;
        /// <summary>
        /// Total amount of memory.
        /// </summary>
        public readonly int? MemTotal;
        /// <summary>
        /// Filter name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Disaster recovery cluster.
        /// </summary>
        public readonly ImmutableArray<string> StandbyDedicatedClusterSets;
        /// <summary>
        /// Zone.
        /// </summary>
        public readonly string? Zone;

        [OutputConstructor]
        private GetDedicatedClustersDedicatedClusterSetResult(
            int? cpuAvailable,

            int? cpuTotal,

            string? dedicatedClusterId,

            int? diskAvailable,

            int? diskTotal,

            int? instanceCount,

            int? memAvailable,

            int? memTotal,

            string? name,

            ImmutableArray<string> standbyDedicatedClusterSets,

            string? zone)
        {
            CpuAvailable = cpuAvailable;
            CpuTotal = cpuTotal;
            DedicatedClusterId = dedicatedClusterId;
            DiskAvailable = diskAvailable;
            DiskTotal = diskTotal;
            InstanceCount = instanceCount;
            MemAvailable = memAvailable;
            MemTotal = memTotal;
            Name = name;
            StandbyDedicatedClusterSets = standbyDedicatedClusterSets;
            Zone = zone;
        }
    }
}
