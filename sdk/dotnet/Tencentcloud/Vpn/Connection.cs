// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Vpn
{
    /// <summary>
    /// Provides a resource to create a VPN connection.
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
    ///     var example = new Tencentcloud.Vpn.Connection("example", new()
    ///     {
    ///         CustomerGatewayId = "cgw-e503id2z",
    ///         EnableHealthCheck = true,
    ///         HealthCheckConfig = new Tencentcloud.Vpn.Inputs.ConnectionHealthCheckConfigArgs
    ///         {
    ///             ProbeInterval = 5000,
    ///             ProbeThreshold = 3,
    ///             ProbeTimeout = 150,
    ///             ProbeType = "NQA",
    ///         },
    ///         HealthCheckLocalIp = "169.254.227.187",
    ///         HealthCheckRemoteIp = "169.254.164.37",
    ///         IkeDhGroupName = "GROUP2",
    ///         IkeExchangeMode = "AGGRESSIVE",
    ///         IkeLocalAddress = "159.75.204.38",
    ///         IkeLocalIdentity = "ADDRESS",
    ///         IkeProtoAuthenAlgorithm = "SHA",
    ///         IkeProtoEncryAlgorithm = "3DES-CBC",
    ///         IkeRemoteAddress = "109.244.60.154",
    ///         IkeRemoteIdentity = "ADDRESS",
    ///         IkeSaLifetimeSeconds = 86400,
    ///         IpsecEncryptAlgorithm = "3DES-CBC",
    ///         IpsecIntegrityAlgorithm = "SHA1",
    ///         IpsecPfsDhGroup = "NULL",
    ///         IpsecSaLifetimeSeconds = 14400,
    ///         IpsecSaLifetimeTraffic = 4096000000,
    ///         NegotiationType = "flowTrigger",
    ///         PreShareKey = "your_pre_share_key",
    ///         RouteType = "StaticRoute",
    ///         SecurityGroupPolicies = new[]
    ///         {
    ///             new Tencentcloud.Vpn.Inputs.ConnectionSecurityGroupPolicyArgs
    ///             {
    ///                 LocalCidrBlock = "172.16.0.0/16",
    ///                 RemoteCidrBlocks = new[]
    ///                 {
    ///                     "2.2.2.0/26",
    ///                 },
    ///             },
    ///         },
    ///         Tags = 
    ///         {
    ///             { "createBy", "Terraform" },
    ///         },
    ///         VpcId = "vpc-6ccw0s5l",
    ///         VpnGatewayId = "vpngw-33p5vnwd",
    ///     });
    /// 
    /// });
    /// ```
    /// &lt;!--End PulumiCodeChooser --&gt;
    /// 
    /// ## Import
    /// 
    /// VPN connection can be imported using the id, e.g.
    /// 
    /// ```sh
    /// $ pulumi import tencentcloud:Vpn/connection:Connection foo vpnx-nadifg3s
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Vpn/connection:Connection")]
    public partial class Connection : global::Pulumi.CustomResource
    {
        /// <summary>
        /// BGP config.
        /// </summary>
        [Output("bgpConfig")]
        public Output<Outputs.ConnectionBgpConfig> BgpConfig { get; private set; } = null!;

        /// <summary>
        /// Create time of the VPN connection.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// ID of the customer gateway.
        /// </summary>
        [Output("customerGatewayId")]
        public Output<string> CustomerGatewayId { get; private set; } = null!;

        /// <summary>
        /// The action after DPD timeout. Valid values: clear (disconnect) and restart (try again). It is valid when DpdEnable is 1.
        /// </summary>
        [Output("dpdAction")]
        public Output<string> DpdAction { get; private set; } = null!;

        /// <summary>
        /// Specifies whether to enable DPD. Valid values: 0 (disable) and 1 (enable).
        /// </summary>
        [Output("dpdEnable")]
        public Output<int> DpdEnable { get; private set; } = null!;

        /// <summary>
        /// DPD timeout period.Valid value ranges: [30~60], Default: 30; unit: second. If the request is not responded within this period, the peer end is considered not exists. This parameter is valid when the value of DpdEnable is 1.
        /// </summary>
        [Output("dpdTimeout")]
        public Output<int> DpdTimeout { get; private set; } = null!;

        /// <summary>
        /// Whether intra-tunnel health checks are supported.
        /// </summary>
        [Output("enableHealthCheck")]
        public Output<bool> EnableHealthCheck { get; private set; } = null!;

        /// <summary>
        /// Encrypt proto of the VPN connection.
        /// </summary>
        [Output("encryptProto")]
        public Output<string> EncryptProto { get; private set; } = null!;

        /// <summary>
        /// VPN channel health check configuration.
        /// </summary>
        [Output("healthCheckConfig")]
        public Output<Outputs.ConnectionHealthCheckConfig> HealthCheckConfig { get; private set; } = null!;

        /// <summary>
        /// Health check the address of this terminal.
        /// </summary>
        [Output("healthCheckLocalIp")]
        public Output<string> HealthCheckLocalIp { get; private set; } = null!;

        /// <summary>
        /// Health check peer address.
        /// </summary>
        [Output("healthCheckRemoteIp")]
        public Output<string> HealthCheckRemoteIp { get; private set; } = null!;

        /// <summary>
        /// DH group name of the IKE operation specification. Valid values: `GROUP1`, `GROUP2`, `GROUP5`, `GROUP14`, `GROUP24`. Default value is `GROUP1`.
        /// </summary>
        [Output("ikeDhGroupName")]
        public Output<string?> IkeDhGroupName { get; private set; } = null!;

        /// <summary>
        /// Exchange mode of the IKE operation specification. Valid values: `AGGRESSIVE`, `MAIN`. Default value is `MAIN`.
        /// </summary>
        [Output("ikeExchangeMode")]
        public Output<string?> IkeExchangeMode { get; private set; } = null!;

        /// <summary>
        /// Local address of IKE operation specification, valid when ike_local_identity is `ADDRESS`, generally the value is `public_ip_address` of the related VPN gateway.
        /// </summary>
        [Output("ikeLocalAddress")]
        public Output<string?> IkeLocalAddress { get; private set; } = null!;

        /// <summary>
        /// Local FQDN name of the IKE operation specification.
        /// </summary>
        [Output("ikeLocalFqdnName")]
        public Output<string> IkeLocalFqdnName { get; private set; } = null!;

        /// <summary>
        /// Local identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Output("ikeLocalIdentity")]
        public Output<string?> IkeLocalIdentity { get; private set; } = null!;

        /// <summary>
        /// Proto authenticate algorithm of the IKE operation specification. Valid values: `MD5`, `SHA`, `SHA-256`. Default Value is `MD5`.
        /// </summary>
        [Output("ikeProtoAuthenAlgorithm")]
        public Output<string?> IkeProtoAuthenAlgorithm { get; private set; } = null!;

        /// <summary>
        /// Proto encrypt algorithm of the IKE operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`,`AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Output("ikeProtoEncryAlgorithm")]
        public Output<string?> IkeProtoEncryAlgorithm { get; private set; } = null!;

        /// <summary>
        /// Remote address of IKE operation specification, valid when ike_remote_identity is `ADDRESS`, generally the value is `public_ip_address` of the related customer gateway.
        /// </summary>
        [Output("ikeRemoteAddress")]
        public Output<string?> IkeRemoteAddress { get; private set; } = null!;

        /// <summary>
        /// Remote FQDN name of the IKE operation specification.
        /// </summary>
        [Output("ikeRemoteFqdnName")]
        public Output<string> IkeRemoteFqdnName { get; private set; } = null!;

        /// <summary>
        /// Remote identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Output("ikeRemoteIdentity")]
        public Output<string?> IkeRemoteIdentity { get; private set; } = null!;

        /// <summary>
        /// SA lifetime of the IKE operation specification, unit is `second`. The value ranges from 60 to 604800. Default value is 86400 seconds.
        /// </summary>
        [Output("ikeSaLifetimeSeconds")]
        public Output<int?> IkeSaLifetimeSeconds { get; private set; } = null!;

        /// <summary>
        /// Version of the IKE operation specification, values: `IKEV1`, `IKEV2`. Default value is `IKEV1`.
        /// </summary>
        [Output("ikeVersion")]
        public Output<string?> IkeVersion { get; private set; } = null!;

        /// <summary>
        /// Encrypt algorithm of the IPSEC operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `NULL`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Output("ipsecEncryptAlgorithm")]
        public Output<string?> IpsecEncryptAlgorithm { get; private set; } = null!;

        /// <summary>
        /// Integrity algorithm of the IPSEC operation specification. Valid values: `SHA1`, `MD5`, `SHA-256`. Default value is `MD5`.
        /// </summary>
        [Output("ipsecIntegrityAlgorithm")]
        public Output<string?> IpsecIntegrityAlgorithm { get; private set; } = null!;

        /// <summary>
        /// PFS DH group. Valid value: `DH-GROUP1`, `DH-GROUP2`, `DH-GROUP5`, `DH-GROUP14`, `DH-GROUP24`, `NULL`. Default value is `NULL`.
        /// </summary>
        [Output("ipsecPfsDhGroup")]
        public Output<string?> IpsecPfsDhGroup { get; private set; } = null!;

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is second. Valid value ranges: [180~604800]. Default value is 3600 seconds.
        /// </summary>
        [Output("ipsecSaLifetimeSeconds")]
        public Output<int?> IpsecSaLifetimeSeconds { get; private set; } = null!;

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is KB. The value should not be less then 2560. Default value is 1843200.
        /// </summary>
        [Output("ipsecSaLifetimeTraffic")]
        public Output<int?> IpsecSaLifetimeTraffic { get; private set; } = null!;

        /// <summary>
        /// Indicate whether is ccn type. Modification of this field only impacts force new logic of `vpc_id`. If `is_ccn_type` is true, modification of `vpc_id` will be ignored.
        /// </summary>
        [Output("isCcnType")]
        public Output<bool> IsCcnType { get; private set; } = null!;

        /// <summary>
        /// Name of the VPN connection. The length of character is limited to 1-60.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The default negotiation type is `active`. Optional values: `active` (active negotiation), `passive` (passive negotiation), `flowTrigger` (traffic negotiation).
        /// </summary>
        [Output("negotiationType")]
        public Output<string> NegotiationType { get; private set; } = null!;

        /// <summary>
        /// Net status of the VPN connection. Valid value: `AVAILABLE`.
        /// </summary>
        [Output("netStatus")]
        public Output<string> NetStatus { get; private set; } = null!;

        /// <summary>
        /// Pre-shared key of the VPN connection.
        /// </summary>
        [Output("preShareKey")]
        public Output<string> PreShareKey { get; private set; } = null!;

        /// <summary>
        /// Route type of the VPN connection. Valid value: `STATIC`, `StaticRoute`, `Policy`, `Bgp`.
        /// </summary>
        [Output("routeType")]
        public Output<string> RouteType { get; private set; } = null!;

        /// <summary>
        /// SPD policy group, for example: {"10.0.0.5/24":["172.123.10.5/16"]}, 10.0.0.5/24 is the vpc intranet segment, and 172.123.10.5/16 is the IDC network segment. Users specify which network segments in the VPC can communicate with which network segments in your IDC.
        /// </summary>
        [Output("securityGroupPolicies")]
        public Output<ImmutableArray<Outputs.ConnectionSecurityGroupPolicy>> SecurityGroupPolicies { get; private set; } = null!;

        /// <summary>
        /// State of the connection. Valid value: `PENDING`, `AVAILABLE`, `DELETING`.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// ID of the VPC. Required if vpn gateway is not in `CCN` type, and doesn't make sense for `CCN` vpn gateway.
        /// </summary>
        [Output("vpcId")]
        public Output<string?> VpcId { get; private set; } = null!;

        /// <summary>
        /// ID of the VPN gateway.
        /// </summary>
        [Output("vpnGatewayId")]
        public Output<string> VpnGatewayId { get; private set; } = null!;

        /// <summary>
        /// Vpn proto of the VPN connection.
        /// </summary>
        [Output("vpnProto")]
        public Output<string> VpnProto { get; private set; } = null!;


        /// <summary>
        /// Create a Connection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Connection(string name, ConnectionArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpn/connection:Connection", name, args ?? new ConnectionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Connection(string name, Input<string> id, ConnectionState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpn/connection:Connection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Connection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Connection Get(string name, Input<string> id, ConnectionState? state = null, CustomResourceOptions? options = null)
        {
            return new Connection(name, id, state, options);
        }
    }

    public sealed class ConnectionArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// BGP config.
        /// </summary>
        [Input("bgpConfig")]
        public Input<Inputs.ConnectionBgpConfigArgs>? BgpConfig { get; set; }

        /// <summary>
        /// ID of the customer gateway.
        /// </summary>
        [Input("customerGatewayId", required: true)]
        public Input<string> CustomerGatewayId { get; set; } = null!;

        /// <summary>
        /// The action after DPD timeout. Valid values: clear (disconnect) and restart (try again). It is valid when DpdEnable is 1.
        /// </summary>
        [Input("dpdAction")]
        public Input<string>? DpdAction { get; set; }

        /// <summary>
        /// Specifies whether to enable DPD. Valid values: 0 (disable) and 1 (enable).
        /// </summary>
        [Input("dpdEnable")]
        public Input<int>? DpdEnable { get; set; }

        /// <summary>
        /// DPD timeout period.Valid value ranges: [30~60], Default: 30; unit: second. If the request is not responded within this period, the peer end is considered not exists. This parameter is valid when the value of DpdEnable is 1.
        /// </summary>
        [Input("dpdTimeout")]
        public Input<int>? DpdTimeout { get; set; }

        /// <summary>
        /// Whether intra-tunnel health checks are supported.
        /// </summary>
        [Input("enableHealthCheck")]
        public Input<bool>? EnableHealthCheck { get; set; }

        /// <summary>
        /// VPN channel health check configuration.
        /// </summary>
        [Input("healthCheckConfig")]
        public Input<Inputs.ConnectionHealthCheckConfigArgs>? HealthCheckConfig { get; set; }

        /// <summary>
        /// Health check the address of this terminal.
        /// </summary>
        [Input("healthCheckLocalIp")]
        public Input<string>? HealthCheckLocalIp { get; set; }

        /// <summary>
        /// Health check peer address.
        /// </summary>
        [Input("healthCheckRemoteIp")]
        public Input<string>? HealthCheckRemoteIp { get; set; }

        /// <summary>
        /// DH group name of the IKE operation specification. Valid values: `GROUP1`, `GROUP2`, `GROUP5`, `GROUP14`, `GROUP24`. Default value is `GROUP1`.
        /// </summary>
        [Input("ikeDhGroupName")]
        public Input<string>? IkeDhGroupName { get; set; }

        /// <summary>
        /// Exchange mode of the IKE operation specification. Valid values: `AGGRESSIVE`, `MAIN`. Default value is `MAIN`.
        /// </summary>
        [Input("ikeExchangeMode")]
        public Input<string>? IkeExchangeMode { get; set; }

        /// <summary>
        /// Local address of IKE operation specification, valid when ike_local_identity is `ADDRESS`, generally the value is `public_ip_address` of the related VPN gateway.
        /// </summary>
        [Input("ikeLocalAddress")]
        public Input<string>? IkeLocalAddress { get; set; }

        /// <summary>
        /// Local FQDN name of the IKE operation specification.
        /// </summary>
        [Input("ikeLocalFqdnName")]
        public Input<string>? IkeLocalFqdnName { get; set; }

        /// <summary>
        /// Local identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Input("ikeLocalIdentity")]
        public Input<string>? IkeLocalIdentity { get; set; }

        /// <summary>
        /// Proto authenticate algorithm of the IKE operation specification. Valid values: `MD5`, `SHA`, `SHA-256`. Default Value is `MD5`.
        /// </summary>
        [Input("ikeProtoAuthenAlgorithm")]
        public Input<string>? IkeProtoAuthenAlgorithm { get; set; }

        /// <summary>
        /// Proto encrypt algorithm of the IKE operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`,`AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Input("ikeProtoEncryAlgorithm")]
        public Input<string>? IkeProtoEncryAlgorithm { get; set; }

        /// <summary>
        /// Remote address of IKE operation specification, valid when ike_remote_identity is `ADDRESS`, generally the value is `public_ip_address` of the related customer gateway.
        /// </summary>
        [Input("ikeRemoteAddress")]
        public Input<string>? IkeRemoteAddress { get; set; }

        /// <summary>
        /// Remote FQDN name of the IKE operation specification.
        /// </summary>
        [Input("ikeRemoteFqdnName")]
        public Input<string>? IkeRemoteFqdnName { get; set; }

        /// <summary>
        /// Remote identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Input("ikeRemoteIdentity")]
        public Input<string>? IkeRemoteIdentity { get; set; }

        /// <summary>
        /// SA lifetime of the IKE operation specification, unit is `second`. The value ranges from 60 to 604800. Default value is 86400 seconds.
        /// </summary>
        [Input("ikeSaLifetimeSeconds")]
        public Input<int>? IkeSaLifetimeSeconds { get; set; }

        /// <summary>
        /// Version of the IKE operation specification, values: `IKEV1`, `IKEV2`. Default value is `IKEV1`.
        /// </summary>
        [Input("ikeVersion")]
        public Input<string>? IkeVersion { get; set; }

        /// <summary>
        /// Encrypt algorithm of the IPSEC operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `NULL`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Input("ipsecEncryptAlgorithm")]
        public Input<string>? IpsecEncryptAlgorithm { get; set; }

        /// <summary>
        /// Integrity algorithm of the IPSEC operation specification. Valid values: `SHA1`, `MD5`, `SHA-256`. Default value is `MD5`.
        /// </summary>
        [Input("ipsecIntegrityAlgorithm")]
        public Input<string>? IpsecIntegrityAlgorithm { get; set; }

        /// <summary>
        /// PFS DH group. Valid value: `DH-GROUP1`, `DH-GROUP2`, `DH-GROUP5`, `DH-GROUP14`, `DH-GROUP24`, `NULL`. Default value is `NULL`.
        /// </summary>
        [Input("ipsecPfsDhGroup")]
        public Input<string>? IpsecPfsDhGroup { get; set; }

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is second. Valid value ranges: [180~604800]. Default value is 3600 seconds.
        /// </summary>
        [Input("ipsecSaLifetimeSeconds")]
        public Input<int>? IpsecSaLifetimeSeconds { get; set; }

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is KB. The value should not be less then 2560. Default value is 1843200.
        /// </summary>
        [Input("ipsecSaLifetimeTraffic")]
        public Input<int>? IpsecSaLifetimeTraffic { get; set; }

        /// <summary>
        /// Name of the VPN connection. The length of character is limited to 1-60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The default negotiation type is `active`. Optional values: `active` (active negotiation), `passive` (passive negotiation), `flowTrigger` (traffic negotiation).
        /// </summary>
        [Input("negotiationType")]
        public Input<string>? NegotiationType { get; set; }

        /// <summary>
        /// Pre-shared key of the VPN connection.
        /// </summary>
        [Input("preShareKey", required: true)]
        public Input<string> PreShareKey { get; set; } = null!;

        /// <summary>
        /// Route type of the VPN connection. Valid value: `STATIC`, `StaticRoute`, `Policy`, `Bgp`.
        /// </summary>
        [Input("routeType")]
        public Input<string>? RouteType { get; set; }

        [Input("securityGroupPolicies")]
        private InputList<Inputs.ConnectionSecurityGroupPolicyArgs>? _securityGroupPolicies;

        /// <summary>
        /// SPD policy group, for example: {"10.0.0.5/24":["172.123.10.5/16"]}, 10.0.0.5/24 is the vpc intranet segment, and 172.123.10.5/16 is the IDC network segment. Users specify which network segments in the VPC can communicate with which network segments in your IDC.
        /// </summary>
        public InputList<Inputs.ConnectionSecurityGroupPolicyArgs> SecurityGroupPolicies
        {
            get => _securityGroupPolicies ?? (_securityGroupPolicies = new InputList<Inputs.ConnectionSecurityGroupPolicyArgs>());
            set => _securityGroupPolicies = value;
        }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the VPC. Required if vpn gateway is not in `CCN` type, and doesn't make sense for `CCN` vpn gateway.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        /// <summary>
        /// ID of the VPN gateway.
        /// </summary>
        [Input("vpnGatewayId", required: true)]
        public Input<string> VpnGatewayId { get; set; } = null!;

        public ConnectionArgs()
        {
        }
        public static new ConnectionArgs Empty => new ConnectionArgs();
    }

    public sealed class ConnectionState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// BGP config.
        /// </summary>
        [Input("bgpConfig")]
        public Input<Inputs.ConnectionBgpConfigGetArgs>? BgpConfig { get; set; }

        /// <summary>
        /// Create time of the VPN connection.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// ID of the customer gateway.
        /// </summary>
        [Input("customerGatewayId")]
        public Input<string>? CustomerGatewayId { get; set; }

        /// <summary>
        /// The action after DPD timeout. Valid values: clear (disconnect) and restart (try again). It is valid when DpdEnable is 1.
        /// </summary>
        [Input("dpdAction")]
        public Input<string>? DpdAction { get; set; }

        /// <summary>
        /// Specifies whether to enable DPD. Valid values: 0 (disable) and 1 (enable).
        /// </summary>
        [Input("dpdEnable")]
        public Input<int>? DpdEnable { get; set; }

        /// <summary>
        /// DPD timeout period.Valid value ranges: [30~60], Default: 30; unit: second. If the request is not responded within this period, the peer end is considered not exists. This parameter is valid when the value of DpdEnable is 1.
        /// </summary>
        [Input("dpdTimeout")]
        public Input<int>? DpdTimeout { get; set; }

        /// <summary>
        /// Whether intra-tunnel health checks are supported.
        /// </summary>
        [Input("enableHealthCheck")]
        public Input<bool>? EnableHealthCheck { get; set; }

        /// <summary>
        /// Encrypt proto of the VPN connection.
        /// </summary>
        [Input("encryptProto")]
        public Input<string>? EncryptProto { get; set; }

        /// <summary>
        /// VPN channel health check configuration.
        /// </summary>
        [Input("healthCheckConfig")]
        public Input<Inputs.ConnectionHealthCheckConfigGetArgs>? HealthCheckConfig { get; set; }

        /// <summary>
        /// Health check the address of this terminal.
        /// </summary>
        [Input("healthCheckLocalIp")]
        public Input<string>? HealthCheckLocalIp { get; set; }

        /// <summary>
        /// Health check peer address.
        /// </summary>
        [Input("healthCheckRemoteIp")]
        public Input<string>? HealthCheckRemoteIp { get; set; }

        /// <summary>
        /// DH group name of the IKE operation specification. Valid values: `GROUP1`, `GROUP2`, `GROUP5`, `GROUP14`, `GROUP24`. Default value is `GROUP1`.
        /// </summary>
        [Input("ikeDhGroupName")]
        public Input<string>? IkeDhGroupName { get; set; }

        /// <summary>
        /// Exchange mode of the IKE operation specification. Valid values: `AGGRESSIVE`, `MAIN`. Default value is `MAIN`.
        /// </summary>
        [Input("ikeExchangeMode")]
        public Input<string>? IkeExchangeMode { get; set; }

        /// <summary>
        /// Local address of IKE operation specification, valid when ike_local_identity is `ADDRESS`, generally the value is `public_ip_address` of the related VPN gateway.
        /// </summary>
        [Input("ikeLocalAddress")]
        public Input<string>? IkeLocalAddress { get; set; }

        /// <summary>
        /// Local FQDN name of the IKE operation specification.
        /// </summary>
        [Input("ikeLocalFqdnName")]
        public Input<string>? IkeLocalFqdnName { get; set; }

        /// <summary>
        /// Local identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Input("ikeLocalIdentity")]
        public Input<string>? IkeLocalIdentity { get; set; }

        /// <summary>
        /// Proto authenticate algorithm of the IKE operation specification. Valid values: `MD5`, `SHA`, `SHA-256`. Default Value is `MD5`.
        /// </summary>
        [Input("ikeProtoAuthenAlgorithm")]
        public Input<string>? IkeProtoAuthenAlgorithm { get; set; }

        /// <summary>
        /// Proto encrypt algorithm of the IKE operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`,`AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Input("ikeProtoEncryAlgorithm")]
        public Input<string>? IkeProtoEncryAlgorithm { get; set; }

        /// <summary>
        /// Remote address of IKE operation specification, valid when ike_remote_identity is `ADDRESS`, generally the value is `public_ip_address` of the related customer gateway.
        /// </summary>
        [Input("ikeRemoteAddress")]
        public Input<string>? IkeRemoteAddress { get; set; }

        /// <summary>
        /// Remote FQDN name of the IKE operation specification.
        /// </summary>
        [Input("ikeRemoteFqdnName")]
        public Input<string>? IkeRemoteFqdnName { get; set; }

        /// <summary>
        /// Remote identity way of IKE operation specification. Valid values: `ADDRESS`, `FQDN`. Default value is `ADDRESS`.
        /// </summary>
        [Input("ikeRemoteIdentity")]
        public Input<string>? IkeRemoteIdentity { get; set; }

        /// <summary>
        /// SA lifetime of the IKE operation specification, unit is `second`. The value ranges from 60 to 604800. Default value is 86400 seconds.
        /// </summary>
        [Input("ikeSaLifetimeSeconds")]
        public Input<int>? IkeSaLifetimeSeconds { get; set; }

        /// <summary>
        /// Version of the IKE operation specification, values: `IKEV1`, `IKEV2`. Default value is `IKEV1`.
        /// </summary>
        [Input("ikeVersion")]
        public Input<string>? IkeVersion { get; set; }

        /// <summary>
        /// Encrypt algorithm of the IPSEC operation specification. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBC-192`, `AES-CBC-256`, `DES-CBC`, `SM4`, `NULL`, `AES128GCM128`, `AES192GCM128`, `AES256GCM128`. Default value is `3DES-CBC`.
        /// </summary>
        [Input("ipsecEncryptAlgorithm")]
        public Input<string>? IpsecEncryptAlgorithm { get; set; }

        /// <summary>
        /// Integrity algorithm of the IPSEC operation specification. Valid values: `SHA1`, `MD5`, `SHA-256`. Default value is `MD5`.
        /// </summary>
        [Input("ipsecIntegrityAlgorithm")]
        public Input<string>? IpsecIntegrityAlgorithm { get; set; }

        /// <summary>
        /// PFS DH group. Valid value: `DH-GROUP1`, `DH-GROUP2`, `DH-GROUP5`, `DH-GROUP14`, `DH-GROUP24`, `NULL`. Default value is `NULL`.
        /// </summary>
        [Input("ipsecPfsDhGroup")]
        public Input<string>? IpsecPfsDhGroup { get; set; }

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is second. Valid value ranges: [180~604800]. Default value is 3600 seconds.
        /// </summary>
        [Input("ipsecSaLifetimeSeconds")]
        public Input<int>? IpsecSaLifetimeSeconds { get; set; }

        /// <summary>
        /// SA lifetime of the IPSEC operation specification, unit is KB. The value should not be less then 2560. Default value is 1843200.
        /// </summary>
        [Input("ipsecSaLifetimeTraffic")]
        public Input<int>? IpsecSaLifetimeTraffic { get; set; }

        /// <summary>
        /// Indicate whether is ccn type. Modification of this field only impacts force new logic of `vpc_id`. If `is_ccn_type` is true, modification of `vpc_id` will be ignored.
        /// </summary>
        [Input("isCcnType")]
        public Input<bool>? IsCcnType { get; set; }

        /// <summary>
        /// Name of the VPN connection. The length of character is limited to 1-60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The default negotiation type is `active`. Optional values: `active` (active negotiation), `passive` (passive negotiation), `flowTrigger` (traffic negotiation).
        /// </summary>
        [Input("negotiationType")]
        public Input<string>? NegotiationType { get; set; }

        /// <summary>
        /// Net status of the VPN connection. Valid value: `AVAILABLE`.
        /// </summary>
        [Input("netStatus")]
        public Input<string>? NetStatus { get; set; }

        /// <summary>
        /// Pre-shared key of the VPN connection.
        /// </summary>
        [Input("preShareKey")]
        public Input<string>? PreShareKey { get; set; }

        /// <summary>
        /// Route type of the VPN connection. Valid value: `STATIC`, `StaticRoute`, `Policy`, `Bgp`.
        /// </summary>
        [Input("routeType")]
        public Input<string>? RouteType { get; set; }

        [Input("securityGroupPolicies")]
        private InputList<Inputs.ConnectionSecurityGroupPolicyGetArgs>? _securityGroupPolicies;

        /// <summary>
        /// SPD policy group, for example: {"10.0.0.5/24":["172.123.10.5/16"]}, 10.0.0.5/24 is the vpc intranet segment, and 172.123.10.5/16 is the IDC network segment. Users specify which network segments in the VPC can communicate with which network segments in your IDC.
        /// </summary>
        public InputList<Inputs.ConnectionSecurityGroupPolicyGetArgs> SecurityGroupPolicies
        {
            get => _securityGroupPolicies ?? (_securityGroupPolicies = new InputList<Inputs.ConnectionSecurityGroupPolicyGetArgs>());
            set => _securityGroupPolicies = value;
        }

        /// <summary>
        /// State of the connection. Valid value: `PENDING`, `AVAILABLE`, `DELETING`.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the VPC. Required if vpn gateway is not in `CCN` type, and doesn't make sense for `CCN` vpn gateway.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        /// <summary>
        /// ID of the VPN gateway.
        /// </summary>
        [Input("vpnGatewayId")]
        public Input<string>? VpnGatewayId { get; set; }

        /// <summary>
        /// Vpn proto of the VPN connection.
        /// </summary>
        [Input("vpnProto")]
        public Input<string>? VpnProto { get; set; }

        public ConnectionState()
        {
        }
        public static new ConnectionState Empty => new ConnectionState();
    }
}
