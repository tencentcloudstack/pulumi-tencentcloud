// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr.Outputs
{

    [OutputType]
    public sealed class GetTagRetentionExecutionsRetentionExecutionListResult
    {
        /// <summary>
        /// execution end time.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// execution id.
        /// </summary>
        public readonly int ExecutionId;
        /// <summary>
        /// retention id.
        /// </summary>
        public readonly int RetentionId;
        /// <summary>
        /// execution start time.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// execution status: Failed, Succeed, Stopped, InProgress.
        /// </summary>
        public readonly string Status;

        [OutputConstructor]
        private GetTagRetentionExecutionsRetentionExecutionListResult(
            string endTime,

            int executionId,

            int retentionId,

            string startTime,

            string status)
        {
            EndTime = endTime;
            ExecutionId = executionId;
            RetentionId = retentionId;
            StartTime = startTime;
            Status = status;
        }
    }
}