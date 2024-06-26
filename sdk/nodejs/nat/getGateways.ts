// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of NAT gateways.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Nat.getGateways({
 *     id: "nat-xfaq1",
 *     name: "main",
 *     vpcId: "vpc-xfqag",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGateways(args?: GetGatewaysArgs, opts?: pulumi.InvokeOptions): Promise<GetGatewaysResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Nat/getGateways:getGateways", {
        "id": args.id,
        "name": args.name,
        "resultOutputFile": args.resultOutputFile,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getGateways.
 */
export interface GetGatewaysArgs {
    /**
     * ID of the NAT gateway.
     */
    id?: string;
    /**
     * Name of the NAT gateway.
     */
    name?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * ID of the VPC.
     */
    vpcId?: string;
}

/**
 * A collection of values returned by getGateways.
 */
export interface GetGatewaysResult {
    /**
     * ID of the NAT gateway.
     */
    readonly id?: string;
    /**
     * Name of the NAT gateway.
     */
    readonly name?: string;
    /**
     * Information list of the dedicated NATs.
     */
    readonly nats: outputs.Nat.GetGatewaysNat[];
    readonly resultOutputFile?: string;
    /**
     * ID of the VPC.
     */
    readonly vpcId?: string;
}
/**
 * Use this data source to query detailed information of NAT gateways.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Nat.getGateways({
 *     id: "nat-xfaq1",
 *     name: "main",
 *     vpcId: "vpc-xfqag",
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
     * ID of the NAT gateway.
     */
    id?: pulumi.Input<string>;
    /**
     * Name of the NAT gateway.
     */
    name?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * ID of the VPC.
     */
    vpcId?: pulumi.Input<string>;
}
