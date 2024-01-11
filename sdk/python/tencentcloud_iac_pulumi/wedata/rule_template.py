# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['RuleTemplateArgs', 'RuleTemplate']

@pulumi.input_type
class RuleTemplateArgs:
    def __init__(__self__, *,
                 project_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 multi_source_flag: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 quality_dim: Optional[pulumi.Input[int]] = None,
                 source_engine_types: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 source_object_type: Optional[pulumi.Input[int]] = None,
                 sql_expression: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[int]] = None,
                 where_flag: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a RuleTemplate resource.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[str] description: Description of Template.
        :param pulumi.Input[bool] multi_source_flag: Whether to associate other library tables.
        :param pulumi.Input[str] name: Template name.
        :param pulumi.Input[int] quality_dim: Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] source_engine_types: The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        :param pulumi.Input[int] source_object_type: Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        :param pulumi.Input[str] sql_expression: SQL Expression.
        :param pulumi.Input[int] type: Template type. `1` means System template, `2` means Custom template.
        :param pulumi.Input[bool] where_flag: If add where.
        """
        pulumi.set(__self__, "project_id", project_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if multi_source_flag is not None:
            pulumi.set(__self__, "multi_source_flag", multi_source_flag)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if quality_dim is not None:
            pulumi.set(__self__, "quality_dim", quality_dim)
        if source_engine_types is not None:
            pulumi.set(__self__, "source_engine_types", source_engine_types)
        if source_object_type is not None:
            pulumi.set(__self__, "source_object_type", source_object_type)
        if sql_expression is not None:
            pulumi.set(__self__, "sql_expression", sql_expression)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if where_flag is not None:
            pulumi.set(__self__, "where_flag", where_flag)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Input[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of Template.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="multiSourceFlag")
    def multi_source_flag(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to associate other library tables.
        """
        return pulumi.get(self, "multi_source_flag")

    @multi_source_flag.setter
    def multi_source_flag(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "multi_source_flag", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Template name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="qualityDim")
    def quality_dim(self) -> Optional[pulumi.Input[int]]:
        """
        Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        """
        return pulumi.get(self, "quality_dim")

    @quality_dim.setter
    def quality_dim(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "quality_dim", value)

    @property
    @pulumi.getter(name="sourceEngineTypes")
    def source_engine_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        """
        return pulumi.get(self, "source_engine_types")

    @source_engine_types.setter
    def source_engine_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "source_engine_types", value)

    @property
    @pulumi.getter(name="sourceObjectType")
    def source_object_type(self) -> Optional[pulumi.Input[int]]:
        """
        Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        """
        return pulumi.get(self, "source_object_type")

    @source_object_type.setter
    def source_object_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "source_object_type", value)

    @property
    @pulumi.getter(name="sqlExpression")
    def sql_expression(self) -> Optional[pulumi.Input[str]]:
        """
        SQL Expression.
        """
        return pulumi.get(self, "sql_expression")

    @sql_expression.setter
    def sql_expression(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sql_expression", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[int]]:
        """
        Template type. `1` means System template, `2` means Custom template.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="whereFlag")
    def where_flag(self) -> Optional[pulumi.Input[bool]]:
        """
        If add where.
        """
        return pulumi.get(self, "where_flag")

    @where_flag.setter
    def where_flag(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "where_flag", value)


@pulumi.input_type
class _RuleTemplateState:
    def __init__(__self__, *,
                 description: Optional[pulumi.Input[str]] = None,
                 multi_source_flag: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 quality_dim: Optional[pulumi.Input[int]] = None,
                 source_engine_types: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 source_object_type: Optional[pulumi.Input[int]] = None,
                 sql_expression: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[int]] = None,
                 where_flag: Optional[pulumi.Input[bool]] = None):
        """
        Input properties used for looking up and filtering RuleTemplate resources.
        :param pulumi.Input[str] description: Description of Template.
        :param pulumi.Input[bool] multi_source_flag: Whether to associate other library tables.
        :param pulumi.Input[str] name: Template name.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[int] quality_dim: Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] source_engine_types: The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        :param pulumi.Input[int] source_object_type: Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        :param pulumi.Input[str] sql_expression: SQL Expression.
        :param pulumi.Input[int] type: Template type. `1` means System template, `2` means Custom template.
        :param pulumi.Input[bool] where_flag: If add where.
        """
        if description is not None:
            pulumi.set(__self__, "description", description)
        if multi_source_flag is not None:
            pulumi.set(__self__, "multi_source_flag", multi_source_flag)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if project_id is not None:
            pulumi.set(__self__, "project_id", project_id)
        if quality_dim is not None:
            pulumi.set(__self__, "quality_dim", quality_dim)
        if source_engine_types is not None:
            pulumi.set(__self__, "source_engine_types", source_engine_types)
        if source_object_type is not None:
            pulumi.set(__self__, "source_object_type", source_object_type)
        if sql_expression is not None:
            pulumi.set(__self__, "sql_expression", sql_expression)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if where_flag is not None:
            pulumi.set(__self__, "where_flag", where_flag)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of Template.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="multiSourceFlag")
    def multi_source_flag(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether to associate other library tables.
        """
        return pulumi.get(self, "multi_source_flag")

    @multi_source_flag.setter
    def multi_source_flag(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "multi_source_flag", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Template name.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> Optional[pulumi.Input[str]]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @project_id.setter
    def project_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_id", value)

    @property
    @pulumi.getter(name="qualityDim")
    def quality_dim(self) -> Optional[pulumi.Input[int]]:
        """
        Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        """
        return pulumi.get(self, "quality_dim")

    @quality_dim.setter
    def quality_dim(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "quality_dim", value)

    @property
    @pulumi.getter(name="sourceEngineTypes")
    def source_engine_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        """
        return pulumi.get(self, "source_engine_types")

    @source_engine_types.setter
    def source_engine_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "source_engine_types", value)

    @property
    @pulumi.getter(name="sourceObjectType")
    def source_object_type(self) -> Optional[pulumi.Input[int]]:
        """
        Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        """
        return pulumi.get(self, "source_object_type")

    @source_object_type.setter
    def source_object_type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "source_object_type", value)

    @property
    @pulumi.getter(name="sqlExpression")
    def sql_expression(self) -> Optional[pulumi.Input[str]]:
        """
        SQL Expression.
        """
        return pulumi.get(self, "sql_expression")

    @sql_expression.setter
    def sql_expression(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sql_expression", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[int]]:
        """
        Template type. `1` means System template, `2` means Custom template.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="whereFlag")
    def where_flag(self) -> Optional[pulumi.Input[bool]]:
        """
        If add where.
        """
        return pulumi.get(self, "where_flag")

    @where_flag.setter
    def where_flag(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "where_flag", value)


class RuleTemplate(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 multi_source_flag: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 quality_dim: Optional[pulumi.Input[int]] = None,
                 source_engine_types: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 source_object_type: Optional[pulumi.Input[int]] = None,
                 sql_expression: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[int]] = None,
                 where_flag: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        """
        Provides a resource to create a wedata rule_template

        ## Import

        wedata rule_template can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Wedata/ruleTemplate:RuleTemplate rule_template rule_template_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of Template.
        :param pulumi.Input[bool] multi_source_flag: Whether to associate other library tables.
        :param pulumi.Input[str] name: Template name.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[int] quality_dim: Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] source_engine_types: The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        :param pulumi.Input[int] source_object_type: Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        :param pulumi.Input[str] sql_expression: SQL Expression.
        :param pulumi.Input[int] type: Template type. `1` means System template, `2` means Custom template.
        :param pulumi.Input[bool] where_flag: If add where.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RuleTemplateArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a wedata rule_template

        ## Import

        wedata rule_template can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Wedata/ruleTemplate:RuleTemplate rule_template rule_template_id
        ```

        :param str resource_name: The name of the resource.
        :param RuleTemplateArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RuleTemplateArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 multi_source_flag: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 project_id: Optional[pulumi.Input[str]] = None,
                 quality_dim: Optional[pulumi.Input[int]] = None,
                 source_engine_types: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 source_object_type: Optional[pulumi.Input[int]] = None,
                 sql_expression: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[int]] = None,
                 where_flag: Optional[pulumi.Input[bool]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.plugin_download_url is None:
            opts.plugin_download_url = _utilities.get_plugin_download_url()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = RuleTemplateArgs.__new__(RuleTemplateArgs)

            __props__.__dict__["description"] = description
            __props__.__dict__["multi_source_flag"] = multi_source_flag
            __props__.__dict__["name"] = name
            if project_id is None and not opts.urn:
                raise TypeError("Missing required property 'project_id'")
            __props__.__dict__["project_id"] = project_id
            __props__.__dict__["quality_dim"] = quality_dim
            __props__.__dict__["source_engine_types"] = source_engine_types
            __props__.__dict__["source_object_type"] = source_object_type
            __props__.__dict__["sql_expression"] = sql_expression
            __props__.__dict__["type"] = type
            __props__.__dict__["where_flag"] = where_flag
        super(RuleTemplate, __self__).__init__(
            'tencentcloud:Wedata/ruleTemplate:RuleTemplate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            description: Optional[pulumi.Input[str]] = None,
            multi_source_flag: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            project_id: Optional[pulumi.Input[str]] = None,
            quality_dim: Optional[pulumi.Input[int]] = None,
            source_engine_types: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            source_object_type: Optional[pulumi.Input[int]] = None,
            sql_expression: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[int]] = None,
            where_flag: Optional[pulumi.Input[bool]] = None) -> 'RuleTemplate':
        """
        Get an existing RuleTemplate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of Template.
        :param pulumi.Input[bool] multi_source_flag: Whether to associate other library tables.
        :param pulumi.Input[str] name: Template name.
        :param pulumi.Input[str] project_id: Project ID.
        :param pulumi.Input[int] quality_dim: Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] source_engine_types: The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        :param pulumi.Input[int] source_object_type: Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        :param pulumi.Input[str] sql_expression: SQL Expression.
        :param pulumi.Input[int] type: Template type. `1` means System template, `2` means Custom template.
        :param pulumi.Input[bool] where_flag: If add where.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _RuleTemplateState.__new__(_RuleTemplateState)

        __props__.__dict__["description"] = description
        __props__.__dict__["multi_source_flag"] = multi_source_flag
        __props__.__dict__["name"] = name
        __props__.__dict__["project_id"] = project_id
        __props__.__dict__["quality_dim"] = quality_dim
        __props__.__dict__["source_engine_types"] = source_engine_types
        __props__.__dict__["source_object_type"] = source_object_type
        __props__.__dict__["sql_expression"] = sql_expression
        __props__.__dict__["type"] = type
        __props__.__dict__["where_flag"] = where_flag
        return RuleTemplate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of Template.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="multiSourceFlag")
    def multi_source_flag(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether to associate other library tables.
        """
        return pulumi.get(self, "multi_source_flag")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Template name.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="projectId")
    def project_id(self) -> pulumi.Output[str]:
        """
        Project ID.
        """
        return pulumi.get(self, "project_id")

    @property
    @pulumi.getter(name="qualityDim")
    def quality_dim(self) -> pulumi.Output[Optional[int]]:
        """
        Quality inspection dimensions. `1`: Accuracy, `2`: Uniqueness, `3`: Completeness, `4`: Consistency, `5`: Timeliness, `6`: Effectiveness.
        """
        return pulumi.get(self, "quality_dim")

    @property
    @pulumi.getter(name="sourceEngineTypes")
    def source_engine_types(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        The engine type corresponding to the source. `2`: hive,`4`: spark, `16`: dlc.
        """
        return pulumi.get(self, "source_engine_types")

    @property
    @pulumi.getter(name="sourceObjectType")
    def source_object_type(self) -> pulumi.Output[Optional[int]]:
        """
        Source data object type. `1`: Constant, `2`: Offline table level, `3`: Offline field level.
        """
        return pulumi.get(self, "source_object_type")

    @property
    @pulumi.getter(name="sqlExpression")
    def sql_expression(self) -> pulumi.Output[Optional[str]]:
        """
        SQL Expression.
        """
        return pulumi.get(self, "sql_expression")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[int]]:
        """
        Template type. `1` means System template, `2` means Custom template.
        """
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="whereFlag")
    def where_flag(self) -> pulumi.Output[Optional[bool]]:
        """
        If add where.
        """
        return pulumi.get(self, "where_flag")
