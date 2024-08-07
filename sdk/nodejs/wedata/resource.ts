// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a wedata resource
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.wedata.Resource("example", {
 *     cosBucketName: "wedata-demo-1314991481",
 *     cosRegion: "ap-guangzhou",
 *     fileName: "tf_example",
 *     filePath: "/datastudio/resource/demo",
 *     filesSize: "8165",
 *     projectId: "1612982498218618880",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * wedata resource can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Wedata/resource:Resource example 1612982498218618880#/datastudio/resource/demo#75431931-7d27-4034-b3de-3dc3348a220e
 * ```
 */
export class Resource extends pulumi.CustomResource {
    /**
     * Get an existing Resource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ResourceState, opts?: pulumi.CustomResourceOptions): Resource {
        return new Resource(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Wedata/resource:Resource';

    /**
     * Returns true if the given object is an instance of Resource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Resource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Resource.__pulumiType;
    }

    /**
     * Cos bucket name.
     */
    public readonly cosBucketName!: pulumi.Output<string>;
    /**
     * Cos bucket region.
     */
    public readonly cosRegion!: pulumi.Output<string>;
    /**
     * File name.
     */
    public readonly fileName!: pulumi.Output<string>;
    /**
     * For file path:/datastudio/resource/projectId/folderName; for folder path:/datastudio/resource/folderName.
     */
    public readonly filePath!: pulumi.Output<string>;
    /**
     * File size.
     */
    public readonly filesSize!: pulumi.Output<string>;
    /**
     * Project ID.
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * Resource ID.
     */
    public /*out*/ readonly resourceId!: pulumi.Output<string>;

    /**
     * Create a Resource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ResourceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ResourceArgs | ResourceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ResourceState | undefined;
            resourceInputs["cosBucketName"] = state ? state.cosBucketName : undefined;
            resourceInputs["cosRegion"] = state ? state.cosRegion : undefined;
            resourceInputs["fileName"] = state ? state.fileName : undefined;
            resourceInputs["filePath"] = state ? state.filePath : undefined;
            resourceInputs["filesSize"] = state ? state.filesSize : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["resourceId"] = state ? state.resourceId : undefined;
        } else {
            const args = argsOrState as ResourceArgs | undefined;
            if ((!args || args.cosBucketName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cosBucketName'");
            }
            if ((!args || args.cosRegion === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cosRegion'");
            }
            if ((!args || args.fileName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'fileName'");
            }
            if ((!args || args.filePath === undefined) && !opts.urn) {
                throw new Error("Missing required property 'filePath'");
            }
            if ((!args || args.filesSize === undefined) && !opts.urn) {
                throw new Error("Missing required property 'filesSize'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            resourceInputs["cosBucketName"] = args ? args.cosBucketName : undefined;
            resourceInputs["cosRegion"] = args ? args.cosRegion : undefined;
            resourceInputs["fileName"] = args ? args.fileName : undefined;
            resourceInputs["filePath"] = args ? args.filePath : undefined;
            resourceInputs["filesSize"] = args ? args.filesSize : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["resourceId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Resource.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Resource resources.
 */
export interface ResourceState {
    /**
     * Cos bucket name.
     */
    cosBucketName?: pulumi.Input<string>;
    /**
     * Cos bucket region.
     */
    cosRegion?: pulumi.Input<string>;
    /**
     * File name.
     */
    fileName?: pulumi.Input<string>;
    /**
     * For file path:/datastudio/resource/projectId/folderName; for folder path:/datastudio/resource/folderName.
     */
    filePath?: pulumi.Input<string>;
    /**
     * File size.
     */
    filesSize?: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    resourceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Resource resource.
 */
export interface ResourceArgs {
    /**
     * Cos bucket name.
     */
    cosBucketName: pulumi.Input<string>;
    /**
     * Cos bucket region.
     */
    cosRegion: pulumi.Input<string>;
    /**
     * File name.
     */
    fileName: pulumi.Input<string>;
    /**
     * For file path:/datastudio/resource/projectId/folderName; for folder path:/datastudio/resource/folderName.
     */
    filePath: pulumi.Input<string>;
    /**
     * File size.
     */
    filesSize: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId: pulumi.Input<string>;
}
