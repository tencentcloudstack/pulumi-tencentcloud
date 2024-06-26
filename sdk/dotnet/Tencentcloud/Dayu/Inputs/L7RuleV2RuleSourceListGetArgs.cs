// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dayu.Inputs
{

    public sealed class L7RuleV2RuleSourceListGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Source IP or domain.
        /// </summary>
        [Input("source", required: true)]
        public Input<string> Source { get; set; } = null!;

        /// <summary>
        /// Weight of the source.
        /// </summary>
        [Input("weight", required: true)]
        public Input<int> Weight { get; set; } = null!;

        public L7RuleV2RuleSourceListGetArgs()
        {
        }
        public static new L7RuleV2RuleSourceListGetArgs Empty => new L7RuleV2RuleSourceListGetArgs();
    }
}
