// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css.Inputs
{

    public sealed class StreamMonitorNotifyPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Callback url.limit [0,512].only http or https.
        /// </summary>
        [Input("callbackUrl")]
        public Input<string>? CallbackUrl { get; set; }

        /// <summary>
        /// Notify policy type.0: not notify.1: use global policy.
        /// </summary>
        [Input("notifyPolicyType")]
        public Input<int>? NotifyPolicyType { get; set; }

        public StreamMonitorNotifyPolicyGetArgs()
        {
        }
        public static new StreamMonitorNotifyPolicyGetArgs Empty => new StreamMonitorNotifyPolicyGetArgs();
    }
}
