// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of dnspod domainAnalytics
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const domainAnalytics = tencentcloud.Dnspod.getDomainAnalytics({
 *     dnsFormat: "HOUR",
 *     domain: "dnspod.cn",
 *     endDate: "2023-10-12",
 *     startDate: "2023-10-07",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDomainAnalytics(args: GetDomainAnalyticsArgs, opts?: pulumi.InvokeOptions): Promise<GetDomainAnalyticsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dnspod/getDomainAnalytics:getDomainAnalytics", {
        "dnsFormat": args.dnsFormat,
        "domain": args.domain,
        "domainId": args.domainId,
        "endDate": args.endDate,
        "resultOutputFile": args.resultOutputFile,
        "startDate": args.startDate,
    }, opts);
}

/**
 * A collection of arguments for invoking getDomainAnalytics.
 */
export interface GetDomainAnalyticsArgs {
    /**
     * DATE: Statistics by day dimension HOUR: Statistics by hour dimension.
     */
    dnsFormat?: string;
    /**
     * The domain name to query for resolution volume.
     */
    domain: string;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: number;
    /**
     * The end date of the query, format: YYYY-MM-DD.
     */
    endDate: string;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * The start date of the query, format: YYYY-MM-DD.
     */
    startDate: string;
}

/**
 * A collection of values returned by getDomainAnalytics.
 */
export interface GetDomainAnalyticsResult {
    /**
     * Domain alias resolution volume statistics information.
     */
    readonly aliasDatas: outputs.Dnspod.GetDomainAnalyticsAliasData[];
    /**
     * Subtotal of resolution volume for the current statistical dimension.
     */
    readonly datas: outputs.Dnspod.GetDomainAnalyticsData[];
    /**
     * DATE: Statistics by day dimension HOUR: Statistics by hour dimension.
     */
    readonly dnsFormat?: string;
    /**
     * The domain name currently being queried.
     */
    readonly domain: string;
    readonly domainId?: number;
    /**
     * End time of the current statistical period.
     */
    readonly endDate: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * Domain resolution volume statistics query information.
     */
    readonly infos: outputs.Dnspod.GetDomainAnalyticsInfo[];
    readonly resultOutputFile?: string;
    /**
     * Start time of the current statistical period.
     */
    readonly startDate: string;
}
/**
 * Use this data source to query detailed information of dnspod domainAnalytics
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const domainAnalytics = tencentcloud.Dnspod.getDomainAnalytics({
 *     dnsFormat: "HOUR",
 *     domain: "dnspod.cn",
 *     endDate: "2023-10-12",
 *     startDate: "2023-10-07",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getDomainAnalyticsOutput(args: GetDomainAnalyticsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDomainAnalyticsResult> {
    return pulumi.output(args).apply((a: any) => getDomainAnalytics(a, opts))
}

/**
 * A collection of arguments for invoking getDomainAnalytics.
 */
export interface GetDomainAnalyticsOutputArgs {
    /**
     * DATE: Statistics by day dimension HOUR: Statistics by hour dimension.
     */
    dnsFormat?: pulumi.Input<string>;
    /**
     * The domain name to query for resolution volume.
     */
    domain: pulumi.Input<string>;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: pulumi.Input<number>;
    /**
     * The end date of the query, format: YYYY-MM-DD.
     */
    endDate: pulumi.Input<string>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * The start date of the query, format: YYYY-MM-DD.
     */
    startDate: pulumi.Input<string>;
}
