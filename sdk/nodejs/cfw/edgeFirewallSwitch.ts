// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cfw edgeFirewallSwitch
 *
 * ## Example Usage
 *
 * ### If not set subnetId
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleEdgeFwSwitches = tencentcloud.Cfw.getEdgeFwSwitches({});
 * const exampleEdgeFirewallSwitch = new tencentcloud.cfw.EdgeFirewallSwitch("exampleEdgeFirewallSwitch", {
 *     publicIp: exampleEdgeFwSwitches.then(exampleEdgeFwSwitches => exampleEdgeFwSwitches.datas?.[0]?.publicIp),
 *     switchMode: 1,
 *     enable: 0,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### If set subnet id
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleEdgeFwSwitches = tencentcloud.Cfw.getEdgeFwSwitches({});
 * const exampleEdgeFirewallSwitch = new tencentcloud.cfw.EdgeFirewallSwitch("exampleEdgeFirewallSwitch", {
 *     publicIp: exampleEdgeFwSwitches.then(exampleEdgeFwSwitches => exampleEdgeFwSwitches.datas?.[0]?.publicIp),
 *     subnetId: "subnet-id",
 *     switchMode: 1,
 *     enable: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class EdgeFirewallSwitch extends pulumi.CustomResource {
    /**
     * Get an existing EdgeFirewallSwitch resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EdgeFirewallSwitchState, opts?: pulumi.CustomResourceOptions): EdgeFirewallSwitch {
        return new EdgeFirewallSwitch(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cfw/edgeFirewallSwitch:EdgeFirewallSwitch';

    /**
     * Returns true if the given object is an instance of EdgeFirewallSwitch.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EdgeFirewallSwitch {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EdgeFirewallSwitch.__pulumiType;
    }

    /**
     * Switch, 0: off, 1: on.
     */
    public readonly enable!: pulumi.Output<number>;
    /**
     * Public Ip.
     */
    public readonly publicIp!: pulumi.Output<string>;
    /**
     * The first EIP switch in the vpc is turned on, and you need to specify a subnet to create a private connection. If `switchMode` is 1 and `enable` is 1, this field is required.
     */
    public readonly subnetId!: pulumi.Output<string | undefined>;
    /**
     * 0: bypass; 1: serial.
     */
    public readonly switchMode!: pulumi.Output<number>;

    /**
     * Create a EdgeFirewallSwitch resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EdgeFirewallSwitchArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EdgeFirewallSwitchArgs | EdgeFirewallSwitchState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as EdgeFirewallSwitchState | undefined;
            resourceInputs["enable"] = state ? state.enable : undefined;
            resourceInputs["publicIp"] = state ? state.publicIp : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["switchMode"] = state ? state.switchMode : undefined;
        } else {
            const args = argsOrState as EdgeFirewallSwitchArgs | undefined;
            if ((!args || args.enable === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enable'");
            }
            if ((!args || args.publicIp === undefined) && !opts.urn) {
                throw new Error("Missing required property 'publicIp'");
            }
            if ((!args || args.switchMode === undefined) && !opts.urn) {
                throw new Error("Missing required property 'switchMode'");
            }
            resourceInputs["enable"] = args ? args.enable : undefined;
            resourceInputs["publicIp"] = args ? args.publicIp : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["switchMode"] = args ? args.switchMode : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(EdgeFirewallSwitch.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EdgeFirewallSwitch resources.
 */
export interface EdgeFirewallSwitchState {
    /**
     * Switch, 0: off, 1: on.
     */
    enable?: pulumi.Input<number>;
    /**
     * Public Ip.
     */
    publicIp?: pulumi.Input<string>;
    /**
     * The first EIP switch in the vpc is turned on, and you need to specify a subnet to create a private connection. If `switchMode` is 1 and `enable` is 1, this field is required.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * 0: bypass; 1: serial.
     */
    switchMode?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a EdgeFirewallSwitch resource.
 */
export interface EdgeFirewallSwitchArgs {
    /**
     * Switch, 0: off, 1: on.
     */
    enable: pulumi.Input<number>;
    /**
     * Public Ip.
     */
    publicIp: pulumi.Input<string>;
    /**
     * The first EIP switch in the vpc is turned on, and you need to specify a subnet to create a private connection. If `switchMode` is 1 and `enable` is 1, this field is required.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * 0: bypass; 1: serial.
     */
    switchMode: pulumi.Input<number>;
}
