// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tse cngwRoute
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
 * const cngwRoute = new tencentcloud.tse.CngwRoute("cngwRoute", {
 *     destinationPorts: [],
 *     gatewayId: cngwGateway.id,
 *     hosts: ["192.168.0.1:9090"],
 *     httpsRedirectStatusCode: 426,
 *     paths: ["/user"],
 *     headers: [{
 *         key: "req",
 *         value: "terraform",
 *     }],
 *     preserveHost: false,
 *     protocols: [
 *         "http",
 *         "https",
 *     ],
 *     routeName: "terraform-route",
 *     serviceId: cngwService.serviceId,
 *     stripPath: true,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class CngwRoute extends pulumi.CustomResource {
    /**
     * Get an existing CngwRoute resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CngwRouteState, opts?: pulumi.CustomResourceOptions): CngwRoute {
        return new CngwRoute(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tse/cngwRoute:CngwRoute';

    /**
     * Returns true if the given object is an instance of CngwRoute.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CngwRoute {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CngwRoute.__pulumiType;
    }

    /**
     * destination port for Layer 4 matching.
     */
    public readonly destinationPorts!: pulumi.Output<number[] | undefined>;
    /**
     * This field has been deprecated and will be deleted in subsequent versions. whether to enable forced HTTPS, no longer use.
     *
     * @deprecated This field has been deprecated and will be deleted in subsequent versions.
     */
    public readonly forceHttps!: pulumi.Output<boolean | undefined>;
    /**
     * gateway ID.
     */
    public readonly gatewayId!: pulumi.Output<string>;
    /**
     * the headers of route.
     */
    public readonly headers!: pulumi.Output<outputs.Tse.CngwRouteHeader[] | undefined>;
    /**
     * host list.
     */
    public readonly hosts!: pulumi.Output<string[] | undefined>;
    /**
     * https redirection status code.
     */
    public readonly httpsRedirectStatusCode!: pulumi.Output<number | undefined>;
    /**
     * route methods. Reference value:`GET`,`POST`,`DELETE`,`PUT`,`OPTIONS`,`PATCH`,`HEAD`,`ANY`,`TRACE`,`COPY`,`MOVE`,`PROPFIND`,`PROPPATCH`,`MKCOL`,`LOCK`,`UNLOCK`.
     */
    public readonly methods!: pulumi.Output<string[] | undefined>;
    /**
     * path list.
     */
    public readonly paths!: pulumi.Output<string[] | undefined>;
    /**
     * whether to keep the host when forwarding to the backend.
     */
    public readonly preserveHost!: pulumi.Output<boolean | undefined>;
    /**
     * the protocol list of route.Reference value:`https`,`http`.
     */
    public readonly protocols!: pulumi.Output<string[] | undefined>;
    /**
     * the id of the route, unique in the instance.
     */
    public /*out*/ readonly routeId!: pulumi.Output<string>;
    /**
     * the name of the route, unique in the instance.
     */
    public readonly routeName!: pulumi.Output<string | undefined>;
    /**
     * ID of the service which the route belongs to.
     */
    public readonly serviceId!: pulumi.Output<string>;
    /**
     * whether to strip path when forwarding to the backend.
     */
    public readonly stripPath!: pulumi.Output<boolean | undefined>;

    /**
     * Create a CngwRoute resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CngwRouteArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CngwRouteArgs | CngwRouteState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CngwRouteState | undefined;
            resourceInputs["destinationPorts"] = state ? state.destinationPorts : undefined;
            resourceInputs["forceHttps"] = state ? state.forceHttps : undefined;
            resourceInputs["gatewayId"] = state ? state.gatewayId : undefined;
            resourceInputs["headers"] = state ? state.headers : undefined;
            resourceInputs["hosts"] = state ? state.hosts : undefined;
            resourceInputs["httpsRedirectStatusCode"] = state ? state.httpsRedirectStatusCode : undefined;
            resourceInputs["methods"] = state ? state.methods : undefined;
            resourceInputs["paths"] = state ? state.paths : undefined;
            resourceInputs["preserveHost"] = state ? state.preserveHost : undefined;
            resourceInputs["protocols"] = state ? state.protocols : undefined;
            resourceInputs["routeId"] = state ? state.routeId : undefined;
            resourceInputs["routeName"] = state ? state.routeName : undefined;
            resourceInputs["serviceId"] = state ? state.serviceId : undefined;
            resourceInputs["stripPath"] = state ? state.stripPath : undefined;
        } else {
            const args = argsOrState as CngwRouteArgs | undefined;
            if ((!args || args.gatewayId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'gatewayId'");
            }
            if ((!args || args.serviceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceId'");
            }
            resourceInputs["destinationPorts"] = args ? args.destinationPorts : undefined;
            resourceInputs["forceHttps"] = args ? args.forceHttps : undefined;
            resourceInputs["gatewayId"] = args ? args.gatewayId : undefined;
            resourceInputs["headers"] = args ? args.headers : undefined;
            resourceInputs["hosts"] = args ? args.hosts : undefined;
            resourceInputs["httpsRedirectStatusCode"] = args ? args.httpsRedirectStatusCode : undefined;
            resourceInputs["methods"] = args ? args.methods : undefined;
            resourceInputs["paths"] = args ? args.paths : undefined;
            resourceInputs["preserveHost"] = args ? args.preserveHost : undefined;
            resourceInputs["protocols"] = args ? args.protocols : undefined;
            resourceInputs["routeName"] = args ? args.routeName : undefined;
            resourceInputs["serviceId"] = args ? args.serviceId : undefined;
            resourceInputs["stripPath"] = args ? args.stripPath : undefined;
            resourceInputs["routeId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CngwRoute.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CngwRoute resources.
 */
export interface CngwRouteState {
    /**
     * destination port for Layer 4 matching.
     */
    destinationPorts?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * This field has been deprecated and will be deleted in subsequent versions. whether to enable forced HTTPS, no longer use.
     *
     * @deprecated This field has been deprecated and will be deleted in subsequent versions.
     */
    forceHttps?: pulumi.Input<boolean>;
    /**
     * gateway ID.
     */
    gatewayId?: pulumi.Input<string>;
    /**
     * the headers of route.
     */
    headers?: pulumi.Input<pulumi.Input<inputs.Tse.CngwRouteHeader>[]>;
    /**
     * host list.
     */
    hosts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * https redirection status code.
     */
    httpsRedirectStatusCode?: pulumi.Input<number>;
    /**
     * route methods. Reference value:`GET`,`POST`,`DELETE`,`PUT`,`OPTIONS`,`PATCH`,`HEAD`,`ANY`,`TRACE`,`COPY`,`MOVE`,`PROPFIND`,`PROPPATCH`,`MKCOL`,`LOCK`,`UNLOCK`.
     */
    methods?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * path list.
     */
    paths?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * whether to keep the host when forwarding to the backend.
     */
    preserveHost?: pulumi.Input<boolean>;
    /**
     * the protocol list of route.Reference value:`https`,`http`.
     */
    protocols?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * the id of the route, unique in the instance.
     */
    routeId?: pulumi.Input<string>;
    /**
     * the name of the route, unique in the instance.
     */
    routeName?: pulumi.Input<string>;
    /**
     * ID of the service which the route belongs to.
     */
    serviceId?: pulumi.Input<string>;
    /**
     * whether to strip path when forwarding to the backend.
     */
    stripPath?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a CngwRoute resource.
 */
export interface CngwRouteArgs {
    /**
     * destination port for Layer 4 matching.
     */
    destinationPorts?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * This field has been deprecated and will be deleted in subsequent versions. whether to enable forced HTTPS, no longer use.
     *
     * @deprecated This field has been deprecated and will be deleted in subsequent versions.
     */
    forceHttps?: pulumi.Input<boolean>;
    /**
     * gateway ID.
     */
    gatewayId: pulumi.Input<string>;
    /**
     * the headers of route.
     */
    headers?: pulumi.Input<pulumi.Input<inputs.Tse.CngwRouteHeader>[]>;
    /**
     * host list.
     */
    hosts?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * https redirection status code.
     */
    httpsRedirectStatusCode?: pulumi.Input<number>;
    /**
     * route methods. Reference value:`GET`,`POST`,`DELETE`,`PUT`,`OPTIONS`,`PATCH`,`HEAD`,`ANY`,`TRACE`,`COPY`,`MOVE`,`PROPFIND`,`PROPPATCH`,`MKCOL`,`LOCK`,`UNLOCK`.
     */
    methods?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * path list.
     */
    paths?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * whether to keep the host when forwarding to the backend.
     */
    preserveHost?: pulumi.Input<boolean>;
    /**
     * the protocol list of route.Reference value:`https`,`http`.
     */
    protocols?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * the name of the route, unique in the instance.
     */
    routeName?: pulumi.Input<string>;
    /**
     * ID of the service which the route belongs to.
     */
    serviceId: pulumi.Input<string>;
    /**
     * whether to strip path when forwarding to the backend.
     */
    stripPath?: pulumi.Input<boolean>;
}
