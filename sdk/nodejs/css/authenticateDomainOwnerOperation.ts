// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to verify the domain ownership by specified way when DomainNeedVerifyOwner failed in domain creation.
 *
 * ## Example Usage
 *
 * ### dnsCheck way:
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const dnsCheck = new tencentcloud.css.AuthenticateDomainOwnerOperation("dnsCheck", {
 *     domainName: "your_domain_name",
 *     verifyType: "dnsCheck",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### fileCheck way:
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const fileCheck = new tencentcloud.css.AuthenticateDomainOwnerOperation("fileCheck", {
 *     domainName: "your_domain_name",
 *     verifyType: "fileCheck",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class AuthenticateDomainOwnerOperation extends pulumi.CustomResource {
    /**
     * Get an existing AuthenticateDomainOwnerOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AuthenticateDomainOwnerOperationState, opts?: pulumi.CustomResourceOptions): AuthenticateDomainOwnerOperation {
        return new AuthenticateDomainOwnerOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Css/authenticateDomainOwnerOperation:AuthenticateDomainOwnerOperation';

    /**
     * Returns true if the given object is an instance of AuthenticateDomainOwnerOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AuthenticateDomainOwnerOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AuthenticateDomainOwnerOperation.__pulumiType;
    }

    /**
     * The domain name to verify.
     */
    public readonly domainName!: pulumi.Output<string>;
    /**
     * Authentication type. Possible values:`dnsCheck`: Immediately verify whether the resolution record of the configured dns is consistent with the content to be verified, and save the record if successful.`fileCheck`: Immediately verify whether the web file is consistent with the content to be verified, and save the record if successful.`dbCheck`: Check if authentication has been successful.
     */
    public readonly verifyType!: pulumi.Output<string | undefined>;

    /**
     * Create a AuthenticateDomainOwnerOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AuthenticateDomainOwnerOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AuthenticateDomainOwnerOperationArgs | AuthenticateDomainOwnerOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AuthenticateDomainOwnerOperationState | undefined;
            resourceInputs["domainName"] = state ? state.domainName : undefined;
            resourceInputs["verifyType"] = state ? state.verifyType : undefined;
        } else {
            const args = argsOrState as AuthenticateDomainOwnerOperationArgs | undefined;
            if ((!args || args.domainName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domainName'");
            }
            resourceInputs["domainName"] = args ? args.domainName : undefined;
            resourceInputs["verifyType"] = args ? args.verifyType : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(AuthenticateDomainOwnerOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AuthenticateDomainOwnerOperation resources.
 */
export interface AuthenticateDomainOwnerOperationState {
    /**
     * The domain name to verify.
     */
    domainName?: pulumi.Input<string>;
    /**
     * Authentication type. Possible values:`dnsCheck`: Immediately verify whether the resolution record of the configured dns is consistent with the content to be verified, and save the record if successful.`fileCheck`: Immediately verify whether the web file is consistent with the content to be verified, and save the record if successful.`dbCheck`: Check if authentication has been successful.
     */
    verifyType?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AuthenticateDomainOwnerOperation resource.
 */
export interface AuthenticateDomainOwnerOperationArgs {
    /**
     * The domain name to verify.
     */
    domainName: pulumi.Input<string>;
    /**
     * Authentication type. Possible values:`dnsCheck`: Immediately verify whether the resolution record of the configured dns is consistent with the content to be verified, and save the record if successful.`fileCheck`: Immediately verify whether the web file is consistent with the content to be verified, and save the record if successful.`dbCheck`: Check if authentication has been successful.
     */
    verifyType?: pulumi.Input<string>;
}
