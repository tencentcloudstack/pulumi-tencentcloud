// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As.Outputs
{

    [OutputType]
    public sealed class GetLastActivityActivitySetResult
    {
        /// <summary>
        /// Scaling activity ID.
        /// </summary>
        public readonly string ActivityId;
        /// <summary>
        /// Information set of the instances related to the scaling activity.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLastActivityActivitySetActivityRelatedInstanceSetResult> ActivityRelatedInstanceSets;
        /// <summary>
        /// Type of the scaling activity. Value range: SCALE_OUT, SCALE_IN, ATTACH_INSTANCES, REMOVE_INSTANCES, DETACH_INSTANCES, TERMINATE_INSTANCES_UNEXPECTEDLY, REPLACE_UNHEALTHY_INSTANCE, START_INSTANCES, STOP_INSTANCES, INVOKE_COMMAND.
        /// </summary>
        public readonly string ActivityType;
        /// <summary>
        /// Auto scaling group ID.
        /// </summary>
        public readonly string AutoScalingGroupId;
        /// <summary>
        /// Cause of the scaling activity.
        /// </summary>
        public readonly string Cause;
        /// <summary>
        /// Creation time of the scaling activity.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// Description of the scaling activity.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Detailed description of scaling activity status.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLastActivityActivitySetDetailedStatusMessageSetResult> DetailedStatusMessageSets;
        /// <summary>
        /// End time of the scaling activity.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// Result of the command execution.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLastActivityActivitySetInvocationResultSetResult> InvocationResultSets;
        /// <summary>
        /// Result of the lifecycle hook action in the scaling activity.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLastActivityActivitySetLifecycleActionResultSetResult> LifecycleActionResultSets;
        /// <summary>
        /// Start time of the scaling activity.
        /// </summary>
        public readonly string StartTime;
        /// <summary>
        /// Scaling activity status. Value range: INIT, RUNNING, SUCCESSFUL, PARTIALLY_SUCCESSFUL, FAILED, CANCELLED.
        /// </summary>
        public readonly string StatusCode;
        /// <summary>
        /// Description of the scaling activity status.
        /// </summary>
        public readonly string StatusMessage;
        /// <summary>
        /// Brief description of the scaling activity status.
        /// </summary>
        public readonly string StatusMessageSimplified;

        [OutputConstructor]
        private GetLastActivityActivitySetResult(
            string activityId,

            ImmutableArray<Outputs.GetLastActivityActivitySetActivityRelatedInstanceSetResult> activityRelatedInstanceSets,

            string activityType,

            string autoScalingGroupId,

            string cause,

            string createdTime,

            string description,

            ImmutableArray<Outputs.GetLastActivityActivitySetDetailedStatusMessageSetResult> detailedStatusMessageSets,

            string endTime,

            ImmutableArray<Outputs.GetLastActivityActivitySetInvocationResultSetResult> invocationResultSets,

            ImmutableArray<Outputs.GetLastActivityActivitySetLifecycleActionResultSetResult> lifecycleActionResultSets,

            string startTime,

            string statusCode,

            string statusMessage,

            string statusMessageSimplified)
        {
            ActivityId = activityId;
            ActivityRelatedInstanceSets = activityRelatedInstanceSets;
            ActivityType = activityType;
            AutoScalingGroupId = autoScalingGroupId;
            Cause = cause;
            CreatedTime = createdTime;
            Description = description;
            DetailedStatusMessageSets = detailedStatusMessageSets;
            EndTime = endTime;
            InvocationResultSets = invocationResultSets;
            LifecycleActionResultSets = lifecycleActionResultSets;
            StartTime = startTime;
            StatusCode = statusCode;
            StatusMessage = statusMessage;
            StatusMessageSimplified = statusMessageSimplified;
        }
    }
}