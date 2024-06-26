// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tsf
{
    public static class GetDeliveryConfigByGroupId
    {
        /// <summary>
        /// Use this data source to query detailed information of tsf delivery_config_by_group_id
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
        ///     var deliveryConfigByGroupId = Tencentcloud.Tsf.GetDeliveryConfigByGroupId.Invoke(new()
        ///     {
        ///         GroupId = "group-yrjkln9v",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDeliveryConfigByGroupIdResult> InvokeAsync(GetDeliveryConfigByGroupIdArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDeliveryConfigByGroupIdResult>("tencentcloud:Tsf/getDeliveryConfigByGroupId:getDeliveryConfigByGroupId", args ?? new GetDeliveryConfigByGroupIdArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tsf delivery_config_by_group_id
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
        ///     var deliveryConfigByGroupId = Tencentcloud.Tsf.GetDeliveryConfigByGroupId.Invoke(new()
        ///     {
        ///         GroupId = "group-yrjkln9v",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDeliveryConfigByGroupIdResult> Invoke(GetDeliveryConfigByGroupIdInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDeliveryConfigByGroupIdResult>("tencentcloud:Tsf/getDeliveryConfigByGroupId:getDeliveryConfigByGroupId", args ?? new GetDeliveryConfigByGroupIdInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDeliveryConfigByGroupIdArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// groupId.
        /// </summary>
        [Input("groupId", required: true)]
        public string GroupId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDeliveryConfigByGroupIdArgs()
        {
        }
        public static new GetDeliveryConfigByGroupIdArgs Empty => new GetDeliveryConfigByGroupIdArgs();
    }

    public sealed class GetDeliveryConfigByGroupIdInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// groupId.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDeliveryConfigByGroupIdInvokeArgs()
        {
        }
        public static new GetDeliveryConfigByGroupIdInvokeArgs Empty => new GetDeliveryConfigByGroupIdInvokeArgs();
    }


    [OutputType]
    public sealed class GetDeliveryConfigByGroupIdResult
    {
        public readonly string GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// configuration item for deliver to a Kafka.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDeliveryConfigByGroupIdResultResult> Results;

        [OutputConstructor]
        private GetDeliveryConfigByGroupIdResult(
            string groupId,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetDeliveryConfigByGroupIdResultResult> results)
        {
            GroupId = groupId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}
