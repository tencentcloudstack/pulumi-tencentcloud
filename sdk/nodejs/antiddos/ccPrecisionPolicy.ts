// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a antiddos ccPrecisionPolicy
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const ccPrecisionPolicy = new tencentcloud.Antiddos.CcPrecisionPolicy("cc_precision_policy", {
 *     domain: "t.baidu.com",
 *     instanceId: "bgpip-0000078h",
 *     ip: "212.64.62.191",
 *     policyAction: "drop",
 *     policyLists: [
 *         {
 *             fieldName: "cgi",
 *             fieldType: "value",
 *             value: "a.com",
 *             valueOperator: "equal",
 *         },
 *         {
 *             fieldName: "ua",
 *             fieldType: "value",
 *             value: "test",
 *             valueOperator: "equal",
 *         },
 *     ],
 *     protocol: "http",
 * });
 * ```
 *
 * ## Import
 *
 * antiddos cc_precision_policy can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Antiddos/ccPrecisionPolicy:CcPrecisionPolicy cc_precision_policy ${instanceId}#${policyId}#${instanceIp}#${domain}#${protocol}
 * ```
 */
export class CcPrecisionPolicy extends pulumi.CustomResource {
    /**
     * Get an existing CcPrecisionPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CcPrecisionPolicyState, opts?: pulumi.CustomResourceOptions): CcPrecisionPolicy {
        return new CcPrecisionPolicy(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Antiddos/ccPrecisionPolicy:CcPrecisionPolicy';

    /**
     * Returns true if the given object is an instance of CcPrecisionPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CcPrecisionPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CcPrecisionPolicy.__pulumiType;
    }

    /**
     * domain.
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * Instance Id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Ip value.
     */
    public readonly ip!: pulumi.Output<string>;
    /**
     * policy type, alg or drop.
     */
    public readonly policyAction!: pulumi.Output<string>;
    /**
     * policy list.
     */
    public readonly policyLists!: pulumi.Output<outputs.Antiddos.CcPrecisionPolicyPolicyList[]>;
    /**
     * protocol http or https.
     */
    public readonly protocol!: pulumi.Output<string>;

    /**
     * Create a CcPrecisionPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CcPrecisionPolicyArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CcPrecisionPolicyArgs | CcPrecisionPolicyState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CcPrecisionPolicyState | undefined;
            resourceInputs["domain"] = state ? state.domain : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["ip"] = state ? state.ip : undefined;
            resourceInputs["policyAction"] = state ? state.policyAction : undefined;
            resourceInputs["policyLists"] = state ? state.policyLists : undefined;
            resourceInputs["protocol"] = state ? state.protocol : undefined;
        } else {
            const args = argsOrState as CcPrecisionPolicyArgs | undefined;
            if ((!args || args.domain === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domain'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.ip === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ip'");
            }
            if ((!args || args.policyAction === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyAction'");
            }
            if ((!args || args.policyLists === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyLists'");
            }
            if ((!args || args.protocol === undefined) && !opts.urn) {
                throw new Error("Missing required property 'protocol'");
            }
            resourceInputs["domain"] = args ? args.domain : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["ip"] = args ? args.ip : undefined;
            resourceInputs["policyAction"] = args ? args.policyAction : undefined;
            resourceInputs["policyLists"] = args ? args.policyLists : undefined;
            resourceInputs["protocol"] = args ? args.protocol : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CcPrecisionPolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CcPrecisionPolicy resources.
 */
export interface CcPrecisionPolicyState {
    /**
     * domain.
     */
    domain?: pulumi.Input<string>;
    /**
     * Instance Id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Ip value.
     */
    ip?: pulumi.Input<string>;
    /**
     * policy type, alg or drop.
     */
    policyAction?: pulumi.Input<string>;
    /**
     * policy list.
     */
    policyLists?: pulumi.Input<pulumi.Input<inputs.Antiddos.CcPrecisionPolicyPolicyList>[]>;
    /**
     * protocol http or https.
     */
    protocol?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CcPrecisionPolicy resource.
 */
export interface CcPrecisionPolicyArgs {
    /**
     * domain.
     */
    domain: pulumi.Input<string>;
    /**
     * Instance Id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Ip value.
     */
    ip: pulumi.Input<string>;
    /**
     * policy type, alg or drop.
     */
    policyAction: pulumi.Input<string>;
    /**
     * policy list.
     */
    policyLists: pulumi.Input<pulumi.Input<inputs.Antiddos.CcPrecisionPolicyPolicyList>[]>;
    /**
     * protocol http or https.
     */
    protocol: pulumi.Input<string>;
}