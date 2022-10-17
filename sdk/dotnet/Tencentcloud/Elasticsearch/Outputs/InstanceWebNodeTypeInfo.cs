// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Elasticsearch.Outputs
{

    [OutputType]
    public sealed class InstanceWebNodeTypeInfo
    {
        /// <summary>
        /// Visual node number.
        /// </summary>
        public readonly int NodeNum;
        /// <summary>
        /// Visual node specifications.
        /// </summary>
        public readonly string NodeType;

        [OutputConstructor]
        private InstanceWebNodeTypeInfo(
            int nodeNum,

            string nodeType)
        {
            NodeNum = nodeNum;
            NodeType = nodeType;
        }
    }
}