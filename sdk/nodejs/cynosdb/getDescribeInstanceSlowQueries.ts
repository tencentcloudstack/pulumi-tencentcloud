// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of cynosdb describeInstanceSlowQueries
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const describeInstanceSlowQueries = pulumi.output(tencentcloud.Cynosdb.getDescribeInstanceSlowQueries({
 *     clusterId: "cynosdbmysql-bws8h88b",
 *     endTime: "2023-06-19 14:00:00",
 *     startTime: "2023-06-01 12:00:00",
 * }));
 * ```
 */
export function getDescribeInstanceSlowQueries(args: GetDescribeInstanceSlowQueriesArgs, opts?: pulumi.InvokeOptions): Promise<GetDescribeInstanceSlowQueriesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getDescribeInstanceSlowQueries:getDescribeInstanceSlowQueries", {
        "clusterId": args.clusterId,
        "endTime": args.endTime,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getDescribeInstanceSlowQueries.
 */
export interface GetDescribeInstanceSlowQueriesArgs {
    /**
     * Cluster ID.
     */
    clusterId: string;
    /**
     * End time.
     */
    endTime?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * start time.
     */
    startTime?: string;
}

/**
 * A collection of values returned by getDescribeInstanceSlowQueries.
 */
export interface GetDescribeInstanceSlowQueriesResult {
    /**
     * Note to the Binlog list: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly binlogs: outputs.Cynosdb.GetDescribeInstanceSlowQueriesBinlog[];
    readonly clusterId: string;
    readonly endTime?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * Earliest transaction time.
     */
    readonly startTime?: string;
}

export function getDescribeInstanceSlowQueriesOutput(args: GetDescribeInstanceSlowQueriesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDescribeInstanceSlowQueriesResult> {
    return pulumi.output(args).apply(a => getDescribeInstanceSlowQueries(a, opts))
}

/**
 * A collection of arguments for invoking getDescribeInstanceSlowQueries.
 */
export interface GetDescribeInstanceSlowQueriesOutputArgs {
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * End time.
     */
    endTime?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * start time.
     */
    startTime?: pulumi.Input<string>;
}