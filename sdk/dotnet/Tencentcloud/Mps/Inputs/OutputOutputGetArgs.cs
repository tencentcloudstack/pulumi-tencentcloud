// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Inputs
{

    public sealed class OutputOutputGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("allowIpLists")]
        private InputList<string>? _allowIpLists;

        /// <summary>
        /// IP whitelist list, the format is CIDR, such as 0.0.0.0/0. When the Protocol is RTMP_PULL, it is valid, and if it is empty, it means that the client IP is not limited.
        /// </summary>
        public InputList<string> AllowIpLists
        {
            get => _allowIpLists ?? (_allowIpLists = new InputList<string>());
            set => _allowIpLists = value;
        }

        /// <summary>
        /// Output description.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// The maximum number of concurrent pull streams, the maximum is 4, and the default is 4. Only SRT or RTMP_PULL can set this parameter.
        /// </summary>
        [Input("maxConcurrent")]
        public Input<int>? MaxConcurrent { get; set; }

        /// <summary>
        /// The name of the output.
        /// </summary>
        [Input("outputName", required: true)]
        public Input<string> OutputName { get; set; } = null!;

        /// <summary>
        /// Output region.
        /// </summary>
        [Input("outputRegion", required: true)]
        public Input<string> OutputRegion { get; set; } = null!;

        /// <summary>
        /// Output protocol, optional [SRT|RTP|RTMP|RTMP_PULL].
        /// </summary>
        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        /// <summary>
        /// Output RTMP configuration.
        /// </summary>
        [Input("rtmpSettings")]
        public Input<Inputs.OutputOutputRtmpSettingsGetArgs>? RtmpSettings { get; set; }

        /// <summary>
        /// Output RTP configuration.
        /// </summary>
        [Input("rtpSettings")]
        public Input<Inputs.OutputOutputRtpSettingsGetArgs>? RtpSettings { get; set; }

        /// <summary>
        /// configuration of the output SRT.
        /// </summary>
        [Input("srtSettings")]
        public Input<Inputs.OutputOutputSrtSettingsGetArgs>? SrtSettings { get; set; }

        public OutputOutputGetArgs()
        {
        }
        public static new OutputOutputGetArgs Empty => new OutputOutputGetArgs();
    }
}
