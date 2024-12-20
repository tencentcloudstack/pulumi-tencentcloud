// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cat
{
    public static class GetNode
    {
        /// <summary>
        /// Use this data source to query detailed information of cat node
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
        ///     var node = Tencentcloud.Cat.GetNode.Invoke(new()
        ///     {
        ///         IsIpv6 = false,
        ///         Location = 2,
        ///         NodeType = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetNodeResult> InvokeAsync(GetNodeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNodeResult>("tencentcloud:Cat/getNode:getNode", args ?? new GetNodeArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cat node
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
        ///     var node = Tencentcloud.Cat.GetNode.Invoke(new()
        ///     {
        ///         IsIpv6 = false,
        ///         Location = 2,
        ///         NodeType = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetNodeResult> Invoke(GetNodeInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNodeResult>("tencentcloud:Cat/getNode:getNode", args ?? new GetNodeInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNodeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// is IPv6.
        /// </summary>
        [Input("isIpv6")]
        public bool? IsIpv6 { get; set; }

        /// <summary>
        /// Node area:1=Chinese Mainland,2=Hong Kong, Macao and Taiwan,3=Overseas.
        /// </summary>
        [Input("location")]
        public int? Location { get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [Input("nodeName")]
        public string? NodeName { get; set; }

        /// <summary>
        /// Node type 1:IDC,2:LastMile,3:Mobile.
        /// </summary>
        [Input("nodeType")]
        public int? NodeType { get; set; }

        /// <summary>
        /// Payment mode:1=Trial version,2=Paid version.
        /// </summary>
        [Input("payMode")]
        public int? PayMode { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetNodeArgs()
        {
        }
        public static new GetNodeArgs Empty => new GetNodeArgs();
    }

    public sealed class GetNodeInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// is IPv6.
        /// </summary>
        [Input("isIpv6")]
        public Input<bool>? IsIpv6 { get; set; }

        /// <summary>
        /// Node area:1=Chinese Mainland,2=Hong Kong, Macao and Taiwan,3=Overseas.
        /// </summary>
        [Input("location")]
        public Input<int>? Location { get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        /// <summary>
        /// Node type 1:IDC,2:LastMile,3:Mobile.
        /// </summary>
        [Input("nodeType")]
        public Input<int>? NodeType { get; set; }

        /// <summary>
        /// Payment mode:1=Trial version,2=Paid version.
        /// </summary>
        [Input("payMode")]
        public Input<int>? PayMode { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetNodeInvokeArgs()
        {
        }
        public static new GetNodeInvokeArgs Empty => new GetNodeInvokeArgs();
    }


    [OutputType]
    public sealed class GetNodeResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool? IsIpv6;
        /// <summary>
        /// Node area:1=Chinese Mainland,2=Hong Kong, Macao and Taiwan,3=Overseas.
        /// </summary>
        public readonly int? Location;
        /// <summary>
        /// Probe node list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNodeNodeDefineResult> NodeDefines;
        public readonly string? NodeName;
        public readonly int? NodeType;
        public readonly int? PayMode;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetNodeResult(
            string id,

            bool? isIpv6,

            int? location,

            ImmutableArray<Outputs.GetNodeNodeDefineResult> nodeDefines,

            string? nodeName,

            int? nodeType,

            int? payMode,

            string? resultOutputFile)
        {
            Id = id;
            IsIpv6 = isIpv6;
            Location = location;
            NodeDefines = nodeDefines;
            NodeName = nodeName;
            NodeType = nodeType;
            PayMode = payMode;
            ResultOutputFile = resultOutputFile;
        }
    }
}
