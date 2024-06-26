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

    public sealed class IntegrationTaskNodeNodeInfoGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// User App Id.
        /// </summary>
        [Input("appId")]
        public Input<string>? AppId { get; set; }

        [Input("configs")]
        private InputList<Inputs.IntegrationTaskNodeNodeInfoConfigGetArgs>? _configs;

        /// <summary>
        /// Node configuration information.
        /// </summary>
        public InputList<Inputs.IntegrationTaskNodeNodeInfoConfigGetArgs> Configs
        {
            get => _configs ?? (_configs = new InputList<Inputs.IntegrationTaskNodeNodeInfoConfigGetArgs>());
            set => _configs = value;
        }

        /// <summary>
        /// Create time.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Creator User ID.
        /// </summary>
        [Input("creatorUin")]
        public Input<string>? CreatorUin { get; set; }

        /// <summary>
        /// Datasource ID.
        /// </summary>
        [Input("datasourceId")]
        public Input<string>? DatasourceId { get; set; }

        [Input("extConfigs")]
        private InputList<Inputs.IntegrationTaskNodeNodeInfoExtConfigGetArgs>? _extConfigs;

        /// <summary>
        /// Node extension configuration information.
        /// </summary>
        public InputList<Inputs.IntegrationTaskNodeNodeInfoExtConfigGetArgs> ExtConfigs
        {
            get => _extConfigs ?? (_extConfigs = new InputList<Inputs.IntegrationTaskNodeNodeInfoExtConfigGetArgs>());
            set => _extConfigs = value;
        }

        /// <summary>
        /// Node mapping.
        /// </summary>
        [Input("nodeMapping")]
        public Input<Inputs.IntegrationTaskNodeNodeInfoNodeMappingGetArgs>? NodeMapping { get; set; }

        /// <summary>
        /// Operator User ID.
        /// </summary>
        [Input("operatorUin")]
        public Input<string>? OperatorUin { get; set; }

        /// <summary>
        /// Owner User ID.
        /// </summary>
        [Input("ownerUin")]
        public Input<string>? OwnerUin { get; set; }

        [Input("schemas")]
        private InputList<Inputs.IntegrationTaskNodeNodeInfoSchemaGetArgs>? _schemas;

        /// <summary>
        /// Schema information.
        /// </summary>
        public InputList<Inputs.IntegrationTaskNodeNodeInfoSchemaGetArgs> Schemas
        {
            get => _schemas ?? (_schemas = new InputList<Inputs.IntegrationTaskNodeNodeInfoSchemaGetArgs>());
            set => _schemas = value;
        }

        /// <summary>
        /// Update time.
        /// </summary>
        [Input("updateTime")]
        public Input<string>? UpdateTime { get; set; }

        public IntegrationTaskNodeNodeInfoGetArgs()
        {
        }
        public static new IntegrationTaskNodeNodeInfoGetArgs Empty => new IntegrationTaskNodeNodeInfoGetArgs();
    }
}
