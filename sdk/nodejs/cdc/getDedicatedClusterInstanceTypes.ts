// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of CDC dedicated cluster instance types
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const types = tencentcloud.Cdc.getDedicatedClusterInstanceTypes({
 *     dedicatedClusterId: "cluster-262n63e8",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDedicatedClusterInstanceTypes(args: GetDedicatedClusterInstanceTypesArgs, opts?: pulumi.InvokeOptions): Promise<GetDedicatedClusterInstanceTypesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cdc/getDedicatedClusterInstanceTypes:getDedicatedClusterInstanceTypes", {
        "dedicatedClusterId": args.dedicatedClusterId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getDedicatedClusterInstanceTypes.
 */
export interface GetDedicatedClusterInstanceTypesArgs {
    /**
     * Dedicated Cluster ID.
     */
    dedicatedClusterId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getDedicatedClusterInstanceTypes.
 */
export interface GetDedicatedClusterInstanceTypesResult {
    readonly dedicatedClusterId: string;
    /**
     * Dedicated Cluster Supported InstanceType.
     */
    readonly dedicatedClusterInstanceTypeSets: outputs.Cdc.GetDedicatedClusterInstanceTypesDedicatedClusterInstanceTypeSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of CDC dedicated cluster instance types
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const types = tencentcloud.Cdc.getDedicatedClusterInstanceTypes({
 *     dedicatedClusterId: "cluster-262n63e8",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDedicatedClusterInstanceTypesOutput(args: GetDedicatedClusterInstanceTypesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDedicatedClusterInstanceTypesResult> {
    return pulumi.output(args).apply((a: any) => getDedicatedClusterInstanceTypes(a, opts))
}

/**
 * A collection of arguments for invoking getDedicatedClusterInstanceTypes.
 */
export interface GetDedicatedClusterInstanceTypesOutputArgs {
    /**
     * Dedicated Cluster ID.
     */
    dedicatedClusterId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
