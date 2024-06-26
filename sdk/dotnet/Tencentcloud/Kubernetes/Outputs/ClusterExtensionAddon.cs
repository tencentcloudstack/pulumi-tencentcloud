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
    public sealed class ClusterExtensionAddon
    {
        /// <summary>
        /// Add-on name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Parameter of the add-on resource object in JSON string format, please check the example at the top of page for reference.
        /// </summary>
        public readonly string Param;

        [OutputConstructor]
        private ClusterExtensionAddon(
            string name,

            string param)
        {
            Name = name;
            Param = param;
        }
    }
}
