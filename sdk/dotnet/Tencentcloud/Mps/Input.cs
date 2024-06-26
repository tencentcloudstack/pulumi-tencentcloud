// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps
{
    /// <summary>
    /// Provides a resource to create a mps input
    /// 
    /// ## Example Usage
    /// 
    /// ### Create mps input group with SRT
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
    ///     var input = new Tencentcloud.Mps.Input("input", new()
    ///     {
    ///         FlowId = tencentcloud_mps_flow.Flow.Id,
    ///         InputGroup = new Tencentcloud.Mps.Inputs.InputInputGroupArgs
    ///         {
    ///             InputName = "your_input_name",
    ///             Protocol = "SRT",
    ///             Description = "input name Description",
    ///             AllowIpLists = new[]
    ///             {
    ///                 "0.0.0.0/0",
    ///             },
    ///             SrtSettings = new Tencentcloud.Mps.Inputs.InputInputGroupSrtSettingsArgs
    ///             {
    ///                 Mode = "LISTENER",
    ///                 StreamId = "#!::u=johnny,r=resource,h=xxx.com,t=stream,m=play",
    ///                 Latency = 1000,
    ///                 RecvLatency = 1000,
    ///                 PeerLatency = 1000,
    ///                 PeerIdleTimeout = 1000,
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
    /// mps input can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Mps/input:Input input input_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Mps/input:Input")]
    public partial class Input : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Flow ID.
        /// </summary>
        [Output("flowId")]
        public Output<string> FlowId { get; private set; } = null!;

        /// <summary>
        /// The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `for_each` to create multiple inputs Scenario.
        /// </summary>
        [Output("inputGroup")]
        public Output<Outputs.InputInputGroup?> InputGroup { get; private set; } = null!;


        /// <summary>
        /// Create a Input resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Input(string name, InputArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/input:Input", name, args ?? new InputArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Input(string name, Input<string> id, InputState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Mps/input:Input", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Input resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Input Get(string name, Input<string> id, InputState? state = null, CustomResourceOptions? options = null)
        {
            return new Input(name, id, state, options);
        }
    }

    public sealed class InputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flow ID.
        /// </summary>
        [Input("flowId", required: true)]
        public Input<string> FlowId { get; set; } = null!;

        /// <summary>
        /// The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `for_each` to create multiple inputs Scenario.
        /// </summary>
        [Input("inputGroup")]
        public Input<Inputs.InputInputGroupArgs>? InputGroup { get; set; }

        public InputArgs()
        {
        }
        public static new InputArgs Empty => new InputArgs();
    }

    public sealed class InputState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Flow ID.
        /// </summary>
        [Input("flowId")]
        public Input<string>? FlowId { get; set; }

        /// <summary>
        /// The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `for_each` to create multiple inputs Scenario.
        /// </summary>
        [Input("inputGroup")]
        public Input<Inputs.InputInputGroupGetArgs>? InputGroup { get; set; }

        public InputState()
        {
        }
        public static new InputState Empty => new InputState();
    }
}
