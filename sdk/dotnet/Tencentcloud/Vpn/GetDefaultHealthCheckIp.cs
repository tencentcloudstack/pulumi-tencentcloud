// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpn
{
    public static class GetDefaultHealthCheckIp
    {
        /// <summary>
        /// Use this data source to query detailed information of vpn default_health_check_ip
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
        ///         var defaultHealthCheckIp = Output.Create(Tencentcloud.Vpn.GetDefaultHealthCheckIp.InvokeAsync(new Tencentcloud.Vpn.GetDefaultHealthCheckIpArgs
        ///         {
        ///             VpnGatewayId = "vpngw-gt8bianl",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDefaultHealthCheckIpResult> InvokeAsync(GetDefaultHealthCheckIpArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDefaultHealthCheckIpResult>("tencentcloud:Vpn/getDefaultHealthCheckIp:getDefaultHealthCheckIp", args ?? new GetDefaultHealthCheckIpArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of vpn default_health_check_ip
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
        ///         var defaultHealthCheckIp = Output.Create(Tencentcloud.Vpn.GetDefaultHealthCheckIp.InvokeAsync(new Tencentcloud.Vpn.GetDefaultHealthCheckIpArgs
        ///         {
        ///             VpnGatewayId = "vpngw-gt8bianl",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetDefaultHealthCheckIpResult> Invoke(GetDefaultHealthCheckIpInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetDefaultHealthCheckIpResult>("tencentcloud:Vpn/getDefaultHealthCheckIp:getDefaultHealthCheckIp", args ?? new GetDefaultHealthCheckIpInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDefaultHealthCheckIpArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// vpn gateway id.
        /// </summary>
        [Input("vpnGatewayId", required: true)]
        public string VpnGatewayId { get; set; } = null!;

        public GetDefaultHealthCheckIpArgs()
        {
        }
    }

    public sealed class GetDefaultHealthCheckIpInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// vpn gateway id.
        /// </summary>
        [Input("vpnGatewayId", required: true)]
        public Input<string> VpnGatewayId { get; set; } = null!;

        public GetDefaultHealthCheckIpInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDefaultHealthCheckIpResult
    {
        /// <summary>
        /// local ip of health check.
        /// </summary>
        public readonly string HealthCheckLocalIp;
        /// <summary>
        /// remote ip for health check.
        /// </summary>
        public readonly string HealthCheckRemoteIp;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly string VpnGatewayId;

        [OutputConstructor]
        private GetDefaultHealthCheckIpResult(
            string healthCheckLocalIp,

            string healthCheckRemoteIp,

            string id,

            string? resultOutputFile,

            string vpnGatewayId)
        {
            HealthCheckLocalIp = healthCheckLocalIp;
            HealthCheckRemoteIp = healthCheckRemoteIp;
            Id = id;
            ResultOutputFile = resultOutputFile;
            VpnGatewayId = vpnGatewayId;
        }
    }
}