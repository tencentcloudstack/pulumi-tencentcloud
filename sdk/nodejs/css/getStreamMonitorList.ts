// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of css streamMonitorList
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const streamMonitorList = pulumi.output(tencentcloud.Css.getStreamMonitorList());
 * ```
 */
export function getStreamMonitorList(args?: GetStreamMonitorListArgs, opts?: pulumi.InvokeOptions): Promise<GetStreamMonitorListResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Css/getStreamMonitorList:getStreamMonitorList", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getStreamMonitorList.
 */
export interface GetStreamMonitorListArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getStreamMonitorList.
 */
export interface GetStreamMonitorListResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The list of live stream monitoring tasks.Note: This field may return null, indicating that no valid value is available.
     */
    readonly liveStreamMonitors: outputs.Css.GetStreamMonitorListLiveStreamMonitor[];
    readonly resultOutputFile?: string;
}

export function getStreamMonitorListOutput(args?: GetStreamMonitorListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetStreamMonitorListResult> {
    return pulumi.output(args).apply(a => getStreamMonitorList(a, opts))
}

/**
 * A collection of arguments for invoking getStreamMonitorList.
 */
export interface GetStreamMonitorListOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}