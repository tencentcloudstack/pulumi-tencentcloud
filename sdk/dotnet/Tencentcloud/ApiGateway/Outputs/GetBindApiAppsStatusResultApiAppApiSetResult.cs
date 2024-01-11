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
    public sealed class GetBindApiAppsStatusResultApiAppApiSetResult
    {
        /// <summary>
        /// Application ID.
        /// </summary>
        public readonly string ApiAppId;
        /// <summary>
        /// Application Name.
        /// </summary>
        public readonly string ApiAppName;
        /// <summary>
        /// API ID.
        /// </summary>
        public readonly string ApiId;
        /// <summary>
        /// API name.
        /// </summary>
        public readonly string ApiName;
        /// <summary>
        /// Apis region.
        /// </summary>
        public readonly string ApiRegion;
        /// <summary>
        /// Authorization binding time, expressed in accordance with the ISO8601 standard and using UTC time. The format is: YYYY-MM-DDThh:mm:ssZ.
        /// </summary>
        public readonly string AuthorizedTime;
        /// <summary>
        /// Authorization binding environment.
        /// </summary>
        public readonly string EnvironmentName;
        /// <summary>
        /// Service ID.
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private GetBindApiAppsStatusResultApiAppApiSetResult(
            string apiAppId,

            string apiAppName,

            string apiId,

            string apiName,

            string apiRegion,

            string authorizedTime,

            string environmentName,

            string serviceId)
        {
            ApiAppId = apiAppId;
            ApiAppName = apiAppName;
            ApiId = apiId;
            ApiName = apiName;
            ApiRegion = apiRegion;
            AuthorizedTime = authorizedTime;
            EnvironmentName = environmentName;
            ServiceId = serviceId;
        }
    }
}