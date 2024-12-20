# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['PacketFilterConfigArgs', 'PacketFilterConfig']

@pulumi.input_type
class PacketFilterConfigArgs:
    def __init__(__self__, *,
                 instance_id: pulumi.Input[str],
                 packet_filter_config: pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']):
        """
        The set of arguments for constructing a PacketFilterConfig resource.
        :param pulumi.Input[str] instance_id: resource id.
        :param pulumi.Input['PacketFilterConfigPacketFilterConfigArgs'] packet_filter_config: Feature filtering configuration.
        """
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "packet_filter_config", packet_filter_config)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        resource id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="packetFilterConfig")
    def packet_filter_config(self) -> pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']:
        """
        Feature filtering configuration.
        """
        return pulumi.get(self, "packet_filter_config")

    @packet_filter_config.setter
    def packet_filter_config(self, value: pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']):
        pulumi.set(self, "packet_filter_config", value)


@pulumi.input_type
class _PacketFilterConfigState:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 packet_filter_config: Optional[pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']] = None):
        """
        Input properties used for looking up and filtering PacketFilterConfig resources.
        :param pulumi.Input[str] instance_id: resource id.
        :param pulumi.Input['PacketFilterConfigPacketFilterConfigArgs'] packet_filter_config: Feature filtering configuration.
        """
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if packet_filter_config is not None:
            pulumi.set(__self__, "packet_filter_config", packet_filter_config)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        resource id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter(name="packetFilterConfig")
    def packet_filter_config(self) -> Optional[pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']]:
        """
        Feature filtering configuration.
        """
        return pulumi.get(self, "packet_filter_config")

    @packet_filter_config.setter
    def packet_filter_config(self, value: Optional[pulumi.Input['PacketFilterConfigPacketFilterConfigArgs']]):
        pulumi.set(self, "packet_filter_config", value)


class PacketFilterConfig(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 packet_filter_config: Optional[pulumi.Input[pulumi.InputType['PacketFilterConfigPacketFilterConfigArgs']]] = None,
                 __props__=None):
        """
        Provides a resource to create a antiddos packet filter config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        packet_filter_config = tencentcloud.antiddos.PacketFilterConfig("packetFilterConfig",
            instance_id="bgp-00000ry7",
            packet_filter_config=tencentcloud.antiddos.PacketFilterConfigPacketFilterConfigArgs(
                action="drop",
                depth=1,
                dport_end=80,
                dport_start=80,
                is_not=0,
                match_begin="begin_l5",
                match_type="pcre",
                offset=1,
                pktlen_max=1400,
                pktlen_min=1400,
                protocol="all",
                sport_end=8080,
                sport_start=8080,
                str="a",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        antiddos packet_filter_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Antiddos/packetFilterConfig:PacketFilterConfig packet_filter_config packet_filter_config_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: resource id.
        :param pulumi.Input[pulumi.InputType['PacketFilterConfigPacketFilterConfigArgs']] packet_filter_config: Feature filtering configuration.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: PacketFilterConfigArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a antiddos packet filter config

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        packet_filter_config = tencentcloud.antiddos.PacketFilterConfig("packetFilterConfig",
            instance_id="bgp-00000ry7",
            packet_filter_config=tencentcloud.antiddos.PacketFilterConfigPacketFilterConfigArgs(
                action="drop",
                depth=1,
                dport_end=80,
                dport_start=80,
                is_not=0,
                match_begin="begin_l5",
                match_type="pcre",
                offset=1,
                pktlen_max=1400,
                pktlen_min=1400,
                protocol="all",
                sport_end=8080,
                sport_start=8080,
                str="a",
            ))
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        antiddos packet_filter_config can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Antiddos/packetFilterConfig:PacketFilterConfig packet_filter_config packet_filter_config_id
        ```

        :param str resource_name: The name of the resource.
        :param PacketFilterConfigArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(PacketFilterConfigArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 packet_filter_config: Optional[pulumi.Input[pulumi.InputType['PacketFilterConfigPacketFilterConfigArgs']]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = PacketFilterConfigArgs.__new__(PacketFilterConfigArgs)

            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if packet_filter_config is None and not opts.urn:
                raise TypeError("Missing required property 'packet_filter_config'")
            __props__.__dict__["packet_filter_config"] = packet_filter_config
        super(PacketFilterConfig, __self__).__init__(
            'tencentcloud:Antiddos/packetFilterConfig:PacketFilterConfig',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            packet_filter_config: Optional[pulumi.Input[pulumi.InputType['PacketFilterConfigPacketFilterConfigArgs']]] = None) -> 'PacketFilterConfig':
        """
        Get an existing PacketFilterConfig resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] instance_id: resource id.
        :param pulumi.Input[pulumi.InputType['PacketFilterConfigPacketFilterConfigArgs']] packet_filter_config: Feature filtering configuration.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _PacketFilterConfigState.__new__(_PacketFilterConfigState)

        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["packet_filter_config"] = packet_filter_config
        return PacketFilterConfig(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        resource id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="packetFilterConfig")
    def packet_filter_config(self) -> pulumi.Output['outputs.PacketFilterConfigPacketFilterConfig']:
        """
        Feature filtering configuration.
        """
        return pulumi.get(self, "packet_filter_config")

