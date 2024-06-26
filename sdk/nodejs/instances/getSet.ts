// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to query cvm instances in parallel.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Instances.getSet({
 *     availabilityZone: "ap-guangzhou-6",
 *     instanceId: "ins-a81rnm8c",
 *     instanceName: "tf_example",
 *     projectId: 0,
 *     subnetId: "subnet-1to7t9au",
 *     tags: {
 *         tagKey: "tagValue",
 *     },
 *     vpcId: "vpc-l040hycv",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSet(args?: GetSetArgs, opts?: pulumi.InvokeOptions): Promise<GetSetResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Instances/getSet:getSet", {
        "availabilityZone": args.availabilityZone,
        "instanceId": args.instanceId,
        "instanceName": args.instanceName,
        "projectId": args.projectId,
        "resultOutputFile": args.resultOutputFile,
        "subnetId": args.subnetId,
        "tags": args.tags,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSet.
 */
export interface GetSetArgs {
    /**
     * The available zone that the CVM instance locates at.
     */
    availabilityZone?: string;
    /**
     * ID of the instances to be queried.
     */
    instanceId?: string;
    /**
     * Name of the instances to be queried.
     */
    instanceName?: string;
    /**
     * The project CVM belongs to.
     */
    projectId?: number;
    /**
     * Used to save results.
     */
    resultOutputFile?: string;
    /**
     * ID of a vpc subnetwork.
     */
    subnetId?: string;
    /**
     * Tags of the instance.
     */
    tags?: {[key: string]: any};
    /**
     * ID of the vpc to be queried.
     */
    vpcId?: string;
}

/**
 * A collection of values returned by getSet.
 */
export interface GetSetResult {
    /**
     * The available zone that the CVM instance locates at.
     */
    readonly availabilityZone?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    /**
     * ID of the instances.
     */
    readonly instanceId?: string;
    /**
     * An information list of cvm instance. Each element contains the following attributes:
     */
    readonly instanceLists: outputs.Instances.GetSetInstanceList[];
    /**
     * Name of the instances.
     */
    readonly instanceName?: string;
    /**
     * The project CVM belongs to.
     */
    readonly projectId?: number;
    readonly resultOutputFile?: string;
    /**
     * ID of a vpc subnetwork.
     */
    readonly subnetId?: string;
    /**
     * Tags of the instance.
     */
    readonly tags?: {[key: string]: any};
    /**
     * ID of the vpc.
     */
    readonly vpcId?: string;
}
/**
 * Use this data source to query cvm instances in parallel.
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const example = tencentcloud.Instances.getSet({
 *     availabilityZone: "ap-guangzhou-6",
 *     instanceId: "ins-a81rnm8c",
 *     instanceName: "tf_example",
 *     projectId: 0,
 *     subnetId: "subnet-1to7t9au",
 *     tags: {
 *         tagKey: "tagValue",
 *     },
 *     vpcId: "vpc-l040hycv",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export function getSetOutput(args?: GetSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSetResult> {
    return pulumi.output(args).apply((a: any) => getSet(a, opts))
}

/**
 * A collection of arguments for invoking getSet.
 */
export interface GetSetOutputArgs {
    /**
     * The available zone that the CVM instance locates at.
     */
    availabilityZone?: pulumi.Input<string>;
    /**
     * ID of the instances to be queried.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Name of the instances to be queried.
     */
    instanceName?: pulumi.Input<string>;
    /**
     * The project CVM belongs to.
     */
    projectId?: pulumi.Input<number>;
    /**
     * Used to save results.
     */
    resultOutputFile?: pulumi.Input<string>;
    /**
     * ID of a vpc subnetwork.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Tags of the instance.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
    /**
     * ID of the vpc to be queried.
     */
    vpcId?: pulumi.Input<string>;
}
