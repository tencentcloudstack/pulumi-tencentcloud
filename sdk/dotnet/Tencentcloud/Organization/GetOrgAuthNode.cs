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
    public static class GetOrgAuthNode
    {
        /// <summary>
        /// Use this data source to query detailed information of organization org_auth_node
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
        ///     var orgAuthNode = Tencentcloud.Organization.GetOrgAuthNode.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetOrgAuthNodeResult> InvokeAsync(GetOrgAuthNodeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOrgAuthNodeResult>("tencentcloud:Organization/getOrgAuthNode:getOrgAuthNode", args ?? new GetOrgAuthNodeArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of organization org_auth_node
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
        ///     var orgAuthNode = Tencentcloud.Organization.GetOrgAuthNode.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetOrgAuthNodeResult> Invoke(GetOrgAuthNodeInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOrgAuthNodeResult>("tencentcloud:Organization/getOrgAuthNode:getOrgAuthNode", args ?? new GetOrgAuthNodeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrgAuthNodeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Verified company name.
        /// </summary>
        [Input("authName")]
        public string? AuthName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetOrgAuthNodeArgs()
        {
        }
        public static new GetOrgAuthNodeArgs Empty => new GetOrgAuthNodeArgs();
    }

    public sealed class GetOrgAuthNodeInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Verified company name.
        /// </summary>
        [Input("authName")]
        public Input<string>? AuthName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetOrgAuthNodeInvokeArgs()
        {
        }
        public static new GetOrgAuthNodeInvokeArgs Empty => new GetOrgAuthNodeInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrgAuthNodeResult
    {
        /// <summary>
        /// Verified company name.
        /// </summary>
        public readonly string? AuthName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Organization auth node list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetOrgAuthNodeItemResult> Items;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetOrgAuthNodeResult(
            string? authName,

            string id,

            ImmutableArray<Outputs.GetOrgAuthNodeItemResult> items,

            string? resultOutputFile)
        {
            AuthName = authName;
            Id = id;
            Items = items;
            ResultOutputFile = resultOutputFile;
        }
    }
}
