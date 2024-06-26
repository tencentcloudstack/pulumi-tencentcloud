// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a sqlserver completeExpansion
 *
 * ## Example Usage
 *
 * ### First, Create a basic SQL instance
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
 * const example = new tencentcloud.sqlserver.Instance("example", {
 *     availabilityZone: zones.then(zones => zones.zones?.[4]?.name),
 *     chargeType: "POSTPAID_BY_HOUR",
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     securityGroups: [securityGroup.id],
 *     projectId: 0,
 *     memory: 2,
 *     storage: 20,
 *     maintenanceWeekSets: [
 *         1,
 *         2,
 *         3,
 *     ],
 *     maintenanceStartTime: "01:00",
 *     maintenanceTimeSpan: 3,
 *     tags: {
 *         createBy: "tfExample",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Expand the current instance, storage: 20->40, waitSwitch = 1
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.sqlserver.Instance("example", {
 *     availabilityZone: data.tencentcloud_availability_zones_by_product.zones.zones[4].name,
 *     chargeType: "POSTPAID_BY_HOUR",
 *     vpcId: tencentcloud_vpc.vpc.id,
 *     subnetId: tencentcloud_subnet.subnet.id,
 *     securityGroups: [tencentcloud_security_group.security_group.id],
 *     projectId: 0,
 *     memory: 2,
 *     storage: 40,
 *     waitSwitch: 1,
 *     maintenanceWeekSets: [
 *         1,
 *         2,
 *         3,
 *     ],
 *     maintenanceStartTime: "01:00",
 *     maintenanceTimeSpan: 3,
 *     tags: {
 *         createBy: "tfExample",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Complete the expansion task immediately
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.sqlserver.CompleteExpansion("example", {instanceId: tencentcloud_sqlserver_instance.example.id});
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class CompleteExpansion extends pulumi.CustomResource {
    /**
     * Get an existing CompleteExpansion resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CompleteExpansionState, opts?: pulumi.CustomResourceOptions): CompleteExpansion {
        return new CompleteExpansion(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Sqlserver/completeExpansion:CompleteExpansion';

    /**
     * Returns true if the given object is an instance of CompleteExpansion.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CompleteExpansion {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CompleteExpansion.__pulumiType;
    }

    /**
     * ID of imported target instance.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a CompleteExpansion resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CompleteExpansionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CompleteExpansionArgs | CompleteExpansionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CompleteExpansionState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as CompleteExpansionArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CompleteExpansion.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CompleteExpansion resources.
 */
export interface CompleteExpansionState {
    /**
     * ID of imported target instance.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CompleteExpansion resource.
 */
export interface CompleteExpansionArgs {
    /**
     * ID of imported target instance.
     */
    instanceId: pulumi.Input<string>;
}
