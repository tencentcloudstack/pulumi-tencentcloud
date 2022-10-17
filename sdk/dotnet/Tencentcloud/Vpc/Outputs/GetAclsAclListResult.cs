// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetAclsAclListResult
    {
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Outbound rules of the network ACL.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAclsAclListEgressResult> Egresses;
        /// <summary>
        /// ID of the network ACL instance.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Inbound rules of the network ACL.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAclsAclListIngressResult> Ingresses;
        /// <summary>
        /// Name of the network ACL.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Subnets associated with the network ACL.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAclsAclListSubnetResult> Subnets;
        /// <summary>
        /// ID of the VPC instance.
        /// </summary>
        public readonly string VpcId;

        [OutputConstructor]
        private GetAclsAclListResult(
            string createTime,

            ImmutableArray<Outputs.GetAclsAclListEgressResult> egresses,

            string id,

            ImmutableArray<Outputs.GetAclsAclListIngressResult> ingresses,

            string name,

            ImmutableArray<Outputs.GetAclsAclListSubnetResult> subnets,

            string vpcId)
        {
            CreateTime = createTime;
            Egresses = egresses;
            Id = id;
            Ingresses = ingresses;
            Name = name;
            Subnets = subnets;
            VpcId = vpcId;
        }
    }
}