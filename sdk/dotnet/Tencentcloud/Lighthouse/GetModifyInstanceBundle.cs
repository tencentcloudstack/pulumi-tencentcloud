// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse
{
    public static class GetModifyInstanceBundle
    {
        /// <summary>
        /// Use this data source to query detailed information of lighthouse modify_instance_bundle
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
        ///         var modifyInstanceBundle = Output.Create(Tencentcloud.Lighthouse.GetModifyInstanceBundle.InvokeAsync(new Tencentcloud.Lighthouse.GetModifyInstanceBundleArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Lighthouse.Inputs.GetModifyInstanceBundleFilterArgs
        ///                 {
        ///                     Name = "bundle-id",
        ///                     Values = 
        ///                     {
        ///                         "bundle_gen_mc_med2_02",
        ///                     },
        ///                 },
        ///             },
        ///             InstanceId = "lhins-xxxxxx",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetModifyInstanceBundleResult> InvokeAsync(GetModifyInstanceBundleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetModifyInstanceBundleResult>("tencentcloud:Lighthouse/getModifyInstanceBundle:getModifyInstanceBundle", args ?? new GetModifyInstanceBundleArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of lighthouse modify_instance_bundle
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
        ///         var modifyInstanceBundle = Output.Create(Tencentcloud.Lighthouse.GetModifyInstanceBundle.InvokeAsync(new Tencentcloud.Lighthouse.GetModifyInstanceBundleArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Lighthouse.Inputs.GetModifyInstanceBundleFilterArgs
        ///                 {
        ///                     Name = "bundle-id",
        ///                     Values = 
        ///                     {
        ///                         "bundle_gen_mc_med2_02",
        ///                     },
        ///                 },
        ///             },
        ///             InstanceId = "lhins-xxxxxx",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetModifyInstanceBundleResult> Invoke(GetModifyInstanceBundleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetModifyInstanceBundleResult>("tencentcloud:Lighthouse/getModifyInstanceBundle:getModifyInstanceBundle", args ?? new GetModifyInstanceBundleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetModifyInstanceBundleArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetModifyInstanceBundleFilterArgs>? _filters;

        /// <summary>
        /// Filter list.
        /// - `bundle-id`: filter by the bundle ID.
        /// - `support-platform-type`: filter by system type, valid values: `LINUX_UNIX`, `WINDOWS`.
        /// - `bundle-type`: filter according to package type, valid values: `GENERAL_BUNDLE`, `STORAGE_BUNDLE`, `ENTERPRISE_BUNDLE`, `EXCLUSIVE_BUNDLE`, `BEFAST_BUNDLE`.
        /// - `bundle-state`: filter according to package status, valid values: `ONLINE`, `OFFLINE`.
        /// NOTE: The upper limit of Filters per request is 10. The upper limit of Filter.Values is 5. Parameter does not support specifying both BundleIds and Filters.
        /// </summary>
        public List<Inputs.GetModifyInstanceBundleFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetModifyInstanceBundleFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetModifyInstanceBundleArgs()
        {
        }
    }

    public sealed class GetModifyInstanceBundleInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetModifyInstanceBundleFilterInputArgs>? _filters;

        /// <summary>
        /// Filter list.
        /// - `bundle-id`: filter by the bundle ID.
        /// - `support-platform-type`: filter by system type, valid values: `LINUX_UNIX`, `WINDOWS`.
        /// - `bundle-type`: filter according to package type, valid values: `GENERAL_BUNDLE`, `STORAGE_BUNDLE`, `ENTERPRISE_BUNDLE`, `EXCLUSIVE_BUNDLE`, `BEFAST_BUNDLE`.
        /// - `bundle-state`: filter according to package status, valid values: `ONLINE`, `OFFLINE`.
        /// NOTE: The upper limit of Filters per request is 10. The upper limit of Filter.Values is 5. Parameter does not support specifying both BundleIds and Filters.
        /// </summary>
        public InputList<Inputs.GetModifyInstanceBundleFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetModifyInstanceBundleFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetModifyInstanceBundleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetModifyInstanceBundleResult
    {
        public readonly ImmutableArray<Outputs.GetModifyInstanceBundleFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Change package details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetModifyInstanceBundleModifyBundleSetResult> ModifyBundleSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetModifyInstanceBundleResult(
            ImmutableArray<Outputs.GetModifyInstanceBundleFilterResult> filters,

            string id,

            string instanceId,

            ImmutableArray<Outputs.GetModifyInstanceBundleModifyBundleSetResult> modifyBundleSets,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            InstanceId = instanceId;
            ModifyBundleSets = modifyBundleSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}