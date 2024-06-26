// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of tat command
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const command = tencentcloud.Tat.getCommand({
 *     commandType: "SHELL",
 *     createdBy: "TAT",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCommand(args?: GetCommandArgs, opts?: pulumi.InvokeOptions): Promise<GetCommandResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tat/getCommand:getCommand", {
        "commandId": args.commandId,
        "commandName": args.commandName,
        "commandType": args.commandType,
        "createdBy": args.createdBy,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCommand.
 */
export interface GetCommandArgs {
    /**
     * Command ID.
     */
    commandId?: string;
    /**
     * Command name.
     */
    commandName?: string;
    /**
     * Command type, Value is `SHELL` or `POWERSHELL`.
     */
    commandType?: string;
    /**
     * Command creator. `TAT` indicates a public command and `USER` indicates a personal command.
     */
    createdBy?: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCommand.
 */
export interface GetCommandResult {
    /**
     * Command ID.
     */
    readonly commandId?: string;
    /**
     * Command name.
     */
    readonly commandName?: string;
    /**
     * List of command details.
     */
    readonly commandSets: outputs.Tat.GetCommandCommandSet[];
    /**
     * Command type.
     */
    readonly commandType?: string;
    /**
     * Command creator. `TAT` indicates a public command and `USER` indicates a personal command.
     */
    readonly createdBy?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
/**
 * Use this data source to query detailed information of tat command
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const command = tencentcloud.Tat.getCommand({
 *     commandType: "SHELL",
 *     createdBy: "TAT",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getCommandOutput(args?: GetCommandOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCommandResult> {
    return pulumi.output(args).apply((a: any) => getCommand(a, opts))
}

/**
 * A collection of arguments for invoking getCommand.
 */
export interface GetCommandOutputArgs {
    /**
     * Command ID.
     */
    commandId?: pulumi.Input<string>;
    /**
     * Command name.
     */
    commandName?: pulumi.Input<string>;
    /**
     * Command type, Value is `SHELL` or `POWERSHELL`.
     */
    commandType?: pulumi.Input<string>;
    /**
     * Command creator. `TAT` indicates a public command and `USER` indicates a personal command.
     */
    createdBy?: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
}
