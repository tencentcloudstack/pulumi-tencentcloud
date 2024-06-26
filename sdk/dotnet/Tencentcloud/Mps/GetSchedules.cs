// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps
{
    public static class GetSchedules
    {
        /// <summary>
        /// Use this data source to query detailed information of mps schedules
        /// 
        /// ## Example Usage
        /// 
        /// ### Query the enabled schedules.
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
        ///     var schedules = Tencentcloud.Mps.GetSchedules.Invoke(new()
        ///     {
        ///         Status = "Enabled",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetSchedulesResult> InvokeAsync(GetSchedulesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSchedulesResult>("tencentcloud:Mps/getSchedules:getSchedules", args ?? new GetSchedulesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of mps schedules
        /// 
        /// ## Example Usage
        /// 
        /// ### Query the enabled schedules.
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
        ///     var schedules = Tencentcloud.Mps.GetSchedules.Invoke(new()
        ///     {
        ///         Status = "Enabled",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetSchedulesResult> Invoke(GetSchedulesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSchedulesResult>("tencentcloud:Mps/getSchedules:getSchedules", args ?? new GetSchedulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSchedulesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("scheduleIds")]
        private List<int>? _scheduleIds;

        /// <summary>
        /// The IDs of the schemes to query. Array length limit: 100.
        /// </summary>
        public List<int> ScheduleIds
        {
            get => _scheduleIds ?? (_scheduleIds = new List<int>());
            set => _scheduleIds = value;
        }

        /// <summary>
        /// The scheme status. Valid values:`Enabled`, `Disabled`. If you do not specify this parameter, all schemes will be returned regardless of the status.
        /// </summary>
        [Input("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The trigger type. Valid values:`CosFileUpload`: The scheme is triggered when a file is uploaded to Tencent Cloud Object Storage (COS).`AwsS3FileUpload`: The scheme is triggered when a file is uploaded to AWS S3.If you do not specify this parameter or leave it empty, all schemes will be returned regardless of the trigger type.
        /// </summary>
        [Input("triggerType")]
        public string? TriggerType { get; set; }

        public GetSchedulesArgs()
        {
        }
        public static new GetSchedulesArgs Empty => new GetSchedulesArgs();
    }

    public sealed class GetSchedulesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("scheduleIds")]
        private InputList<int>? _scheduleIds;

        /// <summary>
        /// The IDs of the schemes to query. Array length limit: 100.
        /// </summary>
        public InputList<int> ScheduleIds
        {
            get => _scheduleIds ?? (_scheduleIds = new InputList<int>());
            set => _scheduleIds = value;
        }

        /// <summary>
        /// The scheme status. Valid values:`Enabled`, `Disabled`. If you do not specify this parameter, all schemes will be returned regardless of the status.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The trigger type. Valid values:`CosFileUpload`: The scheme is triggered when a file is uploaded to Tencent Cloud Object Storage (COS).`AwsS3FileUpload`: The scheme is triggered when a file is uploaded to AWS S3.If you do not specify this parameter or leave it empty, all schemes will be returned regardless of the trigger type.
        /// </summary>
        [Input("triggerType")]
        public Input<string>? TriggerType { get; set; }

        public GetSchedulesInvokeArgs()
        {
        }
        public static new GetSchedulesInvokeArgs Empty => new GetSchedulesInvokeArgs();
    }


    [OutputType]
    public sealed class GetSchedulesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<int> ScheduleIds;
        /// <summary>
        /// The information of the schemes.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSchedulesScheduleInfoSetResult> ScheduleInfoSets;
        /// <summary>
        /// The scheme status. Valid values:`Enabled``Disabled`Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly string? Status;
        public readonly string? TriggerType;

        [OutputConstructor]
        private GetSchedulesResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<int> scheduleIds,

            ImmutableArray<Outputs.GetSchedulesScheduleInfoSetResult> scheduleInfoSets,

            string? status,

            string? triggerType)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            ScheduleIds = scheduleIds;
            ScheduleInfoSets = scheduleInfoSets;
            Status = status;
            TriggerType = triggerType;
        }
    }
}
