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
    /// <summary>
    /// Provide a resource to create a VPC ACL instance.
    /// 
    /// ## Example Usage
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
    ///         var @default = Output.Create(Tencentcloud.Vpc.GetInstances.InvokeAsync());
    ///         var foo = new Tencentcloud.Vpc.Acl("foo", new Tencentcloud.Vpc.AclArgs
    ///         {
    ///             VpcId = @default.Apply(@default =&gt; @default.InstanceLists?[0]?.VpcId),
    ///             Ingresses = 
    ///             {
    ///                 "ACCEPT#192.168.1.0/24#800#TCP",
    ///                 "ACCEPT#192.168.1.0/24#800-900#TCP",
    ///             },
    ///             Egresses = 
    ///             {
    ///                 "ACCEPT#192.168.1.0/24#800#TCP",
    ///                 "ACCEPT#192.168.1.0/24#800-900#TCP",
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// Vpc ACL can be imported, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Vpc/acl:Acl default acl-id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Vpc/acl:Acl")]
    public partial class Acl : Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time of ACL.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Egress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        [Output("egresses")]
        public Output<ImmutableArray<string>> Egresses { get; private set; } = null!;

        /// <summary>
        /// Ingress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        [Output("ingresses")]
        public Output<ImmutableArray<string>> Ingresses { get; private set; } = null!;

        /// <summary>
        /// Name of the network ACL.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// ID of the VPC instance.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a Acl resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Acl(string name, AclArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/acl:Acl", name, args ?? new AclArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Acl(string name, Input<string> id, AclState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/acl:Acl", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Acl resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Acl Get(string name, Input<string> id, AclState? state = null, CustomResourceOptions? options = null)
        {
            return new Acl(name, id, state, options);
        }
    }

    public sealed class AclArgs : Pulumi.ResourceArgs
    {
        [Input("egresses")]
        private InputList<string>? _egresses;

        /// <summary>
        /// Egress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        public InputList<string> Egresses
        {
            get => _egresses ?? (_egresses = new InputList<string>());
            set => _egresses = value;
        }

        [Input("ingresses")]
        private InputList<string>? _ingresses;

        /// <summary>
        /// Ingress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        public InputList<string> Ingresses
        {
            get => _ingresses ?? (_ingresses = new InputList<string>());
            set => _ingresses = value;
        }

        /// <summary>
        /// Name of the network ACL.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the VPC instance.
        /// </summary>
        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public AclArgs()
        {
        }
    }

    public sealed class AclState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation time of ACL.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        [Input("egresses")]
        private InputList<string>? _egresses;

        /// <summary>
        /// Egress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        public InputList<string> Egresses
        {
            get => _egresses ?? (_egresses = new InputList<string>());
            set => _egresses = value;
        }

        [Input("ingresses")]
        private InputList<string>? _ingresses;

        /// <summary>
        /// Ingress rules. A rule must match the following format: [action]#[cidr_ip]#[port]#[protocol]. The available value of 'action' is `ACCEPT` and `DROP`. The 'cidr_ip' must be an IP address network or segment. The 'port' valid format is `80`, `80,443`, `80-90` or `ALL`. The available value of 'protocol' is `TCP`, `UDP`, `ICMP` and `ALL`. When 'protocol' is `ICMP` or `ALL`, the 'port' must be `ALL`.
        /// </summary>
        public InputList<string> Ingresses
        {
            get => _ingresses ?? (_ingresses = new InputList<string>());
            set => _ingresses = value;
        }

        /// <summary>
        /// Name of the network ACL.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the VPC instance.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public AclState()
        {
        }
    }
}