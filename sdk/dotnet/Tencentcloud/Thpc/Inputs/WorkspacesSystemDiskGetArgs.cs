// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Thpc.Inputs
{

    public sealed class WorkspacesSystemDiskGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Data disk ID used to initialize the data disk. When data disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk id is not supported.
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        /// <summary>
        /// Size of the system disk. unit is GB, Default is 50GB.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// System disk type. For more information on limits of system disk types, see [Storage Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk, `LOCAL_SSD`: local SSD disk, `CLOUD_BASIC`: cloud disk, `CLOUD_SSD`: cloud SSD disk, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_BSSD`: Basic SSD, `CLOUD_HSSD`: Enhanced SSD, `CLOUD_TSSD`: Tremendous SSD. NOTE: If modified, the instance may force stop.
        /// </summary>
        [Input("diskType")]
        public Input<string>? DiskType { get; set; }

        public WorkspacesSystemDiskGetArgs()
        {
        }
        public static new WorkspacesSystemDiskGetArgs Empty => new WorkspacesSystemDiskGetArgs();
    }
}