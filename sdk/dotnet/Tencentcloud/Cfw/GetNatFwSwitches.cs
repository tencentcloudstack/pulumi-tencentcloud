// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfw
{
    public static class GetNatFwSwitches
    {
        /// <summary>
        /// Use this data source to query detailed information of cfw nat_fw_switches
        /// 
        /// ## Example Usage
        /// 
        /// ### Query Nat instance'switch by instance id
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
        ///     var example = Tencentcloud.Cfw.GetNatFwSwitches.Invoke(new()
        ///     {
        ///         NatInsId = "cfwnat-18d2ba18",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or filter by switch status
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
        ///     var example = Tencentcloud.Cfw.GetNatFwSwitches.Invoke(new()
        ///     {
        ///         NatInsId = "cfwnat-18d2ba18",
        ///         Status = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetNatFwSwitchesResult> InvokeAsync(GetNatFwSwitchesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNatFwSwitchesResult>("tencentcloud:Cfw/getNatFwSwitches:getNatFwSwitches", args ?? new GetNatFwSwitchesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cfw nat_fw_switches
        /// 
        /// ## Example Usage
        /// 
        /// ### Query Nat instance'switch by instance id
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
        ///     var example = Tencentcloud.Cfw.GetNatFwSwitches.Invoke(new()
        ///     {
        ///         NatInsId = "cfwnat-18d2ba18",
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// 
        /// ### Or filter by switch status
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
        ///     var example = Tencentcloud.Cfw.GetNatFwSwitches.Invoke(new()
        ///     {
        ///         NatInsId = "cfwnat-18d2ba18",
        ///         Status = 1,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetNatFwSwitchesResult> Invoke(GetNatFwSwitchesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNatFwSwitchesResult>("tencentcloud:Cfw/getNatFwSwitches:getNatFwSwitches", args ?? new GetNatFwSwitchesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNatFwSwitchesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter the NAT firewall instance to which the NAT firewall subnet switch belongs.
        /// </summary>
        [Input("natInsId")]
        public string? NatInsId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Switch status, 1 open; 0 close.
        /// </summary>
        [Input("status")]
        public int? Status { get; set; }

        public GetNatFwSwitchesArgs()
        {
        }
        public static new GetNatFwSwitchesArgs Empty => new GetNatFwSwitchesArgs();
    }

    public sealed class GetNatFwSwitchesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Filter the NAT firewall instance to which the NAT firewall subnet switch belongs.
        /// </summary>
        [Input("natInsId")]
        public Input<string>? NatInsId { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Switch status, 1 open; 0 close.
        /// </summary>
        [Input("status")]
        public Input<int>? Status { get; set; }

        public GetNatFwSwitchesInvokeArgs()
        {
        }
        public static new GetNatFwSwitchesInvokeArgs Empty => new GetNatFwSwitchesInvokeArgs();
    }


    [OutputType]
    public sealed class GetNatFwSwitchesResult
    {
        /// <summary>
        /// NAT border firewall switch list data.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetNatFwSwitchesDataResult> Datas;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// NAT firewall instance Id.
        /// </summary>
        public readonly string? NatInsId;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Switch status.
        /// </summary>
        public readonly int? Status;

        [OutputConstructor]
        private GetNatFwSwitchesResult(
            ImmutableArray<Outputs.GetNatFwSwitchesDataResult> datas,

            string id,

            string? natInsId,

            string? resultOutputFile,

            int? status)
        {
            Datas = datas;
            Id = id;
            NatInsId = natInsId;
            ResultOutputFile = resultOutputFile;
            Status = status;
        }
    }
}
