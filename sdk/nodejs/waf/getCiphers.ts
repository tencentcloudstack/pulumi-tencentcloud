// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of waf ciphers
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = pulumi.output(tencentcloud.Waf.getCiphers());
 * ```
 */
export function getCiphers(args?: GetCiphersArgs, opts?: pulumi.InvokeOptions): Promise<GetCiphersResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Waf/getCiphers:getCiphers", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCiphers.
 */
export interface GetCiphersArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCiphers.
 */
export interface GetCiphersResult {
    /**
     * Encryption Suite InformationNote: This field may return null, indicating that a valid value cannot be obtained.
     */
    readonly ciphers: outputs.Waf.GetCiphersCipher[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getCiphersOutput(args?: GetCiphersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCiphersResult> {
    return pulumi.output(args).apply(a => getCiphers(a, opts))
}

/**
 * A collection of arguments for invoking getCiphers.
 */
export interface GetCiphersOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}