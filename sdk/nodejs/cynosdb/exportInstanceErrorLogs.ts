// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cynosdb exportInstanceErrorLogs
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exportInstanceErrorLogs = new tencentcloud.cynosdb.ExportInstanceErrorLogs("exportInstanceErrorLogs", {
 *     endTime: "2022-01-01 14:00:00",
 *     fileType: "csv",
 *     instanceId: "cynosdbmysql-ins-afqx1hy0",
 *     keyWords: ["content"],
 *     logLevels: ["note"],
 *     orderBy: "Timestamp",
 *     orderByType: "ASC",
 *     startTime: "2022-01-01 12:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ExportInstanceErrorLogs extends pulumi.CustomResource {
    /**
     * Get an existing ExportInstanceErrorLogs resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ExportInstanceErrorLogsState, opts?: pulumi.CustomResourceOptions): ExportInstanceErrorLogs {
        return new ExportInstanceErrorLogs(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cynosdb/exportInstanceErrorLogs:ExportInstanceErrorLogs';

    /**
     * Returns true if the given object is an instance of ExportInstanceErrorLogs.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExportInstanceErrorLogs {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExportInstanceErrorLogs.__pulumiType;
    }

    /**
     * Latest log time.
     */
    public readonly endTime!: pulumi.Output<string | undefined>;
    /**
     * List of instances in the read-write instance group.
     */
    public /*out*/ readonly errorLogItemExports!: pulumi.Output<outputs.Cynosdb.ExportInstanceErrorLogsErrorLogItemExport[]>;
    /**
     * File type, optional values: csv, original.
     */
    public readonly fileType!: pulumi.Output<string | undefined>;
    /**
     * Instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * keyword.
     */
    public readonly keyWords!: pulumi.Output<string[] | undefined>;
    /**
     * Log level.
     */
    public readonly logLevels!: pulumi.Output<string[] | undefined>;
    /**
     * Optional value Timestamp.
     */
    public readonly orderBy!: pulumi.Output<string | undefined>;
    /**
     * ASC or DESC.
     */
    public readonly orderByType!: pulumi.Output<string | undefined>;
    /**
     * Log earliest time.
     */
    public readonly startTime!: pulumi.Output<string | undefined>;

    /**
     * Create a ExportInstanceErrorLogs resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExportInstanceErrorLogsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ExportInstanceErrorLogsArgs | ExportInstanceErrorLogsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ExportInstanceErrorLogsState | undefined;
            resourceInputs["endTime"] = state ? state.endTime : undefined;
            resourceInputs["errorLogItemExports"] = state ? state.errorLogItemExports : undefined;
            resourceInputs["fileType"] = state ? state.fileType : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["keyWords"] = state ? state.keyWords : undefined;
            resourceInputs["logLevels"] = state ? state.logLevels : undefined;
            resourceInputs["orderBy"] = state ? state.orderBy : undefined;
            resourceInputs["orderByType"] = state ? state.orderByType : undefined;
            resourceInputs["startTime"] = state ? state.startTime : undefined;
        } else {
            const args = argsOrState as ExportInstanceErrorLogsArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["endTime"] = args ? args.endTime : undefined;
            resourceInputs["fileType"] = args ? args.fileType : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["keyWords"] = args ? args.keyWords : undefined;
            resourceInputs["logLevels"] = args ? args.logLevels : undefined;
            resourceInputs["orderBy"] = args ? args.orderBy : undefined;
            resourceInputs["orderByType"] = args ? args.orderByType : undefined;
            resourceInputs["startTime"] = args ? args.startTime : undefined;
            resourceInputs["errorLogItemExports"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ExportInstanceErrorLogs.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ExportInstanceErrorLogs resources.
 */
export interface ExportInstanceErrorLogsState {
    /**
     * Latest log time.
     */
    endTime?: pulumi.Input<string>;
    /**
     * List of instances in the read-write instance group.
     */
    errorLogItemExports?: pulumi.Input<pulumi.Input<inputs.Cynosdb.ExportInstanceErrorLogsErrorLogItemExport>[]>;
    /**
     * File type, optional values: csv, original.
     */
    fileType?: pulumi.Input<string>;
    /**
     * Instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * keyword.
     */
    keyWords?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Log level.
     */
    logLevels?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Optional value Timestamp.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * ASC or DESC.
     */
    orderByType?: pulumi.Input<string>;
    /**
     * Log earliest time.
     */
    startTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ExportInstanceErrorLogs resource.
 */
export interface ExportInstanceErrorLogsArgs {
    /**
     * Latest log time.
     */
    endTime?: pulumi.Input<string>;
    /**
     * File type, optional values: csv, original.
     */
    fileType?: pulumi.Input<string>;
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * keyword.
     */
    keyWords?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Log level.
     */
    logLevels?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Optional value Timestamp.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * ASC or DESC.
     */
    orderByType?: pulumi.Input<string>;
    /**
     * Log earliest time.
     */
    startTime?: pulumi.Input<string>;
}
