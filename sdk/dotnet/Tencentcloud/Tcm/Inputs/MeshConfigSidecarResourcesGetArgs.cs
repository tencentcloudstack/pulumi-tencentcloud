// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tcm.Inputs
{

    public sealed class MeshConfigSidecarResourcesGetArgs : Pulumi.ResourceArgs
    {
        [Input("limits")]
        private InputList<Inputs.MeshConfigSidecarResourcesLimitGetArgs>? _limits;

        /// <summary>
        /// Sidecar limits.
        /// </summary>
        public InputList<Inputs.MeshConfigSidecarResourcesLimitGetArgs> Limits
        {
            get => _limits ?? (_limits = new InputList<Inputs.MeshConfigSidecarResourcesLimitGetArgs>());
            set => _limits = value;
        }

        [Input("requests")]
        private InputList<Inputs.MeshConfigSidecarResourcesRequestGetArgs>? _requests;

        /// <summary>
        /// Sidecar requests.
        /// </summary>
        public InputList<Inputs.MeshConfigSidecarResourcesRequestGetArgs> Requests
        {
            get => _requests ?? (_requests = new InputList<Inputs.MeshConfigSidecarResourcesRequestGetArgs>());
            set => _requests = value;
        }

        public MeshConfigSidecarResourcesGetArgs()
        {
        }
    }
}