// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cos bucketReferer
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const bucketReferer = new tencentcloud.Cos.BucketReferer("bucket_referer", {
 *     bucket: "mycos-1258798060",
 *     domainLists: [
 *         "127.0.0.1",
 *         "terraform.com",
 *     ],
 *     emptyReferConfiguration: "Allow",
 *     refererType: "Black-List",
 *     status: "Enabled",
 * });
 * ```
 *
 * ## Import
 *
 * cos bucket_referer can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Cos/bucketReferer:BucketReferer bucket_referer bucket_id
 * ```
 */
export class BucketReferer extends pulumi.CustomResource {
    /**
     * Get an existing BucketReferer resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BucketRefererState, opts?: pulumi.CustomResourceOptions): BucketReferer {
        return new BucketReferer(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cos/bucketReferer:BucketReferer';

    /**
     * Returns true if the given object is an instance of BucketReferer.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BucketReferer {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BucketReferer.__pulumiType;
    }

    /**
     * Bucket format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * A list of domain names in the blocklist/allowlist.
     */
    public readonly domainLists!: pulumi.Output<string[]>;
    /**
     * Whether to allow access with an empty referer. Enumerated values: `Allow`, `Deny` (default).
     */
    public readonly emptyReferConfiguration!: pulumi.Output<string | undefined>;
    /**
     * Hotlink protection type. Enumerated values: `Black-List`, `White-List`.
     */
    public readonly refererType!: pulumi.Output<string>;
    /**
     * Whether to enable hotlink protection. Enumerated values: `Enabled`, `Disabled`.
     */
    public readonly status!: pulumi.Output<string>;

    /**
     * Create a BucketReferer resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BucketRefererArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BucketRefererArgs | BucketRefererState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as BucketRefererState | undefined;
            resourceInputs["bucket"] = state ? state.bucket : undefined;
            resourceInputs["domainLists"] = state ? state.domainLists : undefined;
            resourceInputs["emptyReferConfiguration"] = state ? state.emptyReferConfiguration : undefined;
            resourceInputs["refererType"] = state ? state.refererType : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
        } else {
            const args = argsOrState as BucketRefererArgs | undefined;
            if ((!args || args.bucket === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bucket'");
            }
            if ((!args || args.domainLists === undefined) && !opts.urn) {
                throw new Error("Missing required property 'domainLists'");
            }
            if ((!args || args.refererType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'refererType'");
            }
            if ((!args || args.status === undefined) && !opts.urn) {
                throw new Error("Missing required property 'status'");
            }
            resourceInputs["bucket"] = args ? args.bucket : undefined;
            resourceInputs["domainLists"] = args ? args.domainLists : undefined;
            resourceInputs["emptyReferConfiguration"] = args ? args.emptyReferConfiguration : undefined;
            resourceInputs["refererType"] = args ? args.refererType : undefined;
            resourceInputs["status"] = args ? args.status : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(BucketReferer.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BucketReferer resources.
 */
export interface BucketRefererState {
    /**
     * Bucket format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    bucket?: pulumi.Input<string>;
    /**
     * A list of domain names in the blocklist/allowlist.
     */
    domainLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether to allow access with an empty referer. Enumerated values: `Allow`, `Deny` (default).
     */
    emptyReferConfiguration?: pulumi.Input<string>;
    /**
     * Hotlink protection type. Enumerated values: `Black-List`, `White-List`.
     */
    refererType?: pulumi.Input<string>;
    /**
     * Whether to enable hotlink protection. Enumerated values: `Enabled`, `Disabled`.
     */
    status?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a BucketReferer resource.
 */
export interface BucketRefererArgs {
    /**
     * Bucket format should be [custom name]-[appid], for example `mycos-1258798060`.
     */
    bucket: pulumi.Input<string>;
    /**
     * A list of domain names in the blocklist/allowlist.
     */
    domainLists: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Whether to allow access with an empty referer. Enumerated values: `Allow`, `Deny` (default).
     */
    emptyReferConfiguration?: pulumi.Input<string>;
    /**
     * Hotlink protection type. Enumerated values: `Black-List`, `White-List`.
     */
    refererType: pulumi.Input<string>;
    /**
     * Whether to enable hotlink protection. Enumerated values: `Enabled`, `Disabled`.
     */
    status: pulumi.Input<string>;
}