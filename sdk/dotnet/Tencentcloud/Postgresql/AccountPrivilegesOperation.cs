// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Postgresql
{
    /// <summary>
    /// Provides a resource to create postgresql account privileges
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
    ///     var config = new Config();
    ///     var availabilityZone = config.Get("availabilityZone") ?? "ap-guangzhou-3";
    ///     // create vpc
    ///     var vpc = new Tencentcloud.Vpc.Instance("vpc", new()
    ///     {
    ///         CidrBlock = "10.0.0.0/16",
    ///     });
    /// 
    ///     // create vpc subnet
    ///     var subnet = new Tencentcloud.Subnet.Instance("subnet", new()
    ///     {
    ///         AvailabilityZone = availabilityZone,
    ///         VpcId = vpc.Id,
    ///         CidrBlock = "10.0.20.0/28",
    ///         IsMulticast = false,
    ///     });
    /// 
    ///     // create postgresql
    ///     var exampleInstance = new Tencentcloud.Postgresql.Instance("exampleInstance", new()
    ///     {
    ///         AvailabilityZone = availabilityZone,
    ///         ChargeType = "POSTPAID_BY_HOUR",
    ///         VpcId = vpc.Id,
    ///         SubnetId = subnet.Id,
    ///         DbMajorVersion = "10",
    ///         EngineVersion = "10.23",
    ///         RootUser = "root123",
    ///         RootPassword = "Root123$",
    ///         Charset = "UTF8",
    ///         ProjectId = 0,
    ///         Cpu = 1,
    ///         Memory = 2,
    ///         Storage = 10,
    ///         Tags = 
    ///         {
    ///             { "test", "tf" },
    ///         },
    ///     });
    /// 
    ///     // create account
    ///     var exampleAccount = new Tencentcloud.Postgresql.Account("exampleAccount", new()
    ///     {
    ///         DbInstanceId = exampleInstance.Id,
    ///         UserName = "tf_example",
    ///         Password = "Password@123",
    ///         Type = "normal",
    ///         Remark = "remark",
    ///         LockStatus = false,
    ///     });
    /// 
    ///     // create account privileges
    ///     var exampleAccountPrivilegesOperation = new Tencentcloud.Postgresql.AccountPrivilegesOperation("exampleAccountPrivilegesOperation", new()
    ///     {
    ///         DbInstanceId = exampleInstance.Id,
    ///         UserName = exampleAccount.UserName,
    ///         ModifyPrivilegeSets = new[]
    ///         {
    ///             new Tencentcloud.Postgresql.Inputs.AccountPrivilegesOperationModifyPrivilegeSetArgs
    ///             {
    ///                 DatabasePrivilege = new Tencentcloud.Postgresql.Inputs.AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilegeArgs
    ///                 {
    ///                     Object = new Tencentcloud.Postgresql.Inputs.AccountPrivilegesOperationModifyPrivilegeSetDatabasePrivilegeObjectArgs
    ///                     {
    ///                         ObjectName = "postgres",
    ///                         ObjectType = "database",
    ///                     },
    ///                     PrivilegeSets = new[]
    ///                     {
    ///                         "CONNECT",
    ///                         "TEMPORARY",
    ///                         "CREATE",
    ///                     },
    ///                 },
    ///                 ModifyType = "grantObject",
    ///                 IsCascade = false,
    ///             },
    ///         },
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Postgresql/accountPrivilegesOperation:AccountPrivilegesOperation")]
    public partial class AccountPrivilegesOperation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Instance ID in the format of postgres-4wdeb0zv.
        /// </summary>
        [Output("dbInstanceId")]
        public Output<string> DbInstanceId { get; private set; } = null!;

        /// <summary>
        /// Privileges to modify. Batch modification supported, up to 50 entries at a time.
        /// </summary>
        [Output("modifyPrivilegeSets")]
        public Output<ImmutableArray<Outputs.AccountPrivilegesOperationModifyPrivilegeSet>> ModifyPrivilegeSets { get; private set; } = null!;

        /// <summary>
        /// Instance username.
        /// </summary>
        [Output("userName")]
        public Output<string> UserName { get; private set; } = null!;


        /// <summary>
        /// Create a AccountPrivilegesOperation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AccountPrivilegesOperation(string name, AccountPrivilegesOperationArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Postgresql/accountPrivilegesOperation:AccountPrivilegesOperation", name, args ?? new AccountPrivilegesOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AccountPrivilegesOperation(string name, Input<string> id, AccountPrivilegesOperationState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Postgresql/accountPrivilegesOperation:AccountPrivilegesOperation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AccountPrivilegesOperation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AccountPrivilegesOperation Get(string name, Input<string> id, AccountPrivilegesOperationState? state = null, CustomResourceOptions? options = null)
        {
            return new AccountPrivilegesOperation(name, id, state, options);
        }
    }

    public sealed class AccountPrivilegesOperationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of postgres-4wdeb0zv.
        /// </summary>
        [Input("dbInstanceId", required: true)]
        public Input<string> DbInstanceId { get; set; } = null!;

        [Input("modifyPrivilegeSets", required: true)]
        private InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetArgs>? _modifyPrivilegeSets;

        /// <summary>
        /// Privileges to modify. Batch modification supported, up to 50 entries at a time.
        /// </summary>
        public InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetArgs> ModifyPrivilegeSets
        {
            get => _modifyPrivilegeSets ?? (_modifyPrivilegeSets = new InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetArgs>());
            set => _modifyPrivilegeSets = value;
        }

        /// <summary>
        /// Instance username.
        /// </summary>
        [Input("userName", required: true)]
        public Input<string> UserName { get; set; } = null!;

        public AccountPrivilegesOperationArgs()
        {
        }
        public static new AccountPrivilegesOperationArgs Empty => new AccountPrivilegesOperationArgs();
    }

    public sealed class AccountPrivilegesOperationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Instance ID in the format of postgres-4wdeb0zv.
        /// </summary>
        [Input("dbInstanceId")]
        public Input<string>? DbInstanceId { get; set; }

        [Input("modifyPrivilegeSets")]
        private InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetGetArgs>? _modifyPrivilegeSets;

        /// <summary>
        /// Privileges to modify. Batch modification supported, up to 50 entries at a time.
        /// </summary>
        public InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetGetArgs> ModifyPrivilegeSets
        {
            get => _modifyPrivilegeSets ?? (_modifyPrivilegeSets = new InputList<Inputs.AccountPrivilegesOperationModifyPrivilegeSetGetArgs>());
            set => _modifyPrivilegeSets = value;
        }

        /// <summary>
        /// Instance username.
        /// </summary>
        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public AccountPrivilegesOperationState()
        {
        }
        public static new AccountPrivilegesOperationState Empty => new AccountPrivilegesOperationState();
    }
}
