// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As.Inputs
{

    public sealed class ScalingConfigHostNameSettingsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The host name of the cloud server; dots (.) and dashes (-) cannot be used as the first and last characters of HostName, and cannot be used consecutively; Windows instances are not supported; other types (Linux, etc.) instances: the character length is [2, 40], it is allowed to support multiple dots, and there is a paragraph between the dots, and each paragraph is allowed to consist of letters (no uppercase and lowercase restrictions), numbers and dashes (-). Pure numbers are not allowed.
        /// </summary>
        [Input("hostName", required: true)]
        public Input<string> HostName { get; set; } = null!;

        /// <summary>
        /// The style of the host name of the cloud server, the value range includes `ORIGINAL` and `UNIQUE`, the default is `ORIGINAL`; `ORIGINAL`, the AS directly passes the HostName filled in the input parameter to the CVM, and the CVM may append a sequence to the HostName number, the HostName of the instance in the scaling group will conflict; `UNIQUE`, the HostName filled in as a parameter is equivalent to the host name prefix, AS and CVM will expand it, and the HostName of the instance in the scaling group can be guaranteed to be unique.
        /// </summary>
        [Input("hostNameStyle")]
        public Input<string>? HostNameStyle { get; set; }

        public ScalingConfigHostNameSettingsArgs()
        {
        }
        public static new ScalingConfigHostNameSettingsArgs Empty => new ScalingConfigHostNameSettingsArgs();
    }
}
