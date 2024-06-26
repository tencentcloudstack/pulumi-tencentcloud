// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.ApiGateway.Inputs
{

    public sealed class ImportOpenApiOauthConfigGetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Redirect address, used to guide users in login operations.
        /// </summary>
        [Input("loginRedirectUrl")]
        public Input<string>? LoginRedirectUrl { get; set; }

        /// <summary>
        /// Public key, used to verify user tokens.
        /// </summary>
        [Input("publicKey")]
        public Input<string>? PublicKey { get; set; }

        /// <summary>
        /// Token passes the position.
        /// </summary>
        [Input("tokenLocation")]
        public Input<string>? TokenLocation { get; set; }

        public ImportOpenApiOauthConfigGetArgs()
        {
        }
        public static new ImportOpenApiOauthConfigGetArgs Empty => new ImportOpenApiOauthConfigGetArgs();
    }
}
