// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mps.Inputs
{

    public sealed class EditMediaOperationFileInfoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// End time offset of video clipping in seconds.
        /// </summary>
        [Input("endTimeOffset")]
        public Input<double>? EndTimeOffset { get; set; }

        /// <summary>
        /// Video input information.
        /// </summary>
        [Input("inputInfo", required: true)]
        public Input<Inputs.EditMediaOperationFileInfoInputInfoArgs> InputInfo { get; set; } = null!;

        /// <summary>
        /// Start time offset of video clipping in seconds.
        /// </summary>
        [Input("startTimeOffset")]
        public Input<double>? StartTimeOffset { get; set; }

        public EditMediaOperationFileInfoArgs()
        {
        }
        public static new EditMediaOperationFileInfoArgs Empty => new EditMediaOperationFileInfoArgs();
    }
}
