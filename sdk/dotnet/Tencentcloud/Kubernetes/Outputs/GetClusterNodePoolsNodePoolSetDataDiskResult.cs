// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class GetClusterNodePoolsNodePoolSetDataDiskResult
    {
        /// <summary>
        /// Whether to automate the format disk and mount it.
        /// </summary>
        public readonly bool AutoFormatAndMount;
        /// <summary>
        /// Mount device name or partition name.
        /// </summary>
        public readonly string DiskPartition;
        /// <summary>
        /// Cloud disk size(G).
        /// </summary>
        public readonly int DiskSize;
        /// <summary>
        /// Cloud disk type.
        /// </summary>
        public readonly string DiskType;
        /// <summary>
        /// File system(ext3/ext4/xfs).
        /// </summary>
        public readonly string FileSystem;
        /// <summary>
        /// Mount directory.
        /// </summary>
        public readonly string MountTarget;

        [OutputConstructor]
        private GetClusterNodePoolsNodePoolSetDataDiskResult(
            bool autoFormatAndMount,

            string diskPartition,

            int diskSize,

            string diskType,

            string fileSystem,

            string mountTarget)
        {
            AutoFormatAndMount = autoFormatAndMount;
            DiskPartition = diskPartition;
            DiskSize = diskSize;
            DiskType = diskType;
            FileSystem = fileSystem;
            MountTarget = mountTarget;
        }
    }
}
