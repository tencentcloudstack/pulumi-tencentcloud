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

    public sealed class NativeNodePoolTagArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resource type bound to the label.
        /// </summary>
        [Input("resourceType")]
        public Input<string>? ResourceType { get; set; }

        [Input("tags")]
        private InputList<Inputs.NativeNodePoolTagTagArgs>? _tags;

        /// <summary>
        /// Tag pair list.
        /// </summary>
        public InputList<Inputs.NativeNodePoolTagTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.NativeNodePoolTagTagArgs>());
            set => _tags = value;
        }

        public NativeNodePoolTagArgs()
        {
        }
        public static new NativeNodePoolTagArgs Empty => new NativeNodePoolTagArgs();
    }
}
