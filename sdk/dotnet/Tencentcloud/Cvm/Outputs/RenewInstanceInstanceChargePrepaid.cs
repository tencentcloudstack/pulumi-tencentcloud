// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Cvm.Outputs
{

    [OutputType]
    public sealed class RenewInstanceInstanceChargePrepaid
    {
        /// <summary>
        /// Subscription period; unit: month; valid values: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36, 48, 60. Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        public readonly int Period;
        /// <summary>
        /// Auto renewal flag. Valid values:
        /// </summary>
        public readonly string? RenewFlag;

        [OutputConstructor]
        private RenewInstanceInstanceChargePrepaid(
            int period,

            string? renewFlag)
        {
            Period = period;
            RenewFlag = renewFlag;
        }
    }
}
