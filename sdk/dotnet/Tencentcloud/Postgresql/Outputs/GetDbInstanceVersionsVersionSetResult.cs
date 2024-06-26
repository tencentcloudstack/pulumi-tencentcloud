// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class GetDbInstanceVersionsVersionSetResult
    {
        /// <summary>
        /// List of versions to which this database version (`DBKernelVersion`) can be upgraded.
        /// </summary>
        public readonly ImmutableArray<string> AvailableUpgradeTargets;
        /// <summary>
        /// Database engines. Valid values:1. `postgresql` (TencentDB for PostgreSQL)2. `mssql_compatible` (MSSQL compatible-TencentDB for PostgreSQL).
        /// </summary>
        public readonly string DbEngine;
        /// <summary>
        /// Database kernel version, such as v12.4_r1.3.
        /// </summary>
        public readonly string DbKernelVersion;
        /// <summary>
        /// Database major version, such as 12.
        /// </summary>
        public readonly string DbMajorVersion;
        /// <summary>
        /// Database version, such as 12.4.
        /// </summary>
        public readonly string DbVersion;
        /// <summary>
        /// Database version status. Valid values:`AVAILABLE`.`DEPRECATED`.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// List of features supported by the database kernel, such as:TDE: Supports data encryption.
        /// </summary>
        public readonly ImmutableArray<string> SupportedFeatureNames;

        [OutputConstructor]
        private GetDbInstanceVersionsVersionSetResult(
            ImmutableArray<string> availableUpgradeTargets,

            string dbEngine,

            string dbKernelVersion,

            string dbMajorVersion,

            string dbVersion,

            string status,

            ImmutableArray<string> supportedFeatureNames)
        {
            AvailableUpgradeTargets = availableUpgradeTargets;
            DbEngine = dbEngine;
            DbKernelVersion = dbKernelVersion;
            DbMajorVersion = dbMajorVersion;
            DbVersion = dbVersion;
            Status = status;
            SupportedFeatureNames = supportedFeatureNames;
        }
    }
}
