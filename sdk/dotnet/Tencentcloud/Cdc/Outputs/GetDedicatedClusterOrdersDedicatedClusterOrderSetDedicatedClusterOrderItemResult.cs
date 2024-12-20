// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdc.Outputs
{

    [OutputType]
    public sealed class GetDedicatedClusterOrdersDedicatedClusterOrderSetDedicatedClusterOrderItemResult
    {
        /// <summary>
        /// Dedicated Cluster Compute Format.
        /// </summary>
        public readonly string ComputeFormat;
        /// <summary>
        /// Dedicated Cluster SubOrder Count.
        /// </summary>
        public readonly int Count;
        /// <summary>
        /// Dedicated Cluster Order Create time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Dedicated Cluster Type ID.
        /// </summary>
        public readonly string DedicatedClusterTypeId;
        /// <summary>
        /// Dedicated Cluster Type Description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Dedicated Cluster Type Name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Dedicated Cluster Supported PowerDraw.
        /// </summary>
        public readonly double PowerDraw;
        /// <summary>
        /// Dedicated Cluster SubOrder ID.
        /// </summary>
        public readonly string SubOrderId;
        /// <summary>
        /// Dedicated Cluster SubOrder Pay Status.
        /// </summary>
        public readonly int SubOrderPayStatus;
        /// <summary>
        /// Dedicated Cluster Order Status.
        /// </summary>
        public readonly string SubOrderStatus;
        /// <summary>
        /// Dedicated Cluster Supported Instance Family.
        /// </summary>
        public readonly ImmutableArray<string> SupportedInstanceFamilies;
        /// <summary>
        /// Dedicated Cluster Storage Type.
        /// </summary>
        public readonly ImmutableArray<string> SupportedStorageTypes;
        /// <summary>
        /// Dedicated Cluster Supported Uplink Speed.
        /// </summary>
        public readonly ImmutableArray<int> SupportedUplinkSpeeds;
        /// <summary>
        /// Dedicated Cluster Total CPU.
        /// </summary>
        public readonly int TotalCpu;
        /// <summary>
        /// Dedicated Cluster Total GPU.
        /// </summary>
        public readonly int TotalGpu;
        /// <summary>
        /// Dedicated Cluster Total Memory.
        /// </summary>
        public readonly int TotalMem;
        /// <summary>
        /// Dedicated Cluster Type Family.
        /// </summary>
        public readonly string TypeFamily;
        /// <summary>
        /// Dedicated Cluster Type Name.
        /// </summary>
        public readonly string TypeName;
        /// <summary>
        /// Dedicated Cluster Supported Weight.
        /// </summary>
        public readonly int Weight;

        [OutputConstructor]
        private GetDedicatedClusterOrdersDedicatedClusterOrderSetDedicatedClusterOrderItemResult(
            string computeFormat,

            int count,

            string createTime,

            string dedicatedClusterTypeId,

            string description,

            string name,

            double powerDraw,

            string subOrderId,

            int subOrderPayStatus,

            string subOrderStatus,

            ImmutableArray<string> supportedInstanceFamilies,

            ImmutableArray<string> supportedStorageTypes,

            ImmutableArray<int> supportedUplinkSpeeds,

            int totalCpu,

            int totalGpu,

            int totalMem,

            string typeFamily,

            string typeName,

            int weight)
        {
            ComputeFormat = computeFormat;
            Count = count;
            CreateTime = createTime;
            DedicatedClusterTypeId = dedicatedClusterTypeId;
            Description = description;
            Name = name;
            PowerDraw = powerDraw;
            SubOrderId = subOrderId;
            SubOrderPayStatus = subOrderPayStatus;
            SubOrderStatus = subOrderStatus;
            SupportedInstanceFamilies = supportedInstanceFamilies;
            SupportedStorageTypes = supportedStorageTypes;
            SupportedUplinkSpeeds = supportedUplinkSpeeds;
            TotalCpu = totalCpu;
            TotalGpu = totalGpu;
            TotalMem = totalMem;
            TypeFamily = typeFamily;
            TypeName = typeName;
            Weight = weight;
        }
    }
}
