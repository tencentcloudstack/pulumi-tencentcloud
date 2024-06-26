// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of protocol templates.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const name = tencentcloud.Protocol.getTemplates({
 *     name: "test",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getTemplates(args?: GetTemplatesArgs, opts?: pulumi.InvokeOptions): Promise<GetTemplatesResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Protocol/getTemplates:getTemplates", {
        "id": args.id,
        "name": args.name,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getTemplates.
 */
export interface GetTemplatesArgs {
    /**
     * ID of the protocol template to query.
     */
    id?: string;
    /**
     * Name of the protocol template to query.
     */
    name?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getTemplates.
 */
export interface GetTemplatesResult {
    /**
     * ID of the protocol template.
     */
    readonly id?: string;
    /**
     * Name of protocol template.
     */
    readonly name?: string;
    readonly resultOutputFile?: string;
    /**
     * Information list of the dedicated protocol templates.
     */
    readonly templateLists: outputs.Protocol.GetTemplatesTemplateList[];
}
/**
 * Use this data source to query detailed information of protocol templates.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const name = tencentcloud.Protocol.getTemplates({
 *     name: "test",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getTemplatesOutput(args?: GetTemplatesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTemplatesResult> {
    return pulumi.output(args).apply((a: any) => getTemplates(a, opts))
}

/**
 * A collection of arguments for invoking getTemplates.
 */
export interface GetTemplatesOutputArgs {
    /**
     * ID of the protocol template to query.
     */
    id?: pulumi.Input<string>;
    /**
     * Name of the protocol template to query.
     */
    name?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
