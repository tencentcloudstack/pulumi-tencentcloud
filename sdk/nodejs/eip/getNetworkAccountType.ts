// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of eip networkAccountType
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const networkAccountType = tencentcloud.Eip.getNetworkAccountType({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getNetworkAccountType(args?: GetNetworkAccountTypeArgs, opts?: pulumi.InvokeOptions): Promise<GetNetworkAccountTypeResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Eip/getNetworkAccountType:getNetworkAccountType", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getNetworkAccountType.
 */
export interface GetNetworkAccountTypeArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getNetworkAccountType.
 */
export interface GetNetworkAccountTypeResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * The network type of the user account, STANDARD is a standard user, LEGACY is a traditional user.
     */
    readonly networkAccountType: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of eip networkAccountType
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const networkAccountType = tencentcloud.Eip.getNetworkAccountType({});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getNetworkAccountTypeOutput(args?: GetNetworkAccountTypeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNetworkAccountTypeResult> {
    return pulumi.output(args).apply((a: any) => getNetworkAccountType(a, opts))
}

/**
 * A collection of arguments for invoking getNetworkAccountType.
 */
export interface GetNetworkAccountTypeOutputArgs {
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
