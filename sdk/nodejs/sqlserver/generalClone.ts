// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a sqlserver generalCommunication
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const zones = tencentcloud.Availability.getZonesByProduct({
 *     product: "sqlserver",
 * });
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: zones.then(zones => zones.zones?.[4]?.name),
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.0.0/16",
 *     isMulticast: false,
 * });
 * const securityGroup = new tencentcloud.security.Group("securityGroup", {description: "desc."});
 * const exampleBasicInstance = new tencentcloud.sqlserver.BasicInstance("exampleBasicInstance", {
 *     availabilityZone: zones.then(zones => zones.zones?.[4]?.name),
 *     chargeType: "POSTPAID_BY_HOUR",
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     projectId: 0,
 *     memory: 4,
 *     storage: 100,
 *     cpu: 2,
 *     machineType: "CLOUD_PREMIUM",
 *     maintenanceWeekSets: [
 *         1,
 *         2,
 *         3,
 *     ],
 *     maintenanceStartTime: "09:00",
 *     maintenanceTimeSpan: 3,
 *     securityGroups: [securityGroup.id],
 *     tags: {
 *         test: "test",
 *     },
 * });
 * const exampleDb = new tencentcloud.sqlserver.Db("exampleDb", {
 *     instanceId: exampleBasicInstance.id,
 *     charset: "Chinese_PRC_BIN",
 *     remark: "test-remark",
 * });
 * const exampleGeneralClone = new tencentcloud.sqlserver.GeneralClone("exampleGeneralClone", {
 *     instanceId: exampleDb.instanceId,
 *     oldName: exampleDb.name,
 *     newName: "tf_example_db_clone",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * sqlserver general_communication can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Sqlserver/generalClone:GeneralClone example mssql-si2823jyl#tf_example_db#tf_example_db_clone
 * ```
 */
export class GeneralClone extends pulumi.CustomResource {
    /**
     * Get an existing GeneralClone resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GeneralCloneState, opts?: pulumi.CustomResourceOptions): GeneralClone {
        return new GeneralClone(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Sqlserver/generalClone:GeneralClone';

    /**
     * Returns true if the given object is an instance of GeneralClone.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GeneralClone {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GeneralClone.__pulumiType;
    }

    /**
     * Instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * New database name. In offline migration, OldName will be used if NewName is left empty (OldName and NewName cannot be both empty). In database cloning, OldName and NewName must be both specified and cannot have the same value.
     */
    public readonly newName!: pulumi.Output<string>;
    /**
     * Database name. If the OldName database does not exist, a failure will be returned. It can be left empty in offline migration tasks.
     */
    public readonly oldName!: pulumi.Output<string>;

    /**
     * Create a GeneralClone resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GeneralCloneArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GeneralCloneArgs | GeneralCloneState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as GeneralCloneState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["newName"] = state ? state.newName : undefined;
            resourceInputs["oldName"] = state ? state.oldName : undefined;
        } else {
            const args = argsOrState as GeneralCloneArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.newName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'newName'");
            }
            if ((!args || args.oldName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'oldName'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["newName"] = args ? args.newName : undefined;
            resourceInputs["oldName"] = args ? args.oldName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(GeneralClone.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GeneralClone resources.
 */
export interface GeneralCloneState {
    /**
     * Instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * New database name. In offline migration, OldName will be used if NewName is left empty (OldName and NewName cannot be both empty). In database cloning, OldName and NewName must be both specified and cannot have the same value.
     */
    newName?: pulumi.Input<string>;
    /**
     * Database name. If the OldName database does not exist, a failure will be returned. It can be left empty in offline migration tasks.
     */
    oldName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a GeneralClone resource.
 */
export interface GeneralCloneArgs {
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * New database name. In offline migration, OldName will be used if NewName is left empty (OldName and NewName cannot be both empty). In database cloning, OldName and NewName must be both specified and cannot have the same value.
     */
    newName: pulumi.Input<string>;
    /**
     * Database name. If the OldName database does not exist, a failure will be returned. It can be left empty in offline migration tasks.
     */
    oldName: pulumi.Input<string>;
}
