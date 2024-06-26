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
    public sealed class GetIdleInstancesIdleLoadBalancerResult
    {
        /// <summary>
        /// The load balancing hostname.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// CLB type. Value range: 1 (CLB); 0 (classic CLB).
        /// </summary>
        public readonly int Forward;
        /// <summary>
        /// The reason why the load balancer is considered idle. NO_RULES: No rules configured. NO_RS: The rules are not associated with servers.
        /// </summary>
        public readonly string IdleReason;
        /// <summary>
        /// CLB instance ID.
        /// </summary>
        public readonly string LoadBalancerId;
        /// <summary>
        /// CLB instance name.
        /// </summary>
        public readonly string LoadBalancerName;
        /// <summary>
        /// CLB instance region.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// CLB instance status, including:0: Creating; 1: Running.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// CLB instance VIP.
        /// </summary>
        public readonly string Vip;

        [OutputConstructor]
        private GetIdleInstancesIdleLoadBalancerResult(
            string domain,

            int forward,

            string idleReason,

            string loadBalancerId,

            string loadBalancerName,

            string region,

            int status,

            string vip)
        {
            Domain = domain;
            Forward = forward;
            IdleReason = idleReason;
            LoadBalancerId = loadBalancerId;
            LoadBalancerName = loadBalancerName;
            Region = region;
            Status = status;
            Vip = vip;
        }
    }
}
