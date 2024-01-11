// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos.Outputs
{

    [OutputType]
    public sealed class GetListListenerLayer7ListenerRealServerResult
    {
        /// <summary>
        /// 0-65535.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Source server list.
        /// </summary>
        public readonly string RealServer;
        /// <summary>
        /// 1: domain, 2: ip.
        /// </summary>
        public readonly int RsType;
        /// <summary>
        /// Weight: 1-100.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GetListListenerLayer7ListenerRealServerResult(
            int port,

            string realServer,

            int rsType,

            int weight)
        {
            Port = port;
            RealServer = realServer;
            RsType = rsType;
            Weight = weight;
        }
    }
}