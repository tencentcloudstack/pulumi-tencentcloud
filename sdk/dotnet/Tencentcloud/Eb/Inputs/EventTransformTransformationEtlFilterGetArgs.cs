// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Inputs
{

    public sealed class EventTransformTransformationEtlFilterGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Grammatical Rules are consistent.
        /// </summary>
        [Input("filter", required: true)]
        public Input<string> Filter { get; set; } = null!;

        public EventTransformTransformationEtlFilterGetArgs()
        {
        }
        public static new EventTransformTransformationEtlFilterGetArgs Empty => new EventTransformTransformationEtlFilterGetArgs();
    }
}
