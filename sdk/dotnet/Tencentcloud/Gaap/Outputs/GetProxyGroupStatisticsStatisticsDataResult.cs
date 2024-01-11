// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetProxyGroupStatisticsStatisticsDataResult
    {
        /// <summary>
        /// Metric Data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProxyGroupStatisticsStatisticsDataMetricDataResult> MetricDatas;
        /// <summary>
        /// Metric Name.
        /// </summary>
        public readonly string MetricName;

        [OutputConstructor]
        private GetProxyGroupStatisticsStatisticsDataResult(
            ImmutableArray<Outputs.GetProxyGroupStatisticsStatisticsDataMetricDataResult> metricDatas,

            string metricName)
        {
            MetricDatas = metricDatas;
            MetricName = metricName;
        }
    }
}