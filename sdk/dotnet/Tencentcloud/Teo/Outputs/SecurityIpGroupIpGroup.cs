// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class SecurityIpGroupIpGroup
    {
        /// <summary>
        /// IP group content. Only supports IP and IP mask.
        /// </summary>
        public readonly ImmutableArray<string> Contents;
        /// <summary>
        /// Group ID.
        /// </summary>
        public readonly int? GroupId;
        /// <summary>
        /// Group name.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private SecurityIpGroupIpGroup(
            ImmutableArray<string> contents,

            int? groupId,

            string name)
        {
            Contents = contents;
            GroupId = groupId;
            Name = name;
        }
    }
}
