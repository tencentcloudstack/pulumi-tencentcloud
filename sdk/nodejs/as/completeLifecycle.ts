// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a as completeLifecycle
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
 * const exampleLifecycleHook = new tencentcloud.as.LifecycleHook("exampleLifecycleHook", {
 *     scalingGroupId: exampleScalingGroup.id,
 *     lifecycleHookName: "tf-as-lifecycle-hook",
 *     lifecycleTransition: "INSTANCE_LAUNCHING",
 *     defaultResult: "CONTINUE",
 *     heartbeatTimeout: 500,
 *     notificationMetadata: "tf test",
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
 * const completeLifecycle = new tencentcloud.as.CompleteLifecycle("completeLifecycle", {
 *     lifecycleHookId: exampleLifecycleHook.id,
 *     instanceId: exampleInstance.id,
 *     lifecycleActionResult: "CONTINUE",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class CompleteLifecycle extends pulumi.CustomResource {
    /**
     * Get an existing CompleteLifecycle resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CompleteLifecycleState, opts?: pulumi.CustomResourceOptions): CompleteLifecycle {
        return new CompleteLifecycle(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:As/completeLifecycle:CompleteLifecycle';

    /**
     * Returns true if the given object is an instance of CompleteLifecycle.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CompleteLifecycle {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CompleteLifecycle.__pulumiType;
    }

    /**
     * Instance ID. Either InstanceId or LifecycleActionToken must be specified.
     */
    public readonly instanceId!: pulumi.Output<string | undefined>;
    /**
     * Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
     */
    public readonly lifecycleActionResult!: pulumi.Output<string>;
    /**
     * Either InstanceId or LifecycleActionToken must be specified.
     */
    public readonly lifecycleActionToken!: pulumi.Output<string | undefined>;
    /**
     * Lifecycle hook ID.
     */
    public readonly lifecycleHookId!: pulumi.Output<string>;

    /**
     * Create a CompleteLifecycle resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CompleteLifecycleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CompleteLifecycleArgs | CompleteLifecycleState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CompleteLifecycleState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["lifecycleActionResult"] = state ? state.lifecycleActionResult : undefined;
            resourceInputs["lifecycleActionToken"] = state ? state.lifecycleActionToken : undefined;
            resourceInputs["lifecycleHookId"] = state ? state.lifecycleHookId : undefined;
        } else {
            const args = argsOrState as CompleteLifecycleArgs | undefined;
            if ((!args || args.lifecycleActionResult === undefined) && !opts.urn) {
                throw new Error("Missing required property 'lifecycleActionResult'");
            }
            if ((!args || args.lifecycleHookId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'lifecycleHookId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["lifecycleActionResult"] = args ? args.lifecycleActionResult : undefined;
            resourceInputs["lifecycleActionToken"] = args ? args.lifecycleActionToken : undefined;
            resourceInputs["lifecycleHookId"] = args ? args.lifecycleHookId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CompleteLifecycle.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CompleteLifecycle resources.
 */
export interface CompleteLifecycleState {
    /**
     * Instance ID. Either InstanceId or LifecycleActionToken must be specified.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
     */
    lifecycleActionResult?: pulumi.Input<string>;
    /**
     * Either InstanceId or LifecycleActionToken must be specified.
     */
    lifecycleActionToken?: pulumi.Input<string>;
    /**
     * Lifecycle hook ID.
     */
    lifecycleHookId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CompleteLifecycle resource.
 */
export interface CompleteLifecycleArgs {
    /**
     * Instance ID. Either InstanceId or LifecycleActionToken must be specified.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Result of the lifecycle action. Value range: `CONTINUE`, `ABANDON`.
     */
    lifecycleActionResult: pulumi.Input<string>;
    /**
     * Either InstanceId or LifecycleActionToken must be specified.
     */
    lifecycleActionToken?: pulumi.Input<string>;
    /**
     * Lifecycle hook ID.
     */
    lifecycleHookId: pulumi.Input<string>;
}
