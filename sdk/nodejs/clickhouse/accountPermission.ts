// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a clickhouse accountPermission
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const accountPermissionAllDatabase = new tencentcloud.clickhouse.AccountPermission("accountPermissionAllDatabase", {
 *     allDatabase: true,
 *     cluster: "default_cluster",
 *     globalPrivileges: [
 *         "SELECT",
 *         "ALTER",
 *     ],
 *     instanceId: "cdwch-xxxxxx",
 *     userName: "user1",
 * });
 * const accountPermissionNotAllDatabase = new tencentcloud.clickhouse.AccountPermission("accountPermissionNotAllDatabase", {
 *     allDatabase: false,
 *     cluster: "default_cluster",
 *     databasePrivilegeLists: [{
 *         databaseName: "xxxxxx",
 *         databasePrivileges: [
 *             "SELECT",
 *             "ALTER",
 *         ],
 *     }],
 *     instanceId: "cdwch-xxxxxx",
 *     userName: "user2",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * clickhouse account_permission can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Clickhouse/accountPermission:AccountPermission account_permission ${instanceId}#${cluster}#${userName}
 * ```
 */
export class AccountPermission extends pulumi.CustomResource {
    /**
     * Get an existing AccountPermission resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountPermissionState, opts?: pulumi.CustomResourceOptions): AccountPermission {
        return new AccountPermission(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Clickhouse/accountPermission:AccountPermission';

    /**
     * Returns true if the given object is an instance of AccountPermission.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccountPermission {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccountPermission.__pulumiType;
    }

    /**
     * Whether all database tables.
     */
    public readonly allDatabase!: pulumi.Output<boolean>;
    /**
     * Cluster name.
     */
    public readonly cluster!: pulumi.Output<string>;
    /**
     * Database privilege list.
     */
    public readonly databasePrivilegeLists!: pulumi.Output<outputs.Clickhouse.AccountPermissionDatabasePrivilegeList[] | undefined>;
    /**
     * Global privileges.
     */
    public readonly globalPrivileges!: pulumi.Output<string[] | undefined>;
    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * User name.
     */
    public readonly userName!: pulumi.Output<string>;

    /**
     * Create a AccountPermission resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountPermissionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountPermissionArgs | AccountPermissionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AccountPermissionState | undefined;
            resourceInputs["allDatabase"] = state ? state.allDatabase : undefined;
            resourceInputs["cluster"] = state ? state.cluster : undefined;
            resourceInputs["databasePrivilegeLists"] = state ? state.databasePrivilegeLists : undefined;
            resourceInputs["globalPrivileges"] = state ? state.globalPrivileges : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["userName"] = state ? state.userName : undefined;
        } else {
            const args = argsOrState as AccountPermissionArgs | undefined;
            if ((!args || args.allDatabase === undefined) && !opts.urn) {
                throw new Error("Missing required property 'allDatabase'");
            }
            if ((!args || args.cluster === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cluster'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.userName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userName'");
            }
            resourceInputs["allDatabase"] = args ? args.allDatabase : undefined;
            resourceInputs["cluster"] = args ? args.cluster : undefined;
            resourceInputs["databasePrivilegeLists"] = args ? args.databasePrivilegeLists : undefined;
            resourceInputs["globalPrivileges"] = args ? args.globalPrivileges : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["userName"] = args ? args.userName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AccountPermission.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccountPermission resources.
 */
export interface AccountPermissionState {
    /**
     * Whether all database tables.
     */
    allDatabase?: pulumi.Input<boolean>;
    /**
     * Cluster name.
     */
    cluster?: pulumi.Input<string>;
    /**
     * Database privilege list.
     */
    databasePrivilegeLists?: pulumi.Input<pulumi.Input<inputs.Clickhouse.AccountPermissionDatabasePrivilegeList>[]>;
    /**
     * Global privileges.
     */
    globalPrivileges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * User name.
     */
    userName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccountPermission resource.
 */
export interface AccountPermissionArgs {
    /**
     * Whether all database tables.
     */
    allDatabase: pulumi.Input<boolean>;
    /**
     * Cluster name.
     */
    cluster: pulumi.Input<string>;
    /**
     * Database privilege list.
     */
    databasePrivilegeLists?: pulumi.Input<pulumi.Input<inputs.Clickhouse.AccountPermissionDatabasePrivilegeList>[]>;
    /**
     * Global privileges.
     */
    globalPrivileges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * User name.
     */
    userName: pulumi.Input<string>;
}
