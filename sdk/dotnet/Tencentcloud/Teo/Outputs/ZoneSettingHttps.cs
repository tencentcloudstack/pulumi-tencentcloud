// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class ZoneSettingHttps
    {
        /// <summary>
        /// HSTS Configuration. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly Outputs.ZoneSettingHttpsHsts? Hsts;
        /// <summary>
        /// HTTP2 configuration switch.- `on`: Enable.- `off`: Disable. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? Http2;
        /// <summary>
        /// OCSP configuration switch.- `on`: Enable.- `off`: Disable.It is disabled by default. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly string? OcspStapling;
        /// <summary>
        /// TLS version settings. Valid values: `TLSv1`, `TLSV1.1`, `TLSV1.2`, and `TLSv1.3`.Only consecutive versions can be enabled at the same time. Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        public readonly ImmutableArray<string> TlsVersions;

        [OutputConstructor]
        private ZoneSettingHttps(
            Outputs.ZoneSettingHttpsHsts? hsts,

            string? http2,

            string? ocspStapling,

            ImmutableArray<string> tlsVersions)
        {
            Hsts = hsts;
            Http2 = http2;
            OcspStapling = ocspStapling;
            TlsVersions = tlsVersions;
        }
    }
}