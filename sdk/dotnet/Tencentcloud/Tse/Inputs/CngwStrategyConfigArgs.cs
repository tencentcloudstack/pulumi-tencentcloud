// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Inputs
{

    public sealed class CngwStrategyConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// behavior configuration of metric
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("behavior")]
        public Input<Inputs.CngwStrategyConfigBehaviorArgs>? Behavior { get; set; }

        /// <summary>
        /// create time
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// max number of replica for metric scaling.
        /// </summary>
        [Input("maxReplicas")]
        public Input<int>? MaxReplicas { get; set; }

        [Input("metrics")]
        private InputList<Inputs.CngwStrategyConfigMetricArgs>? _metrics;

        /// <summary>
        /// metric list.
        /// </summary>
        public InputList<Inputs.CngwStrategyConfigMetricArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.CngwStrategyConfigMetricArgs>());
            set => _metrics = value;
        }

        /// <summary>
        /// modify time
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("modifyTime")]
        public Input<string>? ModifyTime { get; set; }

        /// <summary>
        /// strategy ID
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("strategyId")]
        public Input<string>? StrategyId { get; set; }

        public CngwStrategyConfigArgs()
        {
        }
        public static new CngwStrategyConfigArgs Empty => new CngwStrategyConfigArgs();
    }
}