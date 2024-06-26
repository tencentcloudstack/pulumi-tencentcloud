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
    public sealed class IntegrationRealtimeTaskTaskInfoNode
    {
        /// <summary>
        /// User App Id.
        /// </summary>
        public readonly string? AppId;
        /// <summary>
        /// Node configuration information.
        /// </summary>
        public readonly ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeConfig> Configs;
        /// <summary>
        /// Create time.
        /// </summary>
        public readonly string? CreateTime;
        /// <summary>
        /// Creator User ID.
        /// </summary>
        public readonly string? CreatorUin;
        /// <summary>
        /// Data source type: MYSQL, POSTGRE, ORACLE, SQLSERVER, FTP, HIVE, HDFS, ICEBERG, KAFKA, HBASE, SPARK, TBASE, DB2, DM, GAUSSDB, GBASE, IMPALA, ES, S3_DATAINSIGHT, GREENPLUM, PHOENIX, SAP_HANA, SFTP, OCEANBASE, CLICKHOUSE, KUDU, VERTICA, REDIS, COS, DLC, DORIS, CKAFKA, DTS_KAFKA, S3, CDW, TDSQLC, TDSQL, MONGODB, SYBASE, REST_API, StarRocks, TCHOUSE_X.
        /// </summary>
        public readonly string? DataSourceType;
        /// <summary>
        /// Datasource ID.
        /// </summary>
        public readonly string? DatasourceId;
        /// <summary>
        /// Node Description.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Node extension configuration information.
        /// </summary>
        public readonly ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeExtConfig> ExtConfigs;
        /// <summary>
        /// Node ID.
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Node Name.
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// Node mapping.
        /// </summary>
        public readonly Outputs.IntegrationRealtimeTaskTaskInfoNodeNodeMapping? NodeMapping;
        /// <summary>
        /// Node type: INPUT,OUTPUT,JOIN,FILTER,TRANSFORM.
        /// </summary>
        public readonly string? NodeType;
        /// <summary>
        /// Operator User ID.
        /// </summary>
        public readonly string? OperatorUin;
        /// <summary>
        /// Owner User ID.
        /// </summary>
        public readonly string? OwnerUin;
        /// <summary>
        /// Project ID.
        /// </summary>
        public readonly string? ProjectId;
        /// <summary>
        /// Schema information.
        /// </summary>
        public readonly ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeSchema> Schemas;
        /// <summary>
        /// The task id to which the node belongs.
        /// </summary>
        public readonly string? TaskId;
        /// <summary>
        /// Update time.
        /// </summary>
        public readonly string? UpdateTime;

        [OutputConstructor]
        private IntegrationRealtimeTaskTaskInfoNode(
            string? appId,

            ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeConfig> configs,

            string? createTime,

            string? creatorUin,

            string? dataSourceType,

            string? datasourceId,

            string? description,

            ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeExtConfig> extConfigs,

            string? id,

            string? name,

            Outputs.IntegrationRealtimeTaskTaskInfoNodeNodeMapping? nodeMapping,

            string? nodeType,

            string? operatorUin,

            string? ownerUin,

            string? projectId,

            ImmutableArray<Outputs.IntegrationRealtimeTaskTaskInfoNodeSchema> schemas,

            string? taskId,

            string? updateTime)
        {
            AppId = appId;
            Configs = configs;
            CreateTime = createTime;
            CreatorUin = creatorUin;
            DataSourceType = dataSourceType;
            DatasourceId = datasourceId;
            Description = description;
            ExtConfigs = extConfigs;
            Id = id;
            Name = name;
            NodeMapping = nodeMapping;
            NodeType = nodeType;
            OperatorUin = operatorUin;
            OwnerUin = ownerUin;
            ProjectId = projectId;
            Schemas = schemas;
            TaskId = taskId;
            UpdateTime = updateTime;
        }
    }
}
