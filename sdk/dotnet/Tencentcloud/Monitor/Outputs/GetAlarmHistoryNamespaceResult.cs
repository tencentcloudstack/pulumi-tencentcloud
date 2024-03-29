// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class GetAlarmHistoryNamespaceResult
    {
        /// <summary>
        /// Monitor type.
        /// </summary>
        public readonly string MonitorType;
        /// <summary>
        /// Policy type.
        /// </summary>
        public readonly string Namespace;

        [OutputConstructor]
        private GetAlarmHistoryNamespaceResult(
            string monitorType,

            string @namespace)
        {
            MonitorType = monitorType;
            Namespace = @namespace;
        }
    }
}
