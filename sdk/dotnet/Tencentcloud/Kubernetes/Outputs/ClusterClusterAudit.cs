// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class ClusterClusterAudit
    {
        /// <summary>
        /// when you want to close the cluster audit log or delete the cluster, you can use this parameter to determine whether the audit log set and topic created by default will be deleted.
        /// </summary>
        public readonly bool? DeleteAuditLogAndTopic;
        /// <summary>
        /// Specify weather the Cluster Audit enabled. NOTE: Enable Cluster Audit will also auto install Log Agent.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Specify id of existing CLS log set, or auto create a new set by leave it empty.
        /// </summary>
        public readonly string? LogSetId;
        /// <summary>
        /// Specify id of existing CLS log topic, or auto create a new topic by leave it empty.
        /// </summary>
        public readonly string? TopicId;

        [OutputConstructor]
        private ClusterClusterAudit(
            bool? deleteAuditLogAndTopic,

            bool enabled,

            string? logSetId,

            string? topicId)
        {
            DeleteAuditLogAndTopic = deleteAuditLogAndTopic;
            Enabled = enabled;
            LogSetId = logSetId;
            TopicId = topicId;
        }
    }
}
