// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class GetXlogsListResult
    {
        /// <summary>
        /// Xlog end time, format `yyyy-MM-dd hh:mm:ss`.
        /// </summary>
        public readonly string EndTime;
        /// <summary>
        /// Xlog external download address.
        /// </summary>
        public readonly string ExternalAddr;
        /// <summary>
        /// Xlog id.
        /// </summary>
        public readonly int Id;
        /// <summary>
        /// Xlog internal download address.
        /// </summary>
        public readonly string InternalAddr;
        /// <summary>
        /// Xlog file size.
        /// </summary>
        public readonly int Size;
        /// <summary>
        /// Xlog start time, format `yyyy-MM-dd hh:mm:ss`, start time cannot before 7 days ago.
        /// </summary>
        public readonly string StartTime;

        [OutputConstructor]
        private GetXlogsListResult(
            string endTime,

            string externalAddr,

            int id,

            string internalAddr,

            int size,

            string startTime)
        {
            EndTime = endTime;
            ExternalAddr = externalAddr;
            Id = id;
            InternalAddr = internalAddr;
            Size = size;
            StartTime = startTime;
        }
    }
}