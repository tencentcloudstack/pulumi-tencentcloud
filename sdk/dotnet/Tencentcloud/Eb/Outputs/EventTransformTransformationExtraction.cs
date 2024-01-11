// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Outputs
{

    [OutputType]
    public sealed class EventTransformTransformationExtraction
    {
        /// <summary>
        /// JsonPath, if not specified, the default value $.
        /// </summary>
        public readonly string ExtractionInputPath;
        /// <summary>
        /// Value: `TEXT`, `JSON`.
        /// </summary>
        public readonly string Format;
        /// <summary>
        /// Only Text needs to be passed.
        /// </summary>
        public readonly Outputs.EventTransformTransformationExtractionTextParams? TextParams;

        [OutputConstructor]
        private EventTransformTransformationExtraction(
            string extractionInputPath,

            string format,

            Outputs.EventTransformTransformationExtractionTextParams? textParams)
        {
            ExtractionInputPath = extractionInputPath;
            Format = format;
            TextParams = textParams;
        }
    }
}