// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Use this data source to query detailed information of ckafka topicSyncReplica
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const topicSyncReplica = pulumi.output(tencentcloud.Ckafka.getTopicSyncReplica({
 *     instanceId: "ckafka-xxxxxx",
 *     topicName: "xxxxxx",
 * }));
 * ```
 */
export function getTopicSyncReplica(args: GetTopicSyncReplicaArgs, opts?: pulumi.InvokeOptions): Promise<GetTopicSyncReplicaResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("tencentcloud:Ckafka/getTopicSyncReplica:getTopicSyncReplica", {
        "instanceId": args.instanceId,
        "outOfSyncReplicaOnly": args.outOfSyncReplicaOnly,
        "resultOutputFile": args.resultOutputFile,
        "topicName": args.topicName,
    }, opts);
}

/**
 * A collection of arguments for invoking getTopicSyncReplica.
 */
export interface GetTopicSyncReplicaArgs {
    /**
     * InstanceId.
     */
    instanceId: string;
    /**
     * Filter only unsynced replicas.
     */
    outOfSyncReplicaOnly?: boolean;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * TopicName.
     */
    topicName: string;
}

/**
 * A collection of values returned by getTopicSyncReplica.
 */
export interface GetTopicSyncReplicaResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly outOfSyncReplicaOnly?: boolean;
    readonly resultOutputFile?: string;
    /**
     * Topic details and copy collection.
     */
    readonly topicInSyncReplicaLists: outputs.Ckafka.GetTopicSyncReplicaTopicInSyncReplicaList[];
    readonly topicName: string;
}

export function getTopicSyncReplicaOutput(args: GetTopicSyncReplicaOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTopicSyncReplicaResult> {
    return pulumi.output(args).apply(a => getTopicSyncReplica(a, opts))
}

/**
 * A collection of arguments for invoking getTopicSyncReplica.
 */
export interface GetTopicSyncReplicaOutputArgs {
    /**
     * InstanceId.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Filter only unsynced replicas.
     */
    outOfSyncReplicaOnly?: pulumi.Input<boolean>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * TopicName.
     */
    topicName: pulumi.Input<string>;
}