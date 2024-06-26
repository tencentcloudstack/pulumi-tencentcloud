// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dlc modifyDataEngineDescriptionOperation
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const modifyDataEngineDescriptionOperation = new tencentcloud.dlc.ModifyDataEngineDescriptionOperation("modifyDataEngineDescriptionOperation", {
 *     dataEngineName: "testEngine",
 *     message: "test",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * dlc modify_data_engine_description_operation can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Dlc/modifyDataEngineDescriptionOperation:ModifyDataEngineDescriptionOperation modify_data_engine_description_operation modify_data_engine_description_operation_id
 * ```
 */
export class ModifyDataEngineDescriptionOperation extends pulumi.CustomResource {
    /**
     * Get an existing ModifyDataEngineDescriptionOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ModifyDataEngineDescriptionOperationState, opts?: pulumi.CustomResourceOptions): ModifyDataEngineDescriptionOperation {
        return new ModifyDataEngineDescriptionOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dlc/modifyDataEngineDescriptionOperation:ModifyDataEngineDescriptionOperation';

    /**
     * Returns true if the given object is an instance of ModifyDataEngineDescriptionOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ModifyDataEngineDescriptionOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ModifyDataEngineDescriptionOperation.__pulumiType;
    }

    /**
     * The name of the engine to modify.
     */
    public readonly dataEngineName!: pulumi.Output<string>;
    /**
     * Engine description information, the maximum length is 250.
     */
    public readonly message!: pulumi.Output<string>;

    /**
     * Create a ModifyDataEngineDescriptionOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModifyDataEngineDescriptionOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ModifyDataEngineDescriptionOperationArgs | ModifyDataEngineDescriptionOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ModifyDataEngineDescriptionOperationState | undefined;
            resourceInputs["dataEngineName"] = state ? state.dataEngineName : undefined;
            resourceInputs["message"] = state ? state.message : undefined;
        } else {
            const args = argsOrState as ModifyDataEngineDescriptionOperationArgs | undefined;
            if ((!args || args.dataEngineName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dataEngineName'");
            }
            if ((!args || args.message === undefined) && !opts.urn) {
                throw new Error("Missing required property 'message'");
            }
            resourceInputs["dataEngineName"] = args ? args.dataEngineName : undefined;
            resourceInputs["message"] = args ? args.message : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ModifyDataEngineDescriptionOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ModifyDataEngineDescriptionOperation resources.
 */
export interface ModifyDataEngineDescriptionOperationState {
    /**
     * The name of the engine to modify.
     */
    dataEngineName?: pulumi.Input<string>;
    /**
     * Engine description information, the maximum length is 250.
     */
    message?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ModifyDataEngineDescriptionOperation resource.
 */
export interface ModifyDataEngineDescriptionOperationArgs {
    /**
     * The name of the engine to modify.
     */
    dataEngineName: pulumi.Input<string>;
    /**
     * Engine description information, the maximum length is 250.
     */
    message: pulumi.Input<string>;
}
