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
    public static class GetApiApps
    {
        /// <summary>
        /// Use this data source to query list information of api_gateway api_app
        /// </summary>
        public static Task<GetApiAppsResult> InvokeAsync(GetApiAppsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiAppsResult>("tencentcloud:ApiGateway/getApiApps:getApiApps", args ?? new GetApiAppsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query list information of api_gateway api_app
        /// </summary>
        public static Output<GetApiAppsResult> Invoke(GetApiAppsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiAppsResult>("tencentcloud:ApiGateway/getApiApps:getApiApps", args ?? new GetApiAppsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiAppsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Api app ID.
        /// </summary>
        [Input("apiAppId")]
        public string? ApiAppId { get; set; }

        /// <summary>
        /// Api app name.
        /// </summary>
        [Input("apiAppName")]
        public string? ApiAppName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetApiAppsArgs()
        {
        }
        public static new GetApiAppsArgs Empty => new GetApiAppsArgs();
    }

    public sealed class GetApiAppsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Api app ID.
        /// </summary>
        [Input("apiAppId")]
        public Input<string>? ApiAppId { get; set; }

        /// <summary>
        /// Api app name.
        /// </summary>
        [Input("apiAppName")]
        public Input<string>? ApiAppName { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetApiAppsInvokeArgs()
        {
        }
        public static new GetApiAppsInvokeArgs Empty => new GetApiAppsInvokeArgs();
    }


    [OutputType]
    public sealed class GetApiAppsResult
    {
        /// <summary>
        /// ApiApp ID.
        /// </summary>
        public readonly string? ApiAppId;
        /// <summary>
        /// List of ApiApp.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApiAppsApiAppListResult> ApiAppLists;
        /// <summary>
        /// ApiApp Name.
        /// </summary>
        public readonly string? ApiAppName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetApiAppsResult(
            string? apiAppId,

            ImmutableArray<Outputs.GetApiAppsApiAppListResult> apiAppLists,

            string? apiAppName,

            string id,

            string? resultOutputFile)
        {
            ApiAppId = apiAppId;
            ApiAppLists = apiAppLists;
            ApiAppName = apiAppName;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
