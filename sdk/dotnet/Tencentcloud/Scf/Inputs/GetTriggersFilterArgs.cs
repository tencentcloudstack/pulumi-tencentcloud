// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf.Inputs
{

    public sealed class GetTriggersFilterInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Fields to be filtered. Up to 10 conditions allowed.Values of Name: VpcId, SubnetId, ClsTopicId, ClsLogsetId, Role, CfsId, CfsMountInsId, Eip. Values limit: 1.Name options: Status, Runtime, FunctionType, PublicNetStatus, AsyncRunEnable, TraceEnable. Values limit: 20.When Name is Runtime, CustomImage refers to the image type function.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// Filter values of the field.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public GetTriggersFilterInputArgs()
        {
        }
        public static new GetTriggersFilterInputArgs Empty => new GetTriggersFilterInputArgs();
    }
}
