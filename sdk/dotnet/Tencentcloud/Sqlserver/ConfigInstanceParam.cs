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
    /// Provides a resource to create a sqlserver config_instance_param
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
    ///     var exampleConfigInstanceParam = new Tencentcloud.Sqlserver.ConfigInstanceParam("exampleConfigInstanceParam", new()
    ///     {
    ///         InstanceId = exampleBasicInstance.Id,
    ///         ParamLists = new[]
    ///         {
    ///             new Tencentcloud.Sqlserver.Inputs.ConfigInstanceParamParamListArgs
    ///             {
    ///                 Name = "fill factor(%)",
    ///                 CurrentValue = "90",
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
    /// sqlserver config_instance_param can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Sqlserver/configInstanceParam:ConfigInstanceParam example config_instance_param
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Sqlserver/configInstanceParam:ConfigInstanceParam")]
    public partial class ConfigInstanceParam : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// List of modified parameters. Each list element has two fields: Name and CurrentValue. Set Name to the parameter name and CurrentValue to the new value after modification. Note: if the instance needs to be restarted for the modified parameter to take effect, it will be restarted immediately or during the maintenance time. Before you modify a parameter, you can use the DescribeInstanceParams API to query whether the instance needs to be restarted.
        /// </summary>
        [Output("paramLists")]
        public Output<ImmutableArray<Outputs.ConfigInstanceParamParamList>> ParamLists { get; private set; } = null!;


        /// <summary>
        /// Create a ConfigInstanceParam resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConfigInstanceParam(string name, ConfigInstanceParamArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/configInstanceParam:ConfigInstanceParam", name, args ?? new ConfigInstanceParamArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ConfigInstanceParam(string name, Input<string> id, ConfigInstanceParamState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Sqlserver/configInstanceParam:ConfigInstanceParam", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ConfigInstanceParam resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConfigInstanceParam Get(string name, Input<string> id, ConfigInstanceParamState? state = null, CustomResourceOptions? options = null)
        {
            return new ConfigInstanceParam(name, id, state, options);
        }
    }

    public sealed class ConfigInstanceParamArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("paramLists", required: true)]
        private InputList<Inputs.ConfigInstanceParamParamListArgs>? _paramLists;

        /// <summary>
        /// List of modified parameters. Each list element has two fields: Name and CurrentValue. Set Name to the parameter name and CurrentValue to the new value after modification. Note: if the instance needs to be restarted for the modified parameter to take effect, it will be restarted immediately or during the maintenance time. Before you modify a parameter, you can use the DescribeInstanceParams API to query whether the instance needs to be restarted.
        /// </summary>
        public InputList<Inputs.ConfigInstanceParamParamListArgs> ParamLists
        {
            get => _paramLists ?? (_paramLists = new InputList<Inputs.ConfigInstanceParamParamListArgs>());
            set => _paramLists = value;
        }

        public ConfigInstanceParamArgs()
        {
        }
        public static new ConfigInstanceParamArgs Empty => new ConfigInstanceParamArgs();
    }

    public sealed class ConfigInstanceParamState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("paramLists")]
        private InputList<Inputs.ConfigInstanceParamParamListGetArgs>? _paramLists;

        /// <summary>
        /// List of modified parameters. Each list element has two fields: Name and CurrentValue. Set Name to the parameter name and CurrentValue to the new value after modification. Note: if the instance needs to be restarted for the modified parameter to take effect, it will be restarted immediately or during the maintenance time. Before you modify a parameter, you can use the DescribeInstanceParams API to query whether the instance needs to be restarted.
        /// </summary>
        public InputList<Inputs.ConfigInstanceParamParamListGetArgs> ParamLists
        {
            get => _paramLists ?? (_paramLists = new InputList<Inputs.ConfigInstanceParamParamListGetArgs>());
            set => _paramLists = value;
        }

        public ConfigInstanceParamState()
        {
        }
        public static new ConfigInstanceParamState Empty => new ConfigInstanceParamState();
    }
}
