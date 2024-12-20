// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a CVM instance action timer
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const config = new pulumi.Config();
 * const availabilityZone = config.get("availabilityZone") || "ap-guangzhou-6";
 * const images = tencentcloud.Images.getInstance({
 *     imageTypes: ["PUBLIC_IMAGE"],
 *     imageNameRegex: "TencentOS Server",
 * });
 * // create vpc
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * // create vpc subnet
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     vpcId: vpc.id,
 *     availabilityZone: availabilityZone,
 *     cidrBlock: "10.0.20.0/28",
 *     isMulticast: false,
 * });
 * // create cvm
 * const exampleInstance = new tencentcloud.instance.Instance("exampleInstance", {
 *     instanceName: "tf_example",
 *     availabilityZone: availabilityZone,
 *     imageId: images.then(images => images.images?.[0]?.imageId),
 *     instanceType: "SA3.MEDIUM4",
 *     systemDiskType: "CLOUD_HSSD",
 *     systemDiskSize: 100,
 *     hostname: "example",
 *     projectId: 0,
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     dataDisks: [{
 *         dataDiskType: "CLOUD_HSSD",
 *         dataDiskSize: 50,
 *         encrypt: false,
 *     }],
 *     tags: {
 *         createBy: "terraform",
 *     },
 * });
 * // create cvm action timer
 * const exampleActionTimer = new tencentcloud.cvm.ActionTimer("exampleActionTimer", {
 *     instanceId: exampleInstance.id,
 *     actionTimer: {
 *         timerAction: "TerminateInstances",
 *         actionTime: "2024-11-11T11:26:40Z",
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ActionTimer extends pulumi.CustomResource {
    /**
     * Get an existing ActionTimer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ActionTimerState, opts?: pulumi.CustomResourceOptions): ActionTimer {
        return new ActionTimer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cvm/actionTimer:ActionTimer';

    /**
     * Returns true if the given object is an instance of ActionTimer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ActionTimer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ActionTimer.__pulumiType;
    }

    /**
     * Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
     */
    public readonly actionTimer!: pulumi.Output<outputs.Cvm.ActionTimerActionTimer>;
    /**
     * Instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a ActionTimer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ActionTimerArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ActionTimerArgs | ActionTimerState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ActionTimerState | undefined;
            resourceInputs["actionTimer"] = state ? state.actionTimer : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as ActionTimerArgs | undefined;
            if ((!args || args.actionTimer === undefined) && !opts.urn) {
                throw new Error("Missing required property 'actionTimer'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["actionTimer"] = args ? args.actionTimer : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ActionTimer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ActionTimer resources.
 */
export interface ActionTimerState {
    /**
     * Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
     */
    actionTimer?: pulumi.Input<inputs.Cvm.ActionTimerActionTimer>;
    /**
     * Instance ID.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ActionTimer resource.
 */
export interface ActionTimerArgs {
    /**
     * Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
     */
    actionTimer: pulumi.Input<inputs.Cvm.ActionTimerActionTimer>;
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
}
