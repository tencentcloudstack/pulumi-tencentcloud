// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Inputs
{

    public sealed class DatahubTaskSourceResourceTdwParamArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Tdw bid.
        /// </summary>
        [Input("bid", required: true)]
        public Input<string> Bid { get; set; } = null!;

        /// <summary>
        /// default true.
        /// </summary>
        [Input("isDomestic")]
        public Input<bool>? IsDomestic { get; set; }

        /// <summary>
        /// TDW address, defalt tl-tdbank-tdmanager.tencent-distribute.com.
        /// </summary>
        [Input("tdwHost")]
        public Input<string>? TdwHost { get; set; }

        /// <summary>
        /// TDW port, default 8099.
        /// </summary>
        [Input("tdwPort")]
        public Input<int>? TdwPort { get; set; }

        /// <summary>
        /// Tdw tid.
        /// </summary>
        [Input("tid", required: true)]
        public Input<string> Tid { get; set; } = null!;

        public DatahubTaskSourceResourceTdwParamArgs()
        {
        }
    }
}