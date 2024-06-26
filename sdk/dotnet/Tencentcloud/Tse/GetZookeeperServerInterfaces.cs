// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse
{
    public static class GetZookeeperServerInterfaces
    {
        /// <summary>
        /// Use this data source to query detailed information of tse zookeeper_server_interfaces
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
        ///     var zookeeperServerInterfaces = Tencentcloud.Tse.GetZookeeperServerInterfaces.Invoke(new()
        ///     {
        ///         InstanceId = "ins-7eb7eea7",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetZookeeperServerInterfacesResult> InvokeAsync(GetZookeeperServerInterfacesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetZookeeperServerInterfacesResult>("tencentcloud:Tse/getZookeeperServerInterfaces:getZookeeperServerInterfaces", args ?? new GetZookeeperServerInterfacesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tse zookeeper_server_interfaces
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
        ///     var zookeeperServerInterfaces = Tencentcloud.Tse.GetZookeeperServerInterfaces.Invoke(new()
        ///     {
        ///         InstanceId = "ins-7eb7eea7",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetZookeeperServerInterfacesResult> Invoke(GetZookeeperServerInterfacesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetZookeeperServerInterfacesResult>("tencentcloud:Tse/getZookeeperServerInterfaces:getZookeeperServerInterfaces", args ?? new GetZookeeperServerInterfacesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetZookeeperServerInterfacesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// engine instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetZookeeperServerInterfacesArgs()
        {
        }
        public static new GetZookeeperServerInterfacesArgs Empty => new GetZookeeperServerInterfacesArgs();
    }

    public sealed class GetZookeeperServerInterfacesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// engine instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetZookeeperServerInterfacesInvokeArgs()
        {
        }
        public static new GetZookeeperServerInterfacesInvokeArgs Empty => new GetZookeeperServerInterfacesInvokeArgs();
    }


    [OutputType]
    public sealed class GetZookeeperServerInterfacesResult
    {
        /// <summary>
        /// interface list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetZookeeperServerInterfacesContentResult> Contents;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetZookeeperServerInterfacesResult(
            ImmutableArray<Outputs.GetZookeeperServerInterfacesContentResult> contents,

            string id,

            string instanceId,

            string? resultOutputFile)
        {
            Contents = contents;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}
