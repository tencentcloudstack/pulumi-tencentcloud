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
    public sealed class FunctionAliasRoutingConfigAdditionalVersionWeight
    {
        /// <summary>
        /// Function version name.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// Version weight.
        /// </summary>
        public readonly double Weight;

        [OutputConstructor]
        private FunctionAliasRoutingConfigAdditionalVersionWeight(
            string version,

            double weight)
        {
            Version = version;
            Weight = weight;
        }
    }
}