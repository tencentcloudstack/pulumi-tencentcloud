// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Outputs
{

    [OutputType]
    public sealed class JobLoad
    {
        /// <summary>
        /// Pressure distribution.
        /// </summary>
        public readonly ImmutableArray<Outputs.JobLoadGeoRegionsLoadDistribution> GeoRegionsLoadDistributions;
        /// <summary>
        /// Pressure allocation.
        /// </summary>
        public readonly Outputs.JobLoadLoadSpec? LoadSpec;
        /// <summary>
        /// Source of stress.
        /// </summary>
        public readonly Outputs.JobLoadVpcLoadDistribution? VpcLoadDistribution;

        [OutputConstructor]
        private JobLoad(
            ImmutableArray<Outputs.JobLoadGeoRegionsLoadDistribution> geoRegionsLoadDistributions,

            Outputs.JobLoadLoadSpec? loadSpec,

            Outputs.JobLoadVpcLoadDistribution? vpcLoadDistribution)
        {
            GeoRegionsLoadDistributions = geoRegionsLoadDistributions;
            LoadSpec = loadSpec;
            VpcLoadDistribution = vpcLoadDistribution;
        }
    }
}
