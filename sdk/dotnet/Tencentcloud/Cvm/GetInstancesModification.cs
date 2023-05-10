// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm
{
    public static class GetInstancesModification
    {
        /// <summary>
        /// Use this data source to query cvm instances modification.
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
        ///         var foo = Output.Create(Tencentcloud.Cvm.GetInstancesModification.InvokeAsync(new Tencentcloud.Cvm.GetInstancesModificationArgs
        ///         {
        ///             InstanceIds = 
        ///             {
        ///                 "ins-xxxxxxx",
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetInstancesModificationResult> InvokeAsync(GetInstancesModificationArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInstancesModificationResult>("tencentcloud:Cvm/getInstancesModification:getInstancesModification", args ?? new GetInstancesModificationArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query cvm instances modification.
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
        ///         var foo = Output.Create(Tencentcloud.Cvm.GetInstancesModification.InvokeAsync(new Tencentcloud.Cvm.GetInstancesModificationArgs
        ///         {
        ///             InstanceIds = 
        ///             {
        ///                 "ins-xxxxxxx",
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetInstancesModificationResult> Invoke(GetInstancesModificationInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetInstancesModificationResult>("tencentcloud:Cvm/getInstancesModification:getInstancesModification", args ?? new GetInstancesModificationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstancesModificationArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInstancesModificationFilterArgs>? _filters;

        /// <summary>
        /// The upper limit of Filters for each request is 10 and the upper limit for Filter.Values is 2.
        /// </summary>
        public List<Inputs.GetInstancesModificationFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInstancesModificationFilterArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private List<string>? _instanceIds;

        /// <summary>
        /// One or more instance ID to be queried. It can be obtained from the InstanceId in the returned value of API DescribeInstances. The maximum number of instances in batch for each request is 20.
        /// </summary>
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstancesModificationArgs()
        {
        }
    }

    public sealed class GetInstancesModificationInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetInstancesModificationFilterInputArgs>? _filters;

        /// <summary>
        /// The upper limit of Filters for each request is 10 and the upper limit for Filter.Values is 2.
        /// </summary>
        public InputList<Inputs.GetInstancesModificationFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetInstancesModificationFilterInputArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// One or more instance ID to be queried. It can be obtained from the InstanceId in the returned value of API DescribeInstances. The maximum number of instances in batch for each request is 20.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstancesModificationInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetInstancesModificationResult
    {
        public readonly ImmutableArray<Outputs.GetInstancesModificationFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// The list of model configurations that can be adjusted by the instance.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInstancesModificationInstanceTypeConfigStatusListResult> InstanceTypeConfigStatusLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstancesModificationResult(
            ImmutableArray<Outputs.GetInstancesModificationFilterResult> filters,

            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetInstancesModificationInstanceTypeConfigStatusListResult> instanceTypeConfigStatusLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            InstanceIds = instanceIds;
            InstanceTypeConfigStatusLists = instanceTypeConfigStatusLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}