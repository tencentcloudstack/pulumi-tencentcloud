# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['StopLogstashPipelineOperationArgs', 'StopLogstashPipelineOperation']

@pulumi.input_type
class StopLogstashPipelineOperationArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 pipeline_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a StopLogstashPipelineOperation resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] pipeline_id: Pipeline id.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "pipeline_id", pipeline_id)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="pipelineId")
    def pipeline_id(self) -> pulumi.Input[str]:
        """
        Pipeline id.
        """
        return pulumi.get(self, "pipeline_id")

    @pipeline_id.setter
    def pipeline_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "pipeline_id", value)


@pulumi.input_type
class _StopLogstashPipelineOperationState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 pipeline_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering StopLogstashPipelineOperation resources.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] pipeline_id: Pipeline id.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if pipeline_id is not None:
            pulumi.set(__self__, "pipeline_id", pipeline_id)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="pipelineId")
    def pipeline_id(self) -> Optional[pulumi.Input[str]]:
        """
        Pipeline id.
        """
        return pulumi.get(self, "pipeline_id")

    @pipeline_id.setter
    def pipeline_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pipeline_id", value)


class StopLogstashPipelineOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 pipeline_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to stop a elasticsearch logstash pipeline

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        stop_logstash_pipeline_operation = tencentcloud.elasticsearch.StopLogstashPipelineOperation("stopLogstashPipelineOperation",
            instance_id="ls-xxxxxx",
            pipeline_id="xxxxxx")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] pipeline_id: Pipeline id.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StopLogstashPipelineOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to stop a elasticsearch logstash pipeline

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        stop_logstash_pipeline_operation = tencentcloud.elasticsearch.StopLogstashPipelineOperation("stopLogstashPipelineOperation",
            instance_id="ls-xxxxxx",
            pipeline_id="xxxxxx")
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param StopLogstashPipelineOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StopLogstashPipelineOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 pipeline_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = StopLogstashPipelineOperationArgs.__new__(StopLogstashPipelineOperationArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if pipeline_id is None and not opts.urn:
                raise TypeError("Missing required property 'pipeline_id'")
            __props__.__dict__["pipeline_id"] = pipeline_id
        super(StopLogstashPipelineOperation, __self__).__init__(
            'tencentcloud:Elasticsearch/stopLogstashPipelineOperation:StopLogstashPipelineOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            pipeline_id: Optional[pulumi.Input[str]] = None) -> 'StopLogstashPipelineOperation':
        """
        Get an existing StopLogstashPipelineOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: Instance id.
        :param pulumi.Input[str] pipeline_id: Pipeline id.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _StopLogstashPipelineOperationState.__new__(_StopLogstashPipelineOperationState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["pipeline_id"] = pipeline_id
        return StopLogstashPipelineOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="pipelineId")
    def pipeline_id(self) -> pulumi.Output[str]:
        """
        Pipeline id.
        """
        return pulumi.get(self, "pipeline_id")

