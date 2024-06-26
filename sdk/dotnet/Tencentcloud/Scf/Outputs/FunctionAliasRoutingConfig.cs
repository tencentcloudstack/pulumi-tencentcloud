// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf.Outputs
{

    [OutputType]
    public sealed class FunctionAliasRoutingConfig
    {
        /// <summary>
        /// Additional version with rule-based routing.
        /// </summary>
        public readonly ImmutableArray<Outputs.FunctionAliasRoutingConfigAdditionalVersionMatch> AdditionalVersionMatches;
        /// <summary>
        /// Additional version with random weight-based routing.
        /// </summary>
        public readonly ImmutableArray<Outputs.FunctionAliasRoutingConfigAdditionalVersionWeight> AdditionalVersionWeights;

        [OutputConstructor]
        private FunctionAliasRoutingConfig(
            ImmutableArray<Outputs.FunctionAliasRoutingConfigAdditionalVersionMatch> additionalVersionMatches,

            ImmutableArray<Outputs.FunctionAliasRoutingConfigAdditionalVersionWeight> additionalVersionWeights)
        {
            AdditionalVersionMatches = additionalVersionMatches;
            AdditionalVersionWeights = additionalVersionWeights;
        }
    }
}
