// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql
{
    /// <summary>
    /// Provides a resource to create a mysql local_binlog_config
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
    ///         Product = "cdb",
    ///     });
    /// 
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[0]?.Name),
    ///         VpcId = vpc.Id,
    ///         CidrBlock = "10.0.0.0/16",
    ///         IsMulticast = false,
    ///     });
    /// 
    ///     var securityGroup = new Tencentcloud.Security.Group("securityGroup", new()
    ///     {
    ///         Description = "mysql test",
    ///     });
    /// 
    ///     var exampleInstance = new Tencentcloud.Mysql.Instance("exampleInstance", new()
    ///     {
    ///         InternetService = 1,
    ///         EngineVersion = "5.7",
    ///         ChargeType = "POSTPAID",
    ///         RootPassword = "PassWord123",
    ///         SlaveDeployMode = 0,
    ///         AvailabilityZone = zones.Apply(getZonesByProductResult =&gt; getZonesByProductResult.Zones[0]?.Name),
    ///         SlaveSyncMode = 1,
    ///         InstanceName = "tf-example-mysql",
    ///         MemSize = 4000,
    ///         VolumeSize = 200,
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///         IntranetPort = 3306,
    ///         SecurityGroups = new[]
    ///         {
    ///             securityGroup.Id,
    ///         },
    ///         Tags = 
    ///         {
    ///             { "name", "test" },
    ///         },
    ///         Parameters = 
    ///         {
    ///             { "character_set_server", "utf8" },
    ///             { "max_connections", "1000" },
    ///         },
    ///     });
    /// 
    ///     var exampleLocalBinlogConfig = new Tencentcloud.Mysql.LocalBinlogConfig("exampleLocalBinlogConfig", new()
    ///     {
    ///         InstanceId = exampleInstance.Id,
    ///         SaveHours = 140,
    ///         MaxUsage = 50,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// mysql local_binlog_config can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Mysql/localBinlogConfig:LocalBinlogConfig local_binlog_config instance_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Mysql/localBinlogConfig:LocalBinlogConfig")]
    public partial class LocalBinlogConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed in the TencentDB console.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Space utilization of local binlog. Value range: [30,50].
        /// </summary>
        [Output("maxUsage")]
        public Output<int> MaxUsage { get; private set; } = null!;

        /// <summary>
        /// Retention period of local binlog. Valid range: 72-168 hours. When there is disaster recovery instance, the valid range will be 120-168 hours.
        /// </summary>
        [Output("saveHours")]
        public Output<int> SaveHours { get; private set; } = null!;


        /// <summary>
        /// Create a LocalBinlogConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LocalBinlogConfig(string name, LocalBinlogConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Mysql/localBinlogConfig:LocalBinlogConfig", name, args ?? new LocalBinlogConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LocalBinlogConfig(string name, Input<string> id, LocalBinlogConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Mysql/localBinlogConfig:LocalBinlogConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LocalBinlogConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LocalBinlogConfig Get(string name, Input<string> id, LocalBinlogConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new LocalBinlogConfig(name, id, state, options);
        }
    }

    public sealed class LocalBinlogConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed in the TencentDB console.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Space utilization of local binlog. Value range: [30,50].
        /// </summary>
        [Input("maxUsage", required: true)]
        public Input<int> MaxUsage { get; set; } = null!;

        /// <summary>
        /// Retention period of local binlog. Valid range: 72-168 hours. When there is disaster recovery instance, the valid range will be 120-168 hours.
        /// </summary>
        [Input("saveHours", required: true)]
        public Input<int> SaveHours { get; set; } = null!;

        public LocalBinlogConfigArgs()
        {
        }
        public static new LocalBinlogConfigArgs Empty => new LocalBinlogConfigArgs();
    }

    public sealed class LocalBinlogConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of cdb-c1nl9rpv. It is the same as the instance ID displayed in the TencentDB console.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Space utilization of local binlog. Value range: [30,50].
        /// </summary>
        [Input("maxUsage")]
        public Input<int>? MaxUsage { get; set; }

        /// <summary>
        /// Retention period of local binlog. Valid range: 72-168 hours. When there is disaster recovery instance, the valid range will be 120-168 hours.
        /// </summary>
        [Input("saveHours")]
        public Input<int>? SaveHours { get; set; }

        public LocalBinlogConfigState()
        {
        }
        public static new LocalBinlogConfigState Empty => new LocalBinlogConfigState();
    }
}
