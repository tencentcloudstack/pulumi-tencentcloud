// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetClassicLinkInstancesFilterResult
    {
        /// <summary>
        /// The attribute name. If more than one Filter exists, the logical relation between these Filters is `AND`.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The attribute value. If there are multiple Values for one Filter, the logical relation between these Values under the same Filter is `OR`.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetClassicLinkInstancesFilterResult(
            string name,

            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
}