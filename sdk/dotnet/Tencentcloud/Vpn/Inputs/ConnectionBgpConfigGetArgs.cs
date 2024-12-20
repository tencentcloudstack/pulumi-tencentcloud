// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpn.Inputs
{

    public sealed class ConnectionBgpConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Cloud BGP address. It must be allocated from within the BGP tunnel network segment.
        /// </summary>
        [Input("localBgpIp", required: true)]
        public Input<string> LocalBgpIp { get; set; } = null!;

        /// <summary>
        /// User side BGP address. It must be allocated from within the BGP tunnel network segment.
        /// </summary>
        [Input("remoteBgpIp", required: true)]
        public Input<string> RemoteBgpIp { get; set; } = null!;

        /// <summary>
        /// BGP tunnel segment.
        /// </summary>
        [Input("tunnelCidr", required: true)]
        public Input<string> TunnelCidr { get; set; } = null!;

        public ConnectionBgpConfigGetArgs()
        {
        }
        public static new ConnectionBgpConfigGetArgs Empty => new ConnectionBgpConfigGetArgs();
    }
}
