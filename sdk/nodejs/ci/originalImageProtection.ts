// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manage original image protection functionality
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const foo = new tencentcloud.Ci.OriginalImageProtection("foo", {
 *     bucket: "examplebucket-1250000000",
 *     status: "on",
 * });
 * ```
 *
 * ## Import
 *
 * Resource original image protection can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Ci/originalImageProtection:OriginalImageProtection example examplebucket-1250000000
 * ```
 */
export class OriginalImageProtection extends pulumi.CustomResource {
    /**
     * Get an existing OriginalImageProtection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OriginalImageProtectionState, opts?: pulumi.CustomResourceOptions): OriginalImageProtection {
        return new OriginalImageProtection(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ci/originalImageProtection:OriginalImageProtection';

    /**
     * Returns true if the given object is an instance of OriginalImageProtection.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OriginalImageProtection {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OriginalImageProtection.__pulumiType;
    }

    /**
     * The name of a bucket, the format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * Whether original image protection is set, options: on/off.
     */
    public readonly status!: pulumi.Output<string>;

    /**
     * Create a OriginalImageProtection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OriginalImageProtectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OriginalImageProtectionArgs | OriginalImageProtectionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as OriginalImageProtectionState | undefined;
            resourceInputs["bucket"] = state ? state.bucket : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as OriginalImageProtectionArgs | undefined;
            if ((!args || args.bucket === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bucket'");
            }
            if ((!args || args.status === undefined) && !opts.urn) {
                throw new Error("Missing required property 'status'");
            }
            resourceInputs["bucket"] = args ? args.bucket : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(OriginalImageProtection.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OriginalImageProtection resources.
 */
export interface OriginalImageProtectionState {
    /**
     * The name of a bucket, the format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    bucket?: pulumi.Input<string>;
    /**
     * Whether original image protection is set, options: on/off.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OriginalImageProtection resource.
 */
export interface OriginalImageProtectionArgs {
    /**
     * The name of a bucket, the format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    bucket: pulumi.Input<string>;
    /**
     * Whether original image protection is set, options: on/off.
     */
    status: pulumi.Input<string>;
}