// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf
{
    public static class GetLayerVersions
    {
        /// <summary>
        /// Use this data source to query detailed information of scf layer_versions
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
        ///     var layerVersions = Tencentcloud.Scf.GetLayerVersions.Invoke(new()
        ///     {
        ///         LayerName = "tf-test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetLayerVersionsResult> InvokeAsync(GetLayerVersionsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLayerVersionsResult>("tencentcloud:Scf/getLayerVersions:getLayerVersions", args ?? new GetLayerVersionsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of scf layer_versions
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
        ///     var layerVersions = Tencentcloud.Scf.GetLayerVersions.Invoke(new()
        ///     {
        ///         LayerName = "tf-test",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetLayerVersionsResult> Invoke(GetLayerVersionsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLayerVersionsResult>("tencentcloud:Scf/getLayerVersions:getLayerVersions", args ?? new GetLayerVersionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLayerVersionsArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntimes")]
        private List<string>? _compatibleRuntimes;

        /// <summary>
        /// Compatible runtimes.
        /// </summary>
        public List<string> CompatibleRuntimes
        {
            get => _compatibleRuntimes ?? (_compatibleRuntimes = new List<string>());
            set => _compatibleRuntimes = value;
        }

        /// <summary>
        /// Layer name.
        /// </summary>
        [Input("layerName", required: true)]
        public string LayerName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetLayerVersionsArgs()
        {
        }
        public static new GetLayerVersionsArgs Empty => new GetLayerVersionsArgs();
    }

    public sealed class GetLayerVersionsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntimes")]
        private InputList<string>? _compatibleRuntimes;

        /// <summary>
        /// Compatible runtimes.
        /// </summary>
        public InputList<string> CompatibleRuntimes
        {
            get => _compatibleRuntimes ?? (_compatibleRuntimes = new InputList<string>());
            set => _compatibleRuntimes = value;
        }

        /// <summary>
        /// Layer name.
        /// </summary>
        [Input("layerName", required: true)]
        public Input<string> LayerName { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetLayerVersionsInvokeArgs()
        {
        }
        public static new GetLayerVersionsInvokeArgs Empty => new GetLayerVersionsInvokeArgs();
    }


    [OutputType]
    public sealed class GetLayerVersionsResult
    {
        public readonly ImmutableArray<string> CompatibleRuntimes;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Layer name.
        /// </summary>
        public readonly string LayerName;
        /// <summary>
        /// Layer version list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetLayerVersionsLayerVersionResult> ScfLayerVersions;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetLayerVersionsResult(
            ImmutableArray<string> compatibleRuntimes,

            string id,

            string layerName,

            ImmutableArray<Outputs.GetLayerVersionsLayerVersionResult> layerVersions,

            string? resultOutputFile)
        {
            CompatibleRuntimes = compatibleRuntimes;
            Id = id;
            LayerName = layerName;
            ScfLayerVersions = layerVersions;
            ResultOutputFile = resultOutputFile;
        }
    }
}
