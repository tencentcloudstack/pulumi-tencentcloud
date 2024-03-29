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
    public sealed class GetAlarmPolicyPolicyNoticeResult
    {
        /// <summary>
        /// Backend AMP consumer ID.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string AmpConsumerId;
        /// <summary>
        /// Channel to push alarm notifications to CLS.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeClsNoticeResult> ClsNotices;
        /// <summary>
        /// Alarm notification template IDNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Whether it is the system default notification template. Valid values: 0 (no), 1 (yes)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int IsPreset;
        /// <summary>
        /// Alarm notification template nameNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Notification language. Valid values: zh-CN (Chinese), en-US (English)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string NoticeLanguage;
        /// <summary>
        /// Alarm notification type. Valid values: ALARM (for unresolved alarms), OK (for resolved alarms), ALL (for all alarms)Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string NoticeType;
        /// <summary>
        /// List of IDs of the alarm policies bound to alarm notification templateNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> PolicyIds;
        /// <summary>
        /// Policy tagNote: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeTagResult> Tags;
        /// <summary>
        /// Last modified timeNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string UpdatedAt;
        /// <summary>
        /// Last modified byNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string UpdatedBy;
        /// <summary>
        /// Callback notification listNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeUrlNoticeResult> UrlNotices;
        /// <summary>
        /// User notification listNote: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeUserNoticeResult> UserNotices;

        [OutputConstructor]
        private GetAlarmPolicyPolicyNoticeResult(
            string ampConsumerId,

            ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeClsNoticeResult> clsNotices,

            string id,

            int isPreset,

            string name,

            string noticeLanguage,

            string noticeType,

            ImmutableArray<string> policyIds,

            ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeTagResult> tags,

            string updatedAt,

            string updatedBy,

            ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeUrlNoticeResult> urlNotices,

            ImmutableArray<Outputs.GetAlarmPolicyPolicyNoticeUserNoticeResult> userNotices)
        {
            AmpConsumerId = ampConsumerId;
            ClsNotices = clsNotices;
            Id = id;
            IsPreset = isPreset;
            Name = name;
            NoticeLanguage = noticeLanguage;
            NoticeType = noticeType;
            PolicyIds = policyIds;
            Tags = tags;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UrlNotices = urlNotices;
            UserNotices = userNotices;
        }
    }
}
