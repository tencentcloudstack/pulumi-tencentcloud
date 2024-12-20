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

    public sealed class ClusterExistInstanceInstancesParaMasterConfigExtraArgsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("kubelets")]
        private InputList<string>? _kubelets;

        /// <summary>
        /// Kubelet custom parameter. The parameter format is ["k1=v1", "k1=v2"].
        /// </summary>
        public InputList<string> Kubelets
        {
            get => _kubelets ?? (_kubelets = new InputList<string>());
            set => _kubelets = value;
        }

        public ClusterExistInstanceInstancesParaMasterConfigExtraArgsGetArgs()
        {
        }
        public static new ClusterExistInstanceInstancesParaMasterConfigExtraArgsGetArgs Empty => new ClusterExistInstanceInstancesParaMasterConfigExtraArgsGetArgs();
    }
}
