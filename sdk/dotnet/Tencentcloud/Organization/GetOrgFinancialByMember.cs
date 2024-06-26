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
    public static class GetOrgFinancialByMember
    {
        /// <summary>
        /// Use this data source to query detailed information of organization org_financial_by_member
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
        ///     var orgFinancialByMember = Tencentcloud.Organization.GetOrgFinancialByMember.Invoke(new()
        ///     {
        ///         EndMonth = "2023-10",
        ///         MemberUins = new[]
        ///         {
        ///             100015591986,
        ///             100029796005,
        ///         },
        ///         Month = "2023-05",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetOrgFinancialByMemberResult> InvokeAsync(GetOrgFinancialByMemberArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetOrgFinancialByMemberResult>("tencentcloud:Organization/getOrgFinancialByMember:getOrgFinancialByMember", args ?? new GetOrgFinancialByMemberArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of organization org_financial_by_member
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
        ///     var orgFinancialByMember = Tencentcloud.Organization.GetOrgFinancialByMember.Invoke(new()
        ///     {
        ///         EndMonth = "2023-10",
        ///         MemberUins = new[]
        ///         {
        ///             100015591986,
        ///             100029796005,
        ///         },
        ///         Month = "2023-05",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetOrgFinancialByMemberResult> Invoke(GetOrgFinancialByMemberInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetOrgFinancialByMemberResult>("tencentcloud:Organization/getOrgFinancialByMember:getOrgFinancialByMember", args ?? new GetOrgFinancialByMemberInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetOrgFinancialByMemberArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query for the end month. Format:yyyy-mm, for example:2021-01.The default value is the `Month`.
        /// </summary>
        [Input("endMonth")]
        public string? EndMonth { get; set; }

        [Input("memberUins")]
        private List<int>? _memberUins;

        /// <summary>
        /// Member uin list. Up to 100.
        /// </summary>
        public List<int> MemberUins
        {
            get => _memberUins ?? (_memberUins = new List<int>());
            set => _memberUins = value;
        }

        /// <summary>
        /// Query for the start month. Format:yyyy-mm, for example:2021-01.
        /// </summary>
        [Input("month", required: true)]
        public string Month { get; set; } = null!;

        [Input("productCodes")]
        private List<string>? _productCodes;

        /// <summary>
        /// Product code list. Up to 100.
        /// </summary>
        public List<string> ProductCodes
        {
            get => _productCodes ?? (_productCodes = new List<string>());
            set => _productCodes = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetOrgFinancialByMemberArgs()
        {
        }
        public static new GetOrgFinancialByMemberArgs Empty => new GetOrgFinancialByMemberArgs();
    }

    public sealed class GetOrgFinancialByMemberInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Query for the end month. Format:yyyy-mm, for example:2021-01.The default value is the `Month`.
        /// </summary>
        [Input("endMonth")]
        public Input<string>? EndMonth { get; set; }

        [Input("memberUins")]
        private InputList<int>? _memberUins;

        /// <summary>
        /// Member uin list. Up to 100.
        /// </summary>
        public InputList<int> MemberUins
        {
            get => _memberUins ?? (_memberUins = new InputList<int>());
            set => _memberUins = value;
        }

        /// <summary>
        /// Query for the start month. Format:yyyy-mm, for example:2021-01.
        /// </summary>
        [Input("month", required: true)]
        public Input<string> Month { get; set; } = null!;

        [Input("productCodes")]
        private InputList<string>? _productCodes;

        /// <summary>
        /// Product code list. Up to 100.
        /// </summary>
        public InputList<string> ProductCodes
        {
            get => _productCodes ?? (_productCodes = new InputList<string>());
            set => _productCodes = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetOrgFinancialByMemberInvokeArgs()
        {
        }
        public static new GetOrgFinancialByMemberInvokeArgs Empty => new GetOrgFinancialByMemberInvokeArgs();
    }


    [OutputType]
    public sealed class GetOrgFinancialByMemberResult
    {
        public readonly string? EndMonth;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Member financial detail.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetOrgFinancialByMemberItemResult> Items;
        public readonly ImmutableArray<int> MemberUins;
        public readonly string Month;
        public readonly ImmutableArray<string> ProductCodes;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Total cost of the member.
        /// </summary>
        public readonly double TotalCost;

        [OutputConstructor]
        private GetOrgFinancialByMemberResult(
            string? endMonth,

            string id,

            ImmutableArray<Outputs.GetOrgFinancialByMemberItemResult> items,

            ImmutableArray<int> memberUins,

            string month,

            ImmutableArray<string> productCodes,

            string? resultOutputFile,

            double totalCost)
        {
            EndMonth = endMonth;
            Id = id;
            Items = items;
            MemberUins = memberUins;
            Month = month;
            ProductCodes = productCodes;
            ResultOutputFile = resultOutputFile;
            TotalCost = totalCost;
        }
    }
}
