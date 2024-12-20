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
    public sealed class GetProxyGroupsProxyGroupListRealServerRegionInfoSupportFeatureResult
    {
        /// <summary>
        /// A list of network types supported by the access area, with &amp;#39;normal&amp;#39; indicating support for regular BGP, &amp;#39;cn2&amp;#39; indicating premium BGP, &amp;#39;triple&amp;#39; indicating three networks, and &amp;#39;secure_EIP&amp;#39; represents a custom secure EIP.
        /// </summary>
        public readonly ImmutableArray<string> NetworkTypes;

        [OutputConstructor]
        private GetProxyGroupsProxyGroupListRealServerRegionInfoSupportFeatureResult(ImmutableArray<string> networkTypes)
        {
            NetworkTypes = networkTypes;
        }
    }
}
