// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdwdoris.Outputs
{

    [OutputType]
    public sealed class WorkloadGroupWorkloadGroup
    {
        /// <summary>
        /// Cpu hard limit. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? CpuHardLimit;
        /// <summary>
        /// CPU weight. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int? CpuShare;
        /// <summary>
        /// Whether to allow over-allocation. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly bool? EnableMemoryOverCommit;
        /// <summary>
        /// Memory limit, the sum of the memory limit values of all resource groups should be less than or equal to 100. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int? MemoryLimit;
        /// <summary>
        /// Workload group name. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? WorkloadGroupName;

        [OutputConstructor]
        private WorkloadGroupWorkloadGroup(
            string? cpuHardLimit,

            int? cpuShare,

            bool? enableMemoryOverCommit,

            int? memoryLimit,

            string? workloadGroupName)
        {
            CpuHardLimit = cpuHardLimit;
            CpuShare = cpuShare;
            EnableMemoryOverCommit = enableMemoryOverCommit;
            MemoryLimit = memoryLimit;
            WorkloadGroupName = workloadGroupName;
        }
    }
}
