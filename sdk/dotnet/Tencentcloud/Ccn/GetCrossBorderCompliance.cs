// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Ccn
{
    public static class GetCrossBorderCompliance
    {
        /// <summary>
        /// Use this data source to query detailed information of ccn cross_border_compliance
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var crossBorderCompliance = Output.Create(Tencentcloud.Ccn.GetCrossBorderCompliance.InvokeAsync(new Tencentcloud.Ccn.GetCrossBorderComplianceArgs
        ///         {
        ///             ComplianceId = 10002,
        ///             Email = "test@tencent.com",
        ///             ServiceEndDate = "2021-07-29",
        ///             ServiceProvider = "UNICOM",
        ///             ServiceStartDate = "2020-07-29",
        ///             State = "APPROVED",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetCrossBorderComplianceResult> InvokeAsync(GetCrossBorderComplianceArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetCrossBorderComplianceResult>("tencentcloud:Ccn/getCrossBorderCompliance:getCrossBorderCompliance", args ?? new GetCrossBorderComplianceArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of ccn cross_border_compliance
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var crossBorderCompliance = Output.Create(Tencentcloud.Ccn.GetCrossBorderCompliance.InvokeAsync(new Tencentcloud.Ccn.GetCrossBorderComplianceArgs
        ///         {
        ///             ComplianceId = 10002,
        ///             Email = "test@tencent.com",
        ///             ServiceEndDate = "2021-07-29",
        ///             ServiceProvider = "UNICOM",
        ///             ServiceStartDate = "2020-07-29",
        ///             State = "APPROVED",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetCrossBorderComplianceResult> Invoke(GetCrossBorderComplianceInvokeArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetCrossBorderComplianceResult>("tencentcloud:Ccn/getCrossBorderCompliance:getCrossBorderCompliance", args ?? new GetCrossBorderComplianceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCrossBorderComplianceArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// (Fuzzy query) business license address.
        /// </summary>
        [Input("businessAddress")]
        public string? BusinessAddress { get; set; }

        /// <summary>
        /// (Fuzzy query) Company name.
        /// </summary>
        [Input("company")]
        public string? Company { get; set; }

        /// <summary>
        /// (Exact match) compliance approval form: 'ID'.
        /// </summary>
        [Input("complianceId")]
        public int? ComplianceId { get; set; }

        /// <summary>
        /// (Exact match) email.
        /// </summary>
        [Input("email")]
        public string? Email { get; set; }

        /// <summary>
        /// (Fuzzy query) Issuing authority.
        /// </summary>
        [Input("issuingAuthority")]
        public string? IssuingAuthority { get; set; }

        /// <summary>
        /// (Fuzzy query) legal representative.
        /// </summary>
        [Input("legalPerson")]
        public string? LegalPerson { get; set; }

        /// <summary>
        /// (Fuzzy query) Person in charge.
        /// </summary>
        [Input("manager")]
        public string? Manager { get; set; }

        /// <summary>
        /// (Fuzzy query) ID card address of the person in charge.
        /// </summary>
        [Input("managerAddress")]
        public string? ManagerAddress { get; set; }

        /// <summary>
        /// (Exact query) ID number of the person in charge.
        /// </summary>
        [Input("managerId")]
        public string? ManagerId { get; set; }

        /// <summary>
        /// (Exact match) contact number of the person in charge.
        /// </summary>
        [Input("managerTelephone")]
        public string? ManagerTelephone { get; set; }

        /// <summary>
        /// (Exact match) post code.
        /// </summary>
        [Input("postCode")]
        public int? PostCode { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// (Exact match) service end date, such as: '2020-07-28'.
        /// </summary>
        [Input("serviceEndDate")]
        public string? ServiceEndDate { get; set; }

        /// <summary>
        /// (Exact match) service provider, optional value: 'UNICOM'.
        /// </summary>
        [Input("serviceProvider")]
        public string? ServiceProvider { get; set; }

        /// <summary>
        /// (Exact match) service start date, such as: '2020-07-28'.
        /// </summary>
        [Input("serviceStartDate")]
        public string? ServiceStartDate { get; set; }

        /// <summary>
        /// (Exact match) status. Pending: PENDING, Passed: APPROVED, Denied: DENY.
        /// </summary>
        [Input("state")]
        public string? State { get; set; }

        /// <summary>
        /// (Exact match) Uniform Social Credit Code.
        /// </summary>
        [Input("uniformSocialCreditCode")]
        public string? UniformSocialCreditCode { get; set; }

        public GetCrossBorderComplianceArgs()
        {
        }
    }

    public sealed class GetCrossBorderComplianceInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// (Fuzzy query) business license address.
        /// </summary>
        [Input("businessAddress")]
        public Input<string>? BusinessAddress { get; set; }

        /// <summary>
        /// (Fuzzy query) Company name.
        /// </summary>
        [Input("company")]
        public Input<string>? Company { get; set; }

        /// <summary>
        /// (Exact match) compliance approval form: 'ID'.
        /// </summary>
        [Input("complianceId")]
        public Input<int>? ComplianceId { get; set; }

        /// <summary>
        /// (Exact match) email.
        /// </summary>
        [Input("email")]
        public Input<string>? Email { get; set; }

        /// <summary>
        /// (Fuzzy query) Issuing authority.
        /// </summary>
        [Input("issuingAuthority")]
        public Input<string>? IssuingAuthority { get; set; }

        /// <summary>
        /// (Fuzzy query) legal representative.
        /// </summary>
        [Input("legalPerson")]
        public Input<string>? LegalPerson { get; set; }

        /// <summary>
        /// (Fuzzy query) Person in charge.
        /// </summary>
        [Input("manager")]
        public Input<string>? Manager { get; set; }

        /// <summary>
        /// (Fuzzy query) ID card address of the person in charge.
        /// </summary>
        [Input("managerAddress")]
        public Input<string>? ManagerAddress { get; set; }

        /// <summary>
        /// (Exact query) ID number of the person in charge.
        /// </summary>
        [Input("managerId")]
        public Input<string>? ManagerId { get; set; }

        /// <summary>
        /// (Exact match) contact number of the person in charge.
        /// </summary>
        [Input("managerTelephone")]
        public Input<string>? ManagerTelephone { get; set; }

        /// <summary>
        /// (Exact match) post code.
        /// </summary>
        [Input("postCode")]
        public Input<int>? PostCode { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// (Exact match) service end date, such as: '2020-07-28'.
        /// </summary>
        [Input("serviceEndDate")]
        public Input<string>? ServiceEndDate { get; set; }

        /// <summary>
        /// (Exact match) service provider, optional value: 'UNICOM'.
        /// </summary>
        [Input("serviceProvider")]
        public Input<string>? ServiceProvider { get; set; }

        /// <summary>
        /// (Exact match) service start date, such as: '2020-07-28'.
        /// </summary>
        [Input("serviceStartDate")]
        public Input<string>? ServiceStartDate { get; set; }

        /// <summary>
        /// (Exact match) status. Pending: PENDING, Passed: APPROVED, Denied: DENY.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// (Exact match) Uniform Social Credit Code.
        /// </summary>
        [Input("uniformSocialCreditCode")]
        public Input<string>? UniformSocialCreditCode { get; set; }

        public GetCrossBorderComplianceInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetCrossBorderComplianceResult
    {
        public readonly string? BusinessAddress;
        public readonly string? Company;
        public readonly int? ComplianceId;
        public readonly string? Email;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? IssuingAuthority;
        public readonly string? LegalPerson;
        public readonly string? Manager;
        public readonly string? ManagerAddress;
        public readonly string? ManagerId;
        public readonly string? ManagerTelephone;
        public readonly int? PostCode;
        public readonly string? ResultOutputFile;
        public readonly string? ServiceEndDate;
        public readonly string? ServiceProvider;
        public readonly string? ServiceStartDate;
        public readonly string? State;
        public readonly string? UniformSocialCreditCode;

        [OutputConstructor]
        private GetCrossBorderComplianceResult(
            string? businessAddress,

            string? company,

            int? complianceId,

            string? email,

            string id,

            string? issuingAuthority,

            string? legalPerson,

            string? manager,

            string? managerAddress,

            string? managerId,

            string? managerTelephone,

            int? postCode,

            string? resultOutputFile,

            string? serviceEndDate,

            string? serviceProvider,

            string? serviceStartDate,

            string? state,

            string? uniformSocialCreditCode)
        {
            BusinessAddress = businessAddress;
            Company = company;
            ComplianceId = complianceId;
            Email = email;
            Id = id;
            IssuingAuthority = issuingAuthority;
            LegalPerson = legalPerson;
            Manager = manager;
            ManagerAddress = managerAddress;
            ManagerId = managerId;
            ManagerTelephone = managerTelephone;
            PostCode = postCode;
            ResultOutputFile = resultOutputFile;
            ServiceEndDate = serviceEndDate;
            ServiceProvider = serviceProvider;
            ServiceStartDate = serviceStartDate;
            State = state;
            UniformSocialCreditCode = uniformSocialCreditCode;
        }
    }
}