// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of clickhouse backup tables
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const backupTables = tencentcloud.Clickhouse.getBackupTables({
 *     instanceId: "cdwch-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getBackupTables(args: GetBackupTablesArgs, opts?: pulumi.InvokeOptions): Promise<GetBackupTablesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Clickhouse/getBackupTables:getBackupTables", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getBackupTables.
 */
export interface GetBackupTablesArgs {
    /**
     * Instance id.
     */
    instanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getBackupTables.
 */
export interface GetBackupTablesResult {
    /**
     * Available tables.
     */
    readonly availableTables: outputs.Clickhouse.GetBackupTablesAvailableTable[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of clickhouse backup tables
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const backupTables = tencentcloud.Clickhouse.getBackupTables({
 *     instanceId: "cdwch-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getBackupTablesOutput(args: GetBackupTablesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBackupTablesResult> {
    return pulumi.output(args).apply((a: any) => getBackupTables(a, opts))
}

/**
 * A collection of arguments for invoking getBackupTables.
 */
export interface GetBackupTablesOutputArgs {
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
