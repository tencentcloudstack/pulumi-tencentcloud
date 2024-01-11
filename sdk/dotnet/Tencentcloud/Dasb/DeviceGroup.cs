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
    /// Provides a resource to create a dasb device_group
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Tencentcloud.Dasb.DeviceGroup("example", new Tencentcloud.Dasb.DeviceGroupArgs
    ///         {
    ///             DepartmentId = "1.2",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// dasb device_group can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Dasb/deviceGroup:DeviceGroup example 36
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dasb/deviceGroup:DeviceGroup")]
    public partial class DeviceGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the department to which the asset group belongs, such as: 1.2.3 name, with a maximum length of 32 characters.
        /// </summary>
        [Output("departmentId")]
        public Output<string?> DepartmentId { get; private set; } = null!;

        /// <summary>
        /// Device group name, the maximum length is 32 characters.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;


        /// <summary>
        /// Create a DeviceGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeviceGroup(string name, DeviceGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/deviceGroup:DeviceGroup", name, args ?? new DeviceGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeviceGroup(string name, Input<string> id, DeviceGroupState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/deviceGroup:DeviceGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeviceGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeviceGroup Get(string name, Input<string> id, DeviceGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new DeviceGroup(name, id, state, options);
        }
    }

    public sealed class DeviceGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the department to which the asset group belongs, such as: 1.2.3 name, with a maximum length of 32 characters.
        /// </summary>
        [Input("departmentId")]
        public Input<string>? DepartmentId { get; set; }

        /// <summary>
        /// Device group name, the maximum length is 32 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DeviceGroupArgs()
        {
        }
    }

    public sealed class DeviceGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the department to which the asset group belongs, such as: 1.2.3 name, with a maximum length of 32 characters.
        /// </summary>
        [Input("departmentId")]
        public Input<string>? DepartmentId { get; set; }

        /// <summary>
        /// Device group name, the maximum length is 32 characters.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public DeviceGroupState()
        {
        }
    }
}