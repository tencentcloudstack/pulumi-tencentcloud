// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cls.Inputs
{

    public sealed class TopicExtendsAnonymousAccessConditionGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Condition attribute, currently only VpcID is supported.
        /// </summary>
        [Input("attributes")]
        public Input<string>? Attributes { get; set; }

        /// <summary>
        /// The value of the corresponding conditional attribute.
        /// </summary>
        [Input("conditionValue")]
        public Input<string>? ConditionValue { get; set; }

        /// <summary>
        /// Conditional rule, 1: equal, 2: not equal.
        /// </summary>
        [Input("rule")]
        public Input<int>? Rule { get; set; }

        public TopicExtendsAnonymousAccessConditionGetArgs()
        {
        }
        public static new TopicExtendsAnonymousAccessConditionGetArgs Empty => new TopicExtendsAnonymousAccessConditionGetArgs();
    }
}