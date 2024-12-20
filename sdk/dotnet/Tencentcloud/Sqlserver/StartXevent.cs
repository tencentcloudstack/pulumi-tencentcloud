// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sqlserver
{
    /// <summary>
    /// Provides a resource to create a sqlserver start_xevent
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = Pulumi.Tencentcloud;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var zones = Tencentcloud.Availability.GetZonesByProduct.Invoke(new()
    ///     {
    ///         Product = "sqlserver",
    ///     });
    /// 
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[4]?.Name),
    ///         VpcId = vpc.Id,
    ///         CidrBlock = "10.0.0.0/16",
    ///         IsMulticast = false,
    ///     });
    /// 
    ///     var securityGroup = new Tencentcloud.Security.Group("securityGroup", new()
    ///     {
    ///         Description = "desc.",
    ///     });
    /// 
    ///     var exampleBasicInstance = new Tencentcloud.Sqlserver.BasicInstance("exampleBasicInstance", new()
    ///     {
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[4]?.Name),
    ///         ChargeType = "POSTPAID_BY_HOUR",
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///         ProjectId = 0,
    ///         Memory = 4,
    ///         Storage = 100,
    ///         Cpu = 2,
    ///         MachineType = "CLOUD_PREMIUM",
    ///         MaintenanceWeekSets = new[]
    ///         {
    ///             1,
    ///             2,
    ///             3,
    ///         },
    ///         MaintenanceStartTime = "09:00",
    ///         MaintenanceTimeSpan = 3,
    ///         SecurityGroups = new[]
    ///         {
    ///             securityGroup.Id,
    ///         },
    ///         Tags = 
    ///         {
    ///             { "test", "test" },
    ///         },
    ///     });
    /// 
    ///     var exampleStartXevent = new Tencentcloud.Sqlserver.StartXevent("exampleStartXevent", new()
    ///     {
    ///         InstanceId = exampleBasicInstance.Id,
    ///         EventConfigs = new[]
    ///         {
    ///             new Tencentcloud.Sqlserver.Inputs.StartXeventEventConfigArgs
    ///             {
    ///                 EventType = "slow",
    ///                 Threshold = 0,
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Sqlserver/startXevent:StartXevent")]
    public partial class StartXevent : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Whether to start or stop an extended event.
        /// </summary>
        [Output("eventConfigs")]
        public Output<ImmutableArray<Outputs.StartXeventEventConfig>> EventConfigs { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;


        /// <summary>
        /// Create a StartXevent resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StartXevent(string name, StartXeventArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/startXevent:StartXevent", name, args ?? new StartXeventArgs(), MakeResourceOptions(options, ""))
        {
        }

        private StartXevent(string name, Input<string> id, StartXeventState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/startXevent:StartXevent", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing StartXevent resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StartXevent Get(string name, Input<string> id, StartXeventState? state = null, CustomResourceOptions? options = null)
        {
            return new StartXevent(name, id, state, options);
        }
    }

    public sealed class StartXeventArgs : global::Pulumi.ResourceArgs
    {
        [Input("eventConfigs", required: true)]
        private InputList<Inputs.StartXeventEventConfigArgs>? _eventConfigs;

        /// <summary>
        /// Whether to start or stop an extended event.
        /// </summary>
        public InputList<Inputs.StartXeventEventConfigArgs> EventConfigs
        {
            get => _eventConfigs ?? (_eventConfigs = new InputList<Inputs.StartXeventEventConfigArgs>());
            set => _eventConfigs = value;
        }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public StartXeventArgs()
        {
        }
        public static new StartXeventArgs Empty => new StartXeventArgs();
    }

    public sealed class StartXeventState : global::Pulumi.ResourceArgs
    {
        [Input("eventConfigs")]
        private InputList<Inputs.StartXeventEventConfigGetArgs>? _eventConfigs;

        /// <summary>
        /// Whether to start or stop an extended event.
        /// </summary>
        public InputList<Inputs.StartXeventEventConfigGetArgs> EventConfigs
        {
            get => _eventConfigs ?? (_eventConfigs = new InputList<Inputs.StartXeventEventConfigGetArgs>());
            set => _eventConfigs = value;
        }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        public StartXeventState()
        {
        }
        public static new StartXeventState Empty => new StartXeventState();
    }
}
