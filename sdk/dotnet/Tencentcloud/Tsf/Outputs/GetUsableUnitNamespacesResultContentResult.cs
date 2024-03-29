// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetUsableUnitNamespacesResultContentResult
    {
        /// <summary>
        /// Create time. Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly string CreatedTime;
        /// <summary>
        /// Gateway instance id Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly string GatewayInstanceId;
        /// <summary>
        /// Unit namespace ID. Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// namespace id.
        /// </summary>
        public readonly string NamespaceId;
        /// <summary>
        /// namespace name.
        /// </summary>
        public readonly string NamespaceName;
        /// <summary>
        /// Update time. Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly string UpdatedTime;

        [OutputConstructor]
        private GetUsableUnitNamespacesResultContentResult(
            string createdTime,

            string gatewayInstanceId,

            string id,

            string namespaceId,

            string namespaceName,

            string updatedTime)
        {
            CreatedTime = createdTime;
            GatewayInstanceId = gatewayInstanceId;
            Id = id;
            NamespaceId = namespaceId;
            NamespaceName = namespaceName;
            UpdatedTime = updatedTime;
        }
    }
}
