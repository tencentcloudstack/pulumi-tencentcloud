// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Events.Inputs
{

    public sealed class AuditTrackStorageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Designated to store user ID.
        /// </summary>
        [Input("storageAccountId")]
        public Input<string>? StorageAccountId { get; set; }

        /// <summary>
        /// Designated to store user app ID.
        /// </summary>
        [Input("storageAppId")]
        public Input<string>? StorageAppId { get; set; }

        /// <summary>
        /// Storage name. For COS, the storage name is the custom bucket name, which can contain up to 50 lowercase letters, digits, and hyphens. It cannot contain "-APPID" and cannot start or end with a hyphen. For CLS, the storage name is the log topic ID, which can contain 1-50 characters.
        /// </summary>
        [Input("storageName", required: true)]
        public Input<string> StorageName { get; set; } = null!;

        /// <summary>
        /// Storage directory prefix. The COS log file prefix can only contain 3-40 letters and digits.
        /// </summary>
        [Input("storagePrefix", required: true)]
        public Input<string> StoragePrefix { get; set; } = null!;

        /// <summary>
        /// StorageRegion *string `json:'StorageRegion,omitnil,omitempty' name: 'StorageRegion'`.
        /// </summary>
        [Input("storageRegion", required: true)]
        public Input<string> StorageRegion { get; set; } = null!;

        /// <summary>
        /// Storage type (Valid values: cos, cls).
        /// </summary>
        [Input("storageType", required: true)]
        public Input<string> StorageType { get; set; } = null!;

        public AuditTrackStorageArgs()
        {
        }
        public static new AuditTrackStorageArgs Empty => new AuditTrackStorageArgs();
    }
}