// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class ClusterAttachmentWorkerConfigTaint
    {
        /// <summary>
        /// Effect of the taint.
        /// </summary>
        public readonly string? Effect;
        /// <summary>
        /// Key of the taint.
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// Value of the taint.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private ClusterAttachmentWorkerConfigTaint(
            string? effect,

            string? key,

            string? value)
        {
            Effect = effect;
            Key = key;
            Value = value;
        }
    }
}
