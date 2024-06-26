// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tse gatewayCertificates
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const gatewayCertificates = tencentcloud.Tse.getGatewayCertificates({
 *     filters: [{
 *         key: "BindDomain",
 *         value: "example.com",
 *     }],
 *     gatewayId: "gateway-ddbb709b",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGatewayCertificates(args: GetGatewayCertificatesArgs, opts?: pulumi.InvokeOptions): Promise<GetGatewayCertificatesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tse/getGatewayCertificates:getGatewayCertificates", {
        "filters": args.filters,
        "gatewayId": args.gatewayId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getGatewayCertificates.
 */
export interface GetGatewayCertificatesArgs {
    /**
     * Filter conditions, valid value: `BindDomain`, `Name`.
     */
    filters?: inputs.Tse.GetGatewayCertificatesFilter[];
    /**
     * Gateway ID.
     */
    gatewayId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getGatewayCertificates.
 */
export interface GetGatewayCertificatesResult {
    readonly filters?: outputs.Tse.GetGatewayCertificatesFilter[];
    readonly gatewayId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * Result.
     */
    readonly results: outputs.Tse.GetGatewayCertificatesResult[];
}
/**
 * Use this data source to query detailed information of tse gatewayCertificates
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const gatewayCertificates = tencentcloud.Tse.getGatewayCertificates({
 *     filters: [{
 *         key: "BindDomain",
 *         value: "example.com",
 *     }],
 *     gatewayId: "gateway-ddbb709b",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGatewayCertificatesOutput(args: GetGatewayCertificatesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGatewayCertificatesResult> {
    return pulumi.output(args).apply((a: any) => getGatewayCertificates(a, opts))
}

/**
 * A collection of arguments for invoking getGatewayCertificates.
 */
export interface GetGatewayCertificatesOutputArgs {
    /**
     * Filter conditions, valid value: `BindDomain`, `Name`.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Tse.GetGatewayCertificatesFilterArgs>[]>;
    /**
     * Gateway ID.
     */
    gatewayId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
