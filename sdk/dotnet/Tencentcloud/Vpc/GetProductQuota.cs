// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetProductQuota
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc product_quota
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
        ///     var productQuota = Tencentcloud.Vpc.GetProductQuota.Invoke(new()
        ///     {
        ///         Product = "vpc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetProductQuotaResult> InvokeAsync(GetProductQuotaArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProductQuotaResult>("tencentcloud:Vpc/getProductQuota:getProductQuota", args ?? new GetProductQuotaArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc product_quota
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
        ///     var productQuota = Tencentcloud.Vpc.GetProductQuota.Invoke(new()
        ///     {
        ///         Product = "vpc",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetProductQuotaResult> Invoke(GetProductQuotaInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProductQuotaResult>("tencentcloud:Vpc/getProductQuota:getProductQuota", args ?? new GetProductQuotaInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProductQuotaArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the network product to be queried. The products that can be queried are:vpc, ccn, vpn, dc, dfw, clb, eip.
        /// </summary>
        [Input("product", required: true)]
        public string Product { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetProductQuotaArgs()
        {
        }
        public static new GetProductQuotaArgs Empty => new GetProductQuotaArgs();
    }

    public sealed class GetProductQuotaInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the network product to be queried. The products that can be queried are:vpc, ccn, vpn, dc, dfw, clb, eip.
        /// </summary>
        [Input("product", required: true)]
        public Input<string> Product { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetProductQuotaInvokeArgs()
        {
        }
        public static new GetProductQuotaInvokeArgs Empty => new GetProductQuotaInvokeArgs();
    }


    [OutputType]
    public sealed class GetProductQuotaResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Product;
        /// <summary>
        /// ProductQuota Array.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetProductQuotaProductQuotaSetResult> ProductQuotaSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetProductQuotaResult(
            string id,

            string product,

            ImmutableArray<Outputs.GetProductQuotaProductQuotaSetResult> productQuotaSets,

            string? resultOutputFile)
        {
            Id = id;
            Product = product;
            ProductQuotaSets = productQuotaSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}
