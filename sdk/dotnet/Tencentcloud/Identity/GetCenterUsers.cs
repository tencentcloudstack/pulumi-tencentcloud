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
    public static class GetCenterUsers
    {
        /// <summary>
        /// Use this data source to query detailed information of identity center users
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var identityCenterUsers = Tencentcloud.Identity.GetCenterUsers.Invoke(new()
        ///     {
        ///         ZoneId = "z-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetCenterUsersResult> InvokeAsync(GetCenterUsersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCenterUsersResult>("tencentcloud:Identity/getCenterUsers:getCenterUsers", args ?? new GetCenterUsersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of identity center users
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var identityCenterUsers = Tencentcloud.Identity.GetCenterUsers.Invoke(new()
        ///     {
        ///         ZoneId = "z-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetCenterUsersResult> Invoke(GetCenterUsersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCenterUsersResult>("tencentcloud:Identity/getCenterUsers:getCenterUsers", args ?? new GetCenterUsersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCenterUsersArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter criterion, which currently only supports username, email address, userId, and description.
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        [Input("filterGroups")]
        private List<string>? _filterGroups;

        /// <summary>
        /// Filtered user group. IsSelected=1 will be returned for the sub-user associated with this user group.
        /// </summary>
        public List<string> FilterGroups
        {
            get => _filterGroups ?? (_filterGroups = new List<string>());
            set => _filterGroups = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
        /// </summary>
        [Input("sortField")]
        public string? SortField { get; set; }

        /// <summary>
        /// Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
        /// </summary>
        [Input("sortType")]
        public string? SortType { get; set; }

        /// <summary>
        /// User status: Enabled, Disabled.
        /// </summary>
        [Input("userStatus")]
        public string? UserStatus { get; set; }

        /// <summary>
        /// User type. Manual: manually created; Synchronized: externally imported.
        /// </summary>
        [Input("userType")]
        public string? UserType { get; set; }

        /// <summary>
        /// Space ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public string ZoneId { get; set; } = null!;

        public GetCenterUsersArgs()
        {
        }
        public static new GetCenterUsersArgs Empty => new GetCenterUsersArgs();
    }

    public sealed class GetCenterUsersInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter criterion, which currently only supports username, email address, userId, and description.
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        [Input("filterGroups")]
        private InputList<string>? _filterGroups;

        /// <summary>
        /// Filtered user group. IsSelected=1 will be returned for the sub-user associated with this user group.
        /// </summary>
        public InputList<string> FilterGroups
        {
            get => _filterGroups ?? (_filterGroups = new InputList<string>());
            set => _filterGroups = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
        /// </summary>
        [Input("sortField")]
        public Input<string>? SortField { get; set; }

        /// <summary>
        /// Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
        /// </summary>
        [Input("sortType")]
        public Input<string>? SortType { get; set; }

        /// <summary>
        /// User status: Enabled, Disabled.
        /// </summary>
        [Input("userStatus")]
        public Input<string>? UserStatus { get; set; }

        /// <summary>
        /// User type. Manual: manually created; Synchronized: externally imported.
        /// </summary>
        [Input("userType")]
        public Input<string>? UserType { get; set; }

        /// <summary>
        /// Space ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public GetCenterUsersInvokeArgs()
        {
        }
        public static new GetCenterUsersInvokeArgs Empty => new GetCenterUsersInvokeArgs();
    }


    [OutputType]
    public sealed class GetCenterUsersResult
    {
        public readonly string? Filter;
        public readonly ImmutableArray<string> FilterGroups;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly string? SortField;
        public readonly string? SortType;
        public readonly string? UserStatus;
        public readonly string? UserType;
        /// <summary>
        /// User list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCenterUsersUserResult> Users;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetCenterUsersResult(
            string? filter,

            ImmutableArray<string> filterGroups,

            string id,

            string? resultOutputFile,

            string? sortField,

            string? sortType,

            string? userStatus,

            string? userType,

            ImmutableArray<Outputs.GetCenterUsersUserResult> users,

            string zoneId)
        {
            Filter = filter;
            FilterGroups = filterGroups;
            Id = id;
            ResultOutputFile = resultOutputFile;
            SortField = sortField;
            SortType = sortType;
            UserStatus = userStatus;
            UserType = userType;
            Users = users;
            ZoneId = zoneId;
        }
    }
}