// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskTransformParamFilterParam
    {
        /// <summary>
        /// Key.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Matching mode, prefix matches PREFIX, suffix matches SUFFIX, contains matches CONTAINS, except matches EXCEPT, value matches NUMBER, IP matches IP.
        /// </summary>
        public readonly string MatchMode;
        /// <summary>
        /// REGULAR.
        /// </summary>
        public readonly string? Type;
        /// <summary>
        /// Value.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private DatahubTaskTransformParamFilterParam(
            string key,

            string matchMode,

            string? type,

            string value)
        {
            Key = key;
            MatchMode = matchMode;
            Type = type;
            Value = value;
        }
    }
}