// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a waf moduleStatus
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.waf.ModuleStatus("example", {
 *     accessControl: 0,
 *     antiLeakage: 0,
 *     antiTamper: 1,
 *     apiProtection: 1,
 *     ccProtection: 1,
 *     domain: "demo.waf.com",
 *     webSecurity: 1,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * waf module_status can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Waf/moduleStatus:ModuleStatus example demo.waf.com
 * ```
 */
export class ModuleStatus extends pulumi.CustomResource {
    /**
     * Get an existing ModuleStatus resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ModuleStatusState, opts?: pulumi.CustomResourceOptions): ModuleStatus {
        return new ModuleStatus(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Waf/moduleStatus:ModuleStatus';

    /**
     * Returns true if the given object is an instance of ModuleStatus.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ModuleStatus {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ModuleStatus.__pulumiType;
    }

    /**
     * ACL module status, 0:closed, 1:opened.
     */
    public readonly accessControl!: pulumi.Output<number>;
    /**
     * Anti leakage module status, 0:closed, 1:opened.
     */
    public readonly antiLeakage!: pulumi.Output<number | undefined>;
    /**
     * Anti tamper module status, 0:closed, 1:opened.
     */
    public readonly antiTamper!: pulumi.Output<number | undefined>;
    /**
     * API security module status, 0:closed, 1:opened.
     */
    public readonly apiProtection!: pulumi.Output<number>;
    /**
     * CC module status, 0:closed, 1:opened.
     */
    public readonly ccProtection!: pulumi.Output<number>;
    /**
     * Domain.
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * WEB security module status, 0:closed, 1:opened.
     */
    public readonly webSecurity!: pulumi.Output<number>;

    /**
     * Create a ModuleStatus resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModuleStatusArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ModuleStatusArgs | ModuleStatusState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ModuleStatusState | undefined;
            resourceInputs["accessControl"] = state ? state.accessControl : undefined;
            resourceInputs["antiLeakage"] = state ? state.antiLeakage : undefined;
            resourceInputs["antiTamper"] = state ? state.antiTamper : undefined;
            resourceInputs["apiProtection"] = state ? state.apiProtection : undefined;
            resourceInputs["ccProtection"] = state ? state.ccProtection : undefined;
            resourceInputs["domain"] = state ? state.domain : undefined;
            resourceInputs["webSecurity"] = state ? state.webSecurity : undefined;
        } else {
            const args = argsOrState as ModuleStatusArgs | undefined;
            if ((!args || args.accessControl === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accessControl'");
            }
            if ((!args || args.apiProtection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiProtection'");
            }
            if ((!args || args.ccProtection === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ccProtection'");
            }
            if ((!args || args.domain === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domain'");
            }
            if ((!args || args.webSecurity === undefined) && !opts.urn) {
                throw new Error("Missing required property 'webSecurity'");
            }
            resourceInputs["accessControl"] = args ? args.accessControl : undefined;
            resourceInputs["antiLeakage"] = args ? args.antiLeakage : undefined;
            resourceInputs["antiTamper"] = args ? args.antiTamper : undefined;
            resourceInputs["apiProtection"] = args ? args.apiProtection : undefined;
            resourceInputs["ccProtection"] = args ? args.ccProtection : undefined;
            resourceInputs["domain"] = args ? args.domain : undefined;
            resourceInputs["webSecurity"] = args ? args.webSecurity : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ModuleStatus.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ModuleStatus resources.
 */
export interface ModuleStatusState {
    /**
     * ACL module status, 0:closed, 1:opened.
     */
    accessControl?: pulumi.Input<number>;
    /**
     * Anti leakage module status, 0:closed, 1:opened.
     */
    antiLeakage?: pulumi.Input<number>;
    /**
     * Anti tamper module status, 0:closed, 1:opened.
     */
    antiTamper?: pulumi.Input<number>;
    /**
     * API security module status, 0:closed, 1:opened.
     */
    apiProtection?: pulumi.Input<number>;
    /**
     * CC module status, 0:closed, 1:opened.
     */
    ccProtection?: pulumi.Input<number>;
    /**
     * Domain.
     */
    domain?: pulumi.Input<string>;
    /**
     * WEB security module status, 0:closed, 1:opened.
     */
    webSecurity?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ModuleStatus resource.
 */
export interface ModuleStatusArgs {
    /**
     * ACL module status, 0:closed, 1:opened.
     */
    accessControl: pulumi.Input<number>;
    /**
     * Anti leakage module status, 0:closed, 1:opened.
     */
    antiLeakage?: pulumi.Input<number>;
    /**
     * Anti tamper module status, 0:closed, 1:opened.
     */
    antiTamper?: pulumi.Input<number>;
    /**
     * API security module status, 0:closed, 1:opened.
     */
    apiProtection: pulumi.Input<number>;
    /**
     * CC module status, 0:closed, 1:opened.
     */
    ccProtection: pulumi.Input<number>;
    /**
     * Domain.
     */
    domain: pulumi.Input<string>;
    /**
     * WEB security module status, 0:closed, 1:opened.
     */
    webSecurity: pulumi.Input<number>;
}
