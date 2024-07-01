// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class GetClusterNativeNodePoolsNodePoolResult
    {
        /// <summary>
        /// Node Annotation List.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolAnnotationResult> Annotations;
        /// <summary>
        /// ID of the cluster.
        /// </summary>
        public readonly string ClusterId;
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly string CreatedAt;
        /// <summary>
        /// Whether to enable deletion protection.
        /// </summary>
        public readonly bool DeletionProtection;
        /// <summary>
        /// Node Labels.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolLabelResult> Labels;
        /// <summary>
        /// Node pool status.
        /// </summary>
        public readonly string LifeState;
        /// <summary>
        /// The attribute name, if there are multiple filters, the relationship between the filters is a logical AND relationship.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Native node pool creation parameters.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolNativeResult> Natives;
        /// <summary>
        /// ID of the node pool.
        /// </summary>
        public readonly string NodePoolId;
        /// <summary>
        /// Tag pair list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolTagResult> Tags;
        /// <summary>
        /// node taint.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolTaintResult> Taints;
        /// <summary>
        /// Node pool type. Optional value is `Native`.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Whether the node is not schedulable by default.
        /// </summary>
        public readonly bool Unschedulable;

        [OutputConstructor]
        private GetClusterNativeNodePoolsNodePoolResult(
            ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolAnnotationResult> annotations,

            string clusterId,

            string createdAt,

            bool deletionProtection,

            ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolLabelResult> labels,

            string lifeState,

            string name,

            ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolNativeResult> natives,

            string nodePoolId,

            ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolTagResult> tags,

            ImmutableArray<Outputs.GetClusterNativeNodePoolsNodePoolTaintResult> taints,

            string type,

            bool unschedulable)
        {
            Annotations = annotations;
            ClusterId = clusterId;
            CreatedAt = createdAt;
            DeletionProtection = deletionProtection;
            Labels = labels;
            LifeState = lifeState;
            Name = name;
            Natives = natives;
            NodePoolId = nodePoolId;
            Tags = tags;
            Taints = taints;
            Type = type;
            Unschedulable = unschedulable;
        }
    }
}