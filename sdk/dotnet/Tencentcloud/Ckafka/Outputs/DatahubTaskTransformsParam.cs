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
    public sealed class DatahubTaskTransformsParam
    {
        /// <summary>
        /// data process.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamBatchAnalyse? BatchAnalyse;
        /// <summary>
        /// Raw data.
        /// </summary>
        public readonly string Content;
        /// <summary>
        /// fail process.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFailureParam? FailureParam;
        /// <summary>
        /// processing chain.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatahubTaskTransformsParamFieldChain> FieldChains;
        /// <summary>
        /// filter.
        /// </summary>
        public readonly ImmutableArray<Outputs.DatahubTaskTransformsParamFilterParam> FilterParams;
        /// <summary>
        /// Whether to keep the data source Topic metadata information (source Topic, Partition, Offset), the default is false.
        /// </summary>
        public readonly bool? KeepMetadata;
        /// <summary>
        /// output format, JSON, ROW, default JSON.
        /// </summary>
        public readonly string? OutputFormat;
        /// <summary>
        /// result.
        /// </summary>
        public readonly string? Result;
        /// <summary>
        /// The output format is ROW Required.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamRowParam? RowParam;
        /// <summary>
        /// data source.
        /// </summary>
        public readonly string? SourceType;

        [OutputConstructor]
        private DatahubTaskTransformsParam(
            Outputs.DatahubTaskTransformsParamBatchAnalyse? batchAnalyse,

            string content,

            Outputs.DatahubTaskTransformsParamFailureParam? failureParam,

            ImmutableArray<Outputs.DatahubTaskTransformsParamFieldChain> fieldChains,

            ImmutableArray<Outputs.DatahubTaskTransformsParamFilterParam> filterParams,

            bool? keepMetadata,

            string? outputFormat,

            string? result,

            Outputs.DatahubTaskTransformsParamRowParam? rowParam,

            string? sourceType)
        {
            BatchAnalyse = batchAnalyse;
            Content = content;
            FailureParam = failureParam;
            FieldChains = fieldChains;
            FilterParams = filterParams;
            KeepMetadata = keepMetadata;
            OutputFormat = outputFormat;
            Result = result;
            RowParam = rowParam;
            SourceType = sourceType;
        }
    }
}
