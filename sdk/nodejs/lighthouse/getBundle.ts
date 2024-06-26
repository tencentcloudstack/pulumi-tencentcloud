// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of lighthouse bundle
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const bundle = tencentcloud.Lighthouse.getBundle({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getBundle(args?: GetBundleArgs, opts?: pulumi.InvokeOptions): Promise<GetBundleResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Lighthouse/getBundle:getBundle", {
        "bundleIds": args.bundleIds,
        "filters": args.filters,
        "limit": args.limit,
        "offset": args.offset,
        "resultOutputFile": args.resultOutputFile,
        "zones": args.zones,
    }, opts);
}

/**
 * A collection of arguments for invoking getBundle.
 */
export interface GetBundleArgs {
    /**
     * Bundle ID list.
     */
    bundleIds?: string[];
    /**
     * Filter list.
     * - `bundle-id`: filter by the bundle ID.
     * - `support-platform-type`: filter by system type, valid values: `LINUX_UNIX`, `WINDOWS`.
     * - `bundle-type`: filter according to package type, valid values: `GENERAL_BUNDLE`, `STORAGE_BUNDLE`, `ENTERPRISE_BUNDLE`, `EXCLUSIVE_BUNDLE`, `BEFAST_BUNDLE`.
     * - `bundle-state`: filter according to package status, valid values: `ONLINE`, `OFFLINE`.
     * NOTE: The upper limit of Filters per request is 10. The upper limit of Filter.Values is 5. Parameter does not support specifying both BundleIds and Filters.
     */
    filters?: inputs.Lighthouse.GetBundleFilter[];
    /**
     * Number of returned results. Default value is 20. Maximum value is 100.
     */
    limit?: number;
    /**
     * Offset. Default value is 0.
     */
    offset?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Zone list, which contains all zones by default.
     */
    zones?: string[];
}

/**
 * A collection of values returned by getBundle.
 */
export interface GetBundleResult {
    readonly bundleIds?: string[];
    /**
     * List of bundle details.
     */
    readonly bundleSets: outputs.Lighthouse.GetBundleBundleSet[];
    readonly filters?: outputs.Lighthouse.GetBundleFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly limit?: number;
    readonly offset?: number;
    readonly resultOutputFile?: string;
    readonly zones?: string[];
}
/**
 * Use this data source to query detailed information of lighthouse bundle
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const bundle = tencentcloud.Lighthouse.getBundle({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getBundleOutput(args?: GetBundleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBundleResult> {
    return pulumi.output(args).apply((a: any) => getBundle(a, opts))
}

/**
 * A collection of arguments for invoking getBundle.
 */
export interface GetBundleOutputArgs {
    /**
     * Bundle ID list.
     */
    bundleIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Filter list.
     * - `bundle-id`: filter by the bundle ID.
     * - `support-platform-type`: filter by system type, valid values: `LINUX_UNIX`, `WINDOWS`.
     * - `bundle-type`: filter according to package type, valid values: `GENERAL_BUNDLE`, `STORAGE_BUNDLE`, `ENTERPRISE_BUNDLE`, `EXCLUSIVE_BUNDLE`, `BEFAST_BUNDLE`.
     * - `bundle-state`: filter according to package status, valid values: `ONLINE`, `OFFLINE`.
     * NOTE: The upper limit of Filters per request is 10. The upper limit of Filter.Values is 5. Parameter does not support specifying both BundleIds and Filters.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Lighthouse.GetBundleFilterArgs>[]>;
    /**
     * Number of returned results. Default value is 20. Maximum value is 100.
     */
    limit?: pulumi.Input<number>;
    /**
     * Offset. Default value is 0.
     */
    offset?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Zone list, which contains all zones by default.
     */
    zones?: pulumi.Input<pulumi.Input<string>[]>;
}
