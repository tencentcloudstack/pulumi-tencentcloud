// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Organization
{
    /// <summary>
    /// Provides a resource to create a organization org_share_unit_member
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
    ///     var orgShareUnit = new Tencentcloud.Organization.OrgShareUnit("orgShareUnit", new()
    ///     {
    ///         Area = "ap-guangzhou",
    ///         Description = "iac-test",
    ///     });
    /// 
    ///     var orgShareUnitMember = new Tencentcloud.Organization.OrgShareUnitMember("orgShareUnitMember", new()
    ///     {
    ///         UnitId = orgShareUnit.UnitId,
    ///         Area = orgShareUnit.Area,
    ///         Members = new[]
    ///         {
    ///             new Tencentcloud.Organization.Inputs.OrgShareUnitMemberMemberArgs
    ///             {
    ///                 ShareMemberUin = 100035309479,
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Organization/orgShareUnitMember:OrgShareUnitMember")]
    public partial class OrgShareUnitMember : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Shared unit region.
        /// </summary>
        [Output("area")]
        public Output<string> Area { get; private set; } = null!;

        /// <summary>
        /// Shared member list. Up to 10 items.
        /// </summary>
        [Output("members")]
        public Output<ImmutableArray<Outputs.OrgShareUnitMemberMember>> Members { get; private set; } = null!;

        /// <summary>
        /// Shared unit ID.
        /// </summary>
        [Output("unitId")]
        public Output<string> UnitId { get; private set; } = null!;


        /// <summary>
        /// Create a OrgShareUnitMember resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrgShareUnitMember(string name, OrgShareUnitMemberArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Organization/orgShareUnitMember:OrgShareUnitMember", name, args ?? new OrgShareUnitMemberArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrgShareUnitMember(string name, Input<string> id, OrgShareUnitMemberState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Organization/orgShareUnitMember:OrgShareUnitMember", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrgShareUnitMember resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrgShareUnitMember Get(string name, Input<string> id, OrgShareUnitMemberState? state = null, CustomResourceOptions? options = null)
        {
            return new OrgShareUnitMember(name, id, state, options);
        }
    }

    public sealed class OrgShareUnitMemberArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Shared unit region.
        /// </summary>
        [Input("area", required: true)]
        public Input<string> Area { get; set; } = null!;

        [Input("members", required: true)]
        private InputList<Inputs.OrgShareUnitMemberMemberArgs>? _members;

        /// <summary>
        /// Shared member list. Up to 10 items.
        /// </summary>
        public InputList<Inputs.OrgShareUnitMemberMemberArgs> Members
        {
            get => _members ?? (_members = new InputList<Inputs.OrgShareUnitMemberMemberArgs>());
            set => _members = value;
        }

        /// <summary>
        /// Shared unit ID.
        /// </summary>
        [Input("unitId", required: true)]
        public Input<string> UnitId { get; set; } = null!;

        public OrgShareUnitMemberArgs()
        {
        }
        public static new OrgShareUnitMemberArgs Empty => new OrgShareUnitMemberArgs();
    }

    public sealed class OrgShareUnitMemberState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Shared unit region.
        /// </summary>
        [Input("area")]
        public Input<string>? Area { get; set; }

        [Input("members")]
        private InputList<Inputs.OrgShareUnitMemberMemberGetArgs>? _members;

        /// <summary>
        /// Shared member list. Up to 10 items.
        /// </summary>
        public InputList<Inputs.OrgShareUnitMemberMemberGetArgs> Members
        {
            get => _members ?? (_members = new InputList<Inputs.OrgShareUnitMemberMemberGetArgs>());
            set => _members = value;
        }

        /// <summary>
        /// Shared unit ID.
        /// </summary>
        [Input("unitId")]
        public Input<string>? UnitId { get; set; }

        public OrgShareUnitMemberState()
        {
        }
        public static new OrgShareUnitMemberState Empty => new OrgShareUnitMemberState();
    }
}