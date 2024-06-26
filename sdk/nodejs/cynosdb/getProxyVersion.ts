// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of cynosdb proxyVersion
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyVersion = tencentcloud.Cynosdb.getProxyVersion({
 *     clusterId: "cynosdbmysql-bws8h88b",
 *     proxyGroupId: "cynosdbmysql-proxy-l6zf9t30",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyVersion(args: GetProxyVersionArgs, opts?: pulumi.InvokeOptions): Promise<GetProxyVersionResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getProxyVersion:getProxyVersion", {
        "clusterId": args.clusterId,
        "proxyGroupId": args.proxyGroupId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getProxyVersion.
 */
export interface GetProxyVersionArgs {
    /**
     * Cluster ID.
     */
    clusterId: string;
    /**
     * Database Agent Group ID.
     */
    proxyGroupId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getProxyVersion.
 */
export interface GetProxyVersionResult {
    readonly clusterId: string;
    /**
     * Current proxy version number note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly currentProxyVersion: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly proxyGroupId?: string;
    readonly resultOutputFile?: string;
    /**
     * Supported Database Agent Version Collection Note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly supportProxyVersions: string[];
}
/**
 * Use this data source to query detailed information of cynosdb proxyVersion
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyVersion = tencentcloud.Cynosdb.getProxyVersion({
 *     clusterId: "cynosdbmysql-bws8h88b",
 *     proxyGroupId: "cynosdbmysql-proxy-l6zf9t30",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyVersionOutput(args: GetProxyVersionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProxyVersionResult> {
    return pulumi.output(args).apply((a: any) => getProxyVersion(a, opts))
}

/**
 * A collection of arguments for invoking getProxyVersion.
 */
export interface GetProxyVersionOutputArgs {
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Database Agent Group ID.
     */
    proxyGroupId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
