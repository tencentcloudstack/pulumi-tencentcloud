// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ci.Inputs
{

    public sealed class MediaVoiceSeparateTemplateAudioConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Original audio bit rate, unit: Kbps, Value range: [8, 1000].
        /// </summary>
        [Input("bitrate")]
        public Input<string>? Bitrate { get; set; }

        /// <summary>
        /// number of channels- When Codec is set to aac/flac, support 1, 2, 4, 5, 6, 8- When Codec is set to mp3, support 1, 2- When Codec is set to amr, only 1 is supported.
        /// </summary>
        [Input("channels")]
        public Input<string>? Channels { get; set; }

        /// <summary>
        /// Codec format, value aac, mp3, flac, amr.
        /// </summary>
        [Input("codec", required: true)]
        public Input<string> Codec { get; set; } = null!;

        /// <summary>
        /// Sampling Rate- 1: Unit: Hz- 2: Optional 8000, 11025, 22050, 32000, 44100, 48000, 96000- 3: When Codec is set to aac/flac, 8000 is not supported- 4: When Codec is set to mp3, 8000 and 96000 are not supported- 5: When Codec is set to amr, only 8000 is supported.
        /// </summary>
        [Input("samplerate")]
        public Input<string>? Samplerate { get; set; }

        public MediaVoiceSeparateTemplateAudioConfigArgs()
        {
        }
    }
}