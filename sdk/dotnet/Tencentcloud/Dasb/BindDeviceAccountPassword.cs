// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Dasb
{
    /// <summary>
    /// Provides a resource to create a dasb bind_device_account_password
    /// 
    /// ## Example Usage
    /// 
    /// &lt;!--Start PulumiCodeChooser --&gt;
    /// ```csharp
    /// using System.Collections.Generic;
    /// using System.Linq;
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// return await Deployment.RunAsync(() =&gt; 
    /// {
    ///     var exampleDevice = new Tencentcloud.Dasb.Device("exampleDevice", new()
    ///     {
    ///         OsName = "Linux",
    ///         Ip = "192.168.0.1",
    ///         Port = 80,
    ///     });
    /// 
    ///     var exampleDeviceAccount = new Tencentcloud.Dasb.DeviceAccount("exampleDeviceAccount", new()
    ///     {
    ///         DeviceId = exampleDevice.Id,
    ///         Account = "root",
    ///     });
    /// 
    ///     var exampleBindDeviceAccountPassword = new Tencentcloud.Dasb.BindDeviceAccountPassword("exampleBindDeviceAccountPassword", new()
    ///     {
    ///         DeviceAccountId = exampleDeviceAccount.Id,
    ///         Password = "TerraformPassword",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dasb/bindDeviceAccountPassword:BindDeviceAccountPassword")]
    public partial class BindDeviceAccountPassword : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Host account ID.
        /// </summary>
        [Output("deviceAccountId")]
        public Output<int> DeviceAccountId { get; private set; } = null!;

        /// <summary>
        /// Host account password.
        /// </summary>
        [Output("password")]
        public Output<string> Password { get; private set; } = null!;


        /// <summary>
        /// Create a BindDeviceAccountPassword resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BindDeviceAccountPassword(string name, BindDeviceAccountPasswordArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/bindDeviceAccountPassword:BindDeviceAccountPassword", name, args ?? new BindDeviceAccountPasswordArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BindDeviceAccountPassword(string name, Input<string> id, BindDeviceAccountPasswordState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/bindDeviceAccountPassword:BindDeviceAccountPassword", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing BindDeviceAccountPassword resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BindDeviceAccountPassword Get(string name, Input<string> id, BindDeviceAccountPasswordState? state = null, CustomResourceOptions? options = null)
        {
            return new BindDeviceAccountPassword(name, id, state, options);
        }
    }

    public sealed class BindDeviceAccountPasswordArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host account ID.
        /// </summary>
        [Input("deviceAccountId", required: true)]
        public Input<int> DeviceAccountId { get; set; } = null!;

        /// <summary>
        /// Host account password.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        public BindDeviceAccountPasswordArgs()
        {
        }
        public static new BindDeviceAccountPasswordArgs Empty => new BindDeviceAccountPasswordArgs();
    }

    public sealed class BindDeviceAccountPasswordState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Host account ID.
        /// </summary>
        [Input("deviceAccountId")]
        public Input<int>? DeviceAccountId { get; set; }

        /// <summary>
        /// Host account password.
        /// </summary>
        [Input("password")]
        public Input<string>? Password { get; set; }

        public BindDeviceAccountPasswordState()
        {
        }
        public static new BindDeviceAccountPasswordState Empty => new BindDeviceAccountPasswordState();
    }
}
