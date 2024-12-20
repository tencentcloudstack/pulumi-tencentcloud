// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls.Inputs
{

    public sealed class NoticeContentNoticeContentsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Template for Alarm Recovery Notification Content.
        /// </summary>
        [Input("recoveryContent")]
        public Input<Inputs.NoticeContentNoticeContentsRecoveryContentArgs>? RecoveryContent { get; set; }

        /// <summary>
        /// Alarm triggered notification content template.
        /// </summary>
        [Input("triggerContent")]
        public Input<Inputs.NoticeContentNoticeContentsTriggerContentArgs>? TriggerContent { get; set; }

        /// <summary>
        /// Channel type. Email: Email; Sms: SMS; WeChat: WeChat; Phone: Telephone; WeCom: Enterprise WeChat; DingTalk: DingTalk; Lark: Feishu; HTTP: Custom callback.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public NoticeContentNoticeContentsArgs()
        {
        }
        public static new NoticeContentNoticeContentsArgs Empty => new NoticeContentNoticeContentsArgs();
    }
}
