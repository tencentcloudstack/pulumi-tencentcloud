// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query the detail information of an existing autoscaling group.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asScalingGroups = tencentcloud.As.getScalingGroups({
 *     configurationId: "asc-oqio4yyj",
 *     resultOutputFile: "my_test_path",
 *     scalingGroupName: "myasgroup",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getScalingGroups(args?: GetScalingGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetScalingGroupsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:As/getScalingGroups:getScalingGroups", {
        "configurationId": args.configurationId,
        "resultOutputFile": args.resultOutputFile,
        "scalingGroupId": args.scalingGroupId,
        "scalingGroupName": args.scalingGroupName,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getScalingGroups.
 */
export interface GetScalingGroupsArgs {
    /**
     * Filter results by launch configuration ID.
     */
    configurationId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * A specified scaling group ID used to query.
     */
    scalingGroupId?: string;
    /**
     * A scaling group name used to query.
     */
    scalingGroupName?: string;
    /**
     * Tags used to query.
     */
    tags?: {[key: string]: any};
}

/**
 * A collection of values returned by getScalingGroups.
 */
export interface GetScalingGroupsResult {
    /**
     * Launch configuration ID.
     */
    readonly configurationId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * Auto scaling group ID.
     */
    readonly scalingGroupId?: string;
    /**
     * A list of scaling group. Each element contains the following attributes:
     */
    readonly scalingGroupLists: outputs.As.GetScalingGroupsScalingGroupList[];
    /**
     * Auto scaling group name.
     */
    readonly scalingGroupName?: string;
    /**
     * Tags of the scaling group.
     */
    readonly tags?: {[key: string]: any};
}
/**
 * Use this data source to query the detail information of an existing autoscaling group.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const asScalingGroups = tencentcloud.As.getScalingGroups({
 *     configurationId: "asc-oqio4yyj",
 *     resultOutputFile: "my_test_path",
 *     scalingGroupName: "myasgroup",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getScalingGroupsOutput(args?: GetScalingGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetScalingGroupsResult> {
    return pulumi.output(args).apply((a: any) => getScalingGroups(a, opts))
}

/**
 * A collection of arguments for invoking getScalingGroups.
 */
export interface GetScalingGroupsOutputArgs {
    /**
     * Filter results by launch configuration ID.
     */
    configurationId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * A specified scaling group ID used to query.
     */
    scalingGroupId?: pulumi.Input<string>;
    /**
     * A scaling group name used to query.
     */
    scalingGroupName?: pulumi.Input<string>;
    /**
     * Tags used to query.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}
