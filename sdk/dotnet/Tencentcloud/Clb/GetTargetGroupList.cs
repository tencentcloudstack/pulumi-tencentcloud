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
    public static class GetTargetGroupList
    {
        /// <summary>
        /// Use this data source to query detailed information of clb target_group_list
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var targetGroupList = Output.Create(Tencentcloud.Clb.GetTargetGroupList.InvokeAsync(new Tencentcloud.Clb.GetTargetGroupListArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Clb.Inputs.GetTargetGroupListFilterArgs
        ///                 {
        ///                     Name = "TargetGroupName",
        ///                     Values = 
        ///                     {
        ///                         "keep-tgg",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetTargetGroupListResult> InvokeAsync(GetTargetGroupListArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetTargetGroupListResult>("tencentcloud:Clb/getTargetGroupList:getTargetGroupList", args ?? new GetTargetGroupListArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of clb target_group_list
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var targetGroupList = Output.Create(Tencentcloud.Clb.GetTargetGroupList.InvokeAsync(new Tencentcloud.Clb.GetTargetGroupListArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Clb.Inputs.GetTargetGroupListFilterArgs
        ///                 {
        ///                     Name = "TargetGroupName",
        ///                     Values = 
        ///                     {
        ///                         "keep-tgg",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetTargetGroupListResult> Invoke(GetTargetGroupListInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetTargetGroupListResult>("tencentcloud:Clb/getTargetGroupList:getTargetGroupList", args ?? new GetTargetGroupListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTargetGroupListArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetTargetGroupListFilterArgs>? _filters;

        /// <summary>
        /// Filter array, which is exclusive of TargetGroupIds. Valid values: TargetGroupVpcId and TargetGroupName. Target group ID will be used first.
        /// </summary>
        public List<Inputs.GetTargetGroupListFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetTargetGroupListFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("targetGroupIds")]
        private List<string>? _targetGroupIds;

        /// <summary>
        /// Target group ID array.
        /// </summary>
        public List<string> TargetGroupIds
        {
            get => _targetGroupIds ?? (_targetGroupIds = new List<string>());
            set => _targetGroupIds = value;
        }

        public GetTargetGroupListArgs()
        {
        }
    }

    public sealed class GetTargetGroupListInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetTargetGroupListFilterInputArgs>? _filters;

        /// <summary>
        /// Filter array, which is exclusive of TargetGroupIds. Valid values: TargetGroupVpcId and TargetGroupName. Target group ID will be used first.
        /// </summary>
        public InputList<Inputs.GetTargetGroupListFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetTargetGroupListFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("targetGroupIds")]
        private InputList<string>? _targetGroupIds;

        /// <summary>
        /// Target group ID array.
        /// </summary>
        public InputList<string> TargetGroupIds
        {
            get => _targetGroupIds ?? (_targetGroupIds = new InputList<string>());
            set => _targetGroupIds = value;
        }

        public GetTargetGroupListInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetTargetGroupListResult
    {
        public readonly ImmutableArray<Outputs.GetTargetGroupListFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> TargetGroupIds;
        /// <summary>
        /// Information set of displayed target groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTargetGroupListTargetGroupSetResult> TargetGroupSets;

        [OutputConstructor]
        private GetTargetGroupListResult(
            ImmutableArray<Outputs.GetTargetGroupListFilterResult> filters,

            string id,

            string? resultOutputFile,

            ImmutableArray<string> targetGroupIds,

            ImmutableArray<Outputs.GetTargetGroupListTargetGroupSetResult> targetGroupSets)
        {
            Filters = filters;
            Id = id;
            ResultOutputFile = resultOutputFile;
            TargetGroupIds = targetGroupIds;
            TargetGroupSets = targetGroupSets;
        }
    }
}