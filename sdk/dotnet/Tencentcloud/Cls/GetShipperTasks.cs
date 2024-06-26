// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls
{
    public static class GetShipperTasks
    {
        /// <summary>
        /// Use this data source to query detailed information of cls shipper_tasks
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
        ///     var shipperTasks = Tencentcloud.Cls.GetShipperTasks.Invoke(new()
        ///     {
        ///         EndTime = 160749910800,
        ///         ShipperId = "dbde3c9b-ea16-4032-bc2a-d8fa65567a8e",
        ///         StartTime = 160749910700,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetShipperTasksResult> InvokeAsync(GetShipperTasksArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetShipperTasksResult>("tencentcloud:Cls/getShipperTasks:getShipperTasks", args ?? new GetShipperTasksArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cls shipper_tasks
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
        ///     var shipperTasks = Tencentcloud.Cls.GetShipperTasks.Invoke(new()
        ///     {
        ///         EndTime = 160749910800,
        ///         ShipperId = "dbde3c9b-ea16-4032-bc2a-d8fa65567a8e",
        ///         StartTime = 160749910700,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetShipperTasksResult> Invoke(GetShipperTasksInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetShipperTasksResult>("tencentcloud:Cls/getShipperTasks:getShipperTasks", args ?? new GetShipperTasksInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetShipperTasksArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// end time(ms).
        /// </summary>
        [Input("endTime", required: true)]
        public int EndTime { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// shipper id.
        /// </summary>
        [Input("shipperId", required: true)]
        public string ShipperId { get; set; } = null!;

        /// <summary>
        /// start time(ms).
        /// </summary>
        [Input("startTime", required: true)]
        public int StartTime { get; set; }

        public GetShipperTasksArgs()
        {
        }
        public static new GetShipperTasksArgs Empty => new GetShipperTasksArgs();
    }

    public sealed class GetShipperTasksInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// end time(ms).
        /// </summary>
        [Input("endTime", required: true)]
        public Input<int> EndTime { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// shipper id.
        /// </summary>
        [Input("shipperId", required: true)]
        public Input<string> ShipperId { get; set; } = null!;

        /// <summary>
        /// start time(ms).
        /// </summary>
        [Input("startTime", required: true)]
        public Input<int> StartTime { get; set; } = null!;

        public GetShipperTasksInvokeArgs()
        {
        }
        public static new GetShipperTasksInvokeArgs Empty => new GetShipperTasksInvokeArgs();
    }


    [OutputType]
    public sealed class GetShipperTasksResult
    {
        /// <summary>
        /// end time(ms).
        /// </summary>
        public readonly int EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// shipper id.
        /// </summary>
        public readonly string ShipperId;
        /// <summary>
        /// start time(ms).
        /// </summary>
        public readonly int StartTime;
        /// <summary>
        /// .
        /// </summary>
        public readonly ImmutableArray<Outputs.GetShipperTasksTaskResult> Tasks;

        [OutputConstructor]
        private GetShipperTasksResult(
            int endTime,

            string id,

            string? resultOutputFile,

            string shipperId,

            int startTime,

            ImmutableArray<Outputs.GetShipperTasksTaskResult> tasks)
        {
            EndTime = endTime;
            Id = id;
            ResultOutputFile = resultOutputFile;
            ShipperId = shipperId;
            StartTime = startTime;
            Tasks = tasks;
        }
    }
}
