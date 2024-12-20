// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ccn
{
    /// <summary>
    /// Provides a resource to create a CCN Route table associate instance config.
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var config = new Config();
    ///     var region = config.Get("region") ?? "ap-guangzhou";
    ///     var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-4";
    ///     // create vpc
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "172.16.0.0/16",
    ///     });
    /// 
    ///     // create subnet
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         AvailabilityZone = availabilityZone,
    ///         VpcId = vpc.Id,
    ///         CidrBlock = "172.16.0.0/24",
    ///         IsMulticast = false,
    ///     });
    /// 
    ///     // create ccn
    ///     var exampleInstance = new Tencentcloud.Ccn.Instance("exampleInstance", new()
    ///     {
    ///         Description = "desc.",
    ///         Qos = "AG",
    ///         ChargeType = "PREPAID",
    ///         BandwidthLimitType = "INTER_REGION_LIMIT",
    ///         Tags = 
    ///         {
    ///             { "createBy", "terraform" },
    ///         },
    ///     });
    /// 
    ///     // create ccn route table
    ///     var exampleRouteTable = new Tencentcloud.Ccn.RouteTable("exampleRouteTable", new()
    ///     {
    ///         CcnId = exampleInstance.Id,
    ///         Description = "desc.",
    ///     });
    /// 
    ///     // attachment instance
    ///     var attachment = new Tencentcloud.Ccn.Attachment("attachment", new()
    ///     {
    ///         CcnId = exampleInstance.Id,
    ///         InstanceId = vpc.Id,
    ///         InstanceType = "VPC",
    ///         InstanceRegion = region,
    ///         RouteTableId = exampleRouteTable.Id,
    ///     });
    /// 
    ///     // route table associate instance
    ///     var exampleRouteTableAssociateInstanceConfig = new Tencentcloud.Ccn.RouteTableAssociateInstanceConfig("exampleRouteTableAssociateInstanceConfig", new()
    ///     {
    ///         CcnId = exampleInstance.Id,
    ///         RouteTableId = exampleRouteTable.Id,
    ///         Instances = new[]
    ///         {
    ///             new Tencentcloud.Ccn.Inputs.RouteTableAssociateInstanceConfigInstanceArgs
    ///             {
    ///                 InstanceId = vpc.Id,
    ///                 InstanceType = "VPC",
    ///             },
    ///         },
    ///     }, new CustomResourceOptions
    ///     {
    ///         DependsOn =
    ///         {
    ///             attachment, 
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// Ccn instance can be imported, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Ccn/routeTableAssociateInstanceConfig:RouteTableAssociateInstanceConfig example ccn-gr7nynbd#ccnrtb-jpf7bzn3
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Ccn/routeTableAssociateInstanceConfig:RouteTableAssociateInstanceConfig")]
    public partial class RouteTableAssociateInstanceConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// ID of the CCN.
        /// </summary>
        [Output("ccnId")]
        public Output<string> CcnId { get; private set; } = null!;

        /// <summary>
        /// Instances list.
        /// </summary>
        [Output("instances")]
        public Output<ImmutableArray<Outputs.RouteTableAssociateInstanceConfigInstance>> Instances { get; private set; } = null!;

        /// <summary>
        /// Ccn instance route table ID.
        /// </summary>
        [Output("routeTableId")]
        public Output<string> RouteTableId { get; private set; } = null!;


        /// <summary>
        /// Create a RouteTableAssociateInstanceConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RouteTableAssociateInstanceConfig(string name, RouteTableAssociateInstanceConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Ccn/routeTableAssociateInstanceConfig:RouteTableAssociateInstanceConfig", name, args ?? new RouteTableAssociateInstanceConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RouteTableAssociateInstanceConfig(string name, Input<string> id, RouteTableAssociateInstanceConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Ccn/routeTableAssociateInstanceConfig:RouteTableAssociateInstanceConfig", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RouteTableAssociateInstanceConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RouteTableAssociateInstanceConfig Get(string name, Input<string> id, RouteTableAssociateInstanceConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new RouteTableAssociateInstanceConfig(name, id, state, options);
        }
    }

    public sealed class RouteTableAssociateInstanceConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the CCN.
        /// </summary>
        [Input("ccnId", required: true)]
        public Input<string> CcnId { get; set; } = null!;

        [Input("instances", required: true)]
        private InputList<Inputs.RouteTableAssociateInstanceConfigInstanceArgs>? _instances;

        /// <summary>
        /// Instances list.
        /// </summary>
        public InputList<Inputs.RouteTableAssociateInstanceConfigInstanceArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.RouteTableAssociateInstanceConfigInstanceArgs>());
            set => _instances = value;
        }

        /// <summary>
        /// Ccn instance route table ID.
        /// </summary>
        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        public RouteTableAssociateInstanceConfigArgs()
        {
        }
        public static new RouteTableAssociateInstanceConfigArgs Empty => new RouteTableAssociateInstanceConfigArgs();
    }

    public sealed class RouteTableAssociateInstanceConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of the CCN.
        /// </summary>
        [Input("ccnId")]
        public Input<string>? CcnId { get; set; }

        [Input("instances")]
        private InputList<Inputs.RouteTableAssociateInstanceConfigInstanceGetArgs>? _instances;

        /// <summary>
        /// Instances list.
        /// </summary>
        public InputList<Inputs.RouteTableAssociateInstanceConfigInstanceGetArgs> Instances
        {
            get => _instances ?? (_instances = new InputList<Inputs.RouteTableAssociateInstanceConfigInstanceGetArgs>());
            set => _instances = value;
        }

        /// <summary>
        /// Ccn instance route table ID.
        /// </summary>
        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        public RouteTableAssociateInstanceConfigState()
        {
        }
        public static new RouteTableAssociateInstanceConfigState Empty => new RouteTableAssociateInstanceConfigState();
    }
}
