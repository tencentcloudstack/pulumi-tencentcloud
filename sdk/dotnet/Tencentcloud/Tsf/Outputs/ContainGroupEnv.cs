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
    public sealed class ContainGroupEnv
    {
        /// <summary>
        /// environment variable name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// environment variable value.
        /// </summary>
        public readonly string? Value;
        /// <summary>
        /// k8s ValueFrom.
        /// </summary>
        public readonly ImmutableArray<Outputs.ContainGroupEnvValueFrom> ValueFroms;

        [OutputConstructor]
        private ContainGroupEnv(
            string? name,

            string? value,

            ImmutableArray<Outputs.ContainGroupEnvValueFrom> valueFroms)
        {
            Name = name;
            Value = value;
            ValueFroms = valueFroms;
        }
    }
}