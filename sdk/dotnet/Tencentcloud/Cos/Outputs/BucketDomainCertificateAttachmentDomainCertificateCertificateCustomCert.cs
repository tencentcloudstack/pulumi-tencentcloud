// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class BucketDomainCertificateAttachmentDomainCertificateCertificateCustomCert
    {
        /// <summary>
        /// Public key of certificate.
        /// </summary>
        public readonly string Cert;
        /// <summary>
        /// Private key of certificate.
        /// </summary>
        public readonly string PrivateKey;

        [OutputConstructor]
        private BucketDomainCertificateAttachmentDomainCertificateCertificateCustomCert(
            string cert,

            string privateKey)
        {
            Cert = cert;
            PrivateKey = privateKey;
        }
    }
}
