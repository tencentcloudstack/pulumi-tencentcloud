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
    /// Provides a resource to create a sqlserver config_database_mdf
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
    ///     var exampleDb = new Tencentcloud.Sqlserver.Db("exampleDb", new()
    ///     {
    ///         InstanceId = exampleBasicInstance.Id,
    ///         Charset = "Chinese_PRC_BIN",
    ///         Remark = "test-remark",
    ///     });
    /// 
    ///     var exampleConfigDatabaseMdf = new Tencentcloud.Sqlserver.ConfigDatabaseMdf("exampleConfigDatabaseMdf", new()
    ///     {
    ///         DbName = exampleDb.Name,
    ///         InstanceId = exampleBasicInstance.Id,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// sqlserver config_database_mdf can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Sqlserver/configDatabaseMdf:ConfigDatabaseMdf example mssql-i9ma6oy7#tf_example_db
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Sqlserver/configDatabaseMdf:ConfigDatabaseMdf")]
    public partial class ConfigDatabaseMdf : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Array of database names.
        /// </summary>
        [Output("dbName")]
        public Output<string> DbName { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;


        /// <summary>
        /// Create a ConfigDatabaseMdf resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConfigDatabaseMdf(string name, ConfigDatabaseMdfArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/configDatabaseMdf:ConfigDatabaseMdf", name, args ?? new ConfigDatabaseMdfArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ConfigDatabaseMdf(string name, Input<string> id, ConfigDatabaseMdfState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/configDatabaseMdf:ConfigDatabaseMdf", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ConfigDatabaseMdf resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConfigDatabaseMdf Get(string name, Input<string> id, ConfigDatabaseMdfState? state = null, CustomResourceOptions? options = null)
        {
            return new ConfigDatabaseMdf(name, id, state, options);
        }
    }

    public sealed class ConfigDatabaseMdfArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Array of database names.
        /// </summary>
        [Input("dbName", required: true)]
        public Input<string> DbName { get; set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public ConfigDatabaseMdfArgs()
        {
        }
        public static new ConfigDatabaseMdfArgs Empty => new ConfigDatabaseMdfArgs();
    }

    public sealed class ConfigDatabaseMdfState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Array of database names.
        /// </summary>
        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        public ConfigDatabaseMdfState()
        {
        }
        public static new ConfigDatabaseMdfState Empty => new ConfigDatabaseMdfState();
    }
}
