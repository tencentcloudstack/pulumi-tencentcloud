// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of identity center groups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const identityCenterGroups = tencentcloud.Identity.getCenterGroups({
 *     zoneId: "z-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCenterGroups(args: GetCenterGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetCenterGroupsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Identity/getCenterGroups:getCenterGroups", {
        "filter": args.filter,
        "filterUsers": args.filterUsers,
        "groupType": args.groupType,
        "resultOutputFile": args.resultOutputFile,
        "sortField": args.sortField,
        "sortType": args.sortType,
        "zoneId": args.zoneId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCenterGroups.
 */
export interface GetCenterGroupsArgs {
    /**
     * Filter criterion. Format: <Attribute> <Operator> <Value>, case-insensitive. Currently, <Attribute> supports only GroupName, and <Operator> supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
     */
    filter?: string;
    /**
     * Filtered user. IsSelected=1 will be returned for the user group associated with this user.
     */
    filterUsers?: string[];
    /**
     * User group type. Manual: manually created; Synchronized: externally imported.
     */
    groupType?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
     */
    sortField?: string;
    /**
     * Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
     */
    sortType?: string;
    /**
     * Space ID.
     */
    zoneId: string;
}

/**
 * A collection of values returned by getCenterGroups.
 */
export interface GetCenterGroupsResult {
    readonly filter?: string;
    readonly filterUsers?: string[];
    readonly groupType?: string;
    /**
     * User group list.
     */
    readonly groups: outputs.Identity.GetCenterGroupsGroup[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly sortField?: string;
    readonly sortType?: string;
    readonly zoneId: string;
}
/**
 * Use this data source to query detailed information of identity center groups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const identityCenterGroups = tencentcloud.Identity.getCenterGroups({
 *     zoneId: "z-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCenterGroupsOutput(args: GetCenterGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCenterGroupsResult> {
    return pulumi.output(args).apply((a: any) => getCenterGroups(a, opts))
}

/**
 * A collection of arguments for invoking getCenterGroups.
 */
export interface GetCenterGroupsOutputArgs {
    /**
     * Filter criterion. Format: <Attribute> <Operator> <Value>, case-insensitive. Currently, <Attribute> supports only GroupName, and <Operator> supports only eq (Equals) and sw (Start With). For example, Filter = "GroupName sw test" indicates querying all user groups with names starting with test; Filter = "GroupName eq testgroup" indicates querying the user group with the name testgroup.
     */
    filter?: pulumi.Input<string>;
    /**
     * Filtered user. IsSelected=1 will be returned for the user group associated with this user.
     */
    filterUsers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * User group type. Manual: manually created; Synchronized: externally imported.
     */
    groupType?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Sorting field, which currently only supports CreateTime. The default is the CreateTime field.
     */
    sortField?: pulumi.Input<string>;
    /**
     * Sorting type. Desc: descending order; Asc: ascending order. It should be set along with SortField.
     */
    sortType?: pulumi.Input<string>;
    /**
     * Space ID.
     */
    zoneId: pulumi.Input<string>;
}
