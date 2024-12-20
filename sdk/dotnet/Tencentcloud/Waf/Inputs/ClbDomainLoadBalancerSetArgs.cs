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

    public sealed class ClbDomainLoadBalancerSetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Unique ID of listener in LB.
        /// </summary>
        [Input("listenerId", required: true)]
        public Input<string> ListenerId { get; set; } = null!;

        /// <summary>
        /// Listener name.
        /// </summary>
        [Input("listenerName", required: true)]
        public Input<string> ListenerName { get; set; } = null!;

        /// <summary>
        /// LoadBalancer unique ID.
        /// </summary>
        [Input("loadBalancerId", required: true)]
        public Input<string> LoadBalancerId { get; set; } = null!;

        /// <summary>
        /// LoadBalancer name.
        /// </summary>
        [Input("loadBalancerName", required: true)]
        public Input<string> LoadBalancerName { get; set; } = null!;

        /// <summary>
        /// Network type for load balancer.
        /// </summary>
        [Input("loadBalancerType")]
        public Input<string>? LoadBalancerType { get; set; }

        /// <summary>
        /// VPCID for load balancer, public network is -1, and internal network is filled in according to actual conditions.
        /// </summary>
        [Input("numericalVpcId")]
        public Input<int>? NumericalVpcId { get; set; }

        /// <summary>
        /// Protocol of listener, http or https.
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// LoadBalancer region.
        /// </summary>
        [Input("region", required: true)]
        public Input<string> Region { get; set; } = null!;

        /// <summary>
        /// LoadBalancer IP.
        /// </summary>
        [Input("vip", required: true)]
        public Input<string> Vip { get; set; } = null!;

        /// <summary>
        /// LoadBalancer port.
        /// </summary>
        [Input("vport", required: true)]
        public Input<int> Vport { get; set; } = null!;

        /// <summary>
        /// LoadBalancer zone.
        /// </summary>
        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public ClbDomainLoadBalancerSetArgs()
        {
        }
        public static new ClbDomainLoadBalancerSetArgs Empty => new ClbDomainLoadBalancerSetArgs();
    }
}
