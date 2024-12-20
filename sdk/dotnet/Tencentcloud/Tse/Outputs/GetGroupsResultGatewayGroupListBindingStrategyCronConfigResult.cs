// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetGroupsResultGatewayGroupListBindingStrategyCronConfigResult
    {
        /// <summary>
        /// group create time.
        /// </summary>
        public readonly string CreateTime;
        /// <summary>
        /// whether to enable timing auto scaling.
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// modify time.
        /// </summary>
        public readonly string ModifyTime;
        /// <summary>
        /// params of timing auto scaling.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetGroupsResultGatewayGroupListBindingStrategyCronConfigParamResult> Params;
        /// <summary>
        /// strategy ID.
        /// </summary>
        public readonly string StrategyId;

        [OutputConstructor]
        private GetGroupsResultGatewayGroupListBindingStrategyCronConfigResult(
            string createTime,

            bool enabled,

            string modifyTime,

            ImmutableArray<Outputs.GetGroupsResultGatewayGroupListBindingStrategyCronConfigParamResult> @params,

            string strategyId)
        {
            CreateTime = createTime;
            Enabled = enabled;
            ModifyTime = modifyTime;
            Params = @params;
            StrategyId = strategyId;
        }
    }
}
