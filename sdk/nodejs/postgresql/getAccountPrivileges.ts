// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of postgresql account privileges
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Postgresql.getAccountPrivileges({
 *     databaseObjectSets: [{
 *         objectName: "postgres",
 *         objectType: "database",
 *     }],
 *     dbInstanceId: "postgres-3hk6b6tj",
 *     userName: "tf_example",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccountPrivileges(args: GetAccountPrivilegesArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountPrivilegesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getAccountPrivileges:getAccountPrivileges", {
        "databaseObjectSets": args.databaseObjectSets,
        "dbInstanceId": args.dbInstanceId,
        "resultOutputFile": args.resultOutputFile,
        "userName": args.userName,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccountPrivileges.
 */
export interface GetAccountPrivilegesArgs {
    /**
     * Instance database object info.
     */
    databaseObjectSets: inputs.Postgresql.GetAccountPrivilegesDatabaseObjectSet[];
    /**
     * Instance ID.
     */
    dbInstanceId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Instance username.
     */
    userName: string;
}

/**
 * A collection of values returned by getAccountPrivileges.
 */
export interface GetAccountPrivilegesResult {
    readonly databaseObjectSets: outputs.Postgresql.GetAccountPrivilegesDatabaseObjectSet[];
    readonly dbInstanceId: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Privileges the specific account has on database object. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly privilegeSets: outputs.Postgresql.GetAccountPrivilegesPrivilegeSet[];
    readonly resultOutputFile?: string;
    readonly userName: string;
}
/**
 * Use this data source to query detailed information of postgresql account privileges
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Postgresql.getAccountPrivileges({
 *     databaseObjectSets: [{
 *         objectName: "postgres",
 *         objectType: "database",
 *     }],
 *     dbInstanceId: "postgres-3hk6b6tj",
 *     userName: "tf_example",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAccountPrivilegesOutput(args: GetAccountPrivilegesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountPrivilegesResult> {
    return pulumi.output(args).apply((a: any) => getAccountPrivileges(a, opts))
}

/**
 * A collection of arguments for invoking getAccountPrivileges.
 */
export interface GetAccountPrivilegesOutputArgs {
    /**
     * Instance database object info.
     */
    databaseObjectSets: pulumi.Input<pulumi.Input<inputs.Postgresql.GetAccountPrivilegesDatabaseObjectSetArgs>[]>;
    /**
     * Instance ID.
     */
    dbInstanceId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Instance username.
     */
    userName: pulumi.Input<string>;
}
