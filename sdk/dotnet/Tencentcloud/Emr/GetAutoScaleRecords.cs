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
        ///     var autoScaleRecords = Tencentcloud.Emr.GetAutoScaleRecords.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Emr.Inputs.GetAutoScaleRecordsFilterInputArgs
        ///             {
        ///                 Key = "StartTime",
        ///                 Value = "2006-01-02 15:04:05",
        ///             },
        ///         },
        ///         InstanceId = "emr-bpum4pad",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetAutoScaleRecordsResult> InvokeAsync(GetAutoScaleRecordsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAutoScaleRecordsResult>("tencentcloud:Emr/getAutoScaleRecords:getAutoScaleRecords", args ?? new GetAutoScaleRecordsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of emr auto_scale_records
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
        ///     var autoScaleRecords = Tencentcloud.Emr.GetAutoScaleRecords.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Emr.Inputs.GetAutoScaleRecordsFilterInputArgs
        ///             {
        ///                 Key = "StartTime",
        ///                 Value = "2006-01-02 15:04:05",
        ///             },
        ///         },
        ///         InstanceId = "emr-bpum4pad",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetAutoScaleRecordsResult> Invoke(GetAutoScaleRecordsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAutoScaleRecordsResult>("tencentcloud:Emr/getAutoScaleRecords:getAutoScaleRecords", args ?? new GetAutoScaleRecordsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAutoScaleRecordsArgs : global::Pulumi.InvokeArgs
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
        public static new GetAutoScaleRecordsArgs Empty => new GetAutoScaleRecordsArgs();
    }

    public sealed class GetAutoScaleRecordsInvokeArgs : global::Pulumi.InvokeArgs
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
        public static new GetAutoScaleRecordsInvokeArgs Empty => new GetAutoScaleRecordsInvokeArgs();
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
