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
    public static class GetCenterGroups
    {
        /// <summary>
        /// Use this data source to query detailed information of identity center groups
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
        ///     var identityCenterGroups = Tencentcloud.Identity.GetCenterGroups.Invoke(new()
        ///     {
        ///         ZoneId = "z-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetCenterGroupsResult> InvokeAsync(GetCenterGroupsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCenterGroupsResult>("tencentcloud:Identity/getCenterGroups:getCenterGroups", args ?? new GetCenterGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of identity center groups
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
        ///     var identityCenterGroups = Tencentcloud.Identity.GetCenterGroups.Invoke(new()
        ///     {
        ///         ZoneId = "z-xxxxxx",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetCenterGroupsResult> Invoke(GetCenterGroupsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCenterGroupsResult>("tencentcloud:Identity/getCenterGroups:getCenterGroups", args ?? new GetCenterGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCenterGroupsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter criterion. Format: &lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;, case-insensitive. Currently, &lt;Attribute&gt; supports only GroupName, and &lt;Operator&gt; supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
        /// </summary>
        [Input("filter")]
        public string? Filter { get; set; }

        [Input("filterUsers")]
        private List<string>? _filterUsers;

        /// <summary>
        /// Filtered user. IsSelected=1 will be returned for the user group associated with this user.
        /// </summary>
        public List<string> FilterUsers
        {
            get => _filterUsers ?? (_filterUsers = new List<string>());
            set => _filterUsers = value;
        }

        /// <summary>
        /// User group type. Manual: manually created; Synchronized: externally imported.
        /// </summary>
        [Input("groupType")]
        public string? GroupType { get; set; }

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
        /// Space ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public string ZoneId { get; set; } = null!;

        public GetCenterGroupsArgs()
        {
        }
        public static new GetCenterGroupsArgs Empty => new GetCenterGroupsArgs();
    }

    public sealed class GetCenterGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter criterion. Format: &lt;Attribute&gt; &lt;Operator&gt; &lt;Value&gt;, case-insensitive. Currently, &lt;Attribute&gt; supports only GroupName, and &lt;Operator&gt; supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        [Input("filterUsers")]
        private InputList<string>? _filterUsers;

        /// <summary>
        /// Filtered user. IsSelected=1 will be returned for the user group associated with this user.
        /// </summary>
        public InputList<string> FilterUsers
        {
            get => _filterUsers ?? (_filterUsers = new InputList<string>());
            set => _filterUsers = value;
        }

        /// <summary>
        /// User group type. Manual: manually created; Synchronized: externally imported.
        /// </summary>
        [Input("groupType")]
        public Input<string>? GroupType { get; set; }

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
        /// Space ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public GetCenterGroupsInvokeArgs()
        {
        }
        public static new GetCenterGroupsInvokeArgs Empty => new GetCenterGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetCenterGroupsResult
    {
        public readonly string? Filter;
        public readonly ImmutableArray<string> FilterUsers;
        public readonly string? GroupType;
        /// <summary>
        /// User group list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetCenterGroupsGroupResult> Groups;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly string? SortField;
        public readonly string? SortType;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetCenterGroupsResult(
            string? filter,

            ImmutableArray<string> filterUsers,

            string? groupType,

            ImmutableArray<Outputs.GetCenterGroupsGroupResult> groups,

            string id,

            string? resultOutputFile,

            string? sortField,

            string? sortType,

            string zoneId)
        {
            Filter = filter;
            FilterUsers = filterUsers;
            GroupType = groupType;
            Groups = groups;
            Id = id;
            ResultOutputFile = resultOutputFile;
            SortField = sortField;
            SortType = sortType;
            ZoneId = zoneId;
        }
    }
}
