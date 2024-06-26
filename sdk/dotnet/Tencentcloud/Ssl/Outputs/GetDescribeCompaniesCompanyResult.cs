// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ssl.Outputs
{

    [OutputType]
    public sealed class GetDescribeCompaniesCompanyResult
    {
        /// <summary>
        /// Detailed address where the company is located.
        /// </summary>
        public readonly string CompanyAddress;
        /// <summary>
        /// The city where the company is.
        /// </summary>
        public readonly string CompanyCity;
        /// <summary>
        /// Company country.
        /// </summary>
        public readonly string CompanyCountry;
        /// <summary>
        /// Company ID.
        /// </summary>
        public readonly int CompanyId;
        /// <summary>
        /// Company Name.
        /// </summary>
        public readonly string CompanyName;
        /// <summary>
        /// company phone.
        /// </summary>
        public readonly string CompanyPhone;
        /// <summary>
        /// Province where the company is located.
        /// </summary>
        public readonly string CompanyProvince;
        /// <summary>
        /// ID numberNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string IdNumber;
        /// <summary>
        /// typeNote: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string IdType;

        [OutputConstructor]
        private GetDescribeCompaniesCompanyResult(
            string companyAddress,

            string companyCity,

            string companyCountry,

            int companyId,

            string companyName,

            string companyPhone,

            string companyProvince,

            string idNumber,

            string idType)
        {
            CompanyAddress = companyAddress;
            CompanyCity = companyCity;
            CompanyCountry = companyCountry;
            CompanyId = companyId;
            CompanyName = companyName;
            CompanyPhone = companyPhone;
            CompanyProvince = companyProvince;
            IdNumber = idNumber;
            IdType = idType;
        }
    }
}
