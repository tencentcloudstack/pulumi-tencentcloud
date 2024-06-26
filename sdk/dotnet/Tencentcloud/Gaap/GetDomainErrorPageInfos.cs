// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap
{
    public static class GetDomainErrorPageInfos
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap domain error page infos
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
        ///     var domainErrorPageInfos = Tencentcloud.Gaap.GetDomainErrorPageInfos.Invoke(new()
        ///     {
        ///         ErrorPageIds = new[]
        ///         {
        ///             "errorPage-xxxxxx",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDomainErrorPageInfosResult> InvokeAsync(GetDomainErrorPageInfosArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDomainErrorPageInfosResult>("tencentcloud:Gaap/getDomainErrorPageInfos:getDomainErrorPageInfos", args ?? new GetDomainErrorPageInfosArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap domain error page infos
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
        ///     var domainErrorPageInfos = Tencentcloud.Gaap.GetDomainErrorPageInfos.Invoke(new()
        ///     {
        ///         ErrorPageIds = new[]
        ///         {
        ///             "errorPage-xxxxxx",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDomainErrorPageInfosResult> Invoke(GetDomainErrorPageInfosInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDomainErrorPageInfosResult>("tencentcloud:Gaap/getDomainErrorPageInfos:getDomainErrorPageInfos", args ?? new GetDomainErrorPageInfosInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDomainErrorPageInfosArgs : global::Pulumi.InvokeArgs
    {
        [Input("errorPageIds", required: true)]
        private List<string>? _errorPageIds;

        /// <summary>
        /// Customized error ID list, supporting up to 10.
        /// </summary>
        public List<string> ErrorPageIds
        {
            get => _errorPageIds ?? (_errorPageIds = new List<string>());
            set => _errorPageIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDomainErrorPageInfosArgs()
        {
        }
        public static new GetDomainErrorPageInfosArgs Empty => new GetDomainErrorPageInfosArgs();
    }

    public sealed class GetDomainErrorPageInfosInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("errorPageIds", required: true)]
        private InputList<string>? _errorPageIds;

        /// <summary>
        /// Customized error ID list, supporting up to 10.
        /// </summary>
        public InputList<string> ErrorPageIds
        {
            get => _errorPageIds ?? (_errorPageIds = new InputList<string>());
            set => _errorPageIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDomainErrorPageInfosInvokeArgs()
        {
        }
        public static new GetDomainErrorPageInfosInvokeArgs Empty => new GetDomainErrorPageInfosInvokeArgs();
    }


    [OutputType]
    public sealed class GetDomainErrorPageInfosResult
    {
        public readonly ImmutableArray<string> ErrorPageIds;
        /// <summary>
        /// Custom error response configuration setNote: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDomainErrorPageInfosErrorPageSetResult> ErrorPageSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDomainErrorPageInfosResult(
            ImmutableArray<string> errorPageIds,

            ImmutableArray<Outputs.GetDomainErrorPageInfosErrorPageSetResult> errorPageSets,

            string id,

            string? resultOutputFile)
        {
            ErrorPageIds = errorPageIds;
            ErrorPageSets = errorPageSets;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
