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

__all__ = ['HbaseInstanceArgs', 'HbaseInstance']

@pulumi.input_type
class HbaseInstanceArgs:
    def __init__(__self__, *,
                 disk_size: pulumi.Input[int],
                 disk_type: pulumi.Input[str],
                 instance_name: pulumi.Input[str],
                 node_type: pulumi.Input[str],
                 pay_mode: pulumi.Input[int],
                 zone_settings: pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]],
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]] = None):
        """
        The set of arguments for constructing a HbaseInstance resource.
        :param pulumi.Input[int] disk_size: Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        :param pulumi.Input[str] disk_type: Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        :param pulumi.Input[str] instance_name: Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        :param pulumi.Input[str] node_type: Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        :param pulumi.Input[int] pay_mode: Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        :param pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]] zone_settings: Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        :param pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]] tags: List of tags to bind to the instance.
        """
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "disk_type", disk_type)
        pulumi.set(__self__, "instance_name", instance_name)
        pulumi.set(__self__, "node_type", node_type)
        pulumi.set(__self__, "pay_mode", pay_mode)
        pulumi.set(__self__, "zone_settings", zone_settings)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Input[int]:
        """
        Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        """
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> pulumi.Input[str]:
        """
        Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        """
        return pulumi.get(self, "disk_type")

    @disk_type.setter
    def disk_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "disk_type", value)

    @property
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> pulumi.Input[str]:
        """
        Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        """
        return pulumi.get(self, "instance_name")

    @instance_name.setter
    def instance_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_name", value)

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> pulumi.Input[str]:
        """
        Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        """
        return pulumi.get(self, "node_type")

    @node_type.setter
    def node_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "node_type", value)

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> pulumi.Input[int]:
        """
        Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        """
        return pulumi.get(self, "pay_mode")

    @pay_mode.setter
    def pay_mode(self, value: pulumi.Input[int]):
        pulumi.set(self, "pay_mode", value)

    @property
    @pulumi.getter(name="zoneSettings")
    def zone_settings(self) -> pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]]:
        """
        Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        return pulumi.get(self, "zone_settings")

    @zone_settings.setter
    def zone_settings(self, value: pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]]):
        pulumi.set(self, "zone_settings", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]]:
        """
        List of tags to bind to the instance.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]]):
        pulumi.set(self, "tags", value)


@pulumi.input_type
class _HbaseInstanceState:
    def __init__(__self__, *,
                 disk_size: Optional[pulumi.Input[int]] = None,
                 disk_type: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 pay_mode: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]] = None,
                 zone_settings: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]]] = None):
        """
        Input properties used for looking up and filtering HbaseInstance resources.
        :param pulumi.Input[int] disk_size: Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        :param pulumi.Input[str] disk_type: Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        :param pulumi.Input[str] instance_name: Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        :param pulumi.Input[str] node_type: Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        :param pulumi.Input[int] pay_mode: Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        :param pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]] tags: List of tags to bind to the instance.
        :param pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]] zone_settings: Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        if disk_size is not None:
            pulumi.set(__self__, "disk_size", disk_size)
        if disk_type is not None:
            pulumi.set(__self__, "disk_type", disk_type)
        if instance_name is not None:
            pulumi.set(__self__, "instance_name", instance_name)
        if node_type is not None:
            pulumi.set(__self__, "node_type", node_type)
        if pay_mode is not None:
            pulumi.set(__self__, "pay_mode", pay_mode)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if zone_settings is not None:
            pulumi.set(__self__, "zone_settings", zone_settings)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> Optional[pulumi.Input[int]]:
        """
        Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        """
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> Optional[pulumi.Input[str]]:
        """
        Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        """
        return pulumi.get(self, "disk_type")

    @disk_type.setter
    def disk_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "disk_type", value)

    @property
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> Optional[pulumi.Input[str]]:
        """
        Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        """
        return pulumi.get(self, "instance_name")

    @instance_name.setter
    def instance_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_name", value)

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> Optional[pulumi.Input[str]]:
        """
        Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        """
        return pulumi.get(self, "node_type")

    @node_type.setter
    def node_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "node_type", value)

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> Optional[pulumi.Input[int]]:
        """
        Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        """
        return pulumi.get(self, "pay_mode")

    @pay_mode.setter
    def pay_mode(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "pay_mode", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]]:
        """
        List of tags to bind to the instance.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="zoneSettings")
    def zone_settings(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]]]:
        """
        Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        return pulumi.get(self, "zone_settings")

    @zone_settings.setter
    def zone_settings(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['HbaseInstanceZoneSettingArgs']]]]):
        pulumi.set(self, "zone_settings", value)


class HbaseInstance(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk_size: Optional[pulumi.Input[int]] = None,
                 disk_type: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 pay_mode: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceTagArgs']]]]] = None,
                 zone_settings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceZoneSettingArgs']]]]] = None,
                 __props__=None):
        """
        Provides a resource to create a emr lite_hbase_instance

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        lite_hbase_instance = tencentcloud.lite.HbaseInstance("liteHbaseInstance",
            disk_size=100,
            disk_type="CLOUD_HSSD",
            instance_name="tf-test",
            node_type="8C32G",
            pay_mode=0,
            tags=[tencentcloud.lite.HbaseInstanceTagArgs(
                tag_key="test",
                tag_value="test",
            )],
            zone_settings=[tencentcloud.lite.HbaseInstanceZoneSettingArgs(
                node_num=3,
                vpc_settings=tencentcloud.lite.HbaseInstanceZoneSettingVpcSettingsArgs(
                    subnet_id="subnet-xxxxxx",
                    vpc_id="vpc-xxxxxx",
                ),
                zone="ap-shanghai-2",
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        emr lite_hbase_instance can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Lite/hbaseInstance:HbaseInstance lite_hbase_instance lite_hbase_instance_id
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] disk_size: Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        :param pulumi.Input[str] disk_type: Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        :param pulumi.Input[str] instance_name: Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        :param pulumi.Input[str] node_type: Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        :param pulumi.Input[int] pay_mode: Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceTagArgs']]]] tags: List of tags to bind to the instance.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceZoneSettingArgs']]]] zone_settings: Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: HbaseInstanceArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a emr lite_hbase_instance

        ## Example Usage

        <!--Start PulumiCodeChooser -->
        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        lite_hbase_instance = tencentcloud.lite.HbaseInstance("liteHbaseInstance",
            disk_size=100,
            disk_type="CLOUD_HSSD",
            instance_name="tf-test",
            node_type="8C32G",
            pay_mode=0,
            tags=[tencentcloud.lite.HbaseInstanceTagArgs(
                tag_key="test",
                tag_value="test",
            )],
            zone_settings=[tencentcloud.lite.HbaseInstanceZoneSettingArgs(
                node_num=3,
                vpc_settings=tencentcloud.lite.HbaseInstanceZoneSettingVpcSettingsArgs(
                    subnet_id="subnet-xxxxxx",
                    vpc_id="vpc-xxxxxx",
                ),
                zone="ap-shanghai-2",
            )])
        ```
        <!--End PulumiCodeChooser -->

        ## Import

        emr lite_hbase_instance can be imported using the id, e.g.

        ```sh
        $ pulumi import tencentcloud:Lite/hbaseInstance:HbaseInstance lite_hbase_instance lite_hbase_instance_id
        ```

        :param str resource_name: The name of the resource.
        :param HbaseInstanceArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(HbaseInstanceArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 disk_size: Optional[pulumi.Input[int]] = None,
                 disk_type: Optional[pulumi.Input[str]] = None,
                 instance_name: Optional[pulumi.Input[str]] = None,
                 node_type: Optional[pulumi.Input[str]] = None,
                 pay_mode: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceTagArgs']]]]] = None,
                 zone_settings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceZoneSettingArgs']]]]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = HbaseInstanceArgs.__new__(HbaseInstanceArgs)

            if disk_size is None and not opts.urn:
                raise TypeError("Missing required property 'disk_size'")
            __props__.__dict__["disk_size"] = disk_size
            if disk_type is None and not opts.urn:
                raise TypeError("Missing required property 'disk_type'")
            __props__.__dict__["disk_type"] = disk_type
            if instance_name is None and not opts.urn:
                raise TypeError("Missing required property 'instance_name'")
            __props__.__dict__["instance_name"] = instance_name
            if node_type is None and not opts.urn:
                raise TypeError("Missing required property 'node_type'")
            __props__.__dict__["node_type"] = node_type
            if pay_mode is None and not opts.urn:
                raise TypeError("Missing required property 'pay_mode'")
            __props__.__dict__["pay_mode"] = pay_mode
            __props__.__dict__["tags"] = tags
            if zone_settings is None and not opts.urn:
                raise TypeError("Missing required property 'zone_settings'")
            __props__.__dict__["zone_settings"] = zone_settings
        super(HbaseInstance, __self__).__init__(
            'tencentcloud:Lite/hbaseInstance:HbaseInstance',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            disk_size: Optional[pulumi.Input[int]] = None,
            disk_type: Optional[pulumi.Input[str]] = None,
            instance_name: Optional[pulumi.Input[str]] = None,
            node_type: Optional[pulumi.Input[str]] = None,
            pay_mode: Optional[pulumi.Input[int]] = None,
            tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceTagArgs']]]]] = None,
            zone_settings: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceZoneSettingArgs']]]]] = None) -> 'HbaseInstance':
        """
        Get an existing HbaseInstance resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[int] disk_size: Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        :param pulumi.Input[str] disk_type: Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        :param pulumi.Input[str] instance_name: Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        :param pulumi.Input[str] node_type: Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        :param pulumi.Input[int] pay_mode: Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceTagArgs']]]] tags: List of tags to bind to the instance.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['HbaseInstanceZoneSettingArgs']]]] zone_settings: Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _HbaseInstanceState.__new__(_HbaseInstanceState)

        __props__.__dict__["disk_size"] = disk_size
        __props__.__dict__["disk_type"] = disk_type
        __props__.__dict__["instance_name"] = instance_name
        __props__.__dict__["node_type"] = node_type
        __props__.__dict__["pay_mode"] = pay_mode
        __props__.__dict__["tags"] = tags
        __props__.__dict__["zone_settings"] = zone_settings
        return HbaseInstance(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Output[int]:
        """
        Instance single-node disk capacity, in GB. The single-node disk capacity must be greater than or equal to 100 and less than or equal to 10000, with an adjustment step size of 20.
        """
        return pulumi.get(self, "disk_size")

    @property
    @pulumi.getter(name="diskType")
    def disk_type(self) -> pulumi.Output[str]:
        """
        Instance disk type, fill in CLOUD_HSSD to indicate performance cloud storage.
        """
        return pulumi.get(self, "disk_type")

    @property
    @pulumi.getter(name="instanceName")
    def instance_name(self) -> pulumi.Output[str]:
        """
        Instance name. Length limit is 6-36 characters. Only Chinese characters, letters, numbers, -, and _ are allowed.
        """
        return pulumi.get(self, "instance_name")

    @property
    @pulumi.getter(name="nodeType")
    def node_type(self) -> pulumi.Output[str]:
        """
        Instance node type, can be filled in as 4C16G, 8C32G, 16C64G, 32C128G, case insensitive.
        """
        return pulumi.get(self, "node_type")

    @property
    @pulumi.getter(name="payMode")
    def pay_mode(self) -> pulumi.Output[int]:
        """
        Instance pay mode. Value range: 0: indicates post pay mode, that is, pay-as-you-go.
        """
        return pulumi.get(self, "pay_mode")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.HbaseInstanceTag']]]:
        """
        List of tags to bind to the instance.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="zoneSettings")
    def zone_settings(self) -> pulumi.Output[Sequence['outputs.HbaseInstanceZoneSetting']]:
        """
        Detailed configuration of the instance availability zone, currently supports multiple availability zones, the number of availability zones can only be 1 or 3, including zone name, VPC information, and number of nodes. The total number of nodes across all zones must be greater than or equal to 3 and less than or equal to 50.
        """
        return pulumi.get(self, "zone_settings")
