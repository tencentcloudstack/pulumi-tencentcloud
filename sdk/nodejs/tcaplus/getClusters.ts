// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query TcaplusDB clusters.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const name = tencentcloud.Tcaplus.getClusters({
 *     clusterName: "cluster",
 * });
 * const id = tencentcloud.Tcaplus.getClusters({
 *     clusterId: tencentcloud_tcaplus_cluster.test.id,
 * });
 * const idname = tencentcloud.Tcaplus.getClusters({
 *     clusterId: tencentcloud_tcaplus_cluster.test.id,
 *     clusterName: "cluster",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClusters(args?: GetClustersArgs, opts?: pulumi.InvokeOptions): Promise<GetClustersResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tcaplus/getClusters:getClusters", {
        "clusterId": args.clusterId,
        "clusterName": args.clusterName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersArgs {
    /**
     * ID of the TcaplusDB cluster to be query.
     */
    clusterId?: string;
    /**
     * Name of the TcaplusDB cluster to be query.
     */
    clusterName?: string;
    /**
     * File for saving results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getClusters.
 */
export interface GetClustersResult {
    /**
     * ID of the TcaplusDB cluster.
     */
    readonly clusterId?: string;
    /**
     * Name of the TcaplusDB cluster.
     */
    readonly clusterName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of TcaplusDB cluster. Each element contains the following attributes.
     */
    readonly lists: outputs.Tcaplus.GetClustersList[];
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query TcaplusDB clusters.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const name = tencentcloud.Tcaplus.getClusters({
 *     clusterName: "cluster",
 * });
 * const id = tencentcloud.Tcaplus.getClusters({
 *     clusterId: tencentcloud_tcaplus_cluster.test.id,
 * });
 * const idname = tencentcloud.Tcaplus.getClusters({
 *     clusterId: tencentcloud_tcaplus_cluster.test.id,
 *     clusterName: "cluster",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getClustersOutput(args?: GetClustersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClustersResult> {
    return pulumi.output(args).apply((a: any) => getClusters(a, opts))
}

/**
 * A collection of arguments for invoking getClusters.
 */
export interface GetClustersOutputArgs {
    /**
     * ID of the TcaplusDB cluster to be query.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * Name of the TcaplusDB cluster to be query.
     */
    clusterName?: pulumi.Input<string>;
    /**
     * File for saving results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
