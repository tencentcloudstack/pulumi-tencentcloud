// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Inputs
{

    public sealed class IntegrationOfflineTaskTaskInfoMappingSourceSchemaPropertyArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Attributes name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Attributes value.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public IntegrationOfflineTaskTaskInfoMappingSourceSchemaPropertyArgs()
        {
        }
        public static new IntegrationOfflineTaskTaskInfoMappingSourceSchemaPropertyArgs Empty => new IntegrationOfflineTaskTaskInfoMappingSourceSchemaPropertyArgs();
    }
}
