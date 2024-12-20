// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfw.Outputs
{

    [OutputType]
    public sealed class VpcInstanceVpcFwInstance
    {
        /// <summary>
        /// Deploy regional information.
        /// </summary>
        public readonly Outputs.VpcInstanceVpcFwInstanceFwDeploy FwDeploy;
        /// <summary>
        /// Firewall instance ID (passed in editing scenario).
        /// </summary>
        public readonly string? FwInsId;
        /// <summary>
        /// Firewall instance name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of VpcIds accessed in private network mode; only used in private network mode.
        /// </summary>
        public readonly ImmutableArray<string> VpcIds;

        [OutputConstructor]
        private VpcInstanceVpcFwInstance(
            Outputs.VpcInstanceVpcFwInstanceFwDeploy fwDeploy,

            string? fwInsId,

            string name,

            ImmutableArray<string> vpcIds)
        {
            FwDeploy = fwDeploy;
            FwInsId = fwInsId;
            Name = name;
            VpcIds = vpcIds;
        }
    }
}
