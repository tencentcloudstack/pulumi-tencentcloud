// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vod.Inputs
{

    public sealed class ProcedureTemplateAiAnalysisTaskGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Video content analysis template ID.
        /// </summary>
        [Input("definition")]
        public Input<string>? Definition { get; set; }

        public ProcedureTemplateAiAnalysisTaskGetArgs()
        {
        }
        public static new ProcedureTemplateAiAnalysisTaskGetArgs Empty => new ProcedureTemplateAiAnalysisTaskGetArgs();
    }
}