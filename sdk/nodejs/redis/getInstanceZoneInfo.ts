// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of redis instanceZoneInfo
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const instanceZoneInfo = tencentcloud.Redis.getInstanceZoneInfo({
 *     instanceId: "crs-c1nl9rpv",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInstanceZoneInfo(args?: GetInstanceZoneInfoArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceZoneInfoResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Redis/getInstanceZoneInfo:getInstanceZoneInfo", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceZoneInfo.
 */
export interface GetInstanceZoneInfoArgs {
    /**
     * The ID of instance.
     */
    instanceId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInstanceZoneInfo.
 */
export interface GetInstanceZoneInfoResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId?: string;
    /**
     * List of instance node groups.
     */
    readonly replicaGroups: outputs.Redis.GetInstanceZoneInfoReplicaGroup[];
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of redis instanceZoneInfo
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const instanceZoneInfo = tencentcloud.Redis.getInstanceZoneInfo({
 *     instanceId: "crs-c1nl9rpv",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getInstanceZoneInfoOutput(args?: GetInstanceZoneInfoOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceZoneInfoResult> {
    return pulumi.output(args).apply((a: any) => getInstanceZoneInfo(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceZoneInfo.
 */
export interface GetInstanceZoneInfoOutputArgs {
    /**
     * The ID of instance.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
