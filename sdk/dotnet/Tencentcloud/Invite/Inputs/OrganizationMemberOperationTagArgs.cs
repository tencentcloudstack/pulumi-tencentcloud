// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Invite.Inputs
{

    public sealed class OrganizationMemberOperationTagArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Tag key.
        /// </summary>
        [Input("tagKey", required: true)]
        public Input<string> TagKey { get; set; } = null!;

        /// <summary>
        /// Tag value.
        /// </summary>
        [Input("tagValue", required: true)]
        public Input<string> TagValue { get; set; } = null!;

        public OrganizationMemberOperationTagArgs()
        {
        }
        public static new OrganizationMemberOperationTagArgs Empty => new OrganizationMemberOperationTagArgs();
    }
}