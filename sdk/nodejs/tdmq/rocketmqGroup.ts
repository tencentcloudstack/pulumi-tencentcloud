// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tdmqRocketmq group
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pulumi from "@tencentcloud_iac/pulumi";
 *
 * const cluster = new tencentcloud.tdmq.RocketmqCluster("cluster", {
 *     clusterName: "test_rocketmq",
 *     remark: "test recket mq",
 * });
 * const namespace = new tencentcloud.tdmq.RocketmqNamespace("namespace", {
 *     clusterId: cluster.clusterId,
 *     namespaceName: "test_namespace",
 *     ttl: 65000,
 *     retentionTime: 65000,
 *     remark: "test namespace",
 * });
 * const group = new tencentcloud.tdmq.RocketmqGroup("group", {
 *     groupName: "test_rocketmq_group",
 *     namespace: namespace.namespaceName,
 *     readEnable: true,
 *     broadcastEnable: true,
 *     clusterId: cluster.clusterId,
 *     remark: "test rocketmq group",
 * });
 * ```
 *
 * ## Import
 *
 * tdmqRocketmq group can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Tdmq/rocketmqGroup:RocketmqGroup group group_id
 * ```
 */
export class RocketmqGroup extends pulumi.CustomResource {
    /**
     * Get an existing RocketmqGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RocketmqGroupState, opts?: pulumi.CustomResourceOptions): RocketmqGroup {
        return new RocketmqGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tdmq/rocketmqGroup:RocketmqGroup';

    /**
     * Returns true if the given object is an instance of RocketmqGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RocketmqGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RocketmqGroup.__pulumiType;
    }

    /**
     * Whether to enable broadcast consumption.
     */
    public readonly broadcastEnable!: pulumi.Output<boolean>;
    /**
     * Client protocol.
     */
    public /*out*/ readonly clientProtocol!: pulumi.Output<string>;
    /**
     * Cluster ID.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The number of online consumers.
     */
    public /*out*/ readonly consumerNum!: pulumi.Output<number>;
    /**
     * Consumer type. Enumerated values: ACTIVELY or PASSIVELY.
     */
    public /*out*/ readonly consumerType!: pulumi.Output<string>;
    /**
     * `0`: Cluster consumption mode; `1`: Broadcast consumption mode; `-1`: Unknown.
     */
    public /*out*/ readonly consumptionMode!: pulumi.Output<number>;
    /**
     * Creation time in milliseconds.
     */
    public /*out*/ readonly createTime!: pulumi.Output<number>;
    /**
     * Group name (8-64 characters).
     */
    public readonly groupName!: pulumi.Output<string>;
    /**
     * Namespace. Currently, only one namespace is supported.
     */
    public readonly namespace!: pulumi.Output<string>;
    /**
     * Whether to enable consumption.
     */
    public readonly readEnable!: pulumi.Output<boolean>;
    /**
     * Remarks (up to 128 characters).
     */
    public readonly remark!: pulumi.Output<string | undefined>;
    /**
     * The number of partitions in a retry topic.
     */
    public /*out*/ readonly retryPartitionNum!: pulumi.Output<number>;
    /**
     * The total number of heaped messages.
     */
    public /*out*/ readonly totalAccumulative!: pulumi.Output<number>;
    /**
     * Consumption TPS.
     */
    public /*out*/ readonly tps!: pulumi.Output<number>;
    /**
     * Modification time in milliseconds.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<number>;

    /**
     * Create a RocketmqGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RocketmqGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RocketmqGroupArgs | RocketmqGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RocketmqGroupState | undefined;
            resourceInputs["broadcastEnable"] = state ? state.broadcastEnable : undefined;
            resourceInputs["clientProtocol"] = state ? state.clientProtocol : undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["consumerNum"] = state ? state.consumerNum : undefined;
            resourceInputs["consumerType"] = state ? state.consumerType : undefined;
            resourceInputs["consumptionMode"] = state ? state.consumptionMode : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["groupName"] = state ? state.groupName : undefined;
            resourceInputs["namespace"] = state ? state.namespace : undefined;
            resourceInputs["readEnable"] = state ? state.readEnable : undefined;
            resourceInputs["remark"] = state ? state.remark : undefined;
            resourceInputs["retryPartitionNum"] = state ? state.retryPartitionNum : undefined;
            resourceInputs["totalAccumulative"] = state ? state.totalAccumulative : undefined;
            resourceInputs["tps"] = state ? state.tps : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as RocketmqGroupArgs | undefined;
            if ((!args || args.broadcastEnable === undefined) && !opts.urn) {
                throw new Error("Missing required property 'broadcastEnable'");
            }
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.groupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupName'");
            }
            if ((!args || args.namespace === undefined) && !opts.urn) {
                throw new Error("Missing required property 'namespace'");
            }
            if ((!args || args.readEnable === undefined) && !opts.urn) {
                throw new Error("Missing required property 'readEnable'");
            }
            resourceInputs["broadcastEnable"] = args ? args.broadcastEnable : undefined;
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["groupName"] = args ? args.groupName : undefined;
            resourceInputs["namespace"] = args ? args.namespace : undefined;
            resourceInputs["readEnable"] = args ? args.readEnable : undefined;
            resourceInputs["remark"] = args ? args.remark : undefined;
            resourceInputs["clientProtocol"] = undefined /*out*/;
            resourceInputs["consumerNum"] = undefined /*out*/;
            resourceInputs["consumerType"] = undefined /*out*/;
            resourceInputs["consumptionMode"] = undefined /*out*/;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["retryPartitionNum"] = undefined /*out*/;
            resourceInputs["totalAccumulative"] = undefined /*out*/;
            resourceInputs["tps"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RocketmqGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RocketmqGroup resources.
 */
export interface RocketmqGroupState {
    /**
     * Whether to enable broadcast consumption.
     */
    broadcastEnable?: pulumi.Input<boolean>;
    /**
     * Client protocol.
     */
    clientProtocol?: pulumi.Input<string>;
    /**
     * Cluster ID.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * The number of online consumers.
     */
    consumerNum?: pulumi.Input<number>;
    /**
     * Consumer type. Enumerated values: ACTIVELY or PASSIVELY.
     */
    consumerType?: pulumi.Input<string>;
    /**
     * `0`: Cluster consumption mode; `1`: Broadcast consumption mode; `-1`: Unknown.
     */
    consumptionMode?: pulumi.Input<number>;
    /**
     * Creation time in milliseconds.
     */
    createTime?: pulumi.Input<number>;
    /**
     * Group name (8-64 characters).
     */
    groupName?: pulumi.Input<string>;
    /**
     * Namespace. Currently, only one namespace is supported.
     */
    namespace?: pulumi.Input<string>;
    /**
     * Whether to enable consumption.
     */
    readEnable?: pulumi.Input<boolean>;
    /**
     * Remarks (up to 128 characters).
     */
    remark?: pulumi.Input<string>;
    /**
     * The number of partitions in a retry topic.
     */
    retryPartitionNum?: pulumi.Input<number>;
    /**
     * The total number of heaped messages.
     */
    totalAccumulative?: pulumi.Input<number>;
    /**
     * Consumption TPS.
     */
    tps?: pulumi.Input<number>;
    /**
     * Modification time in milliseconds.
     */
    updateTime?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a RocketmqGroup resource.
 */
export interface RocketmqGroupArgs {
    /**
     * Whether to enable broadcast consumption.
     */
    broadcastEnable: pulumi.Input<boolean>;
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * Group name (8-64 characters).
     */
    groupName: pulumi.Input<string>;
    /**
     * Namespace. Currently, only one namespace is supported.
     */
    namespace: pulumi.Input<string>;
    /**
     * Whether to enable consumption.
     */
    readEnable: pulumi.Input<boolean>;
    /**
     * Remarks (up to 128 characters).
     */
    remark?: pulumi.Input<string>;
}