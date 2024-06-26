// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of VOD snapshot by time offset templates.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const fooSnapshotByTimeOffsetTemplate = new tencentcloud.vod.SnapshotByTimeOffsetTemplate("fooSnapshotByTimeOffsetTemplate", {
 *     width: 130,
 *     height: 128,
 *     resolutionAdaptive: false,
 *     format: "png",
 *     comment: "test",
 *     fillType: "white",
 * });
 * const fooSnapshotByTimeOffsetTemplates = tencentcloud.Vod.getSnapshotByTimeOffsetTemplatesOutput({
 *     type: "Custom",
 *     definition: fooSnapshotByTimeOffsetTemplate.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSnapshotByTimeOffsetTemplates(args?: GetSnapshotByTimeOffsetTemplatesArgs, opts?: pulumi.InvokeOptions): Promise<GetSnapshotByTimeOffsetTemplatesResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Vod/getSnapshotByTimeOffsetTemplates:getSnapshotByTimeOffsetTemplates", {
        "definition": args.definition,
        "resultOutputFile": args.resultOutputFile,
        "subAppId": args.subAppId,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getSnapshotByTimeOffsetTemplates.
 */
export interface GetSnapshotByTimeOffsetTemplatesArgs {
    /**
     * Unique ID filter of snapshot by time offset template.
     */
    definition?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Subapplication ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
     */
    subAppId?: number;
    /**
     * Template type filter. Valid values: `Preset`, `Custom`. `Preset`: preset template; `Custom`: custom template.
     */
    type?: string;
}

/**
 * A collection of values returned by getSnapshotByTimeOffsetTemplates.
 */
export interface GetSnapshotByTimeOffsetTemplatesResult {
    /**
     * Unique ID of snapshot by time offset template.
     */
    readonly definition?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly subAppId?: number;
    /**
     * A list of snapshot by time offset templates. Each element contains the following attributes:
     */
    readonly templateLists: outputs.Vod.GetSnapshotByTimeOffsetTemplatesTemplateList[];
    /**
     * Template type filter. Valid values: `Preset`, `Custom`. `Preset`: preset template; `Custom`: custom template.
     */
    readonly type?: string;
}
/**
 * Use this data source to query detailed information of VOD snapshot by time offset templates.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const fooSnapshotByTimeOffsetTemplate = new tencentcloud.vod.SnapshotByTimeOffsetTemplate("fooSnapshotByTimeOffsetTemplate", {
 *     width: 130,
 *     height: 128,
 *     resolutionAdaptive: false,
 *     format: "png",
 *     comment: "test",
 *     fillType: "white",
 * });
 * const fooSnapshotByTimeOffsetTemplates = tencentcloud.Vod.getSnapshotByTimeOffsetTemplatesOutput({
 *     type: "Custom",
 *     definition: fooSnapshotByTimeOffsetTemplate.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSnapshotByTimeOffsetTemplatesOutput(args?: GetSnapshotByTimeOffsetTemplatesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSnapshotByTimeOffsetTemplatesResult> {
    return pulumi.output(args).apply((a: any) => getSnapshotByTimeOffsetTemplates(a, opts))
}

/**
 * A collection of arguments for invoking getSnapshotByTimeOffsetTemplates.
 */
export interface GetSnapshotByTimeOffsetTemplatesOutputArgs {
    /**
     * Unique ID filter of snapshot by time offset template.
     */
    definition?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Subapplication ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
     */
    subAppId?: pulumi.Input<number>;
    /**
     * Template type filter. Valid values: `Preset`, `Custom`. `Preset`: preset template; `Custom`: custom template.
     */
    type?: pulumi.Input<string>;
}
