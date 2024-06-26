// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of private dns records
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const privateDnsRecord = tencentcloud.PrivateDns.getRecords({
 *     filters: [{
 *         name: "Value",
 *         values: ["8.8.8.8"],
 *     }],
 *     zoneId: "zone-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecords(args: GetRecordsArgs, opts?: pulumi.InvokeOptions): Promise<GetRecordsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:PrivateDns/getRecords:getRecords", {
        "filters": args.filters,
        "resultOutputFile": args.resultOutputFile,
        "zoneId": args.zoneId,
    }, opts);
}

/**
 * A collection of arguments for invoking getRecords.
 */
export interface GetRecordsArgs {
    /**
     * Filter parameters (Value and RecordType filtering are supported).
     */
    filters?: inputs.PrivateDns.GetRecordsFilter[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Private zone id: zone-xxxxxx.
     */
    zoneId: string;
}

/**
 * A collection of values returned by getRecords.
 */
export interface GetRecordsResult {
    readonly filters?: outputs.PrivateDns.GetRecordsFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Parse record list.
     */
    readonly recordSets: outputs.PrivateDns.GetRecordsRecordSet[];
    readonly resultOutputFile?: string;
    /**
     * Private zone id: zone-xxxxxx.
     */
    readonly zoneId: string;
}
/**
 * Use this data source to query detailed information of private dns records
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const privateDnsRecord = tencentcloud.PrivateDns.getRecords({
 *     filters: [{
 *         name: "Value",
 *         values: ["8.8.8.8"],
 *     }],
 *     zoneId: "zone-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getRecordsOutput(args: GetRecordsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRecordsResult> {
    return pulumi.output(args).apply((a: any) => getRecords(a, opts))
}

/**
 * A collection of arguments for invoking getRecords.
 */
export interface GetRecordsOutputArgs {
    /**
     * Filter parameters (Value and RecordType filtering are supported).
     */
    filters?: pulumi.Input<pulumi.Input<inputs.PrivateDns.GetRecordsFilterArgs>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Private zone id: zone-xxxxxx.
     */
    zoneId: pulumi.Input<string>;
}
