// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts
{
    /// <summary>
    /// Provides a resource to create a pts scenario
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
    ///     var scenario = new Tencentcloud.Pts.Scenario("scenario", new()
    ///     {
    ///         DomainNameConfig = null,
    ///         Load = new Tencentcloud.Pts.Inputs.ScenarioLoadArgs
    ///         {
    ///             GeoRegionsLoadDistributions = new[]
    ///             {
    ///                 new Tencentcloud.Pts.Inputs.ScenarioLoadGeoRegionsLoadDistributionArgs
    ///                 {
    ///                     Percentage = 100,
    ///                     Region = "ap-guangzhou",
    ///                     RegionId = 1,
    ///                 },
    ///             },
    ///             LoadSpec = new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecArgs
    ///             {
    ///                 Concurrency = new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecConcurrencyArgs
    ///                 {
    ///                     GracefulStopSeconds = 3,
    ///                     IterationCount = 0,
    ///                     MaxRequestsPerSecond = 0,
    ///                     Stages = new[]
    ///                     {
    ///                         new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecConcurrencyStageArgs
    ///                         {
    ///                             DurationSeconds = 120,
    ///                             TargetVirtualUsers = 2,
    ///                         },
    ///                         new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecConcurrencyStageArgs
    ///                         {
    ///                             DurationSeconds = 120,
    ///                             TargetVirtualUsers = 4,
    ///                         },
    ///                         new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecConcurrencyStageArgs
    ///                         {
    ///                             DurationSeconds = 120,
    ///                             TargetVirtualUsers = 5,
    ///                         },
    ///                         new Tencentcloud.Pts.Inputs.ScenarioLoadLoadSpecConcurrencyStageArgs
    ///                         {
    ///                             DurationSeconds = 240,
    ///                             TargetVirtualUsers = 5,
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         ProjectId = "project-45vw7v82",
    ///         SlaPolicy = null,
    ///         TestScripts = new[]
    ///         {
    ///             new Tencentcloud.Pts.Inputs.ScenarioTestScriptArgs
    ///             {
    ///                 EncodedContent = @"            // Send a http get request
    ///             import http from 'pts/http';
    ///             import { check, sleep } from 'pts';
    /// 
    ///             export default function () {
    ///               // simple get request
    ///               const resp1 = http.get('http://httpbin.org/get');
    ///               console.log(resp1.body);
    ///               // if resp1.body is a json string, resp1.json() transfer json format body to a json object
    ///               console.log(resp1.json());
    ///               check('status is 200', () =&gt; resp1.statusCode === 200);
    /// 
    ///               // sleep 1 second
    ///               sleep(1);
    /// 
    ///               // get request with headers and parameters
    ///               const resp2 = http.get('http://httpbin.org/get', {
    ///                 headers: {
    ///                   Connection: 'keep-alive',
    ///                   'User-Agent': 'pts-engine',
    ///                 },
    ///                 query: {
    ///                   name1: 'value1',
    ///                   name2: 'value2',
    ///                 },
    ///               });
    /// 
    ///               console.log(resp2.json().args.name1); // 'value1'
    ///               check('body.args.name1 equals value1', () =&gt; resp2.json().args.name1 === 'value1');
    ///             }
    /// 
    /// ",
    ///                 LoadWeight = 100,
    ///                 Name = "script.js",
    ///                 Size = 838,
    ///                 Type = "js",
    ///                 UpdatedAt = "2022-11-11T16:18:37+08:00",
    ///             },
    ///         },
    ///         Type = "pts-js",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// pts scenario can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Pts/scenario:Scenario scenario scenario_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Pts/scenario:Scenario")]
    public partial class Scenario : global::Pulumi.CustomResource
    {
        /// <summary>
        /// App ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Output("appId")]
        public Output<int> AppId { get; private set; } = null!;

        /// <summary>
        /// Scene creation time.
        /// </summary>
        [Output("createdAt")]
        public Output<string> CreatedAt { get; private set; } = null!;

        /// <summary>
        /// cron job ID.
        /// </summary>
        [Output("cronId")]
        public Output<string?> CronId { get; private set; } = null!;

        /// <summary>
        /// Test data set.
        /// </summary>
        [Output("datasets")]
        public Output<ImmutableArray<Outputs.ScenarioDataset>> Datasets { get; private set; } = null!;

        /// <summary>
        /// Pts Scenario Description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Domain name resolution configuration.
        /// </summary>
        [Output("domainNameConfig")]
        public Output<Outputs.ScenarioDomainNameConfig?> DomainNameConfig { get; private set; } = null!;

        /// <summary>
        /// deprecated.
        /// </summary>
        [Output("extensions")]
        public Output<ImmutableArray<string>> Extensions { get; private set; } = null!;

        /// <summary>
        /// Pressure allocation.
        /// </summary>
        [Output("load")]
        public Output<Outputs.ScenarioLoad?> Load { get; private set; } = null!;

        /// <summary>
        /// Pts Scenario name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// SLA strategy.
        /// </summary>
        [Output("plugins")]
        public Output<ImmutableArray<Outputs.ScenarioPlugin>> Plugins { get; private set; } = null!;

        /// <summary>
        /// Project id.
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Protocol file path.
        /// </summary>
        [Output("protocols")]
        public Output<ImmutableArray<Outputs.ScenarioProtocol>> Protocols { get; private set; } = null!;

        /// <summary>
        /// Request file path.
        /// </summary>
        [Output("requestFiles")]
        public Output<ImmutableArray<Outputs.ScenarioRequestFile>> RequestFiles { get; private set; } = null!;

        /// <summary>
        /// SLA strategy.
        /// </summary>
        [Output("slaPolicy")]
        public Output<Outputs.ScenarioSlaPolicy?> SlaPolicy { get; private set; } = null!;

        /// <summary>
        /// Scene statu Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Output("status")]
        public Output<int> Status { get; private set; } = null!;

        /// <summary>
        /// Sub-user ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Output("subAccountUin")]
        public Output<string> SubAccountUin { get; private set; } = null!;

        /// <summary>
        /// Test script file information.
        /// </summary>
        [Output("testScripts")]
        public Output<ImmutableArray<Outputs.ScenarioTestScript>> TestScripts { get; private set; } = null!;

        /// <summary>
        /// Pressure test engine type.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// User ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Output("uin")]
        public Output<string> Uin { get; private set; } = null!;

        /// <summary>
        /// Update time.
        /// </summary>
        [Output("updatedAt")]
        public Output<string> UpdatedAt { get; private set; } = null!;


        /// <summary>
        /// Create a Scenario resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Scenario(string name, ScenarioArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Pts/scenario:Scenario", name, args ?? new ScenarioArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Scenario(string name, Input<string> id, ScenarioState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Pts/scenario:Scenario", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Scenario resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Scenario Get(string name, Input<string> id, ScenarioState? state = null, CustomResourceOptions? options = null)
        {
            return new Scenario(name, id, state, options);
        }
    }

    public sealed class ScenarioArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// cron job ID.
        /// </summary>
        [Input("cronId")]
        public Input<string>? CronId { get; set; }

        [Input("datasets")]
        private InputList<Inputs.ScenarioDatasetArgs>? _datasets;

        /// <summary>
        /// Test data set.
        /// </summary>
        public InputList<Inputs.ScenarioDatasetArgs> Datasets
        {
            get => _datasets ?? (_datasets = new InputList<Inputs.ScenarioDatasetArgs>());
            set => _datasets = value;
        }

        /// <summary>
        /// Pts Scenario Description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Domain name resolution configuration.
        /// </summary>
        [Input("domainNameConfig")]
        public Input<Inputs.ScenarioDomainNameConfigArgs>? DomainNameConfig { get; set; }

        [Input("extensions")]
        private InputList<string>? _extensions;

        /// <summary>
        /// deprecated.
        /// </summary>
        public InputList<string> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<string>());
            set => _extensions = value;
        }

        /// <summary>
        /// Pressure allocation.
        /// </summary>
        [Input("load")]
        public Input<Inputs.ScenarioLoadArgs>? Load { get; set; }

        /// <summary>
        /// Pts Scenario name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("plugins")]
        private InputList<Inputs.ScenarioPluginArgs>? _plugins;

        /// <summary>
        /// SLA strategy.
        /// </summary>
        public InputList<Inputs.ScenarioPluginArgs> Plugins
        {
            get => _plugins ?? (_plugins = new InputList<Inputs.ScenarioPluginArgs>());
            set => _plugins = value;
        }

        /// <summary>
        /// Project id.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        [Input("protocols")]
        private InputList<Inputs.ScenarioProtocolArgs>? _protocols;

        /// <summary>
        /// Protocol file path.
        /// </summary>
        public InputList<Inputs.ScenarioProtocolArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Inputs.ScenarioProtocolArgs>());
            set => _protocols = value;
        }

        [Input("requestFiles")]
        private InputList<Inputs.ScenarioRequestFileArgs>? _requestFiles;

        /// <summary>
        /// Request file path.
        /// </summary>
        public InputList<Inputs.ScenarioRequestFileArgs> RequestFiles
        {
            get => _requestFiles ?? (_requestFiles = new InputList<Inputs.ScenarioRequestFileArgs>());
            set => _requestFiles = value;
        }

        /// <summary>
        /// SLA strategy.
        /// </summary>
        [Input("slaPolicy")]
        public Input<Inputs.ScenarioSlaPolicyArgs>? SlaPolicy { get; set; }

        [Input("testScripts")]
        private InputList<Inputs.ScenarioTestScriptArgs>? _testScripts;

        /// <summary>
        /// Test script file information.
        /// </summary>
        public InputList<Inputs.ScenarioTestScriptArgs> TestScripts
        {
            get => _testScripts ?? (_testScripts = new InputList<Inputs.ScenarioTestScriptArgs>());
            set => _testScripts = value;
        }

        /// <summary>
        /// Pressure test engine type.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ScenarioArgs()
        {
        }
        public static new ScenarioArgs Empty => new ScenarioArgs();
    }

    public sealed class ScenarioState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// App ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("appId")]
        public Input<int>? AppId { get; set; }

        /// <summary>
        /// Scene creation time.
        /// </summary>
        [Input("createdAt")]
        public Input<string>? CreatedAt { get; set; }

        /// <summary>
        /// cron job ID.
        /// </summary>
        [Input("cronId")]
        public Input<string>? CronId { get; set; }

        [Input("datasets")]
        private InputList<Inputs.ScenarioDatasetGetArgs>? _datasets;

        /// <summary>
        /// Test data set.
        /// </summary>
        public InputList<Inputs.ScenarioDatasetGetArgs> Datasets
        {
            get => _datasets ?? (_datasets = new InputList<Inputs.ScenarioDatasetGetArgs>());
            set => _datasets = value;
        }

        /// <summary>
        /// Pts Scenario Description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Domain name resolution configuration.
        /// </summary>
        [Input("domainNameConfig")]
        public Input<Inputs.ScenarioDomainNameConfigGetArgs>? DomainNameConfig { get; set; }

        [Input("extensions")]
        private InputList<string>? _extensions;

        /// <summary>
        /// deprecated.
        /// </summary>
        public InputList<string> Extensions
        {
            get => _extensions ?? (_extensions = new InputList<string>());
            set => _extensions = value;
        }

        /// <summary>
        /// Pressure allocation.
        /// </summary>
        [Input("load")]
        public Input<Inputs.ScenarioLoadGetArgs>? Load { get; set; }

        /// <summary>
        /// Pts Scenario name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("plugins")]
        private InputList<Inputs.ScenarioPluginGetArgs>? _plugins;

        /// <summary>
        /// SLA strategy.
        /// </summary>
        public InputList<Inputs.ScenarioPluginGetArgs> Plugins
        {
            get => _plugins ?? (_plugins = new InputList<Inputs.ScenarioPluginGetArgs>());
            set => _plugins = value;
        }

        /// <summary>
        /// Project id.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("protocols")]
        private InputList<Inputs.ScenarioProtocolGetArgs>? _protocols;

        /// <summary>
        /// Protocol file path.
        /// </summary>
        public InputList<Inputs.ScenarioProtocolGetArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<Inputs.ScenarioProtocolGetArgs>());
            set => _protocols = value;
        }

        [Input("requestFiles")]
        private InputList<Inputs.ScenarioRequestFileGetArgs>? _requestFiles;

        /// <summary>
        /// Request file path.
        /// </summary>
        public InputList<Inputs.ScenarioRequestFileGetArgs> RequestFiles
        {
            get => _requestFiles ?? (_requestFiles = new InputList<Inputs.ScenarioRequestFileGetArgs>());
            set => _requestFiles = value;
        }

        /// <summary>
        /// SLA strategy.
        /// </summary>
        [Input("slaPolicy")]
        public Input<Inputs.ScenarioSlaPolicyGetArgs>? SlaPolicy { get; set; }

        /// <summary>
        /// Scene statu Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("status")]
        public Input<int>? Status { get; set; }

        /// <summary>
        /// Sub-user ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("subAccountUin")]
        public Input<string>? SubAccountUin { get; set; }

        [Input("testScripts")]
        private InputList<Inputs.ScenarioTestScriptGetArgs>? _testScripts;

        /// <summary>
        /// Test script file information.
        /// </summary>
        public InputList<Inputs.ScenarioTestScriptGetArgs> TestScripts
        {
            get => _testScripts ?? (_testScripts = new InputList<Inputs.ScenarioTestScriptGetArgs>());
            set => _testScripts = value;
        }

        /// <summary>
        /// Pressure test engine type.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// User ID Note: this field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        [Input("uin")]
        public Input<string>? Uin { get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [Input("updatedAt")]
        public Input<string>? UpdatedAt { get; set; }

        public ScenarioState()
        {
        }
        public static new ScenarioState Empty => new ScenarioState();
    }
}
