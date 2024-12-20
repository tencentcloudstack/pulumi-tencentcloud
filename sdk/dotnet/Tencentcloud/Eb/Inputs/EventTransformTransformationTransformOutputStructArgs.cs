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

    public sealed class EventTransformTransformationTransformOutputStructArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Corresponding to the key in the output json.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// You can fill in the json-path and also support constants or built-in keyword date types.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        /// <summary>
        /// The data type of value, optional values: `STRING`, `NUMBER`, `BOOLEAN`, `NULL`, `SYS_VARIABLE`, `JSONPATH`.
        /// </summary>
        [Input("valueType", required: true)]
        public Input<string> ValueType { get; set; } = null!;

        public EventTransformTransformationTransformOutputStructArgs()
        {
        }
        public static new EventTransformTransformationTransformOutputStructArgs Empty => new EventTransformTransformationTransformOutputStructArgs();
    }
}
