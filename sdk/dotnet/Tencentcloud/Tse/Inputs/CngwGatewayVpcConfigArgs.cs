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

    public sealed class CngwGatewayVpcConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// subnet ID. Assign an IP address to the engine in the VPC subnet. Reference value: subnet-ahde9me9.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// VPC ID. Assign an IP address to the engine in the VPC subnet. Reference value: vpc-conz6aix.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public CngwGatewayVpcConfigArgs()
        {
        }
        public static new CngwGatewayVpcConfigArgs Empty => new CngwGatewayVpcConfigArgs();
    }
}
