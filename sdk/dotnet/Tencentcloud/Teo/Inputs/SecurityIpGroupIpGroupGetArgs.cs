// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class SecurityIpGroupIpGroupGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("contents", required: true)]
        private InputList<string>? _contents;

        /// <summary>
        /// IP group content. Only supports IP and IP mask.
        /// </summary>
        public InputList<string> Contents
        {
            get => _contents ?? (_contents = new InputList<string>());
            set => _contents = value;
        }

        /// <summary>
        /// Group ID.
        /// </summary>
        [Input("groupId")]
        public Input<int>? GroupId { get; set; }

        /// <summary>
        /// Group name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public SecurityIpGroupIpGroupGetArgs()
        {
        }
        public static new SecurityIpGroupIpGroupGetArgs Empty => new SecurityIpGroupIpGroupGetArgs();
    }
}