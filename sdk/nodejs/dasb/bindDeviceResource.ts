// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dasb bindDeviceResource
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.dasb.BindDeviceResource("example", {
 *     deviceIdSets: [
 *         17,
 *         18,
 *     ],
 *     resourceId: "bh-saas-weyosfym",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class BindDeviceResource extends pulumi.CustomResource {
    /**
     * Get an existing BindDeviceResource resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BindDeviceResourceState, opts?: pulumi.CustomResourceOptions): BindDeviceResource {
        return new BindDeviceResource(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dasb/bindDeviceResource:BindDeviceResource';

    /**
     * Returns true if the given object is an instance of BindDeviceResource.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BindDeviceResource {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BindDeviceResource.__pulumiType;
    }

    /**
     * Asset ID collection.
     */
    public readonly deviceIdSets!: pulumi.Output<number[]>;
    /**
     * Bastion host service ID.
     */
    public readonly resourceId!: pulumi.Output<string>;

    /**
     * Create a BindDeviceResource resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BindDeviceResourceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BindDeviceResourceArgs | BindDeviceResourceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as BindDeviceResourceState | undefined;
            resourceInputs["deviceIdSets"] = state ? state.deviceIdSets : undefined;
            resourceInputs["resourceId"] = state ? state.resourceId : undefined;
        } else {
            const args = argsOrState as BindDeviceResourceArgs | undefined;
            if ((!args || args.deviceIdSets === undefined) && !opts.urn) {
                throw new Error("Missing required property 'deviceIdSets'");
            }
            if ((!args || args.resourceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceId'");
            }
            resourceInputs["deviceIdSets"] = args ? args.deviceIdSets : undefined;
            resourceInputs["resourceId"] = args ? args.resourceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(BindDeviceResource.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BindDeviceResource resources.
 */
export interface BindDeviceResourceState {
    /**
     * Asset ID collection.
     */
    deviceIdSets?: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Bastion host service ID.
     */
    resourceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a BindDeviceResource resource.
 */
export interface BindDeviceResourceArgs {
    /**
     * Asset ID collection.
     */
    deviceIdSets: pulumi.Input<pulumi.Input<number>[]>;
    /**
     * Bastion host service ID.
     */
    resourceId: pulumi.Input<string>;
}
