// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dlc.Outputs
{

    [OutputType]
    public sealed class GetDescribeUserInfoFilterResult
    {
        /// <summary>
        /// Attribute name. If there are multiple Filters, the relationship between Filters is a logical OR (OR) relationship.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Attribute value, if there are multiple Values in the same filter, the relationship between values under the same filter is a logical OR relationship.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetDescribeUserInfoFilterResult(
            string name,

            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
}
