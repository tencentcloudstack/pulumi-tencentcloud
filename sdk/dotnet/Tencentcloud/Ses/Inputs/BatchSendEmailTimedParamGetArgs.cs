// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ses.Inputs
{

    public sealed class BatchSendEmailTimedParamGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Start time of a scheduled sending task.
        /// </summary>
        [Input("beginTime", required: true)]
        public Input<string> BeginTime { get; set; } = null!;

        public BatchSendEmailTimedParamGetArgs()
        {
        }
        public static new BatchSendEmailTimedParamGetArgs Empty => new BatchSendEmailTimedParamGetArgs();
    }
}
