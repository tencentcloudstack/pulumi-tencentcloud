// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class ImportOpenApiRequestParameter
    {
        /// <summary>
        /// The default value for the backend service parameters of the API. This parameter is only used when ServiceType is HTTP.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string? DefaultValue;
        /// <summary>
        /// Parameter description.
        /// </summary>
        public readonly string? Desc;
        /// <summary>
        /// The backend service parameter name of the API. This parameter is only used when ServiceType is HTTP. The front and rear parameter names can be different.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// The backend service parameter location of the API, such as head. This parameter is only used when ServiceType is HTTP. The parameter positions at the front and rear ends can be configured differently.Note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string? Position;
        /// <summary>
        /// If this parameter required. Default value: `false`.
        /// </summary>
        public readonly bool? Required;
        /// <summary>
        /// Parameter type.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private ImportOpenApiRequestParameter(
            string? defaultValue,

            string? desc,

            string? name,

            string? position,

            bool? required,

            string? type)
        {
            DefaultValue = defaultValue;
            Desc = desc;
            Name = name;
            Position = position;
            Required = required;
            Type = type;
        }
    }
}
