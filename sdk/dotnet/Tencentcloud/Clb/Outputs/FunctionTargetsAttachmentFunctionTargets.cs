// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class FunctionTargetsAttachmentFunctionTargets
    {
        /// <summary>
        /// Information about cloud functions.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.FunctionTargetsAttachmentFunctionTargetsFunction Function;
        /// <summary>
        /// Weight. The default is `10`.
        /// </summary>
        public readonly int? Weight;

        [OutputConstructor]
        private FunctionTargetsAttachmentFunctionTargets(
            Outputs.FunctionTargetsAttachmentFunctionTargetsFunction function,

            int? weight)
        {
            Function = function;
            Weight = weight;
        }
    }
}