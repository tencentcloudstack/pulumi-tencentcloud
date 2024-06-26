// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ses.Outputs
{

    [OutputType]
    public sealed class BatchSendEmailTimedParam
    {
        /// <summary>
        /// Start time of a scheduled sending task.
        /// </summary>
        public readonly string BeginTime;

        [OutputConstructor]
        private BatchSendEmailTimedParam(string beginTime)
        {
            BeginTime = beginTime;
        }
    }
}
