// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class SecurityIpGroup extends pulumi.CustomResource {
    /**
     * Get an existing SecurityIpGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SecurityIpGroupState, opts?: pulumi.CustomResourceOptions): SecurityIpGroup {
        return new SecurityIpGroup(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Teo/securityIpGroup:SecurityIpGroup';

    /**
     * Returns true if the given object is an instance of SecurityIpGroup.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SecurityIpGroup {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SecurityIpGroup.__pulumiType;
    }

    /**
     * IP group information, replace all when modifying.
     */
    public readonly ipGroup!: pulumi.Output<outputs.Teo.SecurityIpGroupIpGroup>;
    /**
     * Site ID.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a SecurityIpGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SecurityIpGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SecurityIpGroupArgs | SecurityIpGroupState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SecurityIpGroupState | undefined;
            resourceInputs["ipGroup"] = state ? state.ipGroup : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as SecurityIpGroupArgs | undefined;
            if ((!args || args.ipGroup === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ipGroup'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["ipGroup"] = args ? args.ipGroup : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SecurityIpGroup.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SecurityIpGroup resources.
 */
export interface SecurityIpGroupState {
    /**
     * IP group information, replace all when modifying.
     */
    ipGroup?: pulumi.Input<inputs.Teo.SecurityIpGroupIpGroup>;
    /**
     * Site ID.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SecurityIpGroup resource.
 */
export interface SecurityIpGroupArgs {
    /**
     * IP group information, replace all when modifying.
     */
    ipGroup: pulumi.Input<inputs.Teo.SecurityIpGroupIpGroup>;
    /**
     * Site ID.
     */
    zoneId: pulumi.Input<string>;
}
