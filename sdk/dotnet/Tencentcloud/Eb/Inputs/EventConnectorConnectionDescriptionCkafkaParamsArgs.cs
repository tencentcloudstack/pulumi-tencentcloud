// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Eb.Inputs
{

    public sealed class EventConnectorConnectionDescriptionCkafkaParamsArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// kafka offset.
        /// </summary>
        [Input("offset", required: true)]
        public Input<string> Offset { get; set; } = null!;

        /// <summary>
        /// ckafka  topic.
        /// </summary>
        [Input("topicName", required: true)]
        public Input<string> TopicName { get; set; } = null!;

        public EventConnectorConnectionDescriptionCkafkaParamsArgs()
        {
        }
        public static new EventConnectorConnectionDescriptionCkafkaParamsArgs Empty => new EventConnectorConnectionDescriptionCkafkaParamsArgs();
    }
}
