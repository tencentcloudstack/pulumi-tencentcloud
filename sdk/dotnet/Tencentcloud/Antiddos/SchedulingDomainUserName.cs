// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Antiddos
{
    /// <summary>
    /// Provides a resource to create a antiddos scheduling_domain_user_name
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
    ///     var schedulingDomainUserName = new Tencentcloud.Antiddos.SchedulingDomainUserName("schedulingDomainUserName", new()
    ///     {
    ///         DomainName = "test.com",
    ///         DomainUserName = "",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// antiddos scheduling_domain_user_name can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Antiddos/schedulingDomainUserName:SchedulingDomainUserName scheduling_domain_user_name ${domainName}
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Antiddos/schedulingDomainUserName:SchedulingDomainUserName")]
    public partial class SchedulingDomainUserName : global::Pulumi.CustomResource
    {
        /// <summary>
        /// user cname.
        /// </summary>
        [Output("domainName")]
        public Output<string> DomainName { get; private set; } = null!;

        /// <summary>
        /// domain name.
        /// </summary>
        [Output("domainUserName")]
        public Output<string> DomainUserName { get; private set; } = null!;


        /// <summary>
        /// Create a SchedulingDomainUserName resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SchedulingDomainUserName(string name, SchedulingDomainUserNameArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Antiddos/schedulingDomainUserName:SchedulingDomainUserName", name, args ?? new SchedulingDomainUserNameArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SchedulingDomainUserName(string name, Input<string> id, SchedulingDomainUserNameState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Antiddos/schedulingDomainUserName:SchedulingDomainUserName", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SchedulingDomainUserName resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SchedulingDomainUserName Get(string name, Input<string> id, SchedulingDomainUserNameState? state = null, CustomResourceOptions? options = null)
        {
            return new SchedulingDomainUserName(name, id, state, options);
        }
    }

    public sealed class SchedulingDomainUserNameArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// user cname.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// domain name.
        /// </summary>
        [Input("domainUserName", required: true)]
        public Input<string> DomainUserName { get; set; } = null!;

        public SchedulingDomainUserNameArgs()
        {
        }
        public static new SchedulingDomainUserNameArgs Empty => new SchedulingDomainUserNameArgs();
    }

    public sealed class SchedulingDomainUserNameState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// user cname.
        /// </summary>
        [Input("domainName")]
        public Input<string>? DomainName { get; set; }

        /// <summary>
        /// domain name.
        /// </summary>
        [Input("domainUserName")]
        public Input<string>? DomainUserName { get; set; }

        public SchedulingDomainUserNameState()
        {
        }
        public static new SchedulingDomainUserNameState Empty => new SchedulingDomainUserNameState();
    }
}
