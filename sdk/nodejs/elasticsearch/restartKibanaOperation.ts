// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to restart a elasticsearch kibana
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const restartKibanaOperation = new tencentcloud.elasticsearch.RestartKibanaOperation("restartKibanaOperation", {instanceId: "es-xxxxxx"});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class RestartKibanaOperation extends pulumi.CustomResource {
    /**
     * Get an existing RestartKibanaOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RestartKibanaOperationState, opts?: pulumi.CustomResourceOptions): RestartKibanaOperation {
        return new RestartKibanaOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Elasticsearch/restartKibanaOperation:RestartKibanaOperation';

    /**
     * Returns true if the given object is an instance of RestartKibanaOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RestartKibanaOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RestartKibanaOperation.__pulumiType;
    }

    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a RestartKibanaOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RestartKibanaOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RestartKibanaOperationArgs | RestartKibanaOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RestartKibanaOperationState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as RestartKibanaOperationArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RestartKibanaOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RestartKibanaOperation resources.
 */
export interface RestartKibanaOperationState {
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RestartKibanaOperation resource.
 */
export interface RestartKibanaOperationArgs {
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
}
