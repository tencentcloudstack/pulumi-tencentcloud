// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a eniSgAttachment
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const eniSgAttachment = new tencentcloud.Eni.SgAttachment("eni_sg_attachment", {
 *     networkInterfaceIds: "eni-p0hkgx8p",
 *     securityGroupIds: [
 *         "sg-902tl7t7",
 *         "sg-edmur627",
 *     ],
 * });
 * ```
 *
 * ## Import
 *
 * vpc eni_sg_attachment can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Eni/sgAttachment:SgAttachment eni_sg_attachment eni_sg_attachment_id
 * ```
 */
export class SgAttachment extends pulumi.CustomResource {
    /**
     * Get an existing SgAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SgAttachmentState, opts?: pulumi.CustomResourceOptions): SgAttachment {
        return new SgAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Eni/sgAttachment:SgAttachment';

    /**
     * Returns true if the given object is an instance of SgAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SgAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SgAttachment.__pulumiType;
    }

    /**
     * ENI instance ID. Such as:eni-pxir56ns. It Only support set one eni instance now.
     */
    public readonly networkInterfaceIds!: pulumi.Output<string>;
    /**
     * Security group instance ID, for example:sg-33ocnj9n, can be obtained through DescribeSecurityGroups. There is a limit of 100 instances per request.
     */
    public readonly securityGroupIds!: pulumi.Output<string[]>;

    /**
     * Create a SgAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SgAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SgAttachmentArgs | SgAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SgAttachmentState | undefined;
            resourceInputs["networkInterfaceIds"] = state ? state.networkInterfaceIds : undefined;
            resourceInputs["securityGroupIds"] = state ? state.securityGroupIds : undefined;
        } else {
            const args = argsOrState as SgAttachmentArgs | undefined;
            if ((!args || args.networkInterfaceIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'networkInterfaceIds'");
            }
            if ((!args || args.securityGroupIds === undefined) && !opts.urn) {
                throw new Error("Missing required property 'securityGroupIds'");
            }
            resourceInputs["networkInterfaceIds"] = args ? args.networkInterfaceIds : undefined;
            resourceInputs["securityGroupIds"] = args ? args.securityGroupIds : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SgAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SgAttachment resources.
 */
export interface SgAttachmentState {
    /**
     * ENI instance ID. Such as:eni-pxir56ns. It Only support set one eni instance now.
     */
    networkInterfaceIds?: pulumi.Input<string>;
    /**
     * Security group instance ID, for example:sg-33ocnj9n, can be obtained through DescribeSecurityGroups. There is a limit of 100 instances per request.
     */
    securityGroupIds?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a SgAttachment resource.
 */
export interface SgAttachmentArgs {
    /**
     * ENI instance ID. Such as:eni-pxir56ns. It Only support set one eni instance now.
     */
    networkInterfaceIds: pulumi.Input<string>;
    /**
     * Security group instance ID, for example:sg-33ocnj9n, can be obtained through DescribeSecurityGroups. There is a limit of 100 instances per request.
     */
    securityGroupIds: pulumi.Input<pulumi.Input<string>[]>;
}