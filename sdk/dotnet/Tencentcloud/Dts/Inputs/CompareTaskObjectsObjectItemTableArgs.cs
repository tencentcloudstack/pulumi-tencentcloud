// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dts.Inputs
{

    public sealed class CompareTaskObjectsObjectItemTableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// table name.
        /// </summary>
        [Input("tableName")]
        public Input<string>? TableName { get; set; }

        public CompareTaskObjectsObjectItemTableArgs()
        {
        }
    }
}