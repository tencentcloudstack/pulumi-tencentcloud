// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Thpc.Inputs
{

    public sealed class WorkspacesEnhancedServiceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable the TencentCloud Automation Tools (TAT) service. If this parameter is not specified, the cloud automation tools service will be enabled by default.
        /// </summary>
        [Input("automationService")]
        public Input<Inputs.WorkspacesEnhancedServiceAutomationServiceArgs>? AutomationService { get; set; }

        /// <summary>
        /// Activate Tencent Cloud Observable Platform service. If this parameter is not specified, the Tencent Cloud Observable Platform service will be enabled by default.
        /// </summary>
        [Input("monitorService")]
        public Input<Inputs.WorkspacesEnhancedServiceMonitorServiceArgs>? MonitorService { get; set; }

        /// <summary>
        /// Activate cloud security services. If this parameter is not specified, cloud security services will be enabled by default.
        /// </summary>
        [Input("securityService")]
        public Input<Inputs.WorkspacesEnhancedServiceSecurityServiceArgs>? SecurityService { get; set; }

        public WorkspacesEnhancedServiceArgs()
        {
        }
        public static new WorkspacesEnhancedServiceArgs Empty => new WorkspacesEnhancedServiceArgs();
    }
}