// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to apply parameter template
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const applyParameterTemplateOperation = new tencentcloud.postgresql.ApplyParameterTemplateOperation("applyParameterTemplateOperation", {
 *     dbInstanceId: "postgres-xxxxxx",
 *     templateId: "xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ApplyParameterTemplateOperation extends pulumi.CustomResource {
    /**
     * Get an existing ApplyParameterTemplateOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApplyParameterTemplateOperationState, opts?: pulumi.CustomResourceOptions): ApplyParameterTemplateOperation {
        return new ApplyParameterTemplateOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Postgresql/applyParameterTemplateOperation:ApplyParameterTemplateOperation';

    /**
     * Returns true if the given object is an instance of ApplyParameterTemplateOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApplyParameterTemplateOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApplyParameterTemplateOperation.__pulumiType;
    }

    /**
     * Instance ID.
     */
    public readonly dbInstanceId!: pulumi.Output<string>;
    /**
     * Template ID.
     */
    public readonly templateId!: pulumi.Output<string>;

    /**
     * Create a ApplyParameterTemplateOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApplyParameterTemplateOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApplyParameterTemplateOperationArgs | ApplyParameterTemplateOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApplyParameterTemplateOperationState | undefined;
            resourceInputs["dbInstanceId"] = state ? state.dbInstanceId : undefined;
            resourceInputs["templateId"] = state ? state.templateId : undefined;
        } else {
            const args = argsOrState as ApplyParameterTemplateOperationArgs | undefined;
            if ((!args || args.dbInstanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dbInstanceId'");
            }
            if ((!args || args.templateId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'templateId'");
            }
            resourceInputs["dbInstanceId"] = args ? args.dbInstanceId : undefined;
            resourceInputs["templateId"] = args ? args.templateId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApplyParameterTemplateOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApplyParameterTemplateOperation resources.
 */
export interface ApplyParameterTemplateOperationState {
    /**
     * Instance ID.
     */
    dbInstanceId?: pulumi.Input<string>;
    /**
     * Template ID.
     */
    templateId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApplyParameterTemplateOperation resource.
 */
export interface ApplyParameterTemplateOperationArgs {
    /**
     * Instance ID.
     */
    dbInstanceId: pulumi.Input<string>;
    /**
     * Template ID.
     */
    templateId: pulumi.Input<string>;
}