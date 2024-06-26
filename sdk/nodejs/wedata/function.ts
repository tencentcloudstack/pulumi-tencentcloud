// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a wedata function
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.wedata.Function("example", {
 *     className: "tf_class_example",
 *     clusterIdentifier: "emr-m6u3qgk0",
 *     comment: "V1",
 *     dbName: "tf_db_example",
 *     description: "description.",
 *     example: "example info.",
 *     kind: "ANALYSIS",
 *     paramDesc: "param info.",
 *     projectId: "1612982498218618880",
 *     resourceLists: [{
 *         id: "5b28bcdf-a0e6-4022-927d-927d399c4593",
 *         name: "untitled3-1.0-SNAPSHOT.jar",
 *         path: "/wedata-demo-1314991481/untitled3-1.0-SNAPSHOT.jar",
 *         type: "cos",
 *     }],
 *     returnDesc: "return value info.",
 *     type: "HIVE",
 *     usage: "usage info.",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class Function extends pulumi.CustomResource {
    /**
     * Get an existing Function resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FunctionState, opts?: pulumi.CustomResourceOptions): Function {
        return new Function(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Wedata/function:Function';

    /**
     * Returns true if the given object is an instance of Function.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Function {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Function.__pulumiType;
    }

    /**
     * Class name of function entry.
     */
    public readonly className!: pulumi.Output<string>;
    /**
     * Cluster ID.
     */
    public readonly clusterIdentifier!: pulumi.Output<string>;
    /**
     * Comment.
     */
    public readonly comment!: pulumi.Output<string>;
    /**
     * Database name.
     */
    public readonly dbName!: pulumi.Output<string>;
    /**
     * Description of the function.
     */
    public readonly description!: pulumi.Output<string>;
    /**
     * Example of the function.
     */
    public readonly example!: pulumi.Output<string>;
    /**
     * Function ID.
     */
    public /*out*/ readonly functionId!: pulumi.Output<string>;
    /**
     * Function Kind, Enum: ANALYSIS, ENCRYPTION, AGGREGATE, LOGIC, DATE_AND_TIME, MATH, CONVERSION, STRING, IP_AND_DOMAIN, WINDOW, OTHER.
     */
    public readonly kind!: pulumi.Output<string>;
    /**
     * Function Name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Description of the Parameter.
     */
    public readonly paramDesc!: pulumi.Output<string>;
    /**
     * Project ID.
     */
    public readonly projectId!: pulumi.Output<string>;
    /**
     * Resource of the function, stored in WeData COS(.jar,...).
     */
    public readonly resourceLists!: pulumi.Output<outputs.Wedata.FunctionResourceList[]>;
    /**
     * Description of the Return value.
     */
    public readonly returnDesc!: pulumi.Output<string>;
    /**
     * Function Type, Enum: HIVE, SPARK, DLC.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Usage of the function.
     */
    public readonly usage!: pulumi.Output<string>;

    /**
     * Create a Function resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FunctionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FunctionArgs | FunctionState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FunctionState | undefined;
            resourceInputs["className"] = state ? state.className : undefined;
            resourceInputs["clusterIdentifier"] = state ? state.clusterIdentifier : undefined;
            resourceInputs["comment"] = state ? state.comment : undefined;
            resourceInputs["dbName"] = state ? state.dbName : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["example"] = state ? state.example : undefined;
            resourceInputs["functionId"] = state ? state.functionId : undefined;
            resourceInputs["kind"] = state ? state.kind : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["paramDesc"] = state ? state.paramDesc : undefined;
            resourceInputs["projectId"] = state ? state.projectId : undefined;
            resourceInputs["resourceLists"] = state ? state.resourceLists : undefined;
            resourceInputs["returnDesc"] = state ? state.returnDesc : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["usage"] = state ? state.usage : undefined;
        } else {
            const args = argsOrState as FunctionArgs | undefined;
            if ((!args || args.className === undefined) && !opts.urn) {
                throw new Error("Missing required property 'className'");
            }
            if ((!args || args.clusterIdentifier === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterIdentifier'");
            }
            if ((!args || args.comment === undefined) && !opts.urn) {
                throw new Error("Missing required property 'comment'");
            }
            if ((!args || args.dbName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dbName'");
            }
            if ((!args || args.description === undefined) && !opts.urn) {
                throw new Error("Missing required property 'description'");
            }
            if ((!args || args.example === undefined) && !opts.urn) {
                throw new Error("Missing required property 'example'");
            }
            if ((!args || args.kind === undefined) && !opts.urn) {
                throw new Error("Missing required property 'kind'");
            }
            if ((!args || args.paramDesc === undefined) && !opts.urn) {
                throw new Error("Missing required property 'paramDesc'");
            }
            if ((!args || args.projectId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectId'");
            }
            if ((!args || args.resourceLists === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceLists'");
            }
            if ((!args || args.returnDesc === undefined) && !opts.urn) {
                throw new Error("Missing required property 'returnDesc'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.usage === undefined) && !opts.urn) {
                throw new Error("Missing required property 'usage'");
            }
            resourceInputs["className"] = args ? args.className : undefined;
            resourceInputs["clusterIdentifier"] = args ? args.clusterIdentifier : undefined;
            resourceInputs["comment"] = args ? args.comment : undefined;
            resourceInputs["dbName"] = args ? args.dbName : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["example"] = args ? args.example : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["paramDesc"] = args ? args.paramDesc : undefined;
            resourceInputs["projectId"] = args ? args.projectId : undefined;
            resourceInputs["resourceLists"] = args ? args.resourceLists : undefined;
            resourceInputs["returnDesc"] = args ? args.returnDesc : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["usage"] = args ? args.usage : undefined;
            resourceInputs["functionId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Function.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Function resources.
 */
export interface FunctionState {
    /**
     * Class name of function entry.
     */
    className?: pulumi.Input<string>;
    /**
     * Cluster ID.
     */
    clusterIdentifier?: pulumi.Input<string>;
    /**
     * Comment.
     */
    comment?: pulumi.Input<string>;
    /**
     * Database name.
     */
    dbName?: pulumi.Input<string>;
    /**
     * Description of the function.
     */
    description?: pulumi.Input<string>;
    /**
     * Example of the function.
     */
    example?: pulumi.Input<string>;
    /**
     * Function ID.
     */
    functionId?: pulumi.Input<string>;
    /**
     * Function Kind, Enum: ANALYSIS, ENCRYPTION, AGGREGATE, LOGIC, DATE_AND_TIME, MATH, CONVERSION, STRING, IP_AND_DOMAIN, WINDOW, OTHER.
     */
    kind?: pulumi.Input<string>;
    /**
     * Function Name.
     */
    name?: pulumi.Input<string>;
    /**
     * Description of the Parameter.
     */
    paramDesc?: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId?: pulumi.Input<string>;
    /**
     * Resource of the function, stored in WeData COS(.jar,...).
     */
    resourceLists?: pulumi.Input<pulumi.Input<inputs.Wedata.FunctionResourceList>[]>;
    /**
     * Description of the Return value.
     */
    returnDesc?: pulumi.Input<string>;
    /**
     * Function Type, Enum: HIVE, SPARK, DLC.
     */
    type?: pulumi.Input<string>;
    /**
     * Usage of the function.
     */
    usage?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Function resource.
 */
export interface FunctionArgs {
    /**
     * Class name of function entry.
     */
    className: pulumi.Input<string>;
    /**
     * Cluster ID.
     */
    clusterIdentifier: pulumi.Input<string>;
    /**
     * Comment.
     */
    comment: pulumi.Input<string>;
    /**
     * Database name.
     */
    dbName: pulumi.Input<string>;
    /**
     * Description of the function.
     */
    description: pulumi.Input<string>;
    /**
     * Example of the function.
     */
    example: pulumi.Input<string>;
    /**
     * Function Kind, Enum: ANALYSIS, ENCRYPTION, AGGREGATE, LOGIC, DATE_AND_TIME, MATH, CONVERSION, STRING, IP_AND_DOMAIN, WINDOW, OTHER.
     */
    kind: pulumi.Input<string>;
    /**
     * Function Name.
     */
    name?: pulumi.Input<string>;
    /**
     * Description of the Parameter.
     */
    paramDesc: pulumi.Input<string>;
    /**
     * Project ID.
     */
    projectId: pulumi.Input<string>;
    /**
     * Resource of the function, stored in WeData COS(.jar,...).
     */
    resourceLists: pulumi.Input<pulumi.Input<inputs.Wedata.FunctionResourceList>[]>;
    /**
     * Description of the Return value.
     */
    returnDesc: pulumi.Input<string>;
    /**
     * Function Type, Enum: HIVE, SPARK, DLC.
     */
    type: pulumi.Input<string>;
    /**
     * Usage of the function.
     */
    usage: pulumi.Input<string>;
}
