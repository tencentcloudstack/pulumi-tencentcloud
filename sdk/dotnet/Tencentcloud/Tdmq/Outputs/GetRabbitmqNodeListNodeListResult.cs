// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tdmq.Outputs
{

    [OutputType]
    public sealed class GetRabbitmqNodeListNodeListResult
    {
        /// <summary>
        /// CPU usageNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string CpuUsage;
        /// <summary>
        /// disk usageNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string DiskUsage;
        /// <summary>
        /// Memory usage, in MBNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int Memory;
        /// <summary>
        /// node nameNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string NodeName;
        /// <summary>
        /// node statusNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string NodeStatus;
        /// <summary>
        /// Number of Erlang processes for RabbitmqNote: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly int ProcessNumber;

        [OutputConstructor]
        private GetRabbitmqNodeListNodeListResult(
            string cpuUsage,

            string diskUsage,

            int memory,

            string nodeName,

            string nodeStatus,

            int processNumber)
        {
            CpuUsage = cpuUsage;
            DiskUsage = diskUsage;
            Memory = memory;
            NodeName = nodeName;
            NodeStatus = nodeStatus;
            ProcessNumber = processNumber;
        }
    }
}
