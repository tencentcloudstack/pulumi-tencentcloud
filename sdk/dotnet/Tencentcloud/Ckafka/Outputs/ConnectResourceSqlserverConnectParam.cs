// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class ConnectResourceSqlserverConnectParam
    {
        /// <summary>
        /// Whether to update to the associated Dip task, default: false.
        /// </summary>
        public readonly bool? IsUpdate;
        /// <summary>
        /// SQLServer password.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// SQLServer port.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// SQLServer instanceId.
        /// </summary>
        public readonly string Resource;
        /// <summary>
        /// SQLServer instance vip, When it is a Tencent Cloud instance, it is required.
        /// </summary>
        public readonly string? ServiceVip;
        /// <summary>
        /// SQLServer vpcId, When it is a Tencent Cloud instance, it is required.
        /// </summary>
        public readonly string? UniqVpcId;
        /// <summary>
        /// SQLServer The username of the connection source.
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private ConnectResourceSqlserverConnectParam(
            bool? isUpdate,

            string password,

            int port,

            string resource,

            string? serviceVip,

            string? uniqVpcId,

            string userName)
        {
            IsUpdate = isUpdate;
            Password = password;
            Port = port;
            Resource = resource;
            ServiceVip = serviceVip;
            UniqVpcId = uniqVpcId;
            UserName = userName;
        }
    }
}