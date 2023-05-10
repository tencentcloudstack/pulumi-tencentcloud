// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Teo
{
    public static class GetBotPortraitRules
    {
        /// <summary>
        /// Use this data source to query detailed information of teo botPortraitRules
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var botPortraitRules = Output.Create(Tencentcloud.Teo.GetBotPortraitRules.InvokeAsync(new Tencentcloud.Teo.GetBotPortraitRulesArgs
        ///         {
        ///             Entity = "",
        ///             ZoneId = "",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetBotPortraitRulesResult> InvokeAsync(GetBotPortraitRulesArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetBotPortraitRulesResult>("tencentcloud:Teo/getBotPortraitRules:getBotPortraitRules", args ?? new GetBotPortraitRulesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query detailed information of teo botPortraitRules
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var botPortraitRules = Output.Create(Tencentcloud.Teo.GetBotPortraitRules.InvokeAsync(new Tencentcloud.Teo.GetBotPortraitRulesArgs
        ///         {
        ///             Entity = "",
        ///             ZoneId = "",
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetBotPortraitRulesResult> Invoke(GetBotPortraitRulesInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetBotPortraitRulesResult>("tencentcloud:Teo/getBotPortraitRules:getBotPortraitRules", args ?? new GetBotPortraitRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBotPortraitRulesArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Subdomain or application name.
        /// </summary>
        [Input("entity", required: true)]
        public string Entity { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// Site ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public string ZoneId { get; set; } = null!;

        public GetBotPortraitRulesArgs()
        {
        }
    }

    public sealed class GetBotPortraitRulesInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Subdomain or application name.
        /// </summary>
        [Input("entity", required: true)]
        public Input<string> Entity { get; set; } = null!;

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// Site ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public GetBotPortraitRulesInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetBotPortraitRulesResult
    {
        public readonly string Entity;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        /// <summary>
        /// Portrait rules list.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetBotPortraitRulesRuleResult> Rules;
        public readonly string ZoneId;

        [OutputConstructor]
        private GetBotPortraitRulesResult(
            string entity,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetBotPortraitRulesRuleResult> rules,

            string zoneId)
        {
            Entity = entity;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Rules = rules;
            ZoneId = zoneId;
        }
    }
}