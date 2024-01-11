// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor
{
    public static class GetGrafanaPluginOverviews
    {
        /// <summary>
        /// Use this data source to query detailed information of monitor grafana_plugin_overviews
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
        ///         var grafanaPluginOverviews = Output.Create(Tencentcloud.Monitor.GetGrafanaPluginOverviews.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetGrafanaPluginOverviewsResult> InvokeAsync(GetGrafanaPluginOverviewsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGrafanaPluginOverviewsResult>("tencentcloud:Monitor/getGrafanaPluginOverviews:getGrafanaPluginOverviews", args ?? new GetGrafanaPluginOverviewsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of monitor grafana_plugin_overviews
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
        ///         var grafanaPluginOverviews = Output.Create(Tencentcloud.Monitor.GetGrafanaPluginOverviews.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetGrafanaPluginOverviewsResult> Invoke(GetGrafanaPluginOverviewsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetGrafanaPluginOverviewsResult>("tencentcloud:Monitor/getGrafanaPluginOverviews:getGrafanaPluginOverviews", args ?? new GetGrafanaPluginOverviewsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGrafanaPluginOverviewsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetGrafanaPluginOverviewsArgs()
        {
        }
    }

    public sealed class GetGrafanaPluginOverviewsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetGrafanaPluginOverviewsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGrafanaPluginOverviewsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Plugin set.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGrafanaPluginOverviewsPluginSetResult> PluginSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetGrafanaPluginOverviewsResult(
            string id,

            ImmutableArray<Outputs.GetGrafanaPluginOverviewsPluginSetResult> pluginSets,

            string? resultOutputFile)
        {
            Id = id;
            PluginSets = pluginSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}