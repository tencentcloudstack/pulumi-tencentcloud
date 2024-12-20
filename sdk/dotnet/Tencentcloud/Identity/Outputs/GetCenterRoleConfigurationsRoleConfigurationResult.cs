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
    public sealed class GetCenterRoleConfigurationsRoleConfigurationResult
    {
        /// <summary>
        /// Creation time of the permission configuration.
        /// </summary>
        public readonly string? CreateTime;
        /// <summary>
        /// Permission configuration description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// If the input parameter FilterTargets is provided, check whether the member account has been configured with permissions. If configured, return true; otherwise, return false.
        /// </summary>
        public readonly bool? IsSelected;
        /// <summary>
        /// Initial access page. It indicates the initial access page URL when CIC users use the access configuration to access member accounts.
        /// </summary>
        public readonly string? RelayState;
        /// <summary>
        /// Permission configuration ID.
        /// </summary>
        public readonly string? RoleConfigurationId;
        /// <summary>
        /// Permission configuration name.
        /// </summary>
        public readonly string? RoleConfigurationName;
        /// <summary>
        /// Session duration. It indicates the maximum session duration when CIC users use the access configuration to access member accounts.
        /// Unit: seconds.
        /// </summary>
        public readonly int? SessionDuration;
        /// <summary>
        /// Update time of the permission configuration.
        /// </summary>
        public readonly string? UpdateTime;

        [OutputConstructor]
        private GetCenterRoleConfigurationsRoleConfigurationResult(
            string? createTime,

            string? description,

            bool? isSelected,

            string? relayState,

            string? roleConfigurationId,

            string? roleConfigurationName,

            int? sessionDuration,

            string? updateTime)
        {
            CreateTime = createTime;
            Description = description;
            IsSelected = isSelected;
            RelayState = relayState;
            RoleConfigurationId = roleConfigurationId;
            RoleConfigurationName = roleConfigurationName;
            SessionDuration = sessionDuration;
            UpdateTime = updateTime;
        }
    }
}
