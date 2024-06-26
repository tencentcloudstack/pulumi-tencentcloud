// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this resource to create dayu DDoS policy case
 *
 * > **NOTE:** when a dayu DDoS policy case is created, there will be a dayu DDoS policy created with the same prefix name in the same time. This resource only supports Anti-DDoS of type `bgp`, `bgp-multip` and `bgpip`. One Anti-DDoS resource can only has one DDoS policy case resource. When there is only one Anti-DDoS resource and one policy case, those two resource will be bind automatically.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const foo = new tencentcloud.dayu.DdosPolicyCase("foo", {
 *     appProtocols: [
 *         "tcp",
 *         "udp",
 *     ],
 *     appType: "WEB",
 *     hasAbroad: "yes",
 *     hasInitiateTcp: "yes",
 *     hasInitiateUdp: "yes",
 *     hasVpn: "yes",
 *     maxTcpPackageLen: "1200",
 *     maxUdpPackageLen: "1200",
 *     minTcpPackageLen: "1000",
 *     minUdpPackageLen: "1000",
 *     peerTcpPort: "1111",
 *     peerUdpPort: "3333",
 *     platformTypes: [
 *         "PC",
 *         "MOBILE",
 *     ],
 *     resourceType: "bgpip",
 *     tcpEndPort: "2000",
 *     tcpFootprint: "511",
 *     tcpStartPort: "1000",
 *     udpEndPort: "4000",
 *     udpFootprint: "500",
 *     udpStartPort: "3000",
 *     webApiUrls: [
 *         "abc.com",
 *         "test.cn/aaa.png",
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class DdosPolicyCase extends pulumi.CustomResource {
    /**
     * Get an existing DdosPolicyCase resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DdosPolicyCaseState, opts?: pulumi.CustomResourceOptions): DdosPolicyCase {
        return new DdosPolicyCase(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dayu/ddosPolicyCase:DdosPolicyCase';

    /**
     * Returns true if the given object is an instance of DdosPolicyCase.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DdosPolicyCase {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DdosPolicyCase.__pulumiType;
    }

    /**
     * App protocol set of the DDoS policy case.
     */
    public readonly appProtocols!: pulumi.Output<string[]>;
    /**
     * App type of the DDoS policy case. Valid values: `WEB`, `GAME`, `APP` and `OTHER`.
     */
    public readonly appType!: pulumi.Output<string>;
    /**
     * Create time of the DDoS policy case.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Indicate whether the service involves overseas or not. Valid values: `no` and `yes`.
     */
    public readonly hasAbroad!: pulumi.Output<string>;
    /**
     * Indicate whether the service actively initiates TCP requests or not. Valid values: `no` and `yes`.
     */
    public readonly hasInitiateTcp!: pulumi.Output<string>;
    /**
     * Indicate whether the actively initiate UDP requests or not. Valid values: `no` and `yes`.
     */
    public readonly hasInitiateUdp!: pulumi.Output<string | undefined>;
    /**
     * Indicate whether the service involves VPN service or not. Valid values: `no` and `yes`.
     */
    public readonly hasVpn!: pulumi.Output<string | undefined>;
    /**
     * The max length of TCP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minTcpPackageLen`.
     */
    public readonly maxTcpPackageLen!: pulumi.Output<string | undefined>;
    /**
     * The max length of UDP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minUdpPackageLen`.
     */
    public readonly maxUdpPackageLen!: pulumi.Output<string | undefined>;
    /**
     * The minimum length of TCP message package, valid value length should be greater than 0 and less than 1500.
     */
    public readonly minTcpPackageLen!: pulumi.Output<string | undefined>;
    /**
     * The minimum length of UDP message package, valid value length should be greater than 0 and less than 1500.
     */
    public readonly minUdpPackageLen!: pulumi.Output<string | undefined>;
    /**
     * Name of the DDoS policy case. Length should between 1 and 64.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The port that actively initiates TCP requests. Valid value ranges: (1~65535).
     */
    public readonly peerTcpPort!: pulumi.Output<string | undefined>;
    /**
     * The port that actively initiates UDP requests. Valid value ranges: (1~65535).
     */
    public readonly peerUdpPort!: pulumi.Output<string | undefined>;
    /**
     * Platform set of the DDoS policy case.
     */
    public readonly platformTypes!: pulumi.Output<string[]>;
    /**
     * Type of the resource that the DDoS policy case works for. Valid values: `bgpip`, `bgp` and `bgp-multip`.
     */
    public readonly resourceType!: pulumi.Output<string>;
    /**
     * ID of the DDoS policy case.
     */
    public /*out*/ readonly sceneId!: pulumi.Output<string>;
    /**
     * End port of the TCP service. Valid value ranges: (0~65535). It must be greater than `tcpStartPort`.
     */
    public readonly tcpEndPort!: pulumi.Output<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    public readonly tcpFootprint!: pulumi.Output<string | undefined>;
    /**
     * Start port of the TCP service. Valid value ranges: (0~65535).
     */
    public readonly tcpStartPort!: pulumi.Output<string>;
    /**
     * End port of the UDP service. Valid value ranges: (0~65535). It must be greater than `udpStartPort`.
     */
    public readonly udpEndPort!: pulumi.Output<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    public readonly udpFootprint!: pulumi.Output<string | undefined>;
    /**
     * Start port of the UDP service. Valid value ranges: (0~65535).
     */
    public readonly udpStartPort!: pulumi.Output<string>;
    /**
     * Web API url set.
     */
    public readonly webApiUrls!: pulumi.Output<string[]>;

    /**
     * Create a DdosPolicyCase resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DdosPolicyCaseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DdosPolicyCaseArgs | DdosPolicyCaseState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DdosPolicyCaseState | undefined;
            resourceInputs["appProtocols"] = state ? state.appProtocols : undefined;
            resourceInputs["appType"] = state ? state.appType : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["hasAbroad"] = state ? state.hasAbroad : undefined;
            resourceInputs["hasInitiateTcp"] = state ? state.hasInitiateTcp : undefined;
            resourceInputs["hasInitiateUdp"] = state ? state.hasInitiateUdp : undefined;
            resourceInputs["hasVpn"] = state ? state.hasVpn : undefined;
            resourceInputs["maxTcpPackageLen"] = state ? state.maxTcpPackageLen : undefined;
            resourceInputs["maxUdpPackageLen"] = state ? state.maxUdpPackageLen : undefined;
            resourceInputs["minTcpPackageLen"] = state ? state.minTcpPackageLen : undefined;
            resourceInputs["minUdpPackageLen"] = state ? state.minUdpPackageLen : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["peerTcpPort"] = state ? state.peerTcpPort : undefined;
            resourceInputs["peerUdpPort"] = state ? state.peerUdpPort : undefined;
            resourceInputs["platformTypes"] = state ? state.platformTypes : undefined;
            resourceInputs["resourceType"] = state ? state.resourceType : undefined;
            resourceInputs["sceneId"] = state ? state.sceneId : undefined;
            resourceInputs["tcpEndPort"] = state ? state.tcpEndPort : undefined;
            resourceInputs["tcpFootprint"] = state ? state.tcpFootprint : undefined;
            resourceInputs["tcpStartPort"] = state ? state.tcpStartPort : undefined;
            resourceInputs["udpEndPort"] = state ? state.udpEndPort : undefined;
            resourceInputs["udpFootprint"] = state ? state.udpFootprint : undefined;
            resourceInputs["udpStartPort"] = state ? state.udpStartPort : undefined;
            resourceInputs["webApiUrls"] = state ? state.webApiUrls : undefined;
        } else {
            const args = argsOrState as DdosPolicyCaseArgs | undefined;
            if ((!args || args.appProtocols === undefined) && !opts.urn) {
                throw new Error("Missing required property 'appProtocols'");
            }
            if ((!args || args.appType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'appType'");
            }
            if ((!args || args.hasAbroad === undefined) && !opts.urn) {
                throw new Error("Missing required property 'hasAbroad'");
            }
            if ((!args || args.hasInitiateTcp === undefined) && !opts.urn) {
                throw new Error("Missing required property 'hasInitiateTcp'");
            }
            if ((!args || args.platformTypes === undefined) && !opts.urn) {
                throw new Error("Missing required property 'platformTypes'");
            }
            if ((!args || args.resourceType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceType'");
            }
            if ((!args || args.tcpEndPort === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tcpEndPort'");
            }
            if ((!args || args.tcpStartPort === undefined) && !opts.urn) {
                throw new Error("Missing required property 'tcpStartPort'");
            }
            if ((!args || args.udpEndPort === undefined) && !opts.urn) {
                throw new Error("Missing required property 'udpEndPort'");
            }
            if ((!args || args.udpStartPort === undefined) && !opts.urn) {
                throw new Error("Missing required property 'udpStartPort'");
            }
            if ((!args || args.webApiUrls === undefined) && !opts.urn) {
                throw new Error("Missing required property 'webApiUrls'");
            }
            resourceInputs["appProtocols"] = args ? args.appProtocols : undefined;
            resourceInputs["appType"] = args ? args.appType : undefined;
            resourceInputs["hasAbroad"] = args ? args.hasAbroad : undefined;
            resourceInputs["hasInitiateTcp"] = args ? args.hasInitiateTcp : undefined;
            resourceInputs["hasInitiateUdp"] = args ? args.hasInitiateUdp : undefined;
            resourceInputs["hasVpn"] = args ? args.hasVpn : undefined;
            resourceInputs["maxTcpPackageLen"] = args ? args.maxTcpPackageLen : undefined;
            resourceInputs["maxUdpPackageLen"] = args ? args.maxUdpPackageLen : undefined;
            resourceInputs["minTcpPackageLen"] = args ? args.minTcpPackageLen : undefined;
            resourceInputs["minUdpPackageLen"] = args ? args.minUdpPackageLen : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["peerTcpPort"] = args ? args.peerTcpPort : undefined;
            resourceInputs["peerUdpPort"] = args ? args.peerUdpPort : undefined;
            resourceInputs["platformTypes"] = args ? args.platformTypes : undefined;
            resourceInputs["resourceType"] = args ? args.resourceType : undefined;
            resourceInputs["tcpEndPort"] = args ? args.tcpEndPort : undefined;
            resourceInputs["tcpFootprint"] = args ? args.tcpFootprint : undefined;
            resourceInputs["tcpStartPort"] = args ? args.tcpStartPort : undefined;
            resourceInputs["udpEndPort"] = args ? args.udpEndPort : undefined;
            resourceInputs["udpFootprint"] = args ? args.udpFootprint : undefined;
            resourceInputs["udpStartPort"] = args ? args.udpStartPort : undefined;
            resourceInputs["webApiUrls"] = args ? args.webApiUrls : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["sceneId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DdosPolicyCase.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DdosPolicyCase resources.
 */
export interface DdosPolicyCaseState {
    /**
     * App protocol set of the DDoS policy case.
     */
    appProtocols?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * App type of the DDoS policy case. Valid values: `WEB`, `GAME`, `APP` and `OTHER`.
     */
    appType?: pulumi.Input<string>;
    /**
     * Create time of the DDoS policy case.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Indicate whether the service involves overseas or not. Valid values: `no` and `yes`.
     */
    hasAbroad?: pulumi.Input<string>;
    /**
     * Indicate whether the service actively initiates TCP requests or not. Valid values: `no` and `yes`.
     */
    hasInitiateTcp?: pulumi.Input<string>;
    /**
     * Indicate whether the actively initiate UDP requests or not. Valid values: `no` and `yes`.
     */
    hasInitiateUdp?: pulumi.Input<string>;
    /**
     * Indicate whether the service involves VPN service or not. Valid values: `no` and `yes`.
     */
    hasVpn?: pulumi.Input<string>;
    /**
     * The max length of TCP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minTcpPackageLen`.
     */
    maxTcpPackageLen?: pulumi.Input<string>;
    /**
     * The max length of UDP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minUdpPackageLen`.
     */
    maxUdpPackageLen?: pulumi.Input<string>;
    /**
     * The minimum length of TCP message package, valid value length should be greater than 0 and less than 1500.
     */
    minTcpPackageLen?: pulumi.Input<string>;
    /**
     * The minimum length of UDP message package, valid value length should be greater than 0 and less than 1500.
     */
    minUdpPackageLen?: pulumi.Input<string>;
    /**
     * Name of the DDoS policy case. Length should between 1 and 64.
     */
    name?: pulumi.Input<string>;
    /**
     * The port that actively initiates TCP requests. Valid value ranges: (1~65535).
     */
    peerTcpPort?: pulumi.Input<string>;
    /**
     * The port that actively initiates UDP requests. Valid value ranges: (1~65535).
     */
    peerUdpPort?: pulumi.Input<string>;
    /**
     * Platform set of the DDoS policy case.
     */
    platformTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Type of the resource that the DDoS policy case works for. Valid values: `bgpip`, `bgp` and `bgp-multip`.
     */
    resourceType?: pulumi.Input<string>;
    /**
     * ID of the DDoS policy case.
     */
    sceneId?: pulumi.Input<string>;
    /**
     * End port of the TCP service. Valid value ranges: (0~65535). It must be greater than `tcpStartPort`.
     */
    tcpEndPort?: pulumi.Input<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    tcpFootprint?: pulumi.Input<string>;
    /**
     * Start port of the TCP service. Valid value ranges: (0~65535).
     */
    tcpStartPort?: pulumi.Input<string>;
    /**
     * End port of the UDP service. Valid value ranges: (0~65535). It must be greater than `udpStartPort`.
     */
    udpEndPort?: pulumi.Input<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    udpFootprint?: pulumi.Input<string>;
    /**
     * Start port of the UDP service. Valid value ranges: (0~65535).
     */
    udpStartPort?: pulumi.Input<string>;
    /**
     * Web API url set.
     */
    webApiUrls?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a DdosPolicyCase resource.
 */
export interface DdosPolicyCaseArgs {
    /**
     * App protocol set of the DDoS policy case.
     */
    appProtocols: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * App type of the DDoS policy case. Valid values: `WEB`, `GAME`, `APP` and `OTHER`.
     */
    appType: pulumi.Input<string>;
    /**
     * Indicate whether the service involves overseas or not. Valid values: `no` and `yes`.
     */
    hasAbroad: pulumi.Input<string>;
    /**
     * Indicate whether the service actively initiates TCP requests or not. Valid values: `no` and `yes`.
     */
    hasInitiateTcp: pulumi.Input<string>;
    /**
     * Indicate whether the actively initiate UDP requests or not. Valid values: `no` and `yes`.
     */
    hasInitiateUdp?: pulumi.Input<string>;
    /**
     * Indicate whether the service involves VPN service or not. Valid values: `no` and `yes`.
     */
    hasVpn?: pulumi.Input<string>;
    /**
     * The max length of TCP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minTcpPackageLen`.
     */
    maxTcpPackageLen?: pulumi.Input<string>;
    /**
     * The max length of UDP message package, valid value length should be greater than 0 and less than 1500. It should be greater than `minUdpPackageLen`.
     */
    maxUdpPackageLen?: pulumi.Input<string>;
    /**
     * The minimum length of TCP message package, valid value length should be greater than 0 and less than 1500.
     */
    minTcpPackageLen?: pulumi.Input<string>;
    /**
     * The minimum length of UDP message package, valid value length should be greater than 0 and less than 1500.
     */
    minUdpPackageLen?: pulumi.Input<string>;
    /**
     * Name of the DDoS policy case. Length should between 1 and 64.
     */
    name?: pulumi.Input<string>;
    /**
     * The port that actively initiates TCP requests. Valid value ranges: (1~65535).
     */
    peerTcpPort?: pulumi.Input<string>;
    /**
     * The port that actively initiates UDP requests. Valid value ranges: (1~65535).
     */
    peerUdpPort?: pulumi.Input<string>;
    /**
     * Platform set of the DDoS policy case.
     */
    platformTypes: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Type of the resource that the DDoS policy case works for. Valid values: `bgpip`, `bgp` and `bgp-multip`.
     */
    resourceType: pulumi.Input<string>;
    /**
     * End port of the TCP service. Valid value ranges: (0~65535). It must be greater than `tcpStartPort`.
     */
    tcpEndPort: pulumi.Input<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    tcpFootprint?: pulumi.Input<string>;
    /**
     * Start port of the TCP service. Valid value ranges: (0~65535).
     */
    tcpStartPort: pulumi.Input<string>;
    /**
     * End port of the UDP service. Valid value ranges: (0~65535). It must be greater than `udpStartPort`.
     */
    udpEndPort: pulumi.Input<string>;
    /**
     * The fixed signature of TCP protocol load, valid value length is range from 1 to 512.
     */
    udpFootprint?: pulumi.Input<string>;
    /**
     * Start port of the UDP service. Valid value ranges: (0~65535).
     */
    udpStartPort: pulumi.Input<string>;
    /**
     * Web API url set.
     */
    webApiUrls: pulumi.Input<pulumi.Input<string>[]>;
}
