// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mysql.Inputs
{

    public sealed class RollbackTableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Database name.
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        [Input("tables", required: true)]
        private InputList<Inputs.RollbackTableTableArgs>? _tables;

        /// <summary>
        /// Database table details.
        /// </summary>
        public InputList<Inputs.RollbackTableTableArgs> Tables
        {
            get => _tables ?? (_tables = new InputList<Inputs.RollbackTableTableArgs>());
            set => _tables = value;
        }

        public RollbackTableArgs()
        {
        }
    }
}