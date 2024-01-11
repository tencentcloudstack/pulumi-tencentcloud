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
    /// Provides a resource to create a dasb device_group_members
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
    ///         var example = new Tencentcloud.Dasb.DeviceGroupMembers("example", new Tencentcloud.Dasb.DeviceGroupMembersArgs
    ///         {
    ///             DeviceGroupId = 3,
    ///             MemberIdSets = 
    ///             {
    ///                 1,
    ///                 2,
    ///                 3,
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// dasb device_group_members can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Dasb/deviceGroupMembers:DeviceGroupMembers example 3#1,2,3
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Dasb/deviceGroupMembers:DeviceGroupMembers")]
    public partial class DeviceGroupMembers : Pulumi.CustomResource
    {
        /// <summary>
        /// Device Group ID.
        /// </summary>
        [Output("deviceGroupId")]
        public Output<int> DeviceGroupId { get; private set; } = null!;

        /// <summary>
        /// A collection of device IDs that need to be added to the device group.
        /// </summary>
        [Output("memberIdSets")]
        public Output<ImmutableArray<int>> MemberIdSets { get; private set; } = null!;


        /// <summary>
        /// Create a DeviceGroupMembers resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeviceGroupMembers(string name, DeviceGroupMembersArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/deviceGroupMembers:DeviceGroupMembers", name, args ?? new DeviceGroupMembersArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeviceGroupMembers(string name, Input<string> id, DeviceGroupMembersState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dasb/deviceGroupMembers:DeviceGroupMembers", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeviceGroupMembers resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeviceGroupMembers Get(string name, Input<string> id, DeviceGroupMembersState? state = null, CustomResourceOptions? options = null)
        {
            return new DeviceGroupMembers(name, id, state, options);
        }
    }

    public sealed class DeviceGroupMembersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Device Group ID.
        /// </summary>
        [Input("deviceGroupId", required: true)]
        public Input<int> DeviceGroupId { get; set; } = null!;

        [Input("memberIdSets", required: true)]
        private InputList<int>? _memberIdSets;

        /// <summary>
        /// A collection of device IDs that need to be added to the device group.
        /// </summary>
        public InputList<int> MemberIdSets
        {
            get => _memberIdSets ?? (_memberIdSets = new InputList<int>());
            set => _memberIdSets = value;
        }

        public DeviceGroupMembersArgs()
        {
        }
    }

    public sealed class DeviceGroupMembersState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Device Group ID.
        /// </summary>
        [Input("deviceGroupId")]
        public Input<int>? DeviceGroupId { get; set; }

        [Input("memberIdSets")]
        private InputList<int>? _memberIdSets;

        /// <summary>
        /// A collection of device IDs that need to be added to the device group.
        /// </summary>
        public InputList<int> MemberIdSets
        {
            get => _memberIdSets ?? (_memberIdSets = new InputList<int>());
            set => _memberIdSets = value;
        }

        public DeviceGroupMembersState()
        {
        }
    }
}