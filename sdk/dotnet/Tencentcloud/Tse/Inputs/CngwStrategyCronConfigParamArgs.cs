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

    public sealed class CngwStrategyCronConfigParamArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// cron expression of timed scaling, no input required
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("crontab")]
        public Input<string>? Crontab { get; set; }

        /// <summary>
        /// period of timed scaling
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("period")]
        public Input<string>? Period { get; set; }

        /// <summary>
        /// start time of timed scaling
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("startAt")]
        public Input<string>? StartAt { get; set; }

        /// <summary>
        /// the number of target nodes for the timed scaling. Do not exceed the max number of replica for metric scaling
        /// Note: This field may return null, indicating that a valid value is not available.
        /// </summary>
        [Input("targetReplicas")]
        public Input<int>? TargetReplicas { get; set; }

        public CngwStrategyCronConfigParamArgs()
        {
        }
        public static new CngwStrategyCronConfigParamArgs Empty => new CngwStrategyCronConfigParamArgs();
    }
}
