// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class BatchManifest
    {
        /// <summary>
        /// The location information of the list of objects.
        /// </summary>
        public readonly Outputs.BatchManifestLocation Location;
        /// <summary>
        /// Format information that describes the list of objects. If it is a CSV file, this element describes the fields contained in the manifest.
        /// </summary>
        public readonly Outputs.BatchManifestSpec Spec;

        [OutputConstructor]
        private BatchManifest(
            Outputs.BatchManifestLocation location,

            Outputs.BatchManifestSpec spec)
        {
            Location = location;
            Spec = spec;
        }
    }
}