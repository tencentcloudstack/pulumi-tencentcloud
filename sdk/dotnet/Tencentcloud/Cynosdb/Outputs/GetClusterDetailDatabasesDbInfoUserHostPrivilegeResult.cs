// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetClusterDetailDatabasesDbInfoUserHostPrivilegeResult
    {
        /// <summary>
        /// Database host.
        /// </summary>
        public readonly string DbHost;
        /// <summary>
        /// User permission note: This field may return null, indicating that a valid value cannot be obtained.
        /// </summary>
        public readonly string DbPrivilege;
        /// <summary>
        /// DbUserName.
        /// </summary>
        public readonly string DbUserName;

        [OutputConstructor]
        private GetClusterDetailDatabasesDbInfoUserHostPrivilegeResult(
            string dbHost,

            string dbPrivilege,

            string dbUserName)
        {
            DbHost = dbHost;
            DbPrivilege = dbPrivilege;
            DbUserName = dbUserName;
        }
    }
}