// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Batch.Outputs
{

    [OutputType]
    public sealed class ApplyAccountBaselinesBaselineConfigItem
    {
        /// <summary>
        /// Account Factory baseline item configuration. Different items have different parameters.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? Configuration;
        /// <summary>
        /// A unique identifier for an Account Factory baseline item, which can only contain English letters, digits, and @,._[]-:()+=. It must be 2-128 characters long.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? Identifier;

        [OutputConstructor]
        private ApplyAccountBaselinesBaselineConfigItem(
            string? configuration,

            string? identifier)
        {
            Configuration = configuration;
            Identifier = identifier;
        }
    }
}