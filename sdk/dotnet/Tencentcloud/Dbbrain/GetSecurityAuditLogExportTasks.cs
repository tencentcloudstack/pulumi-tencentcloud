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
    public static class GetSecurityAuditLogExportTasks
    {
        /// <summary>
        /// Use this data source to query detailed information of dbbrain securityAuditLogExportTasks
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var task = new Tencentcloud.Dbbrain.SecurityAuditLogExportTask("task", new Tencentcloud.Dbbrain.SecurityAuditLogExportTaskArgs
        ///         {
        ///             SecAuditGroupId = "sec_audit_group_id",
        ///             StartTime = "start_time",
        ///             EndTime = "end_time",
        ///             Product = "mysql",
        ///             DangerLevels = 
        ///             {
        ///                 0,
        ///                 1,
        ///                 2,
        ///             },
        ///         });
        ///         var tasks = Tencentcloud.Dbbrain.GetSecurityAuditLogExportTasks.Invoke(new Tencentcloud.Dbbrain.GetSecurityAuditLogExportTasksInvokeArgs
        ///         {
        ///             SecAuditGroupId = "sec_audit_group_id",
        ///             Product = "mysql",
        ///             AsyncRequestIds = 
        ///             {
        ///                 task.AsyncRequestId,
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetSecurityAuditLogExportTasksResult> InvokeAsync(GetSecurityAuditLogExportTasksArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetSecurityAuditLogExportTasksResult>("tencentcloud:Dbbrain/getSecurityAuditLogExportTasks:getSecurityAuditLogExportTasks", args ?? new GetSecurityAuditLogExportTasksArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of dbbrain securityAuditLogExportTasks
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var task = new Tencentcloud.Dbbrain.SecurityAuditLogExportTask("task", new Tencentcloud.Dbbrain.SecurityAuditLogExportTaskArgs
        ///         {
        ///             SecAuditGroupId = "sec_audit_group_id",
        ///             StartTime = "start_time",
        ///             EndTime = "end_time",
        ///             Product = "mysql",
        ///             DangerLevels = 
        ///             {
        ///                 0,
        ///                 1,
        ///                 2,
        ///             },
        ///         });
        ///         var tasks = Tencentcloud.Dbbrain.GetSecurityAuditLogExportTasks.Invoke(new Tencentcloud.Dbbrain.GetSecurityAuditLogExportTasksInvokeArgs
        ///         {
        ///             SecAuditGroupId = "sec_audit_group_id",
        ///             Product = "mysql",
        ///             AsyncRequestIds = 
        ///             {
        ///                 task.AsyncRequestId,
        ///             },
        ///         });
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetSecurityAuditLogExportTasksResult> Invoke(GetSecurityAuditLogExportTasksInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetSecurityAuditLogExportTasksResult>("tencentcloud:Dbbrain/getSecurityAuditLogExportTasks:getSecurityAuditLogExportTasks", args ?? new GetSecurityAuditLogExportTasksInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecurityAuditLogExportTasksArgs : Pulumi.InvokeArgs
    {
        [Input("asyncRequestIds")]
        private List<int>? _asyncRequestIds;

        /// <summary>
        /// async request id list.
        /// </summary>
        public List<int> AsyncRequestIds
        {
            get => _asyncRequestIds ?? (_asyncRequestIds = new List<int>());
            set => _asyncRequestIds = value;
        }

        /// <summary>
        /// product, optional value is mysql.
        /// </summary>
        [Input("product", required: true)]
        public string Product { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// security audit group id.
        /// </summary>
        [Input("secAuditGroupId", required: true)]
        public string SecAuditGroupId { get; set; } = null!;

        public GetSecurityAuditLogExportTasksArgs()
        {
        }
    }

    public sealed class GetSecurityAuditLogExportTasksInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("asyncRequestIds")]
        private InputList<int>? _asyncRequestIds;

        /// <summary>
        /// async request id list.
        /// </summary>
        public InputList<int> AsyncRequestIds
        {
            get => _asyncRequestIds ?? (_asyncRequestIds = new InputList<int>());
            set => _asyncRequestIds = value;
        }

        /// <summary>
        /// product, optional value is mysql.
        /// </summary>
        [Input("product", required: true)]
        public Input<string> Product { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// security audit group id.
        /// </summary>
        [Input("secAuditGroupId", required: true)]
        public Input<string> SecAuditGroupId { get; set; } = null!;

        public GetSecurityAuditLogExportTasksInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetSecurityAuditLogExportTasksResult
    {
        public readonly ImmutableArray<int> AsyncRequestIds;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// security audit log export task list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSecurityAuditLogExportTasksListResult> Lists;
        public readonly string Product;
        public readonly string? ResultOutputFile;
        public readonly string SecAuditGroupId;

        [OutputConstructor]
        private GetSecurityAuditLogExportTasksResult(
            ImmutableArray<int> asyncRequestIds,

            string id,

            ImmutableArray<Outputs.GetSecurityAuditLogExportTasksListResult> lists,

            string product,

            string? resultOutputFile,

            string secAuditGroupId)
        {
            AsyncRequestIds = asyncRequestIds;
            Id = id;
            Lists = lists;
            Product = product;
            ResultOutputFile = resultOutputFile;
            SecAuditGroupId = secAuditGroupId;
        }
    }
}