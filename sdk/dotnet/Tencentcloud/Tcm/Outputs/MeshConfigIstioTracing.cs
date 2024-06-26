// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class MeshConfigIstioTracing
    {
        /// <summary>
        /// APM config.
        /// </summary>
        public readonly Outputs.MeshConfigIstioTracingApm? Apm;
        /// <summary>
        /// Whether enable tracing.
        /// </summary>
        public readonly bool? Enable;
        /// <summary>
        /// Tracing sampling, 0.0-1.0.
        /// </summary>
        public readonly double? Sampling;
        /// <summary>
        /// Third party zipkin config.
        /// </summary>
        public readonly Outputs.MeshConfigIstioTracingZipkin? Zipkin;

        [OutputConstructor]
        private MeshConfigIstioTracing(
            Outputs.MeshConfigIstioTracingApm? apm,

            bool? enable,

            double? sampling,

            Outputs.MeshConfigIstioTracingZipkin? zipkin)
        {
            Apm = apm;
            Enable = enable;
            Sampling = sampling;
            Zipkin = zipkin;
        }
    }
}
