// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a postgresql account
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const config = new pulumi.Config();
 * const availabilityZone = config.get("availabilityZone") || "ap-guangzhou-3";
 * // create vpc
 * const vpc = new tencentcloud.vpc.Instance("vpc", {cidrBlock: "10.0.0.0/16"});
 * // create vpc subnet
 * const subnet = new tencentcloud.subnet.Instance("subnet", {
 *     availabilityZone: availabilityZone,
 *     vpcId: vpc.id,
 *     cidrBlock: "10.0.20.0/28",
 *     isMulticast: false,
 * });
 * // create postgresql
 * const exampleInstance = new tencentcloud.postgresql.Instance("exampleInstance", {
 *     availabilityZone: availabilityZone,
 *     chargeType: "POSTPAID_BY_HOUR",
 *     vpcId: vpc.id,
 *     subnetId: subnet.id,
 *     dbMajorVersion: "10",
 *     engineVersion: "10.23",
 *     rootUser: "root123",
 *     rootPassword: "Root123$",
 *     charset: "UTF8",
 *     projectId: 0,
 *     cpu: 1,
 *     memory: 2,
 *     storage: 10,
 *     tags: {
 *         test: "tf",
 *     },
 * });
 * // create account
 * const exampleAccount = new tencentcloud.postgresql.Account("exampleAccount", {
 *     dbInstanceId: exampleInstance.id,
 *     userName: "tf_example",
 *     password: "Password@123",
 *     type: "normal",
 *     remark: "remark",
 *     lockStatus: false,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * postgres account can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:Postgresql/account:Account example postgres-3hk6b6tj#tf_example
 * ```
 */
export class Account extends pulumi.CustomResource {
    /**
     * Get an existing Account resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountState, opts?: pulumi.CustomResourceOptions): Account {
        return new Account(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Postgresql/account:Account';

    /**
     * Returns true if the given object is an instance of Account.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Account {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Account.__pulumiType;
    }

    /**
     * Instance ID in the format of postgres-4wdeb0zv.
     */
    public readonly dbInstanceId!: pulumi.Output<string>;
    /**
     * whether lock account. true: locked; false: unlock.
     */
    public readonly lockStatus!: pulumi.Output<boolean>;
    /**
     * Password, which can contain 8-32 letters, digits, and symbols (()`~!@#$%^&amp;amp;amp;*-+=_|{}[]:;&amp;amp;#39;&amp;amp;lt;&amp;amp;gt;,.?/); can&amp;amp;#39;t start with slash /.
     */
    public readonly password!: pulumi.Output<string>;
    /**
     * Remarks correspond to user `UserName`, which can contain 0-60 letters, digits, symbols (-_), and Chinese characters.
     */
    public readonly remark!: pulumi.Output<string | undefined>;
    /**
     * The type of user. Valid values: 1. normal: regular user; 2. tencentDBSuper: user with the pgTencentdbSuperuser role.
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Instance username, which can contain 1-16 letters, digits, and underscore (_); can&amp;amp;#39;t be postgres; can&amp;amp;#39;t start with numbers, pg_, and tencentdb_.
     */
    public readonly userName!: pulumi.Output<string>;

    /**
     * Create a Account resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountArgs | AccountState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as AccountState | undefined;
            resourceInputs["dbInstanceId"] = state ? state.dbInstanceId : undefined;
            resourceInputs["lockStatus"] = state ? state.lockStatus : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["remark"] = state ? state.remark : undefined;
            resourceInputs["type"] = state ? state.type : undefined;
            resourceInputs["userName"] = state ? state.userName : undefined;
        } else {
            const args = argsOrState as AccountArgs | undefined;
            if ((!args || args.dbInstanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dbInstanceId'");
            }
            if ((!args || args.password === undefined) && !opts.urn) {
                throw new Error("Missing required property 'password'");
            }
            if ((!args || args.type === undefined) && !opts.urn) {
                throw new Error("Missing required property 'type'");
            }
            if ((!args || args.userName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userName'");
            }
            resourceInputs["dbInstanceId"] = args ? args.dbInstanceId : undefined;
            resourceInputs["lockStatus"] = args ? args.lockStatus : undefined;
            resourceInputs["password"] = args?.password ? pulumi.secret(args.password) : undefined;
            resourceInputs["remark"] = args ? args.remark : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["userName"] = args ? args.userName : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const secretOpts = { additionalSecretOutputs: ["password"] };
        opts = pulumi.mergeOptions(opts, secretOpts);
        super(Account.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Account resources.
 */
export interface AccountState {
    /**
     * Instance ID in the format of postgres-4wdeb0zv.
     */
    dbInstanceId?: pulumi.Input<string>;
    /**
     * whether lock account. true: locked; false: unlock.
     */
    lockStatus?: pulumi.Input<boolean>;
    /**
     * Password, which can contain 8-32 letters, digits, and symbols (()`~!@#$%^&amp;amp;amp;*-+=_|{}[]:;&amp;amp;#39;&amp;amp;lt;&amp;amp;gt;,.?/); can&amp;amp;#39;t start with slash /.
     */
    password?: pulumi.Input<string>;
    /**
     * Remarks correspond to user `UserName`, which can contain 0-60 letters, digits, symbols (-_), and Chinese characters.
     */
    remark?: pulumi.Input<string>;
    /**
     * The type of user. Valid values: 1. normal: regular user; 2. tencentDBSuper: user with the pgTencentdbSuperuser role.
     */
    type?: pulumi.Input<string>;
    /**
     * Instance username, which can contain 1-16 letters, digits, and underscore (_); can&amp;amp;#39;t be postgres; can&amp;amp;#39;t start with numbers, pg_, and tencentdb_.
     */
    userName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Account resource.
 */
export interface AccountArgs {
    /**
     * Instance ID in the format of postgres-4wdeb0zv.
     */
    dbInstanceId: pulumi.Input<string>;
    /**
     * whether lock account. true: locked; false: unlock.
     */
    lockStatus?: pulumi.Input<boolean>;
    /**
     * Password, which can contain 8-32 letters, digits, and symbols (()`~!@#$%^&amp;amp;amp;*-+=_|{}[]:;&amp;amp;#39;&amp;amp;lt;&amp;amp;gt;,.?/); can&amp;amp;#39;t start with slash /.
     */
    password: pulumi.Input<string>;
    /**
     * Remarks correspond to user `UserName`, which can contain 0-60 letters, digits, symbols (-_), and Chinese characters.
     */
    remark?: pulumi.Input<string>;
    /**
     * The type of user. Valid values: 1. normal: regular user; 2. tencentDBSuper: user with the pgTencentdbSuperuser role.
     */
    type: pulumi.Input<string>;
    /**
     * Instance username, which can contain 1-16 letters, digits, and underscore (_); can&amp;amp;#39;t be postgres; can&amp;amp;#39;t start with numbers, pg_, and tencentdb_.
     */
    userName: pulumi.Input<string>;
}