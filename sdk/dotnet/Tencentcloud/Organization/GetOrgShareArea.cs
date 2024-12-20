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
    public static class GetOrgShareArea
    {
        /// <summary>
        /// Use this data source to query detailed information of organization org_share_area
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
        ///     var orgShareArea = Tencentcloud.Organization.GetOrgShareArea.Invoke(new()
        ///     {
        ///         Lang = "zh",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetOrgShareAreaResult> InvokeAsync(GetOrgShareAreaArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOrgShareAreaResult>("tencentcloud:Organization/getOrgShareArea:getOrgShareArea", args ?? new GetOrgShareAreaArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of organization org_share_area
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
        ///     var orgShareArea = Tencentcloud.Organization.GetOrgShareArea.Invoke(new()
        ///     {
        ///         Lang = "zh",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetOrgShareAreaResult> Invoke(GetOrgShareAreaInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOrgShareAreaResult>("tencentcloud:Organization/getOrgShareArea:getOrgShareArea", args ?? new GetOrgShareAreaInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrgShareAreaArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Language.default zh.
        /// Valid values:
        /// </summary>
        [Input("lang")]
        public string? Lang { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetOrgShareAreaArgs()
        {
        }
        public static new GetOrgShareAreaArgs Empty => new GetOrgShareAreaArgs();
    }

    public sealed class GetOrgShareAreaInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Language.default zh.
        /// Valid values:
        /// </summary>
        [Input("lang")]
        public Input<string>? Lang { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetOrgShareAreaInvokeArgs()
        {
        }
        public static new GetOrgShareAreaInvokeArgs Empty => new GetOrgShareAreaInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrgShareAreaResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Area list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetOrgShareAreaItemResult> Items;
        public readonly string? Lang;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetOrgShareAreaResult(
            string id,

            ImmutableArray<Outputs.GetOrgShareAreaItemResult> items,

            string? lang,

            string? resultOutputFile)
        {
            Id = id;
            Items = items;
            Lang = lang;
            ResultOutputFile = resultOutputFile;
        }
    }
}
