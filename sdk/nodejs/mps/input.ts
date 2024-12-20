// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mps input
 *
 * ## Example Usage
 *
 * ### Create mps input group with SRT
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const input = new tencentcloud.mps.Input("input", {
 *     flowId: tencentcloud_mps_flow.flow.id,
 *     inputGroup: {
 *         inputName: "your_input_name",
 *         protocol: "SRT",
 *         description: "input name Description",
 *         allowIpLists: ["0.0.0.0/0"],
 *         srtSettings: {
 *             mode: "LISTENER",
 *             streamId: "#!::u=johnny,r=resource,h=xxx.com,t=stream,m=play",
 *             latency: 1000,
 *             recvLatency: 1000,
 *             peerLatency: 1000,
 *             peerIdleTimeout: 1000,
 *         },
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * mps input can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Mps/input:Input input input_id
 * ```
 */
export class Input extends pulumi.CustomResource {
    /**
     * Get an existing Input resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InputState, opts?: pulumi.CustomResourceOptions): Input {
        return new Input(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mps/input:Input';

    /**
     * Returns true if the given object is an instance of Input.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Input {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Input.__pulumiType;
    }

    /**
     * Flow ID.
     */
    public readonly flowId!: pulumi.Output<string>;
    /**
     * The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `forEach` to create multiple inputs Scenario.
     */
    public readonly inputGroup!: pulumi.Output<outputs.Mps.InputInputGroup | undefined>;

    /**
     * Create a Input resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InputArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InputArgs | InputState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as InputState | undefined;
            resourceInputs["flowId"] = state ? state.flowId : undefined;
            resourceInputs["inputGroup"] = state ? state.inputGroup : undefined;
        } else {
            const args = argsOrState as InputArgs | undefined;
            if ((!args || args.flowId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'flowId'");
            }
            resourceInputs["flowId"] = args ? args.flowId : undefined;
            resourceInputs["inputGroup"] = args ? args.inputGroup : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Input.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Input resources.
 */
export interface InputState {
    /**
     * Flow ID.
     */
    flowId?: pulumi.Input<string>;
    /**
     * The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `forEach` to create multiple inputs Scenario.
     */
    inputGroup?: pulumi.Input<inputs.Mps.InputInputGroup>;
}

/**
 * The set of arguments for constructing a Input resource.
 */
export interface InputArgs {
    /**
     * Flow ID.
     */
    flowId: pulumi.Input<string>;
    /**
     * The input group for the input. Only support one group for one `tencentcloud.Mps.Input`. Use `forEach` to create multiple inputs Scenario.
     */
    inputGroup?: pulumi.Input<inputs.Mps.InputInputGroup>;
}
