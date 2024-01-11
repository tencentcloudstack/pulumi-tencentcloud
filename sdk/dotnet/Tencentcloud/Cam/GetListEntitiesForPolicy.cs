// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cam
{
    public static class GetListEntitiesForPolicy
    {
        /// <summary>
        /// Use this data source to query detailed information of cam list_entities_for_policy
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
        ///         var listEntitiesForPolicy = Output.Create(Tencentcloud.Cam.GetListEntitiesForPolicy.InvokeAsync(new Tencentcloud.Cam.GetListEntitiesForPolicyArgs
        ///         {
        ///             EntityFilter = "All",
        ///             PolicyId = 1,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetListEntitiesForPolicyResult> InvokeAsync(GetListEntitiesForPolicyArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetListEntitiesForPolicyResult>("tencentcloud:Cam/getListEntitiesForPolicy:getListEntitiesForPolicy", args ?? new GetListEntitiesForPolicyArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cam list_entities_for_policy
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
        ///         var listEntitiesForPolicy = Output.Create(Tencentcloud.Cam.GetListEntitiesForPolicy.InvokeAsync(new Tencentcloud.Cam.GetListEntitiesForPolicyArgs
        ///         {
        ///             EntityFilter = "All",
        ///             PolicyId = 1,
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetListEntitiesForPolicyResult> Invoke(GetListEntitiesForPolicyInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetListEntitiesForPolicyResult>("tencentcloud:Cam/getListEntitiesForPolicy:getListEntitiesForPolicy", args ?? new GetListEntitiesForPolicyInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetListEntitiesForPolicyArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Can take values of &amp;amp;amp;#39;All&amp;amp;amp;#39;, &amp;amp;amp;#39;User&amp;amp;amp;#39;, &amp;amp;amp;#39;Group&amp;amp;amp;#39;, and &amp;amp;amp;#39;Role&amp;amp;amp;#39;. &amp;amp;amp;#39;All&amp;amp;amp;#39; represents obtaining all entity types, &amp;amp;amp;#39;User&amp;amp;amp;#39; represents only obtaining sub accounts, &amp;amp;amp;#39;Group&amp;amp;amp;#39; represents only obtaining user groups, and &amp;amp;amp;#39;Role&amp;amp;amp;#39; represents only obtaining roles. The default value is&amp;amp;amp;#39; All &amp;amp;amp;#39;.
        /// </summary>
        [Input("entityFilter")]
        public string? EntityFilter { get; set; }

        /// <summary>
        /// Policy Id.
        /// </summary>
        [Input("policyId", required: true)]
        public int PolicyId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Per page size, default value is 20.
        /// </summary>
        [Input("rp")]
        public int? Rp { get; set; }

        public GetListEntitiesForPolicyArgs()
        {
        }
    }

    public sealed class GetListEntitiesForPolicyInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Can take values of &amp;amp;amp;#39;All&amp;amp;amp;#39;, &amp;amp;amp;#39;User&amp;amp;amp;#39;, &amp;amp;amp;#39;Group&amp;amp;amp;#39;, and &amp;amp;amp;#39;Role&amp;amp;amp;#39;. &amp;amp;amp;#39;All&amp;amp;amp;#39; represents obtaining all entity types, &amp;amp;amp;#39;User&amp;amp;amp;#39; represents only obtaining sub accounts, &amp;amp;amp;#39;Group&amp;amp;amp;#39; represents only obtaining user groups, and &amp;amp;amp;#39;Role&amp;amp;amp;#39; represents only obtaining roles. The default value is&amp;amp;amp;#39; All &amp;amp;amp;#39;.
        /// </summary>
        [Input("entityFilter")]
        public Input<string>? EntityFilter { get; set; }

        /// <summary>
        /// Policy Id.
        /// </summary>
        [Input("policyId", required: true)]
        public Input<int> PolicyId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Per page size, default value is 20.
        /// </summary>
        [Input("rp")]
        public Input<int>? Rp { get; set; }

        public GetListEntitiesForPolicyInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetListEntitiesForPolicyResult
    {
        public readonly string? EntityFilter;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Entity ListNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetListEntitiesForPolicyListResult> Lists;
        public readonly int PolicyId;
        public readonly string? ResultOutputFile;
        public readonly int? Rp;

        [OutputConstructor]
        private GetListEntitiesForPolicyResult(
            string? entityFilter,

            string id,

            ImmutableArray<Outputs.GetListEntitiesForPolicyListResult> lists,

            int policyId,

            string? resultOutputFile,

            int? rp)
        {
            EntityFilter = entityFilter;
            Id = id;
            Lists = lists;
            PolicyId = policyId;
            ResultOutputFile = resultOutputFile;
            Rp = rp;
        }
    }
}