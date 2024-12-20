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
    public sealed class CosRechargeExtractRuleInfo
    {
        /// <summary>
        /// syslog address.
        /// </summary>
        public readonly string? Address;
        /// <summary>
        /// backtracking data volume in incremental acquisition mode.
        /// </summary>
        public readonly int? Backtracking;
        /// <summary>
        /// begin line regex.
        /// </summary>
        public readonly string? BeginRegex;
        /// <summary>
        /// log delimiter.
        /// </summary>
        public readonly string? Delimiter;
        /// <summary>
        /// rules that need to filter logs.
        /// </summary>
        public readonly ImmutableArray<Outputs.CosRechargeExtractRuleInfoFilterKeyRegex> FilterKeyRegexes;
        /// <summary>
        /// gbk encoding.
        /// </summary>
        public readonly int? IsGbk;
        /// <summary>
        /// is standard json.
        /// </summary>
        public readonly int? JsonStandard;
        /// <summary>
        /// key list.
        /// </summary>
        public readonly ImmutableArray<string> Keys;
        /// <summary>
        /// log regex.
        /// </summary>
        public readonly string? LogRegex;
        /// <summary>
        /// metadata tag list.
        /// </summary>
        public readonly ImmutableArray<Outputs.CosRechargeExtractRuleInfoMetaTag> MetaTags;
        /// <summary>
        /// metadata type.
        /// </summary>
        public readonly int? MetadataType;
        /// <summary>
        /// parse protocol.
        /// </summary>
        public readonly string? ParseProtocol;
        /// <summary>
        /// metadata path regex.
        /// </summary>
        public readonly string? PathRegex;
        /// <summary>
        /// syslog protocol.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// time format.
        /// </summary>
        public readonly string? TimeFormat;
        /// <summary>
        /// time key.
        /// </summary>
        public readonly string? TimeKey;
        /// <summary>
        /// parsing failure log key.
        /// </summary>
        public readonly string? UnMatchLogKey;
        /// <summary>
        /// whether to upload the parsing failure log.
        /// </summary>
        public readonly bool? UnMatchUpLoadSwitch;

        [OutputConstructor]
        private CosRechargeExtractRuleInfo(
            string? address,

            int? backtracking,

            string? beginRegex,

            string? delimiter,

            ImmutableArray<Outputs.CosRechargeExtractRuleInfoFilterKeyRegex> filterKeyRegexes,

            int? isGbk,

            int? jsonStandard,

            ImmutableArray<string> keys,

            string? logRegex,

            ImmutableArray<Outputs.CosRechargeExtractRuleInfoMetaTag> metaTags,

            int? metadataType,

            string? parseProtocol,

            string? pathRegex,

            string? protocol,

            string? timeFormat,

            string? timeKey,

            string? unMatchLogKey,

            bool? unMatchUpLoadSwitch)
        {
            Address = address;
            Backtracking = backtracking;
            BeginRegex = beginRegex;
            Delimiter = delimiter;
            FilterKeyRegexes = filterKeyRegexes;
            IsGbk = isGbk;
            JsonStandard = jsonStandard;
            Keys = keys;
            LogRegex = logRegex;
            MetaTags = metaTags;
            MetadataType = metadataType;
            ParseProtocol = parseProtocol;
            PathRegex = pathRegex;
            Protocol = protocol;
            TimeFormat = timeFormat;
            TimeKey = timeKey;
            UnMatchLogKey = unMatchLogKey;
            UnMatchUpLoadSwitch = unMatchUpLoadSwitch;
        }
    }
}
