// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Outputs
{

    [OutputType]
    public sealed class DqRuleFieldConfig
    {
        /// <summary>
        /// Library table variableNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.DqRuleFieldConfigTableConfig> TableConfigs;
        /// <summary>
        /// Where variableNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.DqRuleFieldConfigWhereConfig> WhereConfigs;

        [OutputConstructor]
        private DqRuleFieldConfig(
            ImmutableArray<Outputs.DqRuleFieldConfigTableConfig> tableConfigs,

            ImmutableArray<Outputs.DqRuleFieldConfigWhereConfig> whereConfigs)
        {
            TableConfigs = tableConfigs;
            WhereConfigs = whereConfigs;
        }
    }
}