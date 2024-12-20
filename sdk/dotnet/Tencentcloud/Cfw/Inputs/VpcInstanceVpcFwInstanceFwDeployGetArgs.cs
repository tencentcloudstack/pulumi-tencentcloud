// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfw.Inputs
{

    public sealed class VpcInstanceVpcFwInstanceFwDeployGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Off-site disaster recovery 1: use off-site disaster recovery; 0: do not use off-site disaster recovery; if it is empty, off-site disaster recovery will not be used by default.
        /// </summary>
        [Input("crossAZone")]
        public Input<int>? CrossAZone { get; set; }

        /// <summary>
        /// Firewall Deployment Region.
        /// </summary>
        [Input("deployRegion", required: true)]
        public Input<string> DeployRegion { get; set; } = null!;

        /// <summary>
        /// Bandwidth, unit: Mbps.
        /// </summary>
        [Input("width", required: true)]
        public Input<int> Width { get; set; } = null!;

        [Input("zoneSets", required: true)]
        private InputList<string>? _zoneSets;

        /// <summary>
        /// Zone list.
        /// </summary>
        public InputList<string> ZoneSets
        {
            get => _zoneSets ?? (_zoneSets = new InputList<string>());
            set => _zoneSets = value;
        }

        public VpcInstanceVpcFwInstanceFwDeployGetArgs()
        {
        }
        public static new VpcInstanceVpcFwInstanceFwDeployGetArgs Empty => new VpcInstanceVpcFwInstanceFwDeployGetArgs();
    }
}
