// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Bi
{
    /// <summary>
    /// Provides a resource to create a bi user_role
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
    ///     var userRole = new Tencentcloud.Bi.UserRole("userRole", new()
    ///     {
    ///         AreaCode = "+83",
    ///         Email = "1055000000@qq.com",
    ///         PhoneNumber = "13470010000",
    ///         RoleIdLists = new[]
    ///         {
    ///             10629359,
    ///         },
    ///         UserId = "100032767426",
    ///         UserName = "keep-iac-test",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// bi user_role can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Bi/userRole:UserRole user_role user_id
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Bi/userRole:UserRole")]
    public partial class UserRole : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Mobile area code(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Output("areaCode")]
        public Output<string> AreaCode { get; private set; } = null!;

        /// <summary>
        /// E-mail(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Output("email")]
        public Output<string> Email { get; private set; } = null!;

        /// <summary>
        /// Phone number(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Output("phoneNumber")]
        public Output<string> PhoneNumber { get; private set; } = null!;

        /// <summary>
        /// Role id list.
        /// </summary>
        [Output("roleIdLists")]
        public Output<ImmutableArray<int>> RoleIdLists { get; private set; } = null!;

        /// <summary>
        /// User id.
        /// </summary>
        [Output("userId")]
        public Output<string> UserId { get; private set; } = null!;

        /// <summary>
        /// Username.
        /// </summary>
        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;


        /// <summary>
        /// Create a UserRole resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public UserRole(string name, UserRoleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Bi/userRole:UserRole", name, args ?? new UserRoleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private UserRole(string name, Input<string> id, UserRoleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Bi/userRole:UserRole", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing UserRole resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static UserRole Get(string name, Input<string> id, UserRoleState? state = null, CustomResourceOptions? options = null)
        {
            return new UserRole(name, id, state, options);
        }
    }

    public sealed class UserRoleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Mobile area code(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("areaCode", required: true)]
        public Input<string> AreaCode { get; set; } = null!;

        /// <summary>
        /// E-mail(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("email", required: true)]
        public Input<string> Email { get; set; } = null!;

        /// <summary>
        /// Phone number(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("phoneNumber", required: true)]
        public Input<string> PhoneNumber { get; set; } = null!;

        [Input("roleIdLists", required: true)]
        private InputList<int>? _roleIdLists;

        /// <summary>
        /// Role id list.
        /// </summary>
        public InputList<int> RoleIdLists
        {
            get => _roleIdLists ?? (_roleIdLists = new InputList<int>());
            set => _roleIdLists = value;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [Input("userId", required: true)]
        public Input<string> UserId { get; set; } = null!;

        /// <summary>
        /// Username.
        /// </summary>
        [Input("userName", required: true)]
        public Input<string> UserName { get; set; } = null!;

        public UserRoleArgs()
        {
        }
        public static new UserRoleArgs Empty => new UserRoleArgs();
    }

    public sealed class UserRoleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Mobile area code(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("areaCode")]
        public Input<string>? AreaCode { get; set; }

        /// <summary>
        /// E-mail(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// Phone number(Note: This field may return null, indicating that no valid value can be obtained).
        /// </summary>
        [Input("phoneNumber")]
        public Input<string>? PhoneNumber { get; set; }

        [Input("roleIdLists")]
        private InputList<int>? _roleIdLists;

        /// <summary>
        /// Role id list.
        /// </summary>
        public InputList<int> RoleIdLists
        {
            get => _roleIdLists ?? (_roleIdLists = new InputList<int>());
            set => _roleIdLists = value;
        }

        /// <summary>
        /// User id.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public UserRoleState()
        {
        }
        public static new UserRoleState Empty => new UserRoleState();
    }
}
