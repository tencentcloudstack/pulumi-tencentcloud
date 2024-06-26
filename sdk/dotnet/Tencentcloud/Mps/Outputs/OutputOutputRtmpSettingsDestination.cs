// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class OutputOutputRtmpSettingsDestination
    {
        /// <summary>
        /// relayed StreamKey, in the format: stream?key=value.
        /// </summary>
        public readonly string StreamKey;
        /// <summary>
        /// relayed URL, the format is: rtmp://domain/live.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private OutputOutputRtmpSettingsDestination(
            string streamKey,

            string url)
        {
            StreamKey = streamKey;
            Url = url;
        }
    }
}
