// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Elasticsearch.Inputs
{

    public sealed class LogstashOperationDurationArgs : global::Pulumi.ResourceArgs
    {
        [Input("periods", required: true)]
        private InputList<int>? _periods;

        /// <summary>
        /// day of week, from Monday to Sunday, value range: [0, 6]notes: may return null when missing.
        /// </summary>
        public InputList<int> Periods
        {
            get => _periods ?? (_periods = new InputList<int>());
            set => _periods = value;
        }

        /// <summary>
        /// operation end time.
        /// </summary>
        [Input("timeEnd", required: true)]
        public Input<string> TimeEnd { get; set; } = null!;

        /// <summary>
        /// operation start time.
        /// </summary>
        [Input("timeStart", required: true)]
        public Input<string> TimeStart { get; set; } = null!;

        /// <summary>
        /// time zone, for example: UTC+8.
        /// </summary>
        [Input("timeZone", required: true)]
        public Input<string> TimeZone { get; set; } = null!;

        public LogstashOperationDurationArgs()
        {
        }
        public static new LogstashOperationDurationArgs Empty => new LogstashOperationDurationArgs();
    }
}
