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
    /// Provides a resource to create a CCN Route table input policies.
    /// 
    /// &gt; **NOTE:** Use this resource to manage all input policies under the routing table of CCN instances.
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
    ///     // create route table input policy
    ///     var exampleRouteTableInputPolicies = new Tencentcloud.Ccn.RouteTableInputPolicies("exampleRouteTableInputPolicies", new()
    ///     {
    ///         CcnId = exampleInstance.Id,
    ///         RouteTableId = exampleRouteTable.Id,
    ///         Policies = new[]
    ///         {
    ///             new Tencentcloud.Ccn.Inputs.RouteTableInputPoliciesPolicyArgs
    ///             {
    ///                 Action = "accept",
    ///                 Description = "desc.",
    ///                 RouteConditions = new[]
    ///                 {
    ///                     new Tencentcloud.Ccn.Inputs.RouteTableInputPoliciesPolicyRouteConditionArgs
    ///                     {
    ///                         Name = "instance-region",
    ///                         Values = new[]
    ///                         {
    ///                             region,
    ///                         },
    ///                         MatchPattern = 1,
    ///                     },
    ///                 },
    ///             },
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
    /// $ pulumi import tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies example ccn-gr7nynbd#ccnrtb-jpf7bzn3
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies")]
    public partial class RouteTableInputPolicies : global::Pulumi.CustomResource
    {
        /// <summary>
        /// CCN Instance ID.
        /// </summary>
        [Output("ccnId")]
        public Output<string> CcnId { get; private set; } = null!;

        /// <summary>
        /// Routing reception strategy.
        /// </summary>
        [Output("policies")]
        public Output<ImmutableArray<Outputs.RouteTableInputPoliciesPolicy>> Policies { get; private set; } = null!;

        /// <summary>
        /// CCN Route table ID.
        /// </summary>
        [Output("routeTableId")]
        public Output<string> RouteTableId { get; private set; } = null!;


        /// <summary>
        /// Create a RouteTableInputPolicies resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RouteTableInputPolicies(string name, RouteTableInputPoliciesArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies", name, args ?? new RouteTableInputPoliciesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RouteTableInputPolicies(string name, Input<string> id, RouteTableInputPoliciesState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Ccn/routeTableInputPolicies:RouteTableInputPolicies", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RouteTableInputPolicies resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RouteTableInputPolicies Get(string name, Input<string> id, RouteTableInputPoliciesState? state = null, CustomResourceOptions? options = null)
        {
            return new RouteTableInputPolicies(name, id, state, options);
        }
    }

    public sealed class RouteTableInputPoliciesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CCN Instance ID.
        /// </summary>
        [Input("ccnId", required: true)]
        public Input<string> CcnId { get; set; } = null!;

        [Input("policies")]
        private InputList<Inputs.RouteTableInputPoliciesPolicyArgs>? _policies;

        /// <summary>
        /// Routing reception strategy.
        /// </summary>
        public InputList<Inputs.RouteTableInputPoliciesPolicyArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.RouteTableInputPoliciesPolicyArgs>());
            set => _policies = value;
        }

        /// <summary>
        /// CCN Route table ID.
        /// </summary>
        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        public RouteTableInputPoliciesArgs()
        {
        }
        public static new RouteTableInputPoliciesArgs Empty => new RouteTableInputPoliciesArgs();
    }

    public sealed class RouteTableInputPoliciesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// CCN Instance ID.
        /// </summary>
        [Input("ccnId")]
        public Input<string>? CcnId { get; set; }

        [Input("policies")]
        private InputList<Inputs.RouteTableInputPoliciesPolicyGetArgs>? _policies;

        /// <summary>
        /// Routing reception strategy.
        /// </summary>
        public InputList<Inputs.RouteTableInputPoliciesPolicyGetArgs> Policies
        {
            get => _policies ?? (_policies = new InputList<Inputs.RouteTableInputPoliciesPolicyGetArgs>());
            set => _policies = value;
        }

        /// <summary>
        /// CCN Route table ID.
        /// </summary>
        [Input("routeTableId")]
        public Input<string>? RouteTableId { get; set; }

        public RouteTableInputPoliciesState()
        {
        }
        public static new RouteTableInputPoliciesState Empty => new RouteTableInputPoliciesState();
    }
}