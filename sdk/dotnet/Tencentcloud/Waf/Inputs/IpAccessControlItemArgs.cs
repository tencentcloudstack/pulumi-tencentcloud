// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Waf.Inputs
{

    public sealed class IpAccessControlItemArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Action value 40 is whitelist, 42 is blacklist.
        /// </summary>
        [Input("action", required: true)]
        public Input<int> Action { get; set; } = null!;

        /// <summary>
        /// ID of the resource.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// IP address.
        /// </summary>
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        /// <summary>
        /// Note info.
        /// </summary>
        [Input("note", required: true)]
        public Input<string> Note { get; set; } = null!;

        /// <summary>
        /// Source.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        /// <summary>
        /// Valid status.
        /// </summary>
        [Input("validStatus")]
        public Input<int>? ValidStatus { get; set; }

        /// <summary>
        /// Effective date, with a second level timestamp value. For example, 1680570420 represents 2023-04-04 09:07:00; 2019571199 means permanently effective.
        /// </summary>
        [Input("validTs", required: true)]
        public Input<int> ValidTs { get; set; } = null!;

        public IpAccessControlItemArgs()
        {
        }
        public static new IpAccessControlItemArgs Empty => new IpAccessControlItemArgs();
    }
}
