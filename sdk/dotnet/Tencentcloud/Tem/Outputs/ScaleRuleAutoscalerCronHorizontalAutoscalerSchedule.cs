// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tem.Outputs
{

    [OutputType]
    public sealed class ScaleRuleAutoscalerCronHorizontalAutoscalerSchedule
    {
        /// <summary>
        /// start time.
        /// </summary>
        public readonly string StartAt;
        /// <summary>
        /// target replica number.
        /// </summary>
        public readonly int TargetReplicas;

        [OutputConstructor]
        private ScaleRuleAutoscalerCronHorizontalAutoscalerSchedule(
            string startAt,

            int targetReplicas)
        {
            StartAt = startAt;
            TargetReplicas = targetReplicas;
        }
    }
}