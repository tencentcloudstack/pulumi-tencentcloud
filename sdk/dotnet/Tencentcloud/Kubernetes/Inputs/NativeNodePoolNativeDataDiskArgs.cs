// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Inputs
{

    public sealed class NativeNodePoolNativeDataDiskArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to automatically format the disk and mount it.
        /// </summary>
        [Input("autoFormatAndMount", required: true)]
        public Input<bool> AutoFormatAndMount { get; set; } = null!;

        /// <summary>
        /// Mount device name or partition name.
        /// </summary>
        [Input("diskPartition")]
        public Input<string>? DiskPartition { get; set; }

        /// <summary>
        /// Cloud disk size (G).
        /// </summary>
        [Input("diskSize", required: true)]
        public Input<int> DiskSize { get; set; } = null!;

        /// <summary>
        /// Cloud disk type. Valid values: `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_SSD`: cloud SSD disk, `CLOUD_BSSD`: Basic SSD, `CLOUD_HSSD`: Enhanced SSD, `CLOUD_TSSD`: Tremendous SSD, `LOCAL_NVME`: local NVME disk.
        /// </summary>
        [Input("diskType", required: true)]
        public Input<string> DiskType { get; set; } = null!;

        /// <summary>
        /// Pass in this parameter to create an encrypted cloud disk. The value is fixed to `ENCRYPT`.
        /// </summary>
        [Input("encrypt")]
        public Input<string>? Encrypt { get; set; }

        /// <summary>
        /// File system (ext3/ext4/xfs).
        /// </summary>
        [Input("fileSystem")]
        public Input<string>? FileSystem { get; set; }

        /// <summary>
        /// Customize the key when purchasing an encrypted disk. When this parameter is passed in, the Encrypt parameter is not empty.
        /// </summary>
        [Input("kmsKeyId")]
        public Input<string>? KmsKeyId { get; set; }

        /// <summary>
        /// Mount directory.
        /// </summary>
        [Input("mountTarget")]
        public Input<string>? MountTarget { get; set; }

        /// <summary>
        /// Snapshot ID. If passed in, the cloud disk will be created based on this snapshot. The snapshot type must be a data disk snapshot.
        /// </summary>
        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        /// <summary>
        /// Cloud disk performance, unit: MB/s. Use this parameter to purchase additional performance for the cloud disk.
        /// </summary>
        [Input("throughputPerformance")]
        public Input<int>? ThroughputPerformance { get; set; }

        public NativeNodePoolNativeDataDiskArgs()
        {
        }
        public static new NativeNodePoolNativeDataDiskArgs Empty => new NativeNodePoolNativeDataDiskArgs();
    }
}
