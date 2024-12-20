// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class GetClusterCommonNamesListResult
    {
        /// <summary>
        /// The CommonName in the certificate of the client corresponding to the sub-account.
        /// </summary>
        public readonly string CommonName;
        /// <summary>
        /// (**Deprecated**) It has been deprecated from version 1.81.140. Please use `common_name`. The CommonName in the certificate of the client corresponding to the sub-account.
        /// </summary>
        public readonly string CommonNames;
        /// <summary>
        /// User UIN.
        /// </summary>
        public readonly string SubaccountUin;

        [OutputConstructor]
        private GetClusterCommonNamesListResult(
            string commonName,

            string commonNames,

            string subaccountUin)
        {
            CommonName = commonName;
            CommonNames = commonNames;
            SubaccountUin = subaccountUin;
        }
    }
}
