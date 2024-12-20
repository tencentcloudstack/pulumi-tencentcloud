// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a organization inviteOrganizationMemberOperation
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const inviteOrganizationMemberOperation = new tencentcloud.invite.OrganizationMemberOperation("inviteOrganizationMemberOperation", {
 *     isAllowQuit: "Allow",
 *     memberUin: "xxxxxx",
 *     nodeId: "xxxxxx",
 *     permissionIds: [
 *         1,
 *         2,
 *         4,
 *     ],
 *     policyType: "Financial",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class OrganizationMemberOperation extends pulumi.CustomResource {
    /**
     * Get an existing OrganizationMemberOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OrganizationMemberOperationState, opts?: pulumi.CustomResourceOptions): OrganizationMemberOperation {
        return new OrganizationMemberOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Invite/organizationMemberOperation:OrganizationMemberOperation';

    /**
     * Returns true if the given object is an instance of OrganizationMemberOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OrganizationMemberOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OrganizationMemberOperation.__pulumiType;
    }

    /**
     * List of supporting documents of mutual trust entities.
     */
    public readonly authFiles!: pulumi.Output<outputs.Invite.OrganizationMemberOperationAuthFile[] | undefined>;
    /**
     * Whether to allow members to withdraw. Allow: Allow, Disallow: Denied.
     */
    public readonly isAllowQuit!: pulumi.Output<string | undefined>;
    /**
     * Invited account Uin.
     */
    public readonly memberUin!: pulumi.Output<number>;
    /**
     * Member name. The maximum length is 25 characters and supports English letters, numbers, Chinese characters, symbols `+`, `@`, `&`, `.`, `[`, `]`, `-`, `:`, `,` and enumeration comma.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Node ID of the member's department.
     */
    public readonly nodeId!: pulumi.Output<number>;
    /**
     * Payer Uin. Member needs to pay on behalf of.
     */
    public readonly payUin!: pulumi.Output<string | undefined>;
    /**
     * List of member financial authority IDs. Values: 1-View bill, 2-View balance, 3-Fund transfer, 4-Consolidated disbursement, 5-Invoice, 6-Benefit inheritance, 7-Proxy payment, 1 and 2 must be default.
     */
    public readonly permissionIds!: pulumi.Output<number[]>;
    /**
     * Relationship strategies. Value taken: Financial.
     */
    public readonly policyType!: pulumi.Output<string>;
    /**
     * Name of the real-name subject of mutual trust.
     */
    public readonly relationAuthName!: pulumi.Output<string | undefined>;
    /**
     * Remark.
     */
    public readonly remark!: pulumi.Output<string | undefined>;
    /**
     * List of member tags. Maximum 10.
     */
    public readonly tags!: pulumi.Output<outputs.Invite.OrganizationMemberOperationTag[] | undefined>;

    /**
     * Create a OrganizationMemberOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OrganizationMemberOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OrganizationMemberOperationArgs | OrganizationMemberOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OrganizationMemberOperationState | undefined;
            resourceInputs["authFiles"] = state ? state.authFiles : undefined;
            resourceInputs["isAllowQuit"] = state ? state.isAllowQuit : undefined;
            resourceInputs["memberUin"] = state ? state.memberUin : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["nodeId"] = state ? state.nodeId : undefined;
            resourceInputs["payUin"] = state ? state.payUin : undefined;
            resourceInputs["permissionIds"] = state ? state.permissionIds : undefined;
            resourceInputs["policyType"] = state ? state.policyType : undefined;
            resourceInputs["relationAuthName"] = state ? state.relationAuthName : undefined;
            resourceInputs["remark"] = state ? state.remark : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as OrganizationMemberOperationArgs | undefined;
            if ((!args || args.memberUin === undefined) && !opts.urn) {
                throw new Error("Missing required property 'memberUin'");
            }
            if ((!args || args.nodeId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'nodeId'");
            }
            if ((!args || args.permissionIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'permissionIds'");
            }
            if ((!args || args.policyType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'policyType'");
            }
            resourceInputs["authFiles"] = args ? args.authFiles : undefined;
            resourceInputs["isAllowQuit"] = args ? args.isAllowQuit : undefined;
            resourceInputs["memberUin"] = args ? args.memberUin : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["nodeId"] = args ? args.nodeId : undefined;
            resourceInputs["payUin"] = args ? args.payUin : undefined;
            resourceInputs["permissionIds"] = args ? args.permissionIds : undefined;
            resourceInputs["policyType"] = args ? args.policyType : undefined;
            resourceInputs["relationAuthName"] = args ? args.relationAuthName : undefined;
            resourceInputs["remark"] = args ? args.remark : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OrganizationMemberOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OrganizationMemberOperation resources.
 */
export interface OrganizationMemberOperationState {
    /**
     * List of supporting documents of mutual trust entities.
     */
    authFiles?: pulumi.Input<pulumi.Input<inputs.Invite.OrganizationMemberOperationAuthFile>[]>;
    /**
     * Whether to allow members to withdraw. Allow: Allow, Disallow: Denied.
     */
    isAllowQuit?: pulumi.Input<string>;
    /**
     * Invited account Uin.
     */
    memberUin?: pulumi.Input<number>;
    /**
     * Member name. The maximum length is 25 characters and supports English letters, numbers, Chinese characters, symbols `+`, `@`, `&`, `.`, `[`, `]`, `-`, `:`, `,` and enumeration comma.
     */
    name?: pulumi.Input<string>;
    /**
     * Node ID of the member's department.
     */
    nodeId?: pulumi.Input<number>;
    /**
     * Payer Uin. Member needs to pay on behalf of.
     */
    payUin?: pulumi.Input<string>;
    /**
     * List of member financial authority IDs. Values: 1-View bill, 2-View balance, 3-Fund transfer, 4-Consolidated disbursement, 5-Invoice, 6-Benefit inheritance, 7-Proxy payment, 1 and 2 must be default.
     */
    permissionIds?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Relationship strategies. Value taken: Financial.
     */
    policyType?: pulumi.Input<string>;
    /**
     * Name of the real-name subject of mutual trust.
     */
    relationAuthName?: pulumi.Input<string>;
    /**
     * Remark.
     */
    remark?: pulumi.Input<string>;
    /**
     * List of member tags. Maximum 10.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.Invite.OrganizationMemberOperationTag>[]>;
}

/**
 * The set of arguments for constructing a OrganizationMemberOperation resource.
 */
export interface OrganizationMemberOperationArgs {
    /**
     * List of supporting documents of mutual trust entities.
     */
    authFiles?: pulumi.Input<pulumi.Input<inputs.Invite.OrganizationMemberOperationAuthFile>[]>;
    /**
     * Whether to allow members to withdraw. Allow: Allow, Disallow: Denied.
     */
    isAllowQuit?: pulumi.Input<string>;
    /**
     * Invited account Uin.
     */
    memberUin: pulumi.Input<number>;
    /**
     * Member name. The maximum length is 25 characters and supports English letters, numbers, Chinese characters, symbols `+`, `@`, `&`, `.`, `[`, `]`, `-`, `:`, `,` and enumeration comma.
     */
    name?: pulumi.Input<string>;
    /**
     * Node ID of the member's department.
     */
    nodeId: pulumi.Input<number>;
    /**
     * Payer Uin. Member needs to pay on behalf of.
     */
    payUin?: pulumi.Input<string>;
    /**
     * List of member financial authority IDs. Values: 1-View bill, 2-View balance, 3-Fund transfer, 4-Consolidated disbursement, 5-Invoice, 6-Benefit inheritance, 7-Proxy payment, 1 and 2 must be default.
     */
    permissionIds: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Relationship strategies. Value taken: Financial.
     */
    policyType: pulumi.Input<string>;
    /**
     * Name of the real-name subject of mutual trust.
     */
    relationAuthName?: pulumi.Input<string>;
    /**
     * Remark.
     */
    remark?: pulumi.Input<string>;
    /**
     * List of member tags. Maximum 10.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.Invite.OrganizationMemberOperationTag>[]>;
}
