// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata.Outputs
{

    [OutputType]
    public sealed class IntegrationRealtimeTaskTaskInfoNodeNodeMappingSourceSchema
    {
        /// <summary>
        /// Schema alias.
        /// </summary>
        public readonly string? Alias;
        /// <summary>
        /// Schema comment.
        /// </summary>
        public readonly string? Comment;
        /// <summary>
        /// Schema ID.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Schema name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Schema extended attributes.
        /// </summary>
        public readonly ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeNodeMappingSourceSchemaProperty> Properties;
        /// <summary>
        /// Schema type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Schema value.
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private IntegrationRealtimeTaskTaskInfoNodeNodeMappingSourceSchema(
            string? alias,

            string? comment,

            string id,

            string name,

            ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeNodeMappingSourceSchemaProperty> properties,

            string type,

            string? value)
        {
            Alias = alias;
            Comment = comment;
            Id = id;
            Name = name;
            Properties = properties;
            Type = type;
            Value = value;
        }
    }
}
