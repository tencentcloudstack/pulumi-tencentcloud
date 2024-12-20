// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata
{
    public static class GetDataSourceWithoutInfo
    {
        /// <summary>
        /// Use this data source to query detailed information of wedata data_source_without_info
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
        ///     var example = Tencentcloud.Wedata.GetDataSourceWithoutInfo.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Wedata.Inputs.GetDataSourceWithoutInfoFilterInputArgs
        ///             {
        ///                 Name = "ownerProjectId",
        ///                 Values = new[]
        ///                 {
        ///                     "1612982498218618880",
        ///                 },
        ///             },
        ///         },
        ///         OrderFields = new[]
        ///         {
        ///             new Tencentcloud.Wedata.Inputs.GetDataSourceWithoutInfoOrderFieldInputArgs
        ///             {
        ///                 Direction = "DESC",
        ///                 Name = "create_time",
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetDataSourceWithoutInfoResult> InvokeAsync(GetDataSourceWithoutInfoArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDataSourceWithoutInfoResult>("tencentcloud:Wedata/getDataSourceWithoutInfo:getDataSourceWithoutInfo", args ?? new GetDataSourceWithoutInfoArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of wedata data_source_without_info
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
        ///     var example = Tencentcloud.Wedata.GetDataSourceWithoutInfo.Invoke(new()
        ///     {
        ///         Filters = new[]
        ///         {
        ///             new Tencentcloud.Wedata.Inputs.GetDataSourceWithoutInfoFilterInputArgs
        ///             {
        ///                 Name = "ownerProjectId",
        ///                 Values = new[]
        ///                 {
        ///                     "1612982498218618880",
        ///                 },
        ///             },
        ///         },
        ///         OrderFields = new[]
        ///         {
        ///             new Tencentcloud.Wedata.Inputs.GetDataSourceWithoutInfoOrderFieldInputArgs
        ///             {
        ///                 Direction = "DESC",
        ///                 Name = "create_time",
        ///             },
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetDataSourceWithoutInfoResult> Invoke(GetDataSourceWithoutInfoInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDataSourceWithoutInfoResult>("tencentcloud:Wedata/getDataSourceWithoutInfo:getDataSourceWithoutInfo", args ?? new GetDataSourceWithoutInfoInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDataSourceWithoutInfoArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetDataSourceWithoutInfoFilterArgs>? _filters;

        /// <summary>
        /// Filters.
        /// </summary>
        public List<Inputs.GetDataSourceWithoutInfoFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetDataSourceWithoutInfoFilterArgs>());
            set => _filters = value;
        }

        [Input("orderFields")]
        private List<Inputs.GetDataSourceWithoutInfoOrderFieldArgs>? _orderFields;

        /// <summary>
        /// OrderFields.
        /// </summary>
        public List<Inputs.GetDataSourceWithoutInfoOrderFieldArgs> OrderFields
        {
            get => _orderFields ?? (_orderFields = new List<Inputs.GetDataSourceWithoutInfoOrderFieldArgs>());
            set => _orderFields = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDataSourceWithoutInfoArgs()
        {
        }
        public static new GetDataSourceWithoutInfoArgs Empty => new GetDataSourceWithoutInfoArgs();
    }

    public sealed class GetDataSourceWithoutInfoInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetDataSourceWithoutInfoFilterInputArgs>? _filters;

        /// <summary>
        /// Filters.
        /// </summary>
        public InputList<Inputs.GetDataSourceWithoutInfoFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetDataSourceWithoutInfoFilterInputArgs>());
            set => _filters = value;
        }

        [Input("orderFields")]
        private InputList<Inputs.GetDataSourceWithoutInfoOrderFieldInputArgs>? _orderFields;

        /// <summary>
        /// OrderFields.
        /// </summary>
        public InputList<Inputs.GetDataSourceWithoutInfoOrderFieldInputArgs> OrderFields
        {
            get => _orderFields ?? (_orderFields = new InputList<Inputs.GetDataSourceWithoutInfoOrderFieldInputArgs>());
            set => _orderFields = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDataSourceWithoutInfoInvokeArgs()
        {
        }
        public static new GetDataSourceWithoutInfoInvokeArgs Empty => new GetDataSourceWithoutInfoInvokeArgs();
    }


    [OutputType]
    public sealed class GetDataSourceWithoutInfoResult
    {
        /// <summary>
        /// Data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDataSourceWithoutInfoDataResult> Datas;
        public readonly ImmutableArray<Outputs.GetDataSourceWithoutInfoFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetDataSourceWithoutInfoOrderFieldResult> OrderFields;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDataSourceWithoutInfoResult(
            ImmutableArray<Outputs.GetDataSourceWithoutInfoDataResult> datas,

            ImmutableArray<Outputs.GetDataSourceWithoutInfoFilterResult> filters,

            string id,

            ImmutableArray<Outputs.GetDataSourceWithoutInfoOrderFieldResult> orderFields,

            string? resultOutputFile)
        {
            Datas = datas;
            Filters = filters;
            Id = id;
            OrderFields = orderFields;
            ResultOutputFile = resultOutputFile;
        }
    }
}
