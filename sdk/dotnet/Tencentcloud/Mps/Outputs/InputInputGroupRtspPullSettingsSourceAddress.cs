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
    public sealed class InputInputGroupRtspPullSettingsSourceAddress
    {
        /// <summary>
        /// The URL address of the RTSP source site.
        /// </summary>
        public readonly string Url;

        [OutputConstructor]
        private InputInputGroupRtspPullSettingsSourceAddress(string url)
        {
            Url = url;
        }
    }
}
