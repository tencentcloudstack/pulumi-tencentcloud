// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Inputs
{

    public sealed class WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageCosOutputStorageArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The target Bucket name of the file output generated by media processing, if not filled, it means the upper layer.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// The park of the target Bucket for the output of the file generated by media processing. If not filled, it means inheriting from the upper layer.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        public WorkflowMediaProcessTaskSnapshotByTimeOffsetTaskSetOutputStorageCosOutputStorageArgs()
        {
        }
    }
}