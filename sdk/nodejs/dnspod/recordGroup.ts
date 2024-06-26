// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dnspod recordGroup
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const recordGroup = new tencentcloud.dnspod.RecordGroup("recordGroup", {
 *     domain: "dnspod.cn",
 *     groupName: "group_demo",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * dnspod record_group can be imported using the domain#groupId, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Dnspod/recordGroup:RecordGroup record_group domain#groupId
 * ```
 */
export class RecordGroup extends pulumi.CustomResource {
    /**
     * Get an existing RecordGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RecordGroupState, opts?: pulumi.CustomResourceOptions): RecordGroup {
        return new RecordGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dnspod/recordGroup:RecordGroup';

    /**
     * Returns true if the given object is an instance of RecordGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RecordGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RecordGroup.__pulumiType;
    }

    /**
     * Domain.
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * Group ID.
     */
    public /*out*/ readonly groupId!: pulumi.Output<number>;
    /**
     * Record Group Name.
     */
    public readonly groupName!: pulumi.Output<string>;

    /**
     * Create a RecordGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RecordGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RecordGroupArgs | RecordGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RecordGroupState | undefined;
            resourceInputs["domain"] = state ? state.domain : undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["groupName"] = state ? state.groupName : undefined;
        } else {
            const args = argsOrState as RecordGroupArgs | undefined;
            if ((!args || args.domain === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domain'");
            }
            if ((!args || args.groupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupName'");
            }
            resourceInputs["domain"] = args ? args.domain : undefined;
            resourceInputs["groupName"] = args ? args.groupName : undefined;
            resourceInputs["groupId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RecordGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RecordGroup resources.
 */
export interface RecordGroupState {
    /**
     * Domain.
     */
    domain?: pulumi.Input<string>;
    /**
     * Group ID.
     */
    groupId?: pulumi.Input<number>;
    /**
     * Record Group Name.
     */
    groupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RecordGroup resource.
 */
export interface RecordGroupArgs {
    /**
     * Domain.
     */
    domain: pulumi.Input<string>;
    /**
     * Record Group Name.
     */
    groupName: pulumi.Input<string>;
}
