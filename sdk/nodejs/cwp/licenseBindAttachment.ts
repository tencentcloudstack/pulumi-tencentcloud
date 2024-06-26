// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a cwp licenseBindAttachment
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleMachinesSimple = tencentcloud.Cwp.getMachinesSimple({
 *     machineType: "CVM",
 *     machineRegion: "ap-guangzhou",
 *     projectIds: [1210293],
 *     filters: [{
 *         name: "Version",
 *         values: ["BASIC_VERSION"],
 *         exactMatch: true,
 *     }],
 * });
 * const exampleLicenseOrder = new tencentcloud.cwp.LicenseOrder("exampleLicenseOrder", {
 *     alias: "tf_example",
 *     licenseType: 0,
 *     licenseNum: 1,
 *     regionId: 1,
 *     projectId: 0,
 *     tags: {
 *         createdBy: "terraform",
 *     },
 * });
 * const exampleLicenseBindAttachment = new tencentcloud.cwp.LicenseBindAttachment("exampleLicenseBindAttachment", {
 *     resourceId: exampleLicenseOrder.resourceId,
 *     licenseId: exampleLicenseOrder.licenseId,
 *     licenseType: 0,
 *     quuid: exampleMachinesSimple.then(exampleMachinesSimple => exampleMachinesSimple.machines?.[0]?.quuid),
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * cwp license_bind_attachment can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Cwp/licenseBindAttachment:LicenseBindAttachment example cwplic-ab3edffa#44#2c7e5cce-1cec-4456-8d18-018f160dd987#0
 * ```
 */
export class LicenseBindAttachment extends pulumi.CustomResource {
    /**
     * Get an existing LicenseBindAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: LicenseBindAttachmentState, opts?: pulumi.CustomResourceOptions): LicenseBindAttachment {
        return new LicenseBindAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Cwp/licenseBindAttachment:LicenseBindAttachment';

    /**
     * Returns true if the given object is an instance of LicenseBindAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is LicenseBindAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === LicenseBindAttachment.__pulumiType;
    }

    /**
     * agent status.
     */
    public /*out*/ readonly agentStatus!: pulumi.Output<string>;
    /**
     * Is it allowed to change the binding, false is not allowed to change the binding.
     */
    public /*out*/ readonly isSwitchBind!: pulumi.Output<boolean>;
    /**
     * Allow unbinding, false does not allow unbinding.
     */
    public /*out*/ readonly isUnbind!: pulumi.Output<boolean>;
    /**
     * License ID.
     */
    public readonly licenseId!: pulumi.Output<number>;
    /**
     * LicenseType, 0 CWP Pro - Pay as you go, 1 CWP Pro - Monthly subscription, 2 CWP Ultimate - Monthly subscription. Default is 0.
     */
    public readonly licenseType!: pulumi.Output<number>;
    /**
     * machine ip.
     */
    public /*out*/ readonly machineIp!: pulumi.Output<string>;
    /**
     * machine name.
     */
    public /*out*/ readonly machineName!: pulumi.Output<string>;
    /**
     * machine wan ip.
     */
    public /*out*/ readonly machineWanIp!: pulumi.Output<string>;
    /**
     * Machine quota that needs to be bound.
     */
    public readonly quuid!: pulumi.Output<string>;
    /**
     * Resource ID.
     */
    public readonly resourceId!: pulumi.Output<string>;
    /**
     * uuid.
     */
    public /*out*/ readonly uuid!: pulumi.Output<string>;

    /**
     * Create a LicenseBindAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: LicenseBindAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: LicenseBindAttachmentArgs | LicenseBindAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as LicenseBindAttachmentState | undefined;
            resourceInputs["agentStatus"] = state ? state.agentStatus : undefined;
            resourceInputs["isSwitchBind"] = state ? state.isSwitchBind : undefined;
            resourceInputs["isUnbind"] = state ? state.isUnbind : undefined;
            resourceInputs["licenseId"] = state ? state.licenseId : undefined;
            resourceInputs["licenseType"] = state ? state.licenseType : undefined;
            resourceInputs["machineIp"] = state ? state.machineIp : undefined;
            resourceInputs["machineName"] = state ? state.machineName : undefined;
            resourceInputs["machineWanIp"] = state ? state.machineWanIp : undefined;
            resourceInputs["quuid"] = state ? state.quuid : undefined;
            resourceInputs["resourceId"] = state ? state.resourceId : undefined;
            resourceInputs["uuid"] = state ? state.uuid : undefined;
        } else {
            const args = argsOrState as LicenseBindAttachmentArgs | undefined;
            if ((!args || args.licenseId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'licenseId'");
            }
            if ((!args || args.licenseType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'licenseType'");
            }
            if ((!args || args.quuid === undefined) && !opts.urn) {
                throw new Error("Missing required property 'quuid'");
            }
            if ((!args || args.resourceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceId'");
            }
            resourceInputs["licenseId"] = args ? args.licenseId : undefined;
            resourceInputs["licenseType"] = args ? args.licenseType : undefined;
            resourceInputs["quuid"] = args ? args.quuid : undefined;
            resourceInputs["resourceId"] = args ? args.resourceId : undefined;
            resourceInputs["agentStatus"] = undefined /*out*/;
            resourceInputs["isSwitchBind"] = undefined /*out*/;
            resourceInputs["isUnbind"] = undefined /*out*/;
            resourceInputs["machineIp"] = undefined /*out*/;
            resourceInputs["machineName"] = undefined /*out*/;
            resourceInputs["machineWanIp"] = undefined /*out*/;
            resourceInputs["uuid"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(LicenseBindAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering LicenseBindAttachment resources.
 */
export interface LicenseBindAttachmentState {
    /**
     * agent status.
     */
    agentStatus?: pulumi.Input<string>;
    /**
     * Is it allowed to change the binding, false is not allowed to change the binding.
     */
    isSwitchBind?: pulumi.Input<boolean>;
    /**
     * Allow unbinding, false does not allow unbinding.
     */
    isUnbind?: pulumi.Input<boolean>;
    /**
     * License ID.
     */
    licenseId?: pulumi.Input<number>;
    /**
     * LicenseType, 0 CWP Pro - Pay as you go, 1 CWP Pro - Monthly subscription, 2 CWP Ultimate - Monthly subscription. Default is 0.
     */
    licenseType?: pulumi.Input<number>;
    /**
     * machine ip.
     */
    machineIp?: pulumi.Input<string>;
    /**
     * machine name.
     */
    machineName?: pulumi.Input<string>;
    /**
     * machine wan ip.
     */
    machineWanIp?: pulumi.Input<string>;
    /**
     * Machine quota that needs to be bound.
     */
    quuid?: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    resourceId?: pulumi.Input<string>;
    /**
     * uuid.
     */
    uuid?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a LicenseBindAttachment resource.
 */
export interface LicenseBindAttachmentArgs {
    /**
     * License ID.
     */
    licenseId: pulumi.Input<number>;
    /**
     * LicenseType, 0 CWP Pro - Pay as you go, 1 CWP Pro - Monthly subscription, 2 CWP Ultimate - Monthly subscription. Default is 0.
     */
    licenseType: pulumi.Input<number>;
    /**
     * Machine quota that needs to be bound.
     */
    quuid: pulumi.Input<string>;
    /**
     * Resource ID.
     */
    resourceId: pulumi.Input<string>;
}
