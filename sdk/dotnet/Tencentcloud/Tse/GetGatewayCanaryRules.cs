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
    public static class GetGatewayCanaryRules
    {
        /// <summary>
        /// Use this data source to query detailed information of tse gateway_canary_rules
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
        ///         var gatewayCanaryRules = Output.Create(Tencentcloud.Tse.GetGatewayCanaryRules.InvokeAsync(new Tencentcloud.Tse.GetGatewayCanaryRulesArgs
        ///         {
        ///             GatewayId = "gateway-xxxxxx",
        ///             ServiceId = "451a9920-e67a-4519-af41-fccac0e72005",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetGatewayCanaryRulesResult> InvokeAsync(GetGatewayCanaryRulesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetGatewayCanaryRulesResult>("tencentcloud:Tse/getGatewayCanaryRules:getGatewayCanaryRules", args ?? new GetGatewayCanaryRulesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of tse gateway_canary_rules
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
        ///         var gatewayCanaryRules = Output.Create(Tencentcloud.Tse.GetGatewayCanaryRules.InvokeAsync(new Tencentcloud.Tse.GetGatewayCanaryRulesArgs
        ///         {
        ///             GatewayId = "gateway-xxxxxx",
        ///             ServiceId = "451a9920-e67a-4519-af41-fccac0e72005",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetGatewayCanaryRulesResult> Invoke(GetGatewayCanaryRulesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetGatewayCanaryRulesResult>("tencentcloud:Tse/getGatewayCanaryRules:getGatewayCanaryRules", args ?? new GetGatewayCanaryRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGatewayCanaryRulesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// gateway ID.
        /// </summary>
        [Input("gatewayId", required: true)]
        public string GatewayId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// service ID.
        /// </summary>
        [Input("serviceId", required: true)]
        public string ServiceId { get; set; } = null!;

        public GetGatewayCanaryRulesArgs()
        {
        }
    }

    public sealed class GetGatewayCanaryRulesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// gateway ID.
        /// </summary>
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// service ID.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public GetGatewayCanaryRulesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetGatewayCanaryRulesResult
    {
        public readonly string GatewayId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// canary rule configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGatewayCanaryRulesResultResult> Results;
        /// <summary>
        /// service ID.
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private GetGatewayCanaryRulesResult(
            string gatewayId,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetGatewayCanaryRulesResultResult> results,

            string serviceId)
        {
            GatewayId = gatewayId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
            ServiceId = serviceId;
        }
    }
}