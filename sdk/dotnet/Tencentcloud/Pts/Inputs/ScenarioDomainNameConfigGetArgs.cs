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

    public sealed class ScenarioDomainNameConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// DNS configuration.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Inputs.ScenarioDomainNameConfigDnsConfigGetArgs>? DnsConfig { get; set; }

        [Input("hostAliases")]
        private InputList<Inputs.ScenarioDomainNameConfigHostAliasGetArgs>? _hostAliases;

        /// <summary>
        /// Domain name binding configuration.
        /// </summary>
        public InputList<Inputs.ScenarioDomainNameConfigHostAliasGetArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Inputs.ScenarioDomainNameConfigHostAliasGetArgs>());
            set => _hostAliases = value;
        }

        public ScenarioDomainNameConfigGetArgs()
        {
        }
    }
}