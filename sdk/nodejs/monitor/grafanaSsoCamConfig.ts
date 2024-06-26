// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a monitor grafanaSsoCamConfig
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const grafanaSsoCamConfig = new tencentcloud.monitor.GrafanaSsoCamConfig("grafanaSsoCamConfig", {
 *     enableSsoCamCheck: false,
 *     instanceId: "grafana-dp2hnnfa",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * monitor grafana_sso_cam_config can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Monitor/grafanaSsoCamConfig:GrafanaSsoCamConfig grafana_sso_cam_config instance_id
 * ```
 */
export class GrafanaSsoCamConfig extends pulumi.CustomResource {
    /**
     * Get an existing GrafanaSsoCamConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GrafanaSsoCamConfigState, opts?: pulumi.CustomResourceOptions): GrafanaSsoCamConfig {
        return new GrafanaSsoCamConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Monitor/grafanaSsoCamConfig:GrafanaSsoCamConfig';

    /**
     * Returns true if the given object is an instance of GrafanaSsoCamConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GrafanaSsoCamConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GrafanaSsoCamConfig.__pulumiType;
    }

    /**
     * Whether to enable the CAM authorization: `true` for enabling; `false` for disabling.
     */
    public readonly enableSsoCamCheck!: pulumi.Output<boolean>;
    /**
     * Grafana instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a GrafanaSsoCamConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GrafanaSsoCamConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GrafanaSsoCamConfigArgs | GrafanaSsoCamConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as GrafanaSsoCamConfigState | undefined;
            resourceInputs["enableSsoCamCheck"] = state ? state.enableSsoCamCheck : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as GrafanaSsoCamConfigArgs | undefined;
            if ((!args || args.enableSsoCamCheck === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enableSsoCamCheck'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["enableSsoCamCheck"] = args ? args.enableSsoCamCheck : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(GrafanaSsoCamConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GrafanaSsoCamConfig resources.
 */
export interface GrafanaSsoCamConfigState {
    /**
     * Whether to enable the CAM authorization: `true` for enabling; `false` for disabling.
     */
    enableSsoCamCheck?: pulumi.Input<boolean>;
    /**
     * Grafana instance ID.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a GrafanaSsoCamConfig resource.
 */
export interface GrafanaSsoCamConfigArgs {
    /**
     * Whether to enable the CAM authorization: `true` for enabling; `false` for disabling.
     */
    enableSsoCamCheck: pulumi.Input<boolean>;
    /**
     * Grafana instance ID.
     */
    instanceId: pulumi.Input<string>;
}
