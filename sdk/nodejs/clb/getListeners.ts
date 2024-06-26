// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of CLB listener
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Clb.getListeners({
 *     clbId: "lb-k2zjp9lv",
 *     listenerId: "lbl-mwr6vbtv",
 *     port: 80,
 *     protocol: "TCP",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getListeners(args: GetListenersArgs, opts?: pulumi.InvokeOptions): Promise<GetListenersResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Clb/getListeners:getListeners", {
        "clbId": args.clbId,
        "listenerId": args.listenerId,
        "port": args.port,
        "protocol": args.protocol,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getListeners.
 */
export interface GetListenersArgs {
    /**
     * Id of the CLB to be queried.
     */
    clbId: string;
    /**
     * Id of the listener to be queried.
     */
    listenerId?: string;
    /**
     * Port of the CLB listener.
     */
    port?: number;
    /**
     * Type of protocol within the listener, and available values are `TCP`, `UDP`, `HTTP`, `HTTPS` and `TCP_SSL`.
     */
    protocol?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getListeners.
 */
export interface GetListenersResult {
    /**
     * ID of the CLB.
     */
    readonly clbId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * ID of the listener.
     */
    readonly listenerId?: string;
    /**
     * A list of listeners of cloud load balancers. Each element contains the following attributes:
     */
    readonly listenerLists: outputs.Clb.GetListenersListenerList[];
    /**
     * Port of the CLB listener.
     */
    readonly port?: number;
    /**
     * Protocol of the listener. Available values are `HTTP`, `HTTPS`, `TCP`, `UDP`, `TCP_SSL`.
     */
    readonly protocol?: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of CLB listener
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Clb.getListeners({
 *     clbId: "lb-k2zjp9lv",
 *     listenerId: "lbl-mwr6vbtv",
 *     port: 80,
 *     protocol: "TCP",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getListenersOutput(args: GetListenersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetListenersResult> {
    return pulumi.output(args).apply((a: any) => getListeners(a, opts))
}

/**
 * A collection of arguments for invoking getListeners.
 */
export interface GetListenersOutputArgs {
    /**
     * Id of the CLB to be queried.
     */
    clbId: pulumi.Input<string>;
    /**
     * Id of the listener to be queried.
     */
    listenerId?: pulumi.Input<string>;
    /**
     * Port of the CLB listener.
     */
    port?: pulumi.Input<number>;
    /**
     * Type of protocol within the listener, and available values are `TCP`, `UDP`, `HTTP`, `HTTPS` and `TCP_SSL`.
     */
    protocol?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
