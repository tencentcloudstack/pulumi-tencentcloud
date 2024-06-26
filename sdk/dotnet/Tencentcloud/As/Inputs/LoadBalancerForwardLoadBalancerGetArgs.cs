// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As.Inputs
{

    public sealed class LoadBalancerForwardLoadBalancerGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Application load balancer listener ID.
        /// </summary>
        [Input("listenerId", required: true)]
        public Input<string> ListenerId { get; set; } = null!;

        /// <summary>
        /// Application load balancer instance ID.
        /// </summary>
        [Input("loadBalancerId", required: true)]
        public Input<string> LoadBalancerId { get; set; } = null!;

        /// <summary>
        /// Application load balancer location ID.
        /// </summary>
        [Input("locationId")]
        public Input<string>? LocationId { get; set; }

        /// <summary>
        /// Load balancer instance region. Default value is the region of current auto scaling group. The format is the same as the public parameter Region, for example: ap-guangzhou.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        [Input("targetAttributes", required: true)]
        private InputList<Inputs.LoadBalancerForwardLoadBalancerTargetAttributeGetArgs>? _targetAttributes;

        /// <summary>
        /// List of TargetAttribute.
        /// </summary>
        public InputList<Inputs.LoadBalancerForwardLoadBalancerTargetAttributeGetArgs> TargetAttributes
        {
            get => _targetAttributes ?? (_targetAttributes = new InputList<Inputs.LoadBalancerForwardLoadBalancerTargetAttributeGetArgs>());
            set => _targetAttributes = value;
        }

        public LoadBalancerForwardLoadBalancerGetArgs()
        {
        }
        public static new LoadBalancerForwardLoadBalancerGetArgs Empty => new LoadBalancerForwardLoadBalancerGetArgs();
    }
}
