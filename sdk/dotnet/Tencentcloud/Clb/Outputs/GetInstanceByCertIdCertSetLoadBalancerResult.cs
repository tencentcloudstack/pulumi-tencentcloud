// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetInstanceByCertIdCertSetLoadBalancerResult
    {
        /// <summary>
        /// IP version. Valid values: ipv4, ipv6. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string AddressIPVersion;
        /// <summary>
        /// IPv6 address of a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string AddressIPv6;
        /// <summary>
        /// Anycast CLB publishing region. For non-anycast CLB, this field returns an empty string. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string AnycastZone;
        /// <summary>
        /// Cluster ID.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> AttributeFlags;
        /// <summary>
        /// backup zone.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerBackupZoneSetResult> BackupZoneSets;
        /// <summary>
        /// Billing mode of CLB instance. Valid values: PREPAID (monthly subscription), POSTPAID_BY_HOUR (pay as you go). Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ChargeType;
        /// <summary>
        /// Cluster ID. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> ClusterIds;
        /// <summary>
        /// Dedicated layer-7 tag. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ClusterTag;
        /// <summary>
        /// Custom configuration ID at the CLB instance level. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ConfigId;
        /// <summary>
        /// CLB instance creation time. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Domain name of the CLB instance. It is only available for public classic CLBs. This parameter will be discontinued soon. Please use LoadBalancerDomain instead. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// Private network dedicated cluster. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerExclusiveClusterResult> ExclusiveClusters;
        /// <summary>
        /// CLB instance expiration time, which takes effect only for prepaid instances. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string ExpireTime;
        /// <summary>
        /// Reserved field which can be ignored generally.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerExtraInfoResult> ExtraInfos;
        /// <summary>
        /// CLB type identifier. Value range: 1 (CLB); 0 (classic CLB).
        /// </summary>
        public readonly int Forward;
        /// <summary>
        /// Health check logset ID of CLB CLS. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string HealthLogSetId;
        /// <summary>
        /// Health check log topic ID of CLB CLS. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string HealthLogTopicId;
        /// <summary>
        /// This field is meaningful only when the IP address version is ipv6. Valid values: IPv6Nat64, IPv6FullChain. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Ipv6Mode;
        /// <summary>
        /// Whether VIP is blocked. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool IsBlock;
        /// <summary>
        /// Time blocked or unblocked. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string IsBlockTime;
        /// <summary>
        /// Whether an Anti-DDoS Pro instance can be bound. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool IsDdos;
        /// <summary>
        /// CLB instance isolation time. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string IsolatedTime;
        /// <summary>
        /// 0: not isolated; 1: isolated. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int Isolation;
        /// <summary>
        /// Domain name of the CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string LoadBalancerDomain;
        /// <summary>
        /// CLB instance ID.
        /// </summary>
        public readonly string LoadBalancerId;
        /// <summary>
        /// CLB instance name.
        /// </summary>
        public readonly string LoadBalancerName;
        /// <summary>
        /// Whether a real server opens the traffic from a CLB instance to the internet. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool LoadBalancerPassToTarget;
        /// <summary>
        /// CLB instance network type:OPEN: public network; INTERNAL: private network.
        /// </summary>
        public readonly string LoadBalancerType;
        /// <summary>
        /// List of VIPs of a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> LoadBalancerVips;
        /// <summary>
        /// Whether the IP type is the local BGP.
        /// </summary>
        public readonly bool LocalBgp;
        /// <summary>
        /// Log information. Only the public network CLB that have HTTP or HTTPS listeners can generate logs. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string Log;
        /// <summary>
        /// Logset ID of CLB Log Service (CLS). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string LogSetId;
        /// <summary>
        /// Log topic ID of CLB Log Service (CLS). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string LogTopicId;
        /// <summary>
        /// Primary AZ. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerMasterZoneResult> MasterZones;
        /// <summary>
        /// If the layer-7 listener of an IPv6FullChain CLB instance is enabled, the CLB instance can be bound with an IPv4 and an IPv6 CVM instance simultaneously. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool MixIpTarget;
        /// <summary>
        /// CLB instance network attributes. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerNetworkAttributeResult> NetworkAttributes;
        /// <summary>
        /// Whether it is an NFV CLB instance. No returned information: no; l7nfv: yes. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string NfvInfo;
        /// <summary>
        /// VPC ID in a numeric form. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int NumericalVpcId;
        /// <summary>
        /// Protective CLB identifier. Value range: 1 (protective), 0 (non-protective). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int OpenBgp;
        /// <summary>
        /// Prepaid billing attributes of a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerPrepaidAttributeResult> PrepaidAttributes;
        /// <summary>
        /// ID of the project to which a CLB instance belongs. 0: default project.
        /// </summary>
        public readonly int ProjectId;
        /// <summary>
        /// Security group of a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> SecureGroups;
        /// <summary>
        /// Specification of the LCU-supported instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string SlaType;
        /// <summary>
        /// SNAT is enabled for all private network classic CLB created before December 2016. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool Snat;
        /// <summary>
        /// SnatIp list after SnatPro load balancing is enabled. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerSnatIpResult> SnatIps;
        /// <summary>
        /// Whether to enable SnatPro. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly bool SnatPro;
        /// <summary>
        /// CLB instance status, including:0: creating; 1: running. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Last status change time of a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string StatusTime;
        /// <summary>
        /// Subnet where a CLB instance resides (meaningful only for private network VPC CLB). Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string SubnetId;
        /// <summary>
        /// CLB instance tag information. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerTagResult> Tags;
        /// <summary>
        /// Basic information of a backend server bound to a CLB instance. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerTargetRegionInfoResult> TargetRegionInfos;
        /// <summary>
        /// ISP to which a CLB IP address belongs. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string VipIsp;
        /// <summary>
        /// VPC ID Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string VpcId;
        /// <summary>
        /// Availability zone of a VPC-based private network CLB instance. Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetInstanceByCertIdCertSetLoadBalancerResult(
            string addressIPVersion,

            string addressIPv6,

            string anycastZone,

            ImmutableArray<string> attributeFlags,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerBackupZoneSetResult> backupZoneSets,

            string chargeType,

            ImmutableArray<string> clusterIds,

            string clusterTag,

            string configId,

            string createTime,

            string domain,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerExclusiveClusterResult> exclusiveClusters,

            string expireTime,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerExtraInfoResult> extraInfos,

            int forward,

            string healthLogSetId,

            string healthLogTopicId,

            string ipv6Mode,

            bool isBlock,

            string isBlockTime,

            bool isDdos,

            string isolatedTime,

            int isolation,

            string loadBalancerDomain,

            string loadBalancerId,

            string loadBalancerName,

            bool loadBalancerPassToTarget,

            string loadBalancerType,

            ImmutableArray<string> loadBalancerVips,

            bool localBgp,

            string log,

            string logSetId,

            string logTopicId,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerMasterZoneResult> masterZones,

            bool mixIpTarget,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerNetworkAttributeResult> networkAttributes,

            string nfvInfo,

            int numericalVpcId,

            int openBgp,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerPrepaidAttributeResult> prepaidAttributes,

            int projectId,

            ImmutableArray<string> secureGroups,

            string slaType,

            bool snat,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerSnatIpResult> snatIps,

            bool snatPro,

            int status,

            string statusTime,

            string subnetId,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerTagResult> tags,

            ImmutableArray<Outputs.GetInstanceByCertIdCertSetLoadBalancerTargetRegionInfoResult> targetRegionInfos,

            string vipIsp,

            string vpcId,

            ImmutableArray<string> zones)
        {
            AddressIPVersion = addressIPVersion;
            AddressIPv6 = addressIPv6;
            AnycastZone = anycastZone;
            AttributeFlags = attributeFlags;
            BackupZoneSets = backupZoneSets;
            ChargeType = chargeType;
            ClusterIds = clusterIds;
            ClusterTag = clusterTag;
            ConfigId = configId;
            CreateTime = createTime;
            Domain = domain;
            ExclusiveClusters = exclusiveClusters;
            ExpireTime = expireTime;
            ExtraInfos = extraInfos;
            Forward = forward;
            HealthLogSetId = healthLogSetId;
            HealthLogTopicId = healthLogTopicId;
            Ipv6Mode = ipv6Mode;
            IsBlock = isBlock;
            IsBlockTime = isBlockTime;
            IsDdos = isDdos;
            IsolatedTime = isolatedTime;
            Isolation = isolation;
            LoadBalancerDomain = loadBalancerDomain;
            LoadBalancerId = loadBalancerId;
            LoadBalancerName = loadBalancerName;
            LoadBalancerPassToTarget = loadBalancerPassToTarget;
            LoadBalancerType = loadBalancerType;
            LoadBalancerVips = loadBalancerVips;
            LocalBgp = localBgp;
            Log = log;
            LogSetId = logSetId;
            LogTopicId = logTopicId;
            MasterZones = masterZones;
            MixIpTarget = mixIpTarget;
            NetworkAttributes = networkAttributes;
            NfvInfo = nfvInfo;
            NumericalVpcId = numericalVpcId;
            OpenBgp = openBgp;
            PrepaidAttributes = prepaidAttributes;
            ProjectId = projectId;
            SecureGroups = secureGroups;
            SlaType = slaType;
            Snat = snat;
            SnatIps = snatIps;
            SnatPro = snatPro;
            Status = status;
            StatusTime = statusTime;
            SubnetId = subnetId;
            Tags = tags;
            TargetRegionInfos = targetRegionInfos;
            VipIsp = vipIsp;
            VpcId = vpcId;
            Zones = zones;
        }
    }
}