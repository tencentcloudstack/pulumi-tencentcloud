// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetApiDetailResultDefinitionResult
    {
        /// <summary>
        /// param description.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// object property list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApiDetailResultDefinitionPropertyResult> Properties;

        [OutputConstructor]
        private GetApiDetailResultDefinitionResult(
            string name,

            ImmutableArray<Outputs.GetApiDetailResultDefinitionPropertyResult> properties)
        {
            Name = name;
            Properties = properties;
        }
    }
}
