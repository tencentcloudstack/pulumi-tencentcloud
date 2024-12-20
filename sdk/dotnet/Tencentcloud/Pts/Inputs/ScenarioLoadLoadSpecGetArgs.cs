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

    public sealed class ScenarioLoadLoadSpecGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration of concurrent pressure mode.
        /// </summary>
        [Input("concurrency")]
        public Input<Inputs.ScenarioLoadLoadSpecConcurrencyGetArgs>? Concurrency { get; set; }

        /// <summary>
        /// Configuration of RPS pressure mode.
        /// </summary>
        [Input("requestsPerSecond")]
        public Input<Inputs.ScenarioLoadLoadSpecRequestsPerSecondGetArgs>? RequestsPerSecond { get; set; }

        /// <summary>
        /// Built-in stress mode in script.
        /// </summary>
        [Input("scriptOrigin")]
        public Input<Inputs.ScenarioLoadLoadSpecScriptOriginGetArgs>? ScriptOrigin { get; set; }

        public ScenarioLoadLoadSpecGetArgs()
        {
        }
        public static new ScenarioLoadLoadSpecGetArgs Empty => new ScenarioLoadLoadSpecGetArgs();
    }
}
