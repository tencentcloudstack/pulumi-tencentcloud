// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdwdoris.Inputs
{

    public sealed class InstanceChargePropertiesGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Billing type: `PREPAID` for prepayment, and `POSTPAID_BY_HOUR` for postpayment. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// Whether to automatically renew. 1 means automatic renewal is enabled. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("renewFlag")]
        public Input<int>? RenewFlag { get; set; }

        /// <summary>
        /// Billing duration Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("timeSpan")]
        public Input<int>? TimeSpan { get; set; }

        /// <summary>
        /// Billing time unit, and `m` means month, etc. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("timeUnit")]
        public Input<string>? TimeUnit { get; set; }

        public InstanceChargePropertiesGetArgs()
        {
        }
        public static new InstanceChargePropertiesGetArgs Empty => new InstanceChargePropertiesGetArgs();
    }
}
