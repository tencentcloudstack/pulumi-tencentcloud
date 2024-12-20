// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getRoleDetail(args?: GetRoleDetailArgs, opts?: pulumi.InvokeOptions): Promise<GetRoleDetailResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cam/getRoleDetail:getRoleDetail", {
        "resultOutputFile": args.resultOutputFile,
        "roleId": args.roleId,
        "roleName": args.roleName,
    }, opts);
}

/**
 * A collection of arguments for invoking getRoleDetail.
 */
export interface GetRoleDetailArgs {
    resultOutputFile?: string;
    roleId?: string;
    roleName?: string;
}

/**
 * A collection of values returned by getRoleDetail.
 */
export interface GetRoleDetailResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly roleId?: string;
    readonly roleInfos: outputs.Cam.GetRoleDetailRoleInfo[];
    readonly roleName?: string;
}
export function getRoleDetailOutput(args?: GetRoleDetailOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRoleDetailResult> {
    return pulumi.output(args).apply((a: any) => getRoleDetail(a, opts))
}

/**
 * A collection of arguments for invoking getRoleDetail.
 */
export interface GetRoleDetailOutputArgs {
    resultOutputFile?: pulumi.Input<string>;
    roleId?: pulumi.Input<string>;
    roleName?: pulumi.Input<string>;
}
