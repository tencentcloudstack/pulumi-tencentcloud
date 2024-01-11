// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Css.Outputs
{

    [OutputType]
    public sealed class GetMonitorReportMpsResultResult
    {
        /// <summary>
        /// The result of intelligent speech recognition.Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly ImmutableArray<string> AiAsrResults;
        /// <summary>
        /// The result of intelligent text recognition.Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        public readonly ImmutableArray<string> AiOcrResults;

        [OutputConstructor]
        private GetMonitorReportMpsResultResult(
            ImmutableArray<string> aiAsrResults,

            ImmutableArray<string> aiOcrResults)
        {
            AiAsrResults = aiAsrResults;
            AiOcrResults = aiOcrResults;
        }
    }
}