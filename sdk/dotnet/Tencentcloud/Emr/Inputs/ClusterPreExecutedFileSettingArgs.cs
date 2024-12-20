// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Emr.Inputs
{

    public sealed class ClusterPreExecutedFileSettingArgs : global::Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;

        /// <summary>
        /// Execution script parameters.
        /// </summary>
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        /// <summary>
        /// Script file name.
        /// </summary>
        [Input("cosFileName")]
        public Input<string>? CosFileName { get; set; }

        /// <summary>
        /// The cos address of the script.
        /// </summary>
        [Input("cosFileUri")]
        public Input<string>? CosFileUri { get; set; }

        /// <summary>
        /// Cos secretId.
        /// </summary>
        [Input("cosSecretId")]
        public Input<string>? CosSecretId { get; set; }

        /// <summary>
        /// Cos secretKey.
        /// </summary>
        [Input("cosSecretKey")]
        public Input<string>? CosSecretKey { get; set; }

        /// <summary>
        /// Remark.
        /// </summary>
        [Input("remark")]
        public Input<string>? Remark { get; set; }

        /// <summary>
        /// Run order.
        /// </summary>
        [Input("runOrder")]
        public Input<int>? RunOrder { get; set; }

        /// <summary>
        /// `resourceAfter` or `clusterAfter`.
        /// </summary>
        [Input("whenRun")]
        public Input<string>? WhenRun { get; set; }

        public ClusterPreExecutedFileSettingArgs()
        {
        }
        public static new ClusterPreExecutedFileSettingArgs Empty => new ClusterPreExecutedFileSettingArgs();
    }
}
