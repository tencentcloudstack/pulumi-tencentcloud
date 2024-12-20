// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a elasticsearch diagnose
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const diagnose = new tencentcloud.elasticsearch.Diagnose("diagnose", {
 *     cronTime: "15:00:00",
 *     instanceId: "es-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * es diagnose can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Elasticsearch/diagnose:Diagnose diagnose diagnose_id
 * ```
 */
export class Diagnose extends pulumi.CustomResource {
    /**
     * Get an existing Diagnose resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DiagnoseState, opts?: pulumi.CustomResourceOptions): Diagnose {
        return new Diagnose(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Elasticsearch/diagnose:Diagnose';

    /**
     * Returns true if the given object is an instance of Diagnose.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Diagnose {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Diagnose.__pulumiType;
    }

    /**
     * Intelligent operation and maintenance staff regularly patrol the inspection time every day, the time format is HH:00:00, such as 15:00:00.
     */
    public readonly cronTime!: pulumi.Output<string | undefined>;
    /**
     * Diagnostic items and meta-information of intelligent operation and maintenance.
     */
    public /*out*/ readonly diagnoseJobMetas!: pulumi.Output<outputs.Elasticsearch.DiagnoseDiagnoseJobMeta[]>;
    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * The maximum number of manual triggers per day for intelligent operation and maintenance staff.
     */
    public /*out*/ readonly maxCount!: pulumi.Output<number>;

    /**
     * Create a Diagnose resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DiagnoseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DiagnoseArgs | DiagnoseState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DiagnoseState | undefined;
            resourceInputs["cronTime"] = state ? state.cronTime : undefined;
            resourceInputs["diagnoseJobMetas"] = state ? state.diagnoseJobMetas : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["maxCount"] = state ? state.maxCount : undefined;
        } else {
            const args = argsOrState as DiagnoseArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["cronTime"] = args ? args.cronTime : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["diagnoseJobMetas"] = undefined /*out*/;
            resourceInputs["maxCount"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Diagnose.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Diagnose resources.
 */
export interface DiagnoseState {
    /**
     * Intelligent operation and maintenance staff regularly patrol the inspection time every day, the time format is HH:00:00, such as 15:00:00.
     */
    cronTime?: pulumi.Input<string>;
    /**
     * Diagnostic items and meta-information of intelligent operation and maintenance.
     */
    diagnoseJobMetas?: pulumi.Input<pulumi.Input<inputs.Elasticsearch.DiagnoseDiagnoseJobMeta>[]>;
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * The maximum number of manual triggers per day for intelligent operation and maintenance staff.
     */
    maxCount?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Diagnose resource.
 */
export interface DiagnoseArgs {
    /**
     * Intelligent operation and maintenance staff regularly patrol the inspection time every day, the time format is HH:00:00, such as 15:00:00.
     */
    cronTime?: pulumi.Input<string>;
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
}
