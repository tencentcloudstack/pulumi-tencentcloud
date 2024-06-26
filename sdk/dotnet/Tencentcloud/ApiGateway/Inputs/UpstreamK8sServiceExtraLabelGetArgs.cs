// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Inputs
{

    public sealed class UpstreamK8sServiceExtraLabelGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key of Label.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// Value of Label.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public UpstreamK8sServiceExtraLabelGetArgs()
        {
        }
        public static new UpstreamK8sServiceExtraLabelGetArgs Empty => new UpstreamK8sServiceExtraLabelGetArgs();
    }
}
