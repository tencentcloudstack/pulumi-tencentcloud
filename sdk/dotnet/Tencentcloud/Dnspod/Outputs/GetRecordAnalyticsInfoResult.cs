// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dnspod.Outputs
{

    [OutputType]
    public sealed class GetRecordAnalyticsInfoResult
    {
        /// <summary>
        /// DATE: Statistics by day dimension, HOUR: Statistics by hour dimension.
        /// </summary>
        public readonly string DnsFormat;
        /// <summary>
        /// Total resolution count for the current statistical period.
        /// </summary>
        public readonly int DnsTotal;
        /// <summary>
        /// The domain to query for resolution volume.
        /// </summary>
        public readonly string Domain;
        /// <summary>
        /// The end date of the query, format: YYYY-MM-DD.
        /// </summary>
        public readonly string EndDate;
        /// <summary>
        /// The start date of the query, format: YYYY-MM-DD.
        /// </summary>
        public readonly string StartDate;
        /// <summary>
        /// The subdomain to query for resolution volume.
        /// </summary>
        public readonly string Subdomain;

        [OutputConstructor]
        private GetRecordAnalyticsInfoResult(
            string dnsFormat,

            int dnsTotal,

            string domain,

            string endDate,

            string startDate,

            string subdomain)
        {
            DnsFormat = dnsFormat;
            DnsTotal = dnsTotal;
            Domain = domain;
            EndDate = endDate;
            StartDate = startDate;
            Subdomain = subdomain;
        }
    }
}