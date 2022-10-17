// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class GetAccountDbAttachmentsListResult
    {
        /// <summary>
        /// Name of the SQL Server account to be queried.
        /// </summary>
        public readonly string AccountName;
        /// <summary>
        /// Name of the DB to be queried.
        /// </summary>
        public readonly string DbName;
        /// <summary>
        /// SQL Server instance ID that the account belongs to.
        /// </summary>
        public readonly string InstanceId;
        /// <summary>
        /// Privilege of the account on DB. Valid value are `ReadOnly`, `ReadWrite`.
        /// </summary>
        public readonly string Privilege;

        [OutputConstructor]
        private GetAccountDbAttachmentsListResult(
            string accountName,

            string dbName,

            string instanceId,

            string privilege)
        {
            AccountName = accountName;
            DbName = dbName;
            InstanceId = instanceId;
            Privilege = privilege;
        }
    }
}