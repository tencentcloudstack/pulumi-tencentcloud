// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lite.Outputs
{

    [OutputType]
    public sealed class HbaseInstanceZoneSetting
    {
        /// <summary>
        /// Number of nodes.
        /// </summary>
        public readonly int NodeNum;
        /// <summary>
        /// Private network related information configuration. This parameter can be used to specify the ID of the private network, subnet ID, and other information.
        /// </summary>
        public readonly Outputs.HbaseInstanceZoneSettingVpcSettings VpcSettings;
        /// <summary>
        /// The availability zone to which the instance belongs, such as ap-guangzhou-1.
        /// </summary>
        public readonly string Zone;

        [OutputConstructor]
        private HbaseInstanceZoneSetting(
            int nodeNum,

            Outputs.HbaseInstanceZoneSettingVpcSettings vpcSettings,

            string zone)
        {
            NodeNum = nodeNum;
            VpcSettings = vpcSettings;
            Zone = zone;
        }
    }
}