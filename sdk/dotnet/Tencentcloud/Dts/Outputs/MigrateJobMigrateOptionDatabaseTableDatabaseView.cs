// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class MigrateJobMigrateOptionDatabaseTableDatabaseView
    {
        /// <summary>
        /// NewViewName.
        /// </summary>
        public readonly string? NewViewName;
        /// <summary>
        /// ViewName.
        /// </summary>
        public readonly string? ViewName;

        [OutputConstructor]
        private MigrateJobMigrateOptionDatabaseTableDatabaseView(
            string? newViewName,

            string? viewName)
        {
            NewViewName = newViewName;
            ViewName = viewName;
        }
    }
}
