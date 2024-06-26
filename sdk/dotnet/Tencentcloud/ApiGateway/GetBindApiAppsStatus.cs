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
    public static class GetBindApiAppsStatus
    {
        /// <summary>
        /// Use this data source to query detailed information of apiGateway bind_api_apps_status
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
        ///     var example = Tencentcloud.ApiGateway.GetBindApiAppsStatus.Invoke(new()
        ///     {
        ///         ApiIds = new[]
        ///         {
        ///             "api-0cvmf4x4",
        ///             "api-jvqlzolk",
        ///         },
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.ApiGateway.Inputs.GetBindApiAppsStatusFilterInputArgs
        ///             {
        ///                 Name = "ApiAppId",
        ///                 Values = new[]
        ///                 {
        ///                     "app-krljp4wn",
        ///                 },
        ///             },
        ///         },
        ///         ServiceId = "service-nxz6yync",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetBindApiAppsStatusResult> InvokeAsync(GetBindApiAppsStatusArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBindApiAppsStatusResult>("tencentcloud:ApiGateway/getBindApiAppsStatus:getBindApiAppsStatus", args ?? new GetBindApiAppsStatusArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of apiGateway bind_api_apps_status
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
        ///     var example = Tencentcloud.ApiGateway.GetBindApiAppsStatus.Invoke(new()
        ///     {
        ///         ApiIds = new[]
        ///         {
        ///             "api-0cvmf4x4",
        ///             "api-jvqlzolk",
        ///         },
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.ApiGateway.Inputs.GetBindApiAppsStatusFilterInputArgs
        ///             {
        ///                 Name = "ApiAppId",
        ///                 Values = new[]
        ///                 {
        ///                     "app-krljp4wn",
        ///                 },
        ///             },
        ///         },
        ///         ServiceId = "service-nxz6yync",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetBindApiAppsStatusResult> Invoke(GetBindApiAppsStatusInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBindApiAppsStatusResult>("tencentcloud:ApiGateway/getBindApiAppsStatus:getBindApiAppsStatus", args ?? new GetBindApiAppsStatusInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBindApiAppsStatusArgs : global::Pulumi.InvokeArgs
    {
        [Input("apiIds", required: true)]
        private List<string>? _apiIds;

        /// <summary>
        /// Array of API IDs.
        /// </summary>
        public List<string> ApiIds
        {
            get => _apiIds ?? (_apiIds = new List<string>());
            set => _apiIds = value;
        }

        [Input("filters")]
        private List<Inputs.GetBindApiAppsStatusFilterArgs>? _filters;

        /// <summary>
        /// Filter conditions. Supports ApiAppId, Environment, KeyWord (can match name or ID).
        /// </summary>
        public List<Inputs.GetBindApiAppsStatusFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetBindApiAppsStatusFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Service ID.
        /// </summary>
        [Input("serviceId", required: true)]
        public string ServiceId { get; set; } = null!;

        public GetBindApiAppsStatusArgs()
        {
        }
        public static new GetBindApiAppsStatusArgs Empty => new GetBindApiAppsStatusArgs();
    }

    public sealed class GetBindApiAppsStatusInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("apiIds", required: true)]
        private InputList<string>? _apiIds;

        /// <summary>
        /// Array of API IDs.
        /// </summary>
        public InputList<string> ApiIds
        {
            get => _apiIds ?? (_apiIds = new InputList<string>());
            set => _apiIds = value;
        }

        [Input("filters")]
        private InputList<Inputs.GetBindApiAppsStatusFilterInputArgs>? _filters;

        /// <summary>
        /// Filter conditions. Supports ApiAppId, Environment, KeyWord (can match name or ID).
        /// </summary>
        public InputList<Inputs.GetBindApiAppsStatusFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetBindApiAppsStatusFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Service ID.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public GetBindApiAppsStatusInvokeArgs()
        {
        }
        public static new GetBindApiAppsStatusInvokeArgs Empty => new GetBindApiAppsStatusInvokeArgs();
    }


    [OutputType]
    public sealed class GetBindApiAppsStatusResult
    {
        public readonly ImmutableArray<string> ApiIds;
        public readonly ImmutableArray<Outputs.GetBindApiAppsStatusFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// List of APIs bound by the application.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBindApiAppsStatusResultResult> Results;
        /// <summary>
        /// Service ID.
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private GetBindApiAppsStatusResult(
            ImmutableArray<string> apiIds,

            ImmutableArray<Outputs.GetBindApiAppsStatusFilterResult> filters,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetBindApiAppsStatusResultResult> results,

            string serviceId)
        {
            ApiIds = apiIds;
            Filters = filters;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
            ServiceId = serviceId;
        }
    }
}
