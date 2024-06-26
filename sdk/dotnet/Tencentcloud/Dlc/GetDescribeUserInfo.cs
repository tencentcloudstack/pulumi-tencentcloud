// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dlc
{
    public static class GetDescribeUserInfo
    {
        /// <summary>
        /// Use this data source to query detailed information of dlc describe_user_info
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
        ///     var describeUserInfo = Tencentcloud.Dlc.GetDescribeUserInfo.Invoke(new()
        ///     {
        ///         SortBy = "create-time",
        ///         Sorting = "desc",
        ///         Type = "Group",
        ///         UserId = "100032772113",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDescribeUserInfoResult> InvokeAsync(GetDescribeUserInfoArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDescribeUserInfoResult>("tencentcloud:Dlc/getDescribeUserInfo:getDescribeUserInfo", args ?? new GetDescribeUserInfoArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dlc describe_user_info
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
        ///     var describeUserInfo = Tencentcloud.Dlc.GetDescribeUserInfo.Invoke(new()
        ///     {
        ///         SortBy = "create-time",
        ///         Sorting = "desc",
        ///         Type = "Group",
        ///         UserId = "100032772113",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDescribeUserInfoResult> Invoke(GetDescribeUserInfoInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDescribeUserInfoResult>("tencentcloud:Dlc/getDescribeUserInfo:getDescribeUserInfo", args ?? new GetDescribeUserInfoInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDescribeUserInfoArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetDescribeUserInfoFilterArgs>? _filters;

        /// <summary>
        /// Query filter conditions. when type is Group, fuzzy search with Key as workgroup-name is supported. when type is DataAuth, key is supported. policy-type: permission type, policy-source: data source, data-name: database table. Fuzzy search, when type is EngineAuth, supports fuzzy search of key, policy-type: permission type, policy-source: data source, engine-name: library table.
        /// </summary>
        public List<Inputs.GetDescribeUserInfoFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDescribeUserInfoFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Sorting field, when type is Group, support create-time, group-name, when type is DataAuth, support create-time, when type is EngineAuth, support create-time.
        /// </summary>
        [Input("sortBy")]
        public string? SortBy { get; set; }

        /// <summary>
        /// Sorting method, desc means forward order, asc means reverse order, the default is asc.
        /// </summary>
        [Input("sorting")]
        public string? Sorting { get; set; }

        /// <summary>
        /// Query information type, Group: work group DataAuth: data permission EngineAuth: engine permission.
        /// </summary>
        [Input("type")]
        public string? Type { get; set; }

        /// <summary>
        /// User id, the same as the sub-user uin.
        /// </summary>
        [Input("userId")]
        public string? UserId { get; set; }

        public GetDescribeUserInfoArgs()
        {
        }
        public static new GetDescribeUserInfoArgs Empty => new GetDescribeUserInfoArgs();
    }

    public sealed class GetDescribeUserInfoInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetDescribeUserInfoFilterInputArgs>? _filters;

        /// <summary>
        /// Query filter conditions. when type is Group, fuzzy search with Key as workgroup-name is supported. when type is DataAuth, key is supported. policy-type: permission type, policy-source: data source, data-name: database table. Fuzzy search, when type is EngineAuth, supports fuzzy search of key, policy-type: permission type, policy-source: data source, engine-name: library table.
        /// </summary>
        public InputList<Inputs.GetDescribeUserInfoFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetDescribeUserInfoFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Sorting field, when type is Group, support create-time, group-name, when type is DataAuth, support create-time, when type is EngineAuth, support create-time.
        /// </summary>
        [Input("sortBy")]
        public Input<string>? SortBy { get; set; }

        /// <summary>
        /// Sorting method, desc means forward order, asc means reverse order, the default is asc.
        /// </summary>
        [Input("sorting")]
        public Input<string>? Sorting { get; set; }

        /// <summary>
        /// Query information type, Group: work group DataAuth: data permission EngineAuth: engine permission.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// User id, the same as the sub-user uin.
        /// </summary>
        [Input("userId")]
        public Input<string>? UserId { get; set; }

        public GetDescribeUserInfoInvokeArgs()
        {
        }
        public static new GetDescribeUserInfoInvokeArgs Empty => new GetDescribeUserInfoInvokeArgs();
    }


    [OutputType]
    public sealed class GetDescribeUserInfoResult
    {
        public readonly ImmutableArray<Outputs.GetDescribeUserInfoFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly string? SortBy;
        public readonly string? Sorting;
        /// <summary>
        /// The type of information returned, Group: the returned workgroup information of the current user; DataAuth: the returned data permission information of the current user; EngineAuth: the returned engine permission information of the current user.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// User id, the same as the sub-user uin.
        /// </summary>
        public readonly string? UserId;
        /// <summary>
        /// User details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDescribeUserInfoUserInfoResult> UserInfos;

        [OutputConstructor]
        private GetDescribeUserInfoResult(
            ImmutableArray<Outputs.GetDescribeUserInfoFilterResult> filters,

            string id,

            string? resultOutputFile,

            string? sortBy,

            string? sorting,

            string? type,

            string? userId,

            ImmutableArray<Outputs.GetDescribeUserInfoUserInfoResult> userInfos)
        {
            Filters = filters;
            Id = id;
            ResultOutputFile = resultOutputFile;
            SortBy = sortBy;
            Sorting = sorting;
            Type = type;
            UserId = userId;
            UserInfos = userInfos;
        }
    }
}
