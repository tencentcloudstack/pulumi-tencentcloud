// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Identity.Outputs
{

    [OutputType]
    public sealed class GetCenterGroupsGroupResult
    {
        /// <summary>
        /// Creation time of the user group.
        /// </summary>
        public readonly string? CreateTime;
        /// <summary>
        /// User group description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// User group ID.
        /// </summary>
        public readonly string? GroupId;
        /// <summary>
        /// User group name.
        /// </summary>
        public readonly string? GroupName;
        /// <summary>
        /// User group type. Manual: manually created; Synchronized: externally imported.
        /// </summary>
        public readonly string? GroupType;
        /// <summary>
        /// If the input parameter FilterUsers is provided, return true when the user is in the user group; otherwise, return false.
        /// </summary>
        public readonly bool? IsSelected;
        /// <summary>
        /// Number of group members.
        /// </summary>
        public readonly int? MemberCount;
        /// <summary>
        /// Modification time of the user group.
        /// </summary>
        public readonly string? UpdateTime;

        [OutputConstructor]
        private GetCenterGroupsGroupResult(
            string? createTime,

            string? description,

            string? groupId,

            string? groupName,

            string? groupType,

            bool? isSelected,

            int? memberCount,

            string? updateTime)
        {
            CreateTime = createTime;
            Description = description;
            GroupId = groupId;
            GroupName = groupName;
            GroupType = groupType;
            IsSelected = isSelected;
            MemberCount = memberCount;
            UpdateTime = updateTime;
        }
    }
}