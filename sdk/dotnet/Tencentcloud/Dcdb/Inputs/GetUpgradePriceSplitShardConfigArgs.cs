// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dcdb.Inputs
{

    public sealed class GetUpgradePriceSplitShardConfigInputArgs : Pulumi.ResourceArgs
    {
        [Input("shardInstanceIds", required: true)]
        private InputList<string>? _shardInstanceIds;

        /// <summary>
        /// List of shard ID.
        /// </summary>
        public InputList<string> ShardInstanceIds
        {
            get => _shardInstanceIds ?? (_shardInstanceIds = new InputList<string>());
            set => _shardInstanceIds = value;
        }

        /// <summary>
        /// Shard memory size in GB.
        /// </summary>
        [Input("shardMemory", required: true)]
        public Input<int> ShardMemory { get; set; } = null!;

        /// <summary>
        /// Shard storage capacity in GB.
        /// </summary>
        [Input("shardStorage", required: true)]
        public Input<int> ShardStorage { get; set; } = null!;

        /// <summary>
        /// Data split ratio, fixed at 50%.
        /// </summary>
        [Input("splitRate", required: true)]
        public Input<int> SplitRate { get; set; } = null!;

        public GetUpgradePriceSplitShardConfigInputArgs()
        {
        }
    }
}