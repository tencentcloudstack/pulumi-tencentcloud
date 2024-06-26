// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class CngwStrategyConfigBehaviorScaleUp
    {
        /// <summary>
        /// policies of scale up
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public readonly ImmutableArray<Outputs.CngwStrategyConfigBehaviorScaleUpPolicy> Policies;
        /// <summary>
        /// type of policy, default value: max
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public readonly string? SelectPolicy;
        /// <summary>
        /// stability window time, unit:second, default 0 when scale up
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public readonly int? StabilizationWindowSeconds;

        [OutputConstructor]
        private CngwStrategyConfigBehaviorScaleUp(
            ImmutableArray<Outputs.CngwStrategyConfigBehaviorScaleUpPolicy> policies,

            string? selectPolicy,

            int? stabilizationWindowSeconds)
        {
            Policies = policies;
            SelectPolicy = selectPolicy;
            StabilizationWindowSeconds = stabilizationWindowSeconds;
        }
    }
}
