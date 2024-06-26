// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a ckafka datahubTopic
 *
 * ## Import
 *
 * ckafka datahub_topic can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Ckafka/datahubTopic:DatahubTopic datahub_topic datahub_topic_name
 * ```
 */
export class DatahubTopic extends pulumi.CustomResource {
    /**
     * Get an existing DatahubTopic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DatahubTopicState, opts?: pulumi.CustomResourceOptions): DatahubTopic {
        return new DatahubTopic(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ckafka/datahubTopic:DatahubTopic';

    /**
     * Returns true if the given object is an instance of DatahubTopic.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DatahubTopic {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DatahubTopic.__pulumiType;
    }

    /**
     * Name, start with appid, which is a string of no more than 128 characters, must start with a letter, and the rest can contain letters, numbers, and dashes (-).
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Subject note, which is a string of no more than 64 characters, must start with a letter, and the rest can contain letters, numbers and dashes (-).
     */
    public readonly note!: pulumi.Output<string | undefined>;
    /**
     * Number of Partitions, greater than 0.
     */
    public readonly partitionNum!: pulumi.Output<number>;
    /**
     * Message retention time, in ms, the current minimum value is 60000 ms.
     */
    public readonly retentionMs!: pulumi.Output<number>;
    /**
     * Tags of dataHub topic.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a DatahubTopic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatahubTopicArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DatahubTopicArgs | DatahubTopicState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DatahubTopicState | undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["note"] = state ? state.note : undefined;
            resourceInputs["partitionNum"] = state ? state.partitionNum : undefined;
            resourceInputs["retentionMs"] = state ? state.retentionMs : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as DatahubTopicArgs | undefined;
            if ((!args || args.partitionNum === undefined) && !opts.urn) {
                throw new Error("Missing required property 'partitionNum'");
            }
            if ((!args || args.retentionMs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'retentionMs'");
            }
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["note"] = args ? args.note : undefined;
            resourceInputs["partitionNum"] = args ? args.partitionNum : undefined;
            resourceInputs["retentionMs"] = args ? args.retentionMs : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DatahubTopic.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DatahubTopic resources.
 */
export interface DatahubTopicState {
    /**
     * Name, start with appid, which is a string of no more than 128 characters, must start with a letter, and the rest can contain letters, numbers, and dashes (-).
     */
    name?: pulumi.Input<string>;
    /**
     * Subject note, which is a string of no more than 64 characters, must start with a letter, and the rest can contain letters, numbers and dashes (-).
     */
    note?: pulumi.Input<string>;
    /**
     * Number of Partitions, greater than 0.
     */
    partitionNum?: pulumi.Input<number>;
    /**
     * Message retention time, in ms, the current minimum value is 60000 ms.
     */
    retentionMs?: pulumi.Input<number>;
    /**
     * Tags of dataHub topic.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a DatahubTopic resource.
 */
export interface DatahubTopicArgs {
    /**
     * Name, start with appid, which is a string of no more than 128 characters, must start with a letter, and the rest can contain letters, numbers, and dashes (-).
     */
    name?: pulumi.Input<string>;
    /**
     * Subject note, which is a string of no more than 64 characters, must start with a letter, and the rest can contain letters, numbers and dashes (-).
     */
    note?: pulumi.Input<string>;
    /**
     * Number of Partitions, greater than 0.
     */
    partitionNum: pulumi.Input<number>;
    /**
     * Message retention time, in ms, the current minimum value is 60000 ms.
     */
    retentionMs: pulumi.Input<number>;
    /**
     * Tags of dataHub topic.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}
