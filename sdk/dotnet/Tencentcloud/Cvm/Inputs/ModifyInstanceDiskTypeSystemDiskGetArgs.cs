// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm.Inputs
{

    public sealed class ModifyInstanceDiskTypeSystemDiskGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the dedicated cluster to which the instance belongs.
        /// </summary>
        [Input("cdcId")]
        public Input<string>? CdcId { get; set; }

        /// <summary>
        /// System disk ID. System disks whose type is LOCAL_BASIC or LOCAL_SSD do not have an ID and do not support this parameter.
        /// </summary>
        [Input("diskId")]
        public Input<string>? DiskId { get; set; }

        /// <summary>
        /// System disk size; unit: GB; default value: 50 GB.
        /// </summary>
        [Input("diskSize")]
        public Input<int>? DiskSize { get; set; }

        /// <summary>
        /// System disk type. Valid values:- LOCAL_BASIC: local disk
        /// - LOCAL_SSD: local SSD disk
        /// - CLOUD_BASIC: ordinary cloud disk
        /// - CLOUD_SSD: SSD cloud disk
        /// - CLOUD_PREMIUM: Premium cloud storage
        /// - CLOUD_BSSD: Balanced SSD
        /// The disk currently in stock will be used by default.
        /// </summary>
        [Input("diskType")]
        public Input<string>? DiskType { get; set; }

        public ModifyInstanceDiskTypeSystemDiskGetArgs()
        {
        }
        public static new ModifyInstanceDiskTypeSystemDiskGetArgs Empty => new ModifyInstanceDiskTypeSystemDiskGetArgs();
    }
}
