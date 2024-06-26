// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm.Outputs
{

    [OutputType]
    public sealed class GetInstancesModificationFilterResult
    {
        /// <summary>
        /// Fields to be filtered.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Value of the field.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetInstancesModificationFilterResult(
            string name,

            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
}
