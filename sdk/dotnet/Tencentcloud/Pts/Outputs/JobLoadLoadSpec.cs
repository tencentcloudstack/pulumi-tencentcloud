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
    public sealed class JobLoadLoadSpec
    {
        /// <summary>
        /// Configuration of concurrent pressure mode.
        /// </summary>
        public readonly Outputs.JobLoadLoadSpecConcurrency? Concurrency;
        /// <summary>
        /// Average number of requests per second.
        /// </summary>
        public readonly Outputs.JobLoadLoadSpecRequestsPerSecond? RequestsPerSecond;
        /// <summary>
        /// Built-in stress mode in script.
        /// </summary>
        public readonly Outputs.JobLoadLoadSpecScriptOrigin? ScriptOrigin;

        [OutputConstructor]
        private JobLoadLoadSpec(
            Outputs.JobLoadLoadSpecConcurrency? concurrency,

            Outputs.JobLoadLoadSpecRequestsPerSecond? requestsPerSecond,

            Outputs.JobLoadLoadSpecScriptOrigin? scriptOrigin)
        {
            Concurrency = concurrency;
            RequestsPerSecond = requestsPerSecond;
            ScriptOrigin = scriptOrigin;
        }
    }
}
