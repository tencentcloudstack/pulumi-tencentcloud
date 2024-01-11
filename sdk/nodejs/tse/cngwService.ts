// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tse cngwService
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pulumi from "@tencentcloud_iac/pulumi";
 *
 * const config = new pulumi.Config();
 * const availabilityZone = config.get("availabilityZone") || "ap-guangzhou-4";
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     vpcId: vpc.id,
 *     availabilityZone: availabilityZone,
 *     cidrBlock: "10.0.1.0/24",
 * });
 * const cngwGateway = new tencentcloud.tse.CngwGateway("cngwGateway", {
 *     description: "terraform test1",
 *     enableCls: true,
 *     engineRegion: "ap-guangzhou",
 *     featureVersion: "STANDARD",
 *     gatewayVersion: "2.5.1",
 *     ingressClassName: "tse-nginx-ingress",
 *     internetMaxBandwidthOut: 0,
 *     tradeType: 0,
 *     type: "kong",
 *     nodeConfig: {
 *         number: 2,
 *         specification: "1c2g",
 *     },
 *     vpcConfig: {
 *         subnetId: subnet.id,
 *         vpcId: vpc.id,
 *     },
 *     tags: {
 *         createdBy: "terraform",
 *     },
 * });
 * const cngwService = new tencentcloud.tse.CngwService("cngwService", {
 *     gatewayId: cngwGateway.id,
 *     path: "/test",
 *     protocol: "http",
 *     retries: 5,
 *     timeout: 60000,
 *     upstreamType: "HostIP",
 *     upstreamInfo: {
 *         algorithm: "round-robin",
 *         autoScalingCvmPort: 0,
 *         host: "arunma.cn",
 *         port: 8012,
 *         slowStart: 0,
 *     },
 * });
 * ```
 *
 * ## Import
 *
 * tse cngw_service can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Tse/cngwService:CngwService cngw_service gatewayId#name
 * ```
 */
export class CngwService extends pulumi.CustomResource {
    /**
     * Get an existing CngwService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CngwServiceState, opts?: pulumi.CustomResourceOptions): CngwService {
        return new CngwService(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tse/cngwService:CngwService';

    /**
     * Returns true if the given object is an instance of CngwService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CngwService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CngwService.__pulumiType;
    }

    /**
     * gateway ID.
     */
    public readonly gatewayId!: pulumi.Output<string>;
    /**
     * service name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * path.
     */
    public readonly path!: pulumi.Output<string>;
    /**
     * protocol. Reference value:`https`, `http`, `tcp`, `udp`.
     */
    public readonly protocol!: pulumi.Output<string>;
    /**
     * retry times.
     */
    public readonly retries!: pulumi.Output<number>;
    /**
     * service id.
     */
    public /*out*/ readonly serviceId!: pulumi.Output<string>;
    /**
     * Deprecate ineffective tags Tag description list.
     *
     * @deprecated Deprecate ineffective tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * time out, unit:ms.
     */
    public readonly timeout!: pulumi.Output<number>;
    /**
     * service config information.
     */
    public readonly upstreamInfo!: pulumi.Output<outputs.Tse.CngwServiceUpstreamInfo>;
    /**
     * service type. Reference value:`Kubernetes`, `Registry`, `IPList`, `HostIP`, `Scf`.
     */
    public readonly upstreamType!: pulumi.Output<string>;

    /**
     * Create a CngwService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CngwServiceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CngwServiceArgs | CngwServiceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CngwServiceState | undefined;
            resourceInputs["gatewayId"] = state ? state.gatewayId : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["path"] = state ? state.path : undefined;
            resourceInputs["protocol"] = state ? state.protocol : undefined;
            resourceInputs["retries"] = state ? state.retries : undefined;
            resourceInputs["serviceId"] = state ? state.serviceId : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["timeout"] = state ? state.timeout : undefined;
            resourceInputs["upstreamInfo"] = state ? state.upstreamInfo : undefined;
            resourceInputs["upstreamType"] = state ? state.upstreamType : undefined;
        } else {
            const args = argsOrState as CngwServiceArgs | undefined;
            if ((!args || args.gatewayId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'gatewayId'");
            }
            if ((!args || args.path === undefined) && !opts.urn) {
                throw new Error("Missing required property 'path'");
            }
            if ((!args || args.protocol === undefined) && !opts.urn) {
                throw new Error("Missing required property 'protocol'");
            }
            if ((!args || args.retries === undefined) && !opts.urn) {
                throw new Error("Missing required property 'retries'");
            }
            if ((!args || args.timeout === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timeout'");
            }
            if ((!args || args.upstreamInfo === undefined) && !opts.urn) {
                throw new Error("Missing required property 'upstreamInfo'");
            }
            if ((!args || args.upstreamType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'upstreamType'");
            }
            resourceInputs["gatewayId"] = args ? args.gatewayId : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["path"] = args ? args.path : undefined;
            resourceInputs["protocol"] = args ? args.protocol : undefined;
            resourceInputs["retries"] = args ? args.retries : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["timeout"] = args ? args.timeout : undefined;
            resourceInputs["upstreamInfo"] = args ? args.upstreamInfo : undefined;
            resourceInputs["upstreamType"] = args ? args.upstreamType : undefined;
            resourceInputs["serviceId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CngwService.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CngwService resources.
 */
export interface CngwServiceState {
    /**
     * gateway ID.
     */
    gatewayId?: pulumi.Input<string>;
    /**
     * service name.
     */
    name?: pulumi.Input<string>;
    /**
     * path.
     */
    path?: pulumi.Input<string>;
    /**
     * protocol. Reference value:`https`, `http`, `tcp`, `udp`.
     */
    protocol?: pulumi.Input<string>;
    /**
     * retry times.
     */
    retries?: pulumi.Input<number>;
    /**
     * service id.
     */
    serviceId?: pulumi.Input<string>;
    /**
     * Deprecate ineffective tags Tag description list.
     *
     * @deprecated Deprecate ineffective tags
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * time out, unit:ms.
     */
    timeout?: pulumi.Input<number>;
    /**
     * service config information.
     */
    upstreamInfo?: pulumi.Input<inputs.Tse.CngwServiceUpstreamInfo>;
    /**
     * service type. Reference value:`Kubernetes`, `Registry`, `IPList`, `HostIP`, `Scf`.
     */
    upstreamType?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CngwService resource.
 */
export interface CngwServiceArgs {
    /**
     * gateway ID.
     */
    gatewayId: pulumi.Input<string>;
    /**
     * service name.
     */
    name?: pulumi.Input<string>;
    /**
     * path.
     */
    path: pulumi.Input<string>;
    /**
     * protocol. Reference value:`https`, `http`, `tcp`, `udp`.
     */
    protocol: pulumi.Input<string>;
    /**
     * retry times.
     */
    retries: pulumi.Input<number>;
    /**
     * Deprecate ineffective tags Tag description list.
     *
     * @deprecated Deprecate ineffective tags
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * time out, unit:ms.
     */
    timeout: pulumi.Input<number>;
    /**
     * service config information.
     */
    upstreamInfo: pulumi.Input<inputs.Tse.CngwServiceUpstreamInfo>;
    /**
     * service type. Reference value:`Kubernetes`, `Registry`, `IPList`, `HostIP`, `Scf`.
     */
    upstreamType: pulumi.Input<string>;
}