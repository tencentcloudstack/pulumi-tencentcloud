// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a mysql remoteBackupConfig
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 *
 * const remoteBackupConfig = new tencentcloud.Mysql.RemoteBackupConfig("remote_backup_config", {
 *     expireDays: 7,
 *     instanceId: "cdb-c1nl9rpv",
 *     remoteBackupSave: "on",
 *     remoteBinlogSave: "on",
 *     remoteRegions: ["ap-shanghai"],
 * });
 * ```
 *
 * ## Import
 *
 * mysql remote_backup_config can be imported using the id, e.g.
 *
 * ```sh
 *  $ pulumi import tencentcloud:Mysql/remoteBackupConfig:RemoteBackupConfig remote_backup_config remote_backup_config_id
 * ```
 */
export class RemoteBackupConfig extends pulumi.CustomResource {
    /**
     * Get an existing RemoteBackupConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RemoteBackupConfigState, opts?: pulumi.CustomResourceOptions): RemoteBackupConfig {
        return new RemoteBackupConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mysql/remoteBackupConfig:RemoteBackupConfig';

    /**
     * Returns true if the given object is an instance of RemoteBackupConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RemoteBackupConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RemoteBackupConfig.__pulumiType;
    }

    /**
     * Remote backup retention time, in days.
     */
    public readonly expireDays!: pulumi.Output<number>;
    /**
     * Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Remote data backup switch, off - disable remote backup, on - enable remote backup.
     */
    public readonly remoteBackupSave!: pulumi.Output<string>;
    /**
     * Off-site log backup switch, off - off off-site backup, on-on off-site backup, only when the parameter RemoteBackupSave is on, the RemoteBinlogSave parameter can be set to on.
     */
    public readonly remoteBinlogSave!: pulumi.Output<string>;
    /**
     * User settings off-site backup region list.
     */
    public readonly remoteRegions!: pulumi.Output<string[]>;

    /**
     * Create a RemoteBackupConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RemoteBackupConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RemoteBackupConfigArgs | RemoteBackupConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RemoteBackupConfigState | undefined;
            resourceInputs["expireDays"] = state ? state.expireDays : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["remoteBackupSave"] = state ? state.remoteBackupSave : undefined;
            resourceInputs["remoteBinlogSave"] = state ? state.remoteBinlogSave : undefined;
            resourceInputs["remoteRegions"] = state ? state.remoteRegions : undefined;
        } else {
            const args = argsOrState as RemoteBackupConfigArgs | undefined;
            if ((!args || args.expireDays === undefined) && !opts.urn) {
                throw new Error("Missing required property 'expireDays'");
            }
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.remoteBackupSave === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remoteBackupSave'");
            }
            if ((!args || args.remoteBinlogSave === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remoteBinlogSave'");
            }
            if ((!args || args.remoteRegions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'remoteRegions'");
            }
            resourceInputs["expireDays"] = args ? args.expireDays : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["remoteBackupSave"] = args ? args.remoteBackupSave : undefined;
            resourceInputs["remoteBinlogSave"] = args ? args.remoteBinlogSave : undefined;
            resourceInputs["remoteRegions"] = args ? args.remoteRegions : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(RemoteBackupConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering RemoteBackupConfig resources.
 */
export interface RemoteBackupConfigState {
    /**
     * Remote backup retention time, in days.
     */
    expireDays?: pulumi.Input<number>;
    /**
     * Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Remote data backup switch, off - disable remote backup, on - enable remote backup.
     */
    remoteBackupSave?: pulumi.Input<string>;
    /**
     * Off-site log backup switch, off - off off-site backup, on-on off-site backup, only when the parameter RemoteBackupSave is on, the RemoteBinlogSave parameter can be set to on.
     */
    remoteBinlogSave?: pulumi.Input<string>;
    /**
     * User settings off-site backup region list.
     */
    remoteRegions?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a RemoteBackupConfig resource.
 */
export interface RemoteBackupConfigArgs {
    /**
     * Remote backup retention time, in days.
     */
    expireDays: pulumi.Input<number>;
    /**
     * Instance ID, in the format: cdb-c1nl9rpv. Same instance ID as displayed in the ApsaraDB for Console page.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Remote data backup switch, off - disable remote backup, on - enable remote backup.
     */
    remoteBackupSave: pulumi.Input<string>;
    /**
     * Off-site log backup switch, off - off off-site backup, on-on off-site backup, only when the parameter RemoteBackupSave is on, the RemoteBinlogSave parameter can be set to on.
     */
    remoteBinlogSave: pulumi.Input<string>;
    /**
     * User settings off-site backup region list.
     */
    remoteRegions: pulumi.Input<pulumi.Input<string>[]>;
}