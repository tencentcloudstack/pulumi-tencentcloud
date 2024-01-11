// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tse gatewayRoutes
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const gatewayRoutes = pulumi.output(tencentcloud.Tse.getGatewayRoutes({
 *     gatewayId: "gateway-ddbb709b",
 *     routeName: "keep-routes",
 *     serviceName: "test",
 * }));
 * ```
 */
export function getGatewayRoutes(args: GetGatewayRoutesArgs, opts?: pulumi.InvokeOptions): Promise<GetGatewayRoutesResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Tse/getGatewayRoutes:getGatewayRoutes", {
        "gatewayId": args.gatewayId,
        "resultOutputFile": args.resultOutputFile,
        "routeName": args.routeName,
        "serviceName": args.serviceName,
    }, opts);
}

/**
 * A collection of arguments for invoking getGatewayRoutes.
 */
export interface GetGatewayRoutesArgs {
    /**
     * gateway ID.
     */
    gatewayId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * route name.
     */
    routeName?: string;
    /**
     * service name.
     */
    serviceName?: string;
}

/**
 * A collection of values returned by getGatewayRoutes.
 */
export interface GetGatewayRoutesResult {
    readonly gatewayId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * result.
     */
    readonly results: outputs.Tse.GetGatewayRoutesResult[];
    readonly routeName?: string;
    /**
     * service name.
     */
    readonly serviceName?: string;
}

export function getGatewayRoutesOutput(args: GetGatewayRoutesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGatewayRoutesResult> {
    return pulumi.output(args).apply(a => getGatewayRoutes(a, opts))
}

/**
 * A collection of arguments for invoking getGatewayRoutes.
 */
export interface GetGatewayRoutesOutputArgs {
    /**
     * gateway ID.
     */
    gatewayId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * route name.
     */
    routeName?: pulumi.Input<string>;
    /**
     * service name.
     */
    serviceName?: pulumi.Input<string>;
}