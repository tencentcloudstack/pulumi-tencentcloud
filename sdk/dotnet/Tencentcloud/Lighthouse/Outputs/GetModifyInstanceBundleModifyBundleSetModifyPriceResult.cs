// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class GetModifyInstanceBundleModifyBundleSetModifyPriceResult
    {
        /// <summary>
        /// Instance price.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetModifyInstanceBundleModifyBundleSetModifyPriceInstancePriceResult> InstancePrices;

        [OutputConstructor]
        private GetModifyInstanceBundleModifyBundleSetModifyPriceResult(ImmutableArray<Outputs.GetModifyInstanceBundleModifyBundleSetModifyPriceInstancePriceResult> instancePrices)
        {
            InstancePrices = instancePrices;
        }
    }
}
