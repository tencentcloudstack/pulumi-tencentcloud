// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tse cngwGateway
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
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
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class CngwGateway extends pulumi.CustomResource {
    /**
     * Get an existing CngwGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CngwGatewayState, opts?: pulumi.CustomResourceOptions): CngwGateway {
        return new CngwGateway(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tse/cngwGateway:CngwGateway';

    /**
     * Returns true if the given object is an instance of CngwGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CngwGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CngwGateway.__pulumiType;
    }

    /**
     * description information, up to 120 characters.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * whether to enable CLS log. Default value: fasle.
     */
    public readonly enableCls!: pulumi.Output<boolean | undefined>;
    /**
     * engine region of gateway.
     */
    public readonly engineRegion!: pulumi.Output<string>;
    /**
     * product version. Reference value: `TRIAL`, `STANDARD`(default value), `PROFESSIONAL`.
     */
    public readonly featureVersion!: pulumi.Output<string>;
    /**
     * gateway vwersion. Reference value: `2.4.1`, `2.5.1`.
     */
    public readonly gatewayVersion!: pulumi.Output<string>;
    /**
     * ingress class name.
     */
    public readonly ingressClassName!: pulumi.Output<string>;
    /**
     * Port information that the instance listens to.
     */
    public /*out*/ readonly instancePorts!: pulumi.Output<outputs.Tse.CngwGatewayInstancePort[]>;
    /**
     * internet configration.
     */
    public readonly internetConfig!: pulumi.Output<outputs.Tse.CngwGatewayInternetConfig | undefined>;
    /**
     * public network outbound traffic bandwidth,[1,2048]Mbps.
     */
    public readonly internetMaxBandwidthOut!: pulumi.Output<number | undefined>;
    /**
     * gateway name, supports up to 60 characters.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * gateway node configration.
     */
    public readonly nodeConfig!: pulumi.Output<outputs.Tse.CngwGatewayNodeConfig>;
    /**
     * Public IP address list.
     */
    public /*out*/ readonly publicIpAddresses!: pulumi.Output<string[]>;
    /**
     * Tag description list.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * trade type. Reference value: `0`: postpaid, `1`:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    public readonly tradeType!: pulumi.Output<number | undefined>;
    /**
     * gateway type,currently only supports kong.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * vpc information.
     */
    public readonly vpcConfig!: pulumi.Output<outputs.Tse.CngwGatewayVpcConfig>;

    /**
     * Create a CngwGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CngwGatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CngwGatewayArgs | CngwGatewayState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CngwGatewayState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["enableCls"] = state ? state.enableCls : undefined;
            resourceInputs["engineRegion"] = state ? state.engineRegion : undefined;
            resourceInputs["featureVersion"] = state ? state.featureVersion : undefined;
            resourceInputs["gatewayVersion"] = state ? state.gatewayVersion : undefined;
            resourceInputs["ingressClassName"] = state ? state.ingressClassName : undefined;
            resourceInputs["instancePorts"] = state ? state.instancePorts : undefined;
            resourceInputs["internetConfig"] = state ? state.internetConfig : undefined;
            resourceInputs["internetMaxBandwidthOut"] = state ? state.internetMaxBandwidthOut : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nodeConfig"] = state ? state.nodeConfig : undefined;
            resourceInputs["publicIpAddresses"] = state ? state.publicIpAddresses : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["tradeType"] = state ? state.tradeType : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["vpcConfig"] = state ? state.vpcConfig : undefined;
        } else {
            const args = argsOrState as CngwGatewayArgs | undefined;
            if ((!args || args.gatewayVersion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'gatewayVersion'");
            }
            if ((!args || args.nodeConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'nodeConfig'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.vpcConfig === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vpcConfig'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["enableCls"] = args ? args.enableCls : undefined;
            resourceInputs["engineRegion"] = args ? args.engineRegion : undefined;
            resourceInputs["featureVersion"] = args ? args.featureVersion : undefined;
            resourceInputs["gatewayVersion"] = args ? args.gatewayVersion : undefined;
            resourceInputs["ingressClassName"] = args ? args.ingressClassName : undefined;
            resourceInputs["internetConfig"] = args ? args.internetConfig : undefined;
            resourceInputs["internetMaxBandwidthOut"] = args ? args.internetMaxBandwidthOut : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["nodeConfig"] = args ? args.nodeConfig : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tradeType"] = args ? args.tradeType : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["vpcConfig"] = args ? args.vpcConfig : undefined;
            resourceInputs["instancePorts"] = undefined /*out*/;
            resourceInputs["publicIpAddresses"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CngwGateway.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CngwGateway resources.
 */
export interface CngwGatewayState {
    /**
     * description information, up to 120 characters.
     */
    description?: pulumi.Input<string>;
    /**
     * whether to enable CLS log. Default value: fasle.
     */
    enableCls?: pulumi.Input<boolean>;
    /**
     * engine region of gateway.
     */
    engineRegion?: pulumi.Input<string>;
    /**
     * product version. Reference value: `TRIAL`, `STANDARD`(default value), `PROFESSIONAL`.
     */
    featureVersion?: pulumi.Input<string>;
    /**
     * gateway vwersion. Reference value: `2.4.1`, `2.5.1`.
     */
    gatewayVersion?: pulumi.Input<string>;
    /**
     * ingress class name.
     */
    ingressClassName?: pulumi.Input<string>;
    /**
     * Port information that the instance listens to.
     */
    instancePorts?: pulumi.Input<pulumi.Input<inputs.Tse.CngwGatewayInstancePort>[]>;
    /**
     * internet configration.
     */
    internetConfig?: pulumi.Input<inputs.Tse.CngwGatewayInternetConfig>;
    /**
     * public network outbound traffic bandwidth,[1,2048]Mbps.
     */
    internetMaxBandwidthOut?: pulumi.Input<number>;
    /**
     * gateway name, supports up to 60 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * gateway node configration.
     */
    nodeConfig?: pulumi.Input<inputs.Tse.CngwGatewayNodeConfig>;
    /**
     * Public IP address list.
     */
    publicIpAddresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * trade type. Reference value: `0`: postpaid, `1`:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    tradeType?: pulumi.Input<number>;
    /**
     * gateway type,currently only supports kong.
     */
    type?: pulumi.Input<string>;
    /**
     * vpc information.
     */
    vpcConfig?: pulumi.Input<inputs.Tse.CngwGatewayVpcConfig>;
}

/**
 * The set of arguments for constructing a CngwGateway resource.
 */
export interface CngwGatewayArgs {
    /**
     * description information, up to 120 characters.
     */
    description?: pulumi.Input<string>;
    /**
     * whether to enable CLS log. Default value: fasle.
     */
    enableCls?: pulumi.Input<boolean>;
    /**
     * engine region of gateway.
     */
    engineRegion?: pulumi.Input<string>;
    /**
     * product version. Reference value: `TRIAL`, `STANDARD`(default value), `PROFESSIONAL`.
     */
    featureVersion?: pulumi.Input<string>;
    /**
     * gateway vwersion. Reference value: `2.4.1`, `2.5.1`.
     */
    gatewayVersion: pulumi.Input<string>;
    /**
     * ingress class name.
     */
    ingressClassName?: pulumi.Input<string>;
    /**
     * internet configration.
     */
    internetConfig?: pulumi.Input<inputs.Tse.CngwGatewayInternetConfig>;
    /**
     * public network outbound traffic bandwidth,[1,2048]Mbps.
     */
    internetMaxBandwidthOut?: pulumi.Input<number>;
    /**
     * gateway name, supports up to 60 characters.
     */
    name?: pulumi.Input<string>;
    /**
     * gateway node configration.
     */
    nodeConfig: pulumi.Input<inputs.Tse.CngwGatewayNodeConfig>;
    /**
     * Tag description list.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * trade type. Reference value: `0`: postpaid, `1`:Prepaid (Interface does not support the creation of prepaid instances yet).
     */
    tradeType?: pulumi.Input<number>;
    /**
     * gateway type,currently only supports kong.
     */
    type: pulumi.Input<string>;
    /**
     * vpc information.
     */
    vpcConfig: pulumi.Input<inputs.Tse.CngwGatewayVpcConfig>;
}
