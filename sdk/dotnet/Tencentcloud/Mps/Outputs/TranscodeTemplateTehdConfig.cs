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
    public sealed class TranscodeTemplateTehdConfig
    {
        /// <summary>
        /// The upper limit of the video bit rate, which is valid when the Type specifies the ultra-fast HD type.Do not fill in or fill in 0 means that there is no upper limit on the video bit rate.
        /// </summary>
        public readonly int? MaxVideoBitrate;
        /// <summary>
        /// Extremely high-definition type, optional value:TEHD-100: Extreme HD-100.Not filling means that the ultra-fast high-definition is not enabled.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private TranscodeTemplateTehdConfig(
            int? maxVideoBitrate,

            string type)
        {
            MaxVideoBitrate = maxVideoBitrate;
            Type = type;
        }
    }
}