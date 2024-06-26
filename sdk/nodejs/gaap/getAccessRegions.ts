// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of gaap access regions
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accessRegions = tencentcloud.Gaap.getAccessRegions({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccessRegions(args?: GetAccessRegionsArgs, opts?: pulumi.InvokeOptions): Promise<GetAccessRegionsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Gaap/getAccessRegions:getAccessRegions", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccessRegions.
 */
export interface GetAccessRegionsArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAccessRegions.
 */
export interface GetAccessRegionsResult {
    /**
     * Acceleration Zone Details List.
     */
    readonly accessRegionSets: outputs.Gaap.GetAccessRegionsAccessRegionSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of gaap access regions
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accessRegions = tencentcloud.Gaap.getAccessRegions({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccessRegionsOutput(args?: GetAccessRegionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccessRegionsResult> {
    return pulumi.output(args).apply((a: any) => getAccessRegions(a, opts))
}

/**
 * A collection of arguments for invoking getAccessRegions.
 */
export interface GetAccessRegionsOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
