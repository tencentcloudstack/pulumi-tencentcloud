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

    public sealed class ClusterMasterAttachmentExtraArgsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("etcds")]
        private InputList<string>? _etcds;

        /// <summary>
        /// etcd custom parameters. Only supports independent clusters.
        /// </summary>
        public InputList<string> Etcds
        {
            get => _etcds ?? (_etcds = new InputList<string>());
            set => _etcds = value;
        }

        [Input("kubeApiServers")]
        private InputList<string>? _kubeApiServers;

        /// <summary>
        /// Kube apiserver custom parameters. The parameter format is ["k1=v1", "k1=v2"].
        /// </summary>
        public InputList<string> KubeApiServers
        {
            get => _kubeApiServers ?? (_kubeApiServers = new InputList<string>());
            set => _kubeApiServers = value;
        }

        [Input("kubeControllerManagers")]
        private InputList<string>? _kubeControllerManagers;

        /// <summary>
        /// Kube controller manager custom parameters.
        /// </summary>
        public InputList<string> KubeControllerManagers
        {
            get => _kubeControllerManagers ?? (_kubeControllerManagers = new InputList<string>());
            set => _kubeControllerManagers = value;
        }

        [Input("kubeSchedulers")]
        private InputList<string>? _kubeSchedulers;

        /// <summary>
        /// kube scheduler custom parameters.
        /// </summary>
        public InputList<string> KubeSchedulers
        {
            get => _kubeSchedulers ?? (_kubeSchedulers = new InputList<string>());
            set => _kubeSchedulers = value;
        }

        public ClusterMasterAttachmentExtraArgsGetArgs()
        {
        }
        public static new ClusterMasterAttachmentExtraArgsGetArgs Empty => new ClusterMasterAttachmentExtraArgsGetArgs();
    }
}
