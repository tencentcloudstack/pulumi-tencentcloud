// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of emr cvmQuota
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const cvmQuota = pulumi.output(tencentcloud.Emr.getCvmQuota({
 *     clusterId: "emr-0ze36vnp",
 *     zoneId: 100003,
 * }));
 * ```
 */
export function getCvmQuota(args: GetCvmQuotaArgs, opts?: pulumi.InvokeOptions): Promise<GetCvmQuotaResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Emr/getCvmQuota:getCvmQuota", {
        "clusterId": args.clusterId,
        "resultOutputFile": args.resultOutputFile,
        "zoneId": args.zoneId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCvmQuota.
 */
export interface GetCvmQuotaArgs {
    /**
     * EMR cluster ID.
     */
    clusterId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Zone ID.
     */
    zoneId?: number;
}

/**
 * A collection of values returned by getCvmQuota.
 */
export interface GetCvmQuotaResult {
    readonly clusterId: string;
    /**
     * Eks quota Note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly eksQuotaSets: outputs.Emr.GetCvmQuotaEksQuotaSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Postpaid quota list Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly postPaidQuotaSets: outputs.Emr.GetCvmQuotaPostPaidQuotaSet[];
    readonly resultOutputFile?: string;
    /**
     * Biding instance quota list Note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly spotPaidQuotaSets: outputs.Emr.GetCvmQuotaSpotPaidQuotaSet[];
    readonly zoneId?: number;
}

export function getCvmQuotaOutput(args: GetCvmQuotaOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCvmQuotaResult> {
    return pulumi.output(args).apply(a => getCvmQuota(a, opts))
}

/**
 * A collection of arguments for invoking getCvmQuota.
 */
export interface GetCvmQuotaOutputArgs {
    /**
     * EMR cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Zone ID.
     */
    zoneId?: pulumi.Input<number>;
}