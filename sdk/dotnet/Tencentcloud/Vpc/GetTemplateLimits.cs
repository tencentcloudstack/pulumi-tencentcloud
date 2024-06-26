// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpc
{
    public static class GetTemplateLimits
    {
        /// <summary>
        /// Use this data source to query detailed information of vpc template_limits
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
        ///     var templateLimits = Tencentcloud.Vpc.GetTemplateLimits.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetTemplateLimitsResult> InvokeAsync(GetTemplateLimitsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTemplateLimitsResult>("tencentcloud:Vpc/getTemplateLimits:getTemplateLimits", args ?? new GetTemplateLimitsArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpc template_limits
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
        ///     var templateLimits = Tencentcloud.Vpc.GetTemplateLimits.Invoke();
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetTemplateLimitsResult> Invoke(GetTemplateLimitsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTemplateLimitsResult>("tencentcloud:Vpc/getTemplateLimits:getTemplateLimits", args ?? new GetTemplateLimitsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTemplateLimitsArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTemplateLimitsArgs()
        {
        }
        public static new GetTemplateLimitsArgs Empty => new GetTemplateLimitsArgs();
    }

    public sealed class GetTemplateLimitsInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTemplateLimitsInvokeArgs()
        {
        }
        public static new GetTemplateLimitsInvokeArgs Empty => new GetTemplateLimitsInvokeArgs();
    }


    [OutputType]
    public sealed class GetTemplateLimitsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// template limit.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetTemplateLimitsTemplateLimitResult> TemplateLimits;

        [OutputConstructor]
        private GetTemplateLimitsResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTemplateLimitsTemplateLimitResult> templateLimits)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            TemplateLimits = templateLimits;
        }
    }
}
