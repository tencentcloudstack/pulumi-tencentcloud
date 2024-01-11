// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css
{
    public static class GetDeliverLogDownList
    {
        public static Task<GetDeliverLogDownListResult> InvokeAsync(GetDeliverLogDownListArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDeliverLogDownListResult>("tencentcloud:Css/getDeliverLogDownList:getDeliverLogDownList", args ?? new GetDeliverLogDownListArgs(), options.WithDefaults());

        public static Output<GetDeliverLogDownListResult> Invoke(GetDeliverLogDownListInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDeliverLogDownListResult>("tencentcloud:Css/getDeliverLogDownList:getDeliverLogDownList", args ?? new GetDeliverLogDownListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDeliverLogDownListArgs : Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDeliverLogDownListArgs()
        {
        }
    }

    public sealed class GetDeliverLogDownListInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDeliverLogDownListInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDeliverLogDownListResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetDeliverLogDownListLogInfoListResult> LogInfoLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDeliverLogDownListResult(
            string id,

            ImmutableArray<Outputs.GetDeliverLogDownListLogInfoListResult> logInfoLists,

            string? resultOutputFile)
        {
            Id = id;
            LogInfoLists = logInfoLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}