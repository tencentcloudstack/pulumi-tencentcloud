// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dnspod modifyDomainOwner
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const modifyDomainOwner = new tencentcloud.dnspod.ModifyDomainOwnerOperation("modifyDomainOwner", {
 *     account: "xxxxxxxxx",
 *     domain: "dnspod.cn",
 *     domainId: 123,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ModifyDomainOwnerOperation extends pulumi.CustomResource {
    /**
     * Get an existing ModifyDomainOwnerOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ModifyDomainOwnerOperationState, opts?: pulumi.CustomResourceOptions): ModifyDomainOwnerOperation {
        return new ModifyDomainOwnerOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dnspod/modifyDomainOwnerOperation:ModifyDomainOwnerOperation';

    /**
     * Returns true if the given object is an instance of ModifyDomainOwnerOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ModifyDomainOwnerOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ModifyDomainOwnerOperation.__pulumiType;
    }

    /**
     * The account to which the domain needs to be transferred, supporting Uin or email format.
     */
    public readonly account!: pulumi.Output<string>;
    /**
     * Domain.
     */
    public readonly domain!: pulumi.Output<string>;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    public readonly domainId!: pulumi.Output<number | undefined>;

    /**
     * Create a ModifyDomainOwnerOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModifyDomainOwnerOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ModifyDomainOwnerOperationArgs | ModifyDomainOwnerOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ModifyDomainOwnerOperationState | undefined;
            resourceInputs["account"] = state ? state.account : undefined;
            resourceInputs["domain"] = state ? state.domain : undefined;
            resourceInputs["domainId"] = state ? state.domainId : undefined;
        } else {
            const args = argsOrState as ModifyDomainOwnerOperationArgs | undefined;
            if ((!args || args.account === undefined) && !opts.urn) {
                throw new Error("Missing required property 'account'");
            }
            if ((!args || args.domain === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domain'");
            }
            resourceInputs["account"] = args ? args.account : undefined;
            resourceInputs["domain"] = args ? args.domain : undefined;
            resourceInputs["domainId"] = args ? args.domainId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ModifyDomainOwnerOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ModifyDomainOwnerOperation resources.
 */
export interface ModifyDomainOwnerOperationState {
    /**
     * The account to which the domain needs to be transferred, supporting Uin or email format.
     */
    account?: pulumi.Input<string>;
    /**
     * Domain.
     */
    domain?: pulumi.Input<string>;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a ModifyDomainOwnerOperation resource.
 */
export interface ModifyDomainOwnerOperationArgs {
    /**
     * The account to which the domain needs to be transferred, supporting Uin or email format.
     */
    account: pulumi.Input<string>;
    /**
     * Domain.
     */
    domain: pulumi.Input<string>;
    /**
     * Domain ID. The parameter DomainId has a higher priority than the parameter Domain. If the parameter DomainId is passed, the parameter Domain will be ignored. You can find all Domains and DomainIds through the DescribeDomainList interface.
     */
    domainId?: pulumi.Input<number>;
}
