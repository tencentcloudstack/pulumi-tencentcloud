// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetSubnets
    {
        /// <summary>
        /// Use this data source to query vpc subnets information.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var config = new Config();
        ///         var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-3";
        ///         var foo = new Tencentcloud.Vpc.Instance("foo", new Tencentcloud.Vpc.InstanceArgs
        ///         {
        ///             CidrBlock = "10.0.0.0/16",
        ///         });
        ///         var subnet = new Tencentcloud.Subnet.Instance("subnet", new Tencentcloud.Subnet.InstanceArgs
        ///         {
        ///             AvailabilityZone = availabilityZone,
        ///             VpcId = foo.Id,
        ///             CidrBlock = "10.0.20.0/28",
        ///             IsMulticast = false,
        ///             Tags = 
        ///             {
        ///                 { "test", "test" },
        ///             },
        ///         });
        ///         var idInstances = Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             SubnetId = subnet.Id,
        ///         });
        ///         var nameInstances = Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             Name = subnet.Name,
        ///         });
        ///         var tagsInstances = subnet.Tags.Apply(tags =&gt; Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             Tags = tags,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSubnetsResult> InvokeAsync(GetSubnetsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSubnetsResult>("tencentcloud:Vpc/getSubnets:getSubnets", args ?? new GetSubnetsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query vpc subnets information.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var config = new Config();
        ///         var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-3";
        ///         var foo = new Tencentcloud.Vpc.Instance("foo", new Tencentcloud.Vpc.InstanceArgs
        ///         {
        ///             CidrBlock = "10.0.0.0/16",
        ///         });
        ///         var subnet = new Tencentcloud.Subnet.Instance("subnet", new Tencentcloud.Subnet.InstanceArgs
        ///         {
        ///             AvailabilityZone = availabilityZone,
        ///             VpcId = foo.Id,
        ///             CidrBlock = "10.0.20.0/28",
        ///             IsMulticast = false,
        ///             Tags = 
        ///             {
        ///                 { "test", "test" },
        ///             },
        ///         });
        ///         var idInstances = Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             SubnetId = subnet.Id,
        ///         });
        ///         var nameInstances = Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             Name = subnet.Name,
        ///         });
        ///         var tagsInstances = subnet.Tags.Apply(tags =&gt; Tencentcloud.Vpc.GetSubnets.Invoke(new Tencentcloud.Vpc.GetSubnetsInvokeArgs
        ///         {
        ///             Tags = tags,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSubnetsResult> Invoke(GetSubnetsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSubnetsResult>("tencentcloud:Vpc/getSubnets:getSubnets", args ?? new GetSubnetsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSubnetsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Zone of the subnet to be queried.
        /// </summary>
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        /// <summary>
        /// Filter subnet with this CIDR.
        /// </summary>
        [Input("cidrBlock")]
        public string? CidrBlock { get; set; }

        /// <summary>
        /// Filter default or no default subnets.
        /// </summary>
        [Input("isDefault")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Filter the VPC SNAT address pool subnet.
        /// </summary>
        [Input("isRemoteVpcSnat")]
        public bool? IsRemoteVpcSnat { get; set; }

        /// <summary>
        /// Name of the subnet to be queried.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of the subnet to be queried.
        /// </summary>
        [Input("subnetId")]
        public string? SubnetId { get; set; }

        /// <summary>
        /// Filter if subnet has this tag.
        /// </summary>
        [Input("tagKey")]
        public string? TagKey { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;

        /// <summary>
        /// Tags of the subnet to be queried.
        /// </summary>
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the VPC to be queried.
        /// </summary>
        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetSubnetsArgs()
        {
        }
    }

    public sealed class GetSubnetsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Zone of the subnet to be queried.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// Filter subnet with this CIDR.
        /// </summary>
        [Input("cidrBlock")]
        public Input<string>? CidrBlock { get; set; }

        /// <summary>
        /// Filter default or no default subnets.
        /// </summary>
        [Input("isDefault")]
        public Input<bool>? IsDefault { get; set; }

        /// <summary>
        /// Filter the VPC SNAT address pool subnet.
        /// </summary>
        [Input("isRemoteVpcSnat")]
        public Input<bool>? IsRemoteVpcSnat { get; set; }

        /// <summary>
        /// Name of the subnet to be queried.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of the subnet to be queried.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// Filter if subnet has this tag.
        /// </summary>
        [Input("tagKey")]
        public Input<string>? TagKey { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tags of the subnet to be queried.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the VPC to be queried.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public GetSubnetsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSubnetsResult
    {
        /// <summary>
        /// The availability zone of the subnet.
        /// </summary>
        public readonly string? AvailabilityZone;
        /// <summary>
        /// A network address block of the subnet.
        /// </summary>
        public readonly string? CidrBlock;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// List of subnets.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSubnetsInstanceListResult> InstanceLists;
        /// <summary>
        /// Indicates whether it is the default subnet of the VPC for this region.
        /// </summary>
        public readonly bool? IsDefault;
        public readonly bool? IsRemoteVpcSnat;
        /// <summary>
        /// Name of the subnet.
        /// </summary>
        public readonly string? Name;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// ID of the subnet.
        /// </summary>
        public readonly string? SubnetId;
        public readonly string? TagKey;
        /// <summary>
        /// Tags of the subnet resource.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Tags;
        /// <summary>
        /// ID of the VPC.
        /// </summary>
        public readonly string? VpcId;

        [OutputConstructor]
        private GetSubnetsResult(
            string? availabilityZone,

            string? cidrBlock,

            string id,

            ImmutableArray<Outputs.GetSubnetsInstanceListResult> instanceLists,

            bool? isDefault,

            bool? isRemoteVpcSnat,

            string? name,

            string? resultOutputFile,

            string? subnetId,

            string? tagKey,

            ImmutableDictionary<string, object>? tags,

            string? vpcId)
        {
            AvailabilityZone = availabilityZone;
            CidrBlock = cidrBlock;
            Id = id;
            InstanceLists = instanceLists;
            IsDefault = isDefault;
            IsRemoteVpcSnat = isRemoteVpcSnat;
            Name = name;
            ResultOutputFile = resultOutputFile;
            SubnetId = subnetId;
            TagKey = tagKey;
            Tags = tags;
            VpcId = vpcId;
        }
    }
}