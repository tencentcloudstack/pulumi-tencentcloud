// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of postgresql defaultParameters
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const defaultParameters = pulumi.output(tencentcloud.Postgresql.getDefaultParameters({
 *     dbEngine: "postgresql",
 *     dbMajorVersion: "13",
 * }));
 * ```
 */
export function getDefaultParameters(args: GetDefaultParametersArgs, opts?: pulumi.InvokeOptions): Promise<GetDefaultParametersResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getDefaultParameters:getDefaultParameters", {
        "dbEngine": args.dbEngine,
        "dbMajorVersion": args.dbMajorVersion,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDefaultParameters.
 */
export interface GetDefaultParametersArgs {
    /**
     * Database engine, such as postgresql, mssql_compatible.
     */
    dbEngine: string;
    /**
     * The major database version number, such as 11, 12, 13.
     */
    dbMajorVersion: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDefaultParameters.
 */
export interface GetDefaultParametersResult {
    readonly dbEngine: string;
    readonly dbMajorVersion: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Parameter informationNote: This field may return null, indicating that no valid values can be obtained.
     */
    readonly paramInfoSets: outputs.Postgresql.GetDefaultParametersParamInfoSet[];
    readonly resultOutputFile?: string;
}

export function getDefaultParametersOutput(args: GetDefaultParametersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDefaultParametersResult> {
    return pulumi.output(args).apply(a => getDefaultParameters(a, opts))
}

/**
 * A collection of arguments for invoking getDefaultParameters.
 */
export interface GetDefaultParametersOutputArgs {
    /**
     * Database engine, such as postgresql, mssql_compatible.
     */
    dbEngine: pulumi.Input<string>;
    /**
     * The major database version number, such as 11, 12, 13.
     */
    dbMajorVersion: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}