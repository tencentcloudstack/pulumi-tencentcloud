// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tse gateways
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const gateways = tencentcloud.Tse.getGateways({
 *     filters: [{
 *         name: "GatewayId",
 *         values: ["gateway-ddbb709b"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGateways(args?: GetGatewaysArgs, opts?: pulumi.InvokeOptions): Promise<GetGatewaysResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tse/getGateways:getGateways", {
        "filters": args.filters,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getGateways.
 */
export interface GetGatewaysArgs {
    /**
     * filter conditions, valid value:Type,Name,GatewayId,Tag,TradeType,InternetPaymode,Region.
     */
    filters?: inputs.Tse.GetGatewaysFilter[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getGateways.
 */
export interface GetGatewaysResult {
    readonly filters?: outputs.Tse.GetGatewaysFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * gateways information.
     */
    readonly results: outputs.Tse.GetGatewaysResult[];
}
/**
 * Use this data source to query detailed information of tse gateways
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const gateways = tencentcloud.Tse.getGateways({
 *     filters: [{
 *         name: "GatewayId",
 *         values: ["gateway-ddbb709b"],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGatewaysOutput(args?: GetGatewaysOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGatewaysResult> {
    return pulumi.output(args).apply((a: any) => getGateways(a, opts))
}

/**
 * A collection of arguments for invoking getGateways.
 */
export interface GetGatewaysOutputArgs {
    /**
     * filter conditions, valid value:Type,Name,GatewayId,Tag,TradeType,InternetPaymode,Region.
     */
    filters?: pulumi.Input<pulumi.Input<inputs.Tse.GetGatewaysFilterArgs>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
