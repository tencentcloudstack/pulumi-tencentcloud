// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of identity center role configurations
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const identityCenterRoleConfigurations = tencentcloud.Identity.getCenterRoleConfigurations({
 *     zoneId: "z-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCenterRoleConfigurations(args: GetCenterRoleConfigurationsArgs, opts?: pulumi.InvokeOptions): Promise<GetCenterRoleConfigurationsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Identity/getCenterRoleConfigurations:getCenterRoleConfigurations", {
        "filter": args.filter,
        "filterTargets": args.filterTargets,
        "principalId": args.principalId,
        "resultOutputFile": args.resultOutputFile,
        "zoneId": args.zoneId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCenterRoleConfigurations.
 */
export interface GetCenterRoleConfigurationsArgs {
    /**
     * Filter criteria, which are case insensitive. Currently, only RoleConfigurationName is supported and only eq (Equals) and sw (Start With) are supported. Example: Filter = "RoleConfigurationName, only sw test" means querying all permission configurations starting with test. Filter = "RoleConfigurationName, only eq TestRoleConfiguration" means querying the permission configuration named TestRoleConfiguration.
     */
    filter?: string;
    /**
     * Check whether the member account has been configured with permissions. If configured, return IsSelected: true; otherwise, return false.
     */
    filterTargets?: number[];
    /**
     * UserId of the authorized user or GroupId of the authorized user group, which must be set together with the input parameter FilterTargets.
     */
    principalId?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Space ID.
     */
    zoneId: string;
}

/**
 * A collection of values returned by getCenterRoleConfigurations.
 */
export interface GetCenterRoleConfigurationsResult {
    readonly filter?: string;
    readonly filterTargets?: number[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly principalId?: string;
    readonly resultOutputFile?: string;
    /**
     * Permission configuration list.
     */
    readonly roleConfigurations: outputs.Identity.GetCenterRoleConfigurationsRoleConfiguration[];
    readonly zoneId: string;
}
/**
 * Use this data source to query detailed information of identity center role configurations
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const identityCenterRoleConfigurations = tencentcloud.Identity.getCenterRoleConfigurations({
 *     zoneId: "z-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCenterRoleConfigurationsOutput(args: GetCenterRoleConfigurationsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCenterRoleConfigurationsResult> {
    return pulumi.output(args).apply((a: any) => getCenterRoleConfigurations(a, opts))
}

/**
 * A collection of arguments for invoking getCenterRoleConfigurations.
 */
export interface GetCenterRoleConfigurationsOutputArgs {
    /**
     * Filter criteria, which are case insensitive. Currently, only RoleConfigurationName is supported and only eq (Equals) and sw (Start With) are supported. Example: Filter = "RoleConfigurationName, only sw test" means querying all permission configurations starting with test. Filter = "RoleConfigurationName, only eq TestRoleConfiguration" means querying the permission configuration named TestRoleConfiguration.
     */
    filter?: pulumi.Input<string>;
    /**
     * Check whether the member account has been configured with permissions. If configured, return IsSelected: true; otherwise, return false.
     */
    filterTargets?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * UserId of the authorized user or GroupId of the authorized user group, which must be set together with the input parameter FilterTargets.
     */
    principalId?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Space ID.
     */
    zoneId: pulumi.Input<string>;
}