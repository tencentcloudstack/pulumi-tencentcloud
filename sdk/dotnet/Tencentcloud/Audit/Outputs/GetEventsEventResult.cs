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
    public sealed class GetEventsEventResult
    {
        /// <summary>
        /// Root account ID.
        /// </summary>
        public readonly int? AccountId;
        /// <summary>
        /// Log details.
        /// </summary>
        public readonly string? CloudAuditEvent;
        /// <summary>
        /// Authentication error code.
        /// </summary>
        public readonly int? ErrorCode;
        /// <summary>
        /// Log ID.
        /// </summary>
        public readonly string? EventId;
        /// <summary>
        /// Event name.
        /// </summary>
        public readonly string? EventName;
        /// <summary>
        /// Description of event name in Chinese (please use this field as required; if you are using other languages, ignore this field).
        /// </summary>
        public readonly string? EventNameCn;
        /// <summary>
        /// Event region.
        /// </summary>
        public readonly string? EventRegion;
        /// <summary>
        /// Request source.
        /// </summary>
        public readonly string? EventSource;
        /// <summary>
        /// Event Time.
        /// </summary>
        public readonly string? EventTime;
        /// <summary>
        /// IP location.
        /// </summary>
        public readonly string? Location;
        /// <summary>
        /// Request ID.
        /// </summary>
        public readonly string? RequestId;
        /// <summary>
        /// Resource region.
        /// </summary>
        public readonly string? ResourceRegion;
        /// <summary>
        /// Description of resource type in Chinese (please use this field as required; if you are using other languages, ignore this field).
        /// </summary>
        public readonly string? ResourceTypeCn;
        /// <summary>
        /// Resource pair.
        /// </summary>
        public readonly Outputs.GetEventsEventResourcesResult? Resources;
        /// <summary>
        /// Certificate ID
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? SecretId;
        /// <summary>
        /// Source IP
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? SourceIpAddress;
        /// <summary>
        /// Username.
        /// </summary>
        public readonly string? Username;

        [OutputConstructor]
        private GetEventsEventResult(
            int? accountId,

            string? cloudAuditEvent,

            int? errorCode,

            string? eventId,

            string? eventName,

            string? eventNameCn,

            string? eventRegion,

            string? eventSource,

            string? eventTime,

            string? location,

            string? requestId,

            string? resourceRegion,

            string? resourceTypeCn,

            Outputs.GetEventsEventResourcesResult? resources,

            string? secretId,

            string? sourceIpAddress,

            string? username)
        {
            AccountId = accountId;
            CloudAuditEvent = cloudAuditEvent;
            ErrorCode = errorCode;
            EventId = eventId;
            EventName = eventName;
            EventNameCn = eventNameCn;
            EventRegion = eventRegion;
            EventSource = eventSource;
            EventTime = eventTime;
            Location = location;
            RequestId = requestId;
            ResourceRegion = resourceRegion;
            ResourceTypeCn = resourceTypeCn;
            Resources = resources;
            SecretId = secretId;
            SourceIpAddress = sourceIpAddress;
            Username = username;
        }
    }
}