// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf groups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const groups = tencentcloud.Tsf.getGroups({
 *     applicationId: "application-a24x29xv",
 *     clusterId: "cluster-vwgj5e6y",
 *     groupIdLists: ["group-yrjkln9v"],
 *     groupResourceTypeLists: ["DEF"],
 *     namespaceId: "namespace-aemrg36v",
 *     orderBy: "createTime",
 *     orderType: 0,
 *     searchWord: "keep",
 *     status: "Running",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGroups(args?: GetGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetGroupsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tsf/getGroups:getGroups", {
        "applicationId": args.applicationId,
        "clusterId": args.clusterId,
        "groupIdLists": args.groupIdLists,
        "groupResourceTypeLists": args.groupResourceTypeLists,
        "namespaceId": args.namespaceId,
        "orderBy": args.orderBy,
        "orderType": args.orderType,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getGroups.
 */
export interface GetGroupsArgs {
    /**
     * applicationId.
     */
    applicationId?: string;
    /**
     * clusterId.
     */
    clusterId?: string;
    /**
     * group Id list.
     */
    groupIdLists?: string[];
    /**
     * Group resourceType list.
     */
    groupResourceTypeLists?: string[];
    /**
     * namespace Id.
     */
    namespaceId?: string;
    /**
     * sort term.
     */
    orderBy?: string;
    /**
     * order type, 0 desc, 1 asc.
     */
    orderType?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * searchWord, support groupName.
     */
    searchWord?: string;
    /**
     * group status filter, `Running`: running, `Unknown`: unknown.
     */
    status?: string;
}

/**
 * A collection of values returned by getGroups.
 */
export interface GetGroupsResult {
    /**
     * Application ID. Note: This field may return null, indicating that no valid value was found.
     */
    readonly applicationId?: string;
    /**
     * Cluster ID. Note: This field may return null, indicating that no valid value was found.
     */
    readonly clusterId?: string;
    readonly groupIdLists?: string[];
    readonly groupResourceTypeLists?: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Namespace ID. Note: This field may return null, indicating that no valid value was found.
     */
    readonly namespaceId?: string;
    readonly orderBy?: string;
    readonly orderType?: number;
    readonly resultOutputFile?: string;
    /**
     * Pagination information of the virtual machine deployment group.Note: This field may return null, indicating that no valid value was found.
     */
    readonly results: outputs.Tsf.GetGroupsResult[];
    readonly searchWord?: string;
    readonly status?: string;
}
/**
 * Use this data source to query detailed information of tsf groups
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const groups = tencentcloud.Tsf.getGroups({
 *     applicationId: "application-a24x29xv",
 *     clusterId: "cluster-vwgj5e6y",
 *     groupIdLists: ["group-yrjkln9v"],
 *     groupResourceTypeLists: ["DEF"],
 *     namespaceId: "namespace-aemrg36v",
 *     orderBy: "createTime",
 *     orderType: 0,
 *     searchWord: "keep",
 *     status: "Running",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getGroupsOutput(args?: GetGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetGroupsResult> {
    return pulumi.output(args).apply((a: any) => getGroups(a, opts))
}

/**
 * A collection of arguments for invoking getGroups.
 */
export interface GetGroupsOutputArgs {
    /**
     * applicationId.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * clusterId.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * group Id list.
     */
    groupIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Group resourceType list.
     */
    groupResourceTypeLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * namespace Id.
     */
    namespaceId?: pulumi.Input<string>;
    /**
     * sort term.
     */
    orderBy?: pulumi.Input<string>;
    /**
     * order type, 0 desc, 1 asc.
     */
    orderType?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * searchWord, support groupName.
     */
    searchWord?: pulumi.Input<string>;
    /**
     * group status filter, `Running`: running, `Unknown`: unknown.
     */
    status?: pulumi.Input<string>;
}
