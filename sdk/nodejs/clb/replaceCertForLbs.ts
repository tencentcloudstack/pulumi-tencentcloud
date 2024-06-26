// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides a resource to create a clb replaceCertForLbs
 *
 * ## Example Usage
 *
 * ### Replace Server Cert By Cert ID
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const replaceCertForLbs = new tencentcloud.clb.ReplaceCertForLbs("replaceCertForLbs", {
 *     certificate: {
 *         certId: "6vcK02GC",
 *     },
 *     oldCertificateId: "zjUMifFK",
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Replace Server Cert By Cert Content
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@pulumi/tencentcloud";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const foo = tencentcloud.Ssl.getCertificates({
 *     name: "keep-ssl-ca",
 * });
 * const replaceCertForLbs = new tencentcloud.clb.ReplaceCertForLbs("replaceCertForLbs", {
 *     oldCertificateId: foo.then(foo => foo.certificates?.[0]?.id),
 *     certificate: {
 *         certName: "tf-test-cert",
 *         certContent: `-----BEGIN CERTIFICATE-----
 * xxxxxxxxxxxxxxxxxxxxxxxxxxx
 * -----END CERTIFICATE-----
 * EOT,
 *     certKey     = <<-EOT
 * -----BEGIN RSA PRIVATE KEY-----
 * xxxxxxxxxxxxxxxxxxxxxxxxxxxx
 * -----END RSA PRIVATE KEY-----
 * `,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * ### Replace Client Cert By Cert Content
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as tencentcloud from "@tencentcloud_iac/pulumi";
 *
 * const replaceCertForLbs = new tencentcloud.clb.ReplaceCertForLbs("replaceCertForLbs", {
 *     oldCertificateId: "zjUMifFK",
 *     certificate: {
 *         certCaName: "tf-test-cert",
 *         certCaContent: `-----BEGIN CERTIFICATE-----
 * xxxxxxxxContentxxxxxxxxxxxxxx
 * -----END CERTIFICATE-----
 * `,
 *     },
 * });
 * ```
 * <!--End PulumiCodeChooser -->
 *
 * <!--Start PulumiCodeChooser -->
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * ```
 * <!--End PulumiCodeChooser -->
 */
export class ReplaceCertForLbs extends pulumi.CustomResource {
    /**
     * Get an existing ReplaceCertForLbs resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ReplaceCertForLbsState, opts?: pulumi.CustomResourceOptions): ReplaceCertForLbs {
        return new ReplaceCertForLbs(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Clb/replaceCertForLbs:ReplaceCertForLbs';

    /**
     * Returns true if the given object is an instance of ReplaceCertForLbs.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ReplaceCertForLbs {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ReplaceCertForLbs.__pulumiType;
    }

    /**
     * Information such as the content of the new certificate.
     */
    public readonly certificate!: pulumi.Output<outputs.Clb.ReplaceCertForLbsCertificate>;
    /**
     * ID of the certificate to be replaced, which can be a server certificate or a client certificate.
     */
    public readonly oldCertificateId!: pulumi.Output<string>;

    /**
     * Create a ReplaceCertForLbs resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ReplaceCertForLbsArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ReplaceCertForLbsArgs | ReplaceCertForLbsState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ReplaceCertForLbsState | undefined;
            resourceInputs["certificate"] = state ? state.certificate : undefined;
            resourceInputs["oldCertificateId"] = state ? state.oldCertificateId : undefined;
        } else {
            const args = argsOrState as ReplaceCertForLbsArgs | undefined;
            if ((!args || args.certificate === undefined) && !opts.urn) {
                throw new Error("Missing required property 'certificate'");
            }
            if ((!args || args.oldCertificateId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'oldCertificateId'");
            }
            resourceInputs["certificate"] = args ? args.certificate : undefined;
            resourceInputs["oldCertificateId"] = args ? args.oldCertificateId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ReplaceCertForLbs.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ReplaceCertForLbs resources.
 */
export interface ReplaceCertForLbsState {
    /**
     * Information such as the content of the new certificate.
     */
    certificate?: pulumi.Input<inputs.Clb.ReplaceCertForLbsCertificate>;
    /**
     * ID of the certificate to be replaced, which can be a server certificate or a client certificate.
     */
    oldCertificateId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ReplaceCertForLbs resource.
 */
export interface ReplaceCertForLbsArgs {
    /**
     * Information such as the content of the new certificate.
     */
    certificate: pulumi.Input<inputs.Clb.ReplaceCertForLbsCertificate>;
    /**
     * ID of the certificate to be replaced, which can be a server certificate or a client certificate.
     */
    oldCertificateId: pulumi.Input<string>;
}
