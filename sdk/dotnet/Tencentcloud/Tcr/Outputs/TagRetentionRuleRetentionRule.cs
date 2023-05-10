// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcr.Outputs
{

    [OutputType]
    public sealed class TagRetentionRuleRetentionRule
    {
        /// <summary>
        /// The supported policies are latestPushedK (retain the latest `k` pushed versions) and nDaysSinceLastPush (retain pushed versions within the last `n` days).
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// corresponding values for rule settings.
        /// </summary>
        public readonly int Value;

        [OutputConstructor]
        private TagRetentionRuleRetentionRule(
            string key,

            int value)
        {
            Key = key;
            Value = value;
        }
    }
}