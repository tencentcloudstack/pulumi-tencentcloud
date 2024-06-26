// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetProxyDetailProxyDetailIpListResult
    {
        /// <summary>
        /// Band width.
        /// </summary>
        public readonly int Bandwidth;
        /// <summary>
        /// IP.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// Supplier, BGP represents default, CMCC represents China Mobile, CUCC represents China Unicom, and CTCC represents China Telecom.
        /// </summary>
        public readonly string Provider;

        [OutputConstructor]
        private GetProxyDetailProxyDetailIpListResult(
            int bandwidth,

            string ip,

            string provider)
        {
            Bandwidth = bandwidth;
            Ip = ip;
            Provider = provider;
        }
    }
}
