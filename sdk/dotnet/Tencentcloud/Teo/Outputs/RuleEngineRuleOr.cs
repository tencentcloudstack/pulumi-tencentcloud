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
    public sealed class RuleEngineRuleOr
    {
        /// <summary>
        /// Rule engine condition. This condition will be considered met if all items in the array are met.
        /// </summary>
        public readonly ImmutableArray<Outputs.RuleEngineRuleOrAnd> Ands;

        [OutputConstructor]
        private RuleEngineRuleOr(ImmutableArray<Outputs.RuleEngineRuleOrAnd> ands)
        {
            Ands = ands;
        }
    }
}
