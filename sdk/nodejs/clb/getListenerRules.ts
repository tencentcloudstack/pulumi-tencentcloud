// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of CLB listener rule
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Clb.getListenerRules({
 *     clbId: "lb-k2zjp9lv",
 *     domain: "abc.com",
 *     listenerId: "lbl-mwr6vbtv",
 *     ruleId: "loc-inem40hz",
 *     scheduler: "WRR",
 *     url: "/",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getListenerRules(args: GetListenerRulesArgs, opts?: pulumi.InvokeOptions): Promise<GetListenerRulesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Clb/getListenerRules:getListenerRules", {
        "clbId": args.clbId,
        "domain": args.domain,
        "listenerId": args.listenerId,
        "resultOutputFile": args.resultOutputFile,
        "ruleId": args.ruleId,
        "scheduler": args.scheduler,
        "url": args.url,
    }, opts);
}

/**
 * A collection of arguments for invoking getListenerRules.
 */
export interface GetListenerRulesArgs {
    /**
     * ID of the CLB to be queried.
     */
    clbId: string;
    /**
     * Domain name of the forwarding rule to be queried.
     */
    domain?: string;
    /**
     * ID of the CLB listener to be queried.
     */
    listenerId: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * ID of the forwarding rule to be queried.
     */
    ruleId?: string;
    /**
     * Scheduling method of the forwarding rule of thr CLB listener, and available values include `WRR`, `IP HASH` and `LEAST_CONN`. The default is `WRR`.
     */
    scheduler?: string;
    /**
     * Url of the forwarding rule to be queried.
     */
    url?: string;
}

/**
 * A collection of values returned by getListenerRules.
 */
export interface GetListenerRulesResult {
    /**
     * ID of the CLB.
     */
    readonly clbId: string;
    readonly domain?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * ID of the listener.
     */
    readonly listenerId: string;
    readonly resultOutputFile?: string;
    /**
     * ID of the rule.
     */
    readonly ruleId?: string;
    /**
     * A list of forward rules of listeners. Each element contains the following attributes:
     */
    readonly ruleLists: outputs.Clb.GetListenerRulesRuleList[];
    /**
     * Scheduling method of the CLB listener, and available values include 'WRR', 'IP_HASH' and 'LEAST_CONN'. The default is 'WRR'. NOTES: TCP/UDP/TCP_SSL listener allows direct configuration, HTTP/HTTPS listener needs to be configured in tencentcloud_clb_listener_rule.
     */
    readonly scheduler?: string;
    readonly url?: string;
}
/**
 * Use this data source to query detailed information of CLB listener rule
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = tencentcloud.Clb.getListenerRules({
 *     clbId: "lb-k2zjp9lv",
 *     domain: "abc.com",
 *     listenerId: "lbl-mwr6vbtv",
 *     ruleId: "loc-inem40hz",
 *     scheduler: "WRR",
 *     url: "/",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getListenerRulesOutput(args: GetListenerRulesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetListenerRulesResult> {
    return pulumi.output(args).apply((a: any) => getListenerRules(a, opts))
}

/**
 * A collection of arguments for invoking getListenerRules.
 */
export interface GetListenerRulesOutputArgs {
    /**
     * ID of the CLB to be queried.
     */
    clbId: pulumi.Input<string>;
    /**
     * Domain name of the forwarding rule to be queried.
     */
    domain?: pulumi.Input<string>;
    /**
     * ID of the CLB listener to be queried.
     */
    listenerId: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * ID of the forwarding rule to be queried.
     */
    ruleId?: pulumi.Input<string>;
    /**
     * Scheduling method of the forwarding rule of thr CLB listener, and available values include `WRR`, `IP HASH` and `LEAST_CONN`. The default is `WRR`.
     */
    scheduler?: pulumi.Input<string>;
    /**
     * Url of the forwarding rule to be queried.
     */
    url?: pulumi.Input<string>;
}
