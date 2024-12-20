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
    public sealed class GetGroupAndStatisticsProxyGroupSetProxySetResult
    {
        /// <summary>
        /// listener list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGroupAndStatisticsProxyGroupSetProxySetListenerListResult> ListenerLists;
        /// <summary>
        /// Channel Id.
        /// </summary>
        public readonly string ProxyId;
        /// <summary>
        /// Channel name.
        /// </summary>
        public readonly string ProxyName;

        [OutputConstructor]
        private GetGroupAndStatisticsProxyGroupSetProxySetResult(
            ImmutableArray<Outputs.GetGroupAndStatisticsProxyGroupSetProxySetListenerListResult> listenerLists,

            string proxyId,

            string proxyName)
        {
            ListenerLists = listenerLists;
            ProxyId = proxyId;
            ProxyName = proxyName;
        }
    }
}
