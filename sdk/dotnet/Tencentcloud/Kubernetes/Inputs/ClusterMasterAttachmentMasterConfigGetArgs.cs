// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Inputs
{

    public sealed class ClusterMasterAttachmentMasterConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configurations of data disk.
        /// </summary>
        [Input("dataDisk")]
        public Input<Inputs.ClusterMasterAttachmentMasterConfigDataDiskGetArgs>? DataDisk { get; set; }

        /// <summary>
        /// Indicate to set desired pod number in node. valid when the cluster is podCIDR.
        /// </summary>
        [Input("desiredPodNumber")]
        public Input<int>? DesiredPodNumber { get; set; }

        /// <summary>
        /// Docker graph path. Default is `/var/lib/docker`.
        /// </summary>
        [Input("dockerGraphPath")]
        public Input<string>? DockerGraphPath { get; set; }

        /// <summary>
        /// Custom parameter information related to the node. This is a white-list parameter.
        /// </summary>
        [Input("extraArgs")]
        public Input<Inputs.ClusterMasterAttachmentMasterConfigExtraArgsGetArgs>? ExtraArgs { get; set; }

        /// <summary>
        /// GPU driver parameters.
        /// </summary>
        [Input("gpuArgs")]
        public Input<Inputs.ClusterMasterAttachmentMasterConfigGpuArgsGetArgs>? GpuArgs { get; set; }

        [Input("labels")]
        private InputList<Inputs.ClusterMasterAttachmentMasterConfigLabelGetArgs>? _labels;

        /// <summary>
        /// Node label list.
        /// </summary>
        public InputList<Inputs.ClusterMasterAttachmentMasterConfigLabelGetArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.ClusterMasterAttachmentMasterConfigLabelGetArgs>());
            set => _labels = value;
        }

        /// <summary>
        /// Mount target. Default is not mounting.
        /// </summary>
        [Input("mountTarget")]
        public Input<string>? MountTarget { get; set; }

        [Input("taints")]
        private InputList<Inputs.ClusterMasterAttachmentMasterConfigTaintGetArgs>? _taints;

        /// <summary>
        /// Node taint.
        /// </summary>
        public InputList<Inputs.ClusterMasterAttachmentMasterConfigTaintGetArgs> Taints
        {
            get => _taints ?? (_taints = new InputList<Inputs.ClusterMasterAttachmentMasterConfigTaintGetArgs>());
            set => _taints = value;
        }

        /// <summary>
        /// Set whether the joined nodes participate in scheduling, with a default value of 0, indicating participation in scheduling; Non 0 means not participating in scheduling.
        /// </summary>
        [Input("unschedulable")]
        public Input<int>? Unschedulable { get; set; }

        /// <summary>
        /// User script encoded in base64, which will be executed after the k8s component runs. The user needs to ensure the script's reentrant and retry logic. The script and its generated log files can be viewed in the node path /data/ccs_userscript/. If the node needs to be initialized before joining the schedule, it can be used in conjunction with the `unschedulable` parameter. After the final initialization of the userScript is completed, add the command "kubectl uncordon nodename --kubeconfig=/root/.kube/config" to add the node to the schedule.
        /// </summary>
        [Input("userScript")]
        public Input<string>? UserScript { get; set; }

        public ClusterMasterAttachmentMasterConfigGetArgs()
        {
        }
        public static new ClusterMasterAttachmentMasterConfigGetArgs Empty => new ClusterMasterAttachmentMasterConfigGetArgs();
    }
}