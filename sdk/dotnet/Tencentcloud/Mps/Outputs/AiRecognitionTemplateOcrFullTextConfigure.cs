// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class AiRecognitionTemplateOcrFullTextConfigure
    {
        /// <summary>
        /// Ocr full text recognition task switch, optional value:ON/OFF.
        /// </summary>
        public readonly string Switch;

        [OutputConstructor]
        private AiRecognitionTemplateOcrFullTextConfigure(string @switch)
        {
            Switch = @switch;
        }
    }
}
