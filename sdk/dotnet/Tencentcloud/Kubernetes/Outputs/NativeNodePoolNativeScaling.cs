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
    public sealed class NativeNodePoolNativeScaling
    {
        /// <summary>
        /// Node pool expansion strategy. `ZoneEquality`: multiple availability zones are broken up; `ZonePriority`: the preferred availability zone takes precedence.
        /// </summary>
        public readonly string? CreatePolicy;
        /// <summary>
        /// Maximum number of replicas in node pool.
        /// </summary>
        public readonly int? MaxReplicas;
        /// <summary>
        /// Minimum number of replicas in node pool.
        /// </summary>
        public readonly int? MinReplicas;

        [OutputConstructor]
        private NativeNodePoolNativeScaling(
            string? createPolicy,

            int? maxReplicas,

            int? minReplicas)
        {
            CreatePolicy = createPolicy;
            MaxReplicas = maxReplicas;
            MinReplicas = minReplicas;
        }
    }
}
