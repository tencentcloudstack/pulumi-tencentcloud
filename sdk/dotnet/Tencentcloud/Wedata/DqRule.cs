// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace TencentCloudIAC.PulumiPackage.Tencentcloud.Wedata
{
    /// <summary>
    /// Provides a resource to create a wedata dq_rule
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Tencentcloud = TencentCloudIAC.PulumiPackage.Tencentcloud;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var example = new Tencentcloud.Wedata.DqRule("example", new Tencentcloud.Wedata.DqRuleArgs
    ///         {
    ///             AlarmLevel = 1,
    ///             CompareRule = new Tencentcloud.Wedata.Inputs.DqRuleCompareRuleArgs
    ///             {
    ///                 Items = 
    ///                 {
    ///                     new Tencentcloud.Wedata.Inputs.DqRuleCompareRuleItemArgs
    ///                     {
    ///                         CompareType = 1,
    ///                         Operator = "==",
    ///                         ValueList = 
    ///                         {
    ///                             
    ///                             {
    ///                                 { "value", "100" },
    ///                                 { "valueType", 3 },
    ///                             },
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             ConditionType = 1,
    ///             Description = "description.",
    ///             ProjectId = "1948767646355341312",
    ///             RuleGroupId = 312,
    ///             RuleTemplateId = 1,
    ///             SourceObjectDataTypeName = "table",
    ///             SourceObjectValue = "表",
    ///             TableId = "N85hbsh5QQ2VLHL2iOUVeQ",
    ///             Type = 1,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Import
    /// 
    /// wedata dq_rule can be imported using the id, e.g.
    /// 
    /// ```sh
    ///  $ pulumi import tencentcloud:Wedata/dqRule:DqRule example 1948767646355341312#894
    /// ```
    /// </summary>
    [TencentcloudResourceType("tencentcloud:Wedata/dqRule:DqRule")]
    public partial class DqRule : Pulumi.CustomResource
    {
        /// <summary>
        /// Alarm trigger levels 1. Low, 2. Medium, 3. High.
        /// </summary>
        [Output("alarmLevel")]
        public Output<int> AlarmLevel { get; private set; } = null!;

        /// <summary>
        /// Alarm trigger condition.
        /// </summary>
        [Output("compareRule")]
        public Output<Outputs.DqRuleCompareRule> CompareRule { get; private set; } = null!;

        /// <summary>
        /// Condition scans WHERE condition expressions.
        /// </summary>
        [Output("conditionExpression")]
        public Output<string?> ConditionExpression { get; private set; } = null!;

        /// <summary>
        /// Detection scope 1. Full Table 2. Conditional scan.
        /// </summary>
        [Output("conditionType")]
        public Output<int> ConditionType { get; private set; } = null!;

        /// <summary>
        /// Custom sql.
        /// </summary>
        [Output("customSql")]
        public Output<string?> CustomSql { get; private set; } = null!;

        /// <summary>
        /// Rule description.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Custom template sql expression field replacement parameters.
        /// </summary>
        [Output("fieldConfig")]
        public Output<Outputs.DqRuleFieldConfig?> FieldConfig { get; private set; } = null!;

        /// <summary>
        /// Rule name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Project id.
        /// </summary>
        [Output("projectId")]
        public Output<string> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
        /// </summary>
        [Output("qualityDim")]
        public Output<int> QualityDim { get; private set; } = null!;

        /// <summary>
        /// The source field and the target field are associated with a conditional on expression.
        /// </summary>
        [Output("relConditionExpr")]
        public Output<string?> RelConditionExpr { get; private set; } = null!;

        /// <summary>
        /// Rule group id.
        /// </summary>
        [Output("ruleGroupId")]
        public Output<int?> RuleGroupId { get; private set; } = null!;

        /// <summary>
        /// Rule ID.
        /// </summary>
        [Output("ruleId")]
        public Output<string> RuleId { get; private set; } = null!;

        /// <summary>
        /// Rule template id.
        /// </summary>
        [Output("ruleTemplateId")]
        public Output<int> RuleTemplateId { get; private set; } = null!;

        /// <summary>
        /// List of execution engines supported by this rule.
        /// </summary>
        [Output("sourceEngineTypes")]
        public Output<ImmutableArray<int>> SourceEngineTypes { get; private set; } = null!;

        /// <summary>
        /// Source field type. int, string.
        /// </summary>
        [Output("sourceObjectDataTypeName")]
        public Output<string> SourceObjectDataTypeName { get; private set; } = null!;

        /// <summary>
        /// Source field name.
        /// </summary>
        [Output("sourceObjectValue")]
        public Output<string> SourceObjectValue { get; private set; } = null!;

        /// <summary>
        /// Table id.
        /// </summary>
        [Output("tableId")]
        public Output<string?> TableId { get; private set; } = null!;

        /// <summary>
        /// Target filter condition expression.
        /// </summary>
        [Output("targetConditionExpr")]
        public Output<string?> TargetConditionExpr { get; private set; } = null!;

        /// <summary>
        /// Target database id.
        /// </summary>
        [Output("targetDatabaseId")]
        public Output<string?> TargetDatabaseId { get; private set; } = null!;

        /// <summary>
        /// Target field name  CITY.
        /// </summary>
        [Output("targetObjectValue")]
        public Output<string?> TargetObjectValue { get; private set; } = null!;

        /// <summary>
        /// Target table id.
        /// </summary>
        [Output("targetTableId")]
        public Output<string?> TargetTableId { get; private set; } = null!;

        /// <summary>
        /// Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
        /// </summary>
        [Output("type")]
        public Output<int> Type { get; private set; } = null!;


        /// <summary>
        /// Create a DqRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DqRule(string name, DqRuleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Wedata/dqRule:DqRule", name, args ?? new DqRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DqRule(string name, Input<string> id, DqRuleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Wedata/dqRule:DqRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "github://api.github.com/tencentcloudstack",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DqRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DqRule Get(string name, Input<string> id, DqRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new DqRule(name, id, state, options);
        }
    }

    public sealed class DqRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alarm trigger levels 1. Low, 2. Medium, 3. High.
        /// </summary>
        [Input("alarmLevel", required: true)]
        public Input<int> AlarmLevel { get; set; } = null!;

        /// <summary>
        /// Alarm trigger condition.
        /// </summary>
        [Input("compareRule", required: true)]
        public Input<Inputs.DqRuleCompareRuleArgs> CompareRule { get; set; } = null!;

        /// <summary>
        /// Condition scans WHERE condition expressions.
        /// </summary>
        [Input("conditionExpression")]
        public Input<string>? ConditionExpression { get; set; }

        /// <summary>
        /// Detection scope 1. Full Table 2. Conditional scan.
        /// </summary>
        [Input("conditionType", required: true)]
        public Input<int> ConditionType { get; set; } = null!;

        /// <summary>
        /// Custom sql.
        /// </summary>
        [Input("customSql")]
        public Input<string>? CustomSql { get; set; }

        /// <summary>
        /// Rule description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Custom template sql expression field replacement parameters.
        /// </summary>
        [Input("fieldConfig")]
        public Input<Inputs.DqRuleFieldConfigArgs>? FieldConfig { get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Project id.
        /// </summary>
        [Input("projectId", required: true)]
        public Input<string> ProjectId { get; set; } = null!;

        /// <summary>
        /// Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
        /// </summary>
        [Input("qualityDim")]
        public Input<int>? QualityDim { get; set; }

        /// <summary>
        /// The source field and the target field are associated with a conditional on expression.
        /// </summary>
        [Input("relConditionExpr")]
        public Input<string>? RelConditionExpr { get; set; }

        /// <summary>
        /// Rule group id.
        /// </summary>
        [Input("ruleGroupId")]
        public Input<int>? RuleGroupId { get; set; }

        /// <summary>
        /// Rule template id.
        /// </summary>
        [Input("ruleTemplateId", required: true)]
        public Input<int> RuleTemplateId { get; set; } = null!;

        [Input("sourceEngineTypes")]
        private InputList<int>? _sourceEngineTypes;

        /// <summary>
        /// List of execution engines supported by this rule.
        /// </summary>
        public InputList<int> SourceEngineTypes
        {
            get => _sourceEngineTypes ?? (_sourceEngineTypes = new InputList<int>());
            set => _sourceEngineTypes = value;
        }

        /// <summary>
        /// Source field type. int, string.
        /// </summary>
        [Input("sourceObjectDataTypeName", required: true)]
        public Input<string> SourceObjectDataTypeName { get; set; } = null!;

        /// <summary>
        /// Source field name.
        /// </summary>
        [Input("sourceObjectValue", required: true)]
        public Input<string> SourceObjectValue { get; set; } = null!;

        /// <summary>
        /// Table id.
        /// </summary>
        [Input("tableId")]
        public Input<string>? TableId { get; set; }

        /// <summary>
        /// Target filter condition expression.
        /// </summary>
        [Input("targetConditionExpr")]
        public Input<string>? TargetConditionExpr { get; set; }

        /// <summary>
        /// Target database id.
        /// </summary>
        [Input("targetDatabaseId")]
        public Input<string>? TargetDatabaseId { get; set; }

        /// <summary>
        /// Target field name  CITY.
        /// </summary>
        [Input("targetObjectValue")]
        public Input<string>? TargetObjectValue { get; set; }

        /// <summary>
        /// Target table id.
        /// </summary>
        [Input("targetTableId")]
        public Input<string>? TargetTableId { get; set; }

        /// <summary>
        /// Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
        /// </summary>
        [Input("type", required: true)]
        public Input<int> Type { get; set; } = null!;

        public DqRuleArgs()
        {
        }
    }

    public sealed class DqRuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Alarm trigger levels 1. Low, 2. Medium, 3. High.
        /// </summary>
        [Input("alarmLevel")]
        public Input<int>? AlarmLevel { get; set; }

        /// <summary>
        /// Alarm trigger condition.
        /// </summary>
        [Input("compareRule")]
        public Input<Inputs.DqRuleCompareRuleGetArgs>? CompareRule { get; set; }

        /// <summary>
        /// Condition scans WHERE condition expressions.
        /// </summary>
        [Input("conditionExpression")]
        public Input<string>? ConditionExpression { get; set; }

        /// <summary>
        /// Detection scope 1. Full Table 2. Conditional scan.
        /// </summary>
        [Input("conditionType")]
        public Input<int>? ConditionType { get; set; }

        /// <summary>
        /// Custom sql.
        /// </summary>
        [Input("customSql")]
        public Input<string>? CustomSql { get; set; }

        /// <summary>
        /// Rule description.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Custom template sql expression field replacement parameters.
        /// </summary>
        [Input("fieldConfig")]
        public Input<Inputs.DqRuleFieldConfigGetArgs>? FieldConfig { get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Project id.
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// Rules belong to quality dimensions (1. accuracy, 2. uniqueness, 3. completeness, 4. consistency, 5. timeliness, 6. effectiveness).
        /// </summary>
        [Input("qualityDim")]
        public Input<int>? QualityDim { get; set; }

        /// <summary>
        /// The source field and the target field are associated with a conditional on expression.
        /// </summary>
        [Input("relConditionExpr")]
        public Input<string>? RelConditionExpr { get; set; }

        /// <summary>
        /// Rule group id.
        /// </summary>
        [Input("ruleGroupId")]
        public Input<int>? RuleGroupId { get; set; }

        /// <summary>
        /// Rule ID.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        /// <summary>
        /// Rule template id.
        /// </summary>
        [Input("ruleTemplateId")]
        public Input<int>? RuleTemplateId { get; set; }

        [Input("sourceEngineTypes")]
        private InputList<int>? _sourceEngineTypes;

        /// <summary>
        /// List of execution engines supported by this rule.
        /// </summary>
        public InputList<int> SourceEngineTypes
        {
            get => _sourceEngineTypes ?? (_sourceEngineTypes = new InputList<int>());
            set => _sourceEngineTypes = value;
        }

        /// <summary>
        /// Source field type. int, string.
        /// </summary>
        [Input("sourceObjectDataTypeName")]
        public Input<string>? SourceObjectDataTypeName { get; set; }

        /// <summary>
        /// Source field name.
        /// </summary>
        [Input("sourceObjectValue")]
        public Input<string>? SourceObjectValue { get; set; }

        /// <summary>
        /// Table id.
        /// </summary>
        [Input("tableId")]
        public Input<string>? TableId { get; set; }

        /// <summary>
        /// Target filter condition expression.
        /// </summary>
        [Input("targetConditionExpr")]
        public Input<string>? TargetConditionExpr { get; set; }

        /// <summary>
        /// Target database id.
        /// </summary>
        [Input("targetDatabaseId")]
        public Input<string>? TargetDatabaseId { get; set; }

        /// <summary>
        /// Target field name  CITY.
        /// </summary>
        [Input("targetObjectValue")]
        public Input<string>? TargetObjectValue { get; set; }

        /// <summary>
        /// Target table id.
        /// </summary>
        [Input("targetTableId")]
        public Input<string>? TargetTableId { get; set; }

        /// <summary>
        /// Rule Type 1. System Template, 2. Custom Template, 3. Custom SQL.
        /// </summary>
        [Input("type")]
        public Input<int>? Type { get; set; }

        public DqRuleState()
        {
        }
    }
}