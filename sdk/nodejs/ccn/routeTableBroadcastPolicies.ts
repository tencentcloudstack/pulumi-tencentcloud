// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a CCN Route table broadcast policies.
 *
 * > **NOTE:** Use this resource to manage all broadcast policies under the routing table of CCN instances.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const config = new pulumi.Config();
 * const region = config.get("region") || "ap-guangzhou";
 * const availabilityZone = config.get("availabilityZone") || "ap-guangzhou-4";
 * // create vpc
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "172.16.0.0/16"});
 * // create subnet
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: availabilityZone,
 *     vpcId: vpc.id,
 *     cidrBlock: "172.16.0.0/24",
 *     isMulticast: false,
 * });
 * // create ccn
 * const exampleInstance = new tencentcloud.ccn.Instance("exampleInstance", {
 *     description: "desc.",
 *     qos: "AG",
 *     chargeType: "PREPAID",
 *     bandwidthLimitType: "INTER_REGION_LIMIT",
 *     tags: {
 *         createBy: "terraform",
 *     },
 * });
 * // create ccn route table
 * const exampleRouteTable = new tencentcloud.ccn.RouteTable("exampleRouteTable", {
 *     ccnId: exampleInstance.id,
 *     description: "desc.",
 * });
 * // attachment instance
 * const attachment = new tencentcloud.ccn.Attachment("attachment", {
 *     ccnId: exampleInstance.id,
 *     instanceId: vpc.id,
 *     instanceType: "VPC",
 *     instanceRegion: region,
 *     routeTableId: exampleRouteTable.id,
 * });
 * // create route table broadcast policy
 * const exampleRouteTableBroadcastPolicies = new tencentcloud.ccn.RouteTableBroadcastPolicies("exampleRouteTableBroadcastPolicies", {
 *     ccnId: exampleInstance.id,
 *     routeTableId: exampleRouteTable.id,
 *     policies: [{
 *         action: "accept",
 *         description: "desc.",
 *         routeConditions: [{
 *             name: "instance-region",
 *             values: ["ap-guangzhou"],
 *             matchPattern: 1,
 *         }],
 *         broadcastConditions: [{
 *             name: "instance-region",
 *             values: ["ap-shanghai"],
 *             matchPattern: 1,
 *         }],
 *     }],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * Ccn instance can be imported, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Ccn/routeTableBroadcastPolicies:RouteTableBroadcastPolicies example ccn-gr7nynbd#ccnrtb-jpf7bzn3
 * ```
 */
export class RouteTableBroadcastPolicies extends pulumi.CustomResource {
    /**
     * Get an existing RouteTableBroadcastPolicies resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RouteTableBroadcastPoliciesState, opts?: pulumi.CustomResourceOptions): RouteTableBroadcastPolicies {
        return new RouteTableBroadcastPolicies(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ccn/routeTableBroadcastPolicies:RouteTableBroadcastPolicies';

    /**
     * Returns true if the given object is an instance of RouteTableBroadcastPolicies.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RouteTableBroadcastPolicies {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RouteTableBroadcastPolicies.__pulumiType;
    }

    /**
     * CCN Instance ID.
     */
    public readonly ccnId!: pulumi.Output<string>;
    /**
     * Routing propagation strategy.
     */
    public readonly policies!: pulumi.Output<outputs.Ccn.RouteTableBroadcastPoliciesPolicy[]>;
    /**
     * CCN Route table ID.
     */
    public readonly routeTableId!: pulumi.Output<string>;

    /**
     * Create a RouteTableBroadcastPolicies resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteTableBroadcastPoliciesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RouteTableBroadcastPoliciesArgs | RouteTableBroadcastPoliciesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RouteTableBroadcastPoliciesState | undefined;
            resourceInputs["ccnId"] = state ? state.ccnId : undefined;
            resourceInputs["policies"] = state ? state.policies : undefined;
            resourceInputs["routeTableId"] = state ? state.routeTableId : undefined;
        } else {
            const args = argsOrState as RouteTableBroadcastPoliciesArgs | undefined;
            if ((!args || args.ccnId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ccnId'");
            }
            if ((!args || args.policies === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policies'");
            }
            if ((!args || args.routeTableId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'routeTableId'");
            }
            resourceInputs["ccnId"] = args ? args.ccnId : undefined;
            resourceInputs["policies"] = args ? args.policies : undefined;
            resourceInputs["routeTableId"] = args ? args.routeTableId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RouteTableBroadcastPolicies.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RouteTableBroadcastPolicies resources.
 */
export interface RouteTableBroadcastPoliciesState {
    /**
     * CCN Instance ID.
     */
    ccnId?: pulumi.Input<string>;
    /**
     * Routing propagation strategy.
     */
    policies?: pulumi.Input<pulumi.Input<inputs.Ccn.RouteTableBroadcastPoliciesPolicy>[]>;
    /**
     * CCN Route table ID.
     */
    routeTableId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RouteTableBroadcastPolicies resource.
 */
export interface RouteTableBroadcastPoliciesArgs {
    /**
     * CCN Instance ID.
     */
    ccnId: pulumi.Input<string>;
    /**
     * Routing propagation strategy.
     */
    policies: pulumi.Input<pulumi.Input<inputs.Ccn.RouteTableBroadcastPoliciesPolicy>[]>;
    /**
     * CCN Route table ID.
     */
    routeTableId: pulumi.Input<string>;
}
