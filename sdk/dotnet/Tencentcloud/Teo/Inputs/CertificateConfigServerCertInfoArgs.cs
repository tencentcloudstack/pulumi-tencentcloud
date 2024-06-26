// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Inputs
{

    public sealed class CertificateConfigServerCertInfoArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alias of the certificate.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("alias")]
        public Input<string>? Alias { get; set; }

        /// <summary>
        /// ID of the server certificate.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("certId", required: true)]
        public Input<string> CertId { get; set; } = null!;

        /// <summary>
        /// Domain name of the certificate. Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [Input("commonName")]
        public Input<string>? CommonName { get; set; }

        /// <summary>
        /// Time when the certificate is deployed. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("deployTime")]
        public Input<string>? DeployTime { get; set; }

        /// <summary>
        /// Time when the certificate expires. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("expireTime")]
        public Input<string>? ExpireTime { get; set; }

        /// <summary>
        /// Signature algorithm. Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [Input("signAlgo")]
        public Input<string>? SignAlgo { get; set; }

        /// <summary>
        /// Type of the certificate. Values: `default`: Default certificate; `upload`: Specified certificate; `managed`: Tencent Cloud-managed certificate. Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public CertificateConfigServerCertInfoArgs()
        {
        }
        public static new CertificateConfigServerCertInfoArgs Empty => new CertificateConfigServerCertInfoArgs();
    }
}
