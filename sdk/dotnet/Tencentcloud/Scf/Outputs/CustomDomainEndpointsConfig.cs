// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Scf.Outputs
{

    [OutputType]
    public sealed class CustomDomainEndpointsConfig
    {
        /// <summary>
        /// Function name.
        /// </summary>
        public readonly string FunctionName;
        /// <summary>
        /// Function namespace.
        /// </summary>
        public readonly string Namespace;
        /// <summary>
        /// Path, value specification: /,/*,/xxx,/xxx/a,/xxx/*.
        /// </summary>
        public readonly string PathMatch;
        /// <summary>
        /// Path rewriting policy.
        /// </summary>
        public readonly ImmutableArray<Outputs.CustomDomainEndpointsConfigPathRewrite> PathRewrites;
        /// <summary>
        /// Function alias or version.
        /// </summary>
        public readonly string Qualifier;

        [OutputConstructor]
        private CustomDomainEndpointsConfig(
            string functionName,

            string @namespace,

            string pathMatch,

            ImmutableArray<Outputs.CustomDomainEndpointsConfigPathRewrite> pathRewrites,

            string qualifier)
        {
            FunctionName = functionName;
            Namespace = @namespace;
            PathMatch = pathMatch;
            PathRewrites = pathRewrites;
            Qualifier = qualifier;
        }
    }
}