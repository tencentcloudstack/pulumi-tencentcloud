// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a teo teoFunctionRulePriority
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const teoFunctionRulePriority = new tencentcloud.teo.FunctionRulePriority("teoFunctionRulePriority", {
 *     functionId: "ef-txx7fnua",
 *     ruleIds: [
 *         "rule-equpbht3",
 *         "rule-ax28n3g6",
 *     ],
 *     zoneId: "zone-2qtuhspy7cr6",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * teo teo_function_rule_priority can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Teo/functionRulePriority:FunctionRulePriority teo_function_rule_priority zone_id#function_id
 * ```
 */
export class FunctionRulePriority extends pulumi.CustomResource {
    /**
     * Get an existing FunctionRulePriority resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FunctionRulePriorityState, opts?: pulumi.CustomResourceOptions): FunctionRulePriority {
        return new FunctionRulePriority(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Teo/functionRulePriority:FunctionRulePriority';

    /**
     * Returns true if the given object is an instance of FunctionRulePriority.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FunctionRulePriority {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FunctionRulePriority.__pulumiType;
    }

    /**
     * ID of the Function.
     */
    public readonly functionId!: pulumi.Output<string>;
    /**
     * he list of rule IDs. It is required to include all rule IDs after adjusting their priorities. The execution order of multiple rules follows a top-down sequence. If not specified, the original priority order will be maintained.
     */
    public readonly ruleIds!: pulumi.Output<string[]>;
    /**
     * ID of the site.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a FunctionRulePriority resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FunctionRulePriorityArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FunctionRulePriorityArgs | FunctionRulePriorityState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FunctionRulePriorityState | undefined;
            resourceInputs["functionId"] = state ? state.functionId : undefined;
            resourceInputs["ruleIds"] = state ? state.ruleIds : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as FunctionRulePriorityArgs | undefined;
            if ((!args || args.functionId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'functionId'");
            }
            if ((!args || args.ruleIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleIds'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["functionId"] = args ? args.functionId : undefined;
            resourceInputs["ruleIds"] = args ? args.ruleIds : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FunctionRulePriority.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FunctionRulePriority resources.
 */
export interface FunctionRulePriorityState {
    /**
     * ID of the Function.
     */
    functionId?: pulumi.Input<string>;
    /**
     * he list of rule IDs. It is required to include all rule IDs after adjusting their priorities. The execution order of multiple rules follows a top-down sequence. If not specified, the original priority order will be maintained.
     */
    ruleIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * ID of the site.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FunctionRulePriority resource.
 */
export interface FunctionRulePriorityArgs {
    /**
     * ID of the Function.
     */
    functionId: pulumi.Input<string>;
    /**
     * he list of rule IDs. It is required to include all rule IDs after adjusting their priorities. The execution order of multiple rules follows a top-down sequence. If not specified, the original priority order will be maintained.
     */
    ruleIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * ID of the site.
     */
    zoneId: pulumi.Input<string>;
}