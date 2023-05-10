// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tsf containGroup
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const containGroup = new tencentcloud.Tsf.ContainGroup("contain_group", {
 *     accessType: 0,
 *     applicationId: "application-y5r4nejv",
 *     clusterId: "cls-2yu5kxr8",
 *     cpuLimit: "0.5",
 *     cpuRequest: "0.25",
 *     groupName: "terraform-test",
 *     groupResourceType: "DEF",
 *     instanceNum: 1,
 *     memLimit: "1280",
 *     memRequest: "640",
 *     namespaceId: "namespace-ydlezgxa",
 *     protocolPorts: [{
 *         nodePort: 0,
 *         port: 333,
 *         protocol: "TCP",
 *         targetPort: 333,
 *     }],
 *     updateIvl: 10,
 *     updateType: 1,
 * });
 * ```
 *
 * ## Import
 *
 * tsf contain_group can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Tsf/containGroup:ContainGroup contain_group contain_group_id
 * ```
 */
export class ContainGroup extends pulumi.CustomResource {
    /**
     * Get an existing ContainGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ContainGroupState, opts?: pulumi.CustomResourceOptions): ContainGroup {
        return new ContainGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tsf/containGroup:ContainGroup';

    /**
     * Returns true if the given object is an instance of ContainGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ContainGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ContainGroup.__pulumiType;
    }

    /**
     * 0: public network 1: access within the cluster 2: NodePort.
     */
    public readonly accessType!: pulumi.Output<number>;
    /**
     * The maximum number of CPU cores for the agent container, corresponding to the limit of K8S.
     */
    public readonly agentCpuLimit!: pulumi.Output<string | undefined>;
    /**
     * The number of CPU cores allocated by the agent container, corresponding to the K8S request.
     */
    public readonly agentCpuRequest!: pulumi.Output<string | undefined>;
    /**
     * The maximum memory MiB of the agent container, corresponding to the limit of K8S.
     */
    public readonly agentMemLimit!: pulumi.Output<string | undefined>;
    /**
     * The number of memory MiB allocated by the agent container, corresponding to the K8S request.
     */
    public readonly agentMemRequest!: pulumi.Output<string | undefined>;
    /**
     * The application ID to which the group belongs.
     */
    public readonly applicationId!: pulumi.Output<string>;
    /**
     * Application Name.
     */
    public /*out*/ readonly applicationName!: pulumi.Output<string>;
    /**
     * App types.
     */
    public /*out*/ readonly applicationType!: pulumi.Output<string>;
    /**
     * Cluster ID.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * Service ip.
     */
    public /*out*/ readonly clusterIp!: pulumi.Output<string>;
    /**
     * cluster name.
     */
    public /*out*/ readonly clusterName!: pulumi.Output<string>;
    /**
     * The maximum number of allocated CPU cores, corresponding to the K8S limit.
     */
    public readonly cpuLimit!: pulumi.Output<string | undefined>;
    /**
     * Initially allocated CPU cores, corresponding to K8S request.
     */
    public readonly cpuRequest!: pulumi.Output<string | undefined>;
    /**
     * creation time.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Total number of instances launched.
     */
    public /*out*/ readonly currentNum!: pulumi.Output<number>;
    /**
     * environment variable array object.
     */
    public /*out*/ readonly envs!: pulumi.Output<outputs.Tsf.ContainGroupEnv[]>;
    /**
     * Group remarks field, the length should not exceed 200 characters.
     */
    public readonly groupComment!: pulumi.Output<string | undefined>;
    /**
     * Deployment group ID.
     */
    public /*out*/ readonly groupId!: pulumi.Output<string>;
    /**
     * Group name field, length 1~60, beginning with a letter or underscore, can contain alphanumeric underscore.
     */
    public readonly groupName!: pulumi.Output<string>;
    /**
     * Deployment Group Resource Type.
     */
    public readonly groupResourceType!: pulumi.Output<string>;
    /**
     * Deployment group health check settings.
     */
    public /*out*/ readonly healthCheckSettings!: pulumi.Output<outputs.Tsf.ContainGroupHealthCheckSetting[]>;
    /**
     * Number of deployment group instances.
     */
    public /*out*/ readonly instanceCount!: pulumi.Output<number>;
    /**
     * number of instances.
     */
    public readonly instanceNum!: pulumi.Output<number>;
    /**
     * The maximum number of CPU cores for the istioproxy container corresponds to the limit of K8S.
     */
    public readonly istioCpuLimit!: pulumi.Output<string>;
    /**
     * The number of CPU cores allocated by the istioproxy container, corresponding to the K8S request.
     */
    public readonly istioCpuRequest!: pulumi.Output<string>;
    /**
     * The maximum memory MiB of the istioproxy container corresponds to the limit of K8S.
     */
    public readonly istioMemLimit!: pulumi.Output<string>;
    /**
     * The number of memory MiB allocated by the istioproxy container, corresponding to the K8S request.
     */
    public readonly istioMemRequest!: pulumi.Output<string>;
    /**
     * load balancing ip.
     */
    public /*out*/ readonly lbIp!: pulumi.Output<string>;
    /**
     * The MaxSurge parameter of the kubernetes rolling update policy.
     */
    public /*out*/ readonly maxSurge!: pulumi.Output<string>;
    /**
     * The MaxUnavailable parameter of the kubernetes rolling update policy.
     */
    public /*out*/ readonly maxUnavailable!: pulumi.Output<string>;
    /**
     * Maximum allocated memory MiB, corresponding to K8S limit.
     */
    public readonly memLimit!: pulumi.Output<string | undefined>;
    /**
     * Initially allocated memory MiB, corresponding to K8S request.
     */
    public readonly memRequest!: pulumi.Output<string | undefined>;
    /**
     * pod error message description.
     */
    public /*out*/ readonly message!: pulumi.Output<string>;
    /**
     * Service type.
     */
    public /*out*/ readonly microserviceType!: pulumi.Output<string>;
    /**
     * ID of the namespace to which the group belongs.
     */
    public readonly namespaceId!: pulumi.Output<string>;
    /**
     * namespace name.
     */
    public /*out*/ readonly namespaceName!: pulumi.Output<string>;
    /**
     * Protocol Ports array.
     */
    public readonly protocolPorts!: pulumi.Output<outputs.Tsf.ContainGroupProtocolPort[]>;
    /**
     * Mirror name, such as /tsf/nginx.
     */
    public /*out*/ readonly reponame!: pulumi.Output<string>;
    /**
     * mirror server.
     */
    public /*out*/ readonly server!: pulumi.Output<string>;
    /**
     * Deployment group status.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * subnet ID.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Image version name.
     */
    public /*out*/ readonly tagName!: pulumi.Output<string>;
    /**
     * Rolling update is required, update interval.
     */
    public readonly updateIvl!: pulumi.Output<number>;
    /**
     * Update method: 0: fast update 1: rolling update.
     */
    public readonly updateType!: pulumi.Output<number>;
    /**
     * Deployment group update timestamp.
     */
    public /*out*/ readonly updatedTime!: pulumi.Output<number>;

    /**
     * Create a ContainGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ContainGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ContainGroupArgs | ContainGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ContainGroupState | undefined;
            resourceInputs["accessType"] = state ? state.accessType : undefined;
            resourceInputs["agentCpuLimit"] = state ? state.agentCpuLimit : undefined;
            resourceInputs["agentCpuRequest"] = state ? state.agentCpuRequest : undefined;
            resourceInputs["agentMemLimit"] = state ? state.agentMemLimit : undefined;
            resourceInputs["agentMemRequest"] = state ? state.agentMemRequest : undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["applicationName"] = state ? state.applicationName : undefined;
            resourceInputs["applicationType"] = state ? state.applicationType : undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["clusterIp"] = state ? state.clusterIp : undefined;
            resourceInputs["clusterName"] = state ? state.clusterName : undefined;
            resourceInputs["cpuLimit"] = state ? state.cpuLimit : undefined;
            resourceInputs["cpuRequest"] = state ? state.cpuRequest : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["currentNum"] = state ? state.currentNum : undefined;
            resourceInputs["envs"] = state ? state.envs : undefined;
            resourceInputs["groupComment"] = state ? state.groupComment : undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
            resourceInputs["groupName"] = state ? state.groupName : undefined;
            resourceInputs["groupResourceType"] = state ? state.groupResourceType : undefined;
            resourceInputs["healthCheckSettings"] = state ? state.healthCheckSettings : undefined;
            resourceInputs["instanceCount"] = state ? state.instanceCount : undefined;
            resourceInputs["instanceNum"] = state ? state.instanceNum : undefined;
            resourceInputs["istioCpuLimit"] = state ? state.istioCpuLimit : undefined;
            resourceInputs["istioCpuRequest"] = state ? state.istioCpuRequest : undefined;
            resourceInputs["istioMemLimit"] = state ? state.istioMemLimit : undefined;
            resourceInputs["istioMemRequest"] = state ? state.istioMemRequest : undefined;
            resourceInputs["lbIp"] = state ? state.lbIp : undefined;
            resourceInputs["maxSurge"] = state ? state.maxSurge : undefined;
            resourceInputs["maxUnavailable"] = state ? state.maxUnavailable : undefined;
            resourceInputs["memLimit"] = state ? state.memLimit : undefined;
            resourceInputs["memRequest"] = state ? state.memRequest : undefined;
            resourceInputs["message"] = state ? state.message : undefined;
            resourceInputs["microserviceType"] = state ? state.microserviceType : undefined;
            resourceInputs["namespaceId"] = state ? state.namespaceId : undefined;
            resourceInputs["namespaceName"] = state ? state.namespaceName : undefined;
            resourceInputs["protocolPorts"] = state ? state.protocolPorts : undefined;
            resourceInputs["reponame"] = state ? state.reponame : undefined;
            resourceInputs["server"] = state ? state.server : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["tagName"] = state ? state.tagName : undefined;
            resourceInputs["updateIvl"] = state ? state.updateIvl : undefined;
            resourceInputs["updateType"] = state ? state.updateType : undefined;
            resourceInputs["updatedTime"] = state ? state.updatedTime : undefined;
        } else {
            const args = argsOrState as ContainGroupArgs | undefined;
            if ((!args || args.accessType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accessType'");
            }
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.groupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupName'");
            }
            if ((!args || args.instanceNum === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceNum'");
            }
            if ((!args || args.namespaceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'namespaceId'");
            }
            if ((!args || args.protocolPorts === undefined) && !opts.urn) {
                throw new Error("Missing required property 'protocolPorts'");
            }
            resourceInputs["accessType"] = args ? args.accessType : undefined;
            resourceInputs["agentCpuLimit"] = args ? args.agentCpuLimit : undefined;
            resourceInputs["agentCpuRequest"] = args ? args.agentCpuRequest : undefined;
            resourceInputs["agentMemLimit"] = args ? args.agentMemLimit : undefined;
            resourceInputs["agentMemRequest"] = args ? args.agentMemRequest : undefined;
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["cpuLimit"] = args ? args.cpuLimit : undefined;
            resourceInputs["cpuRequest"] = args ? args.cpuRequest : undefined;
            resourceInputs["groupComment"] = args ? args.groupComment : undefined;
            resourceInputs["groupName"] = args ? args.groupName : undefined;
            resourceInputs["groupResourceType"] = args ? args.groupResourceType : undefined;
            resourceInputs["instanceNum"] = args ? args.instanceNum : undefined;
            resourceInputs["istioCpuLimit"] = args ? args.istioCpuLimit : undefined;
            resourceInputs["istioCpuRequest"] = args ? args.istioCpuRequest : undefined;
            resourceInputs["istioMemLimit"] = args ? args.istioMemLimit : undefined;
            resourceInputs["istioMemRequest"] = args ? args.istioMemRequest : undefined;
            resourceInputs["memLimit"] = args ? args.memLimit : undefined;
            resourceInputs["memRequest"] = args ? args.memRequest : undefined;
            resourceInputs["namespaceId"] = args ? args.namespaceId : undefined;
            resourceInputs["protocolPorts"] = args ? args.protocolPorts : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["updateIvl"] = args ? args.updateIvl : undefined;
            resourceInputs["updateType"] = args ? args.updateType : undefined;
            resourceInputs["applicationName"] = undefined /*out*/;
            resourceInputs["applicationType"] = undefined /*out*/;
            resourceInputs["clusterIp"] = undefined /*out*/;
            resourceInputs["clusterName"] = undefined /*out*/;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["currentNum"] = undefined /*out*/;
            resourceInputs["envs"] = undefined /*out*/;
            resourceInputs["groupId"] = undefined /*out*/;
            resourceInputs["healthCheckSettings"] = undefined /*out*/;
            resourceInputs["instanceCount"] = undefined /*out*/;
            resourceInputs["lbIp"] = undefined /*out*/;
            resourceInputs["maxSurge"] = undefined /*out*/;
            resourceInputs["maxUnavailable"] = undefined /*out*/;
            resourceInputs["message"] = undefined /*out*/;
            resourceInputs["microserviceType"] = undefined /*out*/;
            resourceInputs["namespaceName"] = undefined /*out*/;
            resourceInputs["reponame"] = undefined /*out*/;
            resourceInputs["server"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["tagName"] = undefined /*out*/;
            resourceInputs["updatedTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ContainGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ContainGroup resources.
 */
export interface ContainGroupState {
    /**
     * 0: public network 1: access within the cluster 2: NodePort.
     */
    accessType?: pulumi.Input<number>;
    /**
     * The maximum number of CPU cores for the agent container, corresponding to the limit of K8S.
     */
    agentCpuLimit?: pulumi.Input<string>;
    /**
     * The number of CPU cores allocated by the agent container, corresponding to the K8S request.
     */
    agentCpuRequest?: pulumi.Input<string>;
    /**
     * The maximum memory MiB of the agent container, corresponding to the limit of K8S.
     */
    agentMemLimit?: pulumi.Input<string>;
    /**
     * The number of memory MiB allocated by the agent container, corresponding to the K8S request.
     */
    agentMemRequest?: pulumi.Input<string>;
    /**
     * The application ID to which the group belongs.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * Application Name.
     */
    applicationName?: pulumi.Input<string>;
    /**
     * App types.
     */
    applicationType?: pulumi.Input<string>;
    /**
     * Cluster ID.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * Service ip.
     */
    clusterIp?: pulumi.Input<string>;
    /**
     * cluster name.
     */
    clusterName?: pulumi.Input<string>;
    /**
     * The maximum number of allocated CPU cores, corresponding to the K8S limit.
     */
    cpuLimit?: pulumi.Input<string>;
    /**
     * Initially allocated CPU cores, corresponding to K8S request.
     */
    cpuRequest?: pulumi.Input<string>;
    /**
     * creation time.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Total number of instances launched.
     */
    currentNum?: pulumi.Input<number>;
    /**
     * environment variable array object.
     */
    envs?: pulumi.Input<pulumi.Input<inputs.Tsf.ContainGroupEnv>[]>;
    /**
     * Group remarks field, the length should not exceed 200 characters.
     */
    groupComment?: pulumi.Input<string>;
    /**
     * Deployment group ID.
     */
    groupId?: pulumi.Input<string>;
    /**
     * Group name field, length 1~60, beginning with a letter or underscore, can contain alphanumeric underscore.
     */
    groupName?: pulumi.Input<string>;
    /**
     * Deployment Group Resource Type.
     */
    groupResourceType?: pulumi.Input<string>;
    /**
     * Deployment group health check settings.
     */
    healthCheckSettings?: pulumi.Input<pulumi.Input<inputs.Tsf.ContainGroupHealthCheckSetting>[]>;
    /**
     * Number of deployment group instances.
     */
    instanceCount?: pulumi.Input<number>;
    /**
     * number of instances.
     */
    instanceNum?: pulumi.Input<number>;
    /**
     * The maximum number of CPU cores for the istioproxy container corresponds to the limit of K8S.
     */
    istioCpuLimit?: pulumi.Input<string>;
    /**
     * The number of CPU cores allocated by the istioproxy container, corresponding to the K8S request.
     */
    istioCpuRequest?: pulumi.Input<string>;
    /**
     * The maximum memory MiB of the istioproxy container corresponds to the limit of K8S.
     */
    istioMemLimit?: pulumi.Input<string>;
    /**
     * The number of memory MiB allocated by the istioproxy container, corresponding to the K8S request.
     */
    istioMemRequest?: pulumi.Input<string>;
    /**
     * load balancing ip.
     */
    lbIp?: pulumi.Input<string>;
    /**
     * The MaxSurge parameter of the kubernetes rolling update policy.
     */
    maxSurge?: pulumi.Input<string>;
    /**
     * The MaxUnavailable parameter of the kubernetes rolling update policy.
     */
    maxUnavailable?: pulumi.Input<string>;
    /**
     * Maximum allocated memory MiB, corresponding to K8S limit.
     */
    memLimit?: pulumi.Input<string>;
    /**
     * Initially allocated memory MiB, corresponding to K8S request.
     */
    memRequest?: pulumi.Input<string>;
    /**
     * pod error message description.
     */
    message?: pulumi.Input<string>;
    /**
     * Service type.
     */
    microserviceType?: pulumi.Input<string>;
    /**
     * ID of the namespace to which the group belongs.
     */
    namespaceId?: pulumi.Input<string>;
    /**
     * namespace name.
     */
    namespaceName?: pulumi.Input<string>;
    /**
     * Protocol Ports array.
     */
    protocolPorts?: pulumi.Input<pulumi.Input<inputs.Tsf.ContainGroupProtocolPort>[]>;
    /**
     * Mirror name, such as /tsf/nginx.
     */
    reponame?: pulumi.Input<string>;
    /**
     * mirror server.
     */
    server?: pulumi.Input<string>;
    /**
     * Deployment group status.
     */
    status?: pulumi.Input<string>;
    /**
     * subnet ID.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Image version name.
     */
    tagName?: pulumi.Input<string>;
    /**
     * Rolling update is required, update interval.
     */
    updateIvl?: pulumi.Input<number>;
    /**
     * Update method: 0: fast update 1: rolling update.
     */
    updateType?: pulumi.Input<number>;
    /**
     * Deployment group update timestamp.
     */
    updatedTime?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ContainGroup resource.
 */
export interface ContainGroupArgs {
    /**
     * 0: public network 1: access within the cluster 2: NodePort.
     */
    accessType: pulumi.Input<number>;
    /**
     * The maximum number of CPU cores for the agent container, corresponding to the limit of K8S.
     */
    agentCpuLimit?: pulumi.Input<string>;
    /**
     * The number of CPU cores allocated by the agent container, corresponding to the K8S request.
     */
    agentCpuRequest?: pulumi.Input<string>;
    /**
     * The maximum memory MiB of the agent container, corresponding to the limit of K8S.
     */
    agentMemLimit?: pulumi.Input<string>;
    /**
     * The number of memory MiB allocated by the agent container, corresponding to the K8S request.
     */
    agentMemRequest?: pulumi.Input<string>;
    /**
     * The application ID to which the group belongs.
     */
    applicationId: pulumi.Input<string>;
    /**
     * Cluster ID.
     */
    clusterId: pulumi.Input<string>;
    /**
     * The maximum number of allocated CPU cores, corresponding to the K8S limit.
     */
    cpuLimit?: pulumi.Input<string>;
    /**
     * Initially allocated CPU cores, corresponding to K8S request.
     */
    cpuRequest?: pulumi.Input<string>;
    /**
     * Group remarks field, the length should not exceed 200 characters.
     */
    groupComment?: pulumi.Input<string>;
    /**
     * Group name field, length 1~60, beginning with a letter or underscore, can contain alphanumeric underscore.
     */
    groupName: pulumi.Input<string>;
    /**
     * Deployment Group Resource Type.
     */
    groupResourceType?: pulumi.Input<string>;
    /**
     * number of instances.
     */
    instanceNum: pulumi.Input<number>;
    /**
     * The maximum number of CPU cores for the istioproxy container corresponds to the limit of K8S.
     */
    istioCpuLimit?: pulumi.Input<string>;
    /**
     * The number of CPU cores allocated by the istioproxy container, corresponding to the K8S request.
     */
    istioCpuRequest?: pulumi.Input<string>;
    /**
     * The maximum memory MiB of the istioproxy container corresponds to the limit of K8S.
     */
    istioMemLimit?: pulumi.Input<string>;
    /**
     * The number of memory MiB allocated by the istioproxy container, corresponding to the K8S request.
     */
    istioMemRequest?: pulumi.Input<string>;
    /**
     * Maximum allocated memory MiB, corresponding to K8S limit.
     */
    memLimit?: pulumi.Input<string>;
    /**
     * Initially allocated memory MiB, corresponding to K8S request.
     */
    memRequest?: pulumi.Input<string>;
    /**
     * ID of the namespace to which the group belongs.
     */
    namespaceId: pulumi.Input<string>;
    /**
     * Protocol Ports array.
     */
    protocolPorts: pulumi.Input<pulumi.Input<inputs.Tsf.ContainGroupProtocolPort>[]>;
    /**
     * subnet ID.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Rolling update is required, update interval.
     */
    updateIvl?: pulumi.Input<number>;
    /**
     * Update method: 0: fast update 1: rolling update.
     */
    updateType?: pulumi.Input<number>;
}