// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdc
{
    public static class GetDedicatedClusterOrders
    {
        /// <summary>
        /// Use this data source to query detailed information of CDC dedicated cluster orders
        /// 
        /// ## Example Usage
        /// 
        /// ### Query all orders
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
        ///     var orders = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query orders by filter
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
        ///     var orders1 = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke(new()
        ///     {
        ///         DedicatedClusterIds = new[]
        ///         {
        ///             "cluster-262n63e8",
        ///         },
        ///     });
        /// 
        ///     var orders3 = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke(new()
        ///     {
        ///         ActionType = "CREATE",
        ///         Status = "PENDING",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDedicatedClusterOrdersResult> InvokeAsync(GetDedicatedClusterOrdersArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDedicatedClusterOrdersResult>("tencentcloud:Cdc/getDedicatedClusterOrders:getDedicatedClusterOrders", args ?? new GetDedicatedClusterOrdersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of CDC dedicated cluster orders
        /// 
        /// ## Example Usage
        /// 
        /// ### Query all orders
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
        ///     var orders = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Query orders by filter
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
        ///     var orders1 = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke(new()
        ///     {
        ///         DedicatedClusterIds = new[]
        ///         {
        ///             "cluster-262n63e8",
        ///         },
        ///     });
        /// 
        ///     var orders3 = Tencentcloud.Cdc.GetDedicatedClusterOrders.Invoke(new()
        ///     {
        ///         ActionType = "CREATE",
        ///         Status = "PENDING",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDedicatedClusterOrdersResult> Invoke(GetDedicatedClusterOrdersInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDedicatedClusterOrdersResult>("tencentcloud:Cdc/getDedicatedClusterOrders:getDedicatedClusterOrders", args ?? new GetDedicatedClusterOrdersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDedicatedClusterOrdersArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter by Dedicated Cluster Order Action Type. Allow filter value: CREATE, EXTEND.
        /// </summary>
        [Input("actionType")]
        public string? ActionType { get; set; }

        [Input("dedicatedClusterIds")]
        private List<string>? _dedicatedClusterIds;

        /// <summary>
        /// Filter by Dedicated Cluster ID.
        /// </summary>
        public List<string> DedicatedClusterIds
        {
            get => _dedicatedClusterIds ?? (_dedicatedClusterIds = new List<string>());
            set => _dedicatedClusterIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Filter by Dedicated Cluster Order Status. Allow filter value: PENDING, INCONSTRUCTION, DELIVERING, DELIVERED, EXPIRED, CANCELLED, OFFLINE.
        /// </summary>
        [Input("status")]
        public string? Status { get; set; }

        public GetDedicatedClusterOrdersArgs()
        {
        }
        public static new GetDedicatedClusterOrdersArgs Empty => new GetDedicatedClusterOrdersArgs();
    }

    public sealed class GetDedicatedClusterOrdersInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter by Dedicated Cluster Order Action Type. Allow filter value: CREATE, EXTEND.
        /// </summary>
        [Input("actionType")]
        public Input<string>? ActionType { get; set; }

        [Input("dedicatedClusterIds")]
        private InputList<string>? _dedicatedClusterIds;

        /// <summary>
        /// Filter by Dedicated Cluster ID.
        /// </summary>
        public InputList<string> DedicatedClusterIds
        {
            get => _dedicatedClusterIds ?? (_dedicatedClusterIds = new InputList<string>());
            set => _dedicatedClusterIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Filter by Dedicated Cluster Order Status. Allow filter value: PENDING, INCONSTRUCTION, DELIVERING, DELIVERED, EXPIRED, CANCELLED, OFFLINE.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        public GetDedicatedClusterOrdersInvokeArgs()
        {
        }
        public static new GetDedicatedClusterOrdersInvokeArgs Empty => new GetDedicatedClusterOrdersInvokeArgs();
    }


    [OutputType]
    public sealed class GetDedicatedClusterOrdersResult
    {
        public readonly string? ActionType;
        public readonly ImmutableArray<string> DedicatedClusterIds;
        /// <summary>
        /// Filter by Dedicated Cluster Order.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDedicatedClusterOrdersDedicatedClusterOrderSetResult> DedicatedClusterOrderSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly string? Status;

        [OutputConstructor]
        private GetDedicatedClusterOrdersResult(
            string? actionType,

            ImmutableArray<string> dedicatedClusterIds,

            ImmutableArray<Outputs.GetDedicatedClusterOrdersDedicatedClusterOrderSetResult> dedicatedClusterOrderSets,

            string id,

            string? resultOutputFile,

            string? status)
        {
            ActionType = actionType;
            DedicatedClusterIds = dedicatedClusterIds;
            DedicatedClusterOrderSets = dedicatedClusterOrderSets;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Status = status;
        }
    }
}