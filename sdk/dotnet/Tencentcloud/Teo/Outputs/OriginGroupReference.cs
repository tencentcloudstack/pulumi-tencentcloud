// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class OriginGroupReference
    {
        /// <summary>
        /// The instance ID of the reference type.
        /// </summary>
        public readonly string? InstanceId;
        /// <summary>
        /// Instance name of the application type.
        /// </summary>
        public readonly string? InstanceName;
        /// <summary>
        /// Reference service type, the values are:
        /// </summary>
        public readonly string? InstanceType;

        [OutputConstructor]
        private OriginGroupReference(
            string? instanceId,

            string? instanceName,

            string? instanceType)
        {
            InstanceId = instanceId;
            InstanceName = instanceName;
            InstanceType = instanceType;
        }
    }
}
