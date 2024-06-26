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
    public sealed class JobDomainNameConfig
    {
        /// <summary>
        /// DNS configuration.
        /// </summary>
        public readonly Outputs.JobDomainNameConfigDnsConfig? DnsConfig;
        /// <summary>
        /// Domain name binding configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobDomainNameConfigHostAlias> HostAliases;

        [OutputConstructor]
        private JobDomainNameConfig(
            Outputs.JobDomainNameConfigDnsConfig? dnsConfig,

            ImmutableArray<Outputs.JobDomainNameConfigHostAlias> hostAliases)
        {
            DnsConfig = dnsConfig;
            HostAliases = hostAliases;
        }
    }
}
