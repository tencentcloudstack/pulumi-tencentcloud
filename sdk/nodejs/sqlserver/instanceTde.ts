// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a sqlserver instanceTde
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const zones = tencentcloud.Availability.getZonesByProduct({
 *     product: "sqlserver",
 * });
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: zones.then(zones => zones.zones?.[4]?.name),
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.0.0/16",
 *     isMulticast: false,
 * });
 * const securityGroup = new tencentcloud.security.Group("securityGroup", {description: "desc."});
 * const exampleBasicInstance = new tencentcloud.sqlserver.BasicInstance("exampleBasicInstance", {
 *     availabilityZone: zones.then(zones => zones.zones?.[4]?.name),
 *     chargeType: "POSTPAID_BY_HOUR",
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     projectId: 0,
 *     memory: 4,
 *     storage: 100,
 *     cpu: 2,
 *     machineType: "CLOUD_PREMIUM",
 *     maintenanceWeekSets: [
 *         1,
 *         2,
 *         3,
 *     ],
 *     maintenanceStartTime: "09:00",
 *     maintenanceTimeSpan: 3,
 *     securityGroups: [securityGroup.id],
 *     tags: {
 *         test: "test",
 *     },
 * });
 * const exampleInstanceTde = new tencentcloud.sqlserver.InstanceTde("exampleInstanceTde", {
 *     instanceId: exampleBasicInstance.id,
 *     certificateAttribution: "self",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * sqlserver instance_tde can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Sqlserver/instanceTde:InstanceTde example mssql-farjz9tz
 * ```
 */
export class InstanceTde extends pulumi.CustomResource {
    /**
     * Get an existing InstanceTde resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceTdeState, opts?: pulumi.CustomResourceOptions): InstanceTde {
        return new InstanceTde(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Sqlserver/instanceTde:InstanceTde';

    /**
     * Returns true if the given object is an instance of InstanceTde.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InstanceTde {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InstanceTde.__pulumiType;
    }

    /**
     * Certificate attribution. self- means to use the account's own certificate, others- means to refer to the certificate of other accounts, and the default is self.
     */
    public readonly certificateAttribution!: pulumi.Output<string>;
    /**
     * Instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Other referenced main account IDs, required when CertificateAttribute is others.
     */
    public readonly quoteUin!: pulumi.Output<string | undefined>;

    /**
     * Create a InstanceTde resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceTdeArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceTdeArgs | InstanceTdeState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as InstanceTdeState | undefined;
            resourceInputs["certificateAttribution"] = state ? state.certificateAttribution : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["quoteUin"] = state ? state.quoteUin : undefined;
        } else {
            const args = argsOrState as InstanceTdeArgs | undefined;
            if ((!args || args.certificateAttribution === undefined) && !opts.urn) {
                throw new Error("Missing required property 'certificateAttribution'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["certificateAttribution"] = args ? args.certificateAttribution : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["quoteUin"] = args ? args.quoteUin : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(InstanceTde.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering InstanceTde resources.
 */
export interface InstanceTdeState {
    /**
     * Certificate attribution. self- means to use the account's own certificate, others- means to refer to the certificate of other accounts, and the default is self.
     */
    certificateAttribution?: pulumi.Input<string>;
    /**
     * Instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Other referenced main account IDs, required when CertificateAttribute is others.
     */
    quoteUin?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a InstanceTde resource.
 */
export interface InstanceTdeArgs {
    /**
     * Certificate attribution. self- means to use the account's own certificate, others- means to refer to the certificate of other accounts, and the default is self.
     */
    certificateAttribution: pulumi.Input<string>;
    /**
     * Instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Other referenced main account IDs, required when CertificateAttribute is others.
     */
    quoteUin?: pulumi.Input<string>;
}
