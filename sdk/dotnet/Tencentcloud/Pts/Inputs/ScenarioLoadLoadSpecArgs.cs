// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Pts.Inputs
{

    public sealed class ScenarioLoadLoadSpecArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of concurrent pressure mode.
        /// </summary>
        [Input("concurrency")]
        public Input<Inputs.ScenarioLoadLoadSpecConcurrencyArgs>? Concurrency { get; set; }

        /// <summary>
        /// Configuration of RPS pressure mode.
        /// </summary>
        [Input("requestsPerSecond")]
        public Input<Inputs.ScenarioLoadLoadSpecRequestsPerSecondArgs>? RequestsPerSecond { get; set; }

        /// <summary>
        /// Built-in stress mode in script.
        /// </summary>
        [Input("scriptOrigin")]
        public Input<Inputs.ScenarioLoadLoadSpecScriptOriginArgs>? ScriptOrigin { get; set; }

        public ScenarioLoadLoadSpecArgs()
        {
        }
        public static new ScenarioLoadLoadSpecArgs Empty => new ScenarioLoadLoadSpecArgs();
    }
}
