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

    public sealed class ProcedureTemplateMediaProcessTaskTranscodeTaskListHeadTailListArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Video opening/closing credits configuration template ID.
        /// </summary>
        [Input("definition")]
        public Input<string>? Definition { get; set; }

        public ProcedureTemplateMediaProcessTaskTranscodeTaskListHeadTailListArgs()
        {
        }
        public static new ProcedureTemplateMediaProcessTaskTranscodeTaskListHeadTailListArgs Empty => new ProcedureTemplateMediaProcessTaskTranscodeTaskListHeadTailListArgs();
    }
}
