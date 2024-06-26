// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cam.Outputs
{

    [OutputType]
    public sealed class GetPolicyGrantingServiceAccessListActionResult
    {
        /// <summary>
        /// Action description.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// Action name.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetPolicyGrantingServiceAccessListActionResult(
            string description,

            string name)
        {
            Description = description;
            Name = name;
        }
    }
}
