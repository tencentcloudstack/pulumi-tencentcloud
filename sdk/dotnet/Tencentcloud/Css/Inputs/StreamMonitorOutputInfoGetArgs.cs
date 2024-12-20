// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css.Inputs
{

    public sealed class StreamMonitorOutputInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Monitor task play path.limit 32 bytes.
        /// </summary>
        [Input("outputApp")]
        public Input<string>? OutputApp { get; set; }

        /// <summary>
        /// Monitor task output play domain.limit 128 bytes.
        /// </summary>
        [Input("outputDomain")]
        public Input<string>? OutputDomain { get; set; }

        /// <summary>
        /// Monitor task output height, limit[1, 1080].
        /// </summary>
        [Input("outputStreamHeight", required: true)]
        public Input<int> OutputStreamHeight { get; set; } = null!;

        /// <summary>
        /// Monitor task output stream name.limit 256 bytes.
        /// </summary>
        [Input("outputStreamName")]
        public Input<string>? OutputStreamName { get; set; }

        /// <summary>
        /// Output stream width, limit[1, 1920].
        /// </summary>
        [Input("outputStreamWidth", required: true)]
        public Input<int> OutputStreamWidth { get; set; } = null!;

        public StreamMonitorOutputInfoGetArgs()
        {
        }
        public static new StreamMonitorOutputInfoGetArgs Empty => new StreamMonitorOutputInfoGetArgs();
    }
}
