// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of sqlserverInsAttribute
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const insAttribute = pulumi.output(tencentcloud.Sqlserver.getInsAttribute({
 *     instanceId: "mssql-gyg9xycl",
 * }));
 * ```
 */
export function getInsAttribute(args: GetInsAttributeArgs, opts?: pulumi.InvokeOptions): Promise<GetInsAttributeResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Sqlserver/getInsAttribute:getInsAttribute", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInsAttribute.
 */
export interface GetInsAttributeArgs {
    /**
     * Instance ID.
     */
    instanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInsAttribute.
 */
export interface GetInsAttributeResult {
    /**
     * Block process threshold in milliseconds.
     */
    readonly blockedThreshold: number;
    /**
     * Retention period for the files of slow SQL, blocking, deadlock, and extended events.
     */
    readonly eventSaveDays: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    /**
     * The number of retained archive backups.
     */
    readonly regularBackupCounts: number;
    /**
     * Archive backup status. Valid values: enable (enabled), disable (disabled).
     */
    readonly regularBackupEnable: string;
    /**
     * Archive backup retention period: [90-3650] days.
     */
    readonly regularBackupSaveDays: number;
    /**
     * Archive backup start date in YYYY-MM-DD format, which is the current time by default.
     */
    readonly regularBackupStartTime: string;
    /**
     * Archive backup policy. Valid values: years (yearly); quarters (quarterly);months` (monthly).
     */
    readonly regularBackupStrategy: string;
    readonly resultOutputFile?: string;
    /**
     * TDE Transparent Data Encryption Configuration.
     */
    readonly tdeConfigs: outputs.Sqlserver.GetInsAttributeTdeConfig[];
}

export function getInsAttributeOutput(args: GetInsAttributeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInsAttributeResult> {
    return pulumi.output(args).apply(a => getInsAttribute(a, opts))
}

/**
 * A collection of arguments for invoking getInsAttribute.
 */
export interface GetInsAttributeOutputArgs {
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}