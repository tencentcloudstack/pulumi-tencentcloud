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

__all__ = ['ActionTimerArgs', 'ActionTimer']

@pulumi.input_type
class ActionTimerArgs:
    def __init__(__self__, *,
                 action_timer: pulumi.Input['ActionTimerActionTimerArgs'],
                 instance_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a ActionTimer resource.
        :param pulumi.Input['ActionTimerActionTimerArgs'] action_timer: Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        :param pulumi.Input[str] instance_id: Instance ID.
        """
        pulumi.set(__self__, "action_timer", action_timer)
        pulumi.set(__self__, "instance_id", instance_id)

    @property
    @pulumi.getter(name="actionTimer")
    def action_timer(self) -> pulumi.Input['ActionTimerActionTimerArgs']:
        """
        Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        """
        return pulumi.get(self, "action_timer")

    @action_timer.setter
    def action_timer(self, value: pulumi.Input['ActionTimerActionTimerArgs']):
        pulumi.set(self, "action_timer", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance ID.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)


@pulumi.input_type
class _ActionTimerState:
    def __init__(__self__, *,
                 action_timer: Optional[pulumi.Input['ActionTimerActionTimerArgs']] = None,
                 instance_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ActionTimer resources.
        :param pulumi.Input['ActionTimerActionTimerArgs'] action_timer: Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        :param pulumi.Input[str] instance_id: Instance ID.
        """
        if action_timer is not None:
            pulumi.set(__self__, "action_timer", action_timer)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)

    @property
    @pulumi.getter(name="actionTimer")
    def action_timer(self) -> Optional[pulumi.Input['ActionTimerActionTimerArgs']]:
        """
        Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        """
        return pulumi.get(self, "action_timer")

    @action_timer.setter
    def action_timer(self, value: Optional[pulumi.Input['ActionTimerActionTimerArgs']]):
        pulumi.set(self, "action_timer", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance ID.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)


class ActionTimer(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action_timer: Optional[pulumi.Input[pulumi.InputType['ActionTimerActionTimerArgs']]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a CVM instance action timer

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        images = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"],
            image_name_regex="TencentOS Server")
        # create vpc
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        # create vpc subnet
        subnet = tencentcloud.subnet.Instance("subnet",
            vpc_id=vpc.id,
            availability_zone=availability_zone,
            cidr_block="10.0.20.0/28",
            is_multicast=False)
        # create cvm
        example_instance = tencentcloud.instance.Instance("exampleInstance",
            instance_name="tf_example",
            availability_zone=availability_zone,
            image_id=images.images[0].image_id,
            instance_type="SA3.MEDIUM4",
            system_disk_type="CLOUD_HSSD",
            system_disk_size=100,
            hostname="example",
            project_id=0,
            vpc_id=vpc.id,
            subnet_id=subnet.id,
            data_disks=[tencentcloud.instance.InstanceDataDiskArgs(
                data_disk_type="CLOUD_HSSD",
                data_disk_size=50,
                encrypt=False,
            )],
            tags={
                "createBy": "terraform",
            })
        # create cvm action timer
        example_action_timer = tencentcloud.cvm.ActionTimer("exampleActionTimer",
            instance_id=example_instance.id,
            action_timer=tencentcloud.cvm.ActionTimerActionTimerArgs(
                timer_action="TerminateInstances",
                action_time="2024-11-11T11:26:40Z",
            ))
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ActionTimerActionTimerArgs']] action_timer: Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        :param pulumi.Input[str] instance_id: Instance ID.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ActionTimerArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a CVM instance action timer

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import pulumi_tencentcloud as tencentcloud
        import tencentcloud_iac_pulumi as tencentcloud

        config = pulumi.Config()
        availability_zone = config.get("availabilityZone")
        if availability_zone is None:
            availability_zone = "ap-guangzhou-6"
        images = tencentcloud.Images.get_instance(image_types=["PUBLIC_IMAGE"],
            image_name_regex="TencentOS Server")
        # create vpc
        vpc = tencentcloud.vpc.Instance("vpc", cidr_block="10.0.0.0/16")
        # create vpc subnet
        subnet = tencentcloud.subnet.Instance("subnet",
            vpc_id=vpc.id,
            availability_zone=availability_zone,
            cidr_block="10.0.20.0/28",
            is_multicast=False)
        # create cvm
        example_instance = tencentcloud.instance.Instance("exampleInstance",
            instance_name="tf_example",
            availability_zone=availability_zone,
            image_id=images.images[0].image_id,
            instance_type="SA3.MEDIUM4",
            system_disk_type="CLOUD_HSSD",
            system_disk_size=100,
            hostname="example",
            project_id=0,
            vpc_id=vpc.id,
            subnet_id=subnet.id,
            data_disks=[tencentcloud.instance.InstanceDataDiskArgs(
                data_disk_type="CLOUD_HSSD",
                data_disk_size=50,
                encrypt=False,
            )],
            tags={
                "createBy": "terraform",
            })
        # create cvm action timer
        example_action_timer = tencentcloud.cvm.ActionTimer("exampleActionTimer",
            instance_id=example_instance.id,
            action_timer=tencentcloud.cvm.ActionTimerActionTimerArgs(
                timer_action="TerminateInstances",
                action_time="2024-11-11T11:26:40Z",
            ))
        ```
        <!--End PulumiCodeChooser -->

        :param str resource_name: The name of the resource.
        :param ActionTimerArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ActionTimerArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action_timer: Optional[pulumi.Input[pulumi.InputType['ActionTimerActionTimerArgs']]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ActionTimerArgs.__new__(ActionTimerArgs)

            if action_timer is None and not opts.urn:
                raise TypeError("Missing required property 'action_timer'")
            __props__.__dict__["action_timer"] = action_timer
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
        super(ActionTimer, __self__).__init__(
            'tencentcloud:Cvm/actionTimer:ActionTimer',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            action_timer: Optional[pulumi.Input[pulumi.InputType['ActionTimerActionTimerArgs']]] = None,
            instance_id: Optional[pulumi.Input[str]] = None) -> 'ActionTimer':
        """
        Get an existing ActionTimer resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['ActionTimerActionTimerArgs']] action_timer: Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        :param pulumi.Input[str] instance_id: Instance ID.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ActionTimerState.__new__(_ActionTimerState)

        __props__.__dict__["action_timer"] = action_timer
        __props__.__dict__["instance_id"] = instance_id
        return ActionTimer(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="actionTimer")
    def action_timer(self) -> pulumi.Output['outputs.ActionTimerActionTimer']:
        """
        Scheduled tasks. This parameter can be used to specify scheduled tasks for instances, and currently only supports scheduled destruction.
        """
        return pulumi.get(self, "action_timer")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance ID.
        """
        return pulumi.get(self, "instance_id")
