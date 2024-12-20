// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clb
{
    /// <summary>
    /// Provides a resource to set clb listener default domain
    /// 
    /// ## Example Usage
    /// 
    /// ### Set default domain
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
    ///     var example = new Tencentcloud.Clb.ListenerDefaultDomain("example", new()
    ///     {
    ///         ClbId = "lb-g1miv1ok",
    ///         Domain = "3.com",
    ///         ListenerId = "lbl-duilx5qm",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// CLB listener default domain can be imported using the id (version &gt;= 1.47.0), e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Clb/listenerDefaultDomain:ListenerDefaultDomain example lb-k2zjp9lv#lbl-hh141sn9
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Clb/listenerDefaultDomain:ListenerDefaultDomain")]
    public partial class ListenerDefaultDomain : global::Pulumi.CustomResource
    {
        /// <summary>
        /// ID of CLB instance.
        /// </summary>
        [Output("clbId")]
        public Output<string> ClbId { get; private set; } = null!;

        /// <summary>
        /// Domain name of the listener rule. Single domain rules are passed to `domain`, and multi domain rules are passed to `domains`.
        /// </summary>
        [Output("domain")]
        public Output<string> Domain { get; private set; } = null!;

        /// <summary>
        /// ID of CLB listener.
        /// </summary>
        [Output("listenerId")]
        public Output<string> ListenerId { get; private set; } = null!;

        /// <summary>
        /// ID of this CLB listener rule.
        /// </summary>
        [Output("ruleId")]
        public Output<string> RuleId { get; private set; } = null!;


        /// <summary>
        /// Create a ListenerDefaultDomain resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ListenerDefaultDomain(string name, ListenerDefaultDomainArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Clb/listenerDefaultDomain:ListenerDefaultDomain", name, args ?? new ListenerDefaultDomainArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ListenerDefaultDomain(string name, Input<string> id, ListenerDefaultDomainState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Clb/listenerDefaultDomain:ListenerDefaultDomain", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ListenerDefaultDomain resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ListenerDefaultDomain Get(string name, Input<string> id, ListenerDefaultDomainState? state = null, CustomResourceOptions? options = null)
        {
            return new ListenerDefaultDomain(name, id, state, options);
        }
    }

    public sealed class ListenerDefaultDomainArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of CLB instance.
        /// </summary>
        [Input("clbId", required: true)]
        public Input<string> ClbId { get; set; } = null!;

        /// <summary>
        /// Domain name of the listener rule. Single domain rules are passed to `domain`, and multi domain rules are passed to `domains`.
        /// </summary>
        [Input("domain", required: true)]
        public Input<string> Domain { get; set; } = null!;

        /// <summary>
        /// ID of CLB listener.
        /// </summary>
        [Input("listenerId", required: true)]
        public Input<string> ListenerId { get; set; } = null!;

        public ListenerDefaultDomainArgs()
        {
        }
        public static new ListenerDefaultDomainArgs Empty => new ListenerDefaultDomainArgs();
    }

    public sealed class ListenerDefaultDomainState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of CLB instance.
        /// </summary>
        [Input("clbId")]
        public Input<string>? ClbId { get; set; }

        /// <summary>
        /// Domain name of the listener rule. Single domain rules are passed to `domain`, and multi domain rules are passed to `domains`.
        /// </summary>
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        /// <summary>
        /// ID of CLB listener.
        /// </summary>
        [Input("listenerId")]
        public Input<string>? ListenerId { get; set; }

        /// <summary>
        /// ID of this CLB listener rule.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        public ListenerDefaultDomainState()
        {
        }
        public static new ListenerDefaultDomainState Empty => new ListenerDefaultDomainState();
    }
}
