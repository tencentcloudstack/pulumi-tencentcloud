// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Gaap
{
    public static class GetSecurityRules
    {
        /// <summary>
        /// Use this data source to query security policy rule.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var fooProxy = new Tencentcloud.Gaap.Proxy("fooProxy", new()
        ///     {
        ///         Bandwidth = 10,
        ///         Concurrent = 2,
        ///         AccessRegion = "SouthChina",
        ///         RealserverRegion = "NorthChina",
        ///     });
        /// 
        ///     var fooSecurityPolicy = new Tencentcloud.Gaap.SecurityPolicy("fooSecurityPolicy", new()
        ///     {
        ///         ProxyId = fooProxy.Id,
        ///         Action = "ACCEPT",
        ///     });
        /// 
        ///     var fooSecurityRule = new Tencentcloud.Gaap.SecurityRule("fooSecurityRule", new()
        ///     {
        ///         PolicyId = fooSecurityPolicy.Id,
        ///         CidrIp = "1.1.1.1",
        ///         Action = "ACCEPT",
        ///         Protocol = "TCP",
        ///         Port = "80",
        ///     });
        /// 
        ///     var protocol = Tencentcloud.Gaap.GetSecurityRules.Invoke(new()
        ///     {
        ///         PolicyId = fooSecurityPolicy.Id,
        ///         Protocol = fooSecurityRule.Protocol,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Task<GetSecurityRulesResult> InvokeAsync(GetSecurityRulesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSecurityRulesResult>("tencentcloud:Gaap/getSecurityRules:getSecurityRules", args ?? new GetSecurityRulesArgs(), options.WithDefaults());

        /// <summary>
        /// Use this data source to query security policy rule.
        /// 
        /// ## Example Usage
        /// 
        /// &lt;!--Start PulumiCodeChooser --&gt;
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Tencentcloud = Pulumi.Tencentcloud;
        /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var fooProxy = new Tencentcloud.Gaap.Proxy("fooProxy", new()
        ///     {
        ///         Bandwidth = 10,
        ///         Concurrent = 2,
        ///         AccessRegion = "SouthChina",
        ///         RealserverRegion = "NorthChina",
        ///     });
        /// 
        ///     var fooSecurityPolicy = new Tencentcloud.Gaap.SecurityPolicy("fooSecurityPolicy", new()
        ///     {
        ///         ProxyId = fooProxy.Id,
        ///         Action = "ACCEPT",
        ///     });
        /// 
        ///     var fooSecurityRule = new Tencentcloud.Gaap.SecurityRule("fooSecurityRule", new()
        ///     {
        ///         PolicyId = fooSecurityPolicy.Id,
        ///         CidrIp = "1.1.1.1",
        ///         Action = "ACCEPT",
        ///         Protocol = "TCP",
        ///         Port = "80",
        ///     });
        /// 
        ///     var protocol = Tencentcloud.Gaap.GetSecurityRules.Invoke(new()
        ///     {
        ///         PolicyId = fooSecurityPolicy.Id,
        ///         Protocol = fooSecurityRule.Protocol,
        ///     });
        /// 
        /// });
        /// ```
        /// &lt;!--End PulumiCodeChooser --&gt;
        /// </summary>
        public static Output<GetSecurityRulesResult> Invoke(GetSecurityRulesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSecurityRulesResult>("tencentcloud:Gaap/getSecurityRules:getSecurityRules", args ?? new GetSecurityRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSecurityRulesArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Policy of the rule to be queried.
        /// </summary>
        [Input("action")]
        public string? Action { get; set; }

        /// <summary>
        /// A network address block of the request source to be queried.
        /// </summary>
        [Input("cidrIp")]
        public string? CidrIp { get; set; }

        /// <summary>
        /// Name of the security policy rule to be queried.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// ID of the security policy to be queried.
        /// </summary>
        [Input("policyId", required: true)]
        public string PolicyId { get; set; } = null!;

        /// <summary>
        /// Port of the security policy rule to be queried.
        /// </summary>
        [Input("port")]
        public string? Port { get; set; }

        /// <summary>
        /// Protocol of the security policy rule to be queried.
        /// </summary>
        [Input("protocol")]
        public string? Protocol { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of the security policy rules to be queried.
        /// </summary>
        [Input("ruleId")]
        public string? RuleId { get; set; }

        public GetSecurityRulesArgs()
        {
        }
        public static new GetSecurityRulesArgs Empty => new GetSecurityRulesArgs();
    }

    public sealed class GetSecurityRulesInvokeArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Policy of the rule to be queried.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// A network address block of the request source to be queried.
        /// </summary>
        [Input("cidrIp")]
        public Input<string>? CidrIp { get; set; }

        /// <summary>
        /// Name of the security policy rule to be queried.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// ID of the security policy to be queried.
        /// </summary>
        [Input("policyId", required: true)]
        public Input<string> PolicyId { get; set; } = null!;

        /// <summary>
        /// Port of the security policy rule to be queried.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        /// <summary>
        /// Protocol of the security policy rule to be queried.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// Used to save results.
        /// </summary>
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        /// <summary>
        /// ID of the security policy rules to be queried.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        public GetSecurityRulesInvokeArgs()
        {
        }
        public static new GetSecurityRulesInvokeArgs Empty => new GetSecurityRulesInvokeArgs();
    }


    [OutputType]
    public sealed class GetSecurityRulesResult
    {
        /// <summary>
        /// Policy of the rule.
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// A network address block of the request source.
        /// </summary>
        public readonly string? CidrIp;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Name of the security policy rule.
        /// </summary>
        public readonly string? Name;
        public readonly string PolicyId;
        /// <summary>
        /// Port of the security policy rule.
        /// </summary>
        public readonly string? Port;
        /// <summary>
        /// Protocol of the security policy rule.
        /// </summary>
        public readonly string? Protocol;
        public readonly string? ResultOutputFile;
        public readonly string? RuleId;
        /// <summary>
        /// An information list of security policy rule. Each element contains the following attributes:
        /// </summary>
        public readonly ImmutableArray<Outputs.GetSecurityRulesRuleResult> Rules;

        [OutputConstructor]
        private GetSecurityRulesResult(
            string? action,

            string? cidrIp,

            string id,

            string? name,

            string policyId,

            string? port,

            string? protocol,

            string? resultOutputFile,

            string? ruleId,

            ImmutableArray<Outputs.GetSecurityRulesRuleResult> rules)
        {
            Action = action;
            CidrIp = cidrIp;
            Id = id;
            Name = name;
            PolicyId = policyId;
            Port = port;
            Protocol = protocol;
            ResultOutputFile = resultOutputFile;
            RuleId = ruleId;
            Rules = rules;
        }
    }
}
