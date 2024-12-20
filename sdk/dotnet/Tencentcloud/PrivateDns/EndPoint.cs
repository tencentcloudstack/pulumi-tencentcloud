// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.PrivateDns
{
    /// <summary>
    /// Provides a resource to create a privatedns end point
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var example = new Tencentcloud.PrivateDns.EndPoint("example", new()
    ///     {
    ///         EndPointName = "tf-example",
    ///         EndPointRegion = "ap-guangzhou",
    ///         EndPointServiceId = "vpcsvc-61wcwmar",
    ///         IpNum = 1,
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// private dns end point can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:PrivateDns/endPoint:EndPoint example eid-77a246c867
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:PrivateDns/endPoint:EndPoint")]
    public partial class EndPoint : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Endpoint name.
        /// </summary>
        [Output("endPointName")]
        public Output<string> EndPointName { get; private set; } = null!;

        /// <summary>
        /// Endpoint region, which should be consistent with the region of the endpoint service.
        /// </summary>
        [Output("endPointRegion")]
        public Output<string> EndPointRegion { get; private set; } = null!;

        /// <summary>
        /// Endpoint service ID (namely, VPC endpoint service ID).
        /// </summary>
        [Output("endPointServiceId")]
        public Output<string> EndPointServiceId { get; private set; } = null!;

        /// <summary>
        /// Vip list of endpoint.
        /// </summary>
        [Output("endPointVipSets")]
        public Output<ImmutableArray<string>> EndPointVipSets { get; private set; } = null!;

        /// <summary>
        /// Number of endpoint IP addresses.
        /// </summary>
        [Output("ipNum")]
        public Output<int> IpNum { get; private set; } = null!;


        /// <summary>
        /// Create a EndPoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EndPoint(string name, EndPointArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:PrivateDns/endPoint:EndPoint", name, args ?? new EndPointArgs(), MakeResourceOptions(options, ""))
        {
        }

        private EndPoint(string name, Input<string> id, EndPointState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:PrivateDns/endPoint:EndPoint", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing EndPoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EndPoint Get(string name, Input<string> id, EndPointState? state = null, CustomResourceOptions? options = null)
        {
            return new EndPoint(name, id, state, options);
        }
    }

    public sealed class EndPointArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Endpoint name.
        /// </summary>
        [Input("endPointName", required: true)]
        public Input<string> EndPointName { get; set; } = null!;

        /// <summary>
        /// Endpoint region, which should be consistent with the region of the endpoint service.
        /// </summary>
        [Input("endPointRegion", required: true)]
        public Input<string> EndPointRegion { get; set; } = null!;

        /// <summary>
        /// Endpoint service ID (namely, VPC endpoint service ID).
        /// </summary>
        [Input("endPointServiceId", required: true)]
        public Input<string> EndPointServiceId { get; set; } = null!;

        /// <summary>
        /// Number of endpoint IP addresses.
        /// </summary>
        [Input("ipNum")]
        public Input<int>? IpNum { get; set; }

        public EndPointArgs()
        {
        }
        public static new EndPointArgs Empty => new EndPointArgs();
    }

    public sealed class EndPointState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Endpoint name.
        /// </summary>
        [Input("endPointName")]
        public Input<string>? EndPointName { get; set; }

        /// <summary>
        /// Endpoint region, which should be consistent with the region of the endpoint service.
        /// </summary>
        [Input("endPointRegion")]
        public Input<string>? EndPointRegion { get; set; }

        /// <summary>
        /// Endpoint service ID (namely, VPC endpoint service ID).
        /// </summary>
        [Input("endPointServiceId")]
        public Input<string>? EndPointServiceId { get; set; }

        [Input("endPointVipSets")]
        private InputList<string>? _endPointVipSets;

        /// <summary>
        /// Vip list of endpoint.
        /// </summary>
        public InputList<string> EndPointVipSets
        {
            get => _endPointVipSets ?? (_endPointVipSets = new InputList<string>());
            set => _endPointVipSets = value;
        }

        /// <summary>
        /// Number of endpoint IP addresses.
        /// </summary>
        [Input("ipNum")]
        public Input<int>? IpNum { get; set; }

        public EndPointState()
        {
        }
        public static new EndPointState Empty => new EndPointState();
    }
}
