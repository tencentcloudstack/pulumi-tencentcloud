// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Events.Inputs
{

    public sealed class AuditTrackFiltersArgs : global::Pulumi.ResourceArgs
    {
        [Input("resourceFields")]
        private InputList<Inputs.AuditTrackFiltersResourceFieldArgs>? _resourceFields;

        /// <summary>
        /// Resource filtering conditions.
        /// </summary>
        public InputList<Inputs.AuditTrackFiltersResourceFieldArgs> ResourceFields
        {
            get => _resourceFields ?? (_resourceFields = new InputList<Inputs.AuditTrackFiltersResourceFieldArgs>());
            set => _resourceFields = value;
        }

        public AuditTrackFiltersArgs()
        {
        }
        public static new AuditTrackFiltersArgs Empty => new AuditTrackFiltersArgs();
    }
}
