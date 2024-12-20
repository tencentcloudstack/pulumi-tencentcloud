// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor
{
    public static class GetTmpInstances
    {
        /// <summary>
        /// Use this data source to query detailed information of monitor tmp instances
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
        ///     var tmpInstances = Tencentcloud.Monitor.GetTmpInstances.Invoke(new()
        ///     {
        ///         InstanceIds = new[]
        ///         {
        ///             "prom-xxxxxx",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTmpInstancesResult> InvokeAsync(GetTmpInstancesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTmpInstancesResult>("tencentcloud:Monitor/getTmpInstances:getTmpInstances", args ?? new GetTmpInstancesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of monitor tmp instances
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
        ///     var tmpInstances = Tencentcloud.Monitor.GetTmpInstances.Invoke(new()
        ///     {
        ///         InstanceIds = new[]
        ///         {
        ///             "prom-xxxxxx",
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTmpInstancesResult> Invoke(GetTmpInstancesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTmpInstancesResult>("tencentcloud:Monitor/getTmpInstances:getTmpInstances", args ?? new GetTmpInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTmpInstancesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter according to instance charge type.
        /// - 2: Prepaid;
        /// - 3: Postpaid by hour.
        /// </summary>
        [Input("instanceChargeType")]
        public int? InstanceChargeType { get; set; }

        [Input("instanceIds")]
        private List<string>? _instanceIds;

        /// <summary>
        /// Query according to one or more instance IDs. The instance ID is like: prom-xxxx. The maximum number of instances requested is 100.
        /// </summary>
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Filter according to instance name.
        /// </summary>
        [Input("instanceName")]
        public string? InstanceName { get; set; }

        [Input("instanceStatuses")]
        private List<int>? _instanceStatuses;

        /// <summary>
        /// Filter according to instance status.
        /// - 1: Creating;
        /// - 2: In operation;
        /// - 3: Abnormal;
        /// - 4: Reconstruction;
        /// - 5: Destruction;
        /// - 6: Stopped taking;
        /// - 8: Suspension of service due to arrears;
        /// - 9: Service has been suspended due to arrears.
        /// </summary>
        public List<int> InstanceStatuses
        {
            get => _instanceStatuses ?? (_instanceStatuses = new List<int>());
            set => _instanceStatuses = value;
        }

        [Input("ipv4Addresses")]
        private List<string>? _ipv4Addresses;

        /// <summary>
        /// Filter according to ipv4 address.
        /// </summary>
        public List<string> Ipv4Addresses
        {
            get => _ipv4Addresses ?? (_ipv4Addresses = new List<string>());
            set => _ipv4Addresses = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("tagFilters")]
        private List<Inputs.GetTmpInstancesTagFilterArgs>? _tagFilters;

        /// <summary>
        /// Filter according to tag Key-Value pair. The tag-key is replaced with a specific label key.
        /// </summary>
        public List<Inputs.GetTmpInstancesTagFilterArgs> TagFilters
        {
            get => _tagFilters ?? (_tagFilters = new List<Inputs.GetTmpInstancesTagFilterArgs>());
            set => _tagFilters = value;
        }

        [Input("zones")]
        private List<string>? _zones;

        /// <summary>
        /// Filter according to availability area. The availability area is shaped like: ap-Guangzhou-1.
        /// </summary>
        public List<string> Zones
        {
            get => _zones ?? (_zones = new List<string>());
            set => _zones = value;
        }

        public GetTmpInstancesArgs()
        {
        }
        public static new GetTmpInstancesArgs Empty => new GetTmpInstancesArgs();
    }

    public sealed class GetTmpInstancesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter according to instance charge type.
        /// - 2: Prepaid;
        /// - 3: Postpaid by hour.
        /// </summary>
        [Input("instanceChargeType")]
        public Input<int>? InstanceChargeType { get; set; }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// Query according to one or more instance IDs. The instance ID is like: prom-xxxx. The maximum number of instances requested is 100.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Filter according to instance name.
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        [Input("instanceStatuses")]
        private InputList<int>? _instanceStatuses;

        /// <summary>
        /// Filter according to instance status.
        /// - 1: Creating;
        /// - 2: In operation;
        /// - 3: Abnormal;
        /// - 4: Reconstruction;
        /// - 5: Destruction;
        /// - 6: Stopped taking;
        /// - 8: Suspension of service due to arrears;
        /// - 9: Service has been suspended due to arrears.
        /// </summary>
        public InputList<int> InstanceStatuses
        {
            get => _instanceStatuses ?? (_instanceStatuses = new InputList<int>());
            set => _instanceStatuses = value;
        }

        [Input("ipv4Addresses")]
        private InputList<string>? _ipv4Addresses;

        /// <summary>
        /// Filter according to ipv4 address.
        /// </summary>
        public InputList<string> Ipv4Addresses
        {
            get => _ipv4Addresses ?? (_ipv4Addresses = new InputList<string>());
            set => _ipv4Addresses = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("tagFilters")]
        private InputList<Inputs.GetTmpInstancesTagFilterInputArgs>? _tagFilters;

        /// <summary>
        /// Filter according to tag Key-Value pair. The tag-key is replaced with a specific label key.
        /// </summary>
        public InputList<Inputs.GetTmpInstancesTagFilterInputArgs> TagFilters
        {
            get => _tagFilters ?? (_tagFilters = new InputList<Inputs.GetTmpInstancesTagFilterInputArgs>());
            set => _tagFilters = value;
        }

        [Input("zones")]
        private InputList<string>? _zones;

        /// <summary>
        /// Filter according to availability area. The availability area is shaped like: ap-Guangzhou-1.
        /// </summary>
        public InputList<string> Zones
        {
            get => _zones ?? (_zones = new InputList<string>());
            set => _zones = value;
        }

        public GetTmpInstancesInvokeArgs()
        {
        }
        public static new GetTmpInstancesInvokeArgs Empty => new GetTmpInstancesInvokeArgs();
    }


    [OutputType]
    public sealed class GetTmpInstancesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Instance charge type.
        /// - 2: Prepaid;
        /// - 3: Postpaid by hour.
        /// </summary>
        public readonly int? InstanceChargeType;
        public readonly ImmutableArray<string> InstanceIds;
        /// <summary>
        /// Instance name.
        /// </summary>
        public readonly string? InstanceName;
        /// <summary>
        /// Instance details list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTmpInstancesInstanceSetResult> InstanceSets;
        /// <summary>
        /// Filter according to instance status.
        /// - 1: Creating;
        /// - 2: In operation;
        /// - 3: Abnormal;
        /// - 4: Reconstruction;
        /// - 5: Destruction;
        /// - 6: Stopped taking;
        /// - 8: Suspension of service due to arrears;
        /// - 9: Service has been suspended due to arrears.
        /// </summary>
        public readonly ImmutableArray<int> InstanceStatuses;
        /// <summary>
        /// IPV4 address.
        /// </summary>
        public readonly ImmutableArray<string> Ipv4Addresses;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetTmpInstancesTagFilterResult> TagFilters;
        public readonly ImmutableArray<string> Zones;

        [OutputConstructor]
        private GetTmpInstancesResult(
            string id,

            int? instanceChargeType,

            ImmutableArray<string> instanceIds,

            string? instanceName,

            ImmutableArray<Outputs.GetTmpInstancesInstanceSetResult> instanceSets,

            ImmutableArray<int> instanceStatuses,

            ImmutableArray<string> ipv4Addresses,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTmpInstancesTagFilterResult> tagFilters,

            ImmutableArray<string> zones)
        {
            Id = id;
            InstanceChargeType = instanceChargeType;
            InstanceIds = instanceIds;
            InstanceName = instanceName;
            InstanceSets = instanceSets;
            InstanceStatuses = instanceStatuses;
            Ipv4Addresses = ipv4Addresses;
            ResultOutputFile = resultOutputFile;
            TagFilters = tagFilters;
            Zones = zones;
        }
    }
}
