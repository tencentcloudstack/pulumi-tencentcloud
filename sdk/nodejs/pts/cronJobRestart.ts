// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a pts cron_job_restart, restart a scheduled task whose status is `JobAborting`
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const cronJobRestart = new tencentcloud.pts.CronJobRestart("cronJobRestart", {
 *     cronJobId: "job-dtm93vx0",
 *     projectId: "project-abc",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class CronJobRestart extends pulumi.CustomResource {
    /**
     * Get an existing CronJobRestart resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CronJobRestartState, opts?: pulumi.CustomResourceOptions): CronJobRestart {
        return new CronJobRestart(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Pts/cronJobRestart:CronJobRestart';

    /**
     * Returns true if the given object is an instance of CronJobRestart.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CronJobRestart {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CronJobRestart.__pulumiType;
    }

    /**
     * Cron job ID.
     */
    public readonly cronJobId!: pulumi.Output<string>;
    /**
     * Project ID.
     */
    public readonly projectId!: pulumi.Output<string>;

    /**
     * Create a CronJobRestart resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CronJobRestartArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CronJobRestartArgs | CronJobRestartState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CronJobRestartState | undefined;
            resourceInputs["cronJobId"] = state ? state.cronJobId : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
        } else {
            const args = argsOrState as CronJobRestartArgs | undefined;
            if ((!args || args.cronJobId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cronJobId'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            resourceInputs["cronJobId"] = args ? args.cronJobId : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CronJobRestart.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CronJobRestart resources.
 */
export interface CronJobRestartState {
    /**
     * Cron job ID.
     */
    cronJobId?: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CronJobRestart resource.
 */
export interface CronJobRestartArgs {
    /**
     * Cron job ID.
     */
    cronJobId: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId: pulumi.Input<string>;
}
