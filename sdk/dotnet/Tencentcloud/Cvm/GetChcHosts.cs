// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm
{
    public static class GetChcHosts
    {
        /// <summary>
        /// Use this data source to query detailed information of cvm chc_hosts
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
        ///     var chcHosts = Tencentcloud.Cvm.GetChcHosts.Invoke(new()
        ///     {
        ///         ChcIds = new[]
        ///         {
        ///             "chc-xxxxxx",
        ///         },
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cvm.Inputs.GetChcHostsFilterInputArgs
        ///             {
        ///                 Name = "zone",
        ///                 Values = new[]
        ///                 {
        ///                     "ap-guangzhou-7",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetChcHostsResult> InvokeAsync(GetChcHostsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetChcHostsResult>("tencentcloud:Cvm/getChcHosts:getChcHosts", args ?? new GetChcHostsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cvm chc_hosts
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
        ///     var chcHosts = Tencentcloud.Cvm.GetChcHosts.Invoke(new()
        ///     {
        ///         ChcIds = new[]
        ///         {
        ///             "chc-xxxxxx",
        ///         },
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Cvm.Inputs.GetChcHostsFilterInputArgs
        ///             {
        ///                 Name = "zone",
        ///                 Values = new[]
        ///                 {
        ///                     "ap-guangzhou-7",
        ///                 },
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetChcHostsResult> Invoke(GetChcHostsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetChcHostsResult>("tencentcloud:Cvm/getChcHosts:getChcHosts", args ?? new GetChcHostsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetChcHostsArgs : global::Pulumi.InvokeArgs
    {
        [Input("chcIds")]
        private List<string>? _chcIds;

        /// <summary>
        /// CHC host ID. Up to 100 instances per request is allowed. ChcIds and Filters cannot be specified at the same time.
        /// </summary>
        public List<string> ChcIds
        {
            get => _chcIds ?? (_chcIds = new List<string>());
            set => _chcIds = value;
        }

        [Input("filters")]
        private List<Inputs.GetChcHostsFilterArgs>? _filters;

        /// <summary>
        /// `zone` Filter by the availability zone, such as ap-guangzhou-1. Valid values: See [Regions and Availability Zones](https://www.tencentcloud.com/document/product/213/6091?from_cn_redirect=1).
        /// - `instance-name` Filter by the instance name.
        /// - `instance-state` Filter by the instance status. For status details, see [InstanceStatus](https://www.tencentcloud.com/document/api/213/15753?from_cn_redirect=1#InstanceStatus).
        /// - `device-type` Filter by the device type.
        /// - `vpc-id` Filter by the unique VPC ID.
        /// - `subnet-id` Filter by the unique VPC subnet ID.
        /// </summary>
        public List<Inputs.GetChcHostsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetChcHostsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetChcHostsArgs()
        {
        }
        public static new GetChcHostsArgs Empty => new GetChcHostsArgs();
    }

    public sealed class GetChcHostsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("chcIds")]
        private InputList<string>? _chcIds;

        /// <summary>
        /// CHC host ID. Up to 100 instances per request is allowed. ChcIds and Filters cannot be specified at the same time.
        /// </summary>
        public InputList<string> ChcIds
        {
            get => _chcIds ?? (_chcIds = new InputList<string>());
            set => _chcIds = value;
        }

        [Input("filters")]
        private InputList<Inputs.GetChcHostsFilterInputArgs>? _filters;

        /// <summary>
        /// `zone` Filter by the availability zone, such as ap-guangzhou-1. Valid values: See [Regions and Availability Zones](https://www.tencentcloud.com/document/product/213/6091?from_cn_redirect=1).
        /// - `instance-name` Filter by the instance name.
        /// - `instance-state` Filter by the instance status. For status details, see [InstanceStatus](https://www.tencentcloud.com/document/api/213/15753?from_cn_redirect=1#InstanceStatus).
        /// - `device-type` Filter by the device type.
        /// - `vpc-id` Filter by the unique VPC ID.
        /// - `subnet-id` Filter by the unique VPC subnet ID.
        /// </summary>
        public InputList<Inputs.GetChcHostsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetChcHostsFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetChcHostsInvokeArgs()
        {
        }
        public static new GetChcHostsInvokeArgs Empty => new GetChcHostsInvokeArgs();
    }


    [OutputType]
    public sealed class GetChcHostsResult
    {
        /// <summary>
        /// List of returned instances.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetChcHostsChcHostSetResult> ChcHostSets;
        public readonly ImmutableArray<string> ChcIds;
        public readonly ImmutableArray<Outputs.GetChcHostsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetChcHostsResult(
            ImmutableArray<Outputs.GetChcHostsChcHostSetResult> chcHostSets,

            ImmutableArray<string> chcIds,

            ImmutableArray<Outputs.GetChcHostsFilterResult> filters,

            string id,

            string? resultOutputFile)
        {
            ChcHostSets = chcHostSets;
            ChcIds = chcIds;
            Filters = filters;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
