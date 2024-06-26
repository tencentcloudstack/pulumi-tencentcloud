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
    public sealed class GetDataSourceListOrderFieldResult
    {
        /// <summary>
        /// OrderFields rule.
        /// </summary>
        public readonly string Direction;
        /// <summary>
        /// OrderFields name.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetDataSourceListOrderFieldResult(
            string direction,

            string name)
        {
            Direction = direction;
            Name = name;
        }
    }
}
