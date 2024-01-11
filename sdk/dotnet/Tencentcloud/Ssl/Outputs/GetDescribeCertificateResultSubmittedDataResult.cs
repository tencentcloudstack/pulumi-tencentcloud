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
    public sealed class GetDescribeCertificateResultSubmittedDataResult
    {
        /// <summary>
        /// Administrator mailbox address.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AdminEmail;
        /// <summary>
        /// Administrator name.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AdminFirstName;
        /// <summary>
        /// The surname of the administrator.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AdminLastName;
        /// <summary>
        /// Administrator phone number.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AdminPhoneNum;
        /// <summary>
        /// Administrator position.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string AdminPosition;
        /// <summary>
        /// Domain information.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string CertificateDomain;
        /// <summary>
        /// Contact mailbox address,Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ContactEmail;
        /// <summary>
        /// Contact name.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ContactFirstName;
        /// <summary>
        /// Contact surname.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ContactLastName;
        /// <summary>
        /// Contact phone number.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ContactNumber;
        /// <summary>
        /// Contact position.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string ContactPosition;
        /// <summary>
        /// CSR content.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string CsrContent;
        /// <summary>
        /// CSR type, (online = online CSR, PARSE = paste CSR).Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string CsrType;
        /// <summary>
        /// DNS information.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly ImmutableArray<string> DomainLists;
        /// <summary>
        /// Private key password.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string KeyPassword;
        /// <summary>
        /// address.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationAddress;
        /// <summary>
        /// city.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationCity;
        /// <summary>
        /// nation.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationCountry;
        /// <summary>
        /// department.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationDivision;
        /// <summary>
        /// Enterprise or unit name.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationName;
        /// <summary>
        /// Province.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string OrganizationRegion;
        /// <summary>
        /// Local region code.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string PhoneAreaCode;
        /// <summary>
        /// Landline number.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string PhoneNumber;
        /// <summary>
        /// Postal code.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string PostalCode;
        /// <summary>
        /// Verification type: DNS_AUTO = Automatic DNS verification, DNS = manual DNS verification, file = file verification, email = email verification.Note: This field may return NULL, indicating that the valid value cannot be obtained.
        /// </summary>
        public readonly string VerifyType;

        [OutputConstructor]
        private GetDescribeCertificateResultSubmittedDataResult(
            string adminEmail,

            string adminFirstName,

            string adminLastName,

            string adminPhoneNum,

            string adminPosition,

            string certificateDomain,

            string contactEmail,

            string contactFirstName,

            string contactLastName,

            string contactNumber,

            string contactPosition,

            string csrContent,

            string csrType,

            ImmutableArray<string> domainLists,

            string keyPassword,

            string organizationAddress,

            string organizationCity,

            string organizationCountry,

            string organizationDivision,

            string organizationName,

            string organizationRegion,

            string phoneAreaCode,

            string phoneNumber,

            string postalCode,

            string verifyType)
        {
            AdminEmail = adminEmail;
            AdminFirstName = adminFirstName;
            AdminLastName = adminLastName;
            AdminPhoneNum = adminPhoneNum;
            AdminPosition = adminPosition;
            CertificateDomain = certificateDomain;
            ContactEmail = contactEmail;
            ContactFirstName = contactFirstName;
            ContactLastName = contactLastName;
            ContactNumber = contactNumber;
            ContactPosition = contactPosition;
            CsrContent = csrContent;
            CsrType = csrType;
            DomainLists = domainLists;
            KeyPassword = keyPassword;
            OrganizationAddress = organizationAddress;
            OrganizationCity = organizationCity;
            OrganizationCountry = organizationCountry;
            OrganizationDivision = organizationDivision;
            OrganizationName = organizationName;
            OrganizationRegion = organizationRegion;
            PhoneAreaCode = phoneAreaCode;
            PhoneNumber = phoneNumber;
            PostalCode = postalCode;
            VerifyType = verifyType;
        }
    }
}