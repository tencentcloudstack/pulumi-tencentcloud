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
    public static class GetDestRegions
    {
        /// <summary>
        /// Use this data source to query detailed information of gaap dest regions
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
        ///         var destRegions = Output.Create(Tencentcloud.Gaap.GetDestRegions.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDestRegionsResult> InvokeAsync(GetDestRegionsArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDestRegionsResult>("tencentcloud:Gaap/getDestRegions:getDestRegions", args ?? new GetDestRegionsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of gaap dest regions
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
        ///         var destRegions = Output.Create(Tencentcloud.Gaap.GetDestRegions.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetDestRegionsResult> Invoke(GetDestRegionsInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDestRegionsResult>("tencentcloud:Gaap/getDestRegions:getDestRegions", args ?? new GetDestRegionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDestRegionsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDestRegionsArgs()
        {
        }
    }

    public sealed class GetDestRegionsInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDestRegionsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDestRegionsResult
    {
        /// <summary>
        /// Source Site Area Details List.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDestRegionsDestRegionSetResult> DestRegionSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDestRegionsResult(
            ImmutableArray<Outputs.GetDestRegionsDestRegionSetResult> destRegionSets,

            string id,

            string? resultOutputFile)
        {
            DestRegionSets = destRegionSets;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}