// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssl.Outputs
{

    [OutputType]
    public sealed class GetDescribeHostDeployRecordDetailDeployRecordDetailListResult
    {
        /// <summary>
        /// COS storage barrel nameNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string Bucket;
        /// <summary>
        /// Deployment certificate ID.
        /// </summary>
        public readonly string CertId;
        /// <summary>
        /// Deployment record details Create time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// List of deployment domain.
        /// </summary>
        public readonly ImmutableArray<string> Domains;
        /// <summary>
        /// TCB environment IDNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string EnvId;
        /// <summary>
        /// Deployment error messageNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ErrorMsg;
        /// <summary>
        /// Deployment record details ID.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Deployment instance ID.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Deployment example name.
        /// </summary>
        public readonly string InstanceName;
        /// <summary>
        /// Deployment monitor IDNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ListenerId;
        /// <summary>
        /// Delicate monitor name.
        /// </summary>
        public readonly string ListenerName;
        /// <summary>
        /// Named space nameNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Original binding certificate IDNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OldCertId;
        /// <summary>
        /// portNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Deployment monitoring protocolNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string Protocol;
        /// <summary>
        /// Deployed TCB regionNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string Region;
        /// <summary>
        /// Secret nameNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string SecretName;
        /// <summary>
        /// Whether to turn on SNI.
        /// </summary>
        public readonly int SniSwitch;
        /// <summary>
        /// Deployment state.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Deployed TCB typeNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string TcbType;
        /// <summary>
        /// Deployment record details last update time.
        /// </summary>
        public readonly string UpdateTime;

        [OutputConstructor]
        private GetDescribeHostDeployRecordDetailDeployRecordDetailListResult(
            string bucket,

            string certId,

            string createTime,

            ImmutableArray<string> domains,

            string envId,

            string errorMsg,

            int id,

            string instanceId,

            string instanceName,

            string listenerId,

            string listenerName,

            string @namespace,

            string oldCertId,

            int port,

            string protocol,

            string region,

            string secretName,

            int sniSwitch,

            int status,

            string tcbType,

            string updateTime)
        {
            Bucket = bucket;
            CertId = certId;
            CreateTime = createTime;
            Domains = domains;
            EnvId = envId;
            ErrorMsg = errorMsg;
            Id = id;
            InstanceId = instanceId;
            InstanceName = instanceName;
            ListenerId = listenerId;
            ListenerName = listenerName;
            Namespace = @namespace;
            OldCertId = oldCertId;
            Port = port;
            Protocol = protocol;
            Region = region;
            SecretName = secretName;
            SniSwitch = sniSwitch;
            Status = status;
            TcbType = tcbType;
            UpdateTime = updateTime;
        }
    }
}
