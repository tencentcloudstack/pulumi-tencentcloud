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
    public sealed class GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleResult
    {
        /// <summary>
        /// Whether to abort the load test job.
        /// </summary>
        public readonly bool AbortFlag;
        /// <summary>
        /// The aggregation method of the metrics.
        /// </summary>
        public readonly string Aggregation;
        /// <summary>
        /// The operator for checking the condition.
        /// </summary>
        public readonly string Condition;
        /// <summary>
        /// The duration for checking the condition.
        /// </summary>
        public readonly string For;
        /// <summary>
        /// The label filter.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleLabelFilterResult> LabelFilters;
        /// <summary>
        /// The load test metrics.
        /// </summary>
        public readonly string Metric;
        /// <summary>
        /// The threshold in the condition.
        /// </summary>
        public readonly double Value;

        [OutputConstructor]
        private GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleResult(
            bool abortFlag,

            string aggregation,

            string condition,

            string @for,

            ImmutableArray<Outputs.GetScenarioWithJobsScenarioWithJobsSetScenarioSlaPolicySlaRuleLabelFilterResult> labelFilters,

            string metric,

            double value)
        {
            AbortFlag = abortFlag;
            Aggregation = aggregation;
            Condition = condition;
            For = @for;
            LabelFilters = labelFilters;
            Metric = metric;
            Value = value;
        }
    }
}
