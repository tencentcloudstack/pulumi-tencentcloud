// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls.Outputs
{

    [OutputType]
    public sealed class KafkaRechargeProtocol
    {
        /// <summary>
        /// encryption type.
        /// </summary>
        public readonly string? Mechanism;
        /// <summary>
        /// user password.
        /// </summary>
        public readonly string? Password;
        /// <summary>
        /// protocol type.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// username.
        /// </summary>
        public readonly string? UserName;

        [OutputConstructor]
        private KafkaRechargeProtocol(
            string? mechanism,

            string? password,

            string? protocol,

            string? userName)
        {
            Mechanism = mechanism;
            Password = password;
            Protocol = protocol;
            UserName = userName;
        }
    }
}
