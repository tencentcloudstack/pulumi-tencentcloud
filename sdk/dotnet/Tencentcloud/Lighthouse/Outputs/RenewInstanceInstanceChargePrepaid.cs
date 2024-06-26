// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Lighthouse.Outputs
{

    [OutputType]
    public sealed class RenewInstanceInstanceChargePrepaid
    {
        /// <summary>
        /// The duration of purchasing an instance. Unit is month. Valid values are (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 24, 36, 48, 60).
        /// </summary>
        public readonly int Period;
        /// <summary>
        /// Automatic renewal logo. Values:
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
