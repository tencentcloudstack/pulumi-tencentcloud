// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Inputs
{

    public sealed class ScenarioTestScriptArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Base64 encoded file content.
        /// </summary>
        [Input("encodedContent")]
        public Input<string>? EncodedContent { get; set; }

        /// <summary>
        /// Base64 encoded har structure.
        /// </summary>
        [Input("encodedHttpArchive")]
        public Input<string>? EncodedHttpArchive { get; set; }

        /// <summary>
        /// Script weight, range 1-100.
        /// </summary>
        [Input("loadWeight")]
        public Input<int>? LoadWeight { get; set; }

        /// <summary>
        /// File name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// File size.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// File type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public ScenarioTestScriptArgs()
        {
        }
    }
}