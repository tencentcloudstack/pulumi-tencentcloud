// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Emr.Inputs
{

    public sealed class ClusterResourceSpecGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of common node.
        /// </summary>
        [Input("commonCount")]
        public Input<int>? CommonCount { get; set; }

        /// <summary>
        /// Resource details.
        /// </summary>
        [Input("commonResourceSpec")]
        public Input<Inputs.ClusterResourceSpecCommonResourceSpecGetArgs>? CommonResourceSpec { get; set; }

        /// <summary>
        /// The number of core node.
        /// </summary>
        [Input("coreCount")]
        public Input<int>? CoreCount { get; set; }

        /// <summary>
        /// Resource details.
        /// </summary>
        [Input("coreResourceSpec")]
        public Input<Inputs.ClusterResourceSpecCoreResourceSpecGetArgs>? CoreResourceSpec { get; set; }

        /// <summary>
        /// The number of master node.
        /// </summary>
        [Input("masterCount")]
        public Input<int>? MasterCount { get; set; }

        /// <summary>
        /// Resource details.
        /// </summary>
        [Input("masterResourceSpec")]
        public Input<Inputs.ClusterResourceSpecMasterResourceSpecGetArgs>? MasterResourceSpec { get; set; }

        /// <summary>
        /// The number of core node.
        /// </summary>
        [Input("taskCount")]
        public Input<int>? TaskCount { get; set; }

        /// <summary>
        /// Resource details.
        /// </summary>
        [Input("taskResourceSpec")]
        public Input<Inputs.ClusterResourceSpecTaskResourceSpecGetArgs>? TaskResourceSpec { get; set; }

        public ClusterResourceSpecGetArgs()
        {
        }
        public static new ClusterResourceSpecGetArgs Empty => new ClusterResourceSpecGetArgs();
    }
}
