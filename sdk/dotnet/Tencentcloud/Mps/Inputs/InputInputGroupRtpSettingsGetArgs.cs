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

    public sealed class InputInputGroupRtpSettingsGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defaults to &amp;#39;none&amp;#39;, optional values[&amp;#39;none&amp;#39;].
        /// </summary>
        [Input("fec")]
        public Input<string>? Fec { get; set; }

        /// <summary>
        /// Idle timeout, the default is 5000, the unit is ms, and the range is [1000, 10000].
        /// </summary>
        [Input("idleTimeout")]
        public Input<int>? IdleTimeout { get; set; }

        public InputInputGroupRtpSettingsGetArgs()
        {
        }
        public static new InputInputGroupRtpSettingsGetArgs Empty => new InputInputGroupRtpSettingsGetArgs();
    }
}
