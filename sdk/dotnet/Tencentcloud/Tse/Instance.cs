// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse
{
    /// <summary>
    /// Provides a resource to create a tse instance
    /// 
    /// ## Example Usage
    /// ### Create zookeeper standard version
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var zookeeperStandard = new Tencentcloud.Tse.Instance("zookeeperStandard", new Tencentcloud.Tse.InstanceArgs
    ///         {
    ///             EngineName = "zookeeper-test",
    ///             EngineNodeNum = 3,
    ///             EngineProductVersion = "STANDARD",
    ///             EngineRegion = "ap-guangzhou",
    ///             EngineResourceSpec = "spec-qvj6k7t4q",
    ///             EngineType = "zookeeper",
    ///             EngineVersion = "3.5.9.4",
    ///             SubnetId = "subnet-dwj7ipnc",
    ///             Tags = 
    ///             {
    ///                 { "createdBy", "terraform" },
    ///             },
    ///             TradeType = 0,
    ///             VpcId = "vpc-4owdpnwr",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Create zookeeper professional version
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var zookeeperProfessional = new Tencentcloud.Tse.Instance("zookeeperProfessional", new Tencentcloud.Tse.InstanceArgs
    ///         {
    ///             EngineName = "zookeeper-test",
    ///             EngineNodeNum = 3,
    ///             EngineProductVersion = "PROFESSIONAL",
    ///             EngineRegion = "ap-guangzhou",
    ///             EngineRegionInfos = 
    ///             {
    ///                 new Tencentcloud.Tse.Inputs.InstanceEngineRegionInfoArgs
    ///                 {
    ///                     EngineRegion = "ap-guangzhou",
    ///                     Replica = 3,
    ///                     VpcInfos = 
    ///                     {
    ///                         new Tencentcloud.Tse.Inputs.InstanceEngineRegionInfoVpcInfoArgs
    ///                         {
    ///                             SubnetId = "subnet-dwj7ipnc",
    ///                             VpcId = "vpc-4owdpnwr",
    ///                         },
    ///                         new Tencentcloud.Tse.Inputs.InstanceEngineRegionInfoVpcInfoArgs
    ///                         {
    ///                             SubnetId = "subnet-403mgks4",
    ///                             VpcId = "vpc-b1puef4z",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             EngineResourceSpec = "spec-qvj6k7t4q",
    ///             EngineType = "zookeeper",
    ///             EngineVersion = "3.5.9.4",
    ///             SubnetId = "subnet-dwj7ipnc",
    ///             Tags = 
    ///             {
    ///                 { "createdBy", "terraform" },
    ///             },
    ///             TradeType = 0,
    ///             VpcId = "vpc-4owdpnwr",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Create nacos standard version
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var nacos = new Tencentcloud.Tse.Instance("nacos", new Tencentcloud.Tse.InstanceArgs
    ///         {
    ///             EnableClientInternetAccess = false,
    ///             EngineName = "test",
    ///             EngineNodeNum = 3,
    ///             EngineProductVersion = "STANDARD",
    ///             EngineRegion = "ap-guangzhou",
    ///             EngineResourceSpec = "spec-1160a35a",
    ///             EngineType = "nacos",
    ///             EngineVersion = "2.0.3.4",
    ///             SubnetId = "subnet-5vpegquy",
    ///             Tags = 
    ///             {
    ///                 { "createdBy", "terraform" },
    ///             },
    ///             TradeType = 0,
    ///             VpcId = "vpc-99xmasf9",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### Create polaris base version
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var polaris = new Tencentcloud.Tse.Instance("polaris", new Tencentcloud.Tse.InstanceArgs
    ///         {
    ///             EnableClientInternetAccess = false,
    ///             EngineName = "test",
    ///             EngineNodeNum = 2,
    ///             EngineProductVersion = "BASE",
    ///             EngineRegion = "ap-guangzhou",
    ///             EngineResourceSpec = "spec-c160bas1",
    ///             EngineType = "polaris",
    ///             EngineVersion = "1.16.0.1",
    ///             SubnetId = "subnet-5vpegquy",
    ///             Tags = 
    ///             {
    ///                 { "createdBy", "terraform" },
    ///             },
    ///             TradeType = 0,
    ///             VpcId = "vpc-99xmasf9",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// tse instance can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Tse/instance:Instance instance instance_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Tse/instance:Instance")]
    public partial class Instance : Pulumi.CustomResource
    {
        /// <summary>
        /// Client public network access, `true`: on, `false`: off, default: false.
        /// </summary>
        [Output("enableClientInternetAccess")]
        public Output<bool?> EnableClientInternetAccess { get; private set; } = null!;

        /// <summary>
        /// engien name. Reference value: nacos-test.
        /// </summary>
        [Output("engineName")]
        public Output<string> EngineName { get; private set; } = null!;

        /// <summary>
        /// engine node num. see EngineProductVersion.
        /// </summary>
        [Output("engineNodeNum")]
        public Output<int?> EngineNodeNum { get; private set; } = null!;

        /// <summary>
        /// Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
        /// </summary>
        [Output("engineProductVersion")]
        public Output<string> EngineProductVersion { get; private set; } = null!;

        /// <summary>
        /// engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
        /// </summary>
        [Output("engineRegion")]
        public Output<string> EngineRegion { get; private set; } = null!;

        /// <summary>
        /// Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
        /// </summary>
        [Output("engineRegionInfos")]
        public Output<ImmutableArray<Outputs.InstanceEngineRegionInfo>> EngineRegionInfos { get; private set; } = null!;

        /// <summary>
        /// engine spec ID. see EngineProductVersion.
        /// </summary>
        [Output("engineResourceSpec")]
        public Output<string?> EngineResourceSpec { get; private set; } = null!;

        /// <summary>
        /// engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
        /// </summary>
        [Output("engineType")]
        public Output<string> EngineType { get; private set; } = null!;

        /// <summary>
        /// An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
        /// </summary>
        [Output("engineVersion")]
        public Output<string> EngineVersion { get; private set; } = null!;

        /// <summary>
        /// Prepaid time, in monthly units.
        /// </summary>
        [Output("prepaidPeriod")]
        public Output<int?> PrepaidPeriod { get; private set; } = null!;

        /// <summary>
        /// Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
        /// </summary>
        [Output("prepaidRenewFlag")]
        public Output<int?> PrepaidRenewFlag { get; private set; } = null!;

        /// <summary>
        /// subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
        /// </summary>
        [Output("subnetId")]
        public Output<string?> SubnetId { get; private set; } = null!;

        /// <summary>
        /// Tag description list.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
        /// </summary>
        [Output("tradeType")]
        public Output<int> TradeType { get; private set; } = null!;

        /// <summary>
        /// VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
        /// </summary>
        [Output("vpcId")]
        public Output<string?> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a Instance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Instance(string name, InstanceArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Tse/instance:Instance", name, args ?? new InstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Instance(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Tse/instance:Instance", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Instance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Instance Get(string name, Input<string> id, InstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new Instance(name, id, state, options);
        }
    }

    public sealed class InstanceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Client public network access, `true`: on, `false`: off, default: false.
        /// </summary>
        [Input("enableClientInternetAccess")]
        public Input<bool>? EnableClientInternetAccess { get; set; }

        /// <summary>
        /// engien name. Reference value: nacos-test.
        /// </summary>
        [Input("engineName", required: true)]
        public Input<string> EngineName { get; set; } = null!;

        /// <summary>
        /// engine node num. see EngineProductVersion.
        /// </summary>
        [Input("engineNodeNum")]
        public Input<int>? EngineNodeNum { get; set; }

        /// <summary>
        /// Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
        /// </summary>
        [Input("engineProductVersion", required: true)]
        public Input<string> EngineProductVersion { get; set; } = null!;

        /// <summary>
        /// engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
        /// </summary>
        [Input("engineRegion", required: true)]
        public Input<string> EngineRegion { get; set; } = null!;

        [Input("engineRegionInfos")]
        private InputList<Inputs.InstanceEngineRegionInfoArgs>? _engineRegionInfos;

        /// <summary>
        /// Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
        /// </summary>
        public InputList<Inputs.InstanceEngineRegionInfoArgs> EngineRegionInfos
        {
            get => _engineRegionInfos ?? (_engineRegionInfos = new InputList<Inputs.InstanceEngineRegionInfoArgs>());
            set => _engineRegionInfos = value;
        }

        /// <summary>
        /// engine spec ID. see EngineProductVersion.
        /// </summary>
        [Input("engineResourceSpec")]
        public Input<string>? EngineResourceSpec { get; set; }

        /// <summary>
        /// engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
        /// </summary>
        [Input("engineType", required: true)]
        public Input<string> EngineType { get; set; } = null!;

        /// <summary>
        /// An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
        /// </summary>
        [Input("engineVersion", required: true)]
        public Input<string> EngineVersion { get; set; } = null!;

        /// <summary>
        /// Prepaid time, in monthly units.
        /// </summary>
        [Input("prepaidPeriod")]
        public Input<int>? PrepaidPeriod { get; set; }

        /// <summary>
        /// Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
        /// </summary>
        [Input("prepaidRenewFlag")]
        public Input<int>? PrepaidRenewFlag { get; set; }

        /// <summary>
        /// subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tag description list.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
        /// </summary>
        [Input("tradeType", required: true)]
        public Input<int> TradeType { get; set; } = null!;

        /// <summary>
        /// VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public InstanceArgs()
        {
        }
    }

    public sealed class InstanceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Client public network access, `true`: on, `false`: off, default: false.
        /// </summary>
        [Input("enableClientInternetAccess")]
        public Input<bool>? EnableClientInternetAccess { get; set; }

        /// <summary>
        /// engien name. Reference value: nacos-test.
        /// </summary>
        [Input("engineName")]
        public Input<string>? EngineName { get; set; }

        /// <summary>
        /// engine node num. see EngineProductVersion.
        /// </summary>
        [Input("engineNodeNum")]
        public Input<int>? EngineNodeNum { get; set; }

        /// <summary>
        /// Engine product version. Reference value: `Nacos`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Zookeeper`: `TRIAL`: Development version, optional node num: `1`, optional spec list: `1C1G`; `STANDARD`: Standard versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`; `PROFESSIONAL`: professional versions, optional node num: `3`, `5`, `7`, optional spec list: `1C2G`, `2C4G`, `4C8G`, `8C16G`, `16C32G`. `Polarismesh`: `BASE`: Base version, optional node num: `1`, optional spec list: `NUM50`; `PROFESSIONAL`: Enterprise versions, optional node num: `2`, `3`, optional spec list: `NUM50`, `NUM100`, `NUM200`, `NUM500`, `NUM1000`, `NUM5000`, `NUM10000`, `NUM50000`.
        /// </summary>
        [Input("engineProductVersion")]
        public Input<string>? EngineProductVersion { get; set; }

        /// <summary>
        /// engine deploy region. Reference value: `China area` Reference value: `ap-guangzhou`, `ap-beijing`, `ap-chengdu`, `ap-chongqing`, `ap-nanjing`, `ap-shanghai` `ap-beijing-fsi`, `ap-shanghai-fsi`, `ap-shenzhen-fsi`. `Asia Pacific` area Reference value: `ap-hongkong`, `ap-taipei`, `ap-jakarta`, `ap-singapore`, `ap-bangkok`, `ap-seoul`, `ap-tokyo`. `North America area` Reference value: `na-toronto`, `sa-saopaulo`, `na-siliconvalley`, `na-ashburn`.
        /// </summary>
        [Input("engineRegion")]
        public Input<string>? EngineRegion { get; set; }

        [Input("engineRegionInfos")]
        private InputList<Inputs.InstanceEngineRegionInfoGetArgs>? _engineRegionInfos;

        /// <summary>
        /// Details about the regional configuration of the engine in cross-region deployment, only zookeeper professional requires the use of the EngineRegionInfos parameter.
        /// </summary>
        public InputList<Inputs.InstanceEngineRegionInfoGetArgs> EngineRegionInfos
        {
            get => _engineRegionInfos ?? (_engineRegionInfos = new InputList<Inputs.InstanceEngineRegionInfoGetArgs>());
            set => _engineRegionInfos = value;
        }

        /// <summary>
        /// engine spec ID. see EngineProductVersion.
        /// </summary>
        [Input("engineResourceSpec")]
        public Input<string>? EngineResourceSpec { get; set; }

        /// <summary>
        /// engine type. Reference value: `zookeeper`, `nacos`, `polaris`.
        /// </summary>
        [Input("engineType")]
        public Input<string>? EngineType { get; set; }

        /// <summary>
        /// An open source version of the engine. Each engine supports different open source versions, refer to the product documentation or console purchase page.
        /// </summary>
        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        /// <summary>
        /// Prepaid time, in monthly units.
        /// </summary>
        [Input("prepaidPeriod")]
        public Input<int>? PrepaidPeriod { get; set; }

        /// <summary>
        /// Automatic renewal mark, prepaid only.  Reference value: `0`: No automatic renewal, `1`: Automatic renewal.
        /// </summary>
        [Input("prepaidRenewFlag")]
        public Input<int>? PrepaidRenewFlag { get; set; }

        /// <summary>
        /// subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tag description list.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// trade type. Reference value:- 0:postpaid- 1:Prepaid (Interface does not support the creation of prepaid instances yet).
        /// </summary>
        [Input("tradeType")]
        public Input<int>? TradeType { get; set; }

        /// <summary>
        /// VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public InstanceState()
        {
        }
    }
}