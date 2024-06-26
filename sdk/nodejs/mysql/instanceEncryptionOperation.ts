// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mysql instanceEncryptionOperation
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
 *     product: "cdb",
 * });
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.0.0/16",
 *     isMulticast: false,
 * });
 * const securityGroup = new tencentcloud.security.Group("securityGroup", {description: "mysql test"});
 * const exampleInstance = new tencentcloud.mysql.Instance("exampleInstance", {
 *     internetService: 1,
 *     engineVersion: "5.7",
 *     chargeType: "POSTPAID",
 *     rootPassword: "PassWord123",
 *     slaveDeployMode: 0,
 *     availabilityZone: zones.then(zones => zones.zones?.[0]?.name),
 *     slaveSyncMode: 1,
 *     instanceName: "tf-example-mysql",
 *     memSize: 4000,
 *     volumeSize: 200,
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     intranetPort: 3306,
 *     securityGroups: [securityGroup.id],
 *     tags: {
 *         name: "test",
 *     },
 *     parameters: {
 *         character_set_server: "utf8",
 *         max_connections: "1000",
 *     },
 * });
 * const exampleInstanceEncryptionOperation = new tencentcloud.mysql.InstanceEncryptionOperation("exampleInstanceEncryptionOperation", {
 *     instanceId: exampleInstance.id,
 *     keyId: "KMS-CDB",
 *     keyRegion: "ap-guangzhou",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class InstanceEncryptionOperation extends pulumi.CustomResource {
    /**
     * Get an existing InstanceEncryptionOperation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: InstanceEncryptionOperationState, opts?: pulumi.CustomResourceOptions): InstanceEncryptionOperation {
        return new InstanceEncryptionOperation(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mysql/instanceEncryptionOperation:InstanceEncryptionOperation';

    /**
     * Returns true if the given object is an instance of InstanceEncryptionOperation.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is InstanceEncryptionOperation {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === InstanceEncryptionOperation.__pulumiType;
    }

    /**
     * TencentDB instance ID.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Custom key ID, which is the unique CMK ID. If this value is empty, the key KMS-CDB auto-generated by Tencent Cloud will be used.
     */
    public readonly keyId!: pulumi.Output<string | undefined>;
    /**
     * Custom storage region, such as ap-guangzhou. When `KeyId` is not empty, this parameter is required.
     */
    public readonly keyRegion!: pulumi.Output<string | undefined>;

    /**
     * Create a InstanceEncryptionOperation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: InstanceEncryptionOperationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: InstanceEncryptionOperationArgs | InstanceEncryptionOperationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as InstanceEncryptionOperationState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["keyId"] = state ? state.keyId : undefined;
            resourceInputs["keyRegion"] = state ? state.keyRegion : undefined;
        } else {
            const args = argsOrState as InstanceEncryptionOperationArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["keyId"] = args ? args.keyId : undefined;
            resourceInputs["keyRegion"] = args ? args.keyRegion : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(InstanceEncryptionOperation.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering InstanceEncryptionOperation resources.
 */
export interface InstanceEncryptionOperationState {
    /**
     * TencentDB instance ID.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Custom key ID, which is the unique CMK ID. If this value is empty, the key KMS-CDB auto-generated by Tencent Cloud will be used.
     */
    keyId?: pulumi.Input<string>;
    /**
     * Custom storage region, such as ap-guangzhou. When `KeyId` is not empty, this parameter is required.
     */
    keyRegion?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a InstanceEncryptionOperation resource.
 */
export interface InstanceEncryptionOperationArgs {
    /**
     * TencentDB instance ID.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Custom key ID, which is the unique CMK ID. If this value is empty, the key KMS-CDB auto-generated by Tencent Cloud will be used.
     */
    keyId?: pulumi.Input<string>;
    /**
     * Custom storage region, such as ap-guangzhou. When `KeyId` is not empty, this parameter is required.
     */
    keyRegion?: pulumi.Input<string>;
}
