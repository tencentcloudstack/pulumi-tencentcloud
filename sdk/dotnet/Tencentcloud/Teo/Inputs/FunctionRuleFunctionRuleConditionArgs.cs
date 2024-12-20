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

    public sealed class FunctionRuleFunctionRuleConditionArgs : global::Pulumi.ResourceArgs
    {
        [Input("ruleConditions", required: true)]
        private InputList<Inputs.FunctionRuleFunctionRuleConditionRuleConditionArgs>? _ruleConditions;

        /// <summary>
        /// For edge function trigger rule conditions, if all items in the list are satisfied, then the condition is considered fulfilled.
        /// </summary>
        public InputList<Inputs.FunctionRuleFunctionRuleConditionRuleConditionArgs> RuleConditions
        {
            get => _ruleConditions ?? (_ruleConditions = new InputList<Inputs.FunctionRuleFunctionRuleConditionRuleConditionArgs>());
            set => _ruleConditions = value;
        }

        public FunctionRuleFunctionRuleConditionArgs()
        {
        }
        public static new FunctionRuleFunctionRuleConditionArgs Empty => new FunctionRuleFunctionRuleConditionArgs();
    }
}
