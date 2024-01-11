// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of ssl describeHostLiveInstanceList
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const describeHostLiveInstanceList = pulumi.output(tencentcloud.Ssl.getDescribeHostLiveInstanceList({
 *     certificateId: "8u8DII0l",
 *     resourceType: "live",
 * }));
 * ```
 */
export function getDescribeHostLiveInstanceList(args: GetDescribeHostLiveInstanceListArgs, opts?: pulumi.InvokeOptions): Promise<GetDescribeHostLiveInstanceListResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Ssl/getDescribeHostLiveInstanceList:getDescribeHostLiveInstanceList", {
        "certificateId": args.certificateId,
        "filters": args.filters,
        "isCache": args.isCache,
        "oldCertificateId": args.oldCertificateId,
        "resourceType": args.resourceType,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDescribeHostLiveInstanceList.
 */
export interface GetDescribeHostLiveInstanceListArgs {
    /**
     * Certificate ID to be deployed.
     */
    certificateId: string;
    /**
     * List of filtering parameters; Filterkey: domainmatch.
     */
    filters?: inputs.Ssl.GetDescribeHostLiveInstanceListFilter[];
    /**
     * Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
     */
    isCache?: number;
    /**
     * Deployed certificate ID.
     */
    oldCertificateId?: string;
    /**
     * Deploy resource type.
     */
    resourceType: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDescribeHostLiveInstanceList.
 */
export interface GetDescribeHostLiveInstanceListResult {
    readonly certificateId: string;
    readonly filters?: outputs.Ssl.GetDescribeHostLiveInstanceListFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Live instance listNote: This field may return NULL, indicating that the valid value cannot be obtained.
     */
    readonly instanceLists: outputs.Ssl.GetDescribeHostLiveInstanceListInstanceList[];
    readonly isCache?: number;
    readonly oldCertificateId?: string;
    readonly resourceType: string;
    readonly resultOutputFile?: string;
}

export function getDescribeHostLiveInstanceListOutput(args: GetDescribeHostLiveInstanceListOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDescribeHostLiveInstanceListResult> {
    return pulumi.output(args).apply(a => getDescribeHostLiveInstanceList(a, opts))
}

/**
 * A collection of arguments for invoking getDescribeHostLiveInstanceList.
 */
export interface GetDescribeHostLiveInstanceListOutputArgs {
    /**
     * Certificate ID to be deployed.
     */
    certificateId: pulumi.Input<string>;
    /**
     * List of filtering parameters; Filterkey: domainmatch.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Ssl.GetDescribeHostLiveInstanceListFilterArgs>[]>;
    /**
     * Whether to query the cache, 1: Yes; 0: No, the default is the query cache, the cache is half an hour.
     */
    isCache?: pulumi.Input<number>;
    /**
     * Deployed certificate ID.
     */
    oldCertificateId?: pulumi.Input<string>;
    /**
     * Deploy resource type.
     */
    resourceType: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}