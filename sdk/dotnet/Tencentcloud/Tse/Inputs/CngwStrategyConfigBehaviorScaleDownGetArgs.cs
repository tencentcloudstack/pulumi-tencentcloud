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

    public sealed class CngwStrategyConfigBehaviorScaleDownGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("policies")]
        private InputList<Inputs.CngwStrategyConfigBehaviorScaleDownPolicyGetArgs>? _policies;

        /// <summary>
        /// policies of scale down
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        public InputList<Inputs.CngwStrategyConfigBehaviorScaleDownPolicyGetArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.CngwStrategyConfigBehaviorScaleDownPolicyGetArgs>());
            set => _policies = value;
        }

        /// <summary>
        /// type of policy, default value: max
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("selectPolicy")]
        public Input<string>? SelectPolicy { get; set; }

        /// <summary>
        /// stability window time, unit:second, default 300 when scale down
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("stabilizationWindowSeconds")]
        public Input<int>? StabilizationWindowSeconds { get; set; }

        public CngwStrategyConfigBehaviorScaleDownGetArgs()
        {
        }
        public static new CngwStrategyConfigBehaviorScaleDownGetArgs Empty => new CngwStrategyConfigBehaviorScaleDownGetArgs();
    }
}
