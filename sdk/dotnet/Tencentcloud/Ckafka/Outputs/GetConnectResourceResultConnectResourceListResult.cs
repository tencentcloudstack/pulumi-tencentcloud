// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class GetConnectResourceResultConnectResourceListResult
    {
        /// <summary>
        /// ClickHouse configuration, returned when Type is CLICKHOUSE.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListClickhouseConnectParamResult> ClickhouseConnectParams;
        /// <summary>
        /// Creation time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// Ctsdb configuration, returned when Type is CTSDB.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListCtsdbConnectParamResult> CtsdbConnectParams;
        /// <summary>
        /// The current step of the connection source.
        /// </summary>
        public readonly string CurrentStep;
        /// <summary>
        /// The number of Datahub tasks associated with this connection source.
        /// </summary>
        public readonly int DatahubTaskCount;
        /// <summary>
        /// Description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Doris Configuration, returned when Type is DORIS.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListDorisConnectParamResult> DorisConnectParams;
        /// <summary>
        /// Dts configuration, returned when Type is DTS.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListDtsConnectParamResult> DtsConnectParams;
        /// <summary>
        /// Error Messages.
        /// </summary>
        public readonly string ErrorMessage;
        /// <summary>
        /// Es configuration, return when Type is ES.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListEsConnectParamResult> EsConnectParams;
        /// <summary>
        /// Kafka configuration, returned when Type is KAFKA.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListKafkaConnectParamResult> KafkaConnectParams;
        /// <summary>
        /// Mariadb configuration, returned when Type is MARIADB.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMariaDbConnectParamResult> MariaDbConnectParams;
        /// <summary>
        /// Mongo DB configuration, returned when Type is MONGODB.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMongoDbConnectParamResult> MongoDbConnectParams;
        /// <summary>
        /// Mysql configuration, returned when Type is MYSQL or TDSQL C MYSQL.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMysqlConnectParamResult> MysqlConnectParams;
        /// <summary>
        /// Postgresql configuration, returned when Type is POSTGRESQL or TDSQL C POSTGRESQL.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListPostgreSqlConnectParamResult> PostgreSqlConnectParams;
        /// <summary>
        /// Resource id.
        /// </summary>
        public readonly string ResourceId;
        /// <summary>
        /// Resource name.
        /// </summary>
        public readonly string ResourceName;
        /// <summary>
        /// SQL Server configuration, returned when Type is SQLSERVER.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListSqlServerConnectParamResult> SqlServerConnectParams;
        /// <summary>
        /// Resource status.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// Step List.
        /// </summary>
        public readonly ImmutableArray<string> StepLists;
        /// <summary>
        /// Creation progress percentage.
        /// </summary>
        public readonly double TaskProgress;
        /// <summary>
        /// connection source type.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetConnectResourceResultConnectResourceListResult(
            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListClickhouseConnectParamResult> clickhouseConnectParams,

            string createTime,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListCtsdbConnectParamResult> ctsdbConnectParams,

            string currentStep,

            int datahubTaskCount,

            string description,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListDorisConnectParamResult> dorisConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListDtsConnectParamResult> dtsConnectParams,

            string errorMessage,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListEsConnectParamResult> esConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListKafkaConnectParamResult> kafkaConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMariaDbConnectParamResult> mariaDbConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMongoDbConnectParamResult> mongoDbConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListMysqlConnectParamResult> mysqlConnectParams,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListPostgreSqlConnectParamResult> postgreSqlConnectParams,

            string resourceId,

            string resourceName,

            ImmutableArray<Outputs.GetConnectResourceResultConnectResourceListSqlServerConnectParamResult> sqlServerConnectParams,

            int status,

            ImmutableArray<string> stepLists,

            double taskProgress,

            string type)
        {
            ClickhouseConnectParams = clickhouseConnectParams;
            CreateTime = createTime;
            CtsdbConnectParams = ctsdbConnectParams;
            CurrentStep = currentStep;
            DatahubTaskCount = datahubTaskCount;
            Description = description;
            DorisConnectParams = dorisConnectParams;
            DtsConnectParams = dtsConnectParams;
            ErrorMessage = errorMessage;
            EsConnectParams = esConnectParams;
            KafkaConnectParams = kafkaConnectParams;
            MariaDbConnectParams = mariaDbConnectParams;
            MongoDbConnectParams = mongoDbConnectParams;
            MysqlConnectParams = mysqlConnectParams;
            PostgreSqlConnectParams = postgreSqlConnectParams;
            ResourceId = resourceId;
            ResourceName = resourceName;
            SqlServerConnectParams = sqlServerConnectParams;
            Status = status;
            StepLists = stepLists;
            TaskProgress = taskProgress;
            Type = type;
        }
    }
}
