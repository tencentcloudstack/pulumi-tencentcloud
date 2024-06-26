// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a as protectInstances
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
 *     product: "as",
 * });
 * const image = tencentcloud.Images.getInstance({
 *     imageTypes: ["PUBLIC_IMAGE"],
 *     osName: "TencentOS Server 3.2 (Final)",
 * });
 * const instanceTypes = zones.then(zones => tencentcloud.Instance.getTypes({
 *     filters: [
 *         {
 *             name: "zone",
 *             values: [zones.zones?.[0]?.name],
 *         },
 *         {
 *             name: "instance-family",
 *             values: ["S5"],
 *         },
 *     ],
 *     cpuCoreCount: 2,
 *     excludeSoldOut: true,
 * }));
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.0.0/16",
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 * });
 * const exampleScalingConfig = new tencentcloud.as.ScalingConfig("exampleScalingConfig", {
 *     configurationName: "tf-example",
 *     imageId: image.then(image => image.images?.[0]?.imageId),
 *     instanceTypes: [
 *         "SA1.SMALL1",
 *         "SA2.SMALL1",
 *         "SA2.SMALL2",
 *         "SA2.SMALL4",
 *     ],
 *     instanceNameSettings: {
 *         instanceName: "test-ins-name",
 *     },
 * });
 * const exampleScalingGroup = new tencentcloud.as.ScalingGroup("exampleScalingGroup", {
 *     scalingGroupName: "tf-example",
 *     configurationId: exampleScalingConfig.id,
 *     maxSize: 1,
 *     minSize: 0,
 *     vpcId: vpc.id,
 *     subnetIds: [subnet.id],
 * });
 * const exampleInstance = new tencentcloud.instance.Instance("exampleInstance", {
 *     instanceName: "tf_example",
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 *     imageId: image.then(image => image.images?.[0]?.imageId),
 *     instanceType: instanceTypes.then(instanceTypes => instanceTypes.instanceTypes?.[0]?.instanceType),
 *     systemDiskType: "CLOUD_PREMIUM",
 *     systemDiskSize: 50,
 *     hostname: "user",
 *     projectId: 0,
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 * });
 * // Attachment Instance
 * const attachment = new tencentcloud.as.Attachment("attachment", {
 *     scalingGroupId: exampleScalingGroup.id,
 *     instanceIds: [exampleInstance.id],
 * });
 * // Set protect
 * const protect = new tencentcloud.as.ProtectInstances("protect", {
 *     autoScalingGroupId: exampleScalingGroup.id,
 *     instanceIds: attachment.instanceIds,
 *     protectedFromScaleIn: true,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Or close protect
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const protect = new tencentcloud.as.ProtectInstances("protect", {
 *     autoScalingGroupId: tencentcloud_as_scaling_group.example.id,
 *     instanceIds: tencentcloud_as_attachment.attachment.instance_ids,
 *     protectedFromScaleIn: false,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ProtectInstances extends pulumi.CustomResource {
    /**
     * Get an existing ProtectInstances resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProtectInstancesState, opts?: pulumi.CustomResourceOptions): ProtectInstances {
        return new ProtectInstances(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:As/protectInstances:ProtectInstances';

    /**
     * Returns true if the given object is an instance of ProtectInstances.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProtectInstances {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProtectInstances.__pulumiType;
    }

    /**
     * Launch configuration ID.
     */
    public readonly autoScalingGroupId!: pulumi.Output<string>;
    /**
     * List of cvm instances to remove.
     */
    public readonly instanceIds!: pulumi.Output<string[]>;
    /**
     * If instances need protect.
     */
    public readonly protectedFromScaleIn!: pulumi.Output<boolean>;

    /**
     * Create a ProtectInstances resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProtectInstancesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProtectInstancesArgs | ProtectInstancesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProtectInstancesState | undefined;
            resourceInputs["autoScalingGroupId"] = state ? state.autoScalingGroupId : undefined;
            resourceInputs["instanceIds"] = state ? state.instanceIds : undefined;
            resourceInputs["protectedFromScaleIn"] = state ? state.protectedFromScaleIn : undefined;
        } else {
            const args = argsOrState as ProtectInstancesArgs | undefined;
            if ((!args || args.autoScalingGroupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'autoScalingGroupId'");
            }
            if ((!args || args.instanceIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceIds'");
            }
            if ((!args || args.protectedFromScaleIn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'protectedFromScaleIn'");
            }
            resourceInputs["autoScalingGroupId"] = args ? args.autoScalingGroupId : undefined;
            resourceInputs["instanceIds"] = args ? args.instanceIds : undefined;
            resourceInputs["protectedFromScaleIn"] = args ? args.protectedFromScaleIn : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ProtectInstances.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProtectInstances resources.
 */
export interface ProtectInstancesState {
    /**
     * Launch configuration ID.
     */
    autoScalingGroupId?: pulumi.Input<string>;
    /**
     * List of cvm instances to remove.
     */
    instanceIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * If instances need protect.
     */
    protectedFromScaleIn?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a ProtectInstances resource.
 */
export interface ProtectInstancesArgs {
    /**
     * Launch configuration ID.
     */
    autoScalingGroupId: pulumi.Input<string>;
    /**
     * List of cvm instances to remove.
     */
    instanceIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * If instances need protect.
     */
    protectedFromScaleIn: pulumi.Input<boolean>;
}
