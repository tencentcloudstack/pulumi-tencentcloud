// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetSgSnapshotFileContent
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc sg_snapshot_file_content
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
        ///     var sgSnapshotFileContent = Tencentcloud.Vpc.GetSgSnapshotFileContent.Invoke(new()
        ///     {
        ///         SecurityGroupId = "sg-ntrgm89v",
        ///         SnapshotFileId = "ssfile-017gepjxpr",
        ///         SnapshotPolicyId = "sspolicy-ebjofe71",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetSgSnapshotFileContentResult> InvokeAsync(GetSgSnapshotFileContentArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSgSnapshotFileContentResult>("tencentcloud:Vpc/getSgSnapshotFileContent:getSgSnapshotFileContent", args ?? new GetSgSnapshotFileContentArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc sg_snapshot_file_content
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
        ///     var sgSnapshotFileContent = Tencentcloud.Vpc.GetSgSnapshotFileContent.Invoke(new()
        ///     {
        ///         SecurityGroupId = "sg-ntrgm89v",
        ///         SnapshotFileId = "ssfile-017gepjxpr",
        ///         SnapshotPolicyId = "sspolicy-ebjofe71",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetSgSnapshotFileContentResult> Invoke(GetSgSnapshotFileContentInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSgSnapshotFileContentResult>("tencentcloud:Vpc/getSgSnapshotFileContent:getSgSnapshotFileContent", args ?? new GetSgSnapshotFileContentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSgSnapshotFileContentArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Security group ID.
        /// </summary>
        [Input("securityGroupId", required: true)]
        public string SecurityGroupId { get; set; } = null!;

        /// <summary>
        /// Snapshot file ID.
        /// </summary>
        [Input("snapshotFileId", required: true)]
        public string SnapshotFileId { get; set; } = null!;

        /// <summary>
        /// Snapshot policy IDs.
        /// </summary>
        [Input("snapshotPolicyId", required: true)]
        public string SnapshotPolicyId { get; set; } = null!;

        public GetSgSnapshotFileContentArgs()
        {
        }
        public static new GetSgSnapshotFileContentArgs Empty => new GetSgSnapshotFileContentArgs();
    }

    public sealed class GetSgSnapshotFileContentInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Security group ID.
        /// </summary>
        [Input("securityGroupId", required: true)]
        public Input<string> SecurityGroupId { get; set; } = null!;

        /// <summary>
        /// Snapshot file ID.
        /// </summary>
        [Input("snapshotFileId", required: true)]
        public Input<string> SnapshotFileId { get; set; } = null!;

        /// <summary>
        /// Snapshot policy IDs.
        /// </summary>
        [Input("snapshotPolicyId", required: true)]
        public Input<string> SnapshotPolicyId { get; set; } = null!;

        public GetSgSnapshotFileContentInvokeArgs()
        {
        }
        public static new GetSgSnapshotFileContentInvokeArgs Empty => new GetSgSnapshotFileContentInvokeArgs();
    }


    [OutputType]
    public sealed class GetSgSnapshotFileContentResult
    {
        /// <summary>
        /// Backup data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataResult> BackupDatas;
        /// <summary>
        /// Backup time.
        /// </summary>
        public readonly string BackupTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Security group ID.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Operator.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// Original data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSgSnapshotFileContentOriginalDataResult> OriginalDatas;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// The security group instance ID, such as `sg-ohuuioma`.
        /// </summary>
        public readonly string SecurityGroupId;
        public readonly string SnapshotFileId;
        public readonly string SnapshotPolicyId;

        [OutputConstructor]
        private GetSgSnapshotFileContentResult(
            ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataResult> backupDatas,

            string backupTime,

            string id,

            string instanceId,

            string @operator,

            ImmutableArray<Outputs.GetSgSnapshotFileContentOriginalDataResult> originalDatas,

            string? resultOutputFile,

            string securityGroupId,

            string snapshotFileId,

            string snapshotPolicyId)
        {
            BackupDatas = backupDatas;
            BackupTime = backupTime;
            Id = id;
            InstanceId = instanceId;
            Operator = @operator;
            OriginalDatas = originalDatas;
            ResultOutputFile = resultOutputFile;
            SecurityGroupId = securityGroupId;
            SnapshotFileId = snapshotFileId;
            SnapshotPolicyId = snapshotPolicyId;
        }
    }
}
