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
    public sealed class GetMeshMeshListConfigResult
    {
        /// <summary>
        /// Istio configuration.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetMeshMeshListConfigIstioResult> Istios;

        [OutputConstructor]
        private GetMeshMeshListConfigResult(ImmutableArray<Outputs.GetMeshMeshListConfigIstioResult> istios)
        {
            Istios = istios;
        }
    }
}
