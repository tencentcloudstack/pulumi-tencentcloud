// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dasb bindDeviceAccountPassword
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleDevice = new tencentcloud.dasb.Device("exampleDevice", {
 *     osName: "Linux",
 *     ip: "192.168.0.1",
 *     port: 80,
 * });
 * const exampleDeviceAccount = new tencentcloud.dasb.DeviceAccount("exampleDeviceAccount", {
 *     deviceId: exampleDevice.id,
 *     account: "root",
 * });
 * const exampleBindDeviceAccountPassword = new tencentcloud.dasb.BindDeviceAccountPassword("exampleBindDeviceAccountPassword", {
 *     deviceAccountId: exampleDeviceAccount.id,
 *     password: "TerraformPassword",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class BindDeviceAccountPassword extends pulumi.CustomResource {
    /**
     * Get an existing BindDeviceAccountPassword resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BindDeviceAccountPasswordState, opts?: pulumi.CustomResourceOptions): BindDeviceAccountPassword {
        return new BindDeviceAccountPassword(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dasb/bindDeviceAccountPassword:BindDeviceAccountPassword';

    /**
     * Returns true if the given object is an instance of BindDeviceAccountPassword.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BindDeviceAccountPassword {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BindDeviceAccountPassword.__pulumiType;
    }

    /**
     * Host account ID.
     */
    public readonly deviceAccountId!: pulumi.Output<number>;
    /**
     * Host account password.
     */
    public readonly password!: pulumi.Output<string>;

    /**
     * Create a BindDeviceAccountPassword resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BindDeviceAccountPasswordArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BindDeviceAccountPasswordArgs | BindDeviceAccountPasswordState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as BindDeviceAccountPasswordState | undefined;
            resourceInputs["deviceAccountId"] = state ? state.deviceAccountId : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
        } else {
            const args = argsOrState as BindDeviceAccountPasswordArgs | undefined;
            if ((!args || args.deviceAccountId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'deviceAccountId'");
            }
            if ((!args || args.password === undefined) && !opts.urn) {
                throw new Error("Missing required property 'password'");
            }
            resourceInputs["deviceAccountId"] = args ? args.deviceAccountId : undefined;
            resourceInputs["password"] = args ? args.password : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(BindDeviceAccountPassword.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BindDeviceAccountPassword resources.
 */
export interface BindDeviceAccountPasswordState {
    /**
     * Host account ID.
     */
    deviceAccountId?: pulumi.Input<number>;
    /**
     * Host account password.
     */
    password?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a BindDeviceAccountPassword resource.
 */
export interface BindDeviceAccountPasswordArgs {
    /**
     * Host account ID.
     */
    deviceAccountId: pulumi.Input<number>;
    /**
     * Host account password.
     */
    password: pulumi.Input<string>;
}
