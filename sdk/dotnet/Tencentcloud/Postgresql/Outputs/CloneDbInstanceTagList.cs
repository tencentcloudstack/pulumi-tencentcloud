// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class CloneDbInstanceTagList
    {
        /// <summary>
        /// Tag key.
        /// </summary>
        public readonly string TagKey;
        /// <summary>
        /// Tag value.
        /// </summary>
        public readonly string TagValue;

        [OutputConstructor]
        private CloneDbInstanceTagList(
            string tagKey,

            string tagValue)
        {
            TagKey = tagKey;
            TagValue = tagValue;
        }
    }
}