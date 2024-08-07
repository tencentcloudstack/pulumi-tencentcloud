// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf.Outputs
{

    [OutputType]
    public sealed class GetAccountInfoAccountLimitNamespaceTriggerResult
    {
        /// <summary>
        /// Number of API Gateway triggers.
        /// </summary>
        public readonly int Apigw;
        /// <summary>
        /// Number of CKafka triggers.
        /// </summary>
        public readonly int Ckafka;
        /// <summary>
        /// Number of CLB triggers.
        /// </summary>
        public readonly int Clb;
        /// <summary>
        /// Number of CLS triggers.
        /// </summary>
        public readonly int Cls;
        /// <summary>
        /// Number of CM triggers.
        /// </summary>
        public readonly int Cm;
        /// <summary>
        /// Number of CMQ triggers.
        /// </summary>
        public readonly int Cmq;
        /// <summary>
        /// Number of COS triggers.
        /// </summary>
        public readonly int Cos;
        /// <summary>
        /// Number of EventBridge triggers Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        public readonly int Eb;
        /// <summary>
        /// Number of MPS triggers.
        /// </summary>
        public readonly int Mps;
        /// <summary>
        /// Number of timer triggers.
        /// </summary>
        public readonly int Timer;
        /// <summary>
        /// Total number of triggers.
        /// </summary>
        public readonly int Total;
        /// <summary>
        /// Number of VOD triggers.
        /// </summary>
        public readonly int Vod;

        [OutputConstructor]
        private GetAccountInfoAccountLimitNamespaceTriggerResult(
            int apigw,

            int ckafka,

            int clb,

            int cls,

            int cm,

            int cmq,

            int cos,

            int eb,

            int mps,

            int timer,

            int total,

            int vod)
        {
            Apigw = apigw;
            Ckafka = ckafka;
            Clb = clb;
            Cls = cls;
            Cm = cm;
            Cmq = cmq;
            Cos = cos;
            Eb = eb;
            Mps = mps;
            Timer = timer;
            Total = total;
            Vod = vod;
        }
    }
}
