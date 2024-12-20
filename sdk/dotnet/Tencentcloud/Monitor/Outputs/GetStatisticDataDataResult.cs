// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class GetStatisticDataDataResult
    {
        /// <summary>
        /// Metric name.
        /// </summary>
        public readonly string MetricName;
        /// <summary>
        /// Monitoring data point.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetStatisticDataDataPointResult> Points;

        [OutputConstructor]
        private GetStatisticDataDataResult(
            string metricName,

            ImmutableArray<Outputs.GetStatisticDataDataPointResult> points)
        {
            MetricName = metricName;
            Points = points;
        }
    }
}
