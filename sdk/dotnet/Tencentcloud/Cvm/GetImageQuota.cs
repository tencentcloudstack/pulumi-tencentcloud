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
    public static class GetImageQuota
    {
        /// <summary>
        /// Use this data source to query detailed information of cvm image_quota
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var imageQuota = Output.Create(Tencentcloud.Cvm.GetImageQuota.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetImageQuotaResult> InvokeAsync(GetImageQuotaArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetImageQuotaResult>("tencentcloud:Cvm/getImageQuota:getImageQuota", args ?? new GetImageQuotaArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of cvm image_quota
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var imageQuota = Output.Create(Tencentcloud.Cvm.GetImageQuota.InvokeAsync());
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetImageQuotaResult> Invoke(GetImageQuotaInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetImageQuotaResult>("tencentcloud:Cvm/getImageQuota:getImageQuota", args ?? new GetImageQuotaInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetImageQuotaArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetImageQuotaArgs()
        {
        }
    }

    public sealed class GetImageQuotaInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetImageQuotaInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetImageQuotaResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The image quota of an account.
        /// </summary>
        public readonly int ImageNumQuota;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetImageQuotaResult(
            string id,

            int imageNumQuota,

            string? resultOutputFile)
        {
            Id = id;
            ImageNumQuota = imageNumQuota;
            ResultOutputFile = resultOutputFile;
        }
    }
}