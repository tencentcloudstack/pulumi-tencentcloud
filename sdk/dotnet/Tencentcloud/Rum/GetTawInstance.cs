// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Rum
{
    public static class GetTawInstance
    {
        /// <summary>
        /// Use this data source to query detailed information of rum tawInstance
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
        ///     var tawInstance = Tencentcloud.Rum.GetTawInstance.Invoke(new()
        ///     {
        ///         AreaIds = new[]
        ///         {
        ///             1,
        ///         },
        ///         ChargeStatuses = new[]
        ///         {
        ///             1,
        ///         },
        ///         ChargeTypes = new[]
        ///         {
        ///             1,
        ///         },
        ///         InstanceIds = new[]
        ///         {
        ///             "rum-pasZKEI3RLgakj",
        ///         },
        ///         InstanceStatuses = new[]
        ///         {
        ///             2,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTawInstanceResult> InvokeAsync(GetTawInstanceArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTawInstanceResult>("tencentcloud:Rum/getTawInstance:getTawInstance", args ?? new GetTawInstanceArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of rum tawInstance
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
        ///     var tawInstance = Tencentcloud.Rum.GetTawInstance.Invoke(new()
        ///     {
        ///         AreaIds = new[]
        ///         {
        ///             1,
        ///         },
        ///         ChargeStatuses = new[]
        ///         {
        ///             1,
        ///         },
        ///         ChargeTypes = new[]
        ///         {
        ///             1,
        ///         },
        ///         InstanceIds = new[]
        ///         {
        ///             "rum-pasZKEI3RLgakj",
        ///         },
        ///         InstanceStatuses = new[]
        ///         {
        ///             2,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTawInstanceResult> Invoke(GetTawInstanceInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTawInstanceResult>("tencentcloud:Rum/getTawInstance:getTawInstance", args ?? new GetTawInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTawInstanceArgs : global::Pulumi.InvokeArgs
    {
        [Input("areaIds")]
        private List<int>? _areaIds;

        /// <summary>
        /// Region ID.
        /// </summary>
        public List<int> AreaIds
        {
            get => _areaIds ?? (_areaIds = new List<int>());
            set => _areaIds = value;
        }

        [Input("chargeStatuses")]
        private List<int>? _chargeStatuses;

        /// <summary>
        /// Billing status.
        /// </summary>
        public List<int> ChargeStatuses
        {
            get => _chargeStatuses ?? (_chargeStatuses = new List<int>());
            set => _chargeStatuses = value;
        }

        [Input("chargeTypes")]
        private List<int>? _chargeTypes;

        /// <summary>
        /// Billing type.
        /// </summary>
        public List<int> ChargeTypes
        {
            get => _chargeTypes ?? (_chargeTypes = new List<int>());
            set => _chargeTypes = value;
        }

        [Input("instanceIds")]
        private List<string>? _instanceIds;

        /// <summary>
        /// Instance ID.
        /// </summary>
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        [Input("instanceStatuses")]
        private List<int>? _instanceStatuses;

        /// <summary>
        /// Instance status (`1`: creating; `2`: running; `3`: exceptional; `4`: restarting; `5`: stopping; `6`: stopped; `7`: terminating; `8`: terminated).
        /// </summary>
        public List<int> InstanceStatuses
        {
            get => _instanceStatuses ?? (_instanceStatuses = new List<int>());
            set => _instanceStatuses = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTawInstanceArgs()
        {
        }
        public static new GetTawInstanceArgs Empty => new GetTawInstanceArgs();
    }

    public sealed class GetTawInstanceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("areaIds")]
        private InputList<int>? _areaIds;

        /// <summary>
        /// Region ID.
        /// </summary>
        public InputList<int> AreaIds
        {
            get => _areaIds ?? (_areaIds = new InputList<int>());
            set => _areaIds = value;
        }

        [Input("chargeStatuses")]
        private InputList<int>? _chargeStatuses;

        /// <summary>
        /// Billing status.
        /// </summary>
        public InputList<int> ChargeStatuses
        {
            get => _chargeStatuses ?? (_chargeStatuses = new InputList<int>());
            set => _chargeStatuses = value;
        }

        [Input("chargeTypes")]
        private InputList<int>? _chargeTypes;

        /// <summary>
        /// Billing type.
        /// </summary>
        public InputList<int> ChargeTypes
        {
            get => _chargeTypes ?? (_chargeTypes = new InputList<int>());
            set => _chargeTypes = value;
        }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// Instance ID.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        [Input("instanceStatuses")]
        private InputList<int>? _instanceStatuses;

        /// <summary>
        /// Instance status (`1`: creating; `2`: running; `3`: exceptional; `4`: restarting; `5`: stopping; `6`: stopped; `7`: terminating; `8`: terminated).
        /// </summary>
        public InputList<int> InstanceStatuses
        {
            get => _instanceStatuses ?? (_instanceStatuses = new InputList<int>());
            set => _instanceStatuses = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTawInstanceInvokeArgs()
        {
        }
        public static new GetTawInstanceInvokeArgs Empty => new GetTawInstanceInvokeArgs();
    }


    [OutputType]
    public sealed class GetTawInstanceResult
    {
        public readonly ImmutableArray<int> AreaIds;
        public readonly ImmutableArray<int> ChargeStatuses;
        public readonly ImmutableArray<int> ChargeTypes;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// Instance list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTawInstanceInstanceSetResult> InstanceSets;
        public readonly ImmutableArray<int> InstanceStatuses;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetTawInstanceResult(
            ImmutableArray<int> areaIds,

            ImmutableArray<int> chargeStatuses,

            ImmutableArray<int> chargeTypes,

            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetTawInstanceInstanceSetResult> instanceSets,

            ImmutableArray<int> instanceStatuses,

            string? resultOutputFile)
        {
            AreaIds = areaIds;
            ChargeStatuses = chargeStatuses;
            ChargeTypes = chargeTypes;
            Id = id;
            InstanceIds = instanceIds;
            InstanceSets = instanceSets;
            InstanceStatuses = instanceStatuses;
            ResultOutputFile = resultOutputFile;
        }
    }
}
