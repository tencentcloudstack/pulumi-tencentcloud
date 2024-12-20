// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Inputs
{

    public sealed class JobDomainNameConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// DNS configuration.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Inputs.JobDomainNameConfigDnsConfigGetArgs>? DnsConfig { get; set; }

        [Input("hostAliases")]
        private InputList<Inputs.JobDomainNameConfigHostAliasGetArgs>? _hostAliases;

        /// <summary>
        /// Domain name binding configuration.
        /// </summary>
        public InputList<Inputs.JobDomainNameConfigHostAliasGetArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.JobDomainNameConfigHostAliasGetArgs>());
            set => _hostAliases = value;
        }

        public JobDomainNameConfigGetArgs()
        {
        }
        public static new JobDomainNameConfigGetArgs Empty => new JobDomainNameConfigGetArgs();
    }
}
