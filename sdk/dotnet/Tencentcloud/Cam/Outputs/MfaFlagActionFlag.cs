// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cam.Outputs
{

    [OutputType]
    public sealed class MfaFlagActionFlag
    {
        /// <summary>
        /// Phone.
        /// </summary>
        public readonly int? Phone;
        /// <summary>
        /// Soft token.
        /// </summary>
        public readonly int? Stoken;
        /// <summary>
        /// Wechat.
        /// </summary>
        public readonly int? Wechat;

        [OutputConstructor]
        private MfaFlagActionFlag(
            int? phone,

            int? stoken,

            int? wechat)
        {
            Phone = phone;
            Stoken = stoken;
            Wechat = wechat;
        }
    }
}
