// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query which instance types of Redis are available in a specific region.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = pulumi.output(tencentcloud.Cynosdb.getZoneConfig());
 * ```
 */
export function getZoneConfig(args?: GetZoneConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetZoneConfigResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getZoneConfig:getZoneConfig", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getZoneConfig.
 */
export interface GetZoneConfigArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getZoneConfig.
 */
export interface GetZoneConfigResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * A list of zone. Each element contains the following attributes:
     */
    readonly lists: outputs.Cynosdb.GetZoneConfigList[];
    readonly resultOutputFile?: string;
}

export function getZoneConfigOutput(args?: GetZoneConfigOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetZoneConfigResult> {
    return pulumi.output(args).apply(a => getZoneConfig(a, opts))
}

/**
 * A collection of arguments for invoking getZoneConfig.
 */
export interface GetZoneConfigOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}