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
    public sealed class GetScenarioWithJobsScenarioWithJobsSetJobLoadSourceInfoResult
    {
        /// <summary>
        /// IP.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// The pod name of the load source.
        /// </summary>
        public readonly string PodName;
        /// <summary>
        /// Region.
        /// </summary>
        public readonly string Region;

        [OutputConstructor]
        private GetScenarioWithJobsScenarioWithJobsSetJobLoadSourceInfoResult(
            string ip,

            string podName,

            string region)
        {
            Ip = ip;
            PodName = podName;
            Region = region;
        }
    }
}
