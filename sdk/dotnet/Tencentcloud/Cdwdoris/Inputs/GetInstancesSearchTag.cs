// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cdwdoris.Inputs
{

    public sealed class GetInstancesSearchTagArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// 1 means only the tag key is entered without a value, and 0 means both the key and the value are entered.
        /// </summary>
        [Input("allValue")]
        public int? AllValue { get; set; }

        /// <summary>
        /// Tag key.
        /// </summary>
        [Input("tagKey")]
        public string? TagKey { get; set; }

        /// <summary>
        /// Tag value.
        /// </summary>
        [Input("tagValue")]
        public string? TagValue { get; set; }

        public GetInstancesSearchTagArgs()
        {
        }
        public static new GetInstancesSearchTagArgs Empty => new GetInstancesSearchTagArgs();
    }
}