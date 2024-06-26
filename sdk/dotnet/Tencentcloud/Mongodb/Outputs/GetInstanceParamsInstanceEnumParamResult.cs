// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Mongodb.Outputs
{

    [OutputType]
    public sealed class GetInstanceParamsInstanceEnumParamResult
    {
        /// <summary>
        /// current value.
        /// </summary>
        public readonly string CurrentValue;
        /// <summary>
        /// default value.
        /// </summary>
        public readonly string DefaultValue;
        /// <summary>
        /// enum value.
        /// </summary>
        public readonly ImmutableArray<string> EnumValues;
        /// <summary>
        /// if need restart.
        /// </summary>
        public readonly string NeedRestart;
        /// <summary>
        /// name of parameter.
        /// </summary>
        public readonly string ParamName;
        /// <summary>
        /// if is running.
        /// </summary>
        public readonly int Status;
        /// <summary>
        /// descripition of parameter.
        /// </summary>
        public readonly ImmutableArray<string> Tips;
        /// <summary>
        /// value type.
        /// </summary>
        public readonly string ValueType;

        [OutputConstructor]
        private GetInstanceParamsInstanceEnumParamResult(
            string currentValue,

            string defaultValue,

            ImmutableArray<string> enumValues,

            string needRestart,

            string paramName,

            int status,

            ImmutableArray<string> tips,

            string valueType)
        {
            CurrentValue = currentValue;
            DefaultValue = defaultValue;
            EnumValues = enumValues;
            NeedRestart = needRestart;
            ParamName = paramName;
            Status = status;
            Tips = tips;
            ValueType = valueType;
        }
    }
}
