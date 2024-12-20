// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class RuleEngineRuleSubRuleRuleActionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Feature operation with a status code. Features of this type include:
        /// </summary>
        [Input("codeAction")]
        public Input<Inputs.RuleEngineRuleSubRuleRuleActionCodeActionGetArgs>? CodeAction { get; set; }

        /// <summary>
        /// Common operation. Values:
        /// </summary>
        [Input("normalAction")]
        public Input<Inputs.RuleEngineRuleSubRuleRuleActionNormalActionGetArgs>? NormalAction { get; set; }

        /// <summary>
        /// Feature operation with a request/response header. Features of this type include:
        /// </summary>
        [Input("rewriteAction")]
        public Input<Inputs.RuleEngineRuleSubRuleRuleActionRewriteActionGetArgs>? RewriteAction { get; set; }

        public RuleEngineRuleSubRuleRuleActionGetArgs()
        {
        }
        public static new RuleEngineRuleSubRuleRuleActionGetArgs Empty => new RuleEngineRuleSubRuleRuleActionGetArgs();
    }
}
