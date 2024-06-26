// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of clb crossTargets
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const crossTargets = tencentcloud.Clb.getCrossTargets({
 *     filters: [{
 *         name: "vpc-id",
 *         values: ["vpc-4owdpnwr"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCrossTargets(args?: GetCrossTargetsArgs, opts?: pulumi.InvokeOptions): Promise<GetCrossTargetsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Clb/getCrossTargets:getCrossTargets", {
        "filters": args.filters,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCrossTargets.
 */
export interface GetCrossTargetsArgs {
    /**
     * Filter conditions to query CVMs and ENIs: vpc-id - String - Required: No - (Filter condition) Filter by VPC ID, such as vpc-12345678. ip - String - Required: No - (Filter condition) Filter by real server IP, such as 192.168.0.1. listener-id - String - Required: No - (Filter condition) Filter by listener ID, such as lbl-12345678. location-id - String - Required: No - (Filter condition) Filter by forwarding rule ID of the layer-7 listener, such as loc-12345678.
     */
    filters?: inputs.Clb.GetCrossTargetsFilter[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCrossTargets.
 */
export interface GetCrossTargetsResult {
    /**
     * Cross target set.
     */
    readonly crossTargetSets: outputs.Clb.GetCrossTargetsCrossTargetSet[];
    readonly filters?: outputs.Clb.GetCrossTargetsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of clb crossTargets
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const crossTargets = tencentcloud.Clb.getCrossTargets({
 *     filters: [{
 *         name: "vpc-id",
 *         values: ["vpc-4owdpnwr"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCrossTargetsOutput(args?: GetCrossTargetsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCrossTargetsResult> {
    return pulumi.output(args).apply((a: any) => getCrossTargets(a, opts))
}

/**
 * A collection of arguments for invoking getCrossTargets.
 */
export interface GetCrossTargetsOutputArgs {
    /**
     * Filter conditions to query CVMs and ENIs: vpc-id - String - Required: No - (Filter condition) Filter by VPC ID, such as vpc-12345678. ip - String - Required: No - (Filter condition) Filter by real server IP, such as 192.168.0.1. listener-id - String - Required: No - (Filter condition) Filter by listener ID, such as lbl-12345678. location-id - String - Required: No - (Filter condition) Filter by forwarding rule ID of the layer-7 listener, such as loc-12345678.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Clb.GetCrossTargetsFilterArgs>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
