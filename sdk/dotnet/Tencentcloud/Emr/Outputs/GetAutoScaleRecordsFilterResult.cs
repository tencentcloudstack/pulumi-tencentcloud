// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Emr.Outputs
{

    [OutputType]
    public sealed class GetAutoScaleRecordsFilterResult
    {
        /// <summary>
        /// Key. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Value. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetAutoScaleRecordsFilterResult(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
