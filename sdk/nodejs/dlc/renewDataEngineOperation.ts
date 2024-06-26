// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a dlc renewDataEngine
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const renewDataEngine = new tencentcloud.dlc.RenewDataEngineOperation("renewDataEngine", {
 *     dataEngineName: "testEngine",
 *     payMode: 1,
 *     renewFlag: 1,
 *     timeSpan: 3600,
 *     timeUnit: "m",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * dlc renew_data_engine can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Dlc/renewDataEngineOperation:RenewDataEngineOperation renew_data_engine renew_data_engine_id
 * ```
 */
export class RenewDataEngineOperation extends pulumi.CustomResource {
    /**
     * Get an existing RenewDataEngineOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RenewDataEngineOperationState, opts?: pulumi.CustomResourceOptions): RenewDataEngineOperation {
        return new RenewDataEngineOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dlc/renewDataEngineOperation:RenewDataEngineOperation';

    /**
     * Returns true if the given object is an instance of RenewDataEngineOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RenewDataEngineOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RenewDataEngineOperation.__pulumiType;
    }

    /**
     * Data engine name.
     */
    public readonly dataEngineName!: pulumi.Output<string>;
    /**
     * Engine pay mode type, only support 0: postPay, 1: prePay(default).
     */
    public readonly payMode!: pulumi.Output<number | undefined>;
    /**
     * Automatic renewal flag, 0, initial state, automatic renewal is not performed by default. if the user has prepaid non-stop service privileges, automatic renewal will occur. 1: Automatic renewal. 2: make it clear that there will be no automatic renewal. if this parameter is not passed, the default value is 0.
     */
    public readonly renewFlag!: pulumi.Output<number | undefined>;
    /**
     * Engine TimeSpan, prePay: minimum of 1, representing one month of purchasing resources, with a maximum of 120, default 3600, postPay: fixed fee of 3600.
     */
    public readonly timeSpan!: pulumi.Output<number>;
    /**
     * Engine TimeUnit, prePay: use m(default), postPay: use h.
     */
    public readonly timeUnit!: pulumi.Output<string | undefined>;

    /**
     * Create a RenewDataEngineOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RenewDataEngineOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RenewDataEngineOperationArgs | RenewDataEngineOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RenewDataEngineOperationState | undefined;
            resourceInputs["dataEngineName"] = state ? state.dataEngineName : undefined;
            resourceInputs["payMode"] = state ? state.payMode : undefined;
            resourceInputs["renewFlag"] = state ? state.renewFlag : undefined;
            resourceInputs["timeSpan"] = state ? state.timeSpan : undefined;
            resourceInputs["timeUnit"] = state ? state.timeUnit : undefined;
        } else {
            const args = argsOrState as RenewDataEngineOperationArgs | undefined;
            if ((!args || args.dataEngineName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dataEngineName'");
            }
            if ((!args || args.timeSpan === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timeSpan'");
            }
            resourceInputs["dataEngineName"] = args ? args.dataEngineName : undefined;
            resourceInputs["payMode"] = args ? args.payMode : undefined;
            resourceInputs["renewFlag"] = args ? args.renewFlag : undefined;
            resourceInputs["timeSpan"] = args ? args.timeSpan : undefined;
            resourceInputs["timeUnit"] = args ? args.timeUnit : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RenewDataEngineOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RenewDataEngineOperation resources.
 */
export interface RenewDataEngineOperationState {
    /**
     * Data engine name.
     */
    dataEngineName?: pulumi.Input<string>;
    /**
     * Engine pay mode type, only support 0: postPay, 1: prePay(default).
     */
    payMode?: pulumi.Input<number>;
    /**
     * Automatic renewal flag, 0, initial state, automatic renewal is not performed by default. if the user has prepaid non-stop service privileges, automatic renewal will occur. 1: Automatic renewal. 2: make it clear that there will be no automatic renewal. if this parameter is not passed, the default value is 0.
     */
    renewFlag?: pulumi.Input<number>;
    /**
     * Engine TimeSpan, prePay: minimum of 1, representing one month of purchasing resources, with a maximum of 120, default 3600, postPay: fixed fee of 3600.
     */
    timeSpan?: pulumi.Input<number>;
    /**
     * Engine TimeUnit, prePay: use m(default), postPay: use h.
     */
    timeUnit?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a RenewDataEngineOperation resource.
 */
export interface RenewDataEngineOperationArgs {
    /**
     * Data engine name.
     */
    dataEngineName: pulumi.Input<string>;
    /**
     * Engine pay mode type, only support 0: postPay, 1: prePay(default).
     */
    payMode?: pulumi.Input<number>;
    /**
     * Automatic renewal flag, 0, initial state, automatic renewal is not performed by default. if the user has prepaid non-stop service privileges, automatic renewal will occur. 1: Automatic renewal. 2: make it clear that there will be no automatic renewal. if this parameter is not passed, the default value is 0.
     */
    renewFlag?: pulumi.Input<number>;
    /**
     * Engine TimeSpan, prePay: minimum of 1, representing one month of purchasing resources, with a maximum of 120, default 3600, postPay: fixed fee of 3600.
     */
    timeSpan: pulumi.Input<number>;
    /**
     * Engine TimeUnit, prePay: use m(default), postPay: use h.
     */
    timeUnit?: pulumi.Input<string>;
}
