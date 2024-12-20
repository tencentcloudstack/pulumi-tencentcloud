// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to manage identity center scim synchronization status
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const identityCenterScimSynchronizationStatus = new tencentcloud.identity.CenterScimSynchronizationStatus("identityCenterScimSynchronizationStatus", {
 *     scimSynchronizationStatus: "Enabled",
 *     zoneId: "z-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * organization identity_center_scim_synchronization_status can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Identity/centerScimSynchronizationStatus:CenterScimSynchronizationStatus identity_center_scim_synchronization_status ${zone_id}
 * ```
 */
export class CenterScimSynchronizationStatus extends pulumi.CustomResource {
    /**
     * Get an existing CenterScimSynchronizationStatus resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CenterScimSynchronizationStatusState, opts?: pulumi.CustomResourceOptions): CenterScimSynchronizationStatus {
        return new CenterScimSynchronizationStatus(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Identity/centerScimSynchronizationStatus:CenterScimSynchronizationStatus';

    /**
     * Returns true if the given object is an instance of CenterScimSynchronizationStatus.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is CenterScimSynchronizationStatus {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === CenterScimSynchronizationStatus.__pulumiType;
    }

    /**
     * SCIM synchronization status. Enabled-enabled. Disabled-disables.
     */
    public readonly scimSynchronizationStatus!: pulumi.Output<string>;
    /**
     * Space ID. z-prefix starts with 12 random digits/lowercase letters.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a CenterScimSynchronizationStatus resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CenterScimSynchronizationStatusArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CenterScimSynchronizationStatusArgs | CenterScimSynchronizationStatusState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as CenterScimSynchronizationStatusState | undefined;
            resourceInputs["scimSynchronizationStatus"] = state ? state.scimSynchronizationStatus : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as CenterScimSynchronizationStatusArgs | undefined;
            if ((!args || args.scimSynchronizationStatus === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scimSynchronizationStatus'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["scimSynchronizationStatus"] = args ? args.scimSynchronizationStatus : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(CenterScimSynchronizationStatus.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering CenterScimSynchronizationStatus resources.
 */
export interface CenterScimSynchronizationStatusState {
    /**
     * SCIM synchronization status. Enabled-enabled. Disabled-disables.
     */
    scimSynchronizationStatus?: pulumi.Input<string>;
    /**
     * Space ID. z-prefix starts with 12 random digits/lowercase letters.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a CenterScimSynchronizationStatus resource.
 */
export interface CenterScimSynchronizationStatusArgs {
    /**
     * SCIM synchronization status. Enabled-enabled. Disabled-disables.
     */
    scimSynchronizationStatus: pulumi.Input<string>;
    /**
     * Space ID. z-prefix starts with 12 random digits/lowercase letters.
     */
    zoneId: pulumi.Input<string>;
}
