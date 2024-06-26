// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tse zookeeperServerInterfaces
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const zookeeperServerInterfaces = tencentcloud.Tse.getZookeeperServerInterfaces({
 *     instanceId: "ins-7eb7eea7",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getZookeeperServerInterfaces(args: GetZookeeperServerInterfacesArgs, opts?: pulumi.InvokeOptions): Promise<GetZookeeperServerInterfacesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tse/getZookeeperServerInterfaces:getZookeeperServerInterfaces", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getZookeeperServerInterfaces.
 */
export interface GetZookeeperServerInterfacesArgs {
    /**
     * engine instance ID.
     */
    instanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getZookeeperServerInterfaces.
 */
export interface GetZookeeperServerInterfacesResult {
    /**
     * interface list.
     */
    readonly contents: outputs.Tse.GetZookeeperServerInterfacesContent[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of tse zookeeperServerInterfaces
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const zookeeperServerInterfaces = tencentcloud.Tse.getZookeeperServerInterfaces({
 *     instanceId: "ins-7eb7eea7",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getZookeeperServerInterfacesOutput(args: GetZookeeperServerInterfacesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetZookeeperServerInterfacesResult> {
    return pulumi.output(args).apply((a: any) => getZookeeperServerInterfaces(a, opts))
}

/**
 * A collection of arguments for invoking getZookeeperServerInterfaces.
 */
export interface GetZookeeperServerInterfacesOutputArgs {
    /**
     * engine instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
