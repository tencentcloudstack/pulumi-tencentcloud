// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class DeployContainerGroupServiceSetting
    {
        /// <summary>
        /// 0: Public network, 1: Access within the cluster, 2: NodePort, 3: Access within VPC. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int AccessType;
        /// <summary>
        /// When set to true and DisableService is also true, the previously created service will be deleted. Please use with caution. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool? AllowDeleteService;
        /// <summary>
        /// Whether to create a Kubernetes service. The default value is false. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool? DisableService;
        /// <summary>
        /// Whether the service is of headless type. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool? HeadlessService;
        /// <summary>
        /// Enable session affinity. true means enabled, false means disabled. The default value is false. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool? OpenSessionAffinity;
        /// <summary>
        /// Container port mapping. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.DeployContainerGroupServiceSettingProtocolPort> ProtocolPorts;
        /// <summary>
        /// Session affinity session time. The default value is 10800. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int? SessionAffinityTimeoutSeconds;
        /// <summary>
        /// subnet Id.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private DeployContainerGroupServiceSetting(
            int accessType,

            bool? allowDeleteService,

            bool? disableService,

            bool? headlessService,

            bool? openSessionAffinity,

            ImmutableArray<Outputs.DeployContainerGroupServiceSettingProtocolPort> protocolPorts,

            int? sessionAffinityTimeoutSeconds,

            string subnetId)
        {
            AccessType = accessType;
            AllowDeleteService = allowDeleteService;
            DisableService = disableService;
            HeadlessService = headlessService;
            OpenSessionAffinity = openSessionAffinity;
            ProtocolPorts = protocolPorts;
            SessionAffinityTimeoutSeconds = sessionAffinityTimeoutSeconds;
            SubnetId = subnetId;
        }
    }
}
