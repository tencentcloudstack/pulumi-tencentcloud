// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of vpc accountAttributes
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accountAttributes = pulumi.output(tencentcloud.Vpc.getAccountAttributes());
 * ```
 */
export function getAccountAttributes(args?: GetAccountAttributesArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountAttributesResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Vpc/getAccountAttributes:getAccountAttributes", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccountAttributes.
 */
export interface GetAccountAttributesArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAccountAttributes.
 */
export interface GetAccountAttributesResult {
    /**
     * User account attribute object.
     */
    readonly accountAttributeSets: outputs.Vpc.GetAccountAttributesAccountAttributeSet[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getAccountAttributesOutput(args?: GetAccountAttributesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountAttributesResult> {
    return pulumi.output(args).apply(a => getAccountAttributes(a, opts))
}

/**
 * A collection of arguments for invoking getAccountAttributes.
 */
export interface GetAccountAttributesOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}