// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query API gateway throttling services.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const service = new tencentcloud.apigateway.Service("service", {
 *     serviceName: "niceservice",
 *     protocol: "http&https",
 *     serviceDesc: "your nice service",
 *     netTypes: [
 *         "INNER",
 *         "OUTER",
 *     ],
 *     ipVersion: "IPv4",
 *     releaseLimit: 100,
 *     preLimit: 100,
 *     testLimit: 100,
 * });
 * const id = tencentcloud.ApiGateway.getThrottlingServicesOutput({
 *     serviceId: service.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getThrottlingServices(args?: GetThrottlingServicesArgs, opts?: pulumi.InvokeOptions): Promise<GetThrottlingServicesResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getThrottlingServices:getThrottlingServices", {
        "resultOutputFile": args.resultOutputFile,
        "serviceId": args.serviceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getThrottlingServices.
 */
export interface GetThrottlingServicesArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Service ID for query.
     */
    serviceId?: string;
}

/**
 * A collection of values returned by getThrottlingServices.
 */
export interface GetThrottlingServicesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of Throttling policy.
     */
    readonly lists: outputs.ApiGateway.GetThrottlingServicesList[];
    readonly resultOutputFile?: string;
    /**
     * Service ID for query.
     */
    readonly serviceId?: string;
}
/**
 * Use this data source to query API gateway throttling services.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const service = new tencentcloud.apigateway.Service("service", {
 *     serviceName: "niceservice",
 *     protocol: "http&https",
 *     serviceDesc: "your nice service",
 *     netTypes: [
 *         "INNER",
 *         "OUTER",
 *     ],
 *     ipVersion: "IPv4",
 *     releaseLimit: 100,
 *     preLimit: 100,
 *     testLimit: 100,
 * });
 * const id = tencentcloud.ApiGateway.getThrottlingServicesOutput({
 *     serviceId: service.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getThrottlingServicesOutput(args?: GetThrottlingServicesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetThrottlingServicesResult> {
    return pulumi.output(args).apply((a: any) => getThrottlingServices(a, opts))
}

/**
 * A collection of arguments for invoking getThrottlingServices.
 */
export interface GetThrottlingServicesOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Service ID for query.
     */
    serviceId?: pulumi.Input<string>;
}
