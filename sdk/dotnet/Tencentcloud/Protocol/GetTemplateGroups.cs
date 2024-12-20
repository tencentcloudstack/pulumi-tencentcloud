// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Protocol
{
    public static class GetTemplateGroups
    {
        /// <summary>
        /// Use this data source to query detailed information of protocol template groups.
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
        ///     var name = Tencentcloud.Protocol.GetTemplateGroups.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTemplateGroupsResult> InvokeAsync(GetTemplateGroupsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTemplateGroupsResult>("tencentcloud:Protocol/getTemplateGroups:getTemplateGroups", args ?? new GetTemplateGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of protocol template groups.
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
        ///     var name = Tencentcloud.Protocol.GetTemplateGroups.Invoke(new()
        ///     {
        ///         Name = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTemplateGroupsResult> Invoke(GetTemplateGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTemplateGroupsResult>("tencentcloud:Protocol/getTemplateGroups:getTemplateGroups", args ?? new GetTemplateGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTemplateGroupsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the protocol template group to query.
        /// </summary>
        [Input("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Name of the protocol template group to query.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTemplateGroupsArgs()
        {
        }
        public static new GetTemplateGroupsArgs Empty => new GetTemplateGroupsArgs();
    }

    public sealed class GetTemplateGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// ID of the protocol template group to query.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        /// <summary>
        /// Name of the protocol template group to query.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTemplateGroupsInvokeArgs()
        {
        }
        public static new GetTemplateGroupsInvokeArgs Empty => new GetTemplateGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetTemplateGroupsResult
    {
        /// <summary>
        /// Information list of the dedicated protocol template groups.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateGroupsGroupListResult> GroupLists;
        /// <summary>
        /// Id of the protocol template group.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Name of protocol template group.
        /// </summary>
        public readonly string? Name;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetTemplateGroupsResult(
            ImmutableArray<Outputs.GetTemplateGroupsGroupListResult> groupLists,

            string? id,

            string? name,

            string? resultOutputFile)
        {
            GroupLists = groupLists;
            Id = id;
            Name = name;
            ResultOutputFile = resultOutputFile;
        }
    }
}
