// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of postgresql dbInstanceVersions
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const dbInstanceVersions = pulumi.output(tencentcloud.Postgresql.getDbInstanceVersions());
 * ```
 */
export function getDbInstanceVersions(args?: GetDbInstanceVersionsArgs, opts?: pulumi.InvokeOptions): Promise<GetDbInstanceVersionsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getDbInstanceVersions:getDbInstanceVersions", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDbInstanceVersions.
 */
export interface GetDbInstanceVersionsArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDbInstanceVersions.
 */
export interface GetDbInstanceVersionsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * List of database versions.
     */
    readonly versionSets: outputs.Postgresql.GetDbInstanceVersionsVersionSet[];
}

export function getDbInstanceVersionsOutput(args?: GetDbInstanceVersionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDbInstanceVersionsResult> {
    return pulumi.output(args).apply(a => getDbInstanceVersions(a, opts))
}

/**
 * A collection of arguments for invoking getDbInstanceVersions.
 */
export interface GetDbInstanceVersionsOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}