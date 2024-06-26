// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cfw vpcInstance
 *
 * ## Example Usage
 *
 * ## Import
 *
 * cfw vpc_instance can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Cfw/vpcInstance:VpcInstance example cfwg-4ee69507
 * ```
 */
export class VpcInstance extends pulumi.CustomResource {
    /**
     * Get an existing VpcInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcInstanceState, opts?: pulumi.CustomResourceOptions): VpcInstance {
        return new VpcInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cfw/vpcInstance:VpcInstance';

    /**
     * Returns true if the given object is an instance of VpcInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VpcInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VpcInstance.__pulumiType;
    }

    /**
     * Cloud networking id, suitable for cloud networking mode.
     */
    public readonly ccnId!: pulumi.Output<string | undefined>;
    /**
     * auto Automatically select the firewall network segment; 10.10.10.0/24 The firewall network segment entered by the user.
     */
    public readonly fwVpcCidr!: pulumi.Output<string | undefined>;
    /**
     * Mode 0: private network mode; 1: CCN cloud networking mode.
     */
    public readonly mode!: pulumi.Output<number>;
    /**
     * VPC firewall (group) name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Switch mode of firewall instance. 1: Single point intercommunication; 2: Multi-point communication; 4: Custom Routing.
     */
    public readonly switchMode!: pulumi.Output<number>;
    /**
     * List of firewall instances under firewall (group).
     */
    public readonly vpcFwInstances!: pulumi.Output<outputs.Cfw.VpcInstanceVpcFwInstance[]>;

    /**
     * Create a VpcInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpcInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcInstanceArgs | VpcInstanceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcInstanceState | undefined;
            resourceInputs["ccnId"] = state ? state.ccnId : undefined;
            resourceInputs["fwVpcCidr"] = state ? state.fwVpcCidr : undefined;
            resourceInputs["mode"] = state ? state.mode : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["switchMode"] = state ? state.switchMode : undefined;
            resourceInputs["vpcFwInstances"] = state ? state.vpcFwInstances : undefined;
        } else {
            const args = argsOrState as VpcInstanceArgs | undefined;
            if ((!args || args.mode === undefined) && !opts.urn) {
                throw new Error("Missing required property 'mode'");
            }
            if ((!args || args.switchMode === undefined) && !opts.urn) {
                throw new Error("Missing required property 'switchMode'");
            }
            if ((!args || args.vpcFwInstances === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcFwInstances'");
            }
            resourceInputs["ccnId"] = args ? args.ccnId : undefined;
            resourceInputs["fwVpcCidr"] = args ? args.fwVpcCidr : undefined;
            resourceInputs["mode"] = args ? args.mode : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["switchMode"] = args ? args.switchMode : undefined;
            resourceInputs["vpcFwInstances"] = args ? args.vpcFwInstances : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(VpcInstance.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VpcInstance resources.
 */
export interface VpcInstanceState {
    /**
     * Cloud networking id, suitable for cloud networking mode.
     */
    ccnId?: pulumi.Input<string>;
    /**
     * auto Automatically select the firewall network segment; 10.10.10.0/24 The firewall network segment entered by the user.
     */
    fwVpcCidr?: pulumi.Input<string>;
    /**
     * Mode 0: private network mode; 1: CCN cloud networking mode.
     */
    mode?: pulumi.Input<number>;
    /**
     * VPC firewall (group) name.
     */
    name?: pulumi.Input<string>;
    /**
     * Switch mode of firewall instance. 1: Single point intercommunication; 2: Multi-point communication; 4: Custom Routing.
     */
    switchMode?: pulumi.Input<number>;
    /**
     * List of firewall instances under firewall (group).
     */
    vpcFwInstances?: pulumi.Input<pulumi.Input<inputs.Cfw.VpcInstanceVpcFwInstance>[]>;
}

/**
 * The set of arguments for constructing a VpcInstance resource.
 */
export interface VpcInstanceArgs {
    /**
     * Cloud networking id, suitable for cloud networking mode.
     */
    ccnId?: pulumi.Input<string>;
    /**
     * auto Automatically select the firewall network segment; 10.10.10.0/24 The firewall network segment entered by the user.
     */
    fwVpcCidr?: pulumi.Input<string>;
    /**
     * Mode 0: private network mode; 1: CCN cloud networking mode.
     */
    mode: pulumi.Input<number>;
    /**
     * VPC firewall (group) name.
     */
    name?: pulumi.Input<string>;
    /**
     * Switch mode of firewall instance. 1: Single point intercommunication; 2: Multi-point communication; 4: Custom Routing.
     */
    switchMode: pulumi.Input<number>;
    /**
     * List of firewall instances under firewall (group).
     */
    vpcFwInstances: pulumi.Input<pulumi.Input<inputs.Cfw.VpcInstanceVpcFwInstance>[]>;
}
