// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Csip.Outputs
{

    [OutputType]
    public sealed class RiskCenterTaskAdvanceCfg
    {
        /// <summary>
        /// Configure advanced risk Settings.
        /// </summary>
        public readonly ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgCfgRisk> CfgRisks;
        /// <summary>
        /// Advanced Port Risk Configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgPortRisk> PortRisks;
        /// <summary>
        /// Advanced vulnerability risk configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgVulRisk> VulRisks;
        /// <summary>
        /// Weak password risk advanced configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgWeakPwdRisk> WeakPwdRisks;

        [OutputConstructor]
        private RiskCenterTaskAdvanceCfg(
            ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgCfgRisk> cfgRisks,

            ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgPortRisk> portRisks,

            ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgVulRisk> vulRisks,

            ImmutableArray<Outputs.RiskCenterTaskAdvanceCfgWeakPwdRisk> weakPwdRisks)
        {
            CfgRisks = cfgRisks;
            PortRisks = portRisks;
            VulRisks = vulRisks;
            WeakPwdRisks = weakPwdRisks;
        }
    }
}
