// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor
{
    /// <summary>
    /// Provides a resource to create a monitor tmpScrapeJob
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
    ///     var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-4";
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         VpcId = vpc.Id,
    ///         AvailabilityZone = availabilityZone,
    ///         CidrBlock = "10.0.1.0/24",
    ///     });
    /// 
    ///     var fooTmpInstance = new Tencentcloud.Monitor.TmpInstance("fooTmpInstance", new()
    ///     {
    ///         InstanceName = "tf-tmp-instance",
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///         DataRetentionTime = 30,
    ///         Zone = availabilityZone,
    ///         Tags = 
    ///         {
    ///             { "createdBy", "terraform" },
    ///         },
    ///     });
    /// 
    ///     var fooTmpCvmAgent = new Tencentcloud.Monitor.TmpCvmAgent("fooTmpCvmAgent", new()
    ///     {
    ///         InstanceId = fooTmpInstance.Id,
    ///     });
    /// 
    ///     var fooTmpScrapeJob = new Tencentcloud.Monitor.TmpScrapeJob("fooTmpScrapeJob", new()
    ///     {
    ///         InstanceId = fooTmpInstance.Id,
    ///         AgentId = fooTmpCvmAgent.AgentId,
    ///         Config = @"job_name: demo-config
    /// honor_timestamps: true
    /// metrics_path: /metrics
    /// scheme: https
    /// ",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// monitor tmpScrapeJob can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob tmpScrapeJob tmpScrapeJob_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob")]
    public partial class TmpScrapeJob : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Agent id.
        /// </summary>
        [Output("agentId")]
        public Output<string> AgentId { get; private set; } = null!;

        /// <summary>
        /// Job content.
        /// </summary>
        [Output("config")]
        public Output<string?> Config { get; private set; } = null!;

        /// <summary>
        /// Instance id.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;


        /// <summary>
        /// Create a TmpScrapeJob resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TmpScrapeJob(string name, TmpScrapeJobArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob", name, args ?? new TmpScrapeJobArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TmpScrapeJob(string name, Input<string> id, TmpScrapeJobState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Monitor/tmpScrapeJob:TmpScrapeJob", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing TmpScrapeJob resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TmpScrapeJob Get(string name, Input<string> id, TmpScrapeJobState? state = null, CustomResourceOptions? options = null)
        {
            return new TmpScrapeJob(name, id, state, options);
        }
    }

    public sealed class TmpScrapeJobArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Agent id.
        /// </summary>
        [Input("agentId", required: true)]
        public Input<string> AgentId { get; set; } = null!;

        /// <summary>
        /// Job content.
        /// </summary>
        [Input("config")]
        public Input<string>? Config { get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public TmpScrapeJobArgs()
        {
        }
        public static new TmpScrapeJobArgs Empty => new TmpScrapeJobArgs();
    }

    public sealed class TmpScrapeJobState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Agent id.
        /// </summary>
        [Input("agentId")]
        public Input<string>? AgentId { get; set; }

        /// <summary>
        /// Job content.
        /// </summary>
        [Input("config")]
        public Input<string>? Config { get; set; }

        /// <summary>
        /// Instance id.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        public TmpScrapeJobState()
        {
        }
        public static new TmpScrapeJobState Empty => new TmpScrapeJobState();
    }
}
