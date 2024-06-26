// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis
{
    /// <summary>
    /// Provides a resource to create a redis maintenance_window
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
    ///     var zone = Tencentcloud.Redis.GetZoneConfig.Invoke(new()
    ///     {
    ///         TypeId = 7,
    ///     });
    /// 
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         VpcId = vpc.Id,
    ///         AvailabilityZone = zone.Apply(getZoneConfigResult =&gt; getZoneConfigResult.Lists[0]?.Zone),
    ///         CidrBlock = "10.0.1.0/24",
    ///     });
    /// 
    ///     var fooInstance = new Tencentcloud.Redis.Instance("fooInstance", new()
    ///     {
    ///         AvailabilityZone = zone.Apply(getZoneConfigResult =&gt; getZoneConfigResult.Lists[0]?.Zone),
    ///         TypeId = zone.Apply(getZoneConfigResult =&gt; getZoneConfigResult.Lists[0]?.TypeId),
    ///         Password = "test12345789",
    ///         MemSize = 8192,
    ///         RedisShardNum = zone.Apply(getZoneConfigResult =&gt; getZoneConfigResult.Lists[0]?.RedisShardNums[0]),
    ///         RedisReplicasNum = zone.Apply(getZoneConfigResult =&gt; getZoneConfigResult.Lists[0]?.RedisReplicasNums[0]),
    ///         Port = 6379,
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///     });
    /// 
    ///     var fooMaintenanceWindow = new Tencentcloud.Redis.MaintenanceWindow("fooMaintenanceWindow", new()
    ///     {
    ///         InstanceId = fooInstance.Id,
    ///         StartTime = "17:00",
    ///         EndTime = "19:00",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// redis maintenance_window can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Redis/maintenanceWindow:MaintenanceWindow foo instance_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Redis/maintenanceWindow:MaintenanceWindow")]
    public partial class MaintenanceWindow : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The end time of the maintenance window, e.g. 19:00.
        /// </summary>
        [Output("endTime")]
        public Output<string> EndTime { get; private set; } = null!;

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Maintenance window start time, e.g. 17:00.
        /// </summary>
        [Output("startTime")]
        public Output<string> StartTime { get; private set; } = null!;


        /// <summary>
        /// Create a MaintenanceWindow resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MaintenanceWindow(string name, MaintenanceWindowArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/maintenanceWindow:MaintenanceWindow", name, args ?? new MaintenanceWindowArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MaintenanceWindow(string name, Input<string> id, MaintenanceWindowState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/maintenanceWindow:MaintenanceWindow", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MaintenanceWindow resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MaintenanceWindow Get(string name, Input<string> id, MaintenanceWindowState? state = null, CustomResourceOptions? options = null)
        {
            return new MaintenanceWindow(name, id, state, options);
        }
    }

    public sealed class MaintenanceWindowArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end time of the maintenance window, e.g. 19:00.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Maintenance window start time, e.g. 17:00.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public MaintenanceWindowArgs()
        {
        }
        public static new MaintenanceWindowArgs Empty => new MaintenanceWindowArgs();
    }

    public sealed class MaintenanceWindowState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The end time of the maintenance window, e.g. 19:00.
        /// </summary>
        [Input("endTime")]
        public Input<string>? EndTime { get; set; }

        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Maintenance window start time, e.g. 17:00.
        /// </summary>
        [Input("startTime")]
        public Input<string>? StartTime { get; set; }

        public MaintenanceWindowState()
        {
        }
        public static new MaintenanceWindowState Empty => new MaintenanceWindowState();
    }
}
