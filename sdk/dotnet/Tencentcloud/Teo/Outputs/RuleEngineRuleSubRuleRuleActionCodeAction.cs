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
    public sealed class RuleEngineRuleSubRuleRuleActionCodeAction
    {
        /// <summary>
        /// Action name.
        /// </summary>
        public readonly string Action;
        /// <summary>
        /// Action parameters.
        /// </summary>
        public readonly ImmutableArray<Outputs.RuleEngineRuleSubRuleRuleActionCodeActionParameter> Parameters;

        [OutputConstructor]
        private RuleEngineRuleSubRuleRuleActionCodeAction(
            string action,

            ImmutableArray<Outputs.RuleEngineRuleSubRuleRuleActionCodeActionParameter> parameters)
        {
            Action = action;
            Parameters = parameters;
        }
    }
}