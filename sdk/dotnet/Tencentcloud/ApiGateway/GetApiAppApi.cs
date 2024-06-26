// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway
{
    public static class GetApiAppApi
    {
        /// <summary>
        /// Use this data source to query detailed information of apiGateway api_app_api
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
        ///     var example = Tencentcloud.ApiGateway.GetApiAppApi.Invoke(new()
        ///     {
        ///         ApiId = "api-0cvmf4x4",
        ///         ApiRegion = "ap-guangzhou",
        ///         ServiceId = "service-nxz6yync",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetApiAppApiResult> InvokeAsync(GetApiAppApiArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiAppApiResult>("tencentcloud:ApiGateway/getApiAppApi:getApiAppApi", args ?? new GetApiAppApiArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of apiGateway api_app_api
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
        ///     var example = Tencentcloud.ApiGateway.GetApiAppApi.Invoke(new()
        ///     {
        ///         ApiId = "api-0cvmf4x4",
        ///         ApiRegion = "ap-guangzhou",
        ///         ServiceId = "service-nxz6yync",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetApiAppApiResult> Invoke(GetApiAppApiInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiAppApiResult>("tencentcloud:ApiGateway/getApiAppApi:getApiAppApi", args ?? new GetApiAppApiInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiAppApiArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// API interface unique ID.
        /// </summary>
        [Input("apiId", required: true)]
        public string ApiId { get; set; } = null!;

        /// <summary>
        /// Api region.
        /// </summary>
        [Input("apiRegion", required: true)]
        public string ApiRegion { get; set; } = null!;

        /// <summary>
        /// Used to save apiAppApis.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// The unique ID of the service where the API resides.
        /// </summary>
        [Input("serviceId", required: true)]
        public string ServiceId { get; set; } = null!;

        public GetApiAppApiArgs()
        {
        }
        public static new GetApiAppApiArgs Empty => new GetApiAppApiArgs();
    }

    public sealed class GetApiAppApiInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// API interface unique ID.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// Api region.
        /// </summary>
        [Input("apiRegion", required: true)]
        public Input<string> ApiRegion { get; set; } = null!;

        /// <summary>
        /// Used to save apiAppApis.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// The unique ID of the service where the API resides.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public GetApiAppApiInvokeArgs()
        {
        }
        public static new GetApiAppApiInvokeArgs Empty => new GetApiAppApiInvokeArgs();
    }


    [OutputType]
    public sealed class GetApiAppApiResult
    {
        /// <summary>
        /// API interface unique ID.
        /// </summary>
        public readonly string ApiId;
        public readonly string ApiRegion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// API details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApiAppApiResultResult> Results;
        /// <summary>
        /// The unique ID of the service where the API resides.
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private GetApiAppApiResult(
            string apiId,

            string apiRegion,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetApiAppApiResultResult> results,

            string serviceId)
        {
            ApiId = apiId;
            ApiRegion = apiRegion;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
            ServiceId = serviceId;
        }
    }
}
