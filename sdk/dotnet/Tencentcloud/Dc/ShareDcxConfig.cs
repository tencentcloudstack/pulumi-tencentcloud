// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dc
{
    /// <summary>
    /// Provides a resource to create a dc share_dcx_config
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
    ///     var shareDcxConfig = new Tencentcloud.Dc.ShareDcxConfig("shareDcxConfig", new()
    ///     {
    ///         DirectConnectTunnelId = "dcx-4z49tnws",
    ///         Enable = false,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// dc share_dcx_config can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Dc/shareDcxConfig:ShareDcxConfig share_dcx_config dcx_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dc/shareDcxConfig:ShareDcxConfig")]
    public partial class ShareDcxConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// the direct connect owner accept or reject the apply of direct connect tunnel.
        /// </summary>
        [Output("directConnectTunnelId")]
        public Output<string> DirectConnectTunnelId { get; private set; } = null!;

        /// <summary>
        /// if accept or reject direct connect tunnel.
        /// </summary>
        [Output("enable")]
        public Output<bool> Enable { get; private set; } = null!;


        /// <summary>
        /// Create a ShareDcxConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ShareDcxConfig(string name, ShareDcxConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dc/shareDcxConfig:ShareDcxConfig", name, args ?? new ShareDcxConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ShareDcxConfig(string name, Input<string> id, ShareDcxConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dc/shareDcxConfig:ShareDcxConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ShareDcxConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ShareDcxConfig Get(string name, Input<string> id, ShareDcxConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new ShareDcxConfig(name, id, state, options);
        }
    }

    public sealed class ShareDcxConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the direct connect owner accept or reject the apply of direct connect tunnel.
        /// </summary>
        [Input("directConnectTunnelId", required: true)]
        public Input<string> DirectConnectTunnelId { get; set; } = null!;

        /// <summary>
        /// if accept or reject direct connect tunnel.
        /// </summary>
        [Input("enable", required: true)]
        public Input<bool> Enable { get; set; } = null!;

        public ShareDcxConfigArgs()
        {
        }
        public static new ShareDcxConfigArgs Empty => new ShareDcxConfigArgs();
    }

    public sealed class ShareDcxConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// the direct connect owner accept or reject the apply of direct connect tunnel.
        /// </summary>
        [Input("directConnectTunnelId")]
        public Input<string>? DirectConnectTunnelId { get; set; }

        /// <summary>
        /// if accept or reject direct connect tunnel.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        public ShareDcxConfigState()
        {
        }
        public static new ShareDcxConfigState Empty => new ShareDcxConfigState();
    }
}
