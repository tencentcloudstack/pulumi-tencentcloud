// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class TmpTkeGlobalNotificationNotificationAlertManager
    {
        /// <summary>
        /// Cluster id.
        /// </summary>
        public readonly string? ClusterId;
        /// <summary>
        /// Cluster type.
        /// </summary>
        public readonly string? ClusterType;
        /// <summary>
        /// Alert manager url.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private TmpTkeGlobalNotificationNotificationAlertManager(
            string? clusterId,

            string? clusterType,

            string url)
        {
            ClusterId = clusterId;
            ClusterType = clusterType;
            Url = url;
        }
    }
}
