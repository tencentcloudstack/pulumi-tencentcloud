// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of monitor alarmHistory
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const alarmHistory = tencentcloud.Monitor.getAlarmHistory({
 *     content: "CPU利用率 > 3%",
 *     endTime: 1697212799,
 *     module: "monitor",
 *     monitorTypes: ["MT_QCE"],
 *     namespaces: [{
 *         monitorType: "CpuUsage",
 *         namespace: "cvm_device",
 *     }],
 *     order: "DESC",
 *     policyIds: ["policy-iejtp4ue"],
 *     policyName: "terraform_test",
 *     projectIds: [0],
 *     startTime: 1696608000,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAlarmHistory(args: GetAlarmHistoryArgs, opts?: pulumi.InvokeOptions): Promise<GetAlarmHistoryResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Monitor/getAlarmHistory:getAlarmHistory", {
        "alarmLevels": args.alarmLevels,
        "alarmObject": args.alarmObject,
        "alarmStatuses": args.alarmStatuses,
        "content": args.content,
        "endTime": args.endTime,
        "instanceGroupIds": args.instanceGroupIds,
        "metricNames": args.metricNames,
        "module": args.module,
        "monitorTypes": args.monitorTypes,
        "namespaces": args.namespaces,
        "order": args.order,
        "policyIds": args.policyIds,
        "policyName": args.policyName,
        "projectIds": args.projectIds,
        "receiverGroups": args.receiverGroups,
        "receiverUids": args.receiverUids,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getAlarmHistory.
 */
export interface GetAlarmHistoryArgs {
    /**
     * Alarm levels.
     */
    alarmLevels?: string[];
    /**
     * Filter by alarm object. Fuzzy search with string is supported.
     */
    alarmObject?: string;
    /**
     * Filter by alarm status. Valid values: ALARM (not resolved), OK (resolved), NO_CONF (expired), NO_DATA (insufficient data). If this parameter is left empty, all will be queried by default.
     */
    alarmStatuses?: string[];
    /**
     * Fuzzy search by alarm content.
     */
    content?: string;
    /**
     * End time, which is the current timestamp and the time when the alarm FirstOccurTime first occurs. An alarm record can be searched only if its FirstOccurTime is earlier than the EndTime.
     */
    endTime?: number;
    /**
     * Filter by instance group ID.
     */
    instanceGroupIds?: number[];
    /**
     * Filter by metric name.
     */
    metricNames?: string[];
    /**
     * Value fixed at monitor.
     */
    module: string;
    /**
     * Filter by monitor type. Valid values: MT_QCE (Tencent Cloud service monitoring), MT_TAW (application performance monitoring), MT_RUM (frontend performance monitoring), MT_PROBE (cloud automated testing). If this parameter is left empty, all types will be queried by default.
     */
    monitorTypes?: string[];
    /**
     * Filter by policy type. Monitoring type and policy type are first-level and second-level filters respectively and both need to be passed in. For example, [{MonitorType: MT_QCE, Namespace: cvm_device}].
     */
    namespaces?: inputs.Monitor.GetAlarmHistoryNamespace[];
    /**
     * Sort by the first occurrence time in descending order by default. Valid values: ASC (ascending), DESC (descending).
     */
    order?: string;
    /**
     * Search by alarm policy ID list.
     */
    policyIds?: string[];
    /**
     * Fuzzy search by policy name.
     */
    policyName?: string;
    /**
     * Filter by project ID. Valid values: -1 (no project), 0 (default project).
     */
    projectIds?: number[];
    /**
     * Search by recipient group.
     */
    receiverGroups?: number[];
    /**
     * Search by recipient.
     */
    receiverUids?: number[];
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * Start time, which is the timestamp one day ago by default and the time when the alarm FirstOccurTime first occurs. An alarm record can be searched only if its FirstOccurTime is later than the StartTime.
     */
    startTime?: number;
}

/**
 * A collection of values returned by getAlarmHistory.
 */
export interface GetAlarmHistoryResult {
    readonly alarmLevels?: string[];
    /**
     * Alarm object.
     */
    readonly alarmObject?: string;
    /**
     * Alarm status. Valid values: ALARM (not resolved), OK (resolved), NO_CONF (expired), NO_DATA (insufficient data).
     */
    readonly alarmStatuses?: string[];
    /**
     * Alarm content.
     */
    readonly content?: string;
    readonly endTime?: number;
    /**
     * Alarm record list.
     */
    readonly histories: outputs.Monitor.GetAlarmHistoryHistory[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceGroupIds?: number[];
    readonly metricNames?: string[];
    readonly module: string;
    readonly monitorTypes?: string[];
    readonly namespaces?: outputs.Monitor.GetAlarmHistoryNamespace[];
    readonly order?: string;
    readonly policyIds?: string[];
    /**
     * Policy name.
     */
    readonly policyName?: string;
    readonly projectIds?: number[];
    /**
     * Recipient group list.
     */
    readonly receiverGroups?: number[];
    /**
     * Recipient list.
     */
    readonly receiverUids?: number[];
    readonly resultOutputFile?: string;
    readonly startTime?: number;
}
/**
 * Use this data source to query detailed information of monitor alarmHistory
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const alarmHistory = tencentcloud.Monitor.getAlarmHistory({
 *     content: "CPU利用率 > 3%",
 *     endTime: 1697212799,
 *     module: "monitor",
 *     monitorTypes: ["MT_QCE"],
 *     namespaces: [{
 *         monitorType: "CpuUsage",
 *         namespace: "cvm_device",
 *     }],
 *     order: "DESC",
 *     policyIds: ["policy-iejtp4ue"],
 *     policyName: "terraform_test",
 *     projectIds: [0],
 *     startTime: 1696608000,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getAlarmHistoryOutput(args: GetAlarmHistoryOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAlarmHistoryResult> {
    return pulumi.output(args).apply((a: any) => getAlarmHistory(a, opts))
}

/**
 * A collection of arguments for invoking getAlarmHistory.
 */
export interface GetAlarmHistoryOutputArgs {
    /**
     * Alarm levels.
     */
    alarmLevels?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Filter by alarm object. Fuzzy search with string is supported.
     */
    alarmObject?: pulumi.Input<string>;
    /**
     * Filter by alarm status. Valid values: ALARM (not resolved), OK (resolved), NO_CONF (expired), NO_DATA (insufficient data). If this parameter is left empty, all will be queried by default.
     */
    alarmStatuses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Fuzzy search by alarm content.
     */
    content?: pulumi.Input<string>;
    /**
     * End time, which is the current timestamp and the time when the alarm FirstOccurTime first occurs. An alarm record can be searched only if its FirstOccurTime is earlier than the EndTime.
     */
    endTime?: pulumi.Input<number>;
    /**
     * Filter by instance group ID.
     */
    instanceGroupIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Filter by metric name.
     */
    metricNames?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Value fixed at monitor.
     */
    module: pulumi.Input<string>;
    /**
     * Filter by monitor type. Valid values: MT_QCE (Tencent Cloud service monitoring), MT_TAW (application performance monitoring), MT_RUM (frontend performance monitoring), MT_PROBE (cloud automated testing). If this parameter is left empty, all types will be queried by default.
     */
    monitorTypes?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Filter by policy type. Monitoring type and policy type are first-level and second-level filters respectively and both need to be passed in. For example, [{MonitorType: MT_QCE, Namespace: cvm_device}].
     */
    namespaces?: pulumi.Input<pulumi.Input<inputs.Monitor.GetAlarmHistoryNamespaceArgs>[]>;
    /**
     * Sort by the first occurrence time in descending order by default. Valid values: ASC (ascending), DESC (descending).
     */
    order?: pulumi.Input<string>;
    /**
     * Search by alarm policy ID list.
     */
    policyIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Fuzzy search by policy name.
     */
    policyName?: pulumi.Input<string>;
    /**
     * Filter by project ID. Valid values: -1 (no project), 0 (default project).
     */
    projectIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Search by recipient group.
     */
    receiverGroups?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Search by recipient.
     */
    receiverUids?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * Start time, which is the timestamp one day ago by default and the time when the alarm FirstOccurTime first occurs. An alarm record can be searched only if its FirstOccurTime is later than the StartTime.
     */
    startTime?: pulumi.Input<number>;
}
