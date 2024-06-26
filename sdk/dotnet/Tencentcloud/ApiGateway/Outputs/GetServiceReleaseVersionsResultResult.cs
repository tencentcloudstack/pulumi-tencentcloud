// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class GetServiceReleaseVersionsResultResult
    {
        /// <summary>
        /// Version description.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string VersionDesc;
        /// <summary>
        /// Version number.Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string VersionName;

        [OutputConstructor]
        private GetServiceReleaseVersionsResultResult(
            string versionDesc,

            string versionName)
        {
            VersionDesc = versionDesc;
            VersionName = versionName;
        }
    }
}
