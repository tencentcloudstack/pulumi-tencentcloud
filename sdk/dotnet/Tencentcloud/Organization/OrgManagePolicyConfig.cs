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
    /// Provides a resource to create a organization org_manage_policy_config
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
    ///     var orgManagePolicyConfig = new Tencentcloud.Organization.OrgManagePolicyConfig("orgManagePolicyConfig", new()
    ///     {
    ///         OrganizationId = 80001,
    ///         PolicyType = "SERVICE_CONTROL_POLICY",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// organization org_manage_policy_config can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig org_manage_policy_config organization_id#policy_type
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig")]
    public partial class OrgManagePolicyConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Organization ID.
        /// </summary>
        [Output("organizationId")]
        public Output<int> OrganizationId { get; private set; } = null!;

        /// <summary>
        /// Policy type. Default value is SERVICE_CONTROL_POLICY.
        /// Valid values:
        /// </summary>
        [Output("policyType")]
        public Output<string?> PolicyType { get; private set; } = null!;


        /// <summary>
        /// Create a OrgManagePolicyConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public OrgManagePolicyConfig(string name, OrgManagePolicyConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig", name, args ?? new OrgManagePolicyConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private OrgManagePolicyConfig(string name, Input<string> id, OrgManagePolicyConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Organization/orgManagePolicyConfig:OrgManagePolicyConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing OrgManagePolicyConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static OrgManagePolicyConfig Get(string name, Input<string> id, OrgManagePolicyConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new OrgManagePolicyConfig(name, id, state, options);
        }
    }

    public sealed class OrgManagePolicyConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Organization ID.
        /// </summary>
        [Input("organizationId", required: true)]
        public Input<int> OrganizationId { get; set; } = null!;

        /// <summary>
        /// Policy type. Default value is SERVICE_CONTROL_POLICY.
        /// Valid values:
        /// </summary>
        [Input("policyType")]
        public Input<string>? PolicyType { get; set; }

        public OrgManagePolicyConfigArgs()
        {
        }
        public static new OrgManagePolicyConfigArgs Empty => new OrgManagePolicyConfigArgs();
    }

    public sealed class OrgManagePolicyConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Organization ID.
        /// </summary>
        [Input("organizationId")]
        public Input<int>? OrganizationId { get; set; }

        /// <summary>
        /// Policy type. Default value is SERVICE_CONTROL_POLICY.
        /// Valid values:
        /// </summary>
        [Input("policyType")]
        public Input<string>? PolicyType { get; set; }

        public OrgManagePolicyConfigState()
        {
        }
        public static new OrgManagePolicyConfigState Empty => new OrgManagePolicyConfigState();
    }
}