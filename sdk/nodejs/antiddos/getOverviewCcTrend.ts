// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of antiddos overviewCcTrend
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const overviewCcTrend = tencentcloud.Antiddos.getOverviewCcTrend({
 *     business: "bgpip",
 *     endTime: "2023-11-21 00:00:00",
 *     metricName: "inqps",
 *     period: 300,
 *     startTime: "2023-11-20 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOverviewCcTrend(args: GetOverviewCcTrendArgs, opts?: pulumi.InvokeOptions): Promise<GetOverviewCcTrendResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Antiddos/getOverviewCcTrend:getOverviewCcTrend", {
        "business": args.business,
        "endTime": args.endTime,
        "ipLists": args.ipLists,
        "metricName": args.metricName,
        "period": args.period,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getOverviewCcTrend.
 */
export interface GetOverviewCcTrendArgs {
    /**
     * Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
     */
    business?: string;
    /**
     * EndTime.
     */
    endTime: string;
    /**
     * resource id list.
     */
    ipLists?: string[];
    /**
     * Indicator, values [inqps (peak total requests, dropqps (peak attack requests)), incount (number of requests), dropcount (number of attacks)].
     */
    metricName: string;
    /**
     * Statistical granularity, values [300 (5 minutes), 3600 (hours), 86400 (days)].
     */
    period: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * StartTime.
     */
    startTime: string;
}

/**
 * A collection of values returned by getOverviewCcTrend.
 */
export interface GetOverviewCcTrendResult {
    readonly business?: string;
    /**
     * Data.
     */
    readonly datas: number[];
    readonly endTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ipLists?: string[];
    readonly metricName: string;
    readonly period: number;
    readonly resultOutputFile?: string;
    readonly startTime: string;
}
/**
 * Use this data source to query detailed information of antiddos overviewCcTrend
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const overviewCcTrend = tencentcloud.Antiddos.getOverviewCcTrend({
 *     business: "bgpip",
 *     endTime: "2023-11-21 00:00:00",
 *     metricName: "inqps",
 *     period: 300,
 *     startTime: "2023-11-20 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getOverviewCcTrendOutput(args: GetOverviewCcTrendOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetOverviewCcTrendResult> {
    return pulumi.output(args).apply((a: any) => getOverviewCcTrend(a, opts))
}

/**
 * A collection of arguments for invoking getOverviewCcTrend.
 */
export interface GetOverviewCcTrendOutputArgs {
    /**
     * Dayu sub product code (bgpip represents advanced defense IP; net represents professional version of advanced defense IP).
     */
    business?: pulumi.Input<string>;
    /**
     * EndTime.
     */
    endTime: pulumi.Input<string>;
    /**
     * resource id list.
     */
    ipLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicator, values [inqps (peak total requests, dropqps (peak attack requests)), incount (number of requests), dropcount (number of attacks)].
     */
    metricName: pulumi.Input<string>;
    /**
     * Statistical granularity, values [300 (5 minutes), 3600 (hours), 86400 (days)].
     */
    period: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * StartTime.
     */
    startTime: pulumi.Input<string>;
}
