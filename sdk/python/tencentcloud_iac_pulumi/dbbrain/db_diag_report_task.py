# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['DbDiagReportTaskArgs', 'DbDiagReportTask']

@pulumi.input_type
class DbDiagReportTaskArgs:
    def __init__(__self__, *,
                 end_time: pulumi.Input[str],
                 instance_id: pulumi.Input[str],
                 product: pulumi.Input[str],
                 send_mail_flag: pulumi.Input[int],
                 start_time: pulumi.Input[str],
                 contact_groups: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 contact_peoples: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None):
        """
        The set of arguments for constructing a DbDiagReportTask resource.
        :param pulumi.Input[str] end_time: End time, such as 2020-11-09T14:00:00+08:00.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[str] product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        :param pulumi.Input[int] send_mail_flag: Whether to send mail: 0 - no, 1 - yes.
        :param pulumi.Input[str] start_time: Start time, such as 2020-11-08T14:00:00+08:00.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_groups: An array of contact group IDs to receive mail from.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_peoples: An array of contact IDs to receive emails from.
        """
        pulumi.set(__self__, "end_time", end_time)
        pulumi.set(__self__, "instance_id", instance_id)
        pulumi.set(__self__, "product", product)
        pulumi.set(__self__, "send_mail_flag", send_mail_flag)
        pulumi.set(__self__, "start_time", start_time)
        if contact_groups is not None:
            pulumi.set(__self__, "contact_groups", contact_groups)
        if contact_peoples is not None:
            pulumi.set(__self__, "contact_peoples", contact_peoples)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> pulumi.Input[str]:
        """
        End time, such as 2020-11-09T14:00:00+08:00.
        """
        return pulumi.get(self, "end_time")

    @end_time.setter
    def end_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "end_time", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def product(self) -> pulumi.Input[str]:
        """
        Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        """
        return pulumi.get(self, "product")

    @product.setter
    def product(self, value: pulumi.Input[str]):
        pulumi.set(self, "product", value)

    @property
    @pulumi.getter(name="sendMailFlag")
    def send_mail_flag(self) -> pulumi.Input[int]:
        """
        Whether to send mail: 0 - no, 1 - yes.
        """
        return pulumi.get(self, "send_mail_flag")

    @send_mail_flag.setter
    def send_mail_flag(self, value: pulumi.Input[int]):
        pulumi.set(self, "send_mail_flag", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Input[str]:
        """
        Start time, such as 2020-11-08T14:00:00+08:00.
        """
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "start_time", value)

    @property
    @pulumi.getter(name="contactGroups")
    def contact_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        An array of contact group IDs to receive mail from.
        """
        return pulumi.get(self, "contact_groups")

    @contact_groups.setter
    def contact_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "contact_groups", value)

    @property
    @pulumi.getter(name="contactPeoples")
    def contact_peoples(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        An array of contact IDs to receive emails from.
        """
        return pulumi.get(self, "contact_peoples")

    @contact_peoples.setter
    def contact_peoples(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "contact_peoples", value)


@pulumi.input_type
class _DbDiagReportTaskState:
    def __init__(__self__, *,
                 contact_groups: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 contact_peoples: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 product: Optional[pulumi.Input[str]] = None,
                 send_mail_flag: Optional[pulumi.Input[int]] = None,
                 start_time: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DbDiagReportTask resources.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_groups: An array of contact group IDs to receive mail from.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_peoples: An array of contact IDs to receive emails from.
        :param pulumi.Input[str] end_time: End time, such as 2020-11-09T14:00:00+08:00.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[str] product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        :param pulumi.Input[int] send_mail_flag: Whether to send mail: 0 - no, 1 - yes.
        :param pulumi.Input[str] start_time: Start time, such as 2020-11-08T14:00:00+08:00.
        """
        if contact_groups is not None:
            pulumi.set(__self__, "contact_groups", contact_groups)
        if contact_peoples is not None:
            pulumi.set(__self__, "contact_peoples", contact_peoples)
        if end_time is not None:
            pulumi.set(__self__, "end_time", end_time)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if product is not None:
            pulumi.set(__self__, "product", product)
        if send_mail_flag is not None:
            pulumi.set(__self__, "send_mail_flag", send_mail_flag)
        if start_time is not None:
            pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter(name="contactGroups")
    def contact_groups(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        An array of contact group IDs to receive mail from.
        """
        return pulumi.get(self, "contact_groups")

    @contact_groups.setter
    def contact_groups(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "contact_groups", value)

    @property
    @pulumi.getter(name="contactPeoples")
    def contact_peoples(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]:
        """
        An array of contact IDs to receive emails from.
        """
        return pulumi.get(self, "contact_peoples")

    @contact_peoples.setter
    def contact_peoples(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]]):
        pulumi.set(self, "contact_peoples", value)

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> Optional[pulumi.Input[str]]:
        """
        End time, such as 2020-11-09T14:00:00+08:00.
        """
        return pulumi.get(self, "end_time")

    @end_time.setter
    def end_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "end_time", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def product(self) -> Optional[pulumi.Input[str]]:
        """
        Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        """
        return pulumi.get(self, "product")

    @product.setter
    def product(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "product", value)

    @property
    @pulumi.getter(name="sendMailFlag")
    def send_mail_flag(self) -> Optional[pulumi.Input[int]]:
        """
        Whether to send mail: 0 - no, 1 - yes.
        """
        return pulumi.get(self, "send_mail_flag")

    @send_mail_flag.setter
    def send_mail_flag(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "send_mail_flag", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> Optional[pulumi.Input[str]]:
        """
        Start time, such as 2020-11-08T14:00:00+08:00.
        """
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "start_time", value)


class DbDiagReportTask(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 contact_groups: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 contact_peoples: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 product: Optional[pulumi.Input[str]] = None,
                 send_mail_flag: Optional[pulumi.Input[int]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Provides a resource to create a dbbrain db_diag_report_task

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        db_diag_report_task = tencentcloud.dbbrain.DbDiagReportTask("dbDiagReportTask",
            end_time="%s",
            instance_id="%s",
            product="mysql",
            send_mail_flag=0,
            start_time="%s")
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_groups: An array of contact group IDs to receive mail from.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_peoples: An array of contact IDs to receive emails from.
        :param pulumi.Input[str] end_time: End time, such as 2020-11-09T14:00:00+08:00.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[str] product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        :param pulumi.Input[int] send_mail_flag: Whether to send mail: 0 - no, 1 - yes.
        :param pulumi.Input[str] start_time: Start time, such as 2020-11-08T14:00:00+08:00.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DbDiagReportTaskArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Provides a resource to create a dbbrain db_diag_report_task

        ## Example Usage

        ```python
        import pulumi
        import tencentcloud_iac_pulumi as tencentcloud

        db_diag_report_task = tencentcloud.dbbrain.DbDiagReportTask("dbDiagReportTask",
            end_time="%s",
            instance_id="%s",
            product="mysql",
            send_mail_flag=0,
            start_time="%s")
        ```

        :param str resource_name: The name of the resource.
        :param DbDiagReportTaskArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DbDiagReportTaskArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 contact_groups: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 contact_peoples: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
                 end_time: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 product: Optional[pulumi.Input[str]] = None,
                 send_mail_flag: Optional[pulumi.Input[int]] = None,
                 start_time: Optional[pulumi.Input[str]] = None,
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
            __props__ = DbDiagReportTaskArgs.__new__(DbDiagReportTaskArgs)

            __props__.__dict__["contact_groups"] = contact_groups
            __props__.__dict__["contact_peoples"] = contact_peoples
            if end_time is None and not opts.urn:
                raise TypeError("Missing required property 'end_time'")
            __props__.__dict__["end_time"] = end_time
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
            if product is None and not opts.urn:
                raise TypeError("Missing required property 'product'")
            __props__.__dict__["product"] = product
            if send_mail_flag is None and not opts.urn:
                raise TypeError("Missing required property 'send_mail_flag'")
            __props__.__dict__["send_mail_flag"] = send_mail_flag
            if start_time is None and not opts.urn:
                raise TypeError("Missing required property 'start_time'")
            __props__.__dict__["start_time"] = start_time
        super(DbDiagReportTask, __self__).__init__(
            'tencentcloud:Dbbrain/dbDiagReportTask:DbDiagReportTask',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            contact_groups: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            contact_peoples: Optional[pulumi.Input[Sequence[pulumi.Input[int]]]] = None,
            end_time: Optional[pulumi.Input[str]] = None,
            instance_id: Optional[pulumi.Input[str]] = None,
            product: Optional[pulumi.Input[str]] = None,
            send_mail_flag: Optional[pulumi.Input[int]] = None,
            start_time: Optional[pulumi.Input[str]] = None) -> 'DbDiagReportTask':
        """
        Get an existing DbDiagReportTask resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_groups: An array of contact group IDs to receive mail from.
        :param pulumi.Input[Sequence[pulumi.Input[int]]] contact_peoples: An array of contact IDs to receive emails from.
        :param pulumi.Input[str] end_time: End time, such as 2020-11-09T14:00:00+08:00.
        :param pulumi.Input[str] instance_id: instance id.
        :param pulumi.Input[str] product: Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        :param pulumi.Input[int] send_mail_flag: Whether to send mail: 0 - no, 1 - yes.
        :param pulumi.Input[str] start_time: Start time, such as 2020-11-08T14:00:00+08:00.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DbDiagReportTaskState.__new__(_DbDiagReportTaskState)

        __props__.__dict__["contact_groups"] = contact_groups
        __props__.__dict__["contact_peoples"] = contact_peoples
        __props__.__dict__["end_time"] = end_time
        __props__.__dict__["instance_id"] = instance_id
        __props__.__dict__["product"] = product
        __props__.__dict__["send_mail_flag"] = send_mail_flag
        __props__.__dict__["start_time"] = start_time
        return DbDiagReportTask(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="contactGroups")
    def contact_groups(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        An array of contact group IDs to receive mail from.
        """
        return pulumi.get(self, "contact_groups")

    @property
    @pulumi.getter(name="contactPeoples")
    def contact_peoples(self) -> pulumi.Output[Optional[Sequence[int]]]:
        """
        An array of contact IDs to receive emails from.
        """
        return pulumi.get(self, "contact_peoples")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> pulumi.Output[str]:
        """
        End time, such as 2020-11-09T14:00:00+08:00.
        """
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        instance id.
        """
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter
    def product(self) -> pulumi.Output[str]:
        """
        Service product type, supported values include: mysql - cloud database MySQL, cynosdb - cloud database CynosDB for MySQL.
        """
        return pulumi.get(self, "product")

    @property
    @pulumi.getter(name="sendMailFlag")
    def send_mail_flag(self) -> pulumi.Output[int]:
        """
        Whether to send mail: 0 - no, 1 - yes.
        """
        return pulumi.get(self, "send_mail_flag")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Output[str]:
        """
        Start time, such as 2020-11-08T14:00:00+08:00.
        """
        return pulumi.get(self, "start_time")
