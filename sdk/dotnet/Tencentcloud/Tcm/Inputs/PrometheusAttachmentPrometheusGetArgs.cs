// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm.Inputs
{

    public sealed class PrometheusAttachmentPrometheusGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Third party prometheus.
        /// </summary>
        [Input("customProm")]
        public Input<Inputs.PrometheusAttachmentPrometheusCustomPromGetArgs>? CustomProm { get; set; }

        /// <summary>
        /// Existed TMP id, auto create TMP if empty.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Region for TMP.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// Subnet id for TMP.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// Vpc id for TMP.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public PrometheusAttachmentPrometheusGetArgs()
        {
        }
    }
}