// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tsf applicationPublicConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const applicationPublicConfig = tencentcloud.Tsf.getApplicationPublicConfig({
 *     configId: "dcfg-p-evjrbgly",
 *     configName: "dsadsa",
 *     configVersion: "123",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApplicationPublicConfig(args?: GetApplicationPublicConfigArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationPublicConfigResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tsf/getApplicationPublicConfig:getApplicationPublicConfig", {
        "configId": args.configId,
        "configIdLists": args.configIdLists,
        "configName": args.configName,
        "configVersion": args.configVersion,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getApplicationPublicConfig.
 */
export interface GetApplicationPublicConfigArgs {
    /**
     * Config ID. Query all items if not passed, high priority.
     */
    configId?: string;
    /**
     * Config ID list. Query all items if not passed, low priority.
     */
    configIdLists?: string[];
    /**
     * Config name. Exact query. Query all items if not passed.
     */
    configName?: string;
    /**
     * Config version. Exact query. Query all items if not passed.
     */
    configVersion?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getApplicationPublicConfig.
 */
export interface GetApplicationPublicConfigResult {
    /**
     * Config ID. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly configId?: string;
    readonly configIdLists?: string[];
    /**
     * Config name. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly configName?: string;
    /**
     * Config version. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly configVersion?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    /**
     * Paginated global configuration  list. Note: This field may return null, indicating that no valid value can be obtained.
     */
    readonly results: outputs.Tsf.GetApplicationPublicConfigResult[];
}
/**
 * Use this data source to query detailed information of tsf applicationPublicConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const applicationPublicConfig = tencentcloud.Tsf.getApplicationPublicConfig({
 *     configId: "dcfg-p-evjrbgly",
 *     configName: "dsadsa",
 *     configVersion: "123",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getApplicationPublicConfigOutput(args?: GetApplicationPublicConfigOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApplicationPublicConfigResult> {
    return pulumi.output(args).apply((a: any) => getApplicationPublicConfig(a, opts))
}

/**
 * A collection of arguments for invoking getApplicationPublicConfig.
 */
export interface GetApplicationPublicConfigOutputArgs {
    /**
     * Config ID. Query all items if not passed, high priority.
     */
    configId?: pulumi.Input<string>;
    /**
     * Config ID list. Query all items if not passed, low priority.
     */
    configIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Config name. Exact query. Query all items if not passed.
     */
    configName?: pulumi.Input<string>;
    /**
     * Config version. Exact query. Query all items if not passed.
     */
    configVersion?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
