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
    public sealed class AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilege
    {
        /// <summary>
        /// Database object.If ObjectType is database, DatabaseName/SchemaName/TableName can be null.If ObjectType is schema, SchemaName/TableName can be null.If ObjectType is table, TableName can be null.If ObjectType is column, DatabaseName/SchemaName/TableName can&amp;amp;#39;t be null.In all other cases, DatabaseName/SchemaName/TableName can be null. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilegeObject? Object;
        /// <summary>
        /// Privileges the specific account has on database object. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> PrivilegeSets;

        [OutputConstructor]
        private AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilege(
            Outputs.AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilegeObject? @object,

            ImmutableArray<string> privilegeSets)
        {
            Object = @object;
            PrivilegeSets = privilegeSets;
        }
    }
}
