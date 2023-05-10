// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class SecurityPolicyConfigBotConfigIntelligenceRule
    {
        /// <summary>
        /// Configuration detail.
        /// </summary>
        public readonly ImmutableArray<Outputs.SecurityPolicyConfigBotConfigIntelligenceRuleItem> Items;
        /// <summary>
        /// - `on`: Enable.- `off`: Disable.
        /// </summary>
        public readonly string? Switch;

        [OutputConstructor]
        private SecurityPolicyConfigBotConfigIntelligenceRule(
            ImmutableArray<Outputs.SecurityPolicyConfigBotConfigIntelligenceRuleItem> items,

            string? @switch)
        {
            Items = items;
            Switch = @switch;
        }
    }
}