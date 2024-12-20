// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ccn.Inputs
{

    public sealed class RouteTableSelectionPoliciesSelectionPolicyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// description.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Instance Type: Private Network: VPC, Dedicated Gateway: DIRECTCONNECT, Blackstone Private Network: BMVPC, EDGE Device: EDGE, EDGE Tunnel: EDGE_TUNNEL, EDGE Gateway: EDGE_VPNGW, VPN Gateway: VPNGW.
        /// </summary>
        [Input("instanceType", required: true)]
        public Input<string> InstanceType { get; set; } = null!;

        /// <summary>
        /// route table ID.
        /// </summary>
        [Input("routeTableId", required: true)]
        public Input<string> RouteTableId { get; set; } = null!;

        /// <summary>
        /// Source CIDR.
        /// </summary>
        [Input("sourceCidrBlock", required: true)]
        public Input<string> SourceCidrBlock { get; set; } = null!;

        public RouteTableSelectionPoliciesSelectionPolicyArgs()
        {
        }
        public static new RouteTableSelectionPoliciesSelectionPolicyArgs Empty => new RouteTableSelectionPoliciesSelectionPolicyArgs();
    }
}
