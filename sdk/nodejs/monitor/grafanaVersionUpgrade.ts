// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a monitor grafanaVersionUpgrade
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const grafanaVersionUpgrade = new tencentcloud.monitor.GrafanaVersionUpgrade("grafanaVersionUpgrade", {
 *     alias: "v8.2.7",
 *     instanceId: "grafana-dp2hnnfa",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * monitor grafana_version_upgrade can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Monitor/grafanaVersionUpgrade:GrafanaVersionUpgrade grafana_version_upgrade instance_id
 * ```
 */
export class GrafanaVersionUpgrade extends pulumi.CustomResource {
    /**
     * Get an existing GrafanaVersionUpgrade resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GrafanaVersionUpgradeState, opts?: pulumi.CustomResourceOptions): GrafanaVersionUpgrade {
        return new GrafanaVersionUpgrade(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Monitor/grafanaVersionUpgrade:GrafanaVersionUpgrade';

    /**
     * Returns true if the given object is an instance of GrafanaVersionUpgrade.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is GrafanaVersionUpgrade {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === GrafanaVersionUpgrade.__pulumiType;
    }

    /**
     * Version alias.
     */
    public readonly alias!: pulumi.Output<string>;
    /**
     * Grafana instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;

    /**
     * Create a GrafanaVersionUpgrade resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GrafanaVersionUpgradeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GrafanaVersionUpgradeArgs | GrafanaVersionUpgradeState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as GrafanaVersionUpgradeState | undefined;
            resourceInputs["alias"] = state ? state.alias : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
        } else {
            const args = argsOrState as GrafanaVersionUpgradeArgs | undefined;
            if ((!args || args.alias === undefined) && !opts.urn) {
                throw new Error("Missing required property 'alias'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["alias"] = args ? args.alias : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(GrafanaVersionUpgrade.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering GrafanaVersionUpgrade resources.
 */
export interface GrafanaVersionUpgradeState {
    /**
     * Version alias.
     */
    alias?: pulumi.Input<string>;
    /**
     * Grafana instance ID.
     */
    instanceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a GrafanaVersionUpgrade resource.
 */
export interface GrafanaVersionUpgradeArgs {
    /**
     * Version alias.
     */
    alias: pulumi.Input<string>;
    /**
     * Grafana instance ID.
     */
    instanceId: pulumi.Input<string>;
}
