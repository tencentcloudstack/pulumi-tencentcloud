// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Redis
{
    public static class GetClusters
    {
        /// <summary>
        /// Use this data source to query detailed information of redis clusters
        /// 
        /// ## Example Usage
        /// 
        /// ### Query all instance
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
        ///     var clusters = Tencentcloud.Redis.GetClusters.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Also Support the following query conditions
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
        ///     var clusters = Tencentcloud.Redis.GetClusters.Invoke(new()
        ///     {
        ///         AutoRenewFlags = new[]
        ///         {
        ///             0,
        ///             1,
        ///             2,
        ///         },
        ///         ClusterName = "crs-cdc-9nyfki8h",
        ///         DedicatedClusterId = "cluster-0astoh6a",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///             1,
        ///         },
        ///         RedisClusterIds = new[]
        ///         {
        ///             "crs-cdc-9nyfki8h",
        ///         },
        ///         Statuses = new[]
        ///         {
        ///             0,
        ///             1,
        ///             2,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetClustersResult> InvokeAsync(GetClustersArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetClustersResult>("tencentcloud:Redis/getClusters:getClusters", args ?? new GetClustersArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of redis clusters
        /// 
        /// ## Example Usage
        /// 
        /// ### Query all instance
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
        ///     var clusters = Tencentcloud.Redis.GetClusters.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Also Support the following query conditions
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
        ///     var clusters = Tencentcloud.Redis.GetClusters.Invoke(new()
        ///     {
        ///         AutoRenewFlags = new[]
        ///         {
        ///             0,
        ///             1,
        ///             2,
        ///         },
        ///         ClusterName = "crs-cdc-9nyfki8h",
        ///         DedicatedClusterId = "cluster-0astoh6a",
        ///         ProjectIds = new[]
        ///         {
        ///             0,
        ///             1,
        ///         },
        ///         RedisClusterIds = new[]
        ///         {
        ///             "crs-cdc-9nyfki8h",
        ///         },
        ///         Statuses = new[]
        ///         {
        ///             0,
        ///             1,
        ///             2,
        ///         },
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetClustersResult> Invoke(GetClustersInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetClustersResult>("tencentcloud:Redis/getClusters:getClusters", args ?? new GetClustersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetClustersArgs : global::Pulumi.InvokeArgs
    {
        [Input("autoRenewFlags")]
        private List<int>? _autoRenewFlags;

        /// <summary>
        /// Renewal mode: 0- default state (manual renewal); 1- Automatic renewal; 2- Clearly stating that automatic renewal is not allowed.
        /// </summary>
        public List<int> AutoRenewFlags
        {
            get => _autoRenewFlags ?? (_autoRenewFlags = new List<int>());
            set => _autoRenewFlags = value;
        }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [Input("clusterName")]
        public string? ClusterName { get; set; }

        /// <summary>
        /// Dedicated cluster Id.
        /// </summary>
        [Input("dedicatedClusterId")]
        public string? DedicatedClusterId { get; set; }

        [Input("projectIds")]
        private List<int>? _projectIds;

        /// <summary>
        /// Project Ids.
        /// </summary>
        public List<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new List<int>());
            set => _projectIds = value;
        }

        [Input("redisClusterIds")]
        private List<string>? _redisClusterIds;

        /// <summary>
        /// Redis Cluster Ids.
        /// </summary>
        public List<string> RedisClusterIds
        {
            get => _redisClusterIds ?? (_redisClusterIds = new List<string>());
            set => _redisClusterIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("statuses")]
        private List<int>? _statuses;

        /// <summary>
        /// Cluster status: 1- In process, 2- Running, 3- Isolated.
        /// </summary>
        public List<int> Statuses
        {
            get => _statuses ?? (_statuses = new List<int>());
            set => _statuses = value;
        }

        public GetClustersArgs()
        {
        }
        public static new GetClustersArgs Empty => new GetClustersArgs();
    }

    public sealed class GetClustersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("autoRenewFlags")]
        private InputList<int>? _autoRenewFlags;

        /// <summary>
        /// Renewal mode: 0- default state (manual renewal); 1- Automatic renewal; 2- Clearly stating that automatic renewal is not allowed.
        /// </summary>
        public InputList<int> AutoRenewFlags
        {
            get => _autoRenewFlags ?? (_autoRenewFlags = new InputList<int>());
            set => _autoRenewFlags = value;
        }

        /// <summary>
        /// Cluster name.
        /// </summary>
        [Input("clusterName")]
        public Input<string>? ClusterName { get; set; }

        /// <summary>
        /// Dedicated cluster Id.
        /// </summary>
        [Input("dedicatedClusterId")]
        public Input<string>? DedicatedClusterId { get; set; }

        [Input("projectIds")]
        private InputList<int>? _projectIds;

        /// <summary>
        /// Project Ids.
        /// </summary>
        public InputList<int> ProjectIds
        {
            get => _projectIds ?? (_projectIds = new InputList<int>());
            set => _projectIds = value;
        }

        [Input("redisClusterIds")]
        private InputList<string>? _redisClusterIds;

        /// <summary>
        /// Redis Cluster Ids.
        /// </summary>
        public InputList<string> RedisClusterIds
        {
            get => _redisClusterIds ?? (_redisClusterIds = new InputList<string>());
            set => _redisClusterIds = value;
        }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("statuses")]
        private InputList<int>? _statuses;

        /// <summary>
        /// Cluster status: 1- In process, 2- Running, 3- Isolated.
        /// </summary>
        public InputList<int> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<int>());
            set => _statuses = value;
        }

        public GetClustersInvokeArgs()
        {
        }
        public static new GetClustersInvokeArgs Empty => new GetClustersInvokeArgs();
    }


    [OutputType]
    public sealed class GetClustersResult
    {
        /// <summary>
        /// Renewal mode: 0- default state (manual renewal); 1- Automatic renewal; 2- Clearly stating that automatic renewal is not allowed.
        /// </summary>
        public readonly ImmutableArray<int> AutoRenewFlags;
        /// <summary>
        /// Cluster name.
        /// </summary>
        public readonly string? ClusterName;
        /// <summary>
        /// Dedicated cluster Id.
        /// </summary>
        public readonly string? DedicatedClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<int> ProjectIds;
        public readonly ImmutableArray<string> RedisClusterIds;
        /// <summary>
        /// .
        /// </summary>
        public readonly ImmutableArray<Outputs.GetClustersResourceResult> Resources;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Cluster status: 1- In process, 2- Running, 3- Isolated.
        /// </summary>
        public readonly ImmutableArray<int> Statuses;

        [OutputConstructor]
        private GetClustersResult(
            ImmutableArray<int> autoRenewFlags,

            string? clusterName,

            string? dedicatedClusterId,

            string id,

            ImmutableArray<int> projectIds,

            ImmutableArray<string> redisClusterIds,

            ImmutableArray<Outputs.GetClustersResourceResult> resources,

            string? resultOutputFile,

            ImmutableArray<int> statuses)
        {
            AutoRenewFlags = autoRenewFlags;
            ClusterName = clusterName;
            DedicatedClusterId = dedicatedClusterId;
            Id = id;
            ProjectIds = projectIds;
            RedisClusterIds = redisClusterIds;
            Resources = resources;
            ResultOutputFile = resultOutputFile;
            Statuses = statuses;
        }
    }
}