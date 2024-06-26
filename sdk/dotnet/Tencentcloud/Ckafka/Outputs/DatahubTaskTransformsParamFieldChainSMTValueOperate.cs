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
    public sealed class DatahubTaskTransformsParamFieldChainSMTValueOperate
    {
        /// <summary>
        /// Time conversion, required when TYPE=DATE.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateDate? Date;
        /// <summary>
        /// Json Path replacement, must pass when TYPE=JSON PATH REPLACE.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateJsonPathReplace? JsonPathReplace;
        /// <summary>
        /// Key-value secondary analysis, must be passed when TYPE=KV.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateKV? KV;
        /// <summary>
        /// Regular replacement, required when TYPE=REGEX REPLACE.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateRegexReplace? RegexReplace;
        /// <summary>
        /// replace, TYPE=REPLACE is required.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateReplace? Replace;
        /// <summary>
        /// result.
        /// </summary>
        public readonly string? Result;
        /// <summary>
        /// The value supports one split and multiple values, required when TYPE=SPLIT.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateSplit? Split;
        /// <summary>
        /// Substr, TYPE=SUBSTR is required.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateSubstr? Substr;
        /// <summary>
        /// Processing mode, REPLACE replacement, SUBSTR interception, DATE date conversion, TRIM removal of leading and trailing spaces, REGEX REPLACE regular replacement, URL DECODE, LOWERCASE conversion to lowercase.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Url parsing.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateUrlDecode? UrlDecode;

        [OutputConstructor]
        private DatahubTaskTransformsParamFieldChainSMTValueOperate(
            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateDate? date,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateJsonPathReplace? jsonPathReplace,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateKV? kV,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateRegexReplace? regexReplace,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateReplace? replace,

            string? result,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateSplit? split,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateSubstr? substr,

            string type,

            Outputs.DatahubTaskTransformsParamFieldChainSMTValueOperateUrlDecode? urlDecode)
        {
            Date = date;
            JsonPathReplace = jsonPathReplace;
            KV = kV;
            RegexReplace = regexReplace;
            Replace = replace;
            Result = result;
            Split = split;
            Substr = substr;
            Type = type;
            UrlDecode = urlDecode;
        }
    }
}
