// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Identity
{
    /// <summary>
    /// Provides a resource to create an identity center group
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
    ///     var identityCenterGroup = new Tencentcloud.Identity.CenterGroup("identityCenterGroup", new()
    ///     {
    ///         Description = "test",
    ///         GroupName = "test-group",
    ///         ZoneId = "z-xxxxxx",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// tencentcloud_identity_center_group can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Identity/centerGroup:CenterGroup identity_center_group ${zoneId}#${groupId}
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Identity/centerGroup:CenterGroup")]
    public partial class CenterGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time of the user group.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// A description of the user group. Length: Maximum 1024 characters.
        /// </summary>
        [Output("description")]
        public Output<string> Description { get; private set; } = null!;

        /// <summary>
        /// ID of the user group.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;

        /// <summary>
        /// The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        /// </summary>
        [Output("groupName")]
        public Output<string> GroupName { get; private set; } = null!;

        /// <summary>
        /// Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        /// </summary>
        [Output("groupType")]
        public Output<string> GroupType { get; private set; } = null!;

        /// <summary>
        /// Number of team members.
        /// </summary>
        [Output("memberCount")]
        public Output<int> MemberCount { get; private set; } = null!;

        /// <summary>
        /// Modification time for the user group.
        /// </summary>
        [Output("updateTime")]
        public Output<string> UpdateTime { get; private set; } = null!;

        /// <summary>
        /// Zone id.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a CenterGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CenterGroup(string name, CenterGroupArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Identity/centerGroup:CenterGroup", name, args ?? new CenterGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CenterGroup(string name, Input<string> id, CenterGroupState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Identity/centerGroup:CenterGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CenterGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CenterGroup Get(string name, Input<string> id, CenterGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new CenterGroup(name, id, state, options);
        }
    }

    public sealed class CenterGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description of the user group. Length: Maximum 1024 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        /// </summary>
        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        /// <summary>
        /// Zone id.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public CenterGroupArgs()
        {
        }
        public static new CenterGroupArgs Empty => new CenterGroupArgs();
    }

    public sealed class CenterGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation time of the user group.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// A description of the user group. Length: Maximum 1024 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// ID of the user group.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// The name of the user group. Format: Allow English letters, numbers and special characters-. Length: Maximum 128 characters.
        /// </summary>
        [Input("groupName")]
        public Input<string>? GroupName { get; set; }

        /// <summary>
        /// Type of user group. `Manual`: manual creation, `Synchronized`: external import.
        /// </summary>
        [Input("groupType")]
        public Input<string>? GroupType { get; set; }

        /// <summary>
        /// Number of team members.
        /// </summary>
        [Input("memberCount")]
        public Input<int>? MemberCount { get; set; }

        /// <summary>
        /// Modification time for the user group.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        /// <summary>
        /// Zone id.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public CenterGroupState()
        {
        }
        public static new CenterGroupState Empty => new CenterGroupState();
    }
}