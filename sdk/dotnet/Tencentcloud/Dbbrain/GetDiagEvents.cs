// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dbbrain
{
    public static class GetDiagEvents
    {
        /// <summary>
        /// Use this data source to query detailed information of dbbrain diag_events
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
        ///     var diagEvents = Tencentcloud.Dbbrain.GetDiagEvents.Invoke(new()
        ///     {
        ///         EndTime = "%s",
        ///         InstanceIds = new[]
        ///         {
        ///             "%s",
        ///         },
        ///         Severities = new[]
        ///         {
        ///             1,
        ///             4,
        ///             5,
        ///         },
        ///         StartTime = "%s",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDiagEventsResult> InvokeAsync(GetDiagEventsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDiagEventsResult>("tencentcloud:Dbbrain/getDiagEvents:getDiagEvents", args ?? new GetDiagEventsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dbbrain diag_events
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
        ///     var diagEvents = Tencentcloud.Dbbrain.GetDiagEvents.Invoke(new()
        ///     {
        ///         EndTime = "%s",
        ///         InstanceIds = new[]
        ///         {
        ///             "%s",
        ///         },
        ///         Severities = new[]
        ///         {
        ///             1,
        ///             4,
        ///             5,
        ///         },
        ///         StartTime = "%s",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDiagEventsResult> Invoke(GetDiagEventsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDiagEventsResult>("tencentcloud:Dbbrain/getDiagEvents:getDiagEvents", args ?? new GetDiagEventsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDiagEventsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// end time.
        /// </summary>
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

        [Input("instanceIds")]
        private List<string>? _instanceIds;

        /// <summary>
        /// instance id list.
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

        [Input("severities")]
        private List<int>? _severities;

        /// <summary>
        /// severity list, optional value is 1-fatal, 2-severity, 3-warning, 4-tips, 5-health.
        /// </summary>
        public List<int> Severities
        {
            get => _severities ?? (_severities = new List<int>());
            set => _severities = value;
        }

        /// <summary>
        /// start time.
        /// </summary>
        [Input("startTime", required: true)]
        public string StartTime { get; set; } = null!;

        public GetDiagEventsArgs()
        {
        }
        public static new GetDiagEventsArgs Empty => new GetDiagEventsArgs();
    }

    public sealed class GetDiagEventsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// end time.
        /// </summary>
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// instance id list.
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

        [Input("severities")]
        private InputList<int>? _severities;

        /// <summary>
        /// severity list, optional value is 1-fatal, 2-severity, 3-warning, 4-tips, 5-health.
        /// </summary>
        public InputList<int> Severities
        {
            get => _severities ?? (_severities = new InputList<int>());
            set => _severities = value;
        }

        /// <summary>
        /// start time.
        /// </summary>
        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public GetDiagEventsInvokeArgs()
        {
        }
        public static new GetDiagEventsInvokeArgs Empty => new GetDiagEventsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDiagEventsResult
    {
        /// <summary>
        /// end time.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// diag event list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDiagEventsListResult> Lists;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<int> Severities;
        /// <summary>
        /// start time.
        /// </summary>
        public readonly string StartTime;

        [OutputConstructor]
        private GetDiagEventsResult(
            string endTime,

            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetDiagEventsListResult> lists,

            string? resultOutputFile,

            ImmutableArray<int> severities,

            string startTime)
        {
            EndTime = endTime;
            Id = id;
            InstanceIds = instanceIds;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
            Severities = severities;
            StartTime = startTime;
        }
    }
}
