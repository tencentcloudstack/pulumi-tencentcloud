// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf
{
    public static class GetRepository
    {
        /// <summary>
        /// Use this data source to query detailed information of tsf repository
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
        ///     var repository = Tencentcloud.Tsf.GetRepository.Invoke(new()
        ///     {
        ///         RepositoryType = "default",
        ///         SearchWord = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetRepositoryResult> InvokeAsync(GetRepositoryArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRepositoryResult>("tencentcloud:Tsf/getRepository:getRepository", args ?? new GetRepositoryArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tsf repository
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
        ///     var repository = Tencentcloud.Tsf.GetRepository.Invoke(new()
        ///     {
        ///         RepositoryType = "default",
        ///         SearchWord = "test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetRepositoryResult> Invoke(GetRepositoryInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRepositoryResult>("tencentcloud:Tsf/getRepository:getRepository", args ?? new GetRepositoryInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRepositoryArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Repository type (default Repository: default, private Repository: private).
        /// </summary>
        [Input("repositoryType")]
        public string? RepositoryType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Query keywords (search by Repository name).
        /// </summary>
        [Input("searchWord")]
        public string? SearchWord { get; set; }

        public GetRepositoryArgs()
        {
        }
        public static new GetRepositoryArgs Empty => new GetRepositoryArgs();
    }

    public sealed class GetRepositoryInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Repository type (default Repository: default, private Repository: private).
        /// </summary>
        [Input("repositoryType")]
        public Input<string>? RepositoryType { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Query keywords (search by Repository name).
        /// </summary>
        [Input("searchWord")]
        public Input<string>? SearchWord { get; set; }

        public GetRepositoryInvokeArgs()
        {
        }
        public static new GetRepositoryInvokeArgs Empty => new GetRepositoryInvokeArgs();
    }


    [OutputType]
    public sealed class GetRepositoryResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Repository type (default Repository: default, private Repository: private).
        /// </summary>
        public readonly string? RepositoryType;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// A list of Repository information that meets the query criteria.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRepositoryResultResult> Results;
        public readonly string? SearchWord;

        [OutputConstructor]
        private GetRepositoryResult(
            string id,

            string? repositoryType,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetRepositoryResultResult> results,

            string? searchWord)
        {
            Id = id;
            RepositoryType = repositoryType;
            ResultOutputFile = resultOutputFile;
            Results = results;
            SearchWord = searchWord;
        }
    }
}
