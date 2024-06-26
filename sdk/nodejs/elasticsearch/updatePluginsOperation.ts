// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to update elasticsearch plugins
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const updatePluginsOperation = new tencentcloud.elasticsearch.UpdatePluginsOperation("updatePluginsOperation", {
 *     forceRestart: false,
 *     forceUpdate: true,
 *     installPluginLists: ["analysis-pinyin"],
 *     instanceId: "es-xxxxxx",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class UpdatePluginsOperation extends pulumi.CustomResource {
    /**
     * Get an existing UpdatePluginsOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UpdatePluginsOperationState, opts?: pulumi.CustomResourceOptions): UpdatePluginsOperation {
        return new UpdatePluginsOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Elasticsearch/updatePluginsOperation:UpdatePluginsOperation';

    /**
     * Returns true if the given object is an instance of UpdatePluginsOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UpdatePluginsOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UpdatePluginsOperation.__pulumiType;
    }

    /**
     * Whether to force a restart. Default is false.
     */
    public readonly forceRestart!: pulumi.Output<boolean | undefined>;
    /**
     * Whether to reinstall, default value false.
     */
    public readonly forceUpdate!: pulumi.Output<boolean | undefined>;
    /**
     * List of plugins that need to be installed.
     */
    public readonly installPluginLists!: pulumi.Output<string[] | undefined>;
    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Plugin type. 0: system plugin.
     */
    public readonly pluginType!: pulumi.Output<number | undefined>;
    /**
     * List of plugins that need to be uninstalled.
     */
    public readonly removePluginLists!: pulumi.Output<string[] | undefined>;

    /**
     * Create a UpdatePluginsOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UpdatePluginsOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UpdatePluginsOperationArgs | UpdatePluginsOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UpdatePluginsOperationState | undefined;
            resourceInputs["forceRestart"] = state ? state.forceRestart : undefined;
            resourceInputs["forceUpdate"] = state ? state.forceUpdate : undefined;
            resourceInputs["installPluginLists"] = state ? state.installPluginLists : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["pluginType"] = state ? state.pluginType : undefined;
            resourceInputs["removePluginLists"] = state ? state.removePluginLists : undefined;
        } else {
            const args = argsOrState as UpdatePluginsOperationArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["forceRestart"] = args ? args.forceRestart : undefined;
            resourceInputs["forceUpdate"] = args ? args.forceUpdate : undefined;
            resourceInputs["installPluginLists"] = args ? args.installPluginLists : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["pluginType"] = args ? args.pluginType : undefined;
            resourceInputs["removePluginLists"] = args ? args.removePluginLists : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UpdatePluginsOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UpdatePluginsOperation resources.
 */
export interface UpdatePluginsOperationState {
    /**
     * Whether to force a restart. Default is false.
     */
    forceRestart?: pulumi.Input<boolean>;
    /**
     * Whether to reinstall, default value false.
     */
    forceUpdate?: pulumi.Input<boolean>;
    /**
     * List of plugins that need to be installed.
     */
    installPluginLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Plugin type. 0: system plugin.
     */
    pluginType?: pulumi.Input<number>;
    /**
     * List of plugins that need to be uninstalled.
     */
    removePluginLists?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a UpdatePluginsOperation resource.
 */
export interface UpdatePluginsOperationArgs {
    /**
     * Whether to force a restart. Default is false.
     */
    forceRestart?: pulumi.Input<boolean>;
    /**
     * Whether to reinstall, default value false.
     */
    forceUpdate?: pulumi.Input<boolean>;
    /**
     * List of plugins that need to be installed.
     */
    installPluginLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Plugin type. 0: system plugin.
     */
    pluginType?: pulumi.Input<number>;
    /**
     * List of plugins that need to be uninstalled.
     */
    removePluginLists?: pulumi.Input<pulumi.Input<string>[]>;
}
