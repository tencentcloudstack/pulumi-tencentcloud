// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf cluster
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const cluster = pulumi.output(tencentcloud.Tsf.getCluster({
 *     clusterIdLists: ["cluster-vwgj5e6y"],
 *     clusterType: "V",
 *     // search_word = ""
 *     disableProgramAuthCheck: true,
 * }));
 * ```
 */
export function getCluster(args?: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Tsf/getCluster:getCluster", {
        "clusterIdLists": args.clusterIdLists,
        "clusterType": args.clusterType,
        "disableProgramAuthCheck": args.disableProgramAuthCheck,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
    }, opts);
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterArgs {
    /**
     * Cluster ID list to be queried, if not filled in or passed, all content will be queried.
     */
    clusterIdLists?: string[];
    /**
     * The type of cluster to be queried, if left blank or not passed, all content will be queried. C: container, V: virtual machine.
     */
    clusterType?: string;
    /**
     * Whether to disable dataset authentication.
     */
    disableProgramAuthCheck?: boolean;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Filter by keywords for Cluster Id or name.
     */
    searchWord?: string;
}

/**
 * A collection of values returned by getCluster.
 */
export interface GetClusterResult {
    readonly clusterIdLists?: string[];
    /**
     * Cluster type. Note: This field may return null, indicating no valid value.
     */
    readonly clusterType?: string;
    readonly disableProgramAuthCheck?: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * TSF cluster pagination object. Note: This field may return null, indicating no valid value.
     */
    readonly results: outputs.Tsf.GetClusterResult[];
    readonly searchWord?: string;
}

export function getClusterOutput(args?: GetClusterOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterResult> {
    return pulumi.output(args).apply(a => getCluster(a, opts))
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterOutputArgs {
    /**
     * Cluster ID list to be queried, if not filled in or passed, all content will be queried.
     */
    clusterIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The type of cluster to be queried, if left blank or not passed, all content will be queried. C: container, V: virtual machine.
     */
    clusterType?: pulumi.Input<string>;
    /**
     * Whether to disable dataset authentication.
     */
    disableProgramAuthCheck?: pulumi.Input<boolean>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Filter by keywords for Cluster Id or name.
     */
    searchWord?: pulumi.Input<string>;
}