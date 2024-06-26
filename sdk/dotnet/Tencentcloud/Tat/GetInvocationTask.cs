// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tat
{
    public static class GetInvocationTask
    {
        /// <summary>
        /// Use this data source to query detailed information of tat invocation_task
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
        ///     var invocationTask = Tencentcloud.Tat.GetInvocationTask.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Tat.Inputs.GetInvocationTaskFilterInputArgs
        ///             {
        ///                 Name = "instance-id",
        ///                 Values = new[]
        ///                 {
        ///                     "ins-p4pq4gaq",
        ///                 },
        ///             },
        ///         },
        ///         HideOutput = true,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetInvocationTaskResult> InvokeAsync(GetInvocationTaskArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInvocationTaskResult>("tencentcloud:Tat/getInvocationTask:getInvocationTask", args ?? new GetInvocationTaskArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tat invocation_task
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
        ///     var invocationTask = Tencentcloud.Tat.GetInvocationTask.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Tat.Inputs.GetInvocationTaskFilterInputArgs
        ///             {
        ///                 Name = "instance-id",
        ///                 Values = new[]
        ///                 {
        ///                     "ins-p4pq4gaq",
        ///                 },
        ///             },
        ///         },
        ///         HideOutput = true,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetInvocationTaskResult> Invoke(GetInvocationTaskInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInvocationTaskResult>("tencentcloud:Tat/getInvocationTask:getInvocationTask", args ?? new GetInvocationTaskInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInvocationTaskArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInvocationTaskFilterArgs>? _filters;

        /// <summary>
        /// Filter conditions.invocation-id - String - Required: No - (Filter condition) Filter by the execution activity ID.invocation-task-id - String - Required: No - (Filter condition) Filter by the execution task ID.instance-id - String - Required: No - (Filter condition) Filter by the instance ID.command-id - String - Required: No - (Filter condition) Filter by the command ID.Up to 10 Filters are allowed for each request. Each filter can have up to five Filter.Values. InvocationTaskIds and Filters cannot be specified at the same time.
        /// </summary>
        public List<Inputs.GetInvocationTaskFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInvocationTaskFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to hide the output. Valid values:True (default): Hide the outputFalse: Show the output.
        /// </summary>
        [Input("hideOutput")]
        public bool? HideOutput { get; set; }

        [Input("invocationTaskIds")]
        private List<string>? _invocationTaskIds;

        /// <summary>
        /// List of execution task IDs. Up to 100 IDs are allowed for each request. InvocationTaskIds and Filters cannot be specified at the same time.
        /// </summary>
        public List<string> InvocationTaskIds
        {
            get => _invocationTaskIds ?? (_invocationTaskIds = new List<string>());
            set => _invocationTaskIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInvocationTaskArgs()
        {
        }
        public static new GetInvocationTaskArgs Empty => new GetInvocationTaskArgs();
    }

    public sealed class GetInvocationTaskInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetInvocationTaskFilterInputArgs>? _filters;

        /// <summary>
        /// Filter conditions.invocation-id - String - Required: No - (Filter condition) Filter by the execution activity ID.invocation-task-id - String - Required: No - (Filter condition) Filter by the execution task ID.instance-id - String - Required: No - (Filter condition) Filter by the instance ID.command-id - String - Required: No - (Filter condition) Filter by the command ID.Up to 10 Filters are allowed for each request. Each filter can have up to five Filter.Values. InvocationTaskIds and Filters cannot be specified at the same time.
        /// </summary>
        public InputList<Inputs.GetInvocationTaskFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetInvocationTaskFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Whether to hide the output. Valid values:True (default): Hide the outputFalse: Show the output.
        /// </summary>
        [Input("hideOutput")]
        public Input<bool>? HideOutput { get; set; }

        [Input("invocationTaskIds")]
        private InputList<string>? _invocationTaskIds;

        /// <summary>
        /// List of execution task IDs. Up to 100 IDs are allowed for each request. InvocationTaskIds and Filters cannot be specified at the same time.
        /// </summary>
        public InputList<string> InvocationTaskIds
        {
            get => _invocationTaskIds ?? (_invocationTaskIds = new InputList<string>());
            set => _invocationTaskIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInvocationTaskInvokeArgs()
        {
        }
        public static new GetInvocationTaskInvokeArgs Empty => new GetInvocationTaskInvokeArgs();
    }


    [OutputType]
    public sealed class GetInvocationTaskResult
    {
        public readonly ImmutableArray<Outputs.GetInvocationTaskFilterResult> Filters;
        public readonly bool? HideOutput;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InvocationTaskIds;
        /// <summary>
        /// List of execution tasks.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetInvocationTaskInvocationTaskSetResult> InvocationTaskSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInvocationTaskResult(
            ImmutableArray<Outputs.GetInvocationTaskFilterResult> filters,

            bool? hideOutput,

            string id,

            ImmutableArray<string> invocationTaskIds,

            ImmutableArray<Outputs.GetInvocationTaskInvocationTaskSetResult> invocationTaskSets,

            string? resultOutputFile)
        {
            Filters = filters;
            HideOutput = hideOutput;
            Id = id;
            InvocationTaskIds = invocationTaskIds;
            InvocationTaskSets = invocationTaskSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}
