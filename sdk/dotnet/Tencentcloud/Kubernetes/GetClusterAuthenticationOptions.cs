// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes
{
    public static class GetClusterAuthenticationOptions
    {
        /// <summary>
        /// Use this data source to query detailed information of kubernetes cluster_authentication_options
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var clusterAuthenticationOptions = Output.Create(Tencentcloud.Kubernetes.GetClusterAuthenticationOptions.InvokeAsync(new Tencentcloud.Kubernetes.GetClusterAuthenticationOptionsArgs
        ///         {
        ///             ClusterId = "cls-kzilgv5m",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetClusterAuthenticationOptionsResult> InvokeAsync(GetClusterAuthenticationOptionsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetClusterAuthenticationOptionsResult>("tencentcloud:Kubernetes/getClusterAuthenticationOptions:getClusterAuthenticationOptions", args ?? new GetClusterAuthenticationOptionsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of kubernetes cluster_authentication_options
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var clusterAuthenticationOptions = Output.Create(Tencentcloud.Kubernetes.GetClusterAuthenticationOptions.InvokeAsync(new Tencentcloud.Kubernetes.GetClusterAuthenticationOptionsArgs
        ///         {
        ///             ClusterId = "cls-kzilgv5m",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetClusterAuthenticationOptionsResult> Invoke(GetClusterAuthenticationOptionsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetClusterAuthenticationOptionsResult>("tencentcloud:Kubernetes/getClusterAuthenticationOptions:getClusterAuthenticationOptions", args ?? new GetClusterAuthenticationOptionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClusterAuthenticationOptionsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetClusterAuthenticationOptionsArgs()
        {
        }
    }

    public sealed class GetClusterAuthenticationOptionsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Cluster ID.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetClusterAuthenticationOptionsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetClusterAuthenticationOptionsResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Result of the last modification. Values: `Updating`, `Success`, `Failed` or `TimeOut`. Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string LatestOperationState;
        /// <summary>
        /// OIDC authentication configurations. Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterAuthenticationOptionsOidcConfigResult> OidcConfigs;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// ServiceAccount authentication configuration. Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClusterAuthenticationOptionsServiceAccountResult> ServiceAccounts;

        [OutputConstructor]
        private GetClusterAuthenticationOptionsResult(
            string clusterId,

            string id,

            string latestOperationState,

            ImmutableArray<Outputs.GetClusterAuthenticationOptionsOidcConfigResult> oidcConfigs,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetClusterAuthenticationOptionsServiceAccountResult> serviceAccounts)
        {
            ClusterId = clusterId;
            Id = id;
            LatestOperationState = latestOperationState;
            OidcConfigs = oidcConfigs;
            ResultOutputFile = resultOutputFile;
            ServiceAccounts = serviceAccounts;
        }
    }
}