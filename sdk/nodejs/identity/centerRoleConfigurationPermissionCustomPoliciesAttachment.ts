// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a organization tencentcloud.Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachment
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const identityCenterRoleConfigurationPermissionCustomPoliciesAttachment = new tencentcloud.identity.CenterRoleConfigurationPermissionCustomPoliciesAttachment("identityCenterRoleConfigurationPermissionCustomPoliciesAttachment", {
 *     zoneId: "z-xxxxxx",
 *     roleConfigurationId: "rc-xxxxxx",
 *     policies: [
 *         {
 *             rolePolicyName: "CustomPolicy2",
 *             rolePolicyDocument: `{
 *     "version": "2.0",
 *     "statement": [
 *         {
 *             "effect": "allow",
 *             "action": [
 *                 "vpc:AcceptAttachCcnInstances"
 *             ],
 *             "resource": [
 *                 "*"
 *             ]
 *         }
 *     ]
 * }
 * `,
 *         },
 *         {
 *             rolePolicyName: "CustomPolicy1",
 *             rolePolicyDocument: `{
 *     "version": "2.0",
 *     "statement": [
 *         {
 *             "effect": "allow",
 *             "action": [
 *                 "vpc:AcceptAttachCcnInstances"
 *             ],
 *             "resource": [
 *                 "*"
 *             ]
 *         }
 *     ]
 * }
 * `,
 *         },
 *     ],
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * organization tencentcloud_identity_center_role_configuration_permission_custom_policies_attachment can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Identity/centerRoleConfigurationPermissionCustomPoliciesAttachment:CenterRoleConfigurationPermissionCustomPoliciesAttachment identity_center_role_configuration_permission_custom_policies_attachment ${zoneId}#${roleConfigurationId}#${rolePolicyName1},...${rolePolicyNameN}
 * ```
 */
export class CenterRoleConfigurationPermissionCustomPoliciesAttachment extends pulumi.CustomResource {
    /**
     * Get an existing CenterRoleConfigurationPermissionCustomPoliciesAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CenterRoleConfigurationPermissionCustomPoliciesAttachmentState, opts?: pulumi.CustomResourceOptions): CenterRoleConfigurationPermissionCustomPoliciesAttachment {
        return new CenterRoleConfigurationPermissionCustomPoliciesAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Identity/centerRoleConfigurationPermissionCustomPoliciesAttachment:CenterRoleConfigurationPermissionCustomPoliciesAttachment';

    /**
     * Returns true if the given object is an instance of CenterRoleConfigurationPermissionCustomPoliciesAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CenterRoleConfigurationPermissionCustomPoliciesAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CenterRoleConfigurationPermissionCustomPoliciesAttachment.__pulumiType;
    }

    /**
     * Policies.
     */
    public readonly policies!: pulumi.Output<outputs.Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicy[]>;
    /**
     * Permission configuration ID.
     */
    public readonly roleConfigurationId!: pulumi.Output<string>;
    /**
     * Space ID.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a CenterRoleConfigurationPermissionCustomPoliciesAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs | CenterRoleConfigurationPermissionCustomPoliciesAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CenterRoleConfigurationPermissionCustomPoliciesAttachmentState | undefined;
            resourceInputs["policies"] = state ? state.policies : undefined;
            resourceInputs["roleConfigurationId"] = state ? state.roleConfigurationId : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs | undefined;
            if ((!args || args.policies === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policies'");
            }
            if ((!args || args.roleConfigurationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'roleConfigurationId'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["policies"] = args ? args.policies : undefined;
            resourceInputs["roleConfigurationId"] = args ? args.roleConfigurationId : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CenterRoleConfigurationPermissionCustomPoliciesAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CenterRoleConfigurationPermissionCustomPoliciesAttachment resources.
 */
export interface CenterRoleConfigurationPermissionCustomPoliciesAttachmentState {
    /**
     * Policies.
     */
    policies?: pulumi.Input<pulumi.Input<inputs.Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicy>[]>;
    /**
     * Permission configuration ID.
     */
    roleConfigurationId?: pulumi.Input<string>;
    /**
     * Space ID.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CenterRoleConfigurationPermissionCustomPoliciesAttachment resource.
 */
export interface CenterRoleConfigurationPermissionCustomPoliciesAttachmentArgs {
    /**
     * Policies.
     */
    policies: pulumi.Input<pulumi.Input<inputs.Identity.CenterRoleConfigurationPermissionCustomPoliciesAttachmentPolicy>[]>;
    /**
     * Permission configuration ID.
     */
    roleConfigurationId: pulumi.Input<string>;
    /**
     * Space ID.
     */
    zoneId: pulumi.Input<string>;
}