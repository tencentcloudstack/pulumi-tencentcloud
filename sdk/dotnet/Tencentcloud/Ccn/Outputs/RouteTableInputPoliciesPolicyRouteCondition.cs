// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ccn.Outputs
{

    [OutputType]
    public sealed class RouteTableInputPoliciesPolicyRouteCondition
    {
        /// <summary>
        /// Matching mode, `1` precise matching, `0` fuzzy matching.
        /// </summary>
        public readonly int MatchPattern;
        /// <summary>
        /// condition type.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of conditional values.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private RouteTableInputPoliciesPolicyRouteCondition(
            int matchPattern,

            string name,

            ImmutableArray<string> values)
        {
            MatchPattern = matchPattern;
            Name = name;
            Values = values;
        }
    }
}
