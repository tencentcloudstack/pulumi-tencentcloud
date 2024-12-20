// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Thpc.Inputs
{

    public sealed class WorkspacesLoginSettingsArgs : global::Pulumi.ResourceArgs
    {
        [Input("keyIds")]
        private InputList<string>? _keyIds;

        /// <summary>
        /// The key pair to use for the instance, it looks like `skey-16jig7tx`. Modifying will cause the instance reset.
        /// </summary>
        public InputList<string> KeyIds
        {
            get => _keyIds ?? (_keyIds = new InputList<string>());
            set => _keyIds = value;
        }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for the instance. In order for the new password to take effect, the instance will be restarted after the password change. Modifying will cause the instance reset.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        public WorkspacesLoginSettingsArgs()
        {
        }
        public static new WorkspacesLoginSettingsArgs Empty => new WorkspacesLoginSettingsArgs();
    }
}
