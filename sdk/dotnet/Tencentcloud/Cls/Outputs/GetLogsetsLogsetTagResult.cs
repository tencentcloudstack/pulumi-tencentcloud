// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls.Outputs
{

    [OutputType]
    public sealed class GetLogsetsLogsetTagResult
    {
        /// <summary>
        /// Fields that need to be filtered. Support: `logsetName`, `logsetId`, `tagKey`, `tag:tagKey`.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Tag value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetLogsetsLogsetTagResult(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
