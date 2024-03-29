// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf.Outputs
{

    [OutputType]
    public sealed class GetWafInfosHostListResult
    {
        public readonly string Domain;
        public readonly string DomainId;
        public readonly int FlowMode;
        public readonly ImmutableArray<Outputs.GetWafInfosHostListLoadBalancerResult> LoadBalancers;
        public readonly int Status;

        [OutputConstructor]
        private GetWafInfosHostListResult(
            string domain,

            string domainId,

            int flowMode,

            ImmutableArray<Outputs.GetWafInfosHostListLoadBalancerResult> loadBalancers,

            int status)
        {
            Domain = domain;
            DomainId = domainId;
            FlowMode = flowMode;
            LoadBalancers = loadBalancers;
            Status = status;
        }
    }
}
