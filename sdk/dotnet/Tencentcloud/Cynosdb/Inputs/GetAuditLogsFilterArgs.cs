// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cynosdb.Inputs
{

    public sealed class GetAuditLogsFilterInputArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Affects the number of rows. Indicates that filtering affects audit logs with rows greater than this value.
        /// </summary>
        [Input("affectRows")]
        public Input<int>? AffectRows { get; set; }

        [Input("dbNames")]
        private InputList<string>? _dbNames;

        /// <summary>
        /// Database name.
        /// </summary>
        public InputList<string> DbNames
        {
            get => _dbNames ?? (_dbNames = new InputList<string>());
            set => _dbNames = value;
        }

        /// <summary>
        /// Execution time. Unit: ms. Indicates audit logs with a filter execution time greater than this value.
        /// </summary>
        [Input("execTime")]
        public Input<int>? ExecTime { get; set; }

        [Input("hosts")]
        private InputList<string>? _hosts;

        /// <summary>
        /// Client address.
        /// </summary>
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        [Input("policyNames")]
        private InputList<string>? _policyNames;

        /// <summary>
        /// Audit policy name.
        /// </summary>
        public InputList<string> PolicyNames
        {
            get => _policyNames ?? (_policyNames = new InputList<string>());
            set => _policyNames = value;
        }

        /// <summary>
        /// Returns the number of rows.
        /// </summary>
        [Input("sentRows")]
        public Input<int>? SentRows { get; set; }

        /// <summary>
        /// SQL statement. Supports fuzzy matching.
        /// </summary>
        [Input("sql")]
        public Input<string>? Sql { get; set; }

        /// <summary>
        /// SQL type. Currently supported: SELECT, Insert, UPDATE, DELETE, CREATE, DROP, ALT, SET, REPLACE, EXECUTE.
        /// </summary>
        [Input("sqlType")]
        public Input<string>? SqlType { get; set; }

        [Input("sqlTypes")]
        private InputList<string>? _sqlTypes;

        /// <summary>
        /// SQL type. Supports simultaneous querying of multiple types. Currently supported: SELECT, Insert, UPDATE, DELETE, CREATE, DROP, ALT, SET, REPLACE, EXECUTE.
        /// </summary>
        public InputList<string> SqlTypes
        {
            get => _sqlTypes ?? (_sqlTypes = new InputList<string>());
            set => _sqlTypes = value;
        }

        [Input("sqls")]
        private InputList<string>? _sqls;

        /// <summary>
        /// SQL statement. Supports passing multiple SQL statements.
        /// </summary>
        public InputList<string> Sqls
        {
            get => _sqls ?? (_sqls = new InputList<string>());
            set => _sqls = value;
        }

        [Input("tableNames")]
        private InputList<string>? _tableNames;

        /// <summary>
        /// Table name.
        /// </summary>
        public InputList<string> TableNames
        {
            get => _tableNames ?? (_tableNames = new InputList<string>());
            set => _tableNames = value;
        }

        [Input("threadIds")]
        private InputList<string>? _threadIds;

        /// <summary>
        /// Thread ID.
        /// </summary>
        public InputList<string> ThreadIds
        {
            get => _threadIds ?? (_threadIds = new InputList<string>());
            set => _threadIds = value;
        }

        [Input("users")]
        private InputList<string>? _users;

        /// <summary>
        /// User name.
        /// </summary>
        public InputList<string> Users
        {
            get => _users ?? (_users = new InputList<string>());
            set => _users = value;
        }

        public GetAuditLogsFilterInputArgs()
        {
        }
    }
}