// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of gaap proxy detail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyDetail = tencentcloud.Gaap.getProxyDetail({
 *     proxyId: "link-m9t4yho9",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyDetail(args: GetProxyDetailArgs, opts?: pulumi.InvokeOptions): Promise<GetProxyDetailResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Gaap/getProxyDetail:getProxyDetail", {
        "proxyId": args.proxyId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getProxyDetail.
 */
export interface GetProxyDetailArgs {
    /**
     * Proxy Id.
     */
    proxyId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getProxyDetail.
 */
export interface GetProxyDetailResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Proxy Detail.
     */
    readonly proxyDetails: outputs.Gaap.GetProxyDetailProxyDetail[];
    /**
     * (New parameter) proxy instance ID.Note: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly proxyId: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of gaap proxy detail
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const proxyDetail = tencentcloud.Gaap.getProxyDetail({
 *     proxyId: "link-m9t4yho9",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getProxyDetailOutput(args: GetProxyDetailOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProxyDetailResult> {
    return pulumi.output(args).apply((a: any) => getProxyDetail(a, opts))
}

/**
 * A collection of arguments for invoking getProxyDetail.
 */
export interface GetProxyDetailOutputArgs {
    /**
     * Proxy Id.
     */
    proxyId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
