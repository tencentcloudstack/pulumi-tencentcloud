// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a vpc flowLogConfig
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const flowLogConfig = new tencentcloud.Vpc.FlowLogConfig("flow_log_config", {
 *     enable: false,
 *     flowLogId: "fl-geg2keoj",
 * });
 * ```
 *
 * ## Import
 *
 * vpc flow_log_config can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Vpc/flowLogConfig:FlowLogConfig flow_log_config flow_log_id
 * ```
 */
export class FlowLogConfig extends pulumi.CustomResource {
    /**
     * Get an existing FlowLogConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FlowLogConfigState, opts?: pulumi.CustomResourceOptions): FlowLogConfig {
        return new FlowLogConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Vpc/flowLogConfig:FlowLogConfig';

    /**
     * Returns true if the given object is an instance of FlowLogConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FlowLogConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FlowLogConfig.__pulumiType;
    }

    /**
     * If enable snapshot policy.
     */
    public readonly enable!: pulumi.Output<boolean>;
    /**
     * Flow log ID.
     */
    public readonly flowLogId!: pulumi.Output<string>;

    /**
     * Create a FlowLogConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FlowLogConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FlowLogConfigArgs | FlowLogConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FlowLogConfigState | undefined;
            resourceInputs["enable"] = state ? state.enable : undefined;
            resourceInputs["flowLogId"] = state ? state.flowLogId : undefined;
        } else {
            const args = argsOrState as FlowLogConfigArgs | undefined;
            if ((!args || args.enable === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enable'");
            }
            if ((!args || args.flowLogId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'flowLogId'");
            }
            resourceInputs["enable"] = args ? args.enable : undefined;
            resourceInputs["flowLogId"] = args ? args.flowLogId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FlowLogConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FlowLogConfig resources.
 */
export interface FlowLogConfigState {
    /**
     * If enable snapshot policy.
     */
    enable?: pulumi.Input<boolean>;
    /**
     * Flow log ID.
     */
    flowLogId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FlowLogConfig resource.
 */
export interface FlowLogConfigArgs {
    /**
     * If enable snapshot policy.
     */
    enable: pulumi.Input<boolean>;
    /**
     * Flow log ID.
     */
    flowLogId: pulumi.Input<string>;
}