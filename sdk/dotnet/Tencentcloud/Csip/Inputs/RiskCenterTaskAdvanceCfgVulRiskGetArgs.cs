// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Csip.Inputs
{

    public sealed class RiskCenterTaskAdvanceCfgVulRiskGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to enable, 0- No, 1- Enable.
        /// </summary>
        [Input("enable", required: true)]
        public Input<int> Enable { get; set; } = null!;

        /// <summary>
        /// Risk ID.
        /// </summary>
        [Input("riskId", required: true)]
        public Input<string> RiskId { get; set; } = null!;

        public RiskCenterTaskAdvanceCfgVulRiskGetArgs()
        {
        }
        public static new RiskCenterTaskAdvanceCfgVulRiskGetArgs Empty => new RiskCenterTaskAdvanceCfgVulRiskGetArgs();
    }
}
