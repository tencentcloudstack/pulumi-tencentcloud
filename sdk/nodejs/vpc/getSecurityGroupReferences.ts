// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of vpc securityGroupReferences
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const securityGroupReferences = tencentcloud.Vpc.getSecurityGroupReferences({
 *     securityGroupIds: ["sg-edmur627"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSecurityGroupReferences(args: GetSecurityGroupReferencesArgs, opts?: pulumi.InvokeOptions): Promise<GetSecurityGroupReferencesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Vpc/getSecurityGroupReferences:getSecurityGroupReferences", {
        "resultOutputFile": args.resultOutputFile,
        "securityGroupIds": args.securityGroupIds,
    }, opts);
}

/**
 * A collection of arguments for invoking getSecurityGroupReferences.
 */
export interface GetSecurityGroupReferencesArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * A set of security group instance IDs, e.g. [sg-12345678].
     */
    securityGroupIds: string[];
}

/**
 * A collection of values returned by getSecurityGroupReferences.
 */
export interface GetSecurityGroupReferencesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Referred security groups.
     */
    readonly referredSecurityGroupSets: outputs.Vpc.GetSecurityGroupReferencesReferredSecurityGroupSet[];
    readonly resultOutputFile?: string;
    readonly securityGroupIds: string[];
}
/**
 * Use this data source to query detailed information of vpc securityGroupReferences
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const securityGroupReferences = tencentcloud.Vpc.getSecurityGroupReferences({
 *     securityGroupIds: ["sg-edmur627"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSecurityGroupReferencesOutput(args: GetSecurityGroupReferencesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSecurityGroupReferencesResult> {
    return pulumi.output(args).apply((a: any) => getSecurityGroupReferences(a, opts))
}

/**
 * A collection of arguments for invoking getSecurityGroupReferences.
 */
export interface GetSecurityGroupReferencesOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * A set of security group instance IDs, e.g. [sg-12345678].
     */
    securityGroupIds: pulumi.Input<pulumi.Input<string>[]>;
}
