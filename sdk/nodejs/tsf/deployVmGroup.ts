// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tsf deployVmGroup
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const deployVmGroup = new tencentcloud.tsf.DeployVmGroup("deployVmGroup", {
 *     deployDesc: "deploy test",
 *     enableHealthCheck: true,
 *     forceStart: false,
 *     groupId: "group-vzd97zpy",
 *     healthCheckSettings: {
 *         readinessProbe: {
 *             actionType: "HTTP",
 *             failureThreshold: 3,
 *             initialDelaySeconds: 10,
 *             path: "/",
 *             periodSeconds: 10,
 *             port: 80,
 *             scheme: "HTTP",
 *             successThreshold: 1,
 *             timeoutSeconds: 2,
 *         },
 *     },
 *     jdkName: "konaJDK",
 *     jdkVersion: "8",
 *     pkgId: "pkg-131bc1d3",
 *     startupParameters: "-Xms128m -Xmx512m -XX:MetaspaceSize=128m -XX:MaxMetaspaceSize=512m",
 *     updateType: 0,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class DeployVmGroup extends pulumi.CustomResource {
    /**
     * Get an existing DeployVmGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DeployVmGroupState, opts?: pulumi.CustomResourceOptions): DeployVmGroup {
        return new DeployVmGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tsf/deployVmGroup:DeployVmGroup';

    /**
     * Returns true if the given object is an instance of DeployVmGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DeployVmGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DeployVmGroup.__pulumiType;
    }

    /**
     * javaagent info: SERVICE_AGENT/OT_AGENT.
     */
    public readonly agentProfileLists!: pulumi.Output<outputs.Tsf.DeployVmGroupAgentProfileList[]>;
    /**
     * The ratio of instances participating in each batch during rolling release.
     */
    public readonly deployBatches!: pulumi.Output<number[]>;
    /**
     * Whether to enable beta batch.
     */
    public readonly deployBetaEnable!: pulumi.Output<boolean>;
    /**
     * group description.
     */
    public readonly deployDesc!: pulumi.Output<string>;
    /**
     * The execution method of rolling release.
     */
    public readonly deployExeMode!: pulumi.Output<string>;
    /**
     * The time interval for each batch during rolling release.
     */
    public readonly deployWaitTime!: pulumi.Output<number>;
    /**
     * Whether to enable health check.
     */
    public readonly enableHealthCheck!: pulumi.Output<boolean>;
    /**
     * Whether to allow forced start.
     */
    public readonly forceStart!: pulumi.Output<boolean>;
    /**
     * group id.
     */
    public readonly groupId!: pulumi.Output<string>;
    /**
     * When enabling health check, configure the health check settings.
     */
    public readonly healthCheckSettings!: pulumi.Output<outputs.Tsf.DeployVmGroupHealthCheckSettings>;
    /**
     * Whether to perform incremental deployment. The default value is false, which means full update.
     */
    public readonly incrementalDeployment!: pulumi.Output<boolean>;
    /**
     * JDK name: konaJDK or openJDK.
     */
    public readonly jdkName!: pulumi.Output<string>;
    /**
     * JDK version: 8 or 11(openJDK only support 8).
     */
    public readonly jdkVersion!: pulumi.Output<string>;
    /**
     * program package ID.
     */
    public readonly pkgId!: pulumi.Output<string>;
    /**
     * The base64-encoded startup script.
     */
    public readonly startScript!: pulumi.Output<string>;
    /**
     * start args of group.
     */
    public readonly startupParameters!: pulumi.Output<string>;
    /**
     * The base64-encoded stop script.
     */
    public readonly stopScript!: pulumi.Output<string>;
    /**
     * Update method: 0 for fast update, 1 for rolling update.
     */
    public readonly updateType!: pulumi.Output<number>;
    /**
     * warmup setting.
     */
    public readonly warmupSetting!: pulumi.Output<outputs.Tsf.DeployVmGroupWarmupSetting>;

    /**
     * Create a DeployVmGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DeployVmGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DeployVmGroupArgs | DeployVmGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DeployVmGroupState | undefined;
            resourceInputs["agentProfileLists"] = state ? state.agentProfileLists : undefined;
            resourceInputs["deployBatches"] = state ? state.deployBatches : undefined;
            resourceInputs["deployBetaEnable"] = state ? state.deployBetaEnable : undefined;
            resourceInputs["deployDesc"] = state ? state.deployDesc : undefined;
            resourceInputs["deployExeMode"] = state ? state.deployExeMode : undefined;
            resourceInputs["deployWaitTime"] = state ? state.deployWaitTime : undefined;
            resourceInputs["enableHealthCheck"] = state ? state.enableHealthCheck : undefined;
            resourceInputs["forceStart"] = state ? state.forceStart : undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["healthCheckSettings"] = state ? state.healthCheckSettings : undefined;
            resourceInputs["incrementalDeployment"] = state ? state.incrementalDeployment : undefined;
            resourceInputs["jdkName"] = state ? state.jdkName : undefined;
            resourceInputs["jdkVersion"] = state ? state.jdkVersion : undefined;
            resourceInputs["pkgId"] = state ? state.pkgId : undefined;
            resourceInputs["startScript"] = state ? state.startScript : undefined;
            resourceInputs["startupParameters"] = state ? state.startupParameters : undefined;
            resourceInputs["stopScript"] = state ? state.stopScript : undefined;
            resourceInputs["updateType"] = state ? state.updateType : undefined;
            resourceInputs["warmupSetting"] = state ? state.warmupSetting : undefined;
        } else {
            const args = argsOrState as DeployVmGroupArgs | undefined;
            if ((!args || args.groupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupId'");
            }
            if ((!args || args.pkgId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pkgId'");
            }
            resourceInputs["agentProfileLists"] = args ? args.agentProfileLists : undefined;
            resourceInputs["deployBatches"] = args ? args.deployBatches : undefined;
            resourceInputs["deployBetaEnable"] = args ? args.deployBetaEnable : undefined;
            resourceInputs["deployDesc"] = args ? args.deployDesc : undefined;
            resourceInputs["deployExeMode"] = args ? args.deployExeMode : undefined;
            resourceInputs["deployWaitTime"] = args ? args.deployWaitTime : undefined;
            resourceInputs["enableHealthCheck"] = args ? args.enableHealthCheck : undefined;
            resourceInputs["forceStart"] = args ? args.forceStart : undefined;
            resourceInputs["groupId"] = args ? args.groupId : undefined;
            resourceInputs["healthCheckSettings"] = args ? args.healthCheckSettings : undefined;
            resourceInputs["incrementalDeployment"] = args ? args.incrementalDeployment : undefined;
            resourceInputs["jdkName"] = args ? args.jdkName : undefined;
            resourceInputs["jdkVersion"] = args ? args.jdkVersion : undefined;
            resourceInputs["pkgId"] = args ? args.pkgId : undefined;
            resourceInputs["startScript"] = args ? args.startScript : undefined;
            resourceInputs["startupParameters"] = args ? args.startupParameters : undefined;
            resourceInputs["stopScript"] = args ? args.stopScript : undefined;
            resourceInputs["updateType"] = args ? args.updateType : undefined;
            resourceInputs["warmupSetting"] = args ? args.warmupSetting : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DeployVmGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DeployVmGroup resources.
 */
export interface DeployVmGroupState {
    /**
     * javaagent info: SERVICE_AGENT/OT_AGENT.
     */
    agentProfileLists?: pulumi.Input<pulumi.Input<inputs.Tsf.DeployVmGroupAgentProfileList>[]>;
    /**
     * The ratio of instances participating in each batch during rolling release.
     */
    deployBatches?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Whether to enable beta batch.
     */
    deployBetaEnable?: pulumi.Input<boolean>;
    /**
     * group description.
     */
    deployDesc?: pulumi.Input<string>;
    /**
     * The execution method of rolling release.
     */
    deployExeMode?: pulumi.Input<string>;
    /**
     * The time interval for each batch during rolling release.
     */
    deployWaitTime?: pulumi.Input<number>;
    /**
     * Whether to enable health check.
     */
    enableHealthCheck?: pulumi.Input<boolean>;
    /**
     * Whether to allow forced start.
     */
    forceStart?: pulumi.Input<boolean>;
    /**
     * group id.
     */
    groupId?: pulumi.Input<string>;
    /**
     * When enabling health check, configure the health check settings.
     */
    healthCheckSettings?: pulumi.Input<inputs.Tsf.DeployVmGroupHealthCheckSettings>;
    /**
     * Whether to perform incremental deployment. The default value is false, which means full update.
     */
    incrementalDeployment?: pulumi.Input<boolean>;
    /**
     * JDK name: konaJDK or openJDK.
     */
    jdkName?: pulumi.Input<string>;
    /**
     * JDK version: 8 or 11(openJDK only support 8).
     */
    jdkVersion?: pulumi.Input<string>;
    /**
     * program package ID.
     */
    pkgId?: pulumi.Input<string>;
    /**
     * The base64-encoded startup script.
     */
    startScript?: pulumi.Input<string>;
    /**
     * start args of group.
     */
    startupParameters?: pulumi.Input<string>;
    /**
     * The base64-encoded stop script.
     */
    stopScript?: pulumi.Input<string>;
    /**
     * Update method: 0 for fast update, 1 for rolling update.
     */
    updateType?: pulumi.Input<number>;
    /**
     * warmup setting.
     */
    warmupSetting?: pulumi.Input<inputs.Tsf.DeployVmGroupWarmupSetting>;
}

/**
 * The set of arguments for constructing a DeployVmGroup resource.
 */
export interface DeployVmGroupArgs {
    /**
     * javaagent info: SERVICE_AGENT/OT_AGENT.
     */
    agentProfileLists?: pulumi.Input<pulumi.Input<inputs.Tsf.DeployVmGroupAgentProfileList>[]>;
    /**
     * The ratio of instances participating in each batch during rolling release.
     */
    deployBatches?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Whether to enable beta batch.
     */
    deployBetaEnable?: pulumi.Input<boolean>;
    /**
     * group description.
     */
    deployDesc?: pulumi.Input<string>;
    /**
     * The execution method of rolling release.
     */
    deployExeMode?: pulumi.Input<string>;
    /**
     * The time interval for each batch during rolling release.
     */
    deployWaitTime?: pulumi.Input<number>;
    /**
     * Whether to enable health check.
     */
    enableHealthCheck?: pulumi.Input<boolean>;
    /**
     * Whether to allow forced start.
     */
    forceStart?: pulumi.Input<boolean>;
    /**
     * group id.
     */
    groupId: pulumi.Input<string>;
    /**
     * When enabling health check, configure the health check settings.
     */
    healthCheckSettings?: pulumi.Input<inputs.Tsf.DeployVmGroupHealthCheckSettings>;
    /**
     * Whether to perform incremental deployment. The default value is false, which means full update.
     */
    incrementalDeployment?: pulumi.Input<boolean>;
    /**
     * JDK name: konaJDK or openJDK.
     */
    jdkName?: pulumi.Input<string>;
    /**
     * JDK version: 8 or 11(openJDK only support 8).
     */
    jdkVersion?: pulumi.Input<string>;
    /**
     * program package ID.
     */
    pkgId: pulumi.Input<string>;
    /**
     * The base64-encoded startup script.
     */
    startScript?: pulumi.Input<string>;
    /**
     * start args of group.
     */
    startupParameters?: pulumi.Input<string>;
    /**
     * The base64-encoded stop script.
     */
    stopScript?: pulumi.Input<string>;
    /**
     * Update method: 0 for fast update, 1 for rolling update.
     */
    updateType?: pulumi.Input<number>;
    /**
     * warmup setting.
     */
    warmupSetting?: pulumi.Input<inputs.Tsf.DeployVmGroupWarmupSetting>;
}
