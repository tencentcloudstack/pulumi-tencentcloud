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
    public sealed class DatahubTaskTransformsParamFailureParam
    {
        /// <summary>
        /// dlq type, CKAFKA|TOPIC.
        /// </summary>
        public readonly string? DlqType;
        /// <summary>
        /// Ckafka type dlq.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFailureParamKafkaParam? KafkaParam;
        /// <summary>
        /// retry times.
        /// </summary>
        public readonly int? MaxRetryAttempts;
        /// <summary>
        /// retry interval.
        /// </summary>
        public readonly int? RetryInterval;
        /// <summary>
        /// DIP Topic type dead letter queue.
        /// </summary>
        public readonly Outputs.DatahubTaskTransformsParamFailureParamTopicParam? TopicParam;
        /// <summary>
        /// type, DLQ dead letter queue, IGNORE_ERROR|DROP.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DatahubTaskTransformsParamFailureParam(
            string? dlqType,

            Outputs.DatahubTaskTransformsParamFailureParamKafkaParam? kafkaParam,

            int? maxRetryAttempts,

            int? retryInterval,

            Outputs.DatahubTaskTransformsParamFailureParamTopicParam? topicParam,

            string type)
        {
            DlqType = dlqType;
            KafkaParam = kafkaParam;
            MaxRetryAttempts = maxRetryAttempts;
            RetryInterval = retryInterval;
            TopicParam = topicParam;
            Type = type;
        }
    }
}