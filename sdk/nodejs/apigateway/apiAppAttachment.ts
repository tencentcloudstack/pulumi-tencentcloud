// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a apigateway apiAppAttachment
 *
 * ## Example Usage
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const exampleApiApp = new tencentcloud.apigateway.ApiApp("exampleApiApp", {
 *     apiAppName: "tf_example",
 *     apiAppDesc: "app desc.",
 * });
 * const exampleService = new tencentcloud.apigateway.Service("exampleService", {
 *     serviceName: "tf_example_service",
 *     protocol: "http&https",
 *     serviceDesc: "your nice service",
 *     netTypes: [
 *         "INNER",
 *         "OUTER",
 *     ],
 *     ipVersion: "IPv4",
 * });
 * const exampleApi = new tencentcloud.apigateway.Api("exampleApi", {
 *     serviceId: exampleService.id,
 *     apiName: "tf_example_api",
 *     apiDesc: "desc.",
 *     authType: "APP",
 *     protocol: "HTTP",
 *     enableCors: true,
 *     requestConfigPath: "/user/info",
 *     requestConfigMethod: "GET",
 *     requestParameters: [{
 *         name: "name",
 *         position: "QUERY",
 *         type: "string",
 *         desc: "desc.",
 *         defaultValue: "terraform",
 *         required: true,
 *     }],
 *     serviceConfigType: "HTTP",
 *     serviceConfigTimeout: 15,
 *     serviceConfigUrl: "https://www.qq.com",
 *     serviceConfigPath: "/user",
 *     serviceConfigMethod: "GET",
 *     responseType: "HTML",
 *     responseSuccessExample: "success",
 *     responseFailExample: "fail",
 *     responseErrorCodes: [{
 *         code: 400,
 *         msg: "system error msg.",
 *         desc: "system error desc.",
 *         convertedCode: 407,
 *         needConvert: true,
 *     }],
 * });
 * const exampleApiAppAttachment = new tencentcloud.apigateway.ApiAppAttachment("exampleApiAppAttachment", {
 *     apiAppId: exampleApiApp.id,
 *     environment: "test",
 *     serviceId: exampleService.id,
 *     apiId: exampleApi.id,
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ## Import
 *
 * apigateway api_app_attachment can be imported using the id, e.g.
 *
 * ```sh
 * $ pulumi import tencentcloud:ApiGateway/apiAppAttachment:ApiAppAttachment example app-f2dxx0lv#test#service-h0trno8e#api-grsomg0w
 * ```
 */
export class ApiAppAttachment extends pulumi.CustomResource {
    /**
     * Get an existing ApiAppAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ApiAppAttachmentState, opts?: pulumi.CustomResourceOptions): ApiAppAttachment {
        return new ApiAppAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:ApiGateway/apiAppAttachment:ApiAppAttachment';

    /**
     * Returns true if the given object is an instance of ApiAppAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiAppAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiAppAttachment.__pulumiType;
    }

    /**
     * The unique ID of the application to be bound.
     */
    public readonly apiAppId!: pulumi.Output<string>;
    /**
     * The unique ID of the API to be bound.
     */
    public readonly apiId!: pulumi.Output<string>;
    /**
     * The environment to be bound.
     */
    public readonly environment!: pulumi.Output<string>;
    /**
     * The unique ID of the service to be bound.
     */
    public readonly serviceId!: pulumi.Output<string>;

    /**
     * Create a ApiAppAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ApiAppAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ApiAppAttachmentArgs | ApiAppAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ApiAppAttachmentState | undefined;
            resourceInputs["apiAppId"] = state ? state.apiAppId : undefined;
            resourceInputs["apiId"] = state ? state.apiId : undefined;
            resourceInputs["environment"] = state ? state.environment : undefined;
            resourceInputs["serviceId"] = state ? state.serviceId : undefined;
        } else {
            const args = argsOrState as ApiAppAttachmentArgs | undefined;
            if ((!args || args.apiAppId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiAppId'");
            }
            if ((!args || args.apiId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'apiId'");
            }
            if ((!args || args.environment === undefined) && !opts.urn) {
                throw new Error("Missing required property 'environment'");
            }
            if ((!args || args.serviceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceId'");
            }
            resourceInputs["apiAppId"] = args ? args.apiAppId : undefined;
            resourceInputs["apiId"] = args ? args.apiId : undefined;
            resourceInputs["environment"] = args ? args.environment : undefined;
            resourceInputs["serviceId"] = args ? args.serviceId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ApiAppAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ApiAppAttachment resources.
 */
export interface ApiAppAttachmentState {
    /**
     * The unique ID of the application to be bound.
     */
    apiAppId?: pulumi.Input<string>;
    /**
     * The unique ID of the API to be bound.
     */
    apiId?: pulumi.Input<string>;
    /**
     * The environment to be bound.
     */
    environment?: pulumi.Input<string>;
    /**
     * The unique ID of the service to be bound.
     */
    serviceId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ApiAppAttachment resource.
 */
export interface ApiAppAttachmentArgs {
    /**
     * The unique ID of the application to be bound.
     */
    apiAppId: pulumi.Input<string>;
    /**
     * The unique ID of the API to be bound.
     */
    apiId: pulumi.Input<string>;
    /**
     * The environment to be bound.
     */
    environment: pulumi.Input<string>;
    /**
     * The unique ID of the service to be bound.
     */
    serviceId: pulumi.Input<string>;
}
