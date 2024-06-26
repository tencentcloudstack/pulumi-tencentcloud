// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Chdfs.Outputs
{

    [OutputType]
    public sealed class AccessRuleAccessRule
    {
        /// <summary>
        /// rule access mode, 1: read only, 2: read &amp;amp; wirte.
        /// </summary>
        public readonly int? AccessMode;
        /// <summary>
        /// single rule id.
        /// </summary>
        public readonly int? AccessRuleId;
        /// <summary>
        /// rule address, IP OR IP SEG.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// rule create time.
        /// </summary>
        public readonly string? CreateTime;
        /// <summary>
        /// rule priority, range 1 - 100, value less higher priority.
        /// </summary>
        public readonly int? Priority;

        [OutputConstructor]
        private AccessRuleAccessRule(
            int? accessMode,

            int? accessRuleId,

            string? address,

            string? createTime,

            int? priority)
        {
            AccessMode = accessMode;
            AccessRuleId = accessRuleId;
            Address = address;
            CreateTime = createTime;
            Priority = priority;
        }
    }
}
