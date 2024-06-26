// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a ci mediaSnapshotTemplate
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const mediaSnapshotTemplate = new tencentcloud.ci.MediaSnapshotTemplate("mediaSnapshotTemplate", {
 *     bucket: "terraform-ci-xxxxxx",
 *     snapshot: {
 *         count: "10",
 *         snapshotOutMode: "SnapshotAndSprite",
 *         spriteSnapshotConfig: {
 *             color: "White",
 *             columns: "10",
 *             lines: "10",
 *             margin: "10",
 *             padding: "10",
 *         },
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * ci media_snapshot_template can be imported using the bucket#templateId, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Ci/mediaSnapshotTemplate:MediaSnapshotTemplate media_snapshot_template terraform-ci-xxxxxx#t18210645f96564eaf80e86b1f58c20152
 * ```
 */
export class MediaSnapshotTemplate extends pulumi.CustomResource {
    /**
     * Get an existing MediaSnapshotTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: MediaSnapshotTemplateState, opts?: pulumi.CustomResourceOptions): MediaSnapshotTemplate {
        return new MediaSnapshotTemplate(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ci/mediaSnapshotTemplate:MediaSnapshotTemplate';

    /**
     * Returns true if the given object is an instance of MediaSnapshotTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MediaSnapshotTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MediaSnapshotTemplate.__pulumiType;
    }

    /**
     * bucket name.
     */
    public readonly bucket!: pulumi.Output<string>;
    /**
     * creation time.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * The template name only supports `Chinese`, `English`, `numbers`, `_`, `-` and `*`.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * screenshot.
     */
    public readonly snapshot!: pulumi.Output<outputs.Ci.MediaSnapshotTemplateSnapshot>;
    /**
     * Template ID.
     */
    public /*out*/ readonly templateId!: pulumi.Output<string>;
    /**
     * update time.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a MediaSnapshotTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MediaSnapshotTemplateArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: MediaSnapshotTemplateArgs | MediaSnapshotTemplateState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as MediaSnapshotTemplateState | undefined;
            resourceInputs["bucket"] = state ? state.bucket : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["snapshot"] = state ? state.snapshot : undefined;
            resourceInputs["templateId"] = state ? state.templateId : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as MediaSnapshotTemplateArgs | undefined;
            if ((!args || args.bucket === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bucket'");
            }
            if ((!args || args.snapshot === undefined) && !opts.urn) {
                throw new Error("Missing required property 'snapshot'");
            }
            resourceInputs["bucket"] = args ? args.bucket : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["snapshot"] = args ? args.snapshot : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["templateId"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(MediaSnapshotTemplate.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering MediaSnapshotTemplate resources.
 */
export interface MediaSnapshotTemplateState {
    /**
     * bucket name.
     */
    bucket?: pulumi.Input<string>;
    /**
     * creation time.
     */
    createTime?: pulumi.Input<string>;
    /**
     * The template name only supports `Chinese`, `English`, `numbers`, `_`, `-` and `*`.
     */
    name?: pulumi.Input<string>;
    /**
     * screenshot.
     */
    snapshot?: pulumi.Input<inputs.Ci.MediaSnapshotTemplateSnapshot>;
    /**
     * Template ID.
     */
    templateId?: pulumi.Input<string>;
    /**
     * update time.
     */
    updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a MediaSnapshotTemplate resource.
 */
export interface MediaSnapshotTemplateArgs {
    /**
     * bucket name.
     */
    bucket: pulumi.Input<string>;
    /**
     * The template name only supports `Chinese`, `English`, `numbers`, `_`, `-` and `*`.
     */
    name?: pulumi.Input<string>;
    /**
     * screenshot.
     */
    snapshot: pulumi.Input<inputs.Ci.MediaSnapshotTemplateSnapshot>;
}
