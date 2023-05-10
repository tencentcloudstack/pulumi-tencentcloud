// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of cynosdb accounts
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const accounts = pulumi.output(tencentcloud.Cynosdb.getAccounts({
 *     accountNames: ["root"],
 *     clusterId: "cynosdbmysql-bws8h88b",
 * }));
 * ```
 */
export function getAccounts(args: GetAccountsArgs, opts?: pulumi.InvokeOptions): Promise<GetAccountsResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getAccounts:getAccounts", {
        "accountNames": args.accountNames,
        "clusterId": args.clusterId,
        "hosts": args.hosts,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccounts.
 */
export interface GetAccountsArgs {
    /**
     * List of accounts to be filtered.
     */
    accountNames?: string[];
    /**
     * The ID of cluster.
     */
    clusterId: string;
    /**
     * List of hosts to be filtered.
     */
    hosts?: string[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getAccounts.
 */
export interface GetAccountsResult {
    readonly accountNames?: string[];
    /**
     * Database account list.&amp;quot;&amp;quot;Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly accountSets: outputs.Cynosdb.GetAccountsAccountSet[];
    readonly clusterId: string;
    readonly hosts?: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}

export function getAccountsOutput(args: GetAccountsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccountsResult> {
    return pulumi.output(args).apply(a => getAccounts(a, opts))
}

/**
 * A collection of arguments for invoking getAccounts.
 */
export interface GetAccountsOutputArgs {
    /**
     * List of accounts to be filtered.
     */
    accountNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of cluster.
     */
    clusterId: pulumi.Input<string>;
    /**
     * List of hosts to be filtered.
     */
    hosts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}