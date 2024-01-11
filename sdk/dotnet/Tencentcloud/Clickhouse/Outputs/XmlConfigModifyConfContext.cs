// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Clickhouse.Outputs
{

    [OutputType]
    public sealed class XmlConfigModifyConfContext
    {
        /// <summary>
        /// Configuration file name.
        /// </summary>
        public readonly string FileName;
        /// <summary>
        /// Path to save configuration file.
        /// </summary>
        public readonly string? FilePath;
        /// <summary>
        /// New content of configuration file, base64 encoded.
        /// </summary>
        public readonly string NewConfValue;

        [OutputConstructor]
        private XmlConfigModifyConfContext(
            string fileName,

            string? filePath,

            string newConfValue)
        {
            FileName = fileName;
            FilePath = filePath;
            NewConfValue = newConfValue;
        }
    }
}