// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dlc.Outputs
{

    [OutputType]
    public sealed class GetDescribeUserInfoUserInfoWorkGroupInfoWorkGroupSetResult
    {
        /// <summary>
        /// The time the workgroup was created.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Creator.
        /// </summary>
        public readonly string Creator;
        /// <summary>
        /// Work group description.
        /// </summary>
        public readonly string WorkGroupDescription;
        /// <summary>
        /// Work group unique id.
        /// </summary>
        public readonly int WorkGroupId;
        /// <summary>
        /// Work group name.
        /// </summary>
        public readonly string WorkGroupName;

        [OutputConstructor]
        private GetDescribeUserInfoUserInfoWorkGroupInfoWorkGroupSetResult(
            string createTime,

            string creator,

            string workGroupDescription,

            int workGroupId,

            string workGroupName)
        {
            CreateTime = createTime;
            Creator = creator;
            WorkGroupDescription = workGroupDescription;
            WorkGroupId = workGroupId;
            WorkGroupName = workGroupName;
        }
    }
}