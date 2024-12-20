// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a ckafka consumerGroup
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const consumerGroup = new tencentcloud.ckafka.ConsumerGroup("consumerGroup", {
 *     groupName: "GroupName",
 *     instanceId: "InstanceId",
 *     topicNameLists: ["xxxxxx"],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * ckafka consumer_group can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Ckafka/consumerGroup:ConsumerGroup consumer_group consumer_group_id
 * ```
 */
export class ConsumerGroup extends pulumi.CustomResource {
    /**
     * Get an existing ConsumerGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ConsumerGroupState, opts?: pulumi.CustomResourceOptions): ConsumerGroup {
        return new ConsumerGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ckafka/consumerGroup:ConsumerGroup';

    /**
     * Returns true if the given object is an instance of ConsumerGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConsumerGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConsumerGroup.__pulumiType;
    }

    /**
     * GroupName.
     */
    public readonly groupName!: pulumi.Output<string>;
    /**
     * InstanceId.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * array of topic names.
     */
    public readonly topicNameLists!: pulumi.Output<string[] | undefined>;

    /**
     * Create a ConsumerGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ConsumerGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ConsumerGroupArgs | ConsumerGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ConsumerGroupState | undefined;
            resourceInputs["groupName"] = state ? state.groupName : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["topicNameLists"] = state ? state.topicNameLists : undefined;
        } else {
            const args = argsOrState as ConsumerGroupArgs | undefined;
            if ((!args || args.groupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupName'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["groupName"] = args ? args.groupName : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["topicNameLists"] = args ? args.topicNameLists : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ConsumerGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ConsumerGroup resources.
 */
export interface ConsumerGroupState {
    /**
     * GroupName.
     */
    groupName?: pulumi.Input<string>;
    /**
     * InstanceId.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * array of topic names.
     */
    topicNameLists?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a ConsumerGroup resource.
 */
export interface ConsumerGroupArgs {
    /**
     * GroupName.
     */
    groupName: pulumi.Input<string>;
    /**
     * InstanceId.
     */
    instanceId: pulumi.Input<string>;
    /**
     * array of topic names.
     */
    topicNameLists?: pulumi.Input<pulumi.Input<string>[]>;
}
