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
    public sealed class GetDatahubTaskTaskListTargetResourceClickHouseParamResult
    {
        /// <summary>
        /// ClickHouse cluster.
        /// </summary>
        public readonly string Cluster;
        /// <summary>
        /// SQLServer database name.
        /// </summary>
        public readonly string Database;
        /// <summary>
        /// When the member parameter Drop Invalid Message To Cls is set to true, the Drop Invalid Message parameter is invalid.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceClickHouseParamDropClResult> DropCls;
        /// <summary>
        /// Whether to discard messages that fail to parse, the default is true.
        /// </summary>
        public readonly bool DropInvalidMessage;
        /// <summary>
        /// Mongo DB connection ip.
        /// </summary>
        public readonly string Ip;
        /// <summary>
        /// MongoDB database password.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// MongoDB connection port.
        /// </summary>
        public readonly int Port;
        /// <summary>
        /// Resource.
        /// </summary>
        public readonly string Resource;
        /// <summary>
        /// ClickHouse schema.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceClickHouseParamSchemaResult> Schemas;
        /// <summary>
        /// Whether it is a self-built cluster.
        /// </summary>
        public readonly bool SelfBuilt;
        /// <summary>
        /// instance vip.
        /// </summary>
        public readonly string ServiceVip;
        /// <summary>
        /// SQLServer table, is the non-system table in all the monitored databases, you can use, to monitor multiple data tables, but the data table needs to be filled in the format of data database name.data table name.
        /// </summary>
        public readonly string Table;
        /// <summary>
        /// Resource Type.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// instance vpc id.
        /// </summary>
        public readonly string UniqVpcId;
        /// <summary>
        /// MongoDB database user name.
        /// </summary>
        public readonly string UserName;

        [OutputConstructor]
        private GetDatahubTaskTaskListTargetResourceClickHouseParamResult(
            string cluster,

            string database,

            ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceClickHouseParamDropClResult> dropCls,

            bool dropInvalidMessage,

            string ip,

            string password,

            int port,

            string resource,

            ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceClickHouseParamSchemaResult> schemas,

            bool selfBuilt,

            string serviceVip,

            string table,

            string type,

            string uniqVpcId,

            string userName)
        {
            Cluster = cluster;
            Database = database;
            DropCls = dropCls;
            DropInvalidMessage = dropInvalidMessage;
            Ip = ip;
            Password = password;
            Port = port;
            Resource = resource;
            Schemas = schemas;
            SelfBuilt = selfBuilt;
            ServiceVip = serviceVip;
            Table = table;
            Type = type;
            UniqVpcId = uniqVpcId;
            UserName = userName;
        }
    }
}
