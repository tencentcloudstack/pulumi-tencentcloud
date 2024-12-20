// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Inputs
{

    public sealed class CngwGatewayNodeConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// node number, 2-50.
        /// </summary>
        [Input("number", required: true)]
        public Input<int> Number { get; set; } = null!;

        /// <summary>
        /// specification, 1c2g|2c4g|4c8g|8c16g.
        /// </summary>
        [Input("specification", required: true)]
        public Input<string> Specification { get; set; } = null!;

        public CngwGatewayNodeConfigGetArgs()
        {
        }
        public static new CngwGatewayNodeConfigGetArgs Empty => new CngwGatewayNodeConfigGetArgs();
    }
}
