# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['FlowLogConfigArgs', 'FlowLogConfig']

@pulumi.input_type
class FlowLogConfigArgs:
    def __init__(__self__, *,
                 enable: pulumi.Input[bool],
                 flow_log_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a FlowLogConfig resource.
        :param pulumi.Input[bool] enable: If enable snapshot policy.
        :param pulumi.Input[str] flow_log_id: Flow log ID.
        """
        pulumi.set(__self__, "enable", enable)
        pulumi.set(__self__, "flow_log_id", flow_log_id)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Input[bool]:
        """
        If enable snapshot policy.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: pulumi.Input[bool]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="flowLogId")
    def flow_log_id(self) -> pulumi.Input[str]:
        """
        Flow log ID.
        """
        return pulumi.get(self, "flow_log_id")

    @flow_log_id.setter
    def flow_log_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "flow_log_id", value)


@pulumi.input_type
class _FlowLogConfigState:
    def __init__(__self__, *,
                 enable: Optional[pulumi.Input[bool]] = None,
                 flow_log_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering FlowLogConfig resources.
        :param pulumi.Input[bool] enable: If enable snapshot policy.
        :param pulumi.Input[str] flow_log_id: Flow log ID.
        """
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if flow_log_id is not None:
            pulumi.set(__self__, "flow_log_id", flow_log_id)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[bool]]:
        """
        If enable snapshot policy.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="flowLogId")
    def flow_log_id(self) -> Optional[pulumi.Input[str]]:
        """
        Flow log ID.
        """
        return pulumi.get(self, "flow_log_id")

    @flow_log_id.setter
    def flow_log_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "flow_log_id", value)


class FlowLogConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 flow_log_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a vpc flow_log_config

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        flow_log_config = tencentcloud.vpc.FlowLogConfig("flowLogConfig",
            enable=False,
            flow_log_id="fl-geg2keoj")
        ```

        ## Import

        vpc flow_log_config can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Vpc/flowLogConfig:FlowLogConfig flow_log_config flow_log_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable: If enable snapshot policy.
        :param pulumi.Input[str] flow_log_id: Flow log ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FlowLogConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a vpc flow_log_config

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        flow_log_config = tencentcloud.vpc.FlowLogConfig("flowLogConfig",
            enable=False,
            flow_log_id="fl-geg2keoj")
        ```

        ## Import

        vpc flow_log_config can be imported using the id, e.g.

        ```sh
         $ pulumi import tencentcloud:Vpc/flowLogConfig:FlowLogConfig flow_log_config flow_log_id
        ```

        :param str resource_name: The name of the resource.
        :param FlowLogConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FlowLogConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 flow_log_id: Optional[pulumi.Input[str]] = None,
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
            __props__ = FlowLogConfigArgs.__new__(FlowLogConfigArgs)

            if enable is None and not opts.urn:
                raise TypeError("Missing required property 'enable'")
            __props__.__dict__["enable"] = enable
            if flow_log_id is None and not opts.urn:
                raise TypeError("Missing required property 'flow_log_id'")
            __props__.__dict__["flow_log_id"] = flow_log_id
        super(FlowLogConfig, __self__).__init__(
            'tencentcloud:Vpc/flowLogConfig:FlowLogConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            enable: Optional[pulumi.Input[bool]] = None,
            flow_log_id: Optional[pulumi.Input[str]] = None) -> 'FlowLogConfig':
        """
        Get an existing FlowLogConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] enable: If enable snapshot policy.
        :param pulumi.Input[str] flow_log_id: Flow log ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FlowLogConfigState.__new__(_FlowLogConfigState)

        __props__.__dict__["enable"] = enable
        __props__.__dict__["flow_log_id"] = flow_log_id
        return FlowLogConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Output[bool]:
        """
        If enable snapshot policy.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="flowLogId")
    def flow_log_id(self) -> pulumi.Output[str]:
        """
        Flow log ID.
        """
        return pulumi.get(self, "flow_log_id")
