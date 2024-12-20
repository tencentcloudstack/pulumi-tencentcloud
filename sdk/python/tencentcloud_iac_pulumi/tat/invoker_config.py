# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['InvokerConfigArgs', 'InvokerConfig']

@pulumi.input_type
class InvokerConfigArgs:
    def __init__(__self__, *,
                 invoker_id: pulumi.Input[str],
                 invoker_status: pulumi.Input[str]):
        """
        The set of arguments for constructing a InvokerConfig resource.
        :param pulumi.Input[str] invoker_id: ID of the invoker to be enabled.
        :param pulumi.Input[str] invoker_status: Invoker on and off state, Values: `on`, `off`.
        """
        pulumi.set(__self__, "invoker_id", invoker_id)
        pulumi.set(__self__, "invoker_status", invoker_status)

    @property
    @pulumi.getter(name="invokerId")
    def invoker_id(self) -> pulumi.Input[str]:
        """
        ID of the invoker to be enabled.
        """
        return pulumi.get(self, "invoker_id")

    @invoker_id.setter
    def invoker_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "invoker_id", value)

    @property
    @pulumi.getter(name="invokerStatus")
    def invoker_status(self) -> pulumi.Input[str]:
        """
        Invoker on and off state, Values: `on`, `off`.
        """
        return pulumi.get(self, "invoker_status")

    @invoker_status.setter
    def invoker_status(self, value: pulumi.Input[str]):
        pulumi.set(self, "invoker_status", value)


@pulumi.input_type
class _InvokerConfigState:
    def __init__(__self__, *,
                 invoker_id: Optional[pulumi.Input[str]] = None,
                 invoker_status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering InvokerConfig resources.
        :param pulumi.Input[str] invoker_id: ID of the invoker to be enabled.
        :param pulumi.Input[str] invoker_status: Invoker on and off state, Values: `on`, `off`.
        """
        if invoker_id is not None:
            pulumi.set(__self__, "invoker_id", invoker_id)
        if invoker_status is not None:
            pulumi.set(__self__, "invoker_status", invoker_status)

    @property
    @pulumi.getter(name="invokerId")
    def invoker_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of the invoker to be enabled.
        """
        return pulumi.get(self, "invoker_id")

    @invoker_id.setter
    def invoker_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "invoker_id", value)

    @property
    @pulumi.getter(name="invokerStatus")
    def invoker_status(self) -> Optional[pulumi.Input[str]]:
        """
        Invoker on and off state, Values: `on`, `off`.
        """
        return pulumi.get(self, "invoker_status")

    @invoker_status.setter
    def invoker_status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "invoker_status", value)


class InvokerConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 invoker_id: Optional[pulumi.Input[str]] = None,
                 invoker_status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a tat invoker_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        invoker_config = tencentcloud.tat.InvokerConfig("invokerConfig",
            invoker_id="ivk-cas4upyf",
            invoker_status="on")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tat invoker_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tat/invokerConfig:InvokerConfig invoker_config invoker_config_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] invoker_id: ID of the invoker to be enabled.
        :param pulumi.Input[str] invoker_status: Invoker on and off state, Values: `on`, `off`.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InvokerConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a tat invoker_config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        invoker_config = tencentcloud.tat.InvokerConfig("invokerConfig",
            invoker_id="ivk-cas4upyf",
            invoker_status="on")
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        tat invoker_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Tat/invokerConfig:InvokerConfig invoker_config invoker_config_id
        ```

        :param str resource_name: The name of the resource.
        :param InvokerConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InvokerConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 invoker_id: Optional[pulumi.Input[str]] = None,
                 invoker_status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InvokerConfigArgs.__new__(InvokerConfigArgs)

            if invoker_id is None and not opts.urn:
                raise TypeError("Missing required property 'invoker_id'")
            __props__.__dict__["invoker_id"] = invoker_id
            if invoker_status is None and not opts.urn:
                raise TypeError("Missing required property 'invoker_status'")
            __props__.__dict__["invoker_status"] = invoker_status
        super(InvokerConfig, __self__).__init__(
            'tencentcloud:Tat/invokerConfig:InvokerConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            invoker_id: Optional[pulumi.Input[str]] = None,
            invoker_status: Optional[pulumi.Input[str]] = None) -> 'InvokerConfig':
        """
        Get an existing InvokerConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] invoker_id: ID of the invoker to be enabled.
        :param pulumi.Input[str] invoker_status: Invoker on and off state, Values: `on`, `off`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InvokerConfigState.__new__(_InvokerConfigState)

        __props__.__dict__["invoker_id"] = invoker_id
        __props__.__dict__["invoker_status"] = invoker_status
        return InvokerConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="invokerId")
    def invoker_id(self) -> pulumi.Output[str]:
        """
        ID of the invoker to be enabled.
        """
        return pulumi.get(self, "invoker_id")

    @property
    @pulumi.getter(name="invokerStatus")
    def invoker_status(self) -> pulumi.Output[str]:
        """
        Invoker on and off state, Values: `on`, `off`.
        """
        return pulumi.get(self, "invoker_status")

