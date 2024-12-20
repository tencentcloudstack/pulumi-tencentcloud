// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mps enableWorkflowConfig
 *
 * ## Example Usage
 *
 * ### Enable the mps workflow
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const example = new tencentcloud.mps.Workflow("example", {
 *     outputDir: "/",
 *     taskPriority: 0,
 *     workflowName: "tf-workflow-enable-config",
 *     mediaProcessTask: {
 *         adaptiveDynamicStreamingTaskSets: [{
 *             definition: 12,
 *             outputObjectPath: "/out",
 *             segmentObjectName: "/out",
 *             subStreamObjectName: "/out/out/",
 *             outputStorage: {
 *                 type: "COS",
 *                 cosOutputStorage: {
 *                     bucket: "cos-lock-1308919341",
 *                     region: "ap-guangzhou",
 *                 },
 *             },
 *         }],
 *         snapshotByTimeOffsetTaskSets: [{
 *             definition: 10,
 *             extTimeOffsetSets: ["1s"],
 *             outputObjectPath: "/snapshot/",
 *             timeOffsetSets: [],
 *             outputStorage: {
 *                 type: "COS",
 *                 cosOutputStorage: {
 *                     bucket: "cos-lock-1308919341",
 *                     region: "ap-guangzhou",
 *                 },
 *             },
 *         }],
 *         animatedGraphicTaskSets: [{
 *             definition: 20000,
 *             endTimeOffset: 0,
 *             outputObjectPath: "/test/",
 *             startTimeOffset: 0,
 *             outputStorage: {
 *                 type: "COS",
 *                 cosOutputStorage: {
 *                     bucket: "cos-lock-1308919341",
 *                     region: "ap-guangzhou",
 *                 },
 *             },
 *         }],
 *     },
 *     aiAnalysisTask: {
 *         definition: 20,
 *     },
 *     aiContentReviewTask: {
 *         definition: 20,
 *     },
 *     aiRecognitionTask: {
 *         definition: 20,
 *     },
 *     outputStorage: {
 *         type: "COS",
 *         cosOutputStorage: {
 *             bucket: "cos-lock-1308919341",
 *             region: "ap-guangzhou",
 *         },
 *     },
 *     trigger: {
 *         type: "CosFileUpload",
 *         cosFileUploadTrigger: {
 *             bucket: "cos-lock-1308919341",
 *             dir: "/",
 *             region: "ap-guangzhou",
 *         },
 *     },
 * });
 * const config = new tencentcloud.mps.EnableWorkflowConfig("config", {
 *     workflowId: example.id,
 *     enabled: true,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Disable the mps workflow
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const config = new tencentcloud.mps.EnableWorkflowConfig("config", {
 *     workflowId: tencentcloud_mps_workflow.example.id,
 *     enabled: false,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * mps enable_workflow_config can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Mps/enableWorkflowConfig:EnableWorkflowConfig enable_workflow_config enable_workflow_config_id
 * ```
 */
export class EnableWorkflowConfig extends pulumi.CustomResource {
    /**
     * Get an existing EnableWorkflowConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EnableWorkflowConfigState, opts?: pulumi.CustomResourceOptions): EnableWorkflowConfig {
        return new EnableWorkflowConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mps/enableWorkflowConfig:EnableWorkflowConfig';

    /**
     * Returns true if the given object is an instance of EnableWorkflowConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EnableWorkflowConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EnableWorkflowConfig.__pulumiType;
    }

    /**
     * true: enable; false: disable.
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * Workflow ID.
     */
    public readonly workflowId!: pulumi.Output<number>;

    /**
     * Create a EnableWorkflowConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EnableWorkflowConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EnableWorkflowConfigArgs | EnableWorkflowConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as EnableWorkflowConfigState | undefined;
            resourceInputs["enabled"] = state ? state.enabled : undefined;
            resourceInputs["workflowId"] = state ? state.workflowId : undefined;
        } else {
            const args = argsOrState as EnableWorkflowConfigArgs | undefined;
            if ((!args || args.enabled === undefined) && !opts.urn) {
                throw new Error("Missing required property 'enabled'");
            }
            if ((!args || args.workflowId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'workflowId'");
            }
            resourceInputs["enabled"] = args ? args.enabled : undefined;
            resourceInputs["workflowId"] = args ? args.workflowId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(EnableWorkflowConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EnableWorkflowConfig resources.
 */
export interface EnableWorkflowConfigState {
    /**
     * true: enable; false: disable.
     */
    enabled?: pulumi.Input<boolean>;
    /**
     * Workflow ID.
     */
    workflowId?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a EnableWorkflowConfig resource.
 */
export interface EnableWorkflowConfigArgs {
    /**
     * true: enable; false: disable.
     */
    enabled: pulumi.Input<boolean>;
    /**
     * Workflow ID.
     */
    workflowId: pulumi.Input<number>;
}
