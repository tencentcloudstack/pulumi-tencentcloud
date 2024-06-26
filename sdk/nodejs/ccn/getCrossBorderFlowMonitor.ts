// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of vpc crossBorderFlowMonitor
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const crossBorderFlowMonitor = tencentcloud.Ccn.getCrossBorderFlowMonitor({
 *     ccnId: "ccn-39lqkygf",
 *     ccnUin: "979137",
 *     destinationRegion: "ap-singapore",
 *     endTime: "2023-01-01 01:00:00",
 *     period: 60,
 *     sourceRegion: "ap-guangzhou",
 *     startTime: "2023-01-01 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCrossBorderFlowMonitor(args: GetCrossBorderFlowMonitorArgs, opts?: pulumi.InvokeOptions): Promise<GetCrossBorderFlowMonitorResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Ccn/getCrossBorderFlowMonitor:getCrossBorderFlowMonitor", {
        "ccnId": args.ccnId,
        "ccnUin": args.ccnUin,
        "destinationRegion": args.destinationRegion,
        "endTime": args.endTime,
        "period": args.period,
        "resultOutputFile": args.resultOutputFile,
        "sourceRegion": args.sourceRegion,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getCrossBorderFlowMonitor.
 */
export interface GetCrossBorderFlowMonitorArgs {
    /**
     * CcnId.
     */
    ccnId: string;
    /**
     * CcnUin.
     */
    ccnUin: string;
    /**
     * DestinationRegion.
     */
    destinationRegion: string;
    /**
     * EndTime.
     */
    endTime: string;
    /**
     * TimePeriod.
     */
    period: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * SourceRegion.
     */
    sourceRegion: string;
    /**
     * StartTime.
     */
    startTime: string;
}

/**
 * A collection of values returned by getCrossBorderFlowMonitor.
 */
export interface GetCrossBorderFlowMonitorResult {
    readonly ccnId: string;
    readonly ccnUin: string;
    /**
     * monitor data of cross border.
     */
    readonly crossBorderFlowMonitorDatas: outputs.Ccn.GetCrossBorderFlowMonitorCrossBorderFlowMonitorData[];
    readonly destinationRegion: string;
    readonly endTime: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly period: number;
    readonly resultOutputFile?: string;
    readonly sourceRegion: string;
    readonly startTime: string;
}
/**
 * Use this data source to query detailed information of vpc crossBorderFlowMonitor
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const crossBorderFlowMonitor = tencentcloud.Ccn.getCrossBorderFlowMonitor({
 *     ccnId: "ccn-39lqkygf",
 *     ccnUin: "979137",
 *     destinationRegion: "ap-singapore",
 *     endTime: "2023-01-01 01:00:00",
 *     period: 60,
 *     sourceRegion: "ap-guangzhou",
 *     startTime: "2023-01-01 00:00:00",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCrossBorderFlowMonitorOutput(args: GetCrossBorderFlowMonitorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCrossBorderFlowMonitorResult> {
    return pulumi.output(args).apply((a: any) => getCrossBorderFlowMonitor(a, opts))
}

/**
 * A collection of arguments for invoking getCrossBorderFlowMonitor.
 */
export interface GetCrossBorderFlowMonitorOutputArgs {
    /**
     * CcnId.
     */
    ccnId: pulumi.Input<string>;
    /**
     * CcnUin.
     */
    ccnUin: pulumi.Input<string>;
    /**
     * DestinationRegion.
     */
    destinationRegion: pulumi.Input<string>;
    /**
     * EndTime.
     */
    endTime: pulumi.Input<string>;
    /**
     * TimePeriod.
     */
    period: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * SourceRegion.
     */
    sourceRegion: pulumi.Input<string>;
    /**
     * StartTime.
     */
    startTime: pulumi.Input<string>;
}
