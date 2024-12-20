// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Outputs
{

    [OutputType]
    public sealed class JobDomainNameConfigDnsConfig
    {
        /// <summary>
        /// DNS IP List.
        /// </summary>
        public readonly ImmutableArray<string> Nameservers;

        [OutputConstructor]
        private JobDomainNameConfigDnsConfig(ImmutableArray<string> nameservers)
        {
            Nameservers = nameservers;
        }
    }
}
