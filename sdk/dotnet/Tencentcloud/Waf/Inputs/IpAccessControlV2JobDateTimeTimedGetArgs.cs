// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf.Inputs
{

    public sealed class IpAccessControlV2JobDateTimeTimedGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// End timestamp, in seconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("endDateTime")]
        public Input<int>? EndDateTime { get; set; }

        /// <summary>
        /// Start timestamp, in seconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("startDateTime")]
        public Input<int>? StartDateTime { get; set; }

        public IpAccessControlV2JobDateTimeTimedGetArgs()
        {
        }
        public static new IpAccessControlV2JobDateTimeTimedGetArgs Empty => new IpAccessControlV2JobDateTimeTimedGetArgs();
    }
}