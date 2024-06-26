// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of rum logExportList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const logExportList = tencentcloud.Rum.getLogExportList({
 *     projectId: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLogExportList(args: GetLogExportListArgs, opts?: pulumi.InvokeOptions): Promise<GetLogExportListResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Rum/getLogExportList:getLogExportList", {
        "projectId": args.projectId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getLogExportList.
 */
export interface GetLogExportListArgs {
    /**
     * Project ID.
     */
    projectId: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getLogExportList.
 */
export interface GetLogExportListResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly projectId: number;
    /**
     * Return result.
     */
    readonly result: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of rum logExportList
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const logExportList = tencentcloud.Rum.getLogExportList({
 *     projectId: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getLogExportListOutput(args: GetLogExportListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLogExportListResult> {
    return pulumi.output(args).apply((a: any) => getLogExportList(a, opts))
}

/**
 * A collection of arguments for invoking getLogExportList.
 */
export interface GetLogExportListOutputArgs {
    /**
     * Project ID.
     */
    projectId: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
