// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Emr
{
    public static class GetAutoScaleRecords
    {
        /// <summary>
        /// Use this data source to query detailed information of emr auto_scale_records
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
        ///         var autoScaleRecords = Output.Create(Tencentcloud.Emr.GetAutoScaleRecords.InvokeAsync(new Tencentcloud.Emr.GetAutoScaleRecordsArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Emr.Inputs.GetAutoScaleRecordsFilterArgs
        ///                 {
        ///                     Key = "StartTime",
        ///                     Value = "2006-01-02 15:04:05",
        ///                 },
        ///             },
        ///             InstanceId = "emr-bpum4pad",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetAutoScaleRecordsResult> InvokeAsync(GetAutoScaleRecordsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAutoScaleRecordsResult>("tencentcloud:Emr/getAutoScaleRecords:getAutoScaleRecords", args ?? new GetAutoScaleRecordsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of emr auto_scale_records
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
        ///         var autoScaleRecords = Output.Create(Tencentcloud.Emr.GetAutoScaleRecords.InvokeAsync(new Tencentcloud.Emr.GetAutoScaleRecordsArgs
        ///         {
        ///             Filters = 
        ///             {
        ///                 new Tencentcloud.Emr.Inputs.GetAutoScaleRecordsFilterArgs
        ///                 {
        ///                     Key = "StartTime",
        ///                     Value = "2006-01-02 15:04:05",
        ///                 },
        ///             },
        ///             InstanceId = "emr-bpum4pad",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetAutoScaleRecordsResult> Invoke(GetAutoScaleRecordsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAutoScaleRecordsResult>("tencentcloud:Emr/getAutoScaleRecords:getAutoScaleRecords", args ?? new GetAutoScaleRecordsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAutoScaleRecordsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetAutoScaleRecordsFilterArgs>? _filters;

        /// <summary>
        /// Record filtering parameters, currently only `StartTime`, `EndTime` and `StrategyName` are supported. `StartTime` and `EndTime` support the time format of 2006-01-02 15:04:05 or 2006/01/02 15:04:05.
        /// </summary>
        public List<Inputs.GetAutoScaleRecordsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetAutoScaleRecordsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// EMR cluster ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetAutoScaleRecordsArgs()
        {
        }
    }

    public sealed class GetAutoScaleRecordsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetAutoScaleRecordsFilterInputArgs>? _filters;

        /// <summary>
        /// Record filtering parameters, currently only `StartTime`, `EndTime` and `StrategyName` are supported. `StartTime` and `EndTime` support the time format of 2006-01-02 15:04:05 or 2006/01/02 15:04:05.
        /// </summary>
        public InputList<Inputs.GetAutoScaleRecordsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetAutoScaleRecordsFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// EMR cluster ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetAutoScaleRecordsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAutoScaleRecordsResult
    {
        public readonly ImmutableArray<Outputs.GetAutoScaleRecordsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        /// <summary>
        /// Record list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAutoScaleRecordsRecordListResult> RecordLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetAutoScaleRecordsResult(
            ImmutableArray<Outputs.GetAutoScaleRecordsFilterResult> filters,

            string id,

            string instanceId,

            ImmutableArray<Outputs.GetAutoScaleRecordsRecordListResult> recordLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            InstanceId = instanceId;
            RecordLists = recordLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
