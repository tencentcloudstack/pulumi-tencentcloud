// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class ConfigInstanceRoGroupWeightPair
    {
        /// <summary>
        /// Read-only instance ID, in the format: mssqlro-3l3fgqn7.
        /// </summary>
        public readonly string ReadOnlyInstanceId;
        /// <summary>
        /// Read-only instance weight, the range is 0-100.
        /// </summary>
        public readonly int ReadOnlyWeight;

        [OutputConstructor]
        private ConfigInstanceRoGroupWeightPair(
            string readOnlyInstanceId,

            int readOnlyWeight)
        {
            ReadOnlyInstanceId = readOnlyInstanceId;
            ReadOnlyWeight = readOnlyWeight;
        }
    }
}