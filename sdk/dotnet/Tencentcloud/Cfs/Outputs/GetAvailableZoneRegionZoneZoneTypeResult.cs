// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cfs.Outputs
{

    [OutputType]
    public sealed class GetAvailableZoneRegionZoneZoneTypeResult
    {
        /// <summary>
        /// Indicates whether prepaid is supported. true: yes; false: no.
        /// </summary>
        public readonly bool Prepayment;
        /// <summary>
        /// Protocol and sale details.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneTypeProtocolResult> Protocols;
        /// <summary>
        /// Storage class. Valid values: SD (standard storage) and HP (high-performance storage).
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAvailableZoneRegionZoneZoneTypeResult(
            bool prepayment,

            ImmutableArray<Outputs.GetAvailableZoneRegionZoneZoneTypeProtocolResult> protocols,

            string type)
        {
            Prepayment = prepayment;
            Protocols = protocols;
            Type = type;
        }
    }
}