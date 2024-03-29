// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Elasticsearch.Outputs
{

    [OutputType]
    public sealed class GetLogstashInstanceOperationsOperationResult
    {
        /// <summary>
        /// Operation details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLogstashInstanceOperationsOperationDetailResult> Details;
        /// <summary>
        /// Id.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Task progress.
        /// </summary>
        public readonly double Progress;
        /// <summary>
        /// Subtask result.
        /// </summary>
        public readonly string Result;
        /// <summary>
        /// Start time, e.g. 2019-03-07 16:30:39.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// Operator uin.
        /// </summary>
        public readonly string SubAccountUin;
        /// <summary>
        /// Task information.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLogstashInstanceOperationsOperationTaskResult> Tasks;
        /// <summary>
        /// Type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetLogstashInstanceOperationsOperationResult(
            ImmutableArray<Outputs.GetLogstashInstanceOperationsOperationDetailResult> details,

            int id,

            double progress,

            string result,

            string startTime,

            string subAccountUin,

            ImmutableArray<Outputs.GetLogstashInstanceOperationsOperationTaskResult> tasks,

            string type)
        {
            Details = details;
            Id = id;
            Progress = progress;
            Result = result;
            StartTime = startTime;
            SubAccountUin = subAccountUin;
            Tasks = tasks;
            Type = type;
        }
    }
}
