// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Audit.Outputs
{

    [OutputType]
    public sealed class GetEventsLookupAttributeResult
    {
        /// <summary>
        /// Valid values: RequestId, EventName, ReadOnly, Username, ResourceType, ResourceName, AccessKeyId, and EventId
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string AttributeKey;
        /// <summary>
        /// Value of `AttributeValue`
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? AttributeValue;

        [OutputConstructor]
        private GetEventsLookupAttributeResult(
            string attributeKey,

            string? attributeValue)
        {
            AttributeKey = attributeKey;
            AttributeValue = attributeValue;
        }
    }
}
