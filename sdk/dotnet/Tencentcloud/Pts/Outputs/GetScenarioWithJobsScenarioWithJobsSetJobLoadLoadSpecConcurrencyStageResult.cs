// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Outputs
{

    [OutputType]
    public sealed class GetScenarioWithJobsScenarioWithJobsSetJobLoadLoadSpecConcurrencyStageResult
    {
        /// <summary>
        /// The load test execution time.
        /// </summary>
        public readonly int DurationSeconds;
        /// <summary>
        /// Deprecated.
        /// </summary>
        public readonly int TargetVirtualUsers;

        [OutputConstructor]
        private GetScenarioWithJobsScenarioWithJobsSetJobLoadLoadSpecConcurrencyStageResult(
            int durationSeconds,

            int targetVirtualUsers)
        {
            DurationSeconds = durationSeconds;
            TargetVirtualUsers = targetVirtualUsers;
        }
    }
}
