// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetInstanceTrafficLoadBalancerTrafficResult
    {
        /// <summary>
        /// CLB domain name. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// CLB instance ID.
        /// </summary>
        public readonly string LoadBalancerId;
        /// <summary>
        /// CLB instance name.
        /// </summary>
        public readonly string LoadBalancerName;
        /// <summary>
        /// Maximum outbound bandwidth in Mbps.
        /// </summary>
        public readonly double OutBandwidth;
        /// <summary>
        /// CLB instance region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// CLB instance VIP.
        /// </summary>
        public readonly string Vip;

        [OutputConstructor]
        private GetInstanceTrafficLoadBalancerTrafficResult(
            string domain,

            string loadBalancerId,

            string loadBalancerName,

            double outBandwidth,

            string region,

            string vip)
        {
            Domain = domain;
            LoadBalancerId = loadBalancerId;
            LoadBalancerName = loadBalancerName;
            OutBandwidth = outBandwidth;
            Region = region;
            Vip = vip;
        }
    }
}
