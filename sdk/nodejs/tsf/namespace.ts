// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a tsf namespace
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const namespace = new tencentcloud.tsf.Namespace("namespace", {
 *     isHaEnable: "0",
 *     namespaceDesc: "namespace desc",
 *     namespaceName: "namespace-name",
 *     namespaceType: "DEF",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class Namespace extends pulumi.CustomResource {
    /**
     * Get an existing Namespace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NamespaceState, opts?: pulumi.CustomResourceOptions): Namespace {
        return new Namespace(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Tsf/namespace:Namespace';

    /**
     * Returns true if the given object is an instance of Namespace.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Namespace {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Namespace.__pulumiType;
    }

    /**
     * cluster ID.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * creation time.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Delete ID.
     */
    public /*out*/ readonly deleteFlag!: pulumi.Output<boolean>;
    /**
     * default namespace.
     */
    public /*out*/ readonly isDefault!: pulumi.Output<string>;
    /**
     * whether to enable high availability.
     */
    public readonly isHaEnable!: pulumi.Output<string>;
    /**
     * KubeInjectEnable value.
     */
    public /*out*/ readonly kubeInjectEnable!: pulumi.Output<boolean>;
    /**
     * Namespace encoding.
     */
    public /*out*/ readonly namespaceCode!: pulumi.Output<string>;
    /**
     * namespace description.
     */
    public readonly namespaceDesc!: pulumi.Output<string>;
    /**
     * Namespace ID.
     */
    public readonly namespaceId!: pulumi.Output<string>;
    /**
     * namespace name.
     */
    public readonly namespaceName!: pulumi.Output<string>;
    /**
     * namespace resource type (default is DEF).
     */
    public readonly namespaceResourceType!: pulumi.Output<string>;
    /**
     * namespace status.
     */
    public /*out*/ readonly namespaceStatus!: pulumi.Output<string>;
    /**
     * Whether it is a global namespace (the default is DEF, which means a common namespace; GLOBAL means a global namespace).
     */
    public readonly namespaceType!: pulumi.Output<string>;
    /**
     * ID of the dataset to be bound.
     */
    public readonly programId!: pulumi.Output<string | undefined>;
    /**
     * Program id list.
     */
    public readonly programIdLists!: pulumi.Output<string[] | undefined>;
    /**
     * update time.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a Namespace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NamespaceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NamespaceArgs | NamespaceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as NamespaceState | undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["deleteFlag"] = state ? state.deleteFlag : undefined;
            resourceInputs["isDefault"] = state ? state.isDefault : undefined;
            resourceInputs["isHaEnable"] = state ? state.isHaEnable : undefined;
            resourceInputs["kubeInjectEnable"] = state ? state.kubeInjectEnable : undefined;
            resourceInputs["namespaceCode"] = state ? state.namespaceCode : undefined;
            resourceInputs["namespaceDesc"] = state ? state.namespaceDesc : undefined;
            resourceInputs["namespaceId"] = state ? state.namespaceId : undefined;
            resourceInputs["namespaceName"] = state ? state.namespaceName : undefined;
            resourceInputs["namespaceResourceType"] = state ? state.namespaceResourceType : undefined;
            resourceInputs["namespaceStatus"] = state ? state.namespaceStatus : undefined;
            resourceInputs["namespaceType"] = state ? state.namespaceType : undefined;
            resourceInputs["programId"] = state ? state.programId : undefined;
            resourceInputs["programIdLists"] = state ? state.programIdLists : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as NamespaceArgs | undefined;
            if ((!args || args.namespaceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'namespaceName'");
            }
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["isHaEnable"] = args ? args.isHaEnable : undefined;
            resourceInputs["namespaceDesc"] = args ? args.namespaceDesc : undefined;
            resourceInputs["namespaceId"] = args ? args.namespaceId : undefined;
            resourceInputs["namespaceName"] = args ? args.namespaceName : undefined;
            resourceInputs["namespaceResourceType"] = args ? args.namespaceResourceType : undefined;
            resourceInputs["namespaceType"] = args ? args.namespaceType : undefined;
            resourceInputs["programId"] = args ? args.programId : undefined;
            resourceInputs["programIdLists"] = args ? args.programIdLists : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["deleteFlag"] = undefined /*out*/;
            resourceInputs["isDefault"] = undefined /*out*/;
            resourceInputs["kubeInjectEnable"] = undefined /*out*/;
            resourceInputs["namespaceCode"] = undefined /*out*/;
            resourceInputs["namespaceStatus"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Namespace.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Namespace resources.
 */
export interface NamespaceState {
    /**
     * cluster ID.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * creation time.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Delete ID.
     */
    deleteFlag?: pulumi.Input<boolean>;
    /**
     * default namespace.
     */
    isDefault?: pulumi.Input<string>;
    /**
     * whether to enable high availability.
     */
    isHaEnable?: pulumi.Input<string>;
    /**
     * KubeInjectEnable value.
     */
    kubeInjectEnable?: pulumi.Input<boolean>;
    /**
     * Namespace encoding.
     */
    namespaceCode?: pulumi.Input<string>;
    /**
     * namespace description.
     */
    namespaceDesc?: pulumi.Input<string>;
    /**
     * Namespace ID.
     */
    namespaceId?: pulumi.Input<string>;
    /**
     * namespace name.
     */
    namespaceName?: pulumi.Input<string>;
    /**
     * namespace resource type (default is DEF).
     */
    namespaceResourceType?: pulumi.Input<string>;
    /**
     * namespace status.
     */
    namespaceStatus?: pulumi.Input<string>;
    /**
     * Whether it is a global namespace (the default is DEF, which means a common namespace; GLOBAL means a global namespace).
     */
    namespaceType?: pulumi.Input<string>;
    /**
     * ID of the dataset to be bound.
     */
    programId?: pulumi.Input<string>;
    /**
     * Program id list.
     */
    programIdLists?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * update time.
     */
    updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Namespace resource.
 */
export interface NamespaceArgs {
    /**
     * cluster ID.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * whether to enable high availability.
     */
    isHaEnable?: pulumi.Input<string>;
    /**
     * namespace description.
     */
    namespaceDesc?: pulumi.Input<string>;
    /**
     * Namespace ID.
     */
    namespaceId?: pulumi.Input<string>;
    /**
     * namespace name.
     */
    namespaceName: pulumi.Input<string>;
    /**
     * namespace resource type (default is DEF).
     */
    namespaceResourceType?: pulumi.Input<string>;
    /**
     * Whether it is a global namespace (the default is DEF, which means a common namespace; GLOBAL means a global namespace).
     */
    namespaceType?: pulumi.Input<string>;
    /**
     * ID of the dataset to be bound.
     */
    programId?: pulumi.Input<string>;
    /**
     * Program id list.
     */
    programIdLists?: pulumi.Input<pulumi.Input<string>[]>;
}
