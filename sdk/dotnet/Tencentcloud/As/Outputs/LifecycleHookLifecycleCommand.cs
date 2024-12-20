// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.As.Outputs
{

    [OutputType]
    public sealed class LifecycleHookLifecycleCommand
    {
        /// <summary>
        /// Remote command ID. It is required to execute a command.
        /// </summary>
        public readonly string CommandId;
        /// <summary>
        /// Custom parameter. The field type is JSON encoded string. For example, {"varA": "222"}.
        /// </summary>
        public readonly string? Parameters;

        [OutputConstructor]
        private LifecycleHookLifecycleCommand(
            string commandId,

            string? parameters)
        {
            CommandId = commandId;
            Parameters = parameters;
        }
    }
}
