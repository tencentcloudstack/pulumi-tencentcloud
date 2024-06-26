// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dlc checkDataEngineConfigPairsValidity
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const checkDataEngineConfigPairsValidity = tencentcloud.Dlc.getCheckDataEngineConfigPairsValidity({
 *     childImageVersionId: "d3ftghd4-9a7e-4f64-a3f4-f38507c69742",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCheckDataEngineConfigPairsValidity(args?: GetCheckDataEngineConfigPairsValidityArgs, opts?: pulumi.InvokeOptions): Promise<GetCheckDataEngineConfigPairsValidityResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dlc/getCheckDataEngineConfigPairsValidity:getCheckDataEngineConfigPairsValidity", {
        "childImageVersionId": args.childImageVersionId,
        "dataEngineConfigPairs": args.dataEngineConfigPairs,
        "imageVersionId": args.imageVersionId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCheckDataEngineConfigPairsValidity.
 */
export interface GetCheckDataEngineConfigPairsValidityArgs {
    /**
     * Engine Image version id.
     */
    childImageVersionId?: string;
    /**
     * User-defined parameters.
     */
    dataEngineConfigPairs?: inputs.Dlc.GetCheckDataEngineConfigPairsValidityDataEngineConfigPair[];
    /**
     * Engine major version id. If a minor version id exists, you only need to pass in the minor version id. If it does not exist, the latest minor version id under the current major version will be obtained.
     */
    imageVersionId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCheckDataEngineConfigPairsValidity.
 */
export interface GetCheckDataEngineConfigPairsValidityResult {
    readonly childImageVersionId?: string;
    readonly dataEngineConfigPairs?: outputs.Dlc.GetCheckDataEngineConfigPairsValidityDataEngineConfigPair[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly imageVersionId?: string;
    /**
     * Parameter validity: true: valid, false: at least one invalid parameter exists.
     */
    readonly isAvailable: boolean;
    readonly resultOutputFile?: string;
    /**
     * Invalid parameter set.
     */
    readonly unavailableConfigs: string[];
}
/**
 * Use this data source to query detailed information of dlc checkDataEngineConfigPairsValidity
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const checkDataEngineConfigPairsValidity = tencentcloud.Dlc.getCheckDataEngineConfigPairsValidity({
 *     childImageVersionId: "d3ftghd4-9a7e-4f64-a3f4-f38507c69742",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCheckDataEngineConfigPairsValidityOutput(args?: GetCheckDataEngineConfigPairsValidityOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCheckDataEngineConfigPairsValidityResult> {
    return pulumi.output(args).apply((a: any) => getCheckDataEngineConfigPairsValidity(a, opts))
}

/**
 * A collection of arguments for invoking getCheckDataEngineConfigPairsValidity.
 */
export interface GetCheckDataEngineConfigPairsValidityOutputArgs {
    /**
     * Engine Image version id.
     */
    childImageVersionId?: pulumi.Input<string>;
    /**
     * User-defined parameters.
     */
    dataEngineConfigPairs?: pulumi.Input<pulumi.Input<inputs.Dlc.GetCheckDataEngineConfigPairsValidityDataEngineConfigPairArgs>[]>;
    /**
     * Engine major version id. If a minor version id exists, you only need to pass in the minor version id. If it does not exist, the latest minor version id under the current major version will be obtained.
     */
    imageVersionId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
