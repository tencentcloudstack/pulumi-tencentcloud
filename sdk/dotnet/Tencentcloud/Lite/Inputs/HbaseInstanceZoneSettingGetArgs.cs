// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lite.Inputs
{

    public sealed class HbaseInstanceZoneSettingGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of nodes.
        /// </summary>
        [Input("nodeNum", required: true)]
        public Input<int> NodeNum { get; set; } = null!;

        /// <summary>
        /// Private network related information configuration. This parameter can be used to specify the ID of the private network, subnet ID, and other information.
        /// </summary>
        [Input("vpcSettings", required: true)]
        public Input<Inputs.HbaseInstanceZoneSettingVpcSettingsGetArgs> VpcSettings { get; set; } = null!;

        /// <summary>
        /// The availability zone to which the instance belongs, such as ap-guangzhou-1.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public HbaseInstanceZoneSettingGetArgs()
        {
        }
        public static new HbaseInstanceZoneSettingGetArgs Empty => new HbaseInstanceZoneSettingGetArgs();
    }
}
